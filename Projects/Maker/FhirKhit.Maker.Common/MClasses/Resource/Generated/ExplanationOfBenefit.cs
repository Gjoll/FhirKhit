using System;                                                                                                                               // MakerGen.cs:391
using System.Diagnostics;                                                                                                                   // MakerGen.cs:392
using System.IO;                                                                                                                            // MakerGen.cs:393
using System.Linq;                                                                                                                          // MakerGen.cs:394
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:396
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:397
{                                                                                                                                           // MakerGen.cs:398
    #region Json                                                                                                                            // MakerGen.cs:399
    #if NEVER                                                                                                                               // MakerGen.cs:400
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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'ExplanationOfBenefit'
    /// </summary>
    // 0. ExplanationOfBenefit
    public class ExplanationOfBenefit : FhirKhit.Maker.Common.Resource.ResourceBase                                                         // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 15. ExplanationOfBenefit.related
        public class Type_Related : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 16. ExplanationOfBenefit.related.claim
            public MakerElementInstance Element_Claim;                                                                                      // MakerGen.cs:232
            // 17. ExplanationOfBenefit.related.relationship
            public MakerElementInstance Element_Relationship;                                                                               // MakerGen.cs:232
            // 18. ExplanationOfBenefit.related.reference
            public MakerElementInstance Element_Reference;                                                                                  // MakerGen.cs:232
            public Type_Related()                                                                                                           // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 16. ExplanationOfBenefit.related.claim
                    this.Element_Claim = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Claim",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 17. ExplanationOfBenefit.related.relationship
                    this.Element_Relationship = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Relationship",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 18. ExplanationOfBenefit.related.reference
                    this.Element_Reference = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Reference",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 21. ExplanationOfBenefit.payee
        public class Type_Payee : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 22. ExplanationOfBenefit.payee.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 23. ExplanationOfBenefit.payee.party
            public MakerElementInstance Element_Party;                                                                                      // MakerGen.cs:232
            public Type_Payee()                                                                                                             // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 22. ExplanationOfBenefit.payee.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 23. ExplanationOfBenefit.payee.party
                    this.Element_Party = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Party",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 32. ExplanationOfBenefit.careTeam
        public class Type_CareTeam : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 33. ExplanationOfBenefit.careTeam.sequence
            public MakerElementInstance Element_Sequence;                                                                                   // MakerGen.cs:232
            // 34. ExplanationOfBenefit.careTeam.provider
            public MakerElementInstance Element_Provider;                                                                                   // MakerGen.cs:232
            // 35. ExplanationOfBenefit.careTeam.responsible
            public MakerElementInstance Element_Responsible;                                                                                // MakerGen.cs:232
            // 36. ExplanationOfBenefit.careTeam.role
            public MakerElementInstance Element_Role;                                                                                       // MakerGen.cs:232
            // 37. ExplanationOfBenefit.careTeam.qualification
            public MakerElementInstance Element_Qualification;                                                                              // MakerGen.cs:232
            public Type_CareTeam()                                                                                                          // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 33. ExplanationOfBenefit.careTeam.sequence
                    this.Element_Sequence = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Sequence",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 34. ExplanationOfBenefit.careTeam.provider
                    this.Element_Provider = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Provider",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 35. ExplanationOfBenefit.careTeam.responsible
                    this.Element_Responsible = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Responsible",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 36. ExplanationOfBenefit.careTeam.role
                    this.Element_Role = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Role",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 37. ExplanationOfBenefit.careTeam.qualification
                    this.Element_Qualification = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Qualification",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 38. ExplanationOfBenefit.supportingInfo
        public class Type_SupportingInfo : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 39. ExplanationOfBenefit.supportingInfo.sequence
            public MakerElementInstance Element_Sequence;                                                                                   // MakerGen.cs:232
            // 40. ExplanationOfBenefit.supportingInfo.category
            public MakerElementInstance Element_Category;                                                                                   // MakerGen.cs:232
            // 41. ExplanationOfBenefit.supportingInfo.code
            public MakerElementInstance Element_Code;                                                                                       // MakerGen.cs:232
            // 42. ExplanationOfBenefit.supportingInfo.timing[x]
            public MakerElementInstance Element_Timing;                                                                                     // MakerGen.cs:232
            // 43. ExplanationOfBenefit.supportingInfo.value[x]
            public MakerElementInstance Element_Value;                                                                                      // MakerGen.cs:232
            // 44. ExplanationOfBenefit.supportingInfo.reason
            public MakerElementInstance Element_Reason;                                                                                     // MakerGen.cs:232
            public Type_SupportingInfo()                                                                                                    // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 39. ExplanationOfBenefit.supportingInfo.sequence
                    this.Element_Sequence = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Sequence",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 40. ExplanationOfBenefit.supportingInfo.category
                    this.Element_Category = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Category",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 41. ExplanationOfBenefit.supportingInfo.code
                    this.Element_Code = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Code",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 42. ExplanationOfBenefit.supportingInfo.timing[x]
                    this.Element_Timing = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Timing",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Date(),                                                                     // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 43. ExplanationOfBenefit.supportingInfo.value[x]
                    this.Element_Value = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Value",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean(),                                                                  // MakerGen.cs:286
                            new FhirKhit.Maker.Common.Primitive.String(),                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 44. ExplanationOfBenefit.supportingInfo.reason
                    this.Element_Reason = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Reason",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Coding()                                                                      // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 45. ExplanationOfBenefit.diagnosis
        public class Type_Diagnosis : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 46. ExplanationOfBenefit.diagnosis.sequence
            public MakerElementInstance Element_Sequence;                                                                                   // MakerGen.cs:232
            // 47. ExplanationOfBenefit.diagnosis.diagnosis[x]
            public MakerElementInstance Element_Diagnosis;                                                                                  // MakerGen.cs:232
            // 48. ExplanationOfBenefit.diagnosis.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 49. ExplanationOfBenefit.diagnosis.onAdmission
            public MakerElementInstance Element_OnAdmission;                                                                                // MakerGen.cs:232
            // 50. ExplanationOfBenefit.diagnosis.packageCode
            public MakerElementInstance Element_PackageCode;                                                                                // MakerGen.cs:232
            public Type_Diagnosis()                                                                                                         // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 46. ExplanationOfBenefit.diagnosis.sequence
                    this.Element_Sequence = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Sequence",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 47. ExplanationOfBenefit.diagnosis.diagnosis[x]
                    this.Element_Diagnosis = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Diagnosis",                                                                                         // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept(),                                                            // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 48. ExplanationOfBenefit.diagnosis.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 49. ExplanationOfBenefit.diagnosis.onAdmission
                    this.Element_OnAdmission = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_OnAdmission",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 50. ExplanationOfBenefit.diagnosis.packageCode
                    this.Element_PackageCode = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_PackageCode",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 51. ExplanationOfBenefit.procedure
        public class Type_Procedure : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 52. ExplanationOfBenefit.procedure.sequence
            public MakerElementInstance Element_Sequence;                                                                                   // MakerGen.cs:232
            // 53. ExplanationOfBenefit.procedure.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 54. ExplanationOfBenefit.procedure.date
            public MakerElementInstance Element_Date;                                                                                       // MakerGen.cs:232
            // 55. ExplanationOfBenefit.procedure.procedure[x]
            public MakerElementInstance Element_Procedure;                                                                                  // MakerGen.cs:232
            // 56. ExplanationOfBenefit.procedure.udi
            public MakerElementInstance Element_Udi;                                                                                        // MakerGen.cs:232
            public Type_Procedure()                                                                                                         // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 52. ExplanationOfBenefit.procedure.sequence
                    this.Element_Sequence = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Sequence",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 53. ExplanationOfBenefit.procedure.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 54. ExplanationOfBenefit.procedure.date
                    this.Element_Date = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Date",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 55. ExplanationOfBenefit.procedure.procedure[x]
                    this.Element_Procedure = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Procedure",                                                                                         // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept(),                                                            // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 56. ExplanationOfBenefit.procedure.udi
                    this.Element_Udi = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Udi",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 58. ExplanationOfBenefit.insurance
        public class Type_Insurance : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 59. ExplanationOfBenefit.insurance.focal
            public MakerElementInstance Element_Focal;                                                                                      // MakerGen.cs:232
            // 60. ExplanationOfBenefit.insurance.coverage
            public MakerElementInstance Element_Coverage;                                                                                   // MakerGen.cs:232
            // 61. ExplanationOfBenefit.insurance.preAuthRef
            public MakerElementInstance Element_PreAuthRef;                                                                                 // MakerGen.cs:232
            public Type_Insurance()                                                                                                         // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 59. ExplanationOfBenefit.insurance.focal
                    this.Element_Focal = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Focal",                                                                                             // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 60. ExplanationOfBenefit.insurance.coverage
                    this.Element_Coverage = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Coverage",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 61. ExplanationOfBenefit.insurance.preAuthRef
                    this.Element_PreAuthRef = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_PreAuthRef",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 62. ExplanationOfBenefit.accident
        public class Type_Accident : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 63. ExplanationOfBenefit.accident.date
            public MakerElementInstance Element_Date;                                                                                       // MakerGen.cs:232
            // 64. ExplanationOfBenefit.accident.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 65. ExplanationOfBenefit.accident.location[x]
            public MakerElementInstance Element_Location;                                                                                   // MakerGen.cs:232
            public Type_Accident()                                                                                                          // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 63. ExplanationOfBenefit.accident.date
                    this.Element_Date = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Date",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Date()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 64. ExplanationOfBenefit.accident.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 65. ExplanationOfBenefit.accident.location[x]
                    this.Element_Location = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Location",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 66. ExplanationOfBenefit.item
        public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 88. ExplanationOfBenefit.item.adjudication
            public class Type_Adjudication : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 89. ExplanationOfBenefit.item.adjudication.category
                public MakerElementInstance Element_Category;                                                                               // MakerGen.cs:232
                // 90. ExplanationOfBenefit.item.adjudication.reason
                public MakerElementInstance Element_Reason;                                                                                 // MakerGen.cs:232
                // 91. ExplanationOfBenefit.item.adjudication.amount
                public MakerElementInstance Element_Amount;                                                                                 // MakerGen.cs:232
                // 92. ExplanationOfBenefit.item.adjudication.value
                public MakerElementInstance Element_Value;                                                                                  // MakerGen.cs:232
                public Type_Adjudication()                                                                                                  // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 89. ExplanationOfBenefit.item.adjudication.category
                        this.Element_Category = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Category",                                                                                      // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 90. ExplanationOfBenefit.item.adjudication.reason
                        this.Element_Reason = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Reason",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 91. ExplanationOfBenefit.item.adjudication.amount
                        this.Element_Amount = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Amount",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 92. ExplanationOfBenefit.item.adjudication.value
                        this.Element_Value = new MakerElementInstance                                                                       // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Value",                                                                                         // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Decimal()                                                               // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 93. ExplanationOfBenefit.item.detail
            public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 107. ExplanationOfBenefit.item.detail.subDetail
                public class Type_SubDetail : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 108. ExplanationOfBenefit.item.detail.subDetail.sequence
                    public MakerElementInstance Element_Sequence;                                                                           // MakerGen.cs:232
                    // 109. ExplanationOfBenefit.item.detail.subDetail.revenue
                    public MakerElementInstance Element_Revenue;                                                                            // MakerGen.cs:232
                    // 110. ExplanationOfBenefit.item.detail.subDetail.category
                    public MakerElementInstance Element_Category;                                                                           // MakerGen.cs:232
                    // 111. ExplanationOfBenefit.item.detail.subDetail.productOrService
                    public MakerElementInstance Element_ProductOrService;                                                                   // MakerGen.cs:232
                    // 112. ExplanationOfBenefit.item.detail.subDetail.modifier
                    public MakerElementInstance Element_Modifier;                                                                           // MakerGen.cs:232
                    // 113. ExplanationOfBenefit.item.detail.subDetail.programCode
                    public MakerElementInstance Element_ProgramCode;                                                                        // MakerGen.cs:232
                    // 114. ExplanationOfBenefit.item.detail.subDetail.quantity
                    public MakerElementInstance Element_Quantity;                                                                           // MakerGen.cs:232
                    // 115. ExplanationOfBenefit.item.detail.subDetail.unitPrice
                    public MakerElementInstance Element_UnitPrice;                                                                          // MakerGen.cs:232
                    // 116. ExplanationOfBenefit.item.detail.subDetail.factor
                    public MakerElementInstance Element_Factor;                                                                             // MakerGen.cs:232
                    // 117. ExplanationOfBenefit.item.detail.subDetail.net
                    public MakerElementInstance Element_Net;                                                                                // MakerGen.cs:232
                    // 118. ExplanationOfBenefit.item.detail.subDetail.udi
                    public MakerElementInstance Element_Udi;                                                                                // MakerGen.cs:232
                    // 119. ExplanationOfBenefit.item.detail.subDetail.noteNumber
                    public MakerElementInstance Element_NoteNumber;                                                                         // MakerGen.cs:232
                    // 120. ExplanationOfBenefit.item.detail.subDetail.adjudication
                    public MakerElementInstance Element_Adjudication;                                                                       // MakerGen.cs:232
                    public Type_SubDetail()                                                                                                 // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 108. ExplanationOfBenefit.item.detail.subDetail.sequence
                            this.Element_Sequence = new MakerElementInstance                                                                // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Sequence",                                                                                  // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                       // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 109. ExplanationOfBenefit.item.detail.subDetail.revenue
                            this.Element_Revenue = new MakerElementInstance                                                                 // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Revenue",                                                                                   // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                     // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 110. ExplanationOfBenefit.item.detail.subDetail.category
                            this.Element_Category = new MakerElementInstance                                                                // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Category",                                                                                  // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                     // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 111. ExplanationOfBenefit.item.detail.subDetail.productOrService
                            this.Element_ProductOrService = new MakerElementInstance                                                        // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_ProductOrService",                                                                          // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                     // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 112. ExplanationOfBenefit.item.detail.subDetail.modifier
                            this.Element_Modifier = new MakerElementInstance                                                                // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Modifier",                                                                                  // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                     // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 113. ExplanationOfBenefit.item.detail.subDetail.programCode
                            this.Element_ProgramCode = new MakerElementInstance                                                             // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_ProgramCode",                                                                               // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                     // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 114. ExplanationOfBenefit.item.detail.subDetail.quantity
                            this.Element_Quantity = new MakerElementInstance                                                                // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Quantity",                                                                                  // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 115. ExplanationOfBenefit.item.detail.subDetail.unitPrice
                            this.Element_UnitPrice = new MakerElementInstance                                                               // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_UnitPrice",                                                                                 // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 116. ExplanationOfBenefit.item.detail.subDetail.factor
                            this.Element_Factor = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Factor",                                                                                    // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Decimal()                                                           // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 117. ExplanationOfBenefit.item.detail.subDetail.net
                            this.Element_Net = new MakerElementInstance                                                                     // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Net",                                                                                       // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 118. ExplanationOfBenefit.item.detail.subDetail.udi
                            this.Element_Udi = new MakerElementInstance                                                                     // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Udi",                                                                                       // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 119. ExplanationOfBenefit.item.detail.subDetail.noteNumber
                            this.Element_NoteNumber = new MakerElementInstance                                                              // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_NoteNumber",                                                                                // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                       // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 120. ExplanationOfBenefit.item.detail.subDetail.adjudication
                            this.Element_Adjudication = new MakerElementInstance                                                            // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Adjudication",                                                                              // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                // 94. ExplanationOfBenefit.item.detail.sequence
                public MakerElementInstance Element_Sequence;                                                                               // MakerGen.cs:232
                // 95. ExplanationOfBenefit.item.detail.revenue
                public MakerElementInstance Element_Revenue;                                                                                // MakerGen.cs:232
                // 96. ExplanationOfBenefit.item.detail.category
                public MakerElementInstance Element_Category;                                                                               // MakerGen.cs:232
                // 97. ExplanationOfBenefit.item.detail.productOrService
                public MakerElementInstance Element_ProductOrService;                                                                       // MakerGen.cs:232
                // 98. ExplanationOfBenefit.item.detail.modifier
                public MakerElementInstance Element_Modifier;                                                                               // MakerGen.cs:232
                // 99. ExplanationOfBenefit.item.detail.programCode
                public MakerElementInstance Element_ProgramCode;                                                                            // MakerGen.cs:232
                // 100. ExplanationOfBenefit.item.detail.quantity
                public MakerElementInstance Element_Quantity;                                                                               // MakerGen.cs:232
                // 101. ExplanationOfBenefit.item.detail.unitPrice
                public MakerElementInstance Element_UnitPrice;                                                                              // MakerGen.cs:232
                // 102. ExplanationOfBenefit.item.detail.factor
                public MakerElementInstance Element_Factor;                                                                                 // MakerGen.cs:232
                // 103. ExplanationOfBenefit.item.detail.net
                public MakerElementInstance Element_Net;                                                                                    // MakerGen.cs:232
                // 104. ExplanationOfBenefit.item.detail.udi
                public MakerElementInstance Element_Udi;                                                                                    // MakerGen.cs:232
                // 105. ExplanationOfBenefit.item.detail.noteNumber
                public MakerElementInstance Element_NoteNumber;                                                                             // MakerGen.cs:232
                // 106. ExplanationOfBenefit.item.detail.adjudication
                public MakerElementInstance Element_Adjudication;                                                                           // MakerGen.cs:232
                public Type_Detail()                                                                                                        // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 94. ExplanationOfBenefit.item.detail.sequence
                        this.Element_Sequence = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Sequence",                                                                                      // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                           // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 95. ExplanationOfBenefit.item.detail.revenue
                        this.Element_Revenue = new MakerElementInstance                                                                     // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Revenue",                                                                                       // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 96. ExplanationOfBenefit.item.detail.category
                        this.Element_Category = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Category",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 97. ExplanationOfBenefit.item.detail.productOrService
                        this.Element_ProductOrService = new MakerElementInstance                                                            // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ProductOrService",                                                                              // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 98. ExplanationOfBenefit.item.detail.modifier
                        this.Element_Modifier = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Modifier",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 99. ExplanationOfBenefit.item.detail.programCode
                        this.Element_ProgramCode = new MakerElementInstance                                                                 // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ProgramCode",                                                                                   // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 100. ExplanationOfBenefit.item.detail.quantity
                        this.Element_Quantity = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Quantity",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 101. ExplanationOfBenefit.item.detail.unitPrice
                        this.Element_UnitPrice = new MakerElementInstance                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_UnitPrice",                                                                                     // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 102. ExplanationOfBenefit.item.detail.factor
                        this.Element_Factor = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Factor",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Decimal()                                                               // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 103. ExplanationOfBenefit.item.detail.net
                        this.Element_Net = new MakerElementInstance                                                                         // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Net",                                                                                           // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 104. ExplanationOfBenefit.item.detail.udi
                        this.Element_Udi = new MakerElementInstance                                                                         // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Udi",                                                                                           // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 105. ExplanationOfBenefit.item.detail.noteNumber
                        this.Element_NoteNumber = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_NoteNumber",                                                                                    // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                           // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 106. ExplanationOfBenefit.item.detail.adjudication
                        this.Element_Adjudication = new MakerElementInstance                                                                // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Adjudication",                                                                                  // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 67. ExplanationOfBenefit.item.sequence
            public MakerElementInstance Element_Sequence;                                                                                   // MakerGen.cs:232
            // 68. ExplanationOfBenefit.item.careTeamSequence
            public MakerElementInstance Element_CareTeamSequence;                                                                           // MakerGen.cs:232
            // 69. ExplanationOfBenefit.item.diagnosisSequence
            public MakerElementInstance Element_DiagnosisSequence;                                                                          // MakerGen.cs:232
            // 70. ExplanationOfBenefit.item.procedureSequence
            public MakerElementInstance Element_ProcedureSequence;                                                                          // MakerGen.cs:232
            // 71. ExplanationOfBenefit.item.informationSequence
            public MakerElementInstance Element_InformationSequence;                                                                        // MakerGen.cs:232
            // 72. ExplanationOfBenefit.item.revenue
            public MakerElementInstance Element_Revenue;                                                                                    // MakerGen.cs:232
            // 73. ExplanationOfBenefit.item.category
            public MakerElementInstance Element_Category;                                                                                   // MakerGen.cs:232
            // 74. ExplanationOfBenefit.item.productOrService
            public MakerElementInstance Element_ProductOrService;                                                                           // MakerGen.cs:232
            // 75. ExplanationOfBenefit.item.modifier
            public MakerElementInstance Element_Modifier;                                                                                   // MakerGen.cs:232
            // 76. ExplanationOfBenefit.item.programCode
            public MakerElementInstance Element_ProgramCode;                                                                                // MakerGen.cs:232
            // 77. ExplanationOfBenefit.item.serviced[x]
            public MakerElementInstance Element_Serviced;                                                                                   // MakerGen.cs:232
            // 78. ExplanationOfBenefit.item.location[x]
            public MakerElementInstance Element_Location;                                                                                   // MakerGen.cs:232
            // 79. ExplanationOfBenefit.item.quantity
            public MakerElementInstance Element_Quantity;                                                                                   // MakerGen.cs:232
            // 80. ExplanationOfBenefit.item.unitPrice
            public MakerElementInstance Element_UnitPrice;                                                                                  // MakerGen.cs:232
            // 81. ExplanationOfBenefit.item.factor
            public MakerElementInstance Element_Factor;                                                                                     // MakerGen.cs:232
            // 82. ExplanationOfBenefit.item.net
            public MakerElementInstance Element_Net;                                                                                        // MakerGen.cs:232
            // 83. ExplanationOfBenefit.item.udi
            public MakerElementInstance Element_Udi;                                                                                        // MakerGen.cs:232
            // 84. ExplanationOfBenefit.item.bodySite
            public MakerElementInstance Element_BodySite;                                                                                   // MakerGen.cs:232
            // 85. ExplanationOfBenefit.item.subSite
            public MakerElementInstance Element_SubSite;                                                                                    // MakerGen.cs:232
            // 86. ExplanationOfBenefit.item.encounter
            public MakerElementInstance Element_Encounter;                                                                                  // MakerGen.cs:232
            // 87. ExplanationOfBenefit.item.noteNumber
            public MakerElementInstance Element_NoteNumber;                                                                                 // MakerGen.cs:232
            public Type_Item()                                                                                                              // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 67. ExplanationOfBenefit.item.sequence
                    this.Element_Sequence = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Sequence",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 68. ExplanationOfBenefit.item.careTeamSequence
                    this.Element_CareTeamSequence = new MakerElementInstance                                                                // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_CareTeamSequence",                                                                                  // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 69. ExplanationOfBenefit.item.diagnosisSequence
                    this.Element_DiagnosisSequence = new MakerElementInstance                                                               // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DiagnosisSequence",                                                                                 // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 70. ExplanationOfBenefit.item.procedureSequence
                    this.Element_ProcedureSequence = new MakerElementInstance                                                               // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ProcedureSequence",                                                                                 // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 71. ExplanationOfBenefit.item.informationSequence
                    this.Element_InformationSequence = new MakerElementInstance                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_InformationSequence",                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 72. ExplanationOfBenefit.item.revenue
                    this.Element_Revenue = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Revenue",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 73. ExplanationOfBenefit.item.category
                    this.Element_Category = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Category",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 74. ExplanationOfBenefit.item.productOrService
                    this.Element_ProductOrService = new MakerElementInstance                                                                // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ProductOrService",                                                                                  // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 75. ExplanationOfBenefit.item.modifier
                    this.Element_Modifier = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Modifier",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 76. ExplanationOfBenefit.item.programCode
                    this.Element_ProgramCode = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ProgramCode",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 77. ExplanationOfBenefit.item.serviced[x]
                    this.Element_Serviced = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Serviced",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Date(),                                                                     // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 78. ExplanationOfBenefit.item.location[x]
                    this.Element_Location = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Location",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept(),                                                            // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 79. ExplanationOfBenefit.item.quantity
                    this.Element_Quantity = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Quantity",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 80. ExplanationOfBenefit.item.unitPrice
                    this.Element_UnitPrice = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_UnitPrice",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 81. ExplanationOfBenefit.item.factor
                    this.Element_Factor = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Factor",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 82. ExplanationOfBenefit.item.net
                    this.Element_Net = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Net",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 83. ExplanationOfBenefit.item.udi
                    this.Element_Udi = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Udi",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 84. ExplanationOfBenefit.item.bodySite
                    this.Element_BodySite = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_BodySite",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 85. ExplanationOfBenefit.item.subSite
                    this.Element_SubSite = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SubSite",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 86. ExplanationOfBenefit.item.encounter
                    this.Element_Encounter = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Encounter",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 87. ExplanationOfBenefit.item.noteNumber
                    this.Element_NoteNumber = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_NoteNumber",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 121. ExplanationOfBenefit.addItem
        public class Type_AddItem : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 139. ExplanationOfBenefit.addItem.detail
            public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 148. ExplanationOfBenefit.addItem.detail.subDetail
                public class Type_SubDetail : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 149. ExplanationOfBenefit.addItem.detail.subDetail.productOrService
                    public MakerElementInstance Element_ProductOrService;                                                                   // MakerGen.cs:232
                    // 150. ExplanationOfBenefit.addItem.detail.subDetail.modifier
                    public MakerElementInstance Element_Modifier;                                                                           // MakerGen.cs:232
                    // 151. ExplanationOfBenefit.addItem.detail.subDetail.quantity
                    public MakerElementInstance Element_Quantity;                                                                           // MakerGen.cs:232
                    // 152. ExplanationOfBenefit.addItem.detail.subDetail.unitPrice
                    public MakerElementInstance Element_UnitPrice;                                                                          // MakerGen.cs:232
                    // 153. ExplanationOfBenefit.addItem.detail.subDetail.factor
                    public MakerElementInstance Element_Factor;                                                                             // MakerGen.cs:232
                    // 154. ExplanationOfBenefit.addItem.detail.subDetail.net
                    public MakerElementInstance Element_Net;                                                                                // MakerGen.cs:232
                    // 155. ExplanationOfBenefit.addItem.detail.subDetail.noteNumber
                    public MakerElementInstance Element_NoteNumber;                                                                         // MakerGen.cs:232
                    // 156. ExplanationOfBenefit.addItem.detail.subDetail.adjudication
                    public MakerElementInstance Element_Adjudication;                                                                       // MakerGen.cs:232
                    public Type_SubDetail()                                                                                                 // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 149. ExplanationOfBenefit.addItem.detail.subDetail.productOrService
                            this.Element_ProductOrService = new MakerElementInstance                                                        // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_ProductOrService",                                                                          // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                     // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 150. ExplanationOfBenefit.addItem.detail.subDetail.modifier
                            this.Element_Modifier = new MakerElementInstance                                                                // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Modifier",                                                                                  // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                     // MakerGen.cs:292
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 151. ExplanationOfBenefit.addItem.detail.subDetail.quantity
                            this.Element_Quantity = new MakerElementInstance                                                                // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Quantity",                                                                                  // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 152. ExplanationOfBenefit.addItem.detail.subDetail.unitPrice
                            this.Element_UnitPrice = new MakerElementInstance                                                               // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_UnitPrice",                                                                                 // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 153. ExplanationOfBenefit.addItem.detail.subDetail.factor
                            this.Element_Factor = new MakerElementInstance                                                                  // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Factor",                                                                                    // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Decimal()                                                           // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 154. ExplanationOfBenefit.addItem.detail.subDetail.net
                            this.Element_Net = new MakerElementInstance                                                                     // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Net",                                                                                       // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 155. ExplanationOfBenefit.addItem.detail.subDetail.noteNumber
                            this.Element_NoteNumber = new MakerElementInstance                                                              // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_NoteNumber",                                                                                // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                       // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 156. ExplanationOfBenefit.addItem.detail.subDetail.adjudication
                            this.Element_Adjudication = new MakerElementInstance                                                            // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Adjudication",                                                                              // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                // 140. ExplanationOfBenefit.addItem.detail.productOrService
                public MakerElementInstance Element_ProductOrService;                                                                       // MakerGen.cs:232
                // 141. ExplanationOfBenefit.addItem.detail.modifier
                public MakerElementInstance Element_Modifier;                                                                               // MakerGen.cs:232
                // 142. ExplanationOfBenefit.addItem.detail.quantity
                public MakerElementInstance Element_Quantity;                                                                               // MakerGen.cs:232
                // 143. ExplanationOfBenefit.addItem.detail.unitPrice
                public MakerElementInstance Element_UnitPrice;                                                                              // MakerGen.cs:232
                // 144. ExplanationOfBenefit.addItem.detail.factor
                public MakerElementInstance Element_Factor;                                                                                 // MakerGen.cs:232
                // 145. ExplanationOfBenefit.addItem.detail.net
                public MakerElementInstance Element_Net;                                                                                    // MakerGen.cs:232
                // 146. ExplanationOfBenefit.addItem.detail.noteNumber
                public MakerElementInstance Element_NoteNumber;                                                                             // MakerGen.cs:232
                // 147. ExplanationOfBenefit.addItem.detail.adjudication
                public MakerElementInstance Element_Adjudication;                                                                           // MakerGen.cs:232
                public Type_Detail()                                                                                                        // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 140. ExplanationOfBenefit.addItem.detail.productOrService
                        this.Element_ProductOrService = new MakerElementInstance                                                            // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ProductOrService",                                                                              // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 141. ExplanationOfBenefit.addItem.detail.modifier
                        this.Element_Modifier = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Modifier",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 142. ExplanationOfBenefit.addItem.detail.quantity
                        this.Element_Quantity = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Quantity",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 143. ExplanationOfBenefit.addItem.detail.unitPrice
                        this.Element_UnitPrice = new MakerElementInstance                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_UnitPrice",                                                                                     // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 144. ExplanationOfBenefit.addItem.detail.factor
                        this.Element_Factor = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Factor",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Decimal()                                                               // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 145. ExplanationOfBenefit.addItem.detail.net
                        this.Element_Net = new MakerElementInstance                                                                         // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Net",                                                                                           // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 146. ExplanationOfBenefit.addItem.detail.noteNumber
                        this.Element_NoteNumber = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_NoteNumber",                                                                                    // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                           // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 147. ExplanationOfBenefit.addItem.detail.adjudication
                        this.Element_Adjudication = new MakerElementInstance                                                                // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Adjudication",                                                                                  // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 122. ExplanationOfBenefit.addItem.itemSequence
            public MakerElementInstance Element_ItemSequence;                                                                               // MakerGen.cs:232
            // 123. ExplanationOfBenefit.addItem.detailSequence
            public MakerElementInstance Element_DetailSequence;                                                                             // MakerGen.cs:232
            // 124. ExplanationOfBenefit.addItem.subDetailSequence
            public MakerElementInstance Element_SubDetailSequence;                                                                          // MakerGen.cs:232
            // 125. ExplanationOfBenefit.addItem.provider
            public MakerElementInstance Element_Provider;                                                                                   // MakerGen.cs:232
            // 126. ExplanationOfBenefit.addItem.productOrService
            public MakerElementInstance Element_ProductOrService;                                                                           // MakerGen.cs:232
            // 127. ExplanationOfBenefit.addItem.modifier
            public MakerElementInstance Element_Modifier;                                                                                   // MakerGen.cs:232
            // 128. ExplanationOfBenefit.addItem.programCode
            public MakerElementInstance Element_ProgramCode;                                                                                // MakerGen.cs:232
            // 129. ExplanationOfBenefit.addItem.serviced[x]
            public MakerElementInstance Element_Serviced;                                                                                   // MakerGen.cs:232
            // 130. ExplanationOfBenefit.addItem.location[x]
            public MakerElementInstance Element_Location;                                                                                   // MakerGen.cs:232
            // 131. ExplanationOfBenefit.addItem.quantity
            public MakerElementInstance Element_Quantity;                                                                                   // MakerGen.cs:232
            // 132. ExplanationOfBenefit.addItem.unitPrice
            public MakerElementInstance Element_UnitPrice;                                                                                  // MakerGen.cs:232
            // 133. ExplanationOfBenefit.addItem.factor
            public MakerElementInstance Element_Factor;                                                                                     // MakerGen.cs:232
            // 134. ExplanationOfBenefit.addItem.net
            public MakerElementInstance Element_Net;                                                                                        // MakerGen.cs:232
            // 135. ExplanationOfBenefit.addItem.bodySite
            public MakerElementInstance Element_BodySite;                                                                                   // MakerGen.cs:232
            // 136. ExplanationOfBenefit.addItem.subSite
            public MakerElementInstance Element_SubSite;                                                                                    // MakerGen.cs:232
            // 137. ExplanationOfBenefit.addItem.noteNumber
            public MakerElementInstance Element_NoteNumber;                                                                                 // MakerGen.cs:232
            // 138. ExplanationOfBenefit.addItem.adjudication
            public MakerElementInstance Element_Adjudication;                                                                               // MakerGen.cs:232
            public Type_AddItem()                                                                                                           // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 122. ExplanationOfBenefit.addItem.itemSequence
                    this.Element_ItemSequence = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ItemSequence",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 123. ExplanationOfBenefit.addItem.detailSequence
                    this.Element_DetailSequence = new MakerElementInstance                                                                  // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DetailSequence",                                                                                    // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 124. ExplanationOfBenefit.addItem.subDetailSequence
                    this.Element_SubDetailSequence = new MakerElementInstance                                                               // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SubDetailSequence",                                                                                 // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 125. ExplanationOfBenefit.addItem.provider
                    this.Element_Provider = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Provider",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 126. ExplanationOfBenefit.addItem.productOrService
                    this.Element_ProductOrService = new MakerElementInstance                                                                // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ProductOrService",                                                                                  // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 127. ExplanationOfBenefit.addItem.modifier
                    this.Element_Modifier = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Modifier",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 128. ExplanationOfBenefit.addItem.programCode
                    this.Element_ProgramCode = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ProgramCode",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 129. ExplanationOfBenefit.addItem.serviced[x]
                    this.Element_Serviced = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Serviced",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Date(),                                                                     // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 130. ExplanationOfBenefit.addItem.location[x]
                    this.Element_Location = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Location",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept(),                                                            // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 131. ExplanationOfBenefit.addItem.quantity
                    this.Element_Quantity = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Quantity",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 132. ExplanationOfBenefit.addItem.unitPrice
                    this.Element_UnitPrice = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_UnitPrice",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 133. ExplanationOfBenefit.addItem.factor
                    this.Element_Factor = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Factor",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 134. ExplanationOfBenefit.addItem.net
                    this.Element_Net = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Net",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 135. ExplanationOfBenefit.addItem.bodySite
                    this.Element_BodySite = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_BodySite",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 136. ExplanationOfBenefit.addItem.subSite
                    this.Element_SubSite = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SubSite",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 137. ExplanationOfBenefit.addItem.noteNumber
                    this.Element_NoteNumber = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_NoteNumber",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 138. ExplanationOfBenefit.addItem.adjudication
                    this.Element_Adjudication = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Adjudication",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 158. ExplanationOfBenefit.total
        public class Type_Total : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 159. ExplanationOfBenefit.total.category
            public MakerElementInstance Element_Category;                                                                                   // MakerGen.cs:232
            // 160. ExplanationOfBenefit.total.amount
            public MakerElementInstance Element_Amount;                                                                                     // MakerGen.cs:232
            public Type_Total()                                                                                                             // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 159. ExplanationOfBenefit.total.category
                    this.Element_Category = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Category",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 160. ExplanationOfBenefit.total.amount
                    this.Element_Amount = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Amount",                                                                                            // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 161. ExplanationOfBenefit.payment
        public class Type_Payment : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 162. ExplanationOfBenefit.payment.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 163. ExplanationOfBenefit.payment.adjustment
            public MakerElementInstance Element_Adjustment;                                                                                 // MakerGen.cs:232
            // 164. ExplanationOfBenefit.payment.adjustmentReason
            public MakerElementInstance Element_AdjustmentReason;                                                                           // MakerGen.cs:232
            // 165. ExplanationOfBenefit.payment.date
            public MakerElementInstance Element_Date;                                                                                       // MakerGen.cs:232
            // 166. ExplanationOfBenefit.payment.amount
            public MakerElementInstance Element_Amount;                                                                                     // MakerGen.cs:232
            // 167. ExplanationOfBenefit.payment.identifier
            public MakerElementInstance Element_Identifier;                                                                                 // MakerGen.cs:232
            public Type_Payment()                                                                                                           // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 162. ExplanationOfBenefit.payment.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 163. ExplanationOfBenefit.payment.adjustment
                    this.Element_Adjustment = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Adjustment",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 164. ExplanationOfBenefit.payment.adjustmentReason
                    this.Element_AdjustmentReason = new MakerElementInstance                                                                // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_AdjustmentReason",                                                                                  // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 165. ExplanationOfBenefit.payment.date
                    this.Element_Date = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Date",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Date()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 166. ExplanationOfBenefit.payment.amount
                    this.Element_Amount = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Amount",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 167. ExplanationOfBenefit.payment.identifier
                    this.Element_Identifier = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 170. ExplanationOfBenefit.processNote
        public class Type_ProcessNote : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 171. ExplanationOfBenefit.processNote.number
            public MakerElementInstance Element_Number;                                                                                     // MakerGen.cs:232
            // 172. ExplanationOfBenefit.processNote.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 173. ExplanationOfBenefit.processNote.text
            public MakerElementInstance Element_Text;                                                                                       // MakerGen.cs:232
            // 174. ExplanationOfBenefit.processNote.language
            public MakerElementInstance Element_Language;                                                                                   // MakerGen.cs:232
            public Type_ProcessNote()                                                                                                       // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 171. ExplanationOfBenefit.processNote.number
                    this.Element_Number = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Number",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 172. ExplanationOfBenefit.processNote.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 173. ExplanationOfBenefit.processNote.text
                    this.Element_Text = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Text",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 174. ExplanationOfBenefit.processNote.language
                    this.Element_Language = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Language",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 176. ExplanationOfBenefit.benefitBalance
        public class Type_BenefitBalance : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 184. ExplanationOfBenefit.benefitBalance.financial
            public class Type_Financial : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 185. ExplanationOfBenefit.benefitBalance.financial.type
                public MakerElementInstance Element_Type;                                                                                   // MakerGen.cs:232
                // 186. ExplanationOfBenefit.benefitBalance.financial.allowed[x]
                public MakerElementInstance Element_Allowed;                                                                                // MakerGen.cs:232
                // 187. ExplanationOfBenefit.benefitBalance.financial.used[x]
                public MakerElementInstance Element_Used;                                                                                   // MakerGen.cs:232
                public Type_Financial()                                                                                                     // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 185. ExplanationOfBenefit.benefitBalance.financial.type
                        this.Element_Type = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Type",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 186. ExplanationOfBenefit.benefitBalance.financial.allowed[x]
                        this.Element_Allowed = new MakerElementInstance                                                                     // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Allowed",                                                                                       // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.UnsignedInt(),                                                          // MakerGen.cs:286
                                new FhirKhit.Maker.Common.Primitive.String(),                                                               // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 187. ExplanationOfBenefit.benefitBalance.financial.used[x]
                        this.Element_Used = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Used",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.UnsignedInt(),                                                          // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 177. ExplanationOfBenefit.benefitBalance.category
            public MakerElementInstance Element_Category;                                                                                   // MakerGen.cs:232
            // 178. ExplanationOfBenefit.benefitBalance.excluded
            public MakerElementInstance Element_Excluded;                                                                                   // MakerGen.cs:232
            // 179. ExplanationOfBenefit.benefitBalance.name
            public MakerElementInstance Element_Name;                                                                                       // MakerGen.cs:232
            // 180. ExplanationOfBenefit.benefitBalance.description
            public MakerElementInstance Element_Description;                                                                                // MakerGen.cs:232
            // 181. ExplanationOfBenefit.benefitBalance.network
            public MakerElementInstance Element_Network;                                                                                    // MakerGen.cs:232
            // 182. ExplanationOfBenefit.benefitBalance.unit
            public MakerElementInstance Element_Unit;                                                                                       // MakerGen.cs:232
            // 183. ExplanationOfBenefit.benefitBalance.term
            public MakerElementInstance Element_Term;                                                                                       // MakerGen.cs:232
            public Type_BenefitBalance()                                                                                                    // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 177. ExplanationOfBenefit.benefitBalance.category
                    this.Element_Category = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Category",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 178. ExplanationOfBenefit.benefitBalance.excluded
                    this.Element_Excluded = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Excluded",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 179. ExplanationOfBenefit.benefitBalance.name
                    this.Element_Name = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Name",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 180. ExplanationOfBenefit.benefitBalance.description
                    this.Element_Description = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Description",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 181. ExplanationOfBenefit.benefitBalance.network
                    this.Element_Network = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Network",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 182. ExplanationOfBenefit.benefitBalance.unit
                    this.Element_Unit = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Unit",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 183. ExplanationOfBenefit.benefitBalance.term
                    this.Element_Term = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Term",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. ExplanationOfBenefit.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. ExplanationOfBenefit.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 3. ExplanationOfBenefit.type
        public MakerElementInstance Element_Type;                                                                                           // MakerGen.cs:232
        // 4. ExplanationOfBenefit.subType
        public MakerElementInstance Element_SubType;                                                                                        // MakerGen.cs:232
        // 5. ExplanationOfBenefit.use
        public MakerElementInstance Element_Use;                                                                                            // MakerGen.cs:232
        // 6. ExplanationOfBenefit.patient
        public MakerElementInstance Element_Patient;                                                                                        // MakerGen.cs:232
        // 7. ExplanationOfBenefit.billablePeriod
        public MakerElementInstance Element_BillablePeriod;                                                                                 // MakerGen.cs:232
        // 8. ExplanationOfBenefit.created
        public MakerElementInstance Element_Created;                                                                                        // MakerGen.cs:232
        // 9. ExplanationOfBenefit.enterer
        public MakerElementInstance Element_Enterer;                                                                                        // MakerGen.cs:232
        // 10. ExplanationOfBenefit.insurer
        public MakerElementInstance Element_Insurer;                                                                                        // MakerGen.cs:232
        // 11. ExplanationOfBenefit.provider
        public MakerElementInstance Element_Provider;                                                                                       // MakerGen.cs:232
        // 12. ExplanationOfBenefit.priority
        public MakerElementInstance Element_Priority;                                                                                       // MakerGen.cs:232
        // 13. ExplanationOfBenefit.fundsReserveRequested
        public MakerElementInstance Element_FundsReserveRequested;                                                                          // MakerGen.cs:232
        // 14. ExplanationOfBenefit.fundsReserve
        public MakerElementInstance Element_FundsReserve;                                                                                   // MakerGen.cs:232
        // 19. ExplanationOfBenefit.prescription
        public MakerElementInstance Element_Prescription;                                                                                   // MakerGen.cs:232
        // 20. ExplanationOfBenefit.originalPrescription
        public MakerElementInstance Element_OriginalPrescription;                                                                           // MakerGen.cs:232
        // 24. ExplanationOfBenefit.referral
        public MakerElementInstance Element_Referral;                                                                                       // MakerGen.cs:232
        // 25. ExplanationOfBenefit.facility
        public MakerElementInstance Element_Facility;                                                                                       // MakerGen.cs:232
        // 26. ExplanationOfBenefit.claim
        public MakerElementInstance Element_Claim;                                                                                          // MakerGen.cs:232
        // 27. ExplanationOfBenefit.claimResponse
        public MakerElementInstance Element_ClaimResponse;                                                                                  // MakerGen.cs:232
        // 28. ExplanationOfBenefit.outcome
        public MakerElementInstance Element_Outcome;                                                                                        // MakerGen.cs:232
        // 29. ExplanationOfBenefit.disposition
        public MakerElementInstance Element_Disposition;                                                                                    // MakerGen.cs:232
        // 30. ExplanationOfBenefit.preAuthRef
        public MakerElementInstance Element_PreAuthRef;                                                                                     // MakerGen.cs:232
        // 31. ExplanationOfBenefit.preAuthRefPeriod
        public MakerElementInstance Element_PreAuthRefPeriod;                                                                               // MakerGen.cs:232
        // 57. ExplanationOfBenefit.precedence
        public MakerElementInstance Element_Precedence;                                                                                     // MakerGen.cs:232
        // 157. ExplanationOfBenefit.adjudication
        public MakerElementInstance Element_Adjudication;                                                                                   // MakerGen.cs:232
        // 168. ExplanationOfBenefit.formCode
        public MakerElementInstance Element_FormCode;                                                                                       // MakerGen.cs:232
        // 169. ExplanationOfBenefit.form
        public MakerElementInstance Element_Form;                                                                                           // MakerGen.cs:232
        // 175. ExplanationOfBenefit.benefitPeriod
        public MakerElementInstance Element_BenefitPeriod;                                                                                  // MakerGen.cs:232
        public ExplanationOfBenefit()                                                                                                       // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. ExplanationOfBenefit.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. ExplanationOfBenefit.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. ExplanationOfBenefit.type
                this.Element_Type = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. ExplanationOfBenefit.subType
                this.Element_SubType = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_SubType",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. ExplanationOfBenefit.use
                this.Element_Use = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Use",                                                                                                   // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. ExplanationOfBenefit.patient
                this.Element_Patient = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. ExplanationOfBenefit.billablePeriod
                this.Element_BillablePeriod = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_BillablePeriod",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. ExplanationOfBenefit.created
                this.Element_Created = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Created",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 9. ExplanationOfBenefit.enterer
                this.Element_Enterer = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Enterer",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 10. ExplanationOfBenefit.insurer
                this.Element_Insurer = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Insurer",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 11. ExplanationOfBenefit.provider
                this.Element_Provider = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Provider",                                                                                              // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 12. ExplanationOfBenefit.priority
                this.Element_Priority = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Priority",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 13. ExplanationOfBenefit.fundsReserveRequested
                this.Element_FundsReserveRequested = new MakerElementInstance                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_FundsReserveRequested",                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 14. ExplanationOfBenefit.fundsReserve
                this.Element_FundsReserve = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_FundsReserve",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 19. ExplanationOfBenefit.prescription
                this.Element_Prescription = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Prescription",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 20. ExplanationOfBenefit.originalPrescription
                this.Element_OriginalPrescription = new MakerElementInstance                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_OriginalPrescription",                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 24. ExplanationOfBenefit.referral
                this.Element_Referral = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Referral",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 25. ExplanationOfBenefit.facility
                this.Element_Facility = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Facility",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 26. ExplanationOfBenefit.claim
                this.Element_Claim = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Claim",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 27. ExplanationOfBenefit.claimResponse
                this.Element_ClaimResponse = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ClaimResponse",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 28. ExplanationOfBenefit.outcome
                this.Element_Outcome = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Outcome",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 29. ExplanationOfBenefit.disposition
                this.Element_Disposition = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Disposition",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 30. ExplanationOfBenefit.preAuthRef
                this.Element_PreAuthRef = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PreAuthRef",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 31. ExplanationOfBenefit.preAuthRefPeriod
                this.Element_PreAuthRefPeriod = new MakerElementInstance                                                                    // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PreAuthRefPeriod",                                                                                      // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 57. ExplanationOfBenefit.precedence
                this.Element_Precedence = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Precedence",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.PositiveInt()                                                                   // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 157. ExplanationOfBenefit.adjudication
                this.Element_Adjudication = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Adjudication",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 168. ExplanationOfBenefit.formCode
                this.Element_FormCode = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_FormCode",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 169. ExplanationOfBenefit.form
                this.Element_Form = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Form",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 175. ExplanationOfBenefit.benefitPeriod
                this.Element_BenefitPeriod = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_BenefitPeriod",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
