using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
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
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'Claim'
    /// </summary>
    // 0. Claim
    public class Claim : FhirKhit.Maker.Common.Resource.ResourceBase                                                                        // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class Claim_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                           // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 14. Claim.related
            public class Type_Related : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Related_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 15. Claim.related.claim
                    public ElementDefinitionInfo Claim;                                                                                     // MakerGen.cs:216
                    // 16. Claim.related.relationship
                    public ElementDefinitionInfo Relationship;                                                                              // MakerGen.cs:216
                    // 17. Claim.related.reference
                    public ElementDefinitionInfo Reference;                                                                                 // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Related_Elements()                                                                                          // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 15. Claim.related.claim
                            this.Claim = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Claim",                                                                                             // MakerGen.cs:235
                                Path= "Claim.related.claim",                                                                                // MakerGen.cs:236
                                Id = "Claim.related.claim",                                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Claim"                                                 // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 16. Claim.related.relationship
                            this.Relationship = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Relationship",                                                                                      // MakerGen.cs:235
                                Path= "Claim.related.relationship",                                                                         // MakerGen.cs:236
                                Id = "Claim.related.relationship",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 17. Claim.related.reference
                            this.Reference = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Reference",                                                                                         // MakerGen.cs:235
                                Path= "Claim.related.reference",                                                                            // MakerGen.cs:236
                                Id = "Claim.related.reference",                                                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Claim.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Relationship.Write(sDef);                                                                                           // MakerGen.cs:220
                        Reference.Write(sDef);                                                                                              // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Related_Elements Elements                                                                                       // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Related_Elements();                                                                    // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Related_Elements elements;                                                                                             // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Related()                                                                                                       // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "Claim.related",                                                                                             // MakerGen.cs:428
                        ElementId = "Claim.related"                                                                                         // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 20. Claim.payee
            public class Type_Payee : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Payee_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 21. Claim.payee.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 22. Claim.payee.party
                    public ElementDefinitionInfo Party;                                                                                     // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Payee_Elements()                                                                                            // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 21. Claim.payee.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "Claim.payee.type",                                                                                   // MakerGen.cs:236
                                Id = "Claim.payee.type",                                                                                    // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 22. Claim.payee.party
                            this.Party = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Party",                                                                                             // MakerGen.cs:235
                                Path= "Claim.payee.party",                                                                                  // MakerGen.cs:236
                                Id = "Claim.payee.party",                                                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Organization",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                         // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Party.Write(sDef);                                                                                                  // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Payee_Elements Elements                                                                                         // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Payee_Elements();                                                                      // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Payee_Elements elements;                                                                                               // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Payee()                                                                                                         // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "Claim.payee",                                                                                               // MakerGen.cs:428
                        ElementId = "Claim.payee"                                                                                           // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 25. Claim.careTeam
            public class Type_CareTeam : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_CareTeam_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 26. Claim.careTeam.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:216
                    // 27. Claim.careTeam.provider
                    public ElementDefinitionInfo Provider;                                                                                  // MakerGen.cs:216
                    // 28. Claim.careTeam.responsible
                    public ElementDefinitionInfo Responsible;                                                                               // MakerGen.cs:216
                    // 29. Claim.careTeam.role
                    public ElementDefinitionInfo Role;                                                                                      // MakerGen.cs:216
                    // 30. Claim.careTeam.qualification
                    public ElementDefinitionInfo Qualification;                                                                             // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_CareTeam_Elements()                                                                                         // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 26. Claim.careTeam.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Sequence",                                                                                          // MakerGen.cs:235
                                Path= "Claim.careTeam.sequence",                                                                            // MakerGen.cs:236
                                Id = "Claim.careTeam.sequence",                                                                             // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 27. Claim.careTeam.provider
                            this.Provider = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Provider",                                                                                          // MakerGen.cs:235
                                Path= "Claim.careTeam.provider",                                                                            // MakerGen.cs:236
                                Id = "Claim.careTeam.provider",                                                                             // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 28. Claim.careTeam.responsible
                            this.Responsible = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Responsible",                                                                                       // MakerGen.cs:235
                                Path= "Claim.careTeam.responsible",                                                                         // MakerGen.cs:236
                                Id = "Claim.careTeam.responsible",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 29. Claim.careTeam.role
                            this.Role = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Role",                                                                                              // MakerGen.cs:235
                                Path= "Claim.careTeam.role",                                                                                // MakerGen.cs:236
                                Id = "Claim.careTeam.role",                                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 30. Claim.careTeam.qualification
                            this.Qualification = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Qualification",                                                                                     // MakerGen.cs:235
                                Path= "Claim.careTeam.qualification",                                                                       // MakerGen.cs:236
                                Id = "Claim.careTeam.qualification",                                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:220
                        Provider.Write(sDef);                                                                                               // MakerGen.cs:220
                        Responsible.Write(sDef);                                                                                            // MakerGen.cs:220
                        Role.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Qualification.Write(sDef);                                                                                          // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_CareTeam_Elements Elements                                                                                      // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_CareTeam_Elements();                                                                   // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_CareTeam_Elements elements;                                                                                            // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_CareTeam()                                                                                                      // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "Claim.careTeam",                                                                                            // MakerGen.cs:428
                        ElementId = "Claim.careTeam"                                                                                        // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 31. Claim.supportingInfo
            public class Type_SupportingInfo : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_SupportingInfo_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 32. Claim.supportingInfo.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:216
                    // 33. Claim.supportingInfo.category
                    public ElementDefinitionInfo Category;                                                                                  // MakerGen.cs:216
                    // 34. Claim.supportingInfo.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 35. Claim.supportingInfo.timing[x]
                    public ElementDefinitionInfo Timing;                                                                                    // MakerGen.cs:216
                    // 36. Claim.supportingInfo.value[x]
                    public ElementDefinitionInfo Value;                                                                                     // MakerGen.cs:216
                    // 37. Claim.supportingInfo.reason
                    public ElementDefinitionInfo Reason;                                                                                    // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_SupportingInfo_Elements()                                                                                   // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 32. Claim.supportingInfo.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Sequence",                                                                                          // MakerGen.cs:235
                                Path= "Claim.supportingInfo.sequence",                                                                      // MakerGen.cs:236
                                Id = "Claim.supportingInfo.sequence",                                                                       // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 33. Claim.supportingInfo.category
                            this.Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Category",                                                                                          // MakerGen.cs:235
                                Path= "Claim.supportingInfo.category",                                                                      // MakerGen.cs:236
                                Id = "Claim.supportingInfo.category",                                                                       // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 34. Claim.supportingInfo.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "Claim.supportingInfo.code",                                                                          // MakerGen.cs:236
                                Id = "Claim.supportingInfo.code",                                                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 35. Claim.supportingInfo.timing[x]
                            this.Timing = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Timing",                                                                                            // MakerGen.cs:235
                                Path= "Claim.supportingInfo.timing[x]",                                                                     // MakerGen.cs:236
                                Id = "Claim.supportingInfo.timing[x]",                                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    },                                                                                                      // MakerGen.cs:304
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 36. Claim.supportingInfo.value[x]
                            this.Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Value",                                                                                             // MakerGen.cs:235
                                Path= "Claim.supportingInfo.value[x]",                                                                      // MakerGen.cs:236
                                Id = "Claim.supportingInfo.value[x]",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    },                                                                                                      // MakerGen.cs:304
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    },                                                                                                      // MakerGen.cs:304
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    },                                                                                                      // MakerGen.cs:360
                                    new FhirKhit.Maker.Common.Complex.Attachment                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    },                                                                                                      // MakerGen.cs:360
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 37. Claim.supportingInfo.reason
                            this.Reason = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Reason",                                                                                            // MakerGen.cs:235
                                Path= "Claim.supportingInfo.reason",                                                                        // MakerGen.cs:236
                                Id = "Claim.supportingInfo.reason",                                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:220
                        Category.Write(sDef);                                                                                               // MakerGen.cs:220
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Timing.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Value.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Reason.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_SupportingInfo_Elements Elements                                                                                // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_SupportingInfo_Elements();                                                             // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_SupportingInfo_Elements elements;                                                                                      // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_SupportingInfo()                                                                                                // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "Claim.supportingInfo",                                                                                      // MakerGen.cs:428
                        ElementId = "Claim.supportingInfo"                                                                                  // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 38. Claim.diagnosis
            public class Type_Diagnosis : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Diagnosis_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 39. Claim.diagnosis.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:216
                    // 40. Claim.diagnosis.diagnosis[x]
                    public ElementDefinitionInfo Diagnosis;                                                                                 // MakerGen.cs:216
                    // 41. Claim.diagnosis.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 42. Claim.diagnosis.onAdmission
                    public ElementDefinitionInfo OnAdmission;                                                                               // MakerGen.cs:216
                    // 43. Claim.diagnosis.packageCode
                    public ElementDefinitionInfo PackageCode;                                                                               // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Diagnosis_Elements()                                                                                        // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 39. Claim.diagnosis.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Sequence",                                                                                          // MakerGen.cs:235
                                Path= "Claim.diagnosis.sequence",                                                                           // MakerGen.cs:236
                                Id = "Claim.diagnosis.sequence",                                                                            // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 40. Claim.diagnosis.diagnosis[x]
                            this.Diagnosis = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Diagnosis",                                                                                         // MakerGen.cs:235
                                Path= "Claim.diagnosis.diagnosis[x]",                                                                       // MakerGen.cs:236
                                Id = "Claim.diagnosis.diagnosis[x]",                                                                        // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    },                                                                                                      // MakerGen.cs:319
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Condition"                                             // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 41. Claim.diagnosis.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "Claim.diagnosis.type",                                                                               // MakerGen.cs:236
                                Id = "Claim.diagnosis.type",                                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 42. Claim.diagnosis.onAdmission
                            this.OnAdmission = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "OnAdmission",                                                                                       // MakerGen.cs:235
                                Path= "Claim.diagnosis.onAdmission",                                                                        // MakerGen.cs:236
                                Id = "Claim.diagnosis.onAdmission",                                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 43. Claim.diagnosis.packageCode
                            this.PackageCode = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PackageCode",                                                                                       // MakerGen.cs:235
                                Path= "Claim.diagnosis.packageCode",                                                                        // MakerGen.cs:236
                                Id = "Claim.diagnosis.packageCode",                                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:220
                        Diagnosis.Write(sDef);                                                                                              // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        OnAdmission.Write(sDef);                                                                                            // MakerGen.cs:220
                        PackageCode.Write(sDef);                                                                                            // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Diagnosis_Elements Elements                                                                                     // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Diagnosis_Elements();                                                                  // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Diagnosis_Elements elements;                                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Diagnosis()                                                                                                     // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "Claim.diagnosis",                                                                                           // MakerGen.cs:428
                        ElementId = "Claim.diagnosis"                                                                                       // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 44. Claim.procedure
            public class Type_Procedure : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Procedure_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 45. Claim.procedure.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:216
                    // 46. Claim.procedure.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 47. Claim.procedure.date
                    public ElementDefinitionInfo Date;                                                                                      // MakerGen.cs:216
                    // 48. Claim.procedure.procedure[x]
                    public ElementDefinitionInfo Procedure;                                                                                 // MakerGen.cs:216
                    // 49. Claim.procedure.udi
                    public ElementDefinitionInfo Udi;                                                                                       // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Procedure_Elements()                                                                                        // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 45. Claim.procedure.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Sequence",                                                                                          // MakerGen.cs:235
                                Path= "Claim.procedure.sequence",                                                                           // MakerGen.cs:236
                                Id = "Claim.procedure.sequence",                                                                            // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 46. Claim.procedure.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "Claim.procedure.type",                                                                               // MakerGen.cs:236
                                Id = "Claim.procedure.type",                                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 47. Claim.procedure.date
                            this.Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Date",                                                                                              // MakerGen.cs:235
                                Path= "Claim.procedure.date",                                                                               // MakerGen.cs:236
                                Id = "Claim.procedure.date",                                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 48. Claim.procedure.procedure[x]
                            this.Procedure = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Procedure",                                                                                         // MakerGen.cs:235
                                Path= "Claim.procedure.procedure[x]",                                                                       // MakerGen.cs:236
                                Id = "Claim.procedure.procedure[x]",                                                                        // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    },                                                                                                      // MakerGen.cs:319
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Procedure"                                             // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 49. Claim.procedure.udi
                            this.Udi = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Udi",                                                                                               // MakerGen.cs:235
                                Path= "Claim.procedure.udi",                                                                                // MakerGen.cs:236
                                Id = "Claim.procedure.udi",                                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Device"                                                // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Date.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Procedure.Write(sDef);                                                                                              // MakerGen.cs:220
                        Udi.Write(sDef);                                                                                                    // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Procedure_Elements Elements                                                                                     // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Procedure_Elements();                                                                  // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Procedure_Elements elements;                                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Procedure()                                                                                                     // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "Claim.procedure",                                                                                           // MakerGen.cs:428
                        ElementId = "Claim.procedure"                                                                                       // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 50. Claim.insurance
            public class Type_Insurance : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Insurance_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 51. Claim.insurance.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:216
                    // 52. Claim.insurance.focal
                    public ElementDefinitionInfo Focal;                                                                                     // MakerGen.cs:216
                    // 53. Claim.insurance.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:216
                    // 54. Claim.insurance.coverage
                    public ElementDefinitionInfo Coverage;                                                                                  // MakerGen.cs:216
                    // 55. Claim.insurance.businessArrangement
                    public ElementDefinitionInfo BusinessArrangement;                                                                       // MakerGen.cs:216
                    // 56. Claim.insurance.preAuthRef
                    public ElementDefinitionInfo PreAuthRef;                                                                                // MakerGen.cs:216
                    // 57. Claim.insurance.claimResponse
                    public ElementDefinitionInfo ClaimResponse;                                                                             // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Insurance_Elements()                                                                                        // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 51. Claim.insurance.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Sequence",                                                                                          // MakerGen.cs:235
                                Path= "Claim.insurance.sequence",                                                                           // MakerGen.cs:236
                                Id = "Claim.insurance.sequence",                                                                            // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 52. Claim.insurance.focal
                            this.Focal = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Focal",                                                                                             // MakerGen.cs:235
                                Path= "Claim.insurance.focal",                                                                              // MakerGen.cs:236
                                Id = "Claim.insurance.focal",                                                                               // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 53. Claim.insurance.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Identifier",                                                                                        // MakerGen.cs:235
                                Path= "Claim.insurance.identifier",                                                                         // MakerGen.cs:236
                                Id = "Claim.insurance.identifier",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 54. Claim.insurance.coverage
                            this.Coverage = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Coverage",                                                                                          // MakerGen.cs:235
                                Path= "Claim.insurance.coverage",                                                                           // MakerGen.cs:236
                                Id = "Claim.insurance.coverage",                                                                            // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Coverage"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 55. Claim.insurance.businessArrangement
                            this.BusinessArrangement = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "BusinessArrangement",                                                                               // MakerGen.cs:235
                                Path= "Claim.insurance.businessArrangement",                                                                // MakerGen.cs:236
                                Id = "Claim.insurance.businessArrangement",                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 56. Claim.insurance.preAuthRef
                            this.PreAuthRef = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PreAuthRef",                                                                                        // MakerGen.cs:235
                                Path= "Claim.insurance.preAuthRef",                                                                         // MakerGen.cs:236
                                Id = "Claim.insurance.preAuthRef",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 57. Claim.insurance.claimResponse
                            this.ClaimResponse = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ClaimResponse",                                                                                     // MakerGen.cs:235
                                Path= "Claim.insurance.claimResponse",                                                                      // MakerGen.cs:236
                                Id = "Claim.insurance.claimResponse",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/ClaimResponse"                                         // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:220
                        Focal.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:220
                        Coverage.Write(sDef);                                                                                               // MakerGen.cs:220
                        BusinessArrangement.Write(sDef);                                                                                    // MakerGen.cs:220
                        PreAuthRef.Write(sDef);                                                                                             // MakerGen.cs:220
                        ClaimResponse.Write(sDef);                                                                                          // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Insurance_Elements Elements                                                                                     // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Insurance_Elements();                                                                  // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Insurance_Elements elements;                                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Insurance()                                                                                                     // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "Claim.insurance",                                                                                           // MakerGen.cs:428
                        ElementId = "Claim.insurance"                                                                                       // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 58. Claim.accident
            public class Type_Accident : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Accident_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 59. Claim.accident.date
                    public ElementDefinitionInfo Date;                                                                                      // MakerGen.cs:216
                    // 60. Claim.accident.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 61. Claim.accident.location[x]
                    public ElementDefinitionInfo Location;                                                                                  // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Accident_Elements()                                                                                         // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 59. Claim.accident.date
                            this.Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Date",                                                                                              // MakerGen.cs:235
                                Path= "Claim.accident.date",                                                                                // MakerGen.cs:236
                                Id = "Claim.accident.date",                                                                                 // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 60. Claim.accident.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "Claim.accident.type",                                                                                // MakerGen.cs:236
                                Id = "Claim.accident.type",                                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 61. Claim.accident.location[x]
                            this.Location = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Location",                                                                                          // MakerGen.cs:235
                                Path= "Claim.accident.location[x]",                                                                         // MakerGen.cs:236
                                Id = "Claim.accident.location[x]",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Address                                                               // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    },                                                                                                      // MakerGen.cs:360
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Location"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Date.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Location.Write(sDef);                                                                                               // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Accident_Elements Elements                                                                                      // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Accident_Elements();                                                                   // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Accident_Elements elements;                                                                                            // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Accident()                                                                                                      // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "Claim.accident",                                                                                            // MakerGen.cs:428
                        ElementId = "Claim.accident"                                                                                        // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 62. Claim.item
            public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Item_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 83. Claim.item.detail
                    public class Type_Detail : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Detail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 95. Claim.item.detail.subDetail
                            public class Type_SubDetail : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                public class Type_SubDetail_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                          // MakerGen.cs:386
                                {                                                                                                           // MakerGen.cs:387
                                    // 96. Claim.item.detail.subDetail.sequence
                                    public ElementDefinitionInfo Sequence;                                                                  // MakerGen.cs:216
                                    // 97. Claim.item.detail.subDetail.revenue
                                    public ElementDefinitionInfo Revenue;                                                                   // MakerGen.cs:216
                                    // 98. Claim.item.detail.subDetail.category
                                    public ElementDefinitionInfo Category;                                                                  // MakerGen.cs:216
                                    // 99. Claim.item.detail.subDetail.productOrService
                                    public ElementDefinitionInfo ProductOrService;                                                          // MakerGen.cs:216
                                    // 100. Claim.item.detail.subDetail.modifier
                                    public ElementDefinitionInfo Modifier;                                                                  // MakerGen.cs:216
                                    // 101. Claim.item.detail.subDetail.programCode
                                    public ElementDefinitionInfo ProgramCode;                                                               // MakerGen.cs:216
                                    // 102. Claim.item.detail.subDetail.quantity
                                    public ElementDefinitionInfo Quantity;                                                                  // MakerGen.cs:216
                                    // 103. Claim.item.detail.subDetail.unitPrice
                                    public ElementDefinitionInfo UnitPrice;                                                                 // MakerGen.cs:216
                                    // 104. Claim.item.detail.subDetail.factor
                                    public ElementDefinitionInfo Factor;                                                                    // MakerGen.cs:216
                                    // 105. Claim.item.detail.subDetail.net
                                    public ElementDefinitionInfo Net;                                                                       // MakerGen.cs:216
                                    // 106. Claim.item.detail.subDetail.udi
                                    public ElementDefinitionInfo Udi;                                                                       // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                                    public Type_SubDetail_Elements()                                                                        // MakerGen.cs:392
                                    {                                                                                                       // MakerGen.cs:393
                                        {                                                                                                   // MakerGen.cs:231
                                            // 96. Claim.item.detail.subDetail.sequence
                                            this.Sequence = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Sequence",                                                                          // MakerGen.cs:235
                                                Path= "Claim.item.detail.subDetail.sequence",                                               // MakerGen.cs:236
                                                Id = "Claim.item.detail.subDetail.sequence",                                                // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                         // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 97. Claim.item.detail.subDetail.revenue
                                            this.Revenue = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Revenue",                                                                           // MakerGen.cs:235
                                                Path= "Claim.item.detail.subDetail.revenue",                                                // MakerGen.cs:236
                                                Id = "Claim.item.detail.subDetail.revenue",                                                 // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 98. Claim.item.detail.subDetail.category
                                            this.Category = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Category",                                                                          // MakerGen.cs:235
                                                Path= "Claim.item.detail.subDetail.category",                                               // MakerGen.cs:236
                                                Id = "Claim.item.detail.subDetail.category",                                                // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 99. Claim.item.detail.subDetail.productOrService
                                            this.ProductOrService = new ElementDefinitionInfo                                               // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "ProductOrService",                                                                  // MakerGen.cs:235
                                                Path= "Claim.item.detail.subDetail.productOrService",                                       // MakerGen.cs:236
                                                Id = "Claim.item.detail.subDetail.productOrService",                                        // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 100. Claim.item.detail.subDetail.modifier
                                            this.Modifier = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Modifier",                                                                          // MakerGen.cs:235
                                                Path= "Claim.item.detail.subDetail.modifier",                                               // MakerGen.cs:236
                                                Id = "Claim.item.detail.subDetail.modifier",                                                // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 101. Claim.item.detail.subDetail.programCode
                                            this.ProgramCode = new ElementDefinitionInfo                                                    // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "ProgramCode",                                                                       // MakerGen.cs:235
                                                Path= "Claim.item.detail.subDetail.programCode",                                            // MakerGen.cs:236
                                                Id = "Claim.item.detail.subDetail.programCode",                                             // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    }                                                                                       // MakerGen.cs:319
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 102. Claim.item.detail.subDetail.quantity
                                            this.Quantity = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Quantity",                                                                          // MakerGen.cs:235
                                                Path= "Claim.item.detail.subDetail.quantity",                                               // MakerGen.cs:236
                                                Id = "Claim.item.detail.subDetail.quantity",                                                // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Quantity                                              // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 103. Claim.item.detail.subDetail.unitPrice
                                            this.UnitPrice = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "UnitPrice",                                                                         // MakerGen.cs:235
                                                Path= "Claim.item.detail.subDetail.unitPrice",                                              // MakerGen.cs:236
                                                Id = "Claim.item.detail.subDetail.unitPrice",                                               // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Money                                                 // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 104. Claim.item.detail.subDetail.factor
                                            this.Factor = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Factor",                                                                            // MakerGen.cs:235
                                                Path= "Claim.item.detail.subDetail.factor",                                                 // MakerGen.cs:236
                                                Id = "Claim.item.detail.subDetail.factor",                                                  // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Decimal                                             // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 105. Claim.item.detail.subDetail.net
                                            this.Net = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Net",                                                                               // MakerGen.cs:235
                                                Path= "Claim.item.detail.subDetail.net",                                                    // MakerGen.cs:236
                                                Id = "Claim.item.detail.subDetail.net",                                                     // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Money                                                 // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 106. Claim.item.detail.subDetail.udi
                                            this.Udi = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Udi",                                                                               // MakerGen.cs:235
                                                Path= "Claim.item.detail.subDetail.udi",                                                    // MakerGen.cs:236
                                                Id = "Claim.item.detail.subDetail.udi",                                                     // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Complex.Reference                                             // MakerGen.cs:346
                                                    {                                                                                       // MakerGen.cs:347
                                                        TargetProfile = new String[]                                                        // MakerGen.cs:349
                                                        {                                                                                   // CodeEditorExtensions.cs:28
                                                            "http://hl7.org/fhir/StructureDefinition/Device"                                // MakerGen.cs:349
                                                        }                                                                                   // CodeEditorExtensions.cs:34
                                                    }                                                                                       // MakerGen.cs:350
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:398
                                    {                                                                                                       // MakerGen.cs:399
                                        base.Write(sDef);                                                                                   // MakerGen.cs:400
                                        Sequence.Write(sDef);                                                                               // MakerGen.cs:220
                                        Revenue.Write(sDef);                                                                                // MakerGen.cs:220
                                        Category.Write(sDef);                                                                               // MakerGen.cs:220
                                        ProductOrService.Write(sDef);                                                                       // MakerGen.cs:220
                                        Modifier.Write(sDef);                                                                               // MakerGen.cs:220
                                        ProgramCode.Write(sDef);                                                                            // MakerGen.cs:220
                                        Quantity.Write(sDef);                                                                               // MakerGen.cs:220
                                        UnitPrice.Write(sDef);                                                                              // MakerGen.cs:220
                                        Factor.Write(sDef);                                                                                 // MakerGen.cs:220
                                        Net.Write(sDef);                                                                                    // MakerGen.cs:220
                                        Udi.Write(sDef);                                                                                    // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:402
                                }                                                                                                           // MakerGen.cs:404
                                public Type_SubDetail_Elements Elements                                                                     // MakerGen.cs:406
                                {                                                                                                           // MakerGen.cs:407
                                    get                                                                                                     // MakerGen.cs:408
                                    {                                                                                                       // MakerGen.cs:409
                                        if (this.elements == null)                                                                          // MakerGen.cs:410
                                            this.elements = new Type_SubDetail_Elements();                                                  // MakerGen.cs:411
                                        return this.elements;                                                                               // MakerGen.cs:412
                                    }                                                                                                       // MakerGen.cs:413
                                }                                                                                                           // MakerGen.cs:414
                                Type_SubDetail_Elements elements;                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                                public Type_SubDetail()                                                                                     // MakerGen.cs:418
                                {                                                                                                           // MakerGen.cs:419
                                }                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:424
                                {                                                                                                           // MakerGen.cs:425
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:426
                                    {                                                                                                       // MakerGen.cs:427
                                        Path = "Claim.item.detail.subDetail",                                                               // MakerGen.cs:428
                                        ElementId = "Claim.item.detail.subDetail"                                                           // MakerGen.cs:429
                                    });                                                                                                     // MakerGen.cs:430
                                    if (this.elements != null)                                                                              // MakerGen.cs:431
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:432
                                }                                                                                                           // MakerGen.cs:433
                            }                                                                                                               // MakerGen.cs:434
                            // 84. Claim.item.detail.sequence
                            public ElementDefinitionInfo Sequence;                                                                          // MakerGen.cs:216
                            // 85. Claim.item.detail.revenue
                            public ElementDefinitionInfo Revenue;                                                                           // MakerGen.cs:216
                            // 86. Claim.item.detail.category
                            public ElementDefinitionInfo Category;                                                                          // MakerGen.cs:216
                            // 87. Claim.item.detail.productOrService
                            public ElementDefinitionInfo ProductOrService;                                                                  // MakerGen.cs:216
                            // 88. Claim.item.detail.modifier
                            public ElementDefinitionInfo Modifier;                                                                          // MakerGen.cs:216
                            // 89. Claim.item.detail.programCode
                            public ElementDefinitionInfo ProgramCode;                                                                       // MakerGen.cs:216
                            // 90. Claim.item.detail.quantity
                            public ElementDefinitionInfo Quantity;                                                                          // MakerGen.cs:216
                            // 91. Claim.item.detail.unitPrice
                            public ElementDefinitionInfo UnitPrice;                                                                         // MakerGen.cs:216
                            // 92. Claim.item.detail.factor
                            public ElementDefinitionInfo Factor;                                                                            // MakerGen.cs:216
                            // 93. Claim.item.detail.net
                            public ElementDefinitionInfo Net;                                                                               // MakerGen.cs:216
                            // 94. Claim.item.detail.udi
                            public ElementDefinitionInfo Udi;                                                                               // MakerGen.cs:216
                            // 95. Claim.item.detail.subDetail
                            public ElementDefinitionInfo SubDetail;                                                                         // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Detail_Elements()                                                                                   // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 84. Claim.item.detail.sequence
                                    this.Sequence = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Sequence",                                                                                  // MakerGen.cs:235
                                        Path= "Claim.item.detail.sequence",                                                                 // MakerGen.cs:236
                                        Id = "Claim.item.detail.sequence",                                                                  // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.PositiveInt                                                 // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 85. Claim.item.detail.revenue
                                    this.Revenue = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Revenue",                                                                                   // MakerGen.cs:235
                                        Path= "Claim.item.detail.revenue",                                                                  // MakerGen.cs:236
                                        Id = "Claim.item.detail.revenue",                                                                   // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 86. Claim.item.detail.category
                                    this.Category = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Category",                                                                                  // MakerGen.cs:235
                                        Path= "Claim.item.detail.category",                                                                 // MakerGen.cs:236
                                        Id = "Claim.item.detail.category",                                                                  // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 87. Claim.item.detail.productOrService
                                    this.ProductOrService = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "ProductOrService",                                                                          // MakerGen.cs:235
                                        Path= "Claim.item.detail.productOrService",                                                         // MakerGen.cs:236
                                        Id = "Claim.item.detail.productOrService",                                                          // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 88. Claim.item.detail.modifier
                                    this.Modifier = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Modifier",                                                                                  // MakerGen.cs:235
                                        Path= "Claim.item.detail.modifier",                                                                 // MakerGen.cs:236
                                        Id = "Claim.item.detail.modifier",                                                                  // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 89. Claim.item.detail.programCode
                                    this.ProgramCode = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "ProgramCode",                                                                               // MakerGen.cs:235
                                        Path= "Claim.item.detail.programCode",                                                              // MakerGen.cs:236
                                        Id = "Claim.item.detail.programCode",                                                               // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 90. Claim.item.detail.quantity
                                    this.Quantity = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Quantity",                                                                                  // MakerGen.cs:235
                                        Path= "Claim.item.detail.quantity",                                                                 // MakerGen.cs:236
                                        Id = "Claim.item.detail.quantity",                                                                  // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 91. Claim.item.detail.unitPrice
                                    this.UnitPrice = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "UnitPrice",                                                                                 // MakerGen.cs:235
                                        Path= "Claim.item.detail.unitPrice",                                                                // MakerGen.cs:236
                                        Id = "Claim.item.detail.unitPrice",                                                                 // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Money                                                         // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 92. Claim.item.detail.factor
                                    this.Factor = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Factor",                                                                                    // MakerGen.cs:235
                                        Path= "Claim.item.detail.factor",                                                                   // MakerGen.cs:236
                                        Id = "Claim.item.detail.factor",                                                                    // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 93. Claim.item.detail.net
                                    this.Net = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Net",                                                                                       // MakerGen.cs:235
                                        Path= "Claim.item.detail.net",                                                                      // MakerGen.cs:236
                                        Id = "Claim.item.detail.net",                                                                       // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Money                                                         // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 94. Claim.item.detail.udi
                                    this.Udi = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Udi",                                                                                       // MakerGen.cs:235
                                        Path= "Claim.item.detail.udi",                                                                      // MakerGen.cs:236
                                        Id = "Claim.item.detail.udi",                                                                       // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:346
                                            {                                                                                               // MakerGen.cs:347
                                                TargetProfile = new String[]                                                                // MakerGen.cs:349
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Device"                                        // MakerGen.cs:349
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:350
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 95. Claim.item.detail.subDetail
                                    this.SubDetail = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "SubDetail",                                                                                 // MakerGen.cs:235
                                        Path= "Claim.item.detail.subDetail",                                                                // MakerGen.cs:236
                                        Id = "Claim.item.detail.subDetail",                                                                 // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_SubDetail                                                                              // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Sequence.Write(sDef);                                                                                       // MakerGen.cs:220
                                Revenue.Write(sDef);                                                                                        // MakerGen.cs:220
                                Category.Write(sDef);                                                                                       // MakerGen.cs:220
                                ProductOrService.Write(sDef);                                                                               // MakerGen.cs:220
                                Modifier.Write(sDef);                                                                                       // MakerGen.cs:220
                                ProgramCode.Write(sDef);                                                                                    // MakerGen.cs:220
                                Quantity.Write(sDef);                                                                                       // MakerGen.cs:220
                                UnitPrice.Write(sDef);                                                                                      // MakerGen.cs:220
                                Factor.Write(sDef);                                                                                         // MakerGen.cs:220
                                Net.Write(sDef);                                                                                            // MakerGen.cs:220
                                Udi.Write(sDef);                                                                                            // MakerGen.cs:220
                                SubDetail.Write(sDef);                                                                                      // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Detail_Elements Elements                                                                                // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Detail_Elements();                                                             // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Detail_Elements elements;                                                                                      // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Detail()                                                                                                // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "Claim.item.detail",                                                                                 // MakerGen.cs:428
                                ElementId = "Claim.item.detail"                                                                             // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 63. Claim.item.sequence
                    public ElementDefinitionInfo Sequence;                                                                                  // MakerGen.cs:216
                    // 64. Claim.item.careTeamSequence
                    public ElementDefinitionInfo CareTeamSequence;                                                                          // MakerGen.cs:216
                    // 65. Claim.item.diagnosisSequence
                    public ElementDefinitionInfo DiagnosisSequence;                                                                         // MakerGen.cs:216
                    // 66. Claim.item.procedureSequence
                    public ElementDefinitionInfo ProcedureSequence;                                                                         // MakerGen.cs:216
                    // 67. Claim.item.informationSequence
                    public ElementDefinitionInfo InformationSequence;                                                                       // MakerGen.cs:216
                    // 68. Claim.item.revenue
                    public ElementDefinitionInfo Revenue;                                                                                   // MakerGen.cs:216
                    // 69. Claim.item.category
                    public ElementDefinitionInfo Category;                                                                                  // MakerGen.cs:216
                    // 70. Claim.item.productOrService
                    public ElementDefinitionInfo ProductOrService;                                                                          // MakerGen.cs:216
                    // 71. Claim.item.modifier
                    public ElementDefinitionInfo Modifier;                                                                                  // MakerGen.cs:216
                    // 72. Claim.item.programCode
                    public ElementDefinitionInfo ProgramCode;                                                                               // MakerGen.cs:216
                    // 73. Claim.item.serviced[x]
                    public ElementDefinitionInfo Serviced;                                                                                  // MakerGen.cs:216
                    // 74. Claim.item.location[x]
                    public ElementDefinitionInfo Location;                                                                                  // MakerGen.cs:216
                    // 75. Claim.item.quantity
                    public ElementDefinitionInfo Quantity;                                                                                  // MakerGen.cs:216
                    // 76. Claim.item.unitPrice
                    public ElementDefinitionInfo UnitPrice;                                                                                 // MakerGen.cs:216
                    // 77. Claim.item.factor
                    public ElementDefinitionInfo Factor;                                                                                    // MakerGen.cs:216
                    // 78. Claim.item.net
                    public ElementDefinitionInfo Net;                                                                                       // MakerGen.cs:216
                    // 79. Claim.item.udi
                    public ElementDefinitionInfo Udi;                                                                                       // MakerGen.cs:216
                    // 80. Claim.item.bodySite
                    public ElementDefinitionInfo BodySite;                                                                                  // MakerGen.cs:216
                    // 81. Claim.item.subSite
                    public ElementDefinitionInfo SubSite;                                                                                   // MakerGen.cs:216
                    // 82. Claim.item.encounter
                    public ElementDefinitionInfo Encounter;                                                                                 // MakerGen.cs:216
                    // 83. Claim.item.detail
                    public ElementDefinitionInfo Detail;                                                                                    // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Item_Elements()                                                                                             // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 63. Claim.item.sequence
                            this.Sequence = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Sequence",                                                                                          // MakerGen.cs:235
                                Path= "Claim.item.sequence",                                                                                // MakerGen.cs:236
                                Id = "Claim.item.sequence",                                                                                 // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 64. Claim.item.careTeamSequence
                            this.CareTeamSequence = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "CareTeamSequence",                                                                                  // MakerGen.cs:235
                                Path= "Claim.item.careTeamSequence",                                                                        // MakerGen.cs:236
                                Id = "Claim.item.careTeamSequence",                                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 65. Claim.item.diagnosisSequence
                            this.DiagnosisSequence = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "DiagnosisSequence",                                                                                 // MakerGen.cs:235
                                Path= "Claim.item.diagnosisSequence",                                                                       // MakerGen.cs:236
                                Id = "Claim.item.diagnosisSequence",                                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 66. Claim.item.procedureSequence
                            this.ProcedureSequence = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ProcedureSequence",                                                                                 // MakerGen.cs:235
                                Path= "Claim.item.procedureSequence",                                                                       // MakerGen.cs:236
                                Id = "Claim.item.procedureSequence",                                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 67. Claim.item.informationSequence
                            this.InformationSequence = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "InformationSequence",                                                                               // MakerGen.cs:235
                                Path= "Claim.item.informationSequence",                                                                     // MakerGen.cs:236
                                Id = "Claim.item.informationSequence",                                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 68. Claim.item.revenue
                            this.Revenue = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Revenue",                                                                                           // MakerGen.cs:235
                                Path= "Claim.item.revenue",                                                                                 // MakerGen.cs:236
                                Id = "Claim.item.revenue",                                                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 69. Claim.item.category
                            this.Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Category",                                                                                          // MakerGen.cs:235
                                Path= "Claim.item.category",                                                                                // MakerGen.cs:236
                                Id = "Claim.item.category",                                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 70. Claim.item.productOrService
                            this.ProductOrService = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ProductOrService",                                                                                  // MakerGen.cs:235
                                Path= "Claim.item.productOrService",                                                                        // MakerGen.cs:236
                                Id = "Claim.item.productOrService",                                                                         // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 71. Claim.item.modifier
                            this.Modifier = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Modifier",                                                                                          // MakerGen.cs:235
                                Path= "Claim.item.modifier",                                                                                // MakerGen.cs:236
                                Id = "Claim.item.modifier",                                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 72. Claim.item.programCode
                            this.ProgramCode = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ProgramCode",                                                                                       // MakerGen.cs:235
                                Path= "Claim.item.programCode",                                                                             // MakerGen.cs:236
                                Id = "Claim.item.programCode",                                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 73. Claim.item.serviced[x]
                            this.Serviced = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Serviced",                                                                                          // MakerGen.cs:235
                                Path= "Claim.item.serviced[x]",                                                                             // MakerGen.cs:236
                                Id = "Claim.item.serviced[x]",                                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    },                                                                                                      // MakerGen.cs:304
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 74. Claim.item.location[x]
                            this.Location = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Location",                                                                                          // MakerGen.cs:235
                                Path= "Claim.item.location[x]",                                                                             // MakerGen.cs:236
                                Id = "Claim.item.location[x]",                                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    },                                                                                                      // MakerGen.cs:319
                                    new FhirKhit.Maker.Common.Complex.Address                                                               // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    },                                                                                                      // MakerGen.cs:360
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Location"                                              // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 75. Claim.item.quantity
                            this.Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Quantity",                                                                                          // MakerGen.cs:235
                                Path= "Claim.item.quantity",                                                                                // MakerGen.cs:236
                                Id = "Claim.item.quantity",                                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 76. Claim.item.unitPrice
                            this.UnitPrice = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "UnitPrice",                                                                                         // MakerGen.cs:235
                                Path= "Claim.item.unitPrice",                                                                               // MakerGen.cs:236
                                Id = "Claim.item.unitPrice",                                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 77. Claim.item.factor
                            this.Factor = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Factor",                                                                                            // MakerGen.cs:235
                                Path= "Claim.item.factor",                                                                                  // MakerGen.cs:236
                                Id = "Claim.item.factor",                                                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 78. Claim.item.net
                            this.Net = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Net",                                                                                               // MakerGen.cs:235
                                Path= "Claim.item.net",                                                                                     // MakerGen.cs:236
                                Id = "Claim.item.net",                                                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 79. Claim.item.udi
                            this.Udi = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Udi",                                                                                               // MakerGen.cs:235
                                Path= "Claim.item.udi",                                                                                     // MakerGen.cs:236
                                Id = "Claim.item.udi",                                                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Device"                                                // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 80. Claim.item.bodySite
                            this.BodySite = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "BodySite",                                                                                          // MakerGen.cs:235
                                Path= "Claim.item.bodySite",                                                                                // MakerGen.cs:236
                                Id = "Claim.item.bodySite",                                                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 81. Claim.item.subSite
                            this.SubSite = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "SubSite",                                                                                           // MakerGen.cs:235
                                Path= "Claim.item.subSite",                                                                                 // MakerGen.cs:236
                                Id = "Claim.item.subSite",                                                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 82. Claim.item.encounter
                            this.Encounter = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Encounter",                                                                                         // MakerGen.cs:235
                                Path= "Claim.item.encounter",                                                                               // MakerGen.cs:236
                                Id = "Claim.item.encounter",                                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Encounter"                                             // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 83. Claim.item.detail
                            this.Detail = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Detail",                                                                                            // MakerGen.cs:235
                                Path= "Claim.item.detail",                                                                                  // MakerGen.cs:236
                                Id = "Claim.item.detail",                                                                                   // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Detail                                                                                         // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Sequence.Write(sDef);                                                                                               // MakerGen.cs:220
                        CareTeamSequence.Write(sDef);                                                                                       // MakerGen.cs:220
                        DiagnosisSequence.Write(sDef);                                                                                      // MakerGen.cs:220
                        ProcedureSequence.Write(sDef);                                                                                      // MakerGen.cs:220
                        InformationSequence.Write(sDef);                                                                                    // MakerGen.cs:220
                        Revenue.Write(sDef);                                                                                                // MakerGen.cs:220
                        Category.Write(sDef);                                                                                               // MakerGen.cs:220
                        ProductOrService.Write(sDef);                                                                                       // MakerGen.cs:220
                        Modifier.Write(sDef);                                                                                               // MakerGen.cs:220
                        ProgramCode.Write(sDef);                                                                                            // MakerGen.cs:220
                        Serviced.Write(sDef);                                                                                               // MakerGen.cs:220
                        Location.Write(sDef);                                                                                               // MakerGen.cs:220
                        Quantity.Write(sDef);                                                                                               // MakerGen.cs:220
                        UnitPrice.Write(sDef);                                                                                              // MakerGen.cs:220
                        Factor.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Net.Write(sDef);                                                                                                    // MakerGen.cs:220
                        Udi.Write(sDef);                                                                                                    // MakerGen.cs:220
                        BodySite.Write(sDef);                                                                                               // MakerGen.cs:220
                        SubSite.Write(sDef);                                                                                                // MakerGen.cs:220
                        Encounter.Write(sDef);                                                                                              // MakerGen.cs:220
                        Detail.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Item_Elements Elements                                                                                          // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Item_Elements();                                                                       // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Item_Elements elements;                                                                                                // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Item()                                                                                                          // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "Claim.item",                                                                                                // MakerGen.cs:428
                        ElementId = "Claim.item"                                                                                            // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. Claim.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. Claim.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. Claim.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:216
            // 4. Claim.subType
            public ElementDefinitionInfo SubType;                                                                                           // MakerGen.cs:216
            // 5. Claim.use
            public ElementDefinitionInfo Use;                                                                                               // MakerGen.cs:216
            // 6. Claim.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:216
            // 7. Claim.billablePeriod
            public ElementDefinitionInfo BillablePeriod;                                                                                    // MakerGen.cs:216
            // 8. Claim.created
            public ElementDefinitionInfo Created;                                                                                           // MakerGen.cs:216
            // 9. Claim.enterer
            public ElementDefinitionInfo Enterer;                                                                                           // MakerGen.cs:216
            // 10. Claim.insurer
            public ElementDefinitionInfo Insurer;                                                                                           // MakerGen.cs:216
            // 11. Claim.provider
            public ElementDefinitionInfo Provider;                                                                                          // MakerGen.cs:216
            // 12. Claim.priority
            public ElementDefinitionInfo Priority;                                                                                          // MakerGen.cs:216
            // 13. Claim.fundsReserve
            public ElementDefinitionInfo FundsReserve;                                                                                      // MakerGen.cs:216
            // 14. Claim.related
            public ElementDefinitionInfo Related;                                                                                           // MakerGen.cs:216
            // 18. Claim.prescription
            public ElementDefinitionInfo Prescription;                                                                                      // MakerGen.cs:216
            // 19. Claim.originalPrescription
            public ElementDefinitionInfo OriginalPrescription;                                                                              // MakerGen.cs:216
            // 20. Claim.payee
            public ElementDefinitionInfo Payee;                                                                                             // MakerGen.cs:216
            // 23. Claim.referral
            public ElementDefinitionInfo Referral;                                                                                          // MakerGen.cs:216
            // 24. Claim.facility
            public ElementDefinitionInfo Facility;                                                                                          // MakerGen.cs:216
            // 25. Claim.careTeam
            public ElementDefinitionInfo CareTeam;                                                                                          // MakerGen.cs:216
            // 31. Claim.supportingInfo
            public ElementDefinitionInfo SupportingInfo;                                                                                    // MakerGen.cs:216
            // 38. Claim.diagnosis
            public ElementDefinitionInfo Diagnosis;                                                                                         // MakerGen.cs:216
            // 44. Claim.procedure
            public ElementDefinitionInfo Procedure;                                                                                         // MakerGen.cs:216
            // 50. Claim.insurance
            public ElementDefinitionInfo Insurance;                                                                                         // MakerGen.cs:216
            // 58. Claim.accident
            public ElementDefinitionInfo Accident;                                                                                          // MakerGen.cs:216
            // 62. Claim.item
            public ElementDefinitionInfo Item;                                                                                              // MakerGen.cs:216
            // 107. Claim.total
            public ElementDefinitionInfo Total;                                                                                             // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public Claim_Elements()                                                                                                         // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. Claim.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "Claim.identifier",                                                                                           // MakerGen.cs:236
                        Id = "Claim.identifier",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. Claim.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "Claim.status",                                                                                               // MakerGen.cs:236
                        Id = "Claim.status",                                                                                                // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. Claim.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Type",                                                                                                      // MakerGen.cs:235
                        Path= "Claim.type",                                                                                                 // MakerGen.cs:236
                        Id = "Claim.type",                                                                                                  // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. Claim.subType
                    this.SubType = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SubType",                                                                                                   // MakerGen.cs:235
                        Path= "Claim.subType",                                                                                              // MakerGen.cs:236
                        Id = "Claim.subType",                                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. Claim.use
                    this.Use = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Use",                                                                                                       // MakerGen.cs:235
                        Path= "Claim.use",                                                                                                  // MakerGen.cs:236
                        Id = "Claim.use",                                                                                                   // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. Claim.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Patient",                                                                                                   // MakerGen.cs:235
                        Path= "Claim.patient",                                                                                              // MakerGen.cs:236
                        Id = "Claim.patient",                                                                                               // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. Claim.billablePeriod
                    this.BillablePeriod = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "BillablePeriod",                                                                                            // MakerGen.cs:235
                        Path= "Claim.billablePeriod",                                                                                       // MakerGen.cs:236
                        Id = "Claim.billablePeriod",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. Claim.created
                    this.Created = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Created",                                                                                                   // MakerGen.cs:235
                        Path= "Claim.created",                                                                                              // MakerGen.cs:236
                        Id = "Claim.created",                                                                                               // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. Claim.enterer
                    this.Enterer = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Enterer",                                                                                                   // MakerGen.cs:235
                        Path= "Claim.enterer",                                                                                              // MakerGen.cs:236
                        Id = "Claim.enterer",                                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. Claim.insurer
                    this.Insurer = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Insurer",                                                                                                   // MakerGen.cs:235
                        Path= "Claim.insurer",                                                                                              // MakerGen.cs:236
                        Id = "Claim.insurer",                                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. Claim.provider
                    this.Provider = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Provider",                                                                                                  // MakerGen.cs:235
                        Path= "Claim.provider",                                                                                             // MakerGen.cs:236
                        Id = "Claim.provider",                                                                                              // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. Claim.priority
                    this.Priority = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Priority",                                                                                                  // MakerGen.cs:235
                        Path= "Claim.priority",                                                                                             // MakerGen.cs:236
                        Id = "Claim.priority",                                                                                              // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. Claim.fundsReserve
                    this.FundsReserve = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "FundsReserve",                                                                                              // MakerGen.cs:235
                        Path= "Claim.fundsReserve",                                                                                         // MakerGen.cs:236
                        Id = "Claim.fundsReserve",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. Claim.related
                    this.Related = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Related",                                                                                                   // MakerGen.cs:235
                        Path= "Claim.related",                                                                                              // MakerGen.cs:236
                        Id = "Claim.related",                                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Related                                                                                                // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 18. Claim.prescription
                    this.Prescription = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Prescription",                                                                                              // MakerGen.cs:235
                        Path= "Claim.prescription",                                                                                         // MakerGen.cs:236
                        Id = "Claim.prescription",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DeviceRequest",                                                // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/MedicationRequest",                                            // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/VisionPrescription"                                            // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 19. Claim.originalPrescription
                    this.OriginalPrescription = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "OriginalPrescription",                                                                                      // MakerGen.cs:235
                        Path= "Claim.originalPrescription",                                                                                 // MakerGen.cs:236
                        Id = "Claim.originalPrescription",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DeviceRequest",                                                // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/MedicationRequest",                                            // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/VisionPrescription"                                            // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 20. Claim.payee
                    this.Payee = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Payee",                                                                                                     // MakerGen.cs:235
                        Path= "Claim.payee",                                                                                                // MakerGen.cs:236
                        Id = "Claim.payee",                                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Payee                                                                                                  // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 23. Claim.referral
                    this.Referral = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Referral",                                                                                                  // MakerGen.cs:235
                        Path= "Claim.referral",                                                                                             // MakerGen.cs:236
                        Id = "Claim.referral",                                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 24. Claim.facility
                    this.Facility = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Facility",                                                                                                  // MakerGen.cs:235
                        Path= "Claim.facility",                                                                                             // MakerGen.cs:236
                        Id = "Claim.facility",                                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Location"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 25. Claim.careTeam
                    this.CareTeam = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "CareTeam",                                                                                                  // MakerGen.cs:235
                        Path= "Claim.careTeam",                                                                                             // MakerGen.cs:236
                        Id = "Claim.careTeam",                                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_CareTeam                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 31. Claim.supportingInfo
                    this.SupportingInfo = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SupportingInfo",                                                                                            // MakerGen.cs:235
                        Path= "Claim.supportingInfo",                                                                                       // MakerGen.cs:236
                        Id = "Claim.supportingInfo",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_SupportingInfo                                                                                         // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 38. Claim.diagnosis
                    this.Diagnosis = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Diagnosis",                                                                                                 // MakerGen.cs:235
                        Path= "Claim.diagnosis",                                                                                            // MakerGen.cs:236
                        Id = "Claim.diagnosis",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Diagnosis                                                                                              // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 44. Claim.procedure
                    this.Procedure = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Procedure",                                                                                                 // MakerGen.cs:235
                        Path= "Claim.procedure",                                                                                            // MakerGen.cs:236
                        Id = "Claim.procedure",                                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Procedure                                                                                              // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 50. Claim.insurance
                    this.Insurance = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Insurance",                                                                                                 // MakerGen.cs:235
                        Path= "Claim.insurance",                                                                                            // MakerGen.cs:236
                        Id = "Claim.insurance",                                                                                             // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Insurance                                                                                              // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 58. Claim.accident
                    this.Accident = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Accident",                                                                                                  // MakerGen.cs:235
                        Path= "Claim.accident",                                                                                             // MakerGen.cs:236
                        Id = "Claim.accident",                                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Accident                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 62. Claim.item
                    this.Item = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Item",                                                                                                      // MakerGen.cs:235
                        Path= "Claim.item",                                                                                                 // MakerGen.cs:236
                        Id = "Claim.item",                                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Item                                                                                                   // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 107. Claim.total
                    this.Total = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Total",                                                                                                     // MakerGen.cs:235
                        Path= "Claim.total",                                                                                                // MakerGen.cs:236
                        Id = "Claim.total",                                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Money                                                                         // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Type.Write(sDef);                                                                                                           // MakerGen.cs:220
                SubType.Write(sDef);                                                                                                        // MakerGen.cs:220
                Use.Write(sDef);                                                                                                            // MakerGen.cs:220
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:220
                BillablePeriod.Write(sDef);                                                                                                 // MakerGen.cs:220
                Created.Write(sDef);                                                                                                        // MakerGen.cs:220
                Enterer.Write(sDef);                                                                                                        // MakerGen.cs:220
                Insurer.Write(sDef);                                                                                                        // MakerGen.cs:220
                Provider.Write(sDef);                                                                                                       // MakerGen.cs:220
                Priority.Write(sDef);                                                                                                       // MakerGen.cs:220
                FundsReserve.Write(sDef);                                                                                                   // MakerGen.cs:220
                Related.Write(sDef);                                                                                                        // MakerGen.cs:220
                Prescription.Write(sDef);                                                                                                   // MakerGen.cs:220
                OriginalPrescription.Write(sDef);                                                                                           // MakerGen.cs:220
                Payee.Write(sDef);                                                                                                          // MakerGen.cs:220
                Referral.Write(sDef);                                                                                                       // MakerGen.cs:220
                Facility.Write(sDef);                                                                                                       // MakerGen.cs:220
                CareTeam.Write(sDef);                                                                                                       // MakerGen.cs:220
                SupportingInfo.Write(sDef);                                                                                                 // MakerGen.cs:220
                Diagnosis.Write(sDef);                                                                                                      // MakerGen.cs:220
                Procedure.Write(sDef);                                                                                                      // MakerGen.cs:220
                Insurance.Write(sDef);                                                                                                      // MakerGen.cs:220
                Accident.Write(sDef);                                                                                                       // MakerGen.cs:220
                Item.Write(sDef);                                                                                                           // MakerGen.cs:220
                Total.Write(sDef);                                                                                                          // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public Claim_Elements Elements                                                                                                      // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new Claim_Elements();                                                                                   // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        Claim_Elements elements;                                                                                                            // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public Claim()                                                                                                                      // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "Claim";                                                                                                            // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Claim";                                                                     // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "Claim",                                                                                                             // MakerGen.cs:428
                ElementId = "Claim"                                                                                                         // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
