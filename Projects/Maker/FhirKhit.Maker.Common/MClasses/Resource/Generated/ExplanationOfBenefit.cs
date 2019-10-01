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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'ExplanationOfBenefit'
    /// </summary>
    // 0. ExplanationOfBenefit
    public class ExplanationOfBenefit : FhirKhit.Maker.Common.Resource.ResourceBase                                                         // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class ExplanationOfBenefit_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 15. ExplanationOfBenefit.related
            public class Type_Related : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Related_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 16. ExplanationOfBenefit.related.claim
                    public ElementDefinitionInfo Claim;                                                                                     // MakerGen.cs:236
                    // 17. ExplanationOfBenefit.related.relationship
                    public ElementDefinitionInfo Relationship;                                                                              // MakerGen.cs:236
                    // 18. ExplanationOfBenefit.related.reference
                    public ElementDefinitionInfo Reference;                                                                                 // MakerGen.cs:236
                    public Type_Related_Elements()                                                                                          // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 16. ExplanationOfBenefit.related.claim
                            this.Claim = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Claim",                                                                                             // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.related.claim",                                                                 // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.related.claim",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Claim"                                                 // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 17. ExplanationOfBenefit.related.relationship
                            this.Relationship = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Relationship",                                                                                      // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.related.relationship",                                                          // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.related.relationship",                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 18. ExplanationOfBenefit.related.reference
                            this.Reference = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Reference",                                                                                         // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.related.reference",                                                             // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.related.reference",                                                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Claim.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Relationship.Write(sDef);                                                                                           // MakerGen.cs:240
                        Reference.Write(sDef);                                                                                              // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Related_Elements Elements { get; }                                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Related()                                                                                                       // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Related_Elements();                                                                            // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 21. ExplanationOfBenefit.payee
            public class Type_Payee : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Payee_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 22. ExplanationOfBenefit.payee.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 23. ExplanationOfBenefit.payee.party
                    public ElementDefinitionInfo Party;                                                                                     // MakerGen.cs:236
                    public Type_Payee_Elements()                                                                                            // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 22. ExplanationOfBenefit.payee.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.payee.type",                                                                    // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.payee.type",                                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 23. ExplanationOfBenefit.payee.party
                            this.Party = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Party",                                                                                             // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.payee.party",                                                                   // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.payee.party",                                                                    // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Organization",                                         // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                         // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Party.Write(sDef);                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Payee_Elements Elements { get; }                                                                                // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Payee()                                                                                                         // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Payee_Elements();                                                                              // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 32. ExplanationOfBenefit.careTeam
            public class Type_CareTeam : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_CareTeam_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 33. ExplanationOfBenefit.careTeam.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:236
                    // 34. ExplanationOfBenefit.careTeam.provider
                    public ElementDefinitionInfo Provider;                                                                                  // MakerGen.cs:236
                    // 35. ExplanationOfBenefit.careTeam.responsible
                    public ElementDefinitionInfo Responsible;                                                                               // MakerGen.cs:236
                    // 36. ExplanationOfBenefit.careTeam.role
                    public ElementDefinitionInfo Role;                                                                                      // MakerGen.cs:236
                    // 37. ExplanationOfBenefit.careTeam.qualification
                    public ElementDefinitionInfo Qualification;                                                                             // MakerGen.cs:236
                    public Type_CareTeam_Elements()                                                                                         // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 33. ExplanationOfBenefit.careTeam.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Sequence",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.careTeam.sequence",                                                             // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.careTeam.sequence",                                                              // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 34. ExplanationOfBenefit.careTeam.provider
                            this.Provider = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Provider",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.careTeam.provider",                                                             // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.careTeam.provider",                                                              // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 35. ExplanationOfBenefit.careTeam.responsible
                            this.Responsible = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Responsible",                                                                                       // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.careTeam.responsible",                                                          // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.careTeam.responsible",                                                           // MakerGen.cs:257
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
                            // 36. ExplanationOfBenefit.careTeam.role
                            this.Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Role",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.careTeam.role",                                                                 // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.careTeam.role",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 37. ExplanationOfBenefit.careTeam.qualification
                            this.Qualification = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Qualification",                                                                                     // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.careTeam.qualification",                                                        // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.careTeam.qualification",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
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
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:240
                        Provider.Write(sDef);                                                                                               // MakerGen.cs:240
                        Responsible.Write(sDef);                                                                                            // MakerGen.cs:240
                        Role.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Qualification.Write(sDef);                                                                                          // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_CareTeam_Elements Elements { get; }                                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_CareTeam()                                                                                                      // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_CareTeam_Elements();                                                                           // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 38. ExplanationOfBenefit.supportingInfo
            public class Type_SupportingInfo : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_SupportingInfo_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 39. ExplanationOfBenefit.supportingInfo.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:236
                    // 40. ExplanationOfBenefit.supportingInfo.category
                    public ElementDefinitionInfo Category;                                                                                  // MakerGen.cs:236
                    // 41. ExplanationOfBenefit.supportingInfo.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:236
                    // 42. ExplanationOfBenefit.supportingInfo.timing[x]
                    public ElementDefinitionInfo Timing;                                                                                    // MakerGen.cs:236
                    // 43. ExplanationOfBenefit.supportingInfo.value[x]
                    public ElementDefinitionInfo Value;                                                                                     // MakerGen.cs:236
                    // 44. ExplanationOfBenefit.supportingInfo.reason
                    public ElementDefinitionInfo Reason;                                                                                    // MakerGen.cs:236
                    public Type_SupportingInfo_Elements()                                                                                   // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 39. ExplanationOfBenefit.supportingInfo.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Sequence",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.supportingInfo.sequence",                                                       // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.supportingInfo.sequence",                                                        // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 40. ExplanationOfBenefit.supportingInfo.category
                            this.Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Category",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.supportingInfo.category",                                                       // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.supportingInfo.category",                                                        // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 41. ExplanationOfBenefit.supportingInfo.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Code",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.supportingInfo.code",                                                           // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.supportingInfo.code",                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 42. ExplanationOfBenefit.supportingInfo.timing[x]
                            this.Timing = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Timing",                                                                                            // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.supportingInfo.timing[x]",                                                      // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.supportingInfo.timing[x]",                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 43. ExplanationOfBenefit.supportingInfo.value[x]
                            this.Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Value",                                                                                             // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.supportingInfo.value[x]",                                                       // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.supportingInfo.value[x]",                                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Attachment                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 44. ExplanationOfBenefit.supportingInfo.reason
                            this.Reason = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Reason",                                                                                            // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.supportingInfo.reason",                                                         // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.supportingInfo.reason",                                                          // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:240
                        Category.Write(sDef);                                                                                               // MakerGen.cs:240
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Timing.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Value.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Reason.Write(sDef);                                                                                                 // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_SupportingInfo_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_SupportingInfo()                                                                                                // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_SupportingInfo_Elements();                                                                     // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 45. ExplanationOfBenefit.diagnosis
            public class Type_Diagnosis : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Diagnosis_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 46. ExplanationOfBenefit.diagnosis.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:236
                    // 47. ExplanationOfBenefit.diagnosis.diagnosis[x]
                    public ElementDefinitionInfo Diagnosis;                                                                                 // MakerGen.cs:236
                    // 48. ExplanationOfBenefit.diagnosis.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 49. ExplanationOfBenefit.diagnosis.onAdmission
                    public ElementDefinitionInfo OnAdmission;                                                                               // MakerGen.cs:236
                    // 50. ExplanationOfBenefit.diagnosis.packageCode
                    public ElementDefinitionInfo PackageCode;                                                                               // MakerGen.cs:236
                    public Type_Diagnosis_Elements()                                                                                        // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 46. ExplanationOfBenefit.diagnosis.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Sequence",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.diagnosis.sequence",                                                            // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.diagnosis.sequence",                                                             // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 47. ExplanationOfBenefit.diagnosis.diagnosis[x]
                            this.Diagnosis = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Diagnosis",                                                                                         // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.diagnosis.diagnosis[x]",                                                        // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.diagnosis.diagnosis[x]",                                                         // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Condition"                                             // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 48. ExplanationOfBenefit.diagnosis.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.diagnosis.type",                                                                // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.diagnosis.type",                                                                 // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 49. ExplanationOfBenefit.diagnosis.onAdmission
                            this.OnAdmission = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "OnAdmission",                                                                                       // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.diagnosis.onAdmission",                                                         // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.diagnosis.onAdmission",                                                          // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 50. ExplanationOfBenefit.diagnosis.packageCode
                            this.PackageCode = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "PackageCode",                                                                                       // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.diagnosis.packageCode",                                                         // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.diagnosis.packageCode",                                                          // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
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
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:240
                        Diagnosis.Write(sDef);                                                                                              // MakerGen.cs:240
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        OnAdmission.Write(sDef);                                                                                            // MakerGen.cs:240
                        PackageCode.Write(sDef);                                                                                            // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Diagnosis_Elements Elements { get; }                                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Diagnosis()                                                                                                     // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Diagnosis_Elements();                                                                          // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 51. ExplanationOfBenefit.procedure
            public class Type_Procedure : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Procedure_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 52. ExplanationOfBenefit.procedure.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:236
                    // 53. ExplanationOfBenefit.procedure.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 54. ExplanationOfBenefit.procedure.date
                    public ElementDefinitionInfo Date;                                                                                      // MakerGen.cs:236
                    // 55. ExplanationOfBenefit.procedure.procedure[x]
                    public ElementDefinitionInfo Procedure;                                                                                 // MakerGen.cs:236
                    // 56. ExplanationOfBenefit.procedure.udi
                    public ElementDefinitionInfo Udi;                                                                                       // MakerGen.cs:236
                    public Type_Procedure_Elements()                                                                                        // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 52. ExplanationOfBenefit.procedure.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Sequence",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.procedure.sequence",                                                            // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.procedure.sequence",                                                             // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 53. ExplanationOfBenefit.procedure.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.procedure.type",                                                                // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.procedure.type",                                                                 // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 54. ExplanationOfBenefit.procedure.date
                            this.Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Date",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.procedure.date",                                                                // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.procedure.date",                                                                 // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 55. ExplanationOfBenefit.procedure.procedure[x]
                            this.Procedure = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Procedure",                                                                                         // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.procedure.procedure[x]",                                                        // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.procedure.procedure[x]",                                                         // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Procedure"                                             // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 56. ExplanationOfBenefit.procedure.udi
                            this.Udi = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Udi",                                                                                               // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.procedure.udi",                                                                 // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.procedure.udi",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Device"                                                // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:240
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Date.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Procedure.Write(sDef);                                                                                              // MakerGen.cs:240
                        Udi.Write(sDef);                                                                                                    // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Procedure_Elements Elements { get; }                                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Procedure()                                                                                                     // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Procedure_Elements();                                                                          // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 58. ExplanationOfBenefit.insurance
            public class Type_Insurance : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Insurance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 59. ExplanationOfBenefit.insurance.focal
                    public ElementDefinitionInfo Focal;                                                                                     // MakerGen.cs:236
                    // 60. ExplanationOfBenefit.insurance.coverage
                    public ElementDefinitionInfo Coverage;                                                                                  // MakerGen.cs:236
                    // 61. ExplanationOfBenefit.insurance.preAuthRef
                    public ElementDefinitionInfo PreAuthRef;                                                                                // MakerGen.cs:236
                    public Type_Insurance_Elements()                                                                                        // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 59. ExplanationOfBenefit.insurance.focal
                            this.Focal = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Focal",                                                                                             // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.insurance.focal",                                                               // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.insurance.focal",                                                                // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
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
                            // 60. ExplanationOfBenefit.insurance.coverage
                            this.Coverage = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Coverage",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.insurance.coverage",                                                            // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.insurance.coverage",                                                             // MakerGen.cs:257
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
                            // 61. ExplanationOfBenefit.insurance.preAuthRef
                            this.PreAuthRef = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "PreAuthRef",                                                                                        // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.insurance.preAuthRef",                                                          // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.insurance.preAuthRef",                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Focal.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Coverage.Write(sDef);                                                                                               // MakerGen.cs:240
                        PreAuthRef.Write(sDef);                                                                                             // MakerGen.cs:240
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
            // 62. ExplanationOfBenefit.accident
            public class Type_Accident : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Accident_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 63. ExplanationOfBenefit.accident.date
                    public ElementDefinitionInfo Date;                                                                                      // MakerGen.cs:236
                    // 64. ExplanationOfBenefit.accident.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 65. ExplanationOfBenefit.accident.location[x]
                    public ElementDefinitionInfo Location;                                                                                  // MakerGen.cs:236
                    public Type_Accident_Elements()                                                                                         // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 63. ExplanationOfBenefit.accident.date
                            this.Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Date",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.accident.date",                                                                 // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.accident.date",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 64. ExplanationOfBenefit.accident.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.accident.type",                                                                 // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.accident.type",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 65. ExplanationOfBenefit.accident.location[x]
                            this.Location = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Location",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.accident.location[x]",                                                          // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.accident.location[x]",                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Address                                                               // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Location"                                              // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Date.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Location.Write(sDef);                                                                                               // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Accident_Elements Elements { get; }                                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Accident()                                                                                                      // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Accident_Elements();                                                                           // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 66. ExplanationOfBenefit.item
            public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Item_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 88. ExplanationOfBenefit.item.adjudication
                    public class Type_Adjudication : FhirKhit.Maker.Common.Complex.ComplexBase                                              // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Adjudication_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                               // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 89. ExplanationOfBenefit.item.adjudication.category
                            public ElementDefinitionInfo Category;                                                                          // MakerGen.cs:236
                            // 90. ExplanationOfBenefit.item.adjudication.reason
                            public ElementDefinitionInfo Reason;                                                                            // MakerGen.cs:236
                            // 91. ExplanationOfBenefit.item.adjudication.amount
                            public ElementDefinitionInfo Amount;                                                                            // MakerGen.cs:236
                            // 92. ExplanationOfBenefit.item.adjudication.value
                            public ElementDefinitionInfo Value;                                                                             // MakerGen.cs:236
                            public Type_Adjudication_Elements()                                                                             // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 89. ExplanationOfBenefit.item.adjudication.category
                                    this.Category = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Category",                                                                                  // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.adjudication.category",                                            // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.adjudication.category",                                             // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
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
                                    // 90. ExplanationOfBenefit.item.adjudication.reason
                                    this.Reason = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Reason",                                                                                    // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.adjudication.reason",                                              // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.adjudication.reason",                                               // MakerGen.cs:257
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
                                    // 91. ExplanationOfBenefit.item.adjudication.amount
                                    this.Amount = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Amount",                                                                                    // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.adjudication.amount",                                              // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.adjudication.amount",                                               // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Money                                                         // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 92. ExplanationOfBenefit.item.adjudication.value
                                    this.Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Value",                                                                                     // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.adjudication.value",                                               // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.adjudication.value",                                                // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:299
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
                                Reason.Write(sDef);                                                                                         // MakerGen.cs:240
                                Amount.Write(sDef);                                                                                         // MakerGen.cs:240
                                Value.Write(sDef);                                                                                          // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Adjudication_Elements Elements { get; }                                                                 // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Adjudication()                                                                                          // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Adjudication_Elements();                                                               // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 93. ExplanationOfBenefit.item.detail
                    public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Detail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 107. ExplanationOfBenefit.item.detail.subDetail
                            public class Type_SubDetail : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:385
                            {                                                                                                               // MakerGen.cs:386
                                public class Type_SubDetail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                          // MakerGen.cs:387
                                {                                                                                                           // MakerGen.cs:388
                                    // 108. ExplanationOfBenefit.item.detail.subDetail.sequence
                                    public ElementDefinitionInfo Sequence;                                                                  // MakerGen.cs:236
                                    // 109. ExplanationOfBenefit.item.detail.subDetail.revenue
                                    public ElementDefinitionInfo Revenue;                                                                   // MakerGen.cs:236
                                    // 110. ExplanationOfBenefit.item.detail.subDetail.category
                                    public ElementDefinitionInfo Category;                                                                  // MakerGen.cs:236
                                    // 111. ExplanationOfBenefit.item.detail.subDetail.productOrService
                                    public ElementDefinitionInfo ProductOrService;                                                          // MakerGen.cs:236
                                    // 112. ExplanationOfBenefit.item.detail.subDetail.modifier
                                    public ElementDefinitionInfo Modifier;                                                                  // MakerGen.cs:236
                                    // 113. ExplanationOfBenefit.item.detail.subDetail.programCode
                                    public ElementDefinitionInfo ProgramCode;                                                               // MakerGen.cs:236
                                    // 114. ExplanationOfBenefit.item.detail.subDetail.quantity
                                    public ElementDefinitionInfo Quantity;                                                                  // MakerGen.cs:236
                                    // 115. ExplanationOfBenefit.item.detail.subDetail.unitPrice
                                    public ElementDefinitionInfo UnitPrice;                                                                 // MakerGen.cs:236
                                    // 116. ExplanationOfBenefit.item.detail.subDetail.factor
                                    public ElementDefinitionInfo Factor;                                                                    // MakerGen.cs:236
                                    // 117. ExplanationOfBenefit.item.detail.subDetail.net
                                    public ElementDefinitionInfo Net;                                                                       // MakerGen.cs:236
                                    // 118. ExplanationOfBenefit.item.detail.subDetail.udi
                                    public ElementDefinitionInfo Udi;                                                                       // MakerGen.cs:236
                                    // 119. ExplanationOfBenefit.item.detail.subDetail.noteNumber
                                    public ElementDefinitionInfo NoteNumber;                                                                // MakerGen.cs:236
                                    // 120. ExplanationOfBenefit.item.detail.subDetail.adjudication
                                    public ElementDefinitionInfo Adjudication;                                                              // MakerGen.cs:236
                                    public Type_SubDetail_Elements()                                                                        // MakerGen.cs:409
                                    {                                                                                                       // MakerGen.cs:410
                                        {                                                                                                   // MakerGen.cs:251
                                            // 108. ExplanationOfBenefit.item.detail.subDetail.sequence
                                            this.Sequence = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Sequence",                                                                          // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.item.detail.subDetail.sequence",                                // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.item.detail.subDetail.sequence",                                 // MakerGen.cs:257
                                                Min = 1,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                         // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 109. ExplanationOfBenefit.item.detail.subDetail.revenue
                                            this.Revenue = new ElementDefinitionInfo                                                        // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Revenue",                                                                           // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.item.detail.subDetail.revenue",                                 // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.item.detail.subDetail.revenue",                                  // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
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
                                            // 110. ExplanationOfBenefit.item.detail.subDetail.category
                                            this.Category = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Category",                                                                          // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.item.detail.subDetail.category",                                // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.item.detail.subDetail.category",                                 // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
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
                                            // 111. ExplanationOfBenefit.item.detail.subDetail.productOrService
                                            this.ProductOrService = new ElementDefinitionInfo                                               // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "ProductOrService",                                                                  // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.item.detail.subDetail.productOrService",                        // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.item.detail.subDetail.productOrService",                         // MakerGen.cs:257
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
                                            // 112. ExplanationOfBenefit.item.detail.subDetail.modifier
                                            this.Modifier = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Modifier",                                                                          // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.item.detail.subDetail.modifier",                                // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.item.detail.subDetail.modifier",                                 // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = -1,                                                                                   // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:314
                                                    {                                                                                       // MakerGen.cs:315
                                                    }                                                                                       // MakerGen.cs:318
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 113. ExplanationOfBenefit.item.detail.subDetail.programCode
                                            this.ProgramCode = new ElementDefinitionInfo                                                    // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "ProgramCode",                                                                       // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.item.detail.subDetail.programCode",                             // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.item.detail.subDetail.programCode",                              // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = -1,                                                                                   // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:314
                                                    {                                                                                       // MakerGen.cs:315
                                                    }                                                                                       // MakerGen.cs:318
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 114. ExplanationOfBenefit.item.detail.subDetail.quantity
                                            this.Quantity = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Quantity",                                                                          // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.item.detail.subDetail.quantity",                                // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.item.detail.subDetail.quantity",                                 // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.Quantity                                              // MakerGen.cs:357
                                                    {                                                                                       // MakerGen.cs:358
                                                    }                                                                                       // MakerGen.cs:359
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 115. ExplanationOfBenefit.item.detail.subDetail.unitPrice
                                            this.UnitPrice = new ElementDefinitionInfo                                                      // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "UnitPrice",                                                                         // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.item.detail.subDetail.unitPrice",                               // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.item.detail.subDetail.unitPrice",                                // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.Money                                                 // MakerGen.cs:357
                                                    {                                                                                       // MakerGen.cs:358
                                                    }                                                                                       // MakerGen.cs:359
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 116. ExplanationOfBenefit.item.detail.subDetail.factor
                                            this.Factor = new ElementDefinitionInfo                                                         // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Factor",                                                                            // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.item.detail.subDetail.factor",                                  // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.item.detail.subDetail.factor",                                   // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Decimal                                             // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 117. ExplanationOfBenefit.item.detail.subDetail.net
                                            this.Net = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Net",                                                                               // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.item.detail.subDetail.net",                                     // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.item.detail.subDetail.net",                                      // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.Money                                                 // MakerGen.cs:357
                                                    {                                                                                       // MakerGen.cs:358
                                                    }                                                                                       // MakerGen.cs:359
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 118. ExplanationOfBenefit.item.detail.subDetail.udi
                                            this.Udi = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Udi",                                                                               // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.item.detail.subDetail.udi",                                     // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.item.detail.subDetail.udi",                                      // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = -1,                                                                                   // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.Reference                                             // MakerGen.cs:345
                                                    {                                                                                       // MakerGen.cs:346
                                                        TargetProfile = new String[]                                                        // MakerGen.cs:348
                                                        {                                                                                   // CodeEditorExtensions.cs:28
                                                            "http://hl7.org/fhir/StructureDefinition/Device"                                // MakerGen.cs:348
                                                        }                                                                                   // CodeEditorExtensions.cs:34
                                                    }                                                                                       // MakerGen.cs:349
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 119. ExplanationOfBenefit.item.detail.subDetail.noteNumber
                                            this.NoteNumber = new ElementDefinitionInfo                                                     // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "NoteNumber",                                                                        // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.item.detail.subDetail.noteNumber",                              // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.item.detail.subDetail.noteNumber",                               // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = -1,                                                                                   // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                         // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 120. ExplanationOfBenefit.item.detail.subDetail.adjudication
                                            this.Adjudication = new ElementDefinitionInfo                                                   // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Adjudication",                                                                      // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.item.detail.subDetail.adjudication",                            // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.item.detail.subDetail.adjudication",                             // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = -1,                                                                                   // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                    }                                                                                                       // MakerGen.cs:429
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:414
                                    {                                                                                                       // MakerGen.cs:415
                                        base.Write(sDef);                                                                                   // MakerGen.cs:416
                                        Sequence.Write(sDef);                                                                               // MakerGen.cs:240
                                        Revenue.Write(sDef);                                                                                // MakerGen.cs:240
                                        Category.Write(sDef);                                                                               // MakerGen.cs:240
                                        ProductOrService.Write(sDef);                                                                       // MakerGen.cs:240
                                        Modifier.Write(sDef);                                                                               // MakerGen.cs:240
                                        ProgramCode.Write(sDef);                                                                            // MakerGen.cs:240
                                        Quantity.Write(sDef);                                                                               // MakerGen.cs:240
                                        UnitPrice.Write(sDef);                                                                              // MakerGen.cs:240
                                        Factor.Write(sDef);                                                                                 // MakerGen.cs:240
                                        Net.Write(sDef);                                                                                    // MakerGen.cs:240
                                        Udi.Write(sDef);                                                                                    // MakerGen.cs:240
                                        NoteNumber.Write(sDef);                                                                             // MakerGen.cs:240
                                        Adjudication.Write(sDef);                                                                           // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:433
                                }                                                                                                           // MakerGen.cs:393
                                public Type_SubDetail_Elements Elements { get; }                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                                public Type_SubDetail()                                                                                     // MakerGen.cs:396
                                {                                                                                                           // MakerGen.cs:397
                                    this.Elements = new Type_SubDetail_Elements();                                                          // MakerGen.cs:398
                                }                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:401
                                {                                                                                                           // MakerGen.cs:402
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:403
                                }                                                                                                           // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                            // 94. ExplanationOfBenefit.item.detail.sequence
                            public ElementDefinitionInfo Sequence;                                                                          // MakerGen.cs:236
                            // 95. ExplanationOfBenefit.item.detail.revenue
                            public ElementDefinitionInfo Revenue;                                                                           // MakerGen.cs:236
                            // 96. ExplanationOfBenefit.item.detail.category
                            public ElementDefinitionInfo Category;                                                                          // MakerGen.cs:236
                            // 97. ExplanationOfBenefit.item.detail.productOrService
                            public ElementDefinitionInfo ProductOrService;                                                                  // MakerGen.cs:236
                            // 98. ExplanationOfBenefit.item.detail.modifier
                            public ElementDefinitionInfo Modifier;                                                                          // MakerGen.cs:236
                            // 99. ExplanationOfBenefit.item.detail.programCode
                            public ElementDefinitionInfo ProgramCode;                                                                       // MakerGen.cs:236
                            // 100. ExplanationOfBenefit.item.detail.quantity
                            public ElementDefinitionInfo Quantity;                                                                          // MakerGen.cs:236
                            // 101. ExplanationOfBenefit.item.detail.unitPrice
                            public ElementDefinitionInfo UnitPrice;                                                                         // MakerGen.cs:236
                            // 102. ExplanationOfBenefit.item.detail.factor
                            public ElementDefinitionInfo Factor;                                                                            // MakerGen.cs:236
                            // 103. ExplanationOfBenefit.item.detail.net
                            public ElementDefinitionInfo Net;                                                                               // MakerGen.cs:236
                            // 104. ExplanationOfBenefit.item.detail.udi
                            public ElementDefinitionInfo Udi;                                                                               // MakerGen.cs:236
                            // 105. ExplanationOfBenefit.item.detail.noteNumber
                            public ElementDefinitionInfo NoteNumber;                                                                        // MakerGen.cs:236
                            // 106. ExplanationOfBenefit.item.detail.adjudication
                            public ElementDefinitionInfo Adjudication;                                                                      // MakerGen.cs:236
                            public Type_Detail_Elements()                                                                                   // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 94. ExplanationOfBenefit.item.detail.sequence
                                    this.Sequence = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Sequence",                                                                                  // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.detail.sequence",                                                  // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.detail.sequence",                                                   // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                 // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 95. ExplanationOfBenefit.item.detail.revenue
                                    this.Revenue = new ElementDefinitionInfo                                                                // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Revenue",                                                                                   // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.detail.revenue",                                                   // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.detail.revenue",                                                    // MakerGen.cs:257
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
                                    // 96. ExplanationOfBenefit.item.detail.category
                                    this.Category = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Category",                                                                                  // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.detail.category",                                                  // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.detail.category",                                                   // MakerGen.cs:257
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
                                    // 97. ExplanationOfBenefit.item.detail.productOrService
                                    this.ProductOrService = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "ProductOrService",                                                                          // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.detail.productOrService",                                          // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.detail.productOrService",                                           // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
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
                                    // 98. ExplanationOfBenefit.item.detail.modifier
                                    this.Modifier = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Modifier",                                                                                  // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.detail.modifier",                                                  // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.detail.modifier",                                                   // MakerGen.cs:257
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
                                    // 99. ExplanationOfBenefit.item.detail.programCode
                                    this.ProgramCode = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "ProgramCode",                                                                               // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.detail.programCode",                                               // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.detail.programCode",                                                // MakerGen.cs:257
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
                                    // 100. ExplanationOfBenefit.item.detail.quantity
                                    this.Quantity = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Quantity",                                                                                  // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.detail.quantity",                                                  // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.detail.quantity",                                                   // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 101. ExplanationOfBenefit.item.detail.unitPrice
                                    this.UnitPrice = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "UnitPrice",                                                                                 // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.detail.unitPrice",                                                 // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.detail.unitPrice",                                                  // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Money                                                         // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 102. ExplanationOfBenefit.item.detail.factor
                                    this.Factor = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Factor",                                                                                    // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.detail.factor",                                                    // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.detail.factor",                                                     // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 103. ExplanationOfBenefit.item.detail.net
                                    this.Net = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Net",                                                                                       // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.detail.net",                                                       // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.detail.net",                                                        // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Money                                                         // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 104. ExplanationOfBenefit.item.detail.udi
                                    this.Udi = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Udi",                                                                                       // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.detail.udi",                                                       // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.detail.udi",                                                        // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:345
                                            {                                                                                               // MakerGen.cs:346
                                                TargetProfile = new String[]                                                                // MakerGen.cs:348
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Device"                                        // MakerGen.cs:348
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:349
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 105. ExplanationOfBenefit.item.detail.noteNumber
                                    this.NoteNumber = new ElementDefinitionInfo                                                             // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "NoteNumber",                                                                                // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.detail.noteNumber",                                                // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.detail.noteNumber",                                                 // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                 // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 106. ExplanationOfBenefit.item.detail.adjudication
                                    this.Adjudication = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Adjudication",                                                                              // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.item.detail.adjudication",                                              // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.item.detail.adjudication",                                               // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Sequence.Write(sDef);                                                                                       // MakerGen.cs:240
                                Revenue.Write(sDef);                                                                                        // MakerGen.cs:240
                                Category.Write(sDef);                                                                                       // MakerGen.cs:240
                                ProductOrService.Write(sDef);                                                                               // MakerGen.cs:240
                                Modifier.Write(sDef);                                                                                       // MakerGen.cs:240
                                ProgramCode.Write(sDef);                                                                                    // MakerGen.cs:240
                                Quantity.Write(sDef);                                                                                       // MakerGen.cs:240
                                UnitPrice.Write(sDef);                                                                                      // MakerGen.cs:240
                                Factor.Write(sDef);                                                                                         // MakerGen.cs:240
                                Net.Write(sDef);                                                                                            // MakerGen.cs:240
                                Udi.Write(sDef);                                                                                            // MakerGen.cs:240
                                NoteNumber.Write(sDef);                                                                                     // MakerGen.cs:240
                                Adjudication.Write(sDef);                                                                                   // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Detail_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Detail()                                                                                                // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Detail_Elements();                                                                     // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 67. ExplanationOfBenefit.item.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:236
                    // 68. ExplanationOfBenefit.item.careTeamSequence
                    public ElementDefinitionInfo CareTeamSequence;                                                                          // MakerGen.cs:236
                    // 69. ExplanationOfBenefit.item.diagnosisSequence
                    public ElementDefinitionInfo DiagnosisSequence;                                                                         // MakerGen.cs:236
                    // 70. ExplanationOfBenefit.item.procedureSequence
                    public ElementDefinitionInfo ProcedureSequence;                                                                         // MakerGen.cs:236
                    // 71. ExplanationOfBenefit.item.informationSequence
                    public ElementDefinitionInfo InformationSequence;                                                                       // MakerGen.cs:236
                    // 72. ExplanationOfBenefit.item.revenue
                    public ElementDefinitionInfo Revenue;                                                                                   // MakerGen.cs:236
                    // 73. ExplanationOfBenefit.item.category
                    public ElementDefinitionInfo Category;                                                                                  // MakerGen.cs:236
                    // 74. ExplanationOfBenefit.item.productOrService
                    public ElementDefinitionInfo ProductOrService;                                                                          // MakerGen.cs:236
                    // 75. ExplanationOfBenefit.item.modifier
                    public ElementDefinitionInfo Modifier;                                                                                  // MakerGen.cs:236
                    // 76. ExplanationOfBenefit.item.programCode
                    public ElementDefinitionInfo ProgramCode;                                                                               // MakerGen.cs:236
                    // 77. ExplanationOfBenefit.item.serviced[x]
                    public ElementDefinitionInfo Serviced;                                                                                  // MakerGen.cs:236
                    // 78. ExplanationOfBenefit.item.location[x]
                    public ElementDefinitionInfo Location;                                                                                  // MakerGen.cs:236
                    // 79. ExplanationOfBenefit.item.quantity
                    public ElementDefinitionInfo Quantity;                                                                                  // MakerGen.cs:236
                    // 80. ExplanationOfBenefit.item.unitPrice
                    public ElementDefinitionInfo UnitPrice;                                                                                 // MakerGen.cs:236
                    // 81. ExplanationOfBenefit.item.factor
                    public ElementDefinitionInfo Factor;                                                                                    // MakerGen.cs:236
                    // 82. ExplanationOfBenefit.item.net
                    public ElementDefinitionInfo Net;                                                                                       // MakerGen.cs:236
                    // 83. ExplanationOfBenefit.item.udi
                    public ElementDefinitionInfo Udi;                                                                                       // MakerGen.cs:236
                    // 84. ExplanationOfBenefit.item.bodySite
                    public ElementDefinitionInfo BodySite;                                                                                  // MakerGen.cs:236
                    // 85. ExplanationOfBenefit.item.subSite
                    public ElementDefinitionInfo SubSite;                                                                                   // MakerGen.cs:236
                    // 86. ExplanationOfBenefit.item.encounter
                    public ElementDefinitionInfo Encounter;                                                                                 // MakerGen.cs:236
                    // 87. ExplanationOfBenefit.item.noteNumber
                    public ElementDefinitionInfo NoteNumber;                                                                                // MakerGen.cs:236
                    public Type_Item_Elements()                                                                                             // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 67. ExplanationOfBenefit.item.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Sequence",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.sequence",                                                                 // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.sequence",                                                                  // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 68. ExplanationOfBenefit.item.careTeamSequence
                            this.CareTeamSequence = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "CareTeamSequence",                                                                                  // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.careTeamSequence",                                                         // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.careTeamSequence",                                                          // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 69. ExplanationOfBenefit.item.diagnosisSequence
                            this.DiagnosisSequence = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "DiagnosisSequence",                                                                                 // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.diagnosisSequence",                                                        // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.diagnosisSequence",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 70. ExplanationOfBenefit.item.procedureSequence
                            this.ProcedureSequence = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ProcedureSequence",                                                                                 // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.procedureSequence",                                                        // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.procedureSequence",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 71. ExplanationOfBenefit.item.informationSequence
                            this.InformationSequence = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "InformationSequence",                                                                               // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.informationSequence",                                                      // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.informationSequence",                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 72. ExplanationOfBenefit.item.revenue
                            this.Revenue = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Revenue",                                                                                           // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.revenue",                                                                  // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.revenue",                                                                   // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 73. ExplanationOfBenefit.item.category
                            this.Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Category",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.category",                                                                 // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.category",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 74. ExplanationOfBenefit.item.productOrService
                            this.ProductOrService = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ProductOrService",                                                                                  // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.productOrService",                                                         // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.productOrService",                                                          // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 75. ExplanationOfBenefit.item.modifier
                            this.Modifier = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Modifier",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.modifier",                                                                 // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.modifier",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 76. ExplanationOfBenefit.item.programCode
                            this.ProgramCode = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ProgramCode",                                                                                       // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.programCode",                                                              // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.programCode",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 77. ExplanationOfBenefit.item.serviced[x]
                            this.Serviced = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Serviced",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.serviced[x]",                                                              // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.serviced[x]",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 78. ExplanationOfBenefit.item.location[x]
                            this.Location = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Location",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.location[x]",                                                              // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.location[x]",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
                                    new FhirKhit.Maker.Common.Complex.Address                                                               // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Location"                                              // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 79. ExplanationOfBenefit.item.quantity
                            this.Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Quantity",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.quantity",                                                                 // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.quantity",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 80. ExplanationOfBenefit.item.unitPrice
                            this.UnitPrice = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "UnitPrice",                                                                                         // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.unitPrice",                                                                // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.unitPrice",                                                                 // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 81. ExplanationOfBenefit.item.factor
                            this.Factor = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Factor",                                                                                            // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.factor",                                                                   // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.factor",                                                                    // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 82. ExplanationOfBenefit.item.net
                            this.Net = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Net",                                                                                               // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.net",                                                                      // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.net",                                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 83. ExplanationOfBenefit.item.udi
                            this.Udi = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Udi",                                                                                               // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.udi",                                                                      // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.udi",                                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Device"                                                // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 84. ExplanationOfBenefit.item.bodySite
                            this.BodySite = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "BodySite",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.bodySite",                                                                 // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.bodySite",                                                                  // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 85. ExplanationOfBenefit.item.subSite
                            this.SubSite = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "SubSite",                                                                                           // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.subSite",                                                                  // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.subSite",                                                                   // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 86. ExplanationOfBenefit.item.encounter
                            this.Encounter = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Encounter",                                                                                         // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.encounter",                                                                // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.encounter",                                                                 // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Encounter"                                             // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 87. ExplanationOfBenefit.item.noteNumber
                            this.NoteNumber = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "NoteNumber",                                                                                        // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.item.noteNumber",                                                               // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.item.noteNumber",                                                                // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:240
                        CareTeamSequence.Write(sDef);                                                                                       // MakerGen.cs:240
                        DiagnosisSequence.Write(sDef);                                                                                      // MakerGen.cs:240
                        ProcedureSequence.Write(sDef);                                                                                      // MakerGen.cs:240
                        InformationSequence.Write(sDef);                                                                                    // MakerGen.cs:240
                        Revenue.Write(sDef);                                                                                                // MakerGen.cs:240
                        Category.Write(sDef);                                                                                               // MakerGen.cs:240
                        ProductOrService.Write(sDef);                                                                                       // MakerGen.cs:240
                        Modifier.Write(sDef);                                                                                               // MakerGen.cs:240
                        ProgramCode.Write(sDef);                                                                                            // MakerGen.cs:240
                        Serviced.Write(sDef);                                                                                               // MakerGen.cs:240
                        Location.Write(sDef);                                                                                               // MakerGen.cs:240
                        Quantity.Write(sDef);                                                                                               // MakerGen.cs:240
                        UnitPrice.Write(sDef);                                                                                              // MakerGen.cs:240
                        Factor.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Net.Write(sDef);                                                                                                    // MakerGen.cs:240
                        Udi.Write(sDef);                                                                                                    // MakerGen.cs:240
                        BodySite.Write(sDef);                                                                                               // MakerGen.cs:240
                        SubSite.Write(sDef);                                                                                                // MakerGen.cs:240
                        Encounter.Write(sDef);                                                                                              // MakerGen.cs:240
                        NoteNumber.Write(sDef);                                                                                             // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Item_Elements Elements { get; }                                                                                 // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Item()                                                                                                          // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Item_Elements();                                                                               // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 121. ExplanationOfBenefit.addItem
            public class Type_AddItem : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_AddItem_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 139. ExplanationOfBenefit.addItem.detail
                    public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Detail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 148. ExplanationOfBenefit.addItem.detail.subDetail
                            public class Type_SubDetail : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:385
                            {                                                                                                               // MakerGen.cs:386
                                public class Type_SubDetail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                          // MakerGen.cs:387
                                {                                                                                                           // MakerGen.cs:388
                                    // 149. ExplanationOfBenefit.addItem.detail.subDetail.productOrService
                                    public ElementDefinitionInfo ProductOrService;                                                          // MakerGen.cs:236
                                    // 150. ExplanationOfBenefit.addItem.detail.subDetail.modifier
                                    public ElementDefinitionInfo Modifier;                                                                  // MakerGen.cs:236
                                    // 151. ExplanationOfBenefit.addItem.detail.subDetail.quantity
                                    public ElementDefinitionInfo Quantity;                                                                  // MakerGen.cs:236
                                    // 152. ExplanationOfBenefit.addItem.detail.subDetail.unitPrice
                                    public ElementDefinitionInfo UnitPrice;                                                                 // MakerGen.cs:236
                                    // 153. ExplanationOfBenefit.addItem.detail.subDetail.factor
                                    public ElementDefinitionInfo Factor;                                                                    // MakerGen.cs:236
                                    // 154. ExplanationOfBenefit.addItem.detail.subDetail.net
                                    public ElementDefinitionInfo Net;                                                                       // MakerGen.cs:236
                                    // 155. ExplanationOfBenefit.addItem.detail.subDetail.noteNumber
                                    public ElementDefinitionInfo NoteNumber;                                                                // MakerGen.cs:236
                                    // 156. ExplanationOfBenefit.addItem.detail.subDetail.adjudication
                                    public ElementDefinitionInfo Adjudication;                                                              // MakerGen.cs:236
                                    public Type_SubDetail_Elements()                                                                        // MakerGen.cs:409
                                    {                                                                                                       // MakerGen.cs:410
                                        {                                                                                                   // MakerGen.cs:251
                                            // 149. ExplanationOfBenefit.addItem.detail.subDetail.productOrService
                                            this.ProductOrService = new ElementDefinitionInfo                                               // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "ProductOrService",                                                                  // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.productOrService",                     // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.productOrService",                      // MakerGen.cs:257
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
                                            // 150. ExplanationOfBenefit.addItem.detail.subDetail.modifier
                                            this.Modifier = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Modifier",                                                                          // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.modifier",                             // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.modifier",                              // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = -1,                                                                                   // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:314
                                                    {                                                                                       // MakerGen.cs:315
                                                    }                                                                                       // MakerGen.cs:318
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 151. ExplanationOfBenefit.addItem.detail.subDetail.quantity
                                            this.Quantity = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Quantity",                                                                          // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.quantity",                             // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.quantity",                              // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.Quantity                                              // MakerGen.cs:357
                                                    {                                                                                       // MakerGen.cs:358
                                                    }                                                                                       // MakerGen.cs:359
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 152. ExplanationOfBenefit.addItem.detail.subDetail.unitPrice
                                            this.UnitPrice = new ElementDefinitionInfo                                                      // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "UnitPrice",                                                                         // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.unitPrice",                            // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.unitPrice",                             // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.Money                                                 // MakerGen.cs:357
                                                    {                                                                                       // MakerGen.cs:358
                                                    }                                                                                       // MakerGen.cs:359
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 153. ExplanationOfBenefit.addItem.detail.subDetail.factor
                                            this.Factor = new ElementDefinitionInfo                                                         // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Factor",                                                                            // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.factor",                               // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.factor",                                // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Decimal                                             // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 154. ExplanationOfBenefit.addItem.detail.subDetail.net
                                            this.Net = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Net",                                                                               // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.net",                                  // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.net",                                   // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.Money                                                 // MakerGen.cs:357
                                                    {                                                                                       // MakerGen.cs:358
                                                    }                                                                                       // MakerGen.cs:359
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 155. ExplanationOfBenefit.addItem.detail.subDetail.noteNumber
                                            this.NoteNumber = new ElementDefinitionInfo                                                     // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "NoteNumber",                                                                        // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.noteNumber",                           // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.noteNumber",                            // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = -1,                                                                                   // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                         // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 156. ExplanationOfBenefit.addItem.detail.subDetail.adjudication
                                            this.Adjudication = new ElementDefinitionInfo                                                   // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Adjudication",                                                                      // MakerGen.cs:255
                                                Path= "ExplanationOfBenefit.addItem.detail.subDetail.adjudication",                         // MakerGen.cs:256
                                                Id = "ExplanationOfBenefit.addItem.detail.subDetail.adjudication",                          // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = -1,                                                                                   // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                    }                                                                                                       // MakerGen.cs:429
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:414
                                    {                                                                                                       // MakerGen.cs:415
                                        base.Write(sDef);                                                                                   // MakerGen.cs:416
                                        ProductOrService.Write(sDef);                                                                       // MakerGen.cs:240
                                        Modifier.Write(sDef);                                                                               // MakerGen.cs:240
                                        Quantity.Write(sDef);                                                                               // MakerGen.cs:240
                                        UnitPrice.Write(sDef);                                                                              // MakerGen.cs:240
                                        Factor.Write(sDef);                                                                                 // MakerGen.cs:240
                                        Net.Write(sDef);                                                                                    // MakerGen.cs:240
                                        NoteNumber.Write(sDef);                                                                             // MakerGen.cs:240
                                        Adjudication.Write(sDef);                                                                           // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:433
                                }                                                                                                           // MakerGen.cs:393
                                public Type_SubDetail_Elements Elements { get; }                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                                public Type_SubDetail()                                                                                     // MakerGen.cs:396
                                {                                                                                                           // MakerGen.cs:397
                                    this.Elements = new Type_SubDetail_Elements();                                                          // MakerGen.cs:398
                                }                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:401
                                {                                                                                                           // MakerGen.cs:402
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:403
                                }                                                                                                           // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                            // 140. ExplanationOfBenefit.addItem.detail.productOrService
                            public ElementDefinitionInfo ProductOrService;                                                                  // MakerGen.cs:236
                            // 141. ExplanationOfBenefit.addItem.detail.modifier
                            public ElementDefinitionInfo Modifier;                                                                          // MakerGen.cs:236
                            // 142. ExplanationOfBenefit.addItem.detail.quantity
                            public ElementDefinitionInfo Quantity;                                                                          // MakerGen.cs:236
                            // 143. ExplanationOfBenefit.addItem.detail.unitPrice
                            public ElementDefinitionInfo UnitPrice;                                                                         // MakerGen.cs:236
                            // 144. ExplanationOfBenefit.addItem.detail.factor
                            public ElementDefinitionInfo Factor;                                                                            // MakerGen.cs:236
                            // 145. ExplanationOfBenefit.addItem.detail.net
                            public ElementDefinitionInfo Net;                                                                               // MakerGen.cs:236
                            // 146. ExplanationOfBenefit.addItem.detail.noteNumber
                            public ElementDefinitionInfo NoteNumber;                                                                        // MakerGen.cs:236
                            // 147. ExplanationOfBenefit.addItem.detail.adjudication
                            public ElementDefinitionInfo Adjudication;                                                                      // MakerGen.cs:236
                            public Type_Detail_Elements()                                                                                   // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 140. ExplanationOfBenefit.addItem.detail.productOrService
                                    this.ProductOrService = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "ProductOrService",                                                                          // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.addItem.detail.productOrService",                                       // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.addItem.detail.productOrService",                                        // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
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
                                    // 141. ExplanationOfBenefit.addItem.detail.modifier
                                    this.Modifier = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Modifier",                                                                                  // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.addItem.detail.modifier",                                               // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.addItem.detail.modifier",                                                // MakerGen.cs:257
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
                                    // 142. ExplanationOfBenefit.addItem.detail.quantity
                                    this.Quantity = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Quantity",                                                                                  // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.addItem.detail.quantity",                                               // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.addItem.detail.quantity",                                                // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 143. ExplanationOfBenefit.addItem.detail.unitPrice
                                    this.UnitPrice = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "UnitPrice",                                                                                 // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.addItem.detail.unitPrice",                                              // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.addItem.detail.unitPrice",                                               // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Money                                                         // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 144. ExplanationOfBenefit.addItem.detail.factor
                                    this.Factor = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Factor",                                                                                    // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.addItem.detail.factor",                                                 // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.addItem.detail.factor",                                                  // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 145. ExplanationOfBenefit.addItem.detail.net
                                    this.Net = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Net",                                                                                       // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.addItem.detail.net",                                                    // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.addItem.detail.net",                                                     // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Money                                                         // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 146. ExplanationOfBenefit.addItem.detail.noteNumber
                                    this.NoteNumber = new ElementDefinitionInfo                                                             // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "NoteNumber",                                                                                // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.addItem.detail.noteNumber",                                             // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.addItem.detail.noteNumber",                                              // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                 // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 147. ExplanationOfBenefit.addItem.detail.adjudication
                                    this.Adjudication = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Adjudication",                                                                              // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.addItem.detail.adjudication",                                           // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.addItem.detail.adjudication",                                            // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                ProductOrService.Write(sDef);                                                                               // MakerGen.cs:240
                                Modifier.Write(sDef);                                                                                       // MakerGen.cs:240
                                Quantity.Write(sDef);                                                                                       // MakerGen.cs:240
                                UnitPrice.Write(sDef);                                                                                      // MakerGen.cs:240
                                Factor.Write(sDef);                                                                                         // MakerGen.cs:240
                                Net.Write(sDef);                                                                                            // MakerGen.cs:240
                                NoteNumber.Write(sDef);                                                                                     // MakerGen.cs:240
                                Adjudication.Write(sDef);                                                                                   // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Detail_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Detail()                                                                                                // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Detail_Elements();                                                                     // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 122. ExplanationOfBenefit.addItem.itemSequence
                    public ElementDefinitionInfo ItemSequence;                                                                              // MakerGen.cs:236
                    // 123. ExplanationOfBenefit.addItem.detailSequence
                    public ElementDefinitionInfo DetailSequence;                                                                            // MakerGen.cs:236
                    // 124. ExplanationOfBenefit.addItem.subDetailSequence
                    public ElementDefinitionInfo SubDetailSequence;                                                                         // MakerGen.cs:236
                    // 125. ExplanationOfBenefit.addItem.provider
                    public ElementDefinitionInfo Provider;                                                                                  // MakerGen.cs:236
                    // 126. ExplanationOfBenefit.addItem.productOrService
                    public ElementDefinitionInfo ProductOrService;                                                                          // MakerGen.cs:236
                    // 127. ExplanationOfBenefit.addItem.modifier
                    public ElementDefinitionInfo Modifier;                                                                                  // MakerGen.cs:236
                    // 128. ExplanationOfBenefit.addItem.programCode
                    public ElementDefinitionInfo ProgramCode;                                                                               // MakerGen.cs:236
                    // 129. ExplanationOfBenefit.addItem.serviced[x]
                    public ElementDefinitionInfo Serviced;                                                                                  // MakerGen.cs:236
                    // 130. ExplanationOfBenefit.addItem.location[x]
                    public ElementDefinitionInfo Location;                                                                                  // MakerGen.cs:236
                    // 131. ExplanationOfBenefit.addItem.quantity
                    public ElementDefinitionInfo Quantity;                                                                                  // MakerGen.cs:236
                    // 132. ExplanationOfBenefit.addItem.unitPrice
                    public ElementDefinitionInfo UnitPrice;                                                                                 // MakerGen.cs:236
                    // 133. ExplanationOfBenefit.addItem.factor
                    public ElementDefinitionInfo Factor;                                                                                    // MakerGen.cs:236
                    // 134. ExplanationOfBenefit.addItem.net
                    public ElementDefinitionInfo Net;                                                                                       // MakerGen.cs:236
                    // 135. ExplanationOfBenefit.addItem.bodySite
                    public ElementDefinitionInfo BodySite;                                                                                  // MakerGen.cs:236
                    // 136. ExplanationOfBenefit.addItem.subSite
                    public ElementDefinitionInfo SubSite;                                                                                   // MakerGen.cs:236
                    // 137. ExplanationOfBenefit.addItem.noteNumber
                    public ElementDefinitionInfo NoteNumber;                                                                                // MakerGen.cs:236
                    // 138. ExplanationOfBenefit.addItem.adjudication
                    public ElementDefinitionInfo Adjudication;                                                                              // MakerGen.cs:236
                    public Type_AddItem_Elements()                                                                                          // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 122. ExplanationOfBenefit.addItem.itemSequence
                            this.ItemSequence = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ItemSequence",                                                                                      // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.itemSequence",                                                          // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.itemSequence",                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 123. ExplanationOfBenefit.addItem.detailSequence
                            this.DetailSequence = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "DetailSequence",                                                                                    // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.detailSequence",                                                        // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.detailSequence",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 124. ExplanationOfBenefit.addItem.subDetailSequence
                            this.SubDetailSequence = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "SubDetailSequence",                                                                                 // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.subDetailSequence",                                                     // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.subDetailSequence",                                                      // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 125. ExplanationOfBenefit.addItem.provider
                            this.Provider = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Provider",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.provider",                                                              // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.provider",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 126. ExplanationOfBenefit.addItem.productOrService
                            this.ProductOrService = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ProductOrService",                                                                                  // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.productOrService",                                                      // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.productOrService",                                                       // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 127. ExplanationOfBenefit.addItem.modifier
                            this.Modifier = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Modifier",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.modifier",                                                              // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.modifier",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 128. ExplanationOfBenefit.addItem.programCode
                            this.ProgramCode = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ProgramCode",                                                                                       // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.programCode",                                                           // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.programCode",                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 129. ExplanationOfBenefit.addItem.serviced[x]
                            this.Serviced = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Serviced",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.serviced[x]",                                                           // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.serviced[x]",                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 130. ExplanationOfBenefit.addItem.location[x]
                            this.Location = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Location",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.location[x]",                                                           // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.location[x]",                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    },                                                                                                      // MakerGen.cs:318
                                    new FhirKhit.Maker.Common.Complex.Address                                                               // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Location"                                              // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 131. ExplanationOfBenefit.addItem.quantity
                            this.Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Quantity",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.quantity",                                                              // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.quantity",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 132. ExplanationOfBenefit.addItem.unitPrice
                            this.UnitPrice = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "UnitPrice",                                                                                         // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.unitPrice",                                                             // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.unitPrice",                                                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 133. ExplanationOfBenefit.addItem.factor
                            this.Factor = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Factor",                                                                                            // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.factor",                                                                // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.factor",                                                                 // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 134. ExplanationOfBenefit.addItem.net
                            this.Net = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Net",                                                                                               // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.net",                                                                   // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.net",                                                                    // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 135. ExplanationOfBenefit.addItem.bodySite
                            this.BodySite = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "BodySite",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.bodySite",                                                              // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.bodySite",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 136. ExplanationOfBenefit.addItem.subSite
                            this.SubSite = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "SubSite",                                                                                           // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.subSite",                                                               // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.subSite",                                                                // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 137. ExplanationOfBenefit.addItem.noteNumber
                            this.NoteNumber = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "NoteNumber",                                                                                        // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.noteNumber",                                                            // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.noteNumber",                                                             // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 138. ExplanationOfBenefit.addItem.adjudication
                            this.Adjudication = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Adjudication",                                                                                      // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.addItem.adjudication",                                                          // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.addItem.adjudication",                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        ItemSequence.Write(sDef);                                                                                           // MakerGen.cs:240
                        DetailSequence.Write(sDef);                                                                                         // MakerGen.cs:240
                        SubDetailSequence.Write(sDef);                                                                                      // MakerGen.cs:240
                        Provider.Write(sDef);                                                                                               // MakerGen.cs:240
                        ProductOrService.Write(sDef);                                                                                       // MakerGen.cs:240
                        Modifier.Write(sDef);                                                                                               // MakerGen.cs:240
                        ProgramCode.Write(sDef);                                                                                            // MakerGen.cs:240
                        Serviced.Write(sDef);                                                                                               // MakerGen.cs:240
                        Location.Write(sDef);                                                                                               // MakerGen.cs:240
                        Quantity.Write(sDef);                                                                                               // MakerGen.cs:240
                        UnitPrice.Write(sDef);                                                                                              // MakerGen.cs:240
                        Factor.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Net.Write(sDef);                                                                                                    // MakerGen.cs:240
                        BodySite.Write(sDef);                                                                                               // MakerGen.cs:240
                        SubSite.Write(sDef);                                                                                                // MakerGen.cs:240
                        NoteNumber.Write(sDef);                                                                                             // MakerGen.cs:240
                        Adjudication.Write(sDef);                                                                                           // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_AddItem_Elements Elements { get; }                                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_AddItem()                                                                                                       // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_AddItem_Elements();                                                                            // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 158. ExplanationOfBenefit.total
            public class Type_Total : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Total_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 159. ExplanationOfBenefit.total.category
                    public ElementDefinitionInfo Category;                                                                                  // MakerGen.cs:236
                    // 160. ExplanationOfBenefit.total.amount
                    public ElementDefinitionInfo Amount;                                                                                    // MakerGen.cs:236
                    public Type_Total_Elements()                                                                                            // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 159. ExplanationOfBenefit.total.category
                            this.Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Category",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.total.category",                                                                // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.total.category",                                                                 // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 160. ExplanationOfBenefit.total.amount
                            this.Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Amount",                                                                                            // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.total.amount",                                                                  // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.total.amount",                                                                   // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Category.Write(sDef);                                                                                               // MakerGen.cs:240
                        Amount.Write(sDef);                                                                                                 // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Total_Elements Elements { get; }                                                                                // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Total()                                                                                                         // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Total_Elements();                                                                              // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 161. ExplanationOfBenefit.payment
            public class Type_Payment : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Payment_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 162. ExplanationOfBenefit.payment.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 163. ExplanationOfBenefit.payment.adjustment
                    public ElementDefinitionInfo Adjustment;                                                                                // MakerGen.cs:236
                    // 164. ExplanationOfBenefit.payment.adjustmentReason
                    public ElementDefinitionInfo AdjustmentReason;                                                                          // MakerGen.cs:236
                    // 165. ExplanationOfBenefit.payment.date
                    public ElementDefinitionInfo Date;                                                                                      // MakerGen.cs:236
                    // 166. ExplanationOfBenefit.payment.amount
                    public ElementDefinitionInfo Amount;                                                                                    // MakerGen.cs:236
                    // 167. ExplanationOfBenefit.payment.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:236
                    public Type_Payment_Elements()                                                                                          // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 162. ExplanationOfBenefit.payment.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.payment.type",                                                                  // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.payment.type",                                                                   // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 163. ExplanationOfBenefit.payment.adjustment
                            this.Adjustment = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Adjustment",                                                                                        // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.payment.adjustment",                                                            // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.payment.adjustment",                                                             // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 164. ExplanationOfBenefit.payment.adjustmentReason
                            this.AdjustmentReason = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "AdjustmentReason",                                                                                  // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.payment.adjustmentReason",                                                      // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.payment.adjustmentReason",                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 165. ExplanationOfBenefit.payment.date
                            this.Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Date",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.payment.date",                                                                  // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.payment.date",                                                                   // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 166. ExplanationOfBenefit.payment.amount
                            this.Amount = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Amount",                                                                                            // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.payment.amount",                                                                // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.payment.amount",                                                                 // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 167. ExplanationOfBenefit.payment.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Identifier",                                                                                        // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.payment.identifier",                                                            // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.payment.identifier",                                                             // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Adjustment.Write(sDef);                                                                                             // MakerGen.cs:240
                        AdjustmentReason.Write(sDef);                                                                                       // MakerGen.cs:240
                        Date.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Amount.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Payment_Elements Elements { get; }                                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Payment()                                                                                                       // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Payment_Elements();                                                                            // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 170. ExplanationOfBenefit.processNote
            public class Type_ProcessNote : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_ProcessNote_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 171. ExplanationOfBenefit.processNote.number
                    public ElementDefinitionInfo Number;                                                                                    // MakerGen.cs:236
                    // 172. ExplanationOfBenefit.processNote.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 173. ExplanationOfBenefit.processNote.text
                    public ElementDefinitionInfo Text;                                                                                      // MakerGen.cs:236
                    // 174. ExplanationOfBenefit.processNote.language
                    public ElementDefinitionInfo Language;                                                                                  // MakerGen.cs:236
                    public Type_ProcessNote_Elements()                                                                                      // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 171. ExplanationOfBenefit.processNote.number
                            this.Number = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Number",                                                                                            // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.processNote.number",                                                            // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.processNote.number",                                                             // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 172. ExplanationOfBenefit.processNote.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.processNote.type",                                                              // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.processNote.type",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 173. ExplanationOfBenefit.processNote.text
                            this.Text = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Text",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.processNote.text",                                                              // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.processNote.text",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 174. ExplanationOfBenefit.processNote.language
                            this.Language = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Language",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.processNote.language",                                                          // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.processNote.language",                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
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
                        Number.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Text.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Language.Write(sDef);                                                                                               // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_ProcessNote_Elements Elements { get; }                                                                          // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_ProcessNote()                                                                                                   // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_ProcessNote_Elements();                                                                        // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 176. ExplanationOfBenefit.benefitBalance
            public class Type_BenefitBalance : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_BenefitBalance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 184. ExplanationOfBenefit.benefitBalance.financial
                    public class Type_Financial : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Financial_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 185. ExplanationOfBenefit.benefitBalance.financial.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:236
                            // 186. ExplanationOfBenefit.benefitBalance.financial.allowed[x]
                            public ElementDefinitionInfo Allowed;                                                                           // MakerGen.cs:236
                            // 187. ExplanationOfBenefit.benefitBalance.financial.used[x]
                            public ElementDefinitionInfo Used;                                                                              // MakerGen.cs:236
                            public Type_Financial_Elements()                                                                                // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 185. ExplanationOfBenefit.benefitBalance.financial.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Type",                                                                                      // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.benefitBalance.financial.type",                                         // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.benefitBalance.financial.type",                                          // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
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
                                    // 186. ExplanationOfBenefit.benefitBalance.financial.allowed[x]
                                    this.Allowed = new ElementDefinitionInfo                                                                // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Allowed",                                                                                   // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.benefitBalance.financial.allowed[x]",                                   // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.benefitBalance.financial.allowed[x]",                                    // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                 // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            },                                                                                              // MakerGen.cs:303
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            },                                                                                              // MakerGen.cs:303
                                            new FhirKhit.Maker.Common.Complex.Money                                                         // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 187. ExplanationOfBenefit.benefitBalance.financial.used[x]
                                    this.Used = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Used",                                                                                      // MakerGen.cs:255
                                        Path= "ExplanationOfBenefit.benefitBalance.financial.used[x]",                                      // MakerGen.cs:256
                                        Id = "ExplanationOfBenefit.benefitBalance.financial.used[x]",                                       // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                 // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            },                                                                                              // MakerGen.cs:303
                                            new FhirKhit.Maker.Common.Complex.Money                                                         // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Type.Write(sDef);                                                                                           // MakerGen.cs:240
                                Allowed.Write(sDef);                                                                                        // MakerGen.cs:240
                                Used.Write(sDef);                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Financial_Elements Elements { get; }                                                                    // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Financial()                                                                                             // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Financial_Elements();                                                                  // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 177. ExplanationOfBenefit.benefitBalance.category
                    public ElementDefinitionInfo Category;                                                                                  // MakerGen.cs:236
                    // 178. ExplanationOfBenefit.benefitBalance.excluded
                    public ElementDefinitionInfo Excluded;                                                                                  // MakerGen.cs:236
                    // 179. ExplanationOfBenefit.benefitBalance.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:236
                    // 180. ExplanationOfBenefit.benefitBalance.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:236
                    // 181. ExplanationOfBenefit.benefitBalance.network
                    public ElementDefinitionInfo Network;                                                                                   // MakerGen.cs:236
                    // 182. ExplanationOfBenefit.benefitBalance.unit
                    public ElementDefinitionInfo Unit;                                                                                      // MakerGen.cs:236
                    // 183. ExplanationOfBenefit.benefitBalance.term
                    public ElementDefinitionInfo Term;                                                                                      // MakerGen.cs:236
                    public Type_BenefitBalance_Elements()                                                                                   // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 177. ExplanationOfBenefit.benefitBalance.category
                            this.Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Category",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.benefitBalance.category",                                                       // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.benefitBalance.category",                                                        // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 178. ExplanationOfBenefit.benefitBalance.excluded
                            this.Excluded = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Excluded",                                                                                          // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.benefitBalance.excluded",                                                       // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.benefitBalance.excluded",                                                        // MakerGen.cs:257
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
                            // 179. ExplanationOfBenefit.benefitBalance.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Name",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.benefitBalance.name",                                                           // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.benefitBalance.name",                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 180. ExplanationOfBenefit.benefitBalance.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Description",                                                                                       // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.benefitBalance.description",                                                    // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.benefitBalance.description",                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 181. ExplanationOfBenefit.benefitBalance.network
                            this.Network = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Network",                                                                                           // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.benefitBalance.network",                                                        // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.benefitBalance.network",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 182. ExplanationOfBenefit.benefitBalance.unit
                            this.Unit = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Unit",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.benefitBalance.unit",                                                           // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.benefitBalance.unit",                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 183. ExplanationOfBenefit.benefitBalance.term
                            this.Term = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Term",                                                                                              // MakerGen.cs:255
                                Path= "ExplanationOfBenefit.benefitBalance.term",                                                           // MakerGen.cs:256
                                Id = "ExplanationOfBenefit.benefitBalance.term",                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
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
                        Category.Write(sDef);                                                                                               // MakerGen.cs:240
                        Excluded.Write(sDef);                                                                                               // MakerGen.cs:240
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Description.Write(sDef);                                                                                            // MakerGen.cs:240
                        Network.Write(sDef);                                                                                                // MakerGen.cs:240
                        Unit.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Term.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_BenefitBalance_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_BenefitBalance()                                                                                                // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_BenefitBalance_Elements();                                                                     // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. ExplanationOfBenefit.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. ExplanationOfBenefit.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 3. ExplanationOfBenefit.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:236
            // 4. ExplanationOfBenefit.subType
            public ElementDefinitionInfo SubType;                                                                                           // MakerGen.cs:236
            // 5. ExplanationOfBenefit.use
            public ElementDefinitionInfo Use;                                                                                               // MakerGen.cs:236
            // 6. ExplanationOfBenefit.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:236
            // 7. ExplanationOfBenefit.billablePeriod
            public ElementDefinitionInfo BillablePeriod;                                                                                    // MakerGen.cs:236
            // 8. ExplanationOfBenefit.created
            public ElementDefinitionInfo Created;                                                                                           // MakerGen.cs:236
            // 9. ExplanationOfBenefit.enterer
            public ElementDefinitionInfo Enterer;                                                                                           // MakerGen.cs:236
            // 10. ExplanationOfBenefit.insurer
            public ElementDefinitionInfo Insurer;                                                                                           // MakerGen.cs:236
            // 11. ExplanationOfBenefit.provider
            public ElementDefinitionInfo Provider;                                                                                          // MakerGen.cs:236
            // 12. ExplanationOfBenefit.priority
            public ElementDefinitionInfo Priority;                                                                                          // MakerGen.cs:236
            // 13. ExplanationOfBenefit.fundsReserveRequested
            public ElementDefinitionInfo FundsReserveRequested;                                                                             // MakerGen.cs:236
            // 14. ExplanationOfBenefit.fundsReserve
            public ElementDefinitionInfo FundsReserve;                                                                                      // MakerGen.cs:236
            // 19. ExplanationOfBenefit.prescription
            public ElementDefinitionInfo Prescription;                                                                                      // MakerGen.cs:236
            // 20. ExplanationOfBenefit.originalPrescription
            public ElementDefinitionInfo OriginalPrescription;                                                                              // MakerGen.cs:236
            // 24. ExplanationOfBenefit.referral
            public ElementDefinitionInfo Referral;                                                                                          // MakerGen.cs:236
            // 25. ExplanationOfBenefit.facility
            public ElementDefinitionInfo Facility;                                                                                          // MakerGen.cs:236
            // 26. ExplanationOfBenefit.claim
            public ElementDefinitionInfo Claim;                                                                                             // MakerGen.cs:236
            // 27. ExplanationOfBenefit.claimResponse
            public ElementDefinitionInfo ClaimResponse;                                                                                     // MakerGen.cs:236
            // 28. ExplanationOfBenefit.outcome
            public ElementDefinitionInfo Outcome;                                                                                           // MakerGen.cs:236
            // 29. ExplanationOfBenefit.disposition
            public ElementDefinitionInfo Disposition;                                                                                       // MakerGen.cs:236
            // 30. ExplanationOfBenefit.preAuthRef
            public ElementDefinitionInfo PreAuthRef;                                                                                        // MakerGen.cs:236
            // 31. ExplanationOfBenefit.preAuthRefPeriod
            public ElementDefinitionInfo PreAuthRefPeriod;                                                                                  // MakerGen.cs:236
            // 57. ExplanationOfBenefit.precedence
            public ElementDefinitionInfo Precedence;                                                                                        // MakerGen.cs:236
            // 157. ExplanationOfBenefit.adjudication
            public ElementDefinitionInfo Adjudication;                                                                                      // MakerGen.cs:236
            // 168. ExplanationOfBenefit.formCode
            public ElementDefinitionInfo FormCode;                                                                                          // MakerGen.cs:236
            // 169. ExplanationOfBenefit.form
            public ElementDefinitionInfo Form;                                                                                              // MakerGen.cs:236
            // 175. ExplanationOfBenefit.benefitPeriod
            public ElementDefinitionInfo BenefitPeriod;                                                                                     // MakerGen.cs:236
            public ExplanationOfBenefit_Elements()                                                                                          // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. ExplanationOfBenefit.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.identifier",                                                                            // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.identifier",                                                                             // MakerGen.cs:257
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
                    // 2. ExplanationOfBenefit.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.status",                                                                                // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.status",                                                                                 // MakerGen.cs:257
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
                    // 3. ExplanationOfBenefit.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Type",                                                                                                      // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.type",                                                                                  // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.type",                                                                                   // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. ExplanationOfBenefit.subType
                    this.SubType = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "SubType",                                                                                                   // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.subType",                                                                               // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.subType",                                                                                // MakerGen.cs:257
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
                {                                                                                                                           // MakerGen.cs:251
                    // 5. ExplanationOfBenefit.use
                    this.Use = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Use",                                                                                                       // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.use",                                                                                   // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.use",                                                                                    // MakerGen.cs:257
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
                    // 6. ExplanationOfBenefit.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Patient",                                                                                                   // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.patient",                                                                               // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.patient",                                                                                // MakerGen.cs:257
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
                    // 7. ExplanationOfBenefit.billablePeriod
                    this.BillablePeriod = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "BillablePeriod",                                                                                            // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.billablePeriod",                                                                        // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.billablePeriod",                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 8. ExplanationOfBenefit.created
                    this.Created = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Created",                                                                                                   // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.created",                                                                               // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.created",                                                                                // MakerGen.cs:257
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
                    // 9. ExplanationOfBenefit.enterer
                    this.Enterer = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Enterer",                                                                                                   // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.enterer",                                                                               // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.enterer",                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. ExplanationOfBenefit.insurer
                    this.Insurer = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Insurer",                                                                                                   // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.insurer",                                                                               // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.insurer",                                                                                // MakerGen.cs:257
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
                    // 11. ExplanationOfBenefit.provider
                    this.Provider = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Provider",                                                                                                  // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.provider",                                                                              // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.provider",                                                                               // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
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
                    // 12. ExplanationOfBenefit.priority
                    this.Priority = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Priority",                                                                                                  // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.priority",                                                                              // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.priority",                                                                               // MakerGen.cs:257
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
                {                                                                                                                           // MakerGen.cs:251
                    // 13. ExplanationOfBenefit.fundsReserveRequested
                    this.FundsReserveRequested = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "FundsReserveRequested",                                                                                     // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.fundsReserveRequested",                                                                 // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.fundsReserveRequested",                                                                  // MakerGen.cs:257
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
                {                                                                                                                           // MakerGen.cs:251
                    // 14. ExplanationOfBenefit.fundsReserve
                    this.FundsReserve = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "FundsReserve",                                                                                              // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.fundsReserve",                                                                          // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.fundsReserve",                                                                           // MakerGen.cs:257
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
                {                                                                                                                           // MakerGen.cs:251
                    // 19. ExplanationOfBenefit.prescription
                    this.Prescription = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Prescription",                                                                                              // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.prescription",                                                                          // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.prescription",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicationRequest",                                            // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/VisionPrescription"                                            // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 20. ExplanationOfBenefit.originalPrescription
                    this.OriginalPrescription = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "OriginalPrescription",                                                                                      // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.originalPrescription",                                                                  // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.originalPrescription",                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicationRequest"                                             // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 24. ExplanationOfBenefit.referral
                    this.Referral = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Referral",                                                                                                  // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.referral",                                                                              // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.referral",                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 25. ExplanationOfBenefit.facility
                    this.Facility = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Facility",                                                                                                  // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.facility",                                                                              // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.facility",                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 26. ExplanationOfBenefit.claim
                    this.Claim = new ElementDefinitionInfo                                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Claim",                                                                                                     // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.claim",                                                                                 // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.claim",                                                                                  // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Claim"                                                         // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 27. ExplanationOfBenefit.claimResponse
                    this.ClaimResponse = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ClaimResponse",                                                                                             // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.claimResponse",                                                                         // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.claimResponse",                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ClaimResponse"                                                 // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 28. ExplanationOfBenefit.outcome
                    this.Outcome = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Outcome",                                                                                                   // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.outcome",                                                                               // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.outcome",                                                                                // MakerGen.cs:257
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
                    // 29. ExplanationOfBenefit.disposition
                    this.Disposition = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Disposition",                                                                                               // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.disposition",                                                                           // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.disposition",                                                                            // MakerGen.cs:257
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
                    // 30. ExplanationOfBenefit.preAuthRef
                    this.PreAuthRef = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PreAuthRef",                                                                                                // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.preAuthRef",                                                                            // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.preAuthRef",                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 31. ExplanationOfBenefit.preAuthRefPeriod
                    this.PreAuthRefPeriod = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PreAuthRefPeriod",                                                                                          // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.preAuthRefPeriod",                                                                      // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.preAuthRefPeriod",                                                                       // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 57. ExplanationOfBenefit.precedence
                    this.Precedence = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Precedence",                                                                                                // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.precedence",                                                                            // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.precedence",                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                                 // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 157. ExplanationOfBenefit.adjudication
                    this.Adjudication = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Adjudication",                                                                                              // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.adjudication",                                                                          // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.adjudication",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 168. ExplanationOfBenefit.formCode
                    this.FormCode = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "FormCode",                                                                                                  // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.formCode",                                                                              // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.formCode",                                                                               // MakerGen.cs:257
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
                {                                                                                                                           // MakerGen.cs:251
                    // 169. ExplanationOfBenefit.form
                    this.Form = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Form",                                                                                                      // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.form",                                                                                  // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.form",                                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Attachment                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 175. ExplanationOfBenefit.benefitPeriod
                    this.BenefitPeriod = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "BenefitPeriod",                                                                                             // MakerGen.cs:255
                        Path= "ExplanationOfBenefit.benefitPeriod",                                                                         // MakerGen.cs:256
                        Id = "ExplanationOfBenefit.benefitPeriod",                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Type.Write(sDef);                                                                                                           // MakerGen.cs:240
                SubType.Write(sDef);                                                                                                        // MakerGen.cs:240
                Use.Write(sDef);                                                                                                            // MakerGen.cs:240
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:240
                BillablePeriod.Write(sDef);                                                                                                 // MakerGen.cs:240
                Created.Write(sDef);                                                                                                        // MakerGen.cs:240
                Enterer.Write(sDef);                                                                                                        // MakerGen.cs:240
                Insurer.Write(sDef);                                                                                                        // MakerGen.cs:240
                Provider.Write(sDef);                                                                                                       // MakerGen.cs:240
                Priority.Write(sDef);                                                                                                       // MakerGen.cs:240
                FundsReserveRequested.Write(sDef);                                                                                          // MakerGen.cs:240
                FundsReserve.Write(sDef);                                                                                                   // MakerGen.cs:240
                Prescription.Write(sDef);                                                                                                   // MakerGen.cs:240
                OriginalPrescription.Write(sDef);                                                                                           // MakerGen.cs:240
                Referral.Write(sDef);                                                                                                       // MakerGen.cs:240
                Facility.Write(sDef);                                                                                                       // MakerGen.cs:240
                Claim.Write(sDef);                                                                                                          // MakerGen.cs:240
                ClaimResponse.Write(sDef);                                                                                                  // MakerGen.cs:240
                Outcome.Write(sDef);                                                                                                        // MakerGen.cs:240
                Disposition.Write(sDef);                                                                                                    // MakerGen.cs:240
                PreAuthRef.Write(sDef);                                                                                                     // MakerGen.cs:240
                PreAuthRefPeriod.Write(sDef);                                                                                               // MakerGen.cs:240
                Precedence.Write(sDef);                                                                                                     // MakerGen.cs:240
                Adjudication.Write(sDef);                                                                                                   // MakerGen.cs:240
                FormCode.Write(sDef);                                                                                                       // MakerGen.cs:240
                Form.Write(sDef);                                                                                                           // MakerGen.cs:240
                BenefitPeriod.Write(sDef);                                                                                                  // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public ExplanationOfBenefit_Elements Elements { get; }                                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public ExplanationOfBenefit()                                                                                                       // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new ExplanationOfBenefit_Elements();                                                                            // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
