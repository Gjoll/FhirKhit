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
      "id": "MedicationRequest",
      "url": "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
      "version": "4.0.0",
      "name": "MedicationRequest",
      "status": "draft",
      "publisher": "Health Level Seven International (Pharmacy)",
      "description": "An order or request for both supply of the medication and the instructions for administration of the medication to a patient. The resource is called \"MedicationRequest\" rather than \"MedicationPrescription\" or \"MedicationOrder\" to generalize the use across inpatient and outpatient settings, including care plans, etc., and to harmonize with workflow patterns.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MedicationRequest",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MedicationRequest",
            "path": "MedicationRequest",
            "short": "Ordering of medication for patient or group",
            "definition": "An order or request for both supply of the medication and the instructions for administration of the medication to a patient. The resource is called \"MedicationRequest\" rather than \"MedicationPrescription\" or \"MedicationOrder\" to generalize the use across inpatient and outpatient settings, including care plans, etc., and to harmonize with workflow patterns.",
            "alias": [
              "Prescription",
              "Order"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "MedicationRequest.identifier",
            "path": "MedicationRequest.identifier",
            "short": "External ids for this request",
            "definition": "Identifiers associated with this medication request that are defined by business processes and/or used to refer to it when a direct URL reference to the resource itself is not appropriate. They are business identifiers assigned to this resource by the performer or other systems and remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "MedicationRequest.status",
            "path": "MedicationRequest.status",
            "short": "active | on-hold | cancelled | completed | entered-in-error | stopped | draft | unknown",
            "definition": "A code specifying the current state of the order.  Generally, this will be active or completed state.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
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
                  "valueString": "MedicationRequestStatus"
                }
              ],
              "strength": "required",
              "description": "A coded concept specifying the state of the prescribing event. Describes the lifecycle of the prescription.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medicationrequest-status|4.0.0"
            }
          },
          {
            "id": "MedicationRequest.statusReason",
            "path": "MedicationRequest.statusReason",
            "short": "Reason for current status",
            "definition": "Captures the reason for the current state of the MedicationRequest.",
            "comment": "This is generally only used for \"exception\" statuses such as \"suspended\" or \"cancelled\". The reason why the MedicationRequest was created at all is captured in reasonCode, not here.",
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
                  "valueString": "MedicationRequestStatusReason"
                }
              ],
              "strength": "example",
              "description": "Identifies the reasons for a given status.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medicationrequest-status-reason"
            }
          },
          {
            "id": "MedicationRequest.intent",
            "path": "MedicationRequest.intent",
            "short": "proposal | plan | order | original-order | instance-order | option",
            "definition": "Whether the request is a proposal, plan, or an original order.",
            "comment": "It is expected that the type of requester will be restricted for different stages of a MedicationRequest.  For example, Proposals can be created by a patient, relatedPerson, Practitioner or Device.  Plans can be created by Practitioners, Patients, RelatedPersons and Devices.  Original orders can be created by a Practitioner only.\r\rAn instance-order is an instantiation of a request or order and may be used to populate Medication Administration Record.\r\rThis element is labeled as a modifier because the intent alters when and how the resource is actually applicable.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element changes the interpretation of all descriptive attributes. For example \"the time the request is recommended to occur\" vs. \"the time the request is authorized to occur\" or \"who is recommended to perform the request\" vs. \"who is authorized to perform the request",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MedicationRequestIntent"
                }
              ],
              "strength": "required",
              "description": "The kind of medication order.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medicationrequest-intent|4.0.0"
            }
          },
          {
            "id": "MedicationRequest.category",
            "path": "MedicationRequest.category",
            "short": "Type of medication usage",
            "definition": "Indicates the type of medication request (for example, where the medication is expected to be consumed or administered (i.e. inpatient or outpatient)).",
            "comment": "The category can be used to include where the medication is expected to be consumed or other types of requests.",
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
                  "valueString": "MedicationRequestCategory"
                }
              ],
              "strength": "example",
              "description": "A coded concept identifying the category of medication request.  For example, where the medication is to be consumed or administered, or the type of medication treatment.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medicationrequest-category"
            }
          },
          {
            "id": "MedicationRequest.priority",
            "path": "MedicationRequest.priority",
            "short": "routine | urgent | asap | stat",
            "definition": "Indicates how quickly the Medication Request should be addressed with respect to other requests.",
            "min": 0,
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
                  "valueString": "MedicationRequestPriority"
                }
              ],
              "strength": "required",
              "description": "Identifies the level of importance to be assigned to actioning the request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-priority|4.0.0"
            }
          },
          {
            "id": "MedicationRequest.doNotPerform",
            "path": "MedicationRequest.doNotPerform",
            "short": "True if request is prohibiting action",
            "definition": "If true indicates that the provider is asking for the medication request not to occur.",
            "comment": "If do not perform is not specified, the request is a positive request e.g. \"do perform\".",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because this element negates the request to occur (ie, this is a request for the medication not to be ordered or prescribed, etc)",
            "isSummary": true
          },
          {
            "id": "MedicationRequest.reported[x]",
            "path": "MedicationRequest.reported[x]",
            "short": "Reported rather than primary record",
            "definition": "Indicates if this record was captured as a secondary 'reported' record rather than as an original primary source-of-truth record.  It may also indicate the source of the report.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationRequest.medication[x]",
            "path": "MedicationRequest.medication[x]",
            "short": "Medication to be taken",
            "definition": "Identifies the medication being requested. This is a link to a resource that represents the medication which may be the details of the medication or simply an attribute carrying a code that identifies the medication from a known list of medications.",
            "comment": "If only a code is specified, then it needs to be a code for a specific product. If more information is required, then the use of the Medication resource is recommended.  For example, if you require form or lot number or if the medication is compounded or extemporaneously prepared, then you must reference the Medication resource.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Medication"
                ]
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MedicationCode"
                }
              ],
              "strength": "example",
              "description": "A coded concept identifying substance or product that can be ordered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-codes"
            }
          },
          {
            "id": "MedicationRequest.subject",
            "path": "MedicationRequest.subject",
            "short": "Who or group medication request is for",
            "definition": "A link to a resource representing the person or set of individuals to whom the medication will be given.",
            "comment": "The subject on a medication request is mandatory.  For the secondary use case where the actual subject is not provided, there still must be an anonymized subject specified.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationRequest.encounter",
            "path": "MedicationRequest.encounter",
            "short": "Encounter created as part of encounter/admission/stay",
            "definition": "The Encounter during which this [x] was created or to which the creation of this record is tightly associated.",
            "comment": "This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter.\"    If there is a need to link to episodes of care they will be handled with an extension.",
            "min": 0,
            "max": "1",
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
            "id": "MedicationRequest.supportingInformation",
            "path": "MedicationRequest.supportingInformation",
            "short": "Information to support ordering of the medication",
            "definition": "Include additional information (for example, patient height and weight) that supports the ordering of the medication.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "MedicationRequest.authoredOn",
            "path": "MedicationRequest.authoredOn",
            "short": "When request was initially authored",
            "definition": "The date (and perhaps time) when the prescription was initially written or authored on.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationRequest.requester",
            "path": "MedicationRequest.requester",
            "short": "Who/What requested the Request",
            "definition": "The individual, organization, or device that initiated the request and has responsibility for its activation.",
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
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationRequest.performer",
            "path": "MedicationRequest.performer",
            "short": "Intended performer of administration",
            "definition": "The specified desired performer of the medication treatment (e.g. the performer of the medication administration).",
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
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/CareTeam"
                ]
              }
            ]
          },
          {
            "id": "MedicationRequest.performerType",
            "path": "MedicationRequest.performerType",
            "short": "Desired kind of performer of the medication administration",
            "definition": "Indicates the type of performer of the administration of the medication.",
            "comment": "If specified without indicating a performer, this indicates that the performer must be of the specified type. If specified with a performer then it indicates the requirements of the performer if the designated performer is not available.",
            "min": 0,
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
                  "valueString": "MedicationRequestPerformerType"
                }
              ],
              "strength": "example",
              "description": "Identifies the type of individual that is desired to administer the medication.",
              "valueSet": "http://hl7.org/fhir/ValueSet/performer-role"
            }
          },
          {
            "id": "MedicationRequest.recorder",
            "path": "MedicationRequest.recorder",
            "short": "Person who entered the request",
            "definition": "The person who entered the order on behalf of another individual for example in the case of a verbal or a telephone order.",
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
            "id": "MedicationRequest.reasonCode",
            "path": "MedicationRequest.reasonCode",
            "short": "Reason or indication for ordering or not ordering the medication",
            "definition": "The reason or the indication for ordering or not ordering the medication.",
            "comment": "This could be a diagnosis code. If a full condition record exists or additional detail is needed, use reasonReference.",
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
                  "valueString": "MedicationRequestReason"
                }
              ],
              "strength": "example",
              "description": "A coded concept indicating why the medication was ordered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-code"
            }
          },
          {
            "id": "MedicationRequest.reasonReference",
            "path": "MedicationRequest.reasonReference",
            "short": "Condition or observation that supports why the prescription is being written",
            "definition": "Condition or observation that supports why the medication was ordered.",
            "comment": "This is a reference to a condition or observation that is the reason for the medication order.  If only a code exists, use reasonCode.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation"
                ]
              }
            ]
          },
          {
            "id": "MedicationRequest.instantiatesCanonical",
            "path": "MedicationRequest.instantiatesCanonical",
            "short": "Instantiates FHIR protocol or definition",
            "definition": "The URL pointing to a protocol, guideline, orderset, or other definition that is adhered to in whole or in part by this MedicationRequest.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationRequest.instantiatesUri",
            "path": "MedicationRequest.instantiatesUri",
            "short": "Instantiates external protocol or definition",
            "definition": "The URL pointing to an externally maintained protocol, guideline, orderset or other definition that is adhered to in whole or in part by this MedicationRequest.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationRequest.basedOn",
            "path": "MedicationRequest.basedOn",
            "short": "What request fulfills",
            "definition": "A plan or request that is fulfilled in whole or in part by this medication request.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CarePlan",
                  "http://hl7.org/fhir/StructureDefinition/MedicationRequest",
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest",
                  "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationRequest.groupIdentifier",
            "path": "MedicationRequest.groupIdentifier",
            "short": "Composite request this is part of",
            "definition": "A shared identifier common to all requests that were authorized more or less simultaneously by a single author, representing the identifier of the requisition or prescription.",
            "requirements": "Requests are linked either by a \"basedOn\" relationship (i.e. one request is fulfilling another) or by having a common requisition. Requests that are part of the same requisition are generally treated independently from the perspective of changing their state or maintaining them after initial creation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MedicationRequest.courseOfTherapyType",
            "path": "MedicationRequest.courseOfTherapyType",
            "short": "Overall pattern of medication administration",
            "definition": "The description of the overall patte3rn of the administration of the medication to the patient.",
            "comment": "This attribute should not be confused with the protocol of the medication.",
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
                  "valueString": "MedicationRequestCourseOfTherapy"
                }
              ],
              "strength": "example",
              "description": "Identifies the overall pattern of medication administratio.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medicationrequest-course-of-therapy"
            }
          },
          {
            "id": "MedicationRequest.insurance",
            "path": "MedicationRequest.insurance",
            "short": "Associated insurance coverage",
            "definition": "Insurance plans, coverage extensions, pre-authorizations and/or pre-determinations that may be required for delivering the requested service.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Coverage",
                  "http://hl7.org/fhir/StructureDefinition/ClaimResponse"
                ]
              }
            ]
          },
          {
            "id": "MedicationRequest.note",
            "path": "MedicationRequest.note",
            "short": "Information about the prescription",
            "definition": "Extra information about the prescription that could not be conveyed by the other attributes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "MedicationRequest.dosageInstruction",
            "path": "MedicationRequest.dosageInstruction",
            "short": "How the medication should be taken",
            "definition": "Indicates how the medication is to be used by the patient.",
            "comment": "There are examples where a medication request may include the option of an oral dose or an Intravenous or Intramuscular dose.  For example, \"Ondansetron 8mg orally or IV twice a day as needed for nausea\" or \"Compazine® (prochlorperazine) 5-10mg PO or 25mg PR bid prn nausea or vomiting\".  In these cases, two medication requests would be created that could be grouped together.  The decision on which dose and route of administration to use is based on the patient's condition at the time the dose is needed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Dosage"
              }
            ]
          },
          {
            "id": "MedicationRequest.dispenseRequest",
            "path": "MedicationRequest.dispenseRequest",
            "short": "Medication supply authorization",
            "definition": "Indicates the specific details for the dispense or medication supply part of a medication request (also known as a Medication Prescription or Medication Order).  Note that this information is not always sent with the order.  There may be in some settings (e.g. hospitals) institutional or system support for completing the dispense details in the pharmacy department.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationRequest.dispenseRequest.initialFill",
            "path": "MedicationRequest.dispenseRequest.initialFill",
            "short": "First fill details",
            "definition": "Indicates the quantity or duration for the first dispense of the medication.",
            "comment": "If populating this element, either the quantity or the duration must be included.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationRequest.dispenseRequest.initialFill.quantity",
            "path": "MedicationRequest.dispenseRequest.initialFill.quantity",
            "short": "First fill quantity",
            "definition": "The amount or quantity to provide as part of the first dispense.",
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
            "id": "MedicationRequest.dispenseRequest.initialFill.duration",
            "path": "MedicationRequest.dispenseRequest.initialFill.duration",
            "short": "First fill duration",
            "definition": "The length of time that the first dispense is expected to last.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ]
          },
          {
            "id": "MedicationRequest.dispenseRequest.dispenseInterval",
            "path": "MedicationRequest.dispenseRequest.dispenseInterval",
            "short": "Minimum period of time between dispenses",
            "definition": "The minimum period of time that must occur between dispenses of the medication.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ]
          },
          {
            "id": "MedicationRequest.dispenseRequest.validityPeriod",
            "path": "MedicationRequest.dispenseRequest.validityPeriod",
            "short": "Time period supply is authorized for",
            "definition": "This indicates the validity period of a prescription (stale dating the Prescription).",
            "comment": "It reflects the prescribers' perspective for the validity of the prescription. Dispenses must not be made against the prescription outside of this period. The lower-bound of the Dispensing Window signifies the earliest date that the prescription can be filled for the first time. If an upper-bound is not specified then the Prescription is open-ended or will default to a stale-date based on regulations.",
            "requirements": "Indicates when the Prescription becomes valid, and when it ceases to be a dispensable Prescription.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "MedicationRequest.dispenseRequest.numberOfRepeatsAllowed",
            "path": "MedicationRequest.dispenseRequest.numberOfRepeatsAllowed",
            "short": "Number of refills authorized",
            "definition": "An integer indicating the number of times, in addition to the original dispense, (aka refills or repeats) that the patient can receive the prescribed medication. Usage Notes: This integer does not include the original order dispense. This means that if an order indicates dispense 30 tablets plus \"3 repeats\", then the order can be dispensed a total of 4 times and the patient can receive a total of 120 tablets.  A prescriber may explicitly say that zero refills are permitted after the initial dispense.",
            "comment": "If displaying \"number of authorized fills\", add 1 to this number.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ]
          },
          {
            "id": "MedicationRequest.dispenseRequest.quantity",
            "path": "MedicationRequest.dispenseRequest.quantity",
            "short": "Amount of medication to supply per dispense",
            "definition": "The amount that is to be dispensed for one fill.",
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
            "id": "MedicationRequest.dispenseRequest.expectedSupplyDuration",
            "path": "MedicationRequest.dispenseRequest.expectedSupplyDuration",
            "short": "Number of days supply per dispense",
            "definition": "Identifies the period time over which the supplied product is expected to be used, or the length of time the dispense is expected to last.",
            "comment": "In some situations, this attribute may be used instead of quantity to identify the amount supplied by how long it is expected to last, rather than the physical quantity issued, e.g. 90 days supply of medication (based on an ordered dosage). When possible, it is always better to specify quantity, as this tends to be more precise. expectedSupplyDuration will always be an estimate that can be influenced by external factors.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ]
          },
          {
            "id": "MedicationRequest.dispenseRequest.performer",
            "path": "MedicationRequest.dispenseRequest.performer",
            "short": "Intended dispenser",
            "definition": "Indicates the intended dispensing Organization specified by the prescriber.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "MedicationRequest.substitution",
            "path": "MedicationRequest.substitution",
            "short": "Any restrictions on medication substitution",
            "definition": "Indicates whether or not substitution can or should be part of the dispense. In some cases, substitution must happen, in other cases substitution must not happen. This block explains the prescriber's intent. If nothing is specified substitution may be done.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MedicationRequest.substitution.allowed[x]",
            "path": "MedicationRequest.substitution.allowed[x]",
            "short": "Whether substitution is allowed or not",
            "definition": "True if the prescriber allows a different drug to be dispensed from what was prescribed.",
            "comment": "This element is labeled as a modifier because whether substitution is allow or not, it cannot be ignored.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              },
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MedicationRequestSubstitution"
                }
              ],
              "strength": "example",
              "description": "Identifies the type of substitution allowed.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ActSubstanceAdminSubstitutionCode"
            }
          },
          {
            "id": "MedicationRequest.substitution.reason",
            "path": "MedicationRequest.substitution.reason",
            "short": "Why should (not) substitution be made",
            "definition": "Indicates the reason for the substitution, or why substitution must or must not be performed.",
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
                  "valueString": "MedicationIntendedSubstitutionReason"
                }
              ],
              "strength": "example",
              "description": "A coded concept describing the reason that a different medication should (or should not) be substituted from what was prescribed.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-SubstanceAdminSubstitutionReason"
            }
          },
          {
            "id": "MedicationRequest.priorPrescription",
            "path": "MedicationRequest.priorPrescription",
            "short": "An order/prescription that is being replaced",
            "definition": "A link to a resource representing an earlier order related order or prescription.",
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
            "id": "MedicationRequest.detectedIssue",
            "path": "MedicationRequest.detectedIssue",
            "short": "Clinical Issue with action",
            "definition": "Indicates an actual or potential clinical issue with or between one or more active or proposed clinical actions for a patient; e.g. Drug-drug interaction, duplicate therapy, dosage alert etc.",
            "comment": "This element can include a detected issue that has been identified either by a decision support system or by a clinician and may include information on the steps that were taken to address the issue.",
            "alias": [
              "Contraindication",
              "Drug Utilization Review (DUR)",
              "Alert"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DetectedIssue"
                ]
              }
            ]
          },
          {
            "id": "MedicationRequest.eventHistory",
            "path": "MedicationRequest.eventHistory",
            "short": "A list of events of interest in the lifecycle",
            "definition": "Links to Provenance records for past versions of this resource or fulfilling request or event resources that identify key state transitions or updates that are likely to be relevant to a user looking at the current version of the resource.",
            "comment": "This might not include provenances for all versions of the request – only those deemed “relevant” or important. This SHALL NOT include the provenance associated with this current version of the resource. (If that provenance is deemed to be a “relevant” change, it will need to be added as part of a later update. Until then, it can be queried directly as the provenance that points to this version using _revinclude All Provenances should have some historical version of this Request as their subject.).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Provenance"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'MedicationRequest'
    /// </summary>
    // 0. MedicationRequest
    public class MedicationRequest : FhirKhit.Maker.Common.Resource.ResourceBase                                                            // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class MedicationRequest_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 28. MedicationRequest.dispenseRequest
            public class Type_DispenseRequest : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_DispenseRequest_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 29. MedicationRequest.dispenseRequest.initialFill
                    public class Type_InitialFill : FhirKhit.Maker.Common.Complex.ComplexBase                                               // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_InitialFill_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 30. MedicationRequest.dispenseRequest.initialFill.quantity
                            public ElementDefinitionInfo Quantity;                                                                          // MakerGen.cs:216
                            // 31. MedicationRequest.dispenseRequest.initialFill.duration
                            public ElementDefinitionInfo Duration;                                                                          // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_InitialFill_Elements()                                                                              // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 30. MedicationRequest.dispenseRequest.initialFill.quantity
                                    this.Quantity = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Quantity",                                                                                  // MakerGen.cs:235
                                        Path= "MedicationRequest.dispenseRequest.initialFill.quantity",                                     // MakerGen.cs:236
                                        Id = "MedicationRequest.dispenseRequest.initialFill.quantity",                                      // MakerGen.cs:237
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
                                    // 31. MedicationRequest.dispenseRequest.initialFill.duration
                                    this.Duration = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Duration",                                                                                  // MakerGen.cs:235
                                        Path= "MedicationRequest.dispenseRequest.initialFill.duration",                                     // MakerGen.cs:236
                                        Id = "MedicationRequest.dispenseRequest.initialFill.duration",                                      // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Duration                                                      // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Quantity.Write(sDef);                                                                                       // MakerGen.cs:220
                                Duration.Write(sDef);                                                                                       // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_InitialFill_Elements Elements                                                                           // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_InitialFill_Elements();                                                        // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_InitialFill_Elements elements;                                                                                 // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_InitialFill()                                                                                           // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "MedicationRequest.dispenseRequest.initialFill",                                                     // MakerGen.cs:428
                                ElementId = "MedicationRequest.dispenseRequest.initialFill"                                                 // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 29. MedicationRequest.dispenseRequest.initialFill
                    public ElementDefinitionInfo InitialFill;                                                                               // MakerGen.cs:216
                    // 32. MedicationRequest.dispenseRequest.dispenseInterval
                    public ElementDefinitionInfo DispenseInterval;                                                                          // MakerGen.cs:216
                    // 33. MedicationRequest.dispenseRequest.validityPeriod
                    public ElementDefinitionInfo ValidityPeriod;                                                                            // MakerGen.cs:216
                    // 34. MedicationRequest.dispenseRequest.numberOfRepeatsAllowed
                    public ElementDefinitionInfo NumberOfRepeatsAllowed;                                                                    // MakerGen.cs:216
                    // 35. MedicationRequest.dispenseRequest.quantity
                    public ElementDefinitionInfo Quantity;                                                                                  // MakerGen.cs:216
                    // 36. MedicationRequest.dispenseRequest.expectedSupplyDuration
                    public ElementDefinitionInfo ExpectedSupplyDuration;                                                                    // MakerGen.cs:216
                    // 37. MedicationRequest.dispenseRequest.performer
                    public ElementDefinitionInfo Performer;                                                                                 // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_DispenseRequest_Elements()                                                                                  // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 29. MedicationRequest.dispenseRequest.initialFill
                            this.InitialFill = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "InitialFill",                                                                                       // MakerGen.cs:235
                                Path= "MedicationRequest.dispenseRequest.initialFill",                                                      // MakerGen.cs:236
                                Id = "MedicationRequest.dispenseRequest.initialFill",                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_InitialFill                                                                                    // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 32. MedicationRequest.dispenseRequest.dispenseInterval
                            this.DispenseInterval = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "DispenseInterval",                                                                                  // MakerGen.cs:235
                                Path= "MedicationRequest.dispenseRequest.dispenseInterval",                                                 // MakerGen.cs:236
                                Id = "MedicationRequest.dispenseRequest.dispenseInterval",                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Duration                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 33. MedicationRequest.dispenseRequest.validityPeriod
                            this.ValidityPeriod = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ValidityPeriod",                                                                                    // MakerGen.cs:235
                                Path= "MedicationRequest.dispenseRequest.validityPeriod",                                                   // MakerGen.cs:236
                                Id = "MedicationRequest.dispenseRequest.validityPeriod",                                                    // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 34. MedicationRequest.dispenseRequest.numberOfRepeatsAllowed
                            this.NumberOfRepeatsAllowed = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "NumberOfRepeatsAllowed",                                                                            // MakerGen.cs:235
                                Path= "MedicationRequest.dispenseRequest.numberOfRepeatsAllowed",                                           // MakerGen.cs:236
                                Id = "MedicationRequest.dispenseRequest.numberOfRepeatsAllowed",                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                         // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 35. MedicationRequest.dispenseRequest.quantity
                            this.Quantity = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Quantity",                                                                                          // MakerGen.cs:235
                                Path= "MedicationRequest.dispenseRequest.quantity",                                                         // MakerGen.cs:236
                                Id = "MedicationRequest.dispenseRequest.quantity",                                                          // MakerGen.cs:237
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
                            // 36. MedicationRequest.dispenseRequest.expectedSupplyDuration
                            this.ExpectedSupplyDuration = new ElementDefinitionInfo                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ExpectedSupplyDuration",                                                                            // MakerGen.cs:235
                                Path= "MedicationRequest.dispenseRequest.expectedSupplyDuration",                                           // MakerGen.cs:236
                                Id = "MedicationRequest.dispenseRequest.expectedSupplyDuration",                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Duration                                                              // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 37. MedicationRequest.dispenseRequest.performer
                            this.Performer = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Performer",                                                                                         // MakerGen.cs:235
                                Path= "MedicationRequest.dispenseRequest.performer",                                                        // MakerGen.cs:236
                                Id = "MedicationRequest.dispenseRequest.performer",                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:349
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
                        InitialFill.Write(sDef);                                                                                            // MakerGen.cs:220
                        DispenseInterval.Write(sDef);                                                                                       // MakerGen.cs:220
                        ValidityPeriod.Write(sDef);                                                                                         // MakerGen.cs:220
                        NumberOfRepeatsAllowed.Write(sDef);                                                                                 // MakerGen.cs:220
                        Quantity.Write(sDef);                                                                                               // MakerGen.cs:220
                        ExpectedSupplyDuration.Write(sDef);                                                                                 // MakerGen.cs:220
                        Performer.Write(sDef);                                                                                              // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_DispenseRequest_Elements Elements                                                                               // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_DispenseRequest_Elements();                                                            // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_DispenseRequest_Elements elements;                                                                                     // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_DispenseRequest()                                                                                               // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "MedicationRequest.dispenseRequest",                                                                         // MakerGen.cs:428
                        ElementId = "MedicationRequest.dispenseRequest"                                                                     // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 38. MedicationRequest.substitution
            public class Type_Substitution : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Substitution_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 39. MedicationRequest.substitution.allowed[x]
                    public ElementDefinitionInfo Allowed;                                                                                   // MakerGen.cs:216
                    // 40. MedicationRequest.substitution.reason
                    public ElementDefinitionInfo Reason;                                                                                    // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Substitution_Elements()                                                                                     // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 39. MedicationRequest.substitution.allowed[x]
                            this.Allowed = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Allowed",                                                                                           // MakerGen.cs:235
                                Path= "MedicationRequest.substitution.allowed[x]",                                                          // MakerGen.cs:236
                                Id = "MedicationRequest.substitution.allowed[x]",                                                           // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    },                                                                                                      // MakerGen.cs:304
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 40. MedicationRequest.substitution.reason
                            this.Reason = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Reason",                                                                                            // MakerGen.cs:235
                                Path= "MedicationRequest.substitution.reason",                                                              // MakerGen.cs:236
                                Id = "MedicationRequest.substitution.reason",                                                               // MakerGen.cs:237
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
                        Allowed.Write(sDef);                                                                                                // MakerGen.cs:220
                        Reason.Write(sDef);                                                                                                 // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Substitution_Elements Elements                                                                                  // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Substitution_Elements();                                                               // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Substitution_Elements elements;                                                                                        // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Substitution()                                                                                                  // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "MedicationRequest.substitution",                                                                            // MakerGen.cs:428
                        ElementId = "MedicationRequest.substitution"                                                                        // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. MedicationRequest.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. MedicationRequest.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 3. MedicationRequest.statusReason
            public ElementDefinitionInfo StatusReason;                                                                                      // MakerGen.cs:216
            // 4. MedicationRequest.intent
            public ElementDefinitionInfo Intent;                                                                                            // MakerGen.cs:216
            // 5. MedicationRequest.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:216
            // 6. MedicationRequest.priority
            public ElementDefinitionInfo Priority;                                                                                          // MakerGen.cs:216
            // 7. MedicationRequest.doNotPerform
            public ElementDefinitionInfo DoNotPerform;                                                                                      // MakerGen.cs:216
            // 8. MedicationRequest.reported[x]
            public ElementDefinitionInfo Reported;                                                                                          // MakerGen.cs:216
            // 9. MedicationRequest.medication[x]
            public ElementDefinitionInfo Medication;                                                                                        // MakerGen.cs:216
            // 10. MedicationRequest.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 11. MedicationRequest.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:216
            // 12. MedicationRequest.supportingInformation
            public ElementDefinitionInfo SupportingInformation;                                                                             // MakerGen.cs:216
            // 13. MedicationRequest.authoredOn
            public ElementDefinitionInfo AuthoredOn;                                                                                        // MakerGen.cs:216
            // 14. MedicationRequest.requester
            public ElementDefinitionInfo Requester;                                                                                         // MakerGen.cs:216
            // 15. MedicationRequest.performer
            public ElementDefinitionInfo Performer;                                                                                         // MakerGen.cs:216
            // 16. MedicationRequest.performerType
            public ElementDefinitionInfo PerformerType;                                                                                     // MakerGen.cs:216
            // 17. MedicationRequest.recorder
            public ElementDefinitionInfo Recorder;                                                                                          // MakerGen.cs:216
            // 18. MedicationRequest.reasonCode
            public ElementDefinitionInfo ReasonCode;                                                                                        // MakerGen.cs:216
            // 19. MedicationRequest.reasonReference
            public ElementDefinitionInfo ReasonReference;                                                                                   // MakerGen.cs:216
            // 20. MedicationRequest.instantiatesCanonical
            public ElementDefinitionInfo InstantiatesCanonical;                                                                             // MakerGen.cs:216
            // 21. MedicationRequest.instantiatesUri
            public ElementDefinitionInfo InstantiatesUri;                                                                                   // MakerGen.cs:216
            // 22. MedicationRequest.basedOn
            public ElementDefinitionInfo BasedOn;                                                                                           // MakerGen.cs:216
            // 23. MedicationRequest.groupIdentifier
            public ElementDefinitionInfo GroupIdentifier;                                                                                   // MakerGen.cs:216
            // 24. MedicationRequest.courseOfTherapyType
            public ElementDefinitionInfo CourseOfTherapyType;                                                                               // MakerGen.cs:216
            // 25. MedicationRequest.insurance
            public ElementDefinitionInfo Insurance;                                                                                         // MakerGen.cs:216
            // 26. MedicationRequest.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:216
            // 27. MedicationRequest.dosageInstruction
            public ElementDefinitionInfo DosageInstruction;                                                                                 // MakerGen.cs:216
            // 28. MedicationRequest.dispenseRequest
            public ElementDefinitionInfo DispenseRequest;                                                                                   // MakerGen.cs:216
            // 38. MedicationRequest.substitution
            public ElementDefinitionInfo Substitution;                                                                                      // MakerGen.cs:216
            // 41. MedicationRequest.priorPrescription
            public ElementDefinitionInfo PriorPrescription;                                                                                 // MakerGen.cs:216
            // 42. MedicationRequest.detectedIssue
            public ElementDefinitionInfo DetectedIssue;                                                                                     // MakerGen.cs:216
            // 43. MedicationRequest.eventHistory
            public ElementDefinitionInfo EventHistory;                                                                                      // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public MedicationRequest_Elements()                                                                                             // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. MedicationRequest.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "MedicationRequest.identifier",                                                                               // MakerGen.cs:236
                        Id = "MedicationRequest.identifier",                                                                                // MakerGen.cs:237
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
                    // 2. MedicationRequest.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "MedicationRequest.status",                                                                                   // MakerGen.cs:236
                        Id = "MedicationRequest.status",                                                                                    // MakerGen.cs:237
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
                    // 3. MedicationRequest.statusReason
                    this.StatusReason = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "StatusReason",                                                                                              // MakerGen.cs:235
                        Path= "MedicationRequest.statusReason",                                                                             // MakerGen.cs:236
                        Id = "MedicationRequest.statusReason",                                                                              // MakerGen.cs:237
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
                    // 4. MedicationRequest.intent
                    this.Intent = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Intent",                                                                                                    // MakerGen.cs:235
                        Path= "MedicationRequest.intent",                                                                                   // MakerGen.cs:236
                        Id = "MedicationRequest.intent",                                                                                    // MakerGen.cs:237
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
                    // 5. MedicationRequest.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Category",                                                                                                  // MakerGen.cs:235
                        Path= "MedicationRequest.category",                                                                                 // MakerGen.cs:236
                        Id = "MedicationRequest.category",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. MedicationRequest.priority
                    this.Priority = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Priority",                                                                                                  // MakerGen.cs:235
                        Path= "MedicationRequest.priority",                                                                                 // MakerGen.cs:236
                        Id = "MedicationRequest.priority",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 7. MedicationRequest.doNotPerform
                    this.DoNotPerform = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DoNotPerform",                                                                                              // MakerGen.cs:235
                        Path= "MedicationRequest.doNotPerform",                                                                             // MakerGen.cs:236
                        Id = "MedicationRequest.doNotPerform",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. MedicationRequest.reported[x]
                    this.Reported = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Reported",                                                                                                  // MakerGen.cs:235
                        Path= "MedicationRequest.reported[x]",                                                                              // MakerGen.cs:236
                        Id = "MedicationRequest.reported[x]",                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. MedicationRequest.medication[x]
                    this.Medication = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Medication",                                                                                                // MakerGen.cs:235
                        Path= "MedicationRequest.medication[x]",                                                                            // MakerGen.cs:236
                        Id = "MedicationRequest.medication[x]",                                                                             // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            },                                                                                                              // MakerGen.cs:319
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Medication"                                                    // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. MedicationRequest.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "MedicationRequest.subject",                                                                                  // MakerGen.cs:236
                        Id = "MedicationRequest.subject",                                                                                   // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. MedicationRequest.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Encounter",                                                                                                 // MakerGen.cs:235
                        Path= "MedicationRequest.encounter",                                                                                // MakerGen.cs:236
                        Id = "MedicationRequest.encounter",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. MedicationRequest.supportingInformation
                    this.SupportingInformation = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SupportingInformation",                                                                                     // MakerGen.cs:235
                        Path= "MedicationRequest.supportingInformation",                                                                    // MakerGen.cs:236
                        Id = "MedicationRequest.supportingInformation",                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. MedicationRequest.authoredOn
                    this.AuthoredOn = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "AuthoredOn",                                                                                                // MakerGen.cs:235
                        Path= "MedicationRequest.authoredOn",                                                                               // MakerGen.cs:236
                        Id = "MedicationRequest.authoredOn",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 14. MedicationRequest.requester
                    this.Requester = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Requester",                                                                                                 // MakerGen.cs:235
                        Path= "MedicationRequest.requester",                                                                                // MakerGen.cs:236
                        Id = "MedicationRequest.requester",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 15. MedicationRequest.performer
                    this.Performer = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Performer",                                                                                                 // MakerGen.cs:235
                        Path= "MedicationRequest.performer",                                                                                // MakerGen.cs:236
                        Id = "MedicationRequest.performer",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Organization",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/CareTeam"                                                      // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 16. MedicationRequest.performerType
                    this.PerformerType = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PerformerType",                                                                                             // MakerGen.cs:235
                        Path= "MedicationRequest.performerType",                                                                            // MakerGen.cs:236
                        Id = "MedicationRequest.performerType",                                                                             // MakerGen.cs:237
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
                    // 17. MedicationRequest.recorder
                    this.Recorder = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Recorder",                                                                                                  // MakerGen.cs:235
                        Path= "MedicationRequest.recorder",                                                                                 // MakerGen.cs:236
                        Id = "MedicationRequest.recorder",                                                                                  // MakerGen.cs:237
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
                    // 18. MedicationRequest.reasonCode
                    this.ReasonCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReasonCode",                                                                                                // MakerGen.cs:235
                        Path= "MedicationRequest.reasonCode",                                                                               // MakerGen.cs:236
                        Id = "MedicationRequest.reasonCode",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 19. MedicationRequest.reasonReference
                    this.ReasonReference = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReasonReference",                                                                                           // MakerGen.cs:235
                        Path= "MedicationRequest.reasonReference",                                                                          // MakerGen.cs:236
                        Id = "MedicationRequest.reasonReference",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Observation"                                                   // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 20. MedicationRequest.instantiatesCanonical
                    this.InstantiatesCanonical = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "InstantiatesCanonical",                                                                                     // MakerGen.cs:235
                        Path= "MedicationRequest.instantiatesCanonical",                                                                    // MakerGen.cs:236
                        Id = "MedicationRequest.instantiatesCanonical",                                                                     // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 21. MedicationRequest.instantiatesUri
                    this.InstantiatesUri = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "InstantiatesUri",                                                                                           // MakerGen.cs:235
                        Path= "MedicationRequest.instantiatesUri",                                                                          // MakerGen.cs:236
                        Id = "MedicationRequest.instantiatesUri",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 22. MedicationRequest.basedOn
                    this.BasedOn = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "BasedOn",                                                                                                   // MakerGen.cs:235
                        Path= "MedicationRequest.basedOn",                                                                                  // MakerGen.cs:236
                        Id = "MedicationRequest.basedOn",                                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CarePlan",                                                     // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/MedicationRequest",                                            // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest",                                               // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation"                                    // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 23. MedicationRequest.groupIdentifier
                    this.GroupIdentifier = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "GroupIdentifier",                                                                                           // MakerGen.cs:235
                        Path= "MedicationRequest.groupIdentifier",                                                                          // MakerGen.cs:236
                        Id = "MedicationRequest.groupIdentifier",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 24. MedicationRequest.courseOfTherapyType
                    this.CourseOfTherapyType = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "CourseOfTherapyType",                                                                                       // MakerGen.cs:235
                        Path= "MedicationRequest.courseOfTherapyType",                                                                      // MakerGen.cs:236
                        Id = "MedicationRequest.courseOfTherapyType",                                                                       // MakerGen.cs:237
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
                    // 25. MedicationRequest.insurance
                    this.Insurance = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Insurance",                                                                                                 // MakerGen.cs:235
                        Path= "MedicationRequest.insurance",                                                                                // MakerGen.cs:236
                        Id = "MedicationRequest.insurance",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Coverage",                                                     // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/ClaimResponse"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 26. MedicationRequest.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Note",                                                                                                      // MakerGen.cs:235
                        Path= "MedicationRequest.note",                                                                                     // MakerGen.cs:236
                        Id = "MedicationRequest.note",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 27. MedicationRequest.dosageInstruction
                    this.DosageInstruction = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DosageInstruction",                                                                                         // MakerGen.cs:235
                        Path= "MedicationRequest.dosageInstruction",                                                                        // MakerGen.cs:236
                        Id = "MedicationRequest.dosageInstruction",                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Dosage                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 28. MedicationRequest.dispenseRequest
                    this.DispenseRequest = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DispenseRequest",                                                                                           // MakerGen.cs:235
                        Path= "MedicationRequest.dispenseRequest",                                                                          // MakerGen.cs:236
                        Id = "MedicationRequest.dispenseRequest",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_DispenseRequest                                                                                        // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 38. MedicationRequest.substitution
                    this.Substitution = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Substitution",                                                                                              // MakerGen.cs:235
                        Path= "MedicationRequest.substitution",                                                                             // MakerGen.cs:236
                        Id = "MedicationRequest.substitution",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Substitution                                                                                           // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 41. MedicationRequest.priorPrescription
                    this.PriorPrescription = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "PriorPrescription",                                                                                         // MakerGen.cs:235
                        Path= "MedicationRequest.priorPrescription",                                                                        // MakerGen.cs:236
                        Id = "MedicationRequest.priorPrescription",                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/MedicationRequest"                                             // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 42. MedicationRequest.detectedIssue
                    this.DetectedIssue = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "DetectedIssue",                                                                                             // MakerGen.cs:235
                        Path= "MedicationRequest.detectedIssue",                                                                            // MakerGen.cs:236
                        Id = "MedicationRequest.detectedIssue",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DetectedIssue"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 43. MedicationRequest.eventHistory
                    this.EventHistory = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "EventHistory",                                                                                              // MakerGen.cs:235
                        Path= "MedicationRequest.eventHistory",                                                                             // MakerGen.cs:236
                        Id = "MedicationRequest.eventHistory",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Provenance"                                                    // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
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
                StatusReason.Write(sDef);                                                                                                   // MakerGen.cs:220
                Intent.Write(sDef);                                                                                                         // MakerGen.cs:220
                Category.Write(sDef);                                                                                                       // MakerGen.cs:220
                Priority.Write(sDef);                                                                                                       // MakerGen.cs:220
                DoNotPerform.Write(sDef);                                                                                                   // MakerGen.cs:220
                Reported.Write(sDef);                                                                                                       // MakerGen.cs:220
                Medication.Write(sDef);                                                                                                     // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:220
                SupportingInformation.Write(sDef);                                                                                          // MakerGen.cs:220
                AuthoredOn.Write(sDef);                                                                                                     // MakerGen.cs:220
                Requester.Write(sDef);                                                                                                      // MakerGen.cs:220
                Performer.Write(sDef);                                                                                                      // MakerGen.cs:220
                PerformerType.Write(sDef);                                                                                                  // MakerGen.cs:220
                Recorder.Write(sDef);                                                                                                       // MakerGen.cs:220
                ReasonCode.Write(sDef);                                                                                                     // MakerGen.cs:220
                ReasonReference.Write(sDef);                                                                                                // MakerGen.cs:220
                InstantiatesCanonical.Write(sDef);                                                                                          // MakerGen.cs:220
                InstantiatesUri.Write(sDef);                                                                                                // MakerGen.cs:220
                BasedOn.Write(sDef);                                                                                                        // MakerGen.cs:220
                GroupIdentifier.Write(sDef);                                                                                                // MakerGen.cs:220
                CourseOfTherapyType.Write(sDef);                                                                                            // MakerGen.cs:220
                Insurance.Write(sDef);                                                                                                      // MakerGen.cs:220
                Note.Write(sDef);                                                                                                           // MakerGen.cs:220
                DosageInstruction.Write(sDef);                                                                                              // MakerGen.cs:220
                DispenseRequest.Write(sDef);                                                                                                // MakerGen.cs:220
                Substitution.Write(sDef);                                                                                                   // MakerGen.cs:220
                PriorPrescription.Write(sDef);                                                                                              // MakerGen.cs:220
                DetectedIssue.Write(sDef);                                                                                                  // MakerGen.cs:220
                EventHistory.Write(sDef);                                                                                                   // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public MedicationRequest_Elements Elements                                                                                          // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new MedicationRequest_Elements();                                                                       // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        MedicationRequest_Elements elements;                                                                                                // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public MedicationRequest()                                                                                                          // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "MedicationRequest";                                                                                                // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MedicationRequest";                                                         // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "MedicationRequest",                                                                                                 // MakerGen.cs:428
                ElementId = "MedicationRequest"                                                                                             // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
