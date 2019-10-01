using System;                                                                                                                               // MakerGen.cs:423
using System.Diagnostics;                                                                                                                   // MakerGen.cs:424
using System.IO;                                                                                                                            // MakerGen.cs:425
using System.Linq;                                                                                                                          // MakerGen.cs:426
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:427
                                                                                                                                            // MakerGen.cs:428
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:429
{                                                                                                                                           // MakerGen.cs:430
    #region Json                                                                                                                            // MakerGen.cs:431
    #if NEVER                                                                                                                               // MakerGen.cs:432
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
    #endregion                                                                                                                              // MakerGen.cs:435
    /// <summary>
    /// Fhir resource 'MedicationRequest'
    /// </summary>
    // 0. MedicationRequest
    public class MedicationRequest : FhirKhit.Maker.Common.Resource.ResourceBase                                                            // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        // 28. MedicationRequest.dispenseRequest
        public class Type_DispenseRequest : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:384
        {                                                                                                                                   // MakerGen.cs:385
            // 29. MedicationRequest.dispenseRequest.initialFill
            public class Type_InitialFill : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                // 30. MedicationRequest.dispenseRequest.initialFill.quantity
                public MakerElementInstance Element_Quantity;                                                                               // MakerGen.cs:232
                // 31. MedicationRequest.dispenseRequest.initialFill.duration
                public MakerElementInstance Element_Duration;                                                                               // MakerGen.cs:232
                public Type_InitialFill()                                                                                                   // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    {                                                                                                                       // MakerGen.cs:243
                        // 30. MedicationRequest.dispenseRequest.initialFill.quantity
                        this.Element_Quantity = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Quantity",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Quantity                                                                  // MakerGen.cs:343
                                {                                                                                                           // MakerGen.cs:344
                                }                                                                                                           // MakerGen.cs:345
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                    {                                                                                                                       // MakerGen.cs:243
                        // 31. MedicationRequest.dispenseRequest.initialFill.duration
                        this.Element_Duration = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Duration",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Duration                                                                  // MakerGen.cs:343
                                {                                                                                                           // MakerGen.cs:344
                                }                                                                                                           // MakerGen.cs:345
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:389
            // 32. MedicationRequest.dispenseRequest.dispenseInterval
            public MakerElementInstance Element_DispenseInterval;                                                                           // MakerGen.cs:232
            // 33. MedicationRequest.dispenseRequest.validityPeriod
            public MakerElementInstance Element_ValidityPeriod;                                                                             // MakerGen.cs:232
            // 34. MedicationRequest.dispenseRequest.numberOfRepeatsAllowed
            public MakerElementInstance Element_NumberOfRepeatsAllowed;                                                                     // MakerGen.cs:232
            // 35. MedicationRequest.dispenseRequest.quantity
            public MakerElementInstance Element_Quantity;                                                                                   // MakerGen.cs:232
            // 36. MedicationRequest.dispenseRequest.expectedSupplyDuration
            public MakerElementInstance Element_ExpectedSupplyDuration;                                                                     // MakerGen.cs:232
            // 37. MedicationRequest.dispenseRequest.performer
            public MakerElementInstance Element_Performer;                                                                                  // MakerGen.cs:232
            public Type_DispenseRequest()                                                                                                   // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:243
                    // 32. MedicationRequest.dispenseRequest.dispenseInterval
                    this.Element_DispenseInterval = new MakerElementInstance                                                                // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DispenseInterval",                                                                                  // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Duration                                                                      // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 33. MedicationRequest.dispenseRequest.validityPeriod
                    this.Element_ValidityPeriod = new MakerElementInstance                                                                  // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ValidityPeriod",                                                                                    // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 34. MedicationRequest.dispenseRequest.numberOfRepeatsAllowed
                    this.Element_NumberOfRepeatsAllowed = new MakerElementInstance                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_NumberOfRepeatsAllowed",                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                                 // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 35. MedicationRequest.dispenseRequest.quantity
                    this.Element_Quantity = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Quantity",                                                                                          // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Quantity                                                                      // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 36. MedicationRequest.dispenseRequest.expectedSupplyDuration
                    this.Element_ExpectedSupplyDuration = new MakerElementInstance                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ExpectedSupplyDuration",                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Duration                                                                      // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 37. MedicationRequest.dispenseRequest.performer
                    this.Element_Performer = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Performer",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:389
        // 38. MedicationRequest.substitution
        public class Type_Substitution : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:384
        {                                                                                                                                   // MakerGen.cs:385
            // 39. MedicationRequest.substitution.allowed[x]
            public MakerElementInstance Element_Allowed;                                                                                    // MakerGen.cs:232
            // 40. MedicationRequest.substitution.reason
            public MakerElementInstance Element_Reason;                                                                                     // MakerGen.cs:232
            public Type_Substitution()                                                                                                      // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:243
                    // 39. MedicationRequest.substitution.allowed[x]
                    this.Element_Allowed = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Allowed",                                                                                           // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            },                                                                                                              // MakerGen.cs:289
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 40. MedicationRequest.substitution.reason
                    this.Element_Reason = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Reason",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:389
        // 1. MedicationRequest.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. MedicationRequest.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 3. MedicationRequest.statusReason
        public MakerElementInstance Element_StatusReason;                                                                                   // MakerGen.cs:232
        // 4. MedicationRequest.intent
        public MakerElementInstance Element_Intent;                                                                                         // MakerGen.cs:232
        // 5. MedicationRequest.category
        public MakerElementInstance Element_Category;                                                                                       // MakerGen.cs:232
        // 6. MedicationRequest.priority
        public MakerElementInstance Element_Priority;                                                                                       // MakerGen.cs:232
        // 7. MedicationRequest.doNotPerform
        public MakerElementInstance Element_DoNotPerform;                                                                                   // MakerGen.cs:232
        // 8. MedicationRequest.reported[x]
        public MakerElementInstance Element_Reported;                                                                                       // MakerGen.cs:232
        // 9. MedicationRequest.medication[x]
        public MakerElementInstance Element_Medication;                                                                                     // MakerGen.cs:232
        // 10. MedicationRequest.subject
        public MakerElementInstance Element_Subject;                                                                                        // MakerGen.cs:232
        // 11. MedicationRequest.encounter
        public MakerElementInstance Element_Encounter;                                                                                      // MakerGen.cs:232
        // 12. MedicationRequest.supportingInformation
        public MakerElementInstance Element_SupportingInformation;                                                                          // MakerGen.cs:232
        // 13. MedicationRequest.authoredOn
        public MakerElementInstance Element_AuthoredOn;                                                                                     // MakerGen.cs:232
        // 14. MedicationRequest.requester
        public MakerElementInstance Element_Requester;                                                                                      // MakerGen.cs:232
        // 15. MedicationRequest.performer
        public MakerElementInstance Element_Performer;                                                                                      // MakerGen.cs:232
        // 16. MedicationRequest.performerType
        public MakerElementInstance Element_PerformerType;                                                                                  // MakerGen.cs:232
        // 17. MedicationRequest.recorder
        public MakerElementInstance Element_Recorder;                                                                                       // MakerGen.cs:232
        // 18. MedicationRequest.reasonCode
        public MakerElementInstance Element_ReasonCode;                                                                                     // MakerGen.cs:232
        // 19. MedicationRequest.reasonReference
        public MakerElementInstance Element_ReasonReference;                                                                                // MakerGen.cs:232
        // 20. MedicationRequest.instantiatesCanonical
        public MakerElementInstance Element_InstantiatesCanonical;                                                                          // MakerGen.cs:232
        // 21. MedicationRequest.instantiatesUri
        public MakerElementInstance Element_InstantiatesUri;                                                                                // MakerGen.cs:232
        // 22. MedicationRequest.basedOn
        public MakerElementInstance Element_BasedOn;                                                                                        // MakerGen.cs:232
        // 23. MedicationRequest.groupIdentifier
        public MakerElementInstance Element_GroupIdentifier;                                                                                // MakerGen.cs:232
        // 24. MedicationRequest.courseOfTherapyType
        public MakerElementInstance Element_CourseOfTherapyType;                                                                            // MakerGen.cs:232
        // 25. MedicationRequest.insurance
        public MakerElementInstance Element_Insurance;                                                                                      // MakerGen.cs:232
        // 26. MedicationRequest.note
        public MakerElementInstance Element_Note;                                                                                           // MakerGen.cs:232
        // 27. MedicationRequest.dosageInstruction
        public MakerElementInstance Element_DosageInstruction;                                                                              // MakerGen.cs:232
        // 41. MedicationRequest.priorPrescription
        public MakerElementInstance Element_PriorPrescription;                                                                              // MakerGen.cs:232
        // 42. MedicationRequest.detectedIssue
        public MakerElementInstance Element_DetectedIssue;                                                                                  // MakerGen.cs:232
        // 43. MedicationRequest.eventHistory
        public MakerElementInstance Element_EventHistory;                                                                                   // MakerGen.cs:232
        public MedicationRequest()                                                                                                          // MakerGen.cs:393
        {                                                                                                                                   // MakerGen.cs:394
            {                                                                                                                               // MakerGen.cs:243
                // 1. MedicationRequest.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Identifier                                                                        // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 2. MedicationRequest.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 3. MedicationRequest.statusReason
                this.Element_StatusReason = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_StatusReason",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 4. MedicationRequest.intent
                this.Element_Intent = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Intent",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 5. MedicationRequest.category
                this.Element_Category = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Category",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 6. MedicationRequest.priority
                this.Element_Priority = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Priority",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 7. MedicationRequest.doNotPerform
                this.Element_DoNotPerform = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_DoNotPerform",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean                                                                         // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 8. MedicationRequest.reported[x]
                this.Element_Reported = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Reported",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean                                                                         // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        },                                                                                                                  // MakerGen.cs:289
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 9. MedicationRequest.medication[x]
                this.Element_Medication = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Medication",                                                                                            // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        },                                                                                                                  // MakerGen.cs:299
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 10. MedicationRequest.subject
                this.Element_Subject = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 11. MedicationRequest.encounter
                this.Element_Encounter = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 12. MedicationRequest.supportingInformation
                this.Element_SupportingInformation = new MakerElementInstance                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_SupportingInformation",                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 13. MedicationRequest.authoredOn
                this.Element_AuthoredOn = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_AuthoredOn",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 14. MedicationRequest.requester
                this.Element_Requester = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Requester",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 15. MedicationRequest.performer
                this.Element_Performer = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Performer",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 16. MedicationRequest.performerType
                this.Element_PerformerType = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PerformerType",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 17. MedicationRequest.recorder
                this.Element_Recorder = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Recorder",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 18. MedicationRequest.reasonCode
                this.Element_ReasonCode = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 19. MedicationRequest.reasonReference
                this.Element_ReasonReference = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 20. MedicationRequest.instantiatesCanonical
                this.Element_InstantiatesCanonical = new MakerElementInstance                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_InstantiatesCanonical",                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Canonical                                                                       // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 21. MedicationRequest.instantiatesUri
                this.Element_InstantiatesUri = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_InstantiatesUri",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Uri                                                                             // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 22. MedicationRequest.basedOn
                this.Element_BasedOn = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_BasedOn",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 23. MedicationRequest.groupIdentifier
                this.Element_GroupIdentifier = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_GroupIdentifier",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Identifier                                                                        // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 24. MedicationRequest.courseOfTherapyType
                this.Element_CourseOfTherapyType = new MakerElementInstance                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_CourseOfTherapyType",                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 25. MedicationRequest.insurance
                this.Element_Insurance = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Insurance",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 26. MedicationRequest.note
                this.Element_Note = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Annotation                                                                        // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 27. MedicationRequest.dosageInstruction
                this.Element_DosageInstruction = new MakerElementInstance                                                                   // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_DosageInstruction",                                                                                     // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Dosage                                                                            // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 41. MedicationRequest.priorPrescription
                this.Element_PriorPrescription = new MakerElementInstance                                                                   // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PriorPrescription",                                                                                     // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 42. MedicationRequest.detectedIssue
                this.Element_DetectedIssue = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_DetectedIssue",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 43. MedicationRequest.eventHistory
                this.Element_EventHistory = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_EventHistory",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:389
}                                                                                                                                           // MakerGen.cs:440
