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
      "id": "Claim",
      "url": "http://hl7.org/fhir/StructureDefinition/Claim",
      "version": "4.0.0",
      "name": "Claim",
      "status": "draft",
      "publisher": "Health Level Seven International (Financial Management)",
      "description": "A provider issued list of professional services and products which have been provided, or are to be provided, to a patient which is sent to an insurer for reimbursement.",
      "purpose": "The Claim resource is used by providers to exchange services and products rendered to patients or planned to be rendered with insurers for reimbuserment. It is also used by insurers to exchange claims information with statutory reporting and data analytics firms.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Claim",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Claim",
            "path": "Claim",
            "short": "Claim, Pre-determination or Pre-authorization",
            "definition": "A provider issued list of professional services and products which have been provided, or are to be provided, to a patient which is sent to an insurer for reimbursement.",
            "comment": "The Claim resource fulfills three information request requirements: Claim - a request for adjudication for reimbursement for products and/or services provided; Preauthorization - a request to authorize the future provision of products and/or services including an anticipated adjudication; and, Predetermination - a request for a non-bind adjudication of possible future products and/or services.",
            "alias": [
              "Adjudication Request",
              "Preauthorization Request",
              "Predetermination Request"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "Claim.identifier",
            "path": "Claim.identifier",
            "short": "Business Identifier for claim",
            "definition": "A unique identifier assigned to this claim.",
            "requirements": "Allows claims to be distinguished and referenced.",
            "alias": [
              "Claim Number"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "Claim.status",
            "path": "Claim.status",
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
                  "valueString": "ClaimStatus"
                }
              ],
              "strength": "required",
              "description": "A code specifying the state of the resource instance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/fm-status|4.0.0"
            }
          },
          {
            "id": "Claim.type",
            "path": "Claim.type",
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
            "id": "Claim.subType",
            "path": "Claim.subType",
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
            "id": "Claim.use",
            "path": "Claim.use",
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
              "description": "The purpose of the Claim: predetermination, preauthorization, claim.",
              "valueSet": "http://hl7.org/fhir/ValueSet/claim-use|4.0.0"
            }
          },
          {
            "id": "Claim.patient",
            "path": "Claim.patient",
            "short": "The recipient of the products and services",
            "definition": "The party to whom the professional services and/or products have been supplied or are being considered and for whom actual or forecast reimbursement is sought.",
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
            "id": "Claim.billablePeriod",
            "path": "Claim.billablePeriod",
            "short": "Relevant time frame for the claim",
            "definition": "The period for which charges are being submitted.",
            "comment": "Typically this would be today or in the past for a claim, and today or in the future for preauthorizations and predeterminations. Typically line item dates of service should fall within the billing period if one is specified.",
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
            "id": "Claim.created",
            "path": "Claim.created",
            "short": "Resource creation date",
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
            "id": "Claim.enterer",
            "path": "Claim.enterer",
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
            "id": "Claim.insurer",
            "path": "Claim.insurer",
            "short": "Target",
            "definition": "The Insurer who is target of the request.",
            "min": 0,
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
            "id": "Claim.provider",
            "path": "Claim.provider",
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
            "id": "Claim.priority",
            "path": "Claim.priority",
            "short": "Desired processing ugency",
            "definition": "The provider-required urgency of processing the request. Typical values include: stat, routine deferred.",
            "comment": "If a claim processor is unable to complete the processing as per the priority then they should generate and error and not process the request.",
            "requirements": "The provider may need to indicate their processing requirements so that the processor can indicate if they are unable to comply.",
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
                  "valueString": "ProcessPriority"
                }
              ],
              "strength": "example",
              "description": "The timeliness with which processing is required: stat, normal, deferred.",
              "valueSet": "http://hl7.org/fhir/ValueSet/process-priority"
            }
          },
          {
            "id": "Claim.fundsReserve",
            "path": "Claim.fundsReserve",
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
            "id": "Claim.related",
            "path": "Claim.related",
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
            "id": "Claim.related.claim",
            "path": "Claim.related.claim",
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
            "id": "Claim.related.relationship",
            "path": "Claim.related.relationship",
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
            "id": "Claim.related.reference",
            "path": "Claim.related.reference",
            "short": "File or case reference",
            "definition": "An alternate organizational reference to the case or file to which this particular claim pertains.",
            "comment": "For example, Property/Casualty insurer claim # or Workers Compensation case # .",
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
            "id": "Claim.prescription",
            "path": "Claim.prescription",
            "short": "Prescription authorizing services and products",
            "definition": "Prescription to support the dispensing of pharmacy, device or vision products.",
            "requirements": "Required to authorize the dispensing of controlled substances and devices.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DeviceRequest",
                  "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
                  "http://hl7.org/fhir/StructureDefinition/VisionPrescription"
                ]
              }
            ]
          },
          {
            "id": "Claim.originalPrescription",
            "path": "Claim.originalPrescription",
            "short": "Original prescription if superseded by fulfiller",
            "definition": "Original prescription which has been superseded by this prescription to support the dispensing of pharmacy services, medications or products.",
            "comment": "For example, a physician may prescribe a medication which the pharmacy determines is contraindicated, or for which the patient has an intolerance, and therefore issues a new prescription for an alternate medication which has the same therapeutic intent. The prescription from the pharmacy becomes the 'prescription' and that from the physician becomes the 'original prescription'.",
            "requirements": "Often required when a fulfiller varies what is fulfilled from that authorized on the original prescription.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DeviceRequest",
                  "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
                  "http://hl7.org/fhir/StructureDefinition/VisionPrescription"
                ]
              }
            ]
          },
          {
            "id": "Claim.payee",
            "path": "Claim.payee",
            "short": "Recipient of benefits payable",
            "definition": "The party to be reimbursed for cost of the products and services according to the terms of the policy.",
            "comment": "Often providers agree to receive the benefits payable to reduce the near-term costs to the patient. The insurer may decline to pay the provider and choose to pay the subscriber instead.",
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
            "id": "Claim.payee.type",
            "path": "Claim.payee.type",
            "short": "Category of recipient",
            "definition": "Type of Party to be reimbursed: subscriber, provider, other.",
            "requirements": "Need to know who should receive payment with the most common situations being the Provider (assignment of benefits) or the Subscriber.",
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
            "id": "Claim.payee.party",
            "path": "Claim.payee.party",
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
            "id": "Claim.referral",
            "path": "Claim.referral",
            "short": "Treatment referral",
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
            "id": "Claim.facility",
            "path": "Claim.facility",
            "short": "Servicing facility",
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
            "id": "Claim.careTeam",
            "path": "Claim.careTeam",
            "short": "Members of the care team",
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
            "id": "Claim.careTeam.sequence",
            "path": "Claim.careTeam.sequence",
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
            "id": "Claim.careTeam.provider",
            "path": "Claim.careTeam.provider",
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
            "id": "Claim.careTeam.responsible",
            "path": "Claim.careTeam.responsible",
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
            "id": "Claim.careTeam.role",
            "path": "Claim.careTeam.role",
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
            "id": "Claim.careTeam.qualification",
            "path": "Claim.careTeam.qualification",
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
            "id": "Claim.supportingInfo",
            "path": "Claim.supportingInfo",
            "short": "Supporting information",
            "definition": "Additional information codes regarding exceptions, special considerations, the condition, situation, prior or concurrent issues.",
            "comment": "Often there are multiple jurisdiction specific valuesets which are required.",
            "requirements": "Typically these information codes are required to support the services rendered or the adjudication of the services rendered.",
            "alias": [
              "Attachments\nException Codes\nOccurrence Codes\nValue codes"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Claim.supportingInfo.sequence",
            "path": "Claim.supportingInfo.sequence",
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
            "id": "Claim.supportingInfo.category",
            "path": "Claim.supportingInfo.category",
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
            "id": "Claim.supportingInfo.code",
            "path": "Claim.supportingInfo.code",
            "short": "Type of information",
            "definition": "System and code pertaining to the specific information regarding special conditions relating to the setting, treatment or patient  for which care is sought.",
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
            "id": "Claim.supportingInfo.timing[x]",
            "path": "Claim.supportingInfo.timing[x]",
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
            "id": "Claim.supportingInfo.value[x]",
            "path": "Claim.supportingInfo.value[x]",
            "short": "Data to be provided",
            "definition": "Additional data or information such as resources, documents, images etc. including references to the data or the actual inclusion of the data.",
            "comment": "Could be used to provide references to other resources, document. For example could contain a PDF in an Attachment of the Police Report for an Accident.",
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
            "id": "Claim.supportingInfo.reason",
            "path": "Claim.supportingInfo.reason",
            "short": "Explanation for the information",
            "definition": "Provides the reason in the situation where a reason code is required in addition to the content.",
            "comment": "For example: the reason for the additional stay, or why a tooth is  missing.",
            "requirements": "Needed when the supporting information has both a date and amount/value and requires explanation.",
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
                  "valueString": "MissingReason"
                }
              ],
              "strength": "example",
              "description": "Reason codes for the missing teeth.",
              "valueSet": "http://hl7.org/fhir/ValueSet/missing-tooth-reason"
            }
          },
          {
            "id": "Claim.diagnosis",
            "path": "Claim.diagnosis",
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
            "id": "Claim.diagnosis.sequence",
            "path": "Claim.diagnosis.sequence",
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
            "id": "Claim.diagnosis.diagnosis[x]",
            "path": "Claim.diagnosis.diagnosis[x]",
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
              "description": "Example ICD10 Diagnostic codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/icd-10"
            }
          },
          {
            "id": "Claim.diagnosis.type",
            "path": "Claim.diagnosis.type",
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
            "id": "Claim.diagnosis.onAdmission",
            "path": "Claim.diagnosis.onAdmission",
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
            "id": "Claim.diagnosis.packageCode",
            "path": "Claim.diagnosis.packageCode",
            "short": "Package billing code",
            "definition": "A package billing code or bundle code used to group products and services to a particular health condition (such as heart attack) which is based on a predetermined grouping code system.",
            "comment": "For example DRG (Diagnosis Related Group) or a bundled billing code. A patient may have a diagnosis of a Myocardial Infarction and a DRG for HeartAttack would be assigned. The Claim item (and possible subsequent claims) would refer to the DRG for those line items that were for services related to the heart attack event.",
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
            "id": "Claim.procedure",
            "path": "Claim.procedure",
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
            "id": "Claim.procedure.sequence",
            "path": "Claim.procedure.sequence",
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
            "id": "Claim.procedure.type",
            "path": "Claim.procedure.type",
            "short": "Category of Procedure",
            "definition": "When the condition was observed or the relative ranking.",
            "comment": "For example: primary, secondary.",
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
            "id": "Claim.procedure.date",
            "path": "Claim.procedure.date",
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
            "id": "Claim.procedure.procedure[x]",
            "path": "Claim.procedure.procedure[x]",
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
              "description": "Example ICD10 Procedure codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/icd-10-procedures"
            }
          },
          {
            "id": "Claim.procedure.udi",
            "path": "Claim.procedure.udi",
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
            "id": "Claim.insurance",
            "path": "Claim.insurance",
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
            "id": "Claim.insurance.sequence",
            "path": "Claim.insurance.sequence",
            "short": "Insurance instance identifier",
            "definition": "A number to uniquely identify insurance entries and provide a sequence of coverages to convey coordination of benefit order.",
            "requirements": "To maintain order of the coverages.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Claim.insurance.focal",
            "path": "Claim.insurance.focal",
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
            ],
            "isSummary": true
          },
          {
            "id": "Claim.insurance.identifier",
            "path": "Claim.insurance.identifier",
            "short": "Pre-assigned Claim number",
            "definition": "The business identifier to be used when the claim is sent for adjudication against this insurance policy.",
            "comment": "Only required in jurisdictions where insurers, rather than the provider, are required to send claims to  insurers that appear after them in the list. This element is not required when 'subrogation=true'.",
            "requirements": "This will be the claim number should it be necessary to create this claim in the future. This is provided so that payors may forward claims to other payors in the Coordination of Benefit for adjudication rather than the provider being required to initiate each adjudication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "Claim.insurance.coverage",
            "path": "Claim.insurance.coverage",
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
            "id": "Claim.insurance.businessArrangement",
            "path": "Claim.insurance.businessArrangement",
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
            "id": "Claim.insurance.preAuthRef",
            "path": "Claim.insurance.preAuthRef",
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
            "id": "Claim.insurance.claimResponse",
            "path": "Claim.insurance.claimResponse",
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
            "id": "Claim.accident",
            "path": "Claim.accident",
            "short": "Details of the event",
            "definition": "Details of an accident which resulted in injuries which required the products and services listed in the claim.",
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
            "id": "Claim.accident.date",
            "path": "Claim.accident.date",
            "short": "When the incident occurred",
            "definition": "Date of an accident event  related to the products and services contained in the claim.",
            "comment": "The date of the accident has to precede the dates of the products and services but within a reasonable timeframe.",
            "requirements": "Required for audit purposes and adjudication.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ]
          },
          {
            "id": "Claim.accident.type",
            "path": "Claim.accident.type",
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
            "id": "Claim.accident.location[x]",
            "path": "Claim.accident.location[x]",
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
            "id": "Claim.item",
            "path": "Claim.item",
            "short": "Product or service provided",
            "definition": "A claim line. Either a simple  product or service or a 'group' of details which can each be a simple items or groups of sub-details.",
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
            "id": "Claim.item.sequence",
            "path": "Claim.item.sequence",
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
            "id": "Claim.item.careTeamSequence",
            "path": "Claim.item.careTeamSequence",
            "short": "Applicable careTeam members",
            "definition": "CareTeam members related to this service or product.",
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
            "id": "Claim.item.diagnosisSequence",
            "path": "Claim.item.diagnosisSequence",
            "short": "Applicable diagnoses",
            "definition": "Diagnosis applicable for this service or product.",
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
            "id": "Claim.item.procedureSequence",
            "path": "Claim.item.procedureSequence",
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
            "id": "Claim.item.informationSequence",
            "path": "Claim.item.informationSequence",
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
            "id": "Claim.item.revenue",
            "path": "Claim.item.revenue",
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
            "id": "Claim.item.category",
            "path": "Claim.item.category",
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
              "description": "Benefit categories such as: oral-basic, major, glasses.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-benefitcategory"
            }
          },
          {
            "id": "Claim.item.productOrService",
            "path": "Claim.item.productOrService",
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
            "id": "Claim.item.modifier",
            "path": "Claim.item.modifier",
            "short": "Product or service billing modifiers",
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
            "id": "Claim.item.programCode",
            "path": "Claim.item.programCode",
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
            "id": "Claim.item.serviced[x]",
            "path": "Claim.item.serviced[x]",
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
            "id": "Claim.item.location[x]",
            "path": "Claim.item.location[x]",
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
            "id": "Claim.item.quantity",
            "path": "Claim.item.quantity",
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
            "id": "Claim.item.unitPrice",
            "path": "Claim.item.unitPrice",
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
            "id": "Claim.item.factor",
            "path": "Claim.item.factor",
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
            "id": "Claim.item.net",
            "path": "Claim.item.net",
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
            "id": "Claim.item.udi",
            "path": "Claim.item.udi",
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
            "id": "Claim.item.bodySite",
            "path": "Claim.item.bodySite",
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
            "id": "Claim.item.subSite",
            "path": "Claim.item.subSite",
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
            "id": "Claim.item.encounter",
            "path": "Claim.item.encounter",
            "short": "Encounters related to this billed item",
            "definition": "The Encounters during which this Claim was created or to which the creation of this record is tightly associated.",
            "comment": "This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter.",
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
            "id": "Claim.item.detail",
            "path": "Claim.item.detail",
            "short": "Product or service provided",
            "definition": "A claim detail line. Either a simple (a product or service) or a 'group' of sub-details which are simple items.",
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
            "id": "Claim.item.detail.sequence",
            "path": "Claim.item.detail.sequence",
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
            "id": "Claim.item.detail.revenue",
            "path": "Claim.item.detail.revenue",
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
            "id": "Claim.item.detail.category",
            "path": "Claim.item.detail.category",
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
              "description": "Benefit categories such as: oral-basic, major, glasses.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-benefitcategory"
            }
          },
          {
            "id": "Claim.item.detail.productOrService",
            "path": "Claim.item.detail.productOrService",
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
            "id": "Claim.item.detail.modifier",
            "path": "Claim.item.detail.modifier",
            "short": "Service/Product billing modifiers",
            "definition": "Item typification or modifiers codes to convey additional context for the product or service.",
            "comment": "For example in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or out of office hours.",
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
            "id": "Claim.item.detail.programCode",
            "path": "Claim.item.detail.programCode",
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
            "id": "Claim.item.detail.quantity",
            "path": "Claim.item.detail.quantity",
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
            "id": "Claim.item.detail.unitPrice",
            "path": "Claim.item.detail.unitPrice",
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
            "id": "Claim.item.detail.factor",
            "path": "Claim.item.detail.factor",
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
            "id": "Claim.item.detail.net",
            "path": "Claim.item.detail.net",
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
            "id": "Claim.item.detail.udi",
            "path": "Claim.item.detail.udi",
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
            "id": "Claim.item.detail.subDetail",
            "path": "Claim.item.detail.subDetail",
            "short": "Product or service provided",
            "definition": "A claim detail line. Either a simple (a product or service) or a 'group' of sub-details which are simple items.",
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
            "id": "Claim.item.detail.subDetail.sequence",
            "path": "Claim.item.detail.subDetail.sequence",
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
            "id": "Claim.item.detail.subDetail.revenue",
            "path": "Claim.item.detail.subDetail.revenue",
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
            "id": "Claim.item.detail.subDetail.category",
            "path": "Claim.item.detail.subDetail.category",
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
              "description": "Benefit categories such as: oral-basic, major, glasses.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ex-benefitcategory"
            }
          },
          {
            "id": "Claim.item.detail.subDetail.productOrService",
            "path": "Claim.item.detail.subDetail.productOrService",
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
            "id": "Claim.item.detail.subDetail.modifier",
            "path": "Claim.item.detail.subDetail.modifier",
            "short": "Service/Product billing modifiers",
            "definition": "Item typification or modifiers codes to convey additional context for the product or service.",
            "comment": "For example in Oral whether the treatment is cosmetic or associated with TMJ, or for Medical whether the treatment was outside the clinic or out of office hours.",
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
            "id": "Claim.item.detail.subDetail.programCode",
            "path": "Claim.item.detail.subDetail.programCode",
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
            "id": "Claim.item.detail.subDetail.quantity",
            "path": "Claim.item.detail.subDetail.quantity",
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
            "id": "Claim.item.detail.subDetail.unitPrice",
            "path": "Claim.item.detail.subDetail.unitPrice",
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
            "id": "Claim.item.detail.subDetail.factor",
            "path": "Claim.item.detail.subDetail.factor",
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
            "id": "Claim.item.detail.subDetail.net",
            "path": "Claim.item.detail.subDetail.net",
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
            "id": "Claim.item.detail.subDetail.udi",
            "path": "Claim.item.detail.subDetail.udi",
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
            "id": "Claim.total",
            "path": "Claim.total",
            "short": "Total claim cost",
            "definition": "The total value of the all the items in the claim.",
            "requirements": "Used for  control total purposes.",
            "min": 0,
            "max": "1",
            "type": [
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
    /// Fhir resource 'Claim'
    /// </summary>
    // 0. Claim
    public partial class Resource_Claim : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 14. Claim.related
        public partial class Type_Related : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 15. Claim.related.claim
            public ElementDefinitionInfo Element_Claim;
            // 16. Claim.related.relationship
            public ElementDefinitionInfo Element_Relationship;
            // 17. Claim.related.reference
            public ElementDefinitionInfo Element_Reference;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Claim.related",
                    ElementId = "Claim.related"
                });
                Element_Claim.Write(sDef);
                Element_Relationship.Write(sDef);
                Element_Reference.Write(sDef);
            }
            
            public Type_Related()
            {
                {
                    // 15. Claim.related.claim
                    this.Element_Claim = new ElementDefinitionInfo
                    {
                        Name = "Element_Claim",
                        Path= "Claim.related.claim",
                        Id = "Claim.related.claim",
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
                    // 16. Claim.related.relationship
                    this.Element_Relationship = new ElementDefinitionInfo
                    {
                        Name = "Element_Relationship",
                        Path= "Claim.related.relationship",
                        Id = "Claim.related.relationship",
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
                    // 17. Claim.related.reference
                    this.Element_Reference = new ElementDefinitionInfo
                    {
                        Name = "Element_Reference",
                        Path= "Claim.related.reference",
                        Id = "Claim.related.reference",
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
        // 20. Claim.payee
        public partial class Type_Payee : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 21. Claim.payee.type
            public ElementDefinitionInfo Element_Type;
            // 22. Claim.payee.party
            public ElementDefinitionInfo Element_Party;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Claim.payee",
                    ElementId = "Claim.payee"
                });
                Element_Type.Write(sDef);
                Element_Party.Write(sDef);
            }
            
            public Type_Payee()
            {
                {
                    // 21. Claim.payee.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Claim.payee.type",
                        Id = "Claim.payee.type",
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
                    // 22. Claim.payee.party
                    this.Element_Party = new ElementDefinitionInfo
                    {
                        Name = "Element_Party",
                        Path= "Claim.payee.party",
                        Id = "Claim.payee.party",
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
        // 25. Claim.careTeam
        public partial class Type_CareTeam : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 26. Claim.careTeam.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 27. Claim.careTeam.provider
            public ElementDefinitionInfo Element_Provider;
            // 28. Claim.careTeam.responsible
            public ElementDefinitionInfo Element_Responsible;
            // 29. Claim.careTeam.role
            public ElementDefinitionInfo Element_Role;
            // 30. Claim.careTeam.qualification
            public ElementDefinitionInfo Element_Qualification;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Claim.careTeam",
                    ElementId = "Claim.careTeam"
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
                    // 26. Claim.careTeam.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "Claim.careTeam.sequence",
                        Id = "Claim.careTeam.sequence",
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
                    // 27. Claim.careTeam.provider
                    this.Element_Provider = new ElementDefinitionInfo
                    {
                        Name = "Element_Provider",
                        Path= "Claim.careTeam.provider",
                        Id = "Claim.careTeam.provider",
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
                    // 28. Claim.careTeam.responsible
                    this.Element_Responsible = new ElementDefinitionInfo
                    {
                        Name = "Element_Responsible",
                        Path= "Claim.careTeam.responsible",
                        Id = "Claim.careTeam.responsible",
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
                    // 29. Claim.careTeam.role
                    this.Element_Role = new ElementDefinitionInfo
                    {
                        Name = "Element_Role",
                        Path= "Claim.careTeam.role",
                        Id = "Claim.careTeam.role",
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
                    // 30. Claim.careTeam.qualification
                    this.Element_Qualification = new ElementDefinitionInfo
                    {
                        Name = "Element_Qualification",
                        Path= "Claim.careTeam.qualification",
                        Id = "Claim.careTeam.qualification",
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
        // 31. Claim.supportingInfo
        public partial class Type_SupportingInfo : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 32. Claim.supportingInfo.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 33. Claim.supportingInfo.category
            public ElementDefinitionInfo Element_Category;
            // 34. Claim.supportingInfo.code
            public ElementDefinitionInfo Element_Code;
            // 35. Claim.supportingInfo.timing[x]
            public ElementDefinitionInfo Element_Timing;
            // 36. Claim.supportingInfo.value[x]
            public ElementDefinitionInfo Element_Value;
            // 37. Claim.supportingInfo.reason
            public ElementDefinitionInfo Element_Reason;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Claim.supportingInfo",
                    ElementId = "Claim.supportingInfo"
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
                    // 32. Claim.supportingInfo.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "Claim.supportingInfo.sequence",
                        Id = "Claim.supportingInfo.sequence",
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
                    // 33. Claim.supportingInfo.category
                    this.Element_Category = new ElementDefinitionInfo
                    {
                        Name = "Element_Category",
                        Path= "Claim.supportingInfo.category",
                        Id = "Claim.supportingInfo.category",
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
                    // 34. Claim.supportingInfo.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "Claim.supportingInfo.code",
                        Id = "Claim.supportingInfo.code",
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
                    // 35. Claim.supportingInfo.timing[x]
                    this.Element_Timing = new ElementDefinitionInfo
                    {
                        Name = "Element_Timing",
                        Path= "Claim.supportingInfo.timing[x]",
                        Id = "Claim.supportingInfo.timing[x]",
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
                    // 36. Claim.supportingInfo.value[x]
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "Claim.supportingInfo.value[x]",
                        Id = "Claim.supportingInfo.value[x]",
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
                    // 37. Claim.supportingInfo.reason
                    this.Element_Reason = new ElementDefinitionInfo
                    {
                        Name = "Element_Reason",
                        Path= "Claim.supportingInfo.reason",
                        Id = "Claim.supportingInfo.reason",
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
        // 38. Claim.diagnosis
        public partial class Type_Diagnosis : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 39. Claim.diagnosis.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 40. Claim.diagnosis.diagnosis[x]
            public ElementDefinitionInfo Element_Diagnosis;
            // 41. Claim.diagnosis.type
            public ElementDefinitionInfo Element_Type;
            // 42. Claim.diagnosis.onAdmission
            public ElementDefinitionInfo Element_OnAdmission;
            // 43. Claim.diagnosis.packageCode
            public ElementDefinitionInfo Element_PackageCode;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Claim.diagnosis",
                    ElementId = "Claim.diagnosis"
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
                    // 39. Claim.diagnosis.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "Claim.diagnosis.sequence",
                        Id = "Claim.diagnosis.sequence",
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
                    // 40. Claim.diagnosis.diagnosis[x]
                    this.Element_Diagnosis = new ElementDefinitionInfo
                    {
                        Name = "Element_Diagnosis",
                        Path= "Claim.diagnosis.diagnosis[x]",
                        Id = "Claim.diagnosis.diagnosis[x]",
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
                    // 41. Claim.diagnosis.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Claim.diagnosis.type",
                        Id = "Claim.diagnosis.type",
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
                    // 42. Claim.diagnosis.onAdmission
                    this.Element_OnAdmission = new ElementDefinitionInfo
                    {
                        Name = "Element_OnAdmission",
                        Path= "Claim.diagnosis.onAdmission",
                        Id = "Claim.diagnosis.onAdmission",
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
                    // 43. Claim.diagnosis.packageCode
                    this.Element_PackageCode = new ElementDefinitionInfo
                    {
                        Name = "Element_PackageCode",
                        Path= "Claim.diagnosis.packageCode",
                        Id = "Claim.diagnosis.packageCode",
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
        // 44. Claim.procedure
        public partial class Type_Procedure : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 45. Claim.procedure.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 46. Claim.procedure.type
            public ElementDefinitionInfo Element_Type;
            // 47. Claim.procedure.date
            public ElementDefinitionInfo Element_Date;
            // 48. Claim.procedure.procedure[x]
            public ElementDefinitionInfo Element_Procedure;
            // 49. Claim.procedure.udi
            public ElementDefinitionInfo Element_Udi;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Claim.procedure",
                    ElementId = "Claim.procedure"
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
                    // 45. Claim.procedure.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "Claim.procedure.sequence",
                        Id = "Claim.procedure.sequence",
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
                    // 46. Claim.procedure.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Claim.procedure.type",
                        Id = "Claim.procedure.type",
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
                    // 47. Claim.procedure.date
                    this.Element_Date = new ElementDefinitionInfo
                    {
                        Name = "Element_Date",
                        Path= "Claim.procedure.date",
                        Id = "Claim.procedure.date",
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
                    // 48. Claim.procedure.procedure[x]
                    this.Element_Procedure = new ElementDefinitionInfo
                    {
                        Name = "Element_Procedure",
                        Path= "Claim.procedure.procedure[x]",
                        Id = "Claim.procedure.procedure[x]",
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
                    // 49. Claim.procedure.udi
                    this.Element_Udi = new ElementDefinitionInfo
                    {
                        Name = "Element_Udi",
                        Path= "Claim.procedure.udi",
                        Id = "Claim.procedure.udi",
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
        // 50. Claim.insurance
        public partial class Type_Insurance : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 51. Claim.insurance.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 52. Claim.insurance.focal
            public ElementDefinitionInfo Element_Focal;
            // 53. Claim.insurance.identifier
            public ElementDefinitionInfo Element_Identifier;
            // 54. Claim.insurance.coverage
            public ElementDefinitionInfo Element_Coverage;
            // 55. Claim.insurance.businessArrangement
            public ElementDefinitionInfo Element_BusinessArrangement;
            // 56. Claim.insurance.preAuthRef
            public ElementDefinitionInfo Element_PreAuthRef;
            // 57. Claim.insurance.claimResponse
            public ElementDefinitionInfo Element_ClaimResponse;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Claim.insurance",
                    ElementId = "Claim.insurance"
                });
                Element_Sequence.Write(sDef);
                Element_Focal.Write(sDef);
                Element_Identifier.Write(sDef);
                Element_Coverage.Write(sDef);
                Element_BusinessArrangement.Write(sDef);
                Element_PreAuthRef.Write(sDef);
                Element_ClaimResponse.Write(sDef);
            }
            
            public Type_Insurance()
            {
                {
                    // 51. Claim.insurance.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "Claim.insurance.sequence",
                        Id = "Claim.insurance.sequence",
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
                    // 52. Claim.insurance.focal
                    this.Element_Focal = new ElementDefinitionInfo
                    {
                        Name = "Element_Focal",
                        Path= "Claim.insurance.focal",
                        Id = "Claim.insurance.focal",
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
                    // 53. Claim.insurance.identifier
                    this.Element_Identifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Identifier",
                        Path= "Claim.insurance.identifier",
                        Id = "Claim.insurance.identifier",
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
                {
                    // 54. Claim.insurance.coverage
                    this.Element_Coverage = new ElementDefinitionInfo
                    {
                        Name = "Element_Coverage",
                        Path= "Claim.insurance.coverage",
                        Id = "Claim.insurance.coverage",
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
                    // 55. Claim.insurance.businessArrangement
                    this.Element_BusinessArrangement = new ElementDefinitionInfo
                    {
                        Name = "Element_BusinessArrangement",
                        Path= "Claim.insurance.businessArrangement",
                        Id = "Claim.insurance.businessArrangement",
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
                    // 56. Claim.insurance.preAuthRef
                    this.Element_PreAuthRef = new ElementDefinitionInfo
                    {
                        Name = "Element_PreAuthRef",
                        Path= "Claim.insurance.preAuthRef",
                        Id = "Claim.insurance.preAuthRef",
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
                    // 57. Claim.insurance.claimResponse
                    this.Element_ClaimResponse = new ElementDefinitionInfo
                    {
                        Name = "Element_ClaimResponse",
                        Path= "Claim.insurance.claimResponse",
                        Id = "Claim.insurance.claimResponse",
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
        // 58. Claim.accident
        public partial class Type_Accident : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 59. Claim.accident.date
            public ElementDefinitionInfo Element_Date;
            // 60. Claim.accident.type
            public ElementDefinitionInfo Element_Type;
            // 61. Claim.accident.location[x]
            public ElementDefinitionInfo Element_Location;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Claim.accident",
                    ElementId = "Claim.accident"
                });
                Element_Date.Write(sDef);
                Element_Type.Write(sDef);
                Element_Location.Write(sDef);
            }
            
            public Type_Accident()
            {
                {
                    // 59. Claim.accident.date
                    this.Element_Date = new ElementDefinitionInfo
                    {
                        Name = "Element_Date",
                        Path= "Claim.accident.date",
                        Id = "Claim.accident.date",
                        Min = 1,
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
                    // 60. Claim.accident.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Claim.accident.type",
                        Id = "Claim.accident.type",
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
                    // 61. Claim.accident.location[x]
                    this.Element_Location = new ElementDefinitionInfo
                    {
                        Name = "Element_Location",
                        Path= "Claim.accident.location[x]",
                        Id = "Claim.accident.location[x]",
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
        // 62. Claim.item
        public partial class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 83. Claim.item.detail
            public partial class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 95. Claim.item.detail.subDetail
                public partial class Type_SubDetail : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 96. Claim.item.detail.subDetail.sequence
                    public ElementDefinitionInfo Element_Sequence;
                    // 97. Claim.item.detail.subDetail.revenue
                    public ElementDefinitionInfo Element_Revenue;
                    // 98. Claim.item.detail.subDetail.category
                    public ElementDefinitionInfo Element_Category;
                    // 99. Claim.item.detail.subDetail.productOrService
                    public ElementDefinitionInfo Element_ProductOrService;
                    // 100. Claim.item.detail.subDetail.modifier
                    public ElementDefinitionInfo Element_Modifier;
                    // 101. Claim.item.detail.subDetail.programCode
                    public ElementDefinitionInfo Element_ProgramCode;
                    // 102. Claim.item.detail.subDetail.quantity
                    public ElementDefinitionInfo Element_Quantity;
                    // 103. Claim.item.detail.subDetail.unitPrice
                    public ElementDefinitionInfo Element_UnitPrice;
                    // 104. Claim.item.detail.subDetail.factor
                    public ElementDefinitionInfo Element_Factor;
                    // 105. Claim.item.detail.subDetail.net
                    public ElementDefinitionInfo Element_Net;
                    // 106. Claim.item.detail.subDetail.udi
                    public ElementDefinitionInfo Element_Udi;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "Claim.item.detail.subDetail",
                            ElementId = "Claim.item.detail.subDetail"
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
                    }
                    
                    public Type_SubDetail()
                    {
                        {
                            // 96. Claim.item.detail.subDetail.sequence
                            this.Element_Sequence = new ElementDefinitionInfo
                            {
                                Name = "Element_Sequence",
                                Path= "Claim.item.detail.subDetail.sequence",
                                Id = "Claim.item.detail.subDetail.sequence",
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
                            // 97. Claim.item.detail.subDetail.revenue
                            this.Element_Revenue = new ElementDefinitionInfo
                            {
                                Name = "Element_Revenue",
                                Path= "Claim.item.detail.subDetail.revenue",
                                Id = "Claim.item.detail.subDetail.revenue",
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
                            // 98. Claim.item.detail.subDetail.category
                            this.Element_Category = new ElementDefinitionInfo
                            {
                                Name = "Element_Category",
                                Path= "Claim.item.detail.subDetail.category",
                                Id = "Claim.item.detail.subDetail.category",
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
                            // 99. Claim.item.detail.subDetail.productOrService
                            this.Element_ProductOrService = new ElementDefinitionInfo
                            {
                                Name = "Element_ProductOrService",
                                Path= "Claim.item.detail.subDetail.productOrService",
                                Id = "Claim.item.detail.subDetail.productOrService",
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
                            // 100. Claim.item.detail.subDetail.modifier
                            this.Element_Modifier = new ElementDefinitionInfo
                            {
                                Name = "Element_Modifier",
                                Path= "Claim.item.detail.subDetail.modifier",
                                Id = "Claim.item.detail.subDetail.modifier",
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
                            // 101. Claim.item.detail.subDetail.programCode
                            this.Element_ProgramCode = new ElementDefinitionInfo
                            {
                                Name = "Element_ProgramCode",
                                Path= "Claim.item.detail.subDetail.programCode",
                                Id = "Claim.item.detail.subDetail.programCode",
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
                            // 102. Claim.item.detail.subDetail.quantity
                            this.Element_Quantity = new ElementDefinitionInfo
                            {
                                Name = "Element_Quantity",
                                Path= "Claim.item.detail.subDetail.quantity",
                                Id = "Claim.item.detail.subDetail.quantity",
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
                            // 103. Claim.item.detail.subDetail.unitPrice
                            this.Element_UnitPrice = new ElementDefinitionInfo
                            {
                                Name = "Element_UnitPrice",
                                Path= "Claim.item.detail.subDetail.unitPrice",
                                Id = "Claim.item.detail.subDetail.unitPrice",
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
                            // 104. Claim.item.detail.subDetail.factor
                            this.Element_Factor = new ElementDefinitionInfo
                            {
                                Name = "Element_Factor",
                                Path= "Claim.item.detail.subDetail.factor",
                                Id = "Claim.item.detail.subDetail.factor",
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
                            // 105. Claim.item.detail.subDetail.net
                            this.Element_Net = new ElementDefinitionInfo
                            {
                                Name = "Element_Net",
                                Path= "Claim.item.detail.subDetail.net",
                                Id = "Claim.item.detail.subDetail.net",
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
                            // 106. Claim.item.detail.subDetail.udi
                            this.Element_Udi = new ElementDefinitionInfo
                            {
                                Name = "Element_Udi",
                                Path= "Claim.item.detail.subDetail.udi",
                                Id = "Claim.item.detail.subDetail.udi",
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
                // 84. Claim.item.detail.sequence
                public ElementDefinitionInfo Element_Sequence;
                // 85. Claim.item.detail.revenue
                public ElementDefinitionInfo Element_Revenue;
                // 86. Claim.item.detail.category
                public ElementDefinitionInfo Element_Category;
                // 87. Claim.item.detail.productOrService
                public ElementDefinitionInfo Element_ProductOrService;
                // 88. Claim.item.detail.modifier
                public ElementDefinitionInfo Element_Modifier;
                // 89. Claim.item.detail.programCode
                public ElementDefinitionInfo Element_ProgramCode;
                // 90. Claim.item.detail.quantity
                public ElementDefinitionInfo Element_Quantity;
                // 91. Claim.item.detail.unitPrice
                public ElementDefinitionInfo Element_UnitPrice;
                // 92. Claim.item.detail.factor
                public ElementDefinitionInfo Element_Factor;
                // 93. Claim.item.detail.net
                public ElementDefinitionInfo Element_Net;
                // 94. Claim.item.detail.udi
                public ElementDefinitionInfo Element_Udi;
                // 95. Claim.item.detail.subDetail
                public ElementDefinitionInfo Element_SubDetail;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "Claim.item.detail",
                        ElementId = "Claim.item.detail"
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
                    Element_SubDetail.Write(sDef);
                }
                
                public Type_Detail()
                {
                    {
                        // 84. Claim.item.detail.sequence
                        this.Element_Sequence = new ElementDefinitionInfo
                        {
                            Name = "Element_Sequence",
                            Path= "Claim.item.detail.sequence",
                            Id = "Claim.item.detail.sequence",
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
                        // 85. Claim.item.detail.revenue
                        this.Element_Revenue = new ElementDefinitionInfo
                        {
                            Name = "Element_Revenue",
                            Path= "Claim.item.detail.revenue",
                            Id = "Claim.item.detail.revenue",
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
                        // 86. Claim.item.detail.category
                        this.Element_Category = new ElementDefinitionInfo
                        {
                            Name = "Element_Category",
                            Path= "Claim.item.detail.category",
                            Id = "Claim.item.detail.category",
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
                        // 87. Claim.item.detail.productOrService
                        this.Element_ProductOrService = new ElementDefinitionInfo
                        {
                            Name = "Element_ProductOrService",
                            Path= "Claim.item.detail.productOrService",
                            Id = "Claim.item.detail.productOrService",
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
                        // 88. Claim.item.detail.modifier
                        this.Element_Modifier = new ElementDefinitionInfo
                        {
                            Name = "Element_Modifier",
                            Path= "Claim.item.detail.modifier",
                            Id = "Claim.item.detail.modifier",
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
                        // 89. Claim.item.detail.programCode
                        this.Element_ProgramCode = new ElementDefinitionInfo
                        {
                            Name = "Element_ProgramCode",
                            Path= "Claim.item.detail.programCode",
                            Id = "Claim.item.detail.programCode",
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
                        // 90. Claim.item.detail.quantity
                        this.Element_Quantity = new ElementDefinitionInfo
                        {
                            Name = "Element_Quantity",
                            Path= "Claim.item.detail.quantity",
                            Id = "Claim.item.detail.quantity",
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
                        // 91. Claim.item.detail.unitPrice
                        this.Element_UnitPrice = new ElementDefinitionInfo
                        {
                            Name = "Element_UnitPrice",
                            Path= "Claim.item.detail.unitPrice",
                            Id = "Claim.item.detail.unitPrice",
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
                        // 92. Claim.item.detail.factor
                        this.Element_Factor = new ElementDefinitionInfo
                        {
                            Name = "Element_Factor",
                            Path= "Claim.item.detail.factor",
                            Id = "Claim.item.detail.factor",
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
                        // 93. Claim.item.detail.net
                        this.Element_Net = new ElementDefinitionInfo
                        {
                            Name = "Element_Net",
                            Path= "Claim.item.detail.net",
                            Id = "Claim.item.detail.net",
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
                        // 94. Claim.item.detail.udi
                        this.Element_Udi = new ElementDefinitionInfo
                        {
                            Name = "Element_Udi",
                            Path= "Claim.item.detail.udi",
                            Id = "Claim.item.detail.udi",
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
                        // 95. Claim.item.detail.subDetail
                        this.Element_SubDetail = new ElementDefinitionInfo
                        {
                            Name = "Element_SubDetail",
                            Path= "Claim.item.detail.subDetail",
                            Id = "Claim.item.detail.subDetail",
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
            // 63. Claim.item.sequence
            public ElementDefinitionInfo Element_Sequence;
            // 64. Claim.item.careTeamSequence
            public ElementDefinitionInfo Element_CareTeamSequence;
            // 65. Claim.item.diagnosisSequence
            public ElementDefinitionInfo Element_DiagnosisSequence;
            // 66. Claim.item.procedureSequence
            public ElementDefinitionInfo Element_ProcedureSequence;
            // 67. Claim.item.informationSequence
            public ElementDefinitionInfo Element_InformationSequence;
            // 68. Claim.item.revenue
            public ElementDefinitionInfo Element_Revenue;
            // 69. Claim.item.category
            public ElementDefinitionInfo Element_Category;
            // 70. Claim.item.productOrService
            public ElementDefinitionInfo Element_ProductOrService;
            // 71. Claim.item.modifier
            public ElementDefinitionInfo Element_Modifier;
            // 72. Claim.item.programCode
            public ElementDefinitionInfo Element_ProgramCode;
            // 73. Claim.item.serviced[x]
            public ElementDefinitionInfo Element_Serviced;
            // 74. Claim.item.location[x]
            public ElementDefinitionInfo Element_Location;
            // 75. Claim.item.quantity
            public ElementDefinitionInfo Element_Quantity;
            // 76. Claim.item.unitPrice
            public ElementDefinitionInfo Element_UnitPrice;
            // 77. Claim.item.factor
            public ElementDefinitionInfo Element_Factor;
            // 78. Claim.item.net
            public ElementDefinitionInfo Element_Net;
            // 79. Claim.item.udi
            public ElementDefinitionInfo Element_Udi;
            // 80. Claim.item.bodySite
            public ElementDefinitionInfo Element_BodySite;
            // 81. Claim.item.subSite
            public ElementDefinitionInfo Element_SubSite;
            // 82. Claim.item.encounter
            public ElementDefinitionInfo Element_Encounter;
            // 83. Claim.item.detail
            public ElementDefinitionInfo Element_Detail;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Claim.item",
                    ElementId = "Claim.item"
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
                Element_Detail.Write(sDef);
            }
            
            public Type_Item()
            {
                {
                    // 63. Claim.item.sequence
                    this.Element_Sequence = new ElementDefinitionInfo
                    {
                        Name = "Element_Sequence",
                        Path= "Claim.item.sequence",
                        Id = "Claim.item.sequence",
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
                    // 64. Claim.item.careTeamSequence
                    this.Element_CareTeamSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_CareTeamSequence",
                        Path= "Claim.item.careTeamSequence",
                        Id = "Claim.item.careTeamSequence",
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
                    // 65. Claim.item.diagnosisSequence
                    this.Element_DiagnosisSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_DiagnosisSequence",
                        Path= "Claim.item.diagnosisSequence",
                        Id = "Claim.item.diagnosisSequence",
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
                    // 66. Claim.item.procedureSequence
                    this.Element_ProcedureSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_ProcedureSequence",
                        Path= "Claim.item.procedureSequence",
                        Id = "Claim.item.procedureSequence",
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
                    // 67. Claim.item.informationSequence
                    this.Element_InformationSequence = new ElementDefinitionInfo
                    {
                        Name = "Element_InformationSequence",
                        Path= "Claim.item.informationSequence",
                        Id = "Claim.item.informationSequence",
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
                    // 68. Claim.item.revenue
                    this.Element_Revenue = new ElementDefinitionInfo
                    {
                        Name = "Element_Revenue",
                        Path= "Claim.item.revenue",
                        Id = "Claim.item.revenue",
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
                    // 69. Claim.item.category
                    this.Element_Category = new ElementDefinitionInfo
                    {
                        Name = "Element_Category",
                        Path= "Claim.item.category",
                        Id = "Claim.item.category",
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
                    // 70. Claim.item.productOrService
                    this.Element_ProductOrService = new ElementDefinitionInfo
                    {
                        Name = "Element_ProductOrService",
                        Path= "Claim.item.productOrService",
                        Id = "Claim.item.productOrService",
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
                    // 71. Claim.item.modifier
                    this.Element_Modifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Modifier",
                        Path= "Claim.item.modifier",
                        Id = "Claim.item.modifier",
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
                    // 72. Claim.item.programCode
                    this.Element_ProgramCode = new ElementDefinitionInfo
                    {
                        Name = "Element_ProgramCode",
                        Path= "Claim.item.programCode",
                        Id = "Claim.item.programCode",
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
                    // 73. Claim.item.serviced[x]
                    this.Element_Serviced = new ElementDefinitionInfo
                    {
                        Name = "Element_Serviced",
                        Path= "Claim.item.serviced[x]",
                        Id = "Claim.item.serviced[x]",
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
                    // 74. Claim.item.location[x]
                    this.Element_Location = new ElementDefinitionInfo
                    {
                        Name = "Element_Location",
                        Path= "Claim.item.location[x]",
                        Id = "Claim.item.location[x]",
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
                    // 75. Claim.item.quantity
                    this.Element_Quantity = new ElementDefinitionInfo
                    {
                        Name = "Element_Quantity",
                        Path= "Claim.item.quantity",
                        Id = "Claim.item.quantity",
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
                    // 76. Claim.item.unitPrice
                    this.Element_UnitPrice = new ElementDefinitionInfo
                    {
                        Name = "Element_UnitPrice",
                        Path= "Claim.item.unitPrice",
                        Id = "Claim.item.unitPrice",
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
                    // 77. Claim.item.factor
                    this.Element_Factor = new ElementDefinitionInfo
                    {
                        Name = "Element_Factor",
                        Path= "Claim.item.factor",
                        Id = "Claim.item.factor",
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
                    // 78. Claim.item.net
                    this.Element_Net = new ElementDefinitionInfo
                    {
                        Name = "Element_Net",
                        Path= "Claim.item.net",
                        Id = "Claim.item.net",
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
                    // 79. Claim.item.udi
                    this.Element_Udi = new ElementDefinitionInfo
                    {
                        Name = "Element_Udi",
                        Path= "Claim.item.udi",
                        Id = "Claim.item.udi",
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
                    // 80. Claim.item.bodySite
                    this.Element_BodySite = new ElementDefinitionInfo
                    {
                        Name = "Element_BodySite",
                        Path= "Claim.item.bodySite",
                        Id = "Claim.item.bodySite",
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
                    // 81. Claim.item.subSite
                    this.Element_SubSite = new ElementDefinitionInfo
                    {
                        Name = "Element_SubSite",
                        Path= "Claim.item.subSite",
                        Id = "Claim.item.subSite",
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
                    // 82. Claim.item.encounter
                    this.Element_Encounter = new ElementDefinitionInfo
                    {
                        Name = "Element_Encounter",
                        Path= "Claim.item.encounter",
                        Id = "Claim.item.encounter",
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
                    // 83. Claim.item.detail
                    this.Element_Detail = new ElementDefinitionInfo
                    {
                        Name = "Element_Detail",
                        Path= "Claim.item.detail",
                        Id = "Claim.item.detail",
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
        // 1. Claim.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. Claim.status
        public ElementDefinitionInfo Element_Status;
        // 3. Claim.type
        public ElementDefinitionInfo Element_Type;
        // 4. Claim.subType
        public ElementDefinitionInfo Element_SubType;
        // 5. Claim.use
        public ElementDefinitionInfo Element_Use;
        // 6. Claim.patient
        public ElementDefinitionInfo Element_Patient;
        // 7. Claim.billablePeriod
        public ElementDefinitionInfo Element_BillablePeriod;
        // 8. Claim.created
        public ElementDefinitionInfo Element_Created;
        // 9. Claim.enterer
        public ElementDefinitionInfo Element_Enterer;
        // 10. Claim.insurer
        public ElementDefinitionInfo Element_Insurer;
        // 11. Claim.provider
        public ElementDefinitionInfo Element_Provider;
        // 12. Claim.priority
        public ElementDefinitionInfo Element_Priority;
        // 13. Claim.fundsReserve
        public ElementDefinitionInfo Element_FundsReserve;
        // 14. Claim.related
        public ElementDefinitionInfo Element_Related;
        // 18. Claim.prescription
        public ElementDefinitionInfo Element_Prescription;
        // 19. Claim.originalPrescription
        public ElementDefinitionInfo Element_OriginalPrescription;
        // 20. Claim.payee
        public ElementDefinitionInfo Element_Payee;
        // 23. Claim.referral
        public ElementDefinitionInfo Element_Referral;
        // 24. Claim.facility
        public ElementDefinitionInfo Element_Facility;
        // 25. Claim.careTeam
        public ElementDefinitionInfo Element_CareTeam;
        // 31. Claim.supportingInfo
        public ElementDefinitionInfo Element_SupportingInfo;
        // 38. Claim.diagnosis
        public ElementDefinitionInfo Element_Diagnosis;
        // 44. Claim.procedure
        public ElementDefinitionInfo Element_Procedure;
        // 50. Claim.insurance
        public ElementDefinitionInfo Element_Insurance;
        // 58. Claim.accident
        public ElementDefinitionInfo Element_Accident;
        // 62. Claim.item
        public ElementDefinitionInfo Element_Item;
        // 107. Claim.total
        public ElementDefinitionInfo Element_Total;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Claim",
                ElementId = "Claim"
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
            Element_FundsReserve.Write(sDef);
            Element_Related.Write(sDef);
            Element_Prescription.Write(sDef);
            Element_OriginalPrescription.Write(sDef);
            Element_Payee.Write(sDef);
            Element_Referral.Write(sDef);
            Element_Facility.Write(sDef);
            Element_CareTeam.Write(sDef);
            Element_SupportingInfo.Write(sDef);
            Element_Diagnosis.Write(sDef);
            Element_Procedure.Write(sDef);
            Element_Insurance.Write(sDef);
            Element_Accident.Write(sDef);
            Element_Item.Write(sDef);
            Element_Total.Write(sDef);
        }
        
        public Resource_Claim()
        {
            {
                // 1. Claim.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Claim.identifier",
                    Id = "Claim.identifier",
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
                // 2. Claim.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Claim.status",
                    Id = "Claim.status",
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
                // 3. Claim.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "Claim.type",
                    Id = "Claim.type",
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
                // 4. Claim.subType
                this.Element_SubType = new ElementDefinitionInfo
                {
                    Name = "Element_SubType",
                    Path= "Claim.subType",
                    Id = "Claim.subType",
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
                // 5. Claim.use
                this.Element_Use = new ElementDefinitionInfo
                {
                    Name = "Element_Use",
                    Path= "Claim.use",
                    Id = "Claim.use",
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
                // 6. Claim.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "Claim.patient",
                    Id = "Claim.patient",
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
                // 7. Claim.billablePeriod
                this.Element_BillablePeriod = new ElementDefinitionInfo
                {
                    Name = "Element_BillablePeriod",
                    Path= "Claim.billablePeriod",
                    Id = "Claim.billablePeriod",
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
                // 8. Claim.created
                this.Element_Created = new ElementDefinitionInfo
                {
                    Name = "Element_Created",
                    Path= "Claim.created",
                    Id = "Claim.created",
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
                // 9. Claim.enterer
                this.Element_Enterer = new ElementDefinitionInfo
                {
                    Name = "Element_Enterer",
                    Path= "Claim.enterer",
                    Id = "Claim.enterer",
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
                // 10. Claim.insurer
                this.Element_Insurer = new ElementDefinitionInfo
                {
                    Name = "Element_Insurer",
                    Path= "Claim.insurer",
                    Id = "Claim.insurer",
                    Min = 0,
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
                // 11. Claim.provider
                this.Element_Provider = new ElementDefinitionInfo
                {
                    Name = "Element_Provider",
                    Path= "Claim.provider",
                    Id = "Claim.provider",
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
                // 12. Claim.priority
                this.Element_Priority = new ElementDefinitionInfo
                {
                    Name = "Element_Priority",
                    Path= "Claim.priority",
                    Id = "Claim.priority",
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
                // 13. Claim.fundsReserve
                this.Element_FundsReserve = new ElementDefinitionInfo
                {
                    Name = "Element_FundsReserve",
                    Path= "Claim.fundsReserve",
                    Id = "Claim.fundsReserve",
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
                // 14. Claim.related
                this.Element_Related = new ElementDefinitionInfo
                {
                    Name = "Element_Related",
                    Path= "Claim.related",
                    Id = "Claim.related",
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
                // 18. Claim.prescription
                this.Element_Prescription = new ElementDefinitionInfo
                {
                    Name = "Element_Prescription",
                    Path= "Claim.prescription",
                    Id = "Claim.prescription",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/DeviceRequest",
                                "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
                                "http://hl7.org/fhir/StructureDefinition/VisionPrescription"
                            }
                        }
                    }
                };
            }
            {
                // 19. Claim.originalPrescription
                this.Element_OriginalPrescription = new ElementDefinitionInfo
                {
                    Name = "Element_OriginalPrescription",
                    Path= "Claim.originalPrescription",
                    Id = "Claim.originalPrescription",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/DeviceRequest",
                                "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
                                "http://hl7.org/fhir/StructureDefinition/VisionPrescription"
                            }
                        }
                    }
                };
            }
            {
                // 20. Claim.payee
                this.Element_Payee = new ElementDefinitionInfo
                {
                    Name = "Element_Payee",
                    Path= "Claim.payee",
                    Id = "Claim.payee",
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
                // 23. Claim.referral
                this.Element_Referral = new ElementDefinitionInfo
                {
                    Name = "Element_Referral",
                    Path= "Claim.referral",
                    Id = "Claim.referral",
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
                // 24. Claim.facility
                this.Element_Facility = new ElementDefinitionInfo
                {
                    Name = "Element_Facility",
                    Path= "Claim.facility",
                    Id = "Claim.facility",
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
                // 25. Claim.careTeam
                this.Element_CareTeam = new ElementDefinitionInfo
                {
                    Name = "Element_CareTeam",
                    Path= "Claim.careTeam",
                    Id = "Claim.careTeam",
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
                // 31. Claim.supportingInfo
                this.Element_SupportingInfo = new ElementDefinitionInfo
                {
                    Name = "Element_SupportingInfo",
                    Path= "Claim.supportingInfo",
                    Id = "Claim.supportingInfo",
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
                // 38. Claim.diagnosis
                this.Element_Diagnosis = new ElementDefinitionInfo
                {
                    Name = "Element_Diagnosis",
                    Path= "Claim.diagnosis",
                    Id = "Claim.diagnosis",
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
                // 44. Claim.procedure
                this.Element_Procedure = new ElementDefinitionInfo
                {
                    Name = "Element_Procedure",
                    Path= "Claim.procedure",
                    Id = "Claim.procedure",
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
                // 50. Claim.insurance
                this.Element_Insurance = new ElementDefinitionInfo
                {
                    Name = "Element_Insurance",
                    Path= "Claim.insurance",
                    Id = "Claim.insurance",
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
                // 58. Claim.accident
                this.Element_Accident = new ElementDefinitionInfo
                {
                    Name = "Element_Accident",
                    Path= "Claim.accident",
                    Id = "Claim.accident",
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
                // 62. Claim.item
                this.Element_Item = new ElementDefinitionInfo
                {
                    Name = "Element_Item",
                    Path= "Claim.item",
                    Id = "Claim.item",
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
                // 107. Claim.total
                this.Element_Total = new ElementDefinitionInfo
                {
                    Name = "Element_Total",
                    Path= "Claim.total",
                    Id = "Claim.total",
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
            this.Name = "Claim";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Claim";
        }
    }
}
