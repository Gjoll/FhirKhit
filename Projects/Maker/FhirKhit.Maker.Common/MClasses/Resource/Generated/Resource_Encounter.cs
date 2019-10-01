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
      "id": "Encounter",
      "url": "http://hl7.org/fhir/StructureDefinition/Encounter",
      "version": "4.0.0",
      "name": "Encounter",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Administration)",
      "description": "An interaction between a patient and healthcare provider(s) for the purpose of providing healthcare service(s) or assessing the health status of a patient.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Encounter",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "Encounter",
            "path": "Encounter",
            "short": "An interaction during which services are provided to the patient",
            "definition": "An interaction between a patient and healthcare provider(s) for the purpose of providing healthcare service(s) or assessing the health status of a patient.",
            "alias": [
              "Visit"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "Encounter.identifier",
            "path": "Encounter.identifier",
            "short": "Identifier(s) by which this encounter is known",
            "definition": "Identifier(s) by which this encounter is known.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "Encounter.status",
            "path": "Encounter.status",
            "short": "planned | arrived | triaged | in-progress | onleave | finished | cancelled +",
            "definition": "planned | arrived | triaged | in-progress | onleave | finished | cancelled +.",
            "comment": "Note that internal business rules will determine the appropriate transitions that may occur between statuses (and also classes).",
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
                  "valueString": "EncounterStatus"
                }
              ],
              "strength": "required",
              "description": "Current state of the encounter.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-status|4.0.0"
            }
          },
          {
            "id": "Encounter.statusHistory",
            "path": "Encounter.statusHistory",
            "short": "List of past encounter statuses",
            "definition": "The status history permits the encounter resource to contain the status history without needing to read through the historical versions of the resource, or even have the server store them.",
            "comment": "The current status is always found in the current version of the resource, not the status history.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Encounter.statusHistory.status",
            "path": "Encounter.statusHistory.status",
            "short": "planned | arrived | triaged | in-progress | onleave | finished | cancelled +",
            "definition": "planned | arrived | triaged | in-progress | onleave | finished | cancelled +.",
            "min": 1,
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
                  "valueString": "EncounterStatus"
                }
              ],
              "strength": "required",
              "description": "Current state of the encounter.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-status|4.0.0"
            }
          },
          {
            "id": "Encounter.statusHistory.period",
            "path": "Encounter.statusHistory.period",
            "short": "The time that the episode was in the specified status",
            "definition": "The time that the episode was in the specified status.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Encounter.class",
            "path": "Encounter.class",
            "short": "Classification of patient encounter",
            "definition": "Concepts representing classification of patient encounter such as ambulatory (outpatient), inpatient, emergency, home health or others due to local variations.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "EncounterClass"
                }
              ],
              "strength": "extensible",
              "description": "Classification of the encounter.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode"
            }
          },
          {
            "id": "Encounter.classHistory",
            "path": "Encounter.classHistory",
            "short": "List of past encounter classes",
            "definition": "The class history permits the tracking of the encounters transitions without needing to go  through the resource history.  This would be used for a case where an admission starts of as an emergency encounter, then transitions into an inpatient scenario. Doing this and not restarting a new encounter ensures that any lab/diagnostic results can more easily follow the patient and not require re-processing and not get lost or cancelled during a kind of discharge from emergency to inpatient.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Encounter.classHistory.class",
            "path": "Encounter.classHistory.class",
            "short": "inpatient | outpatient | ambulatory | emergency +",
            "definition": "inpatient | outpatient | ambulatory | emergency +.",
            "min": 1,
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
                  "valueString": "EncounterClass"
                }
              ],
              "strength": "extensible",
              "description": "Classification of the encounter.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ActEncounterCode"
            }
          },
          {
            "id": "Encounter.classHistory.period",
            "path": "Encounter.classHistory.period",
            "short": "The time that the episode was in the specified class",
            "definition": "The time that the episode was in the specified class.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Encounter.type",
            "path": "Encounter.type",
            "short": "Specific type of encounter",
            "definition": "Specific type of encounter (e.g. e-mail consultation, surgical day-care, skilled nursing, rehabilitation).",
            "comment": "Since there are many ways to further classify encounters, this element is 0..*.",
            "min": 0,
            "max": "*",
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
                  "valueString": "EncounterType"
                }
              ],
              "strength": "example",
              "description": "The type of encounter.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-type"
            }
          },
          {
            "id": "Encounter.serviceType",
            "path": "Encounter.serviceType",
            "short": "Specific type of service",
            "definition": "Broad categorization of the service that is to be provided (e.g. cardiology).",
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
                  "valueString": "EncounterServiceType"
                }
              ],
              "strength": "example",
              "description": "Broad categorization of the service that is to be provided.",
              "valueSet": "http://hl7.org/fhir/ValueSet/service-type"
            }
          },
          {
            "id": "Encounter.priority",
            "path": "Encounter.priority",
            "short": "Indicates the urgency of the encounter",
            "definition": "Indicates the urgency of the encounter.",
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
                  "valueString": "Priority"
                }
              ],
              "strength": "example",
              "description": "Indicates the urgency of the encounter.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v3-ActPriority"
            }
          },
          {
            "id": "Encounter.subject",
            "path": "Encounter.subject",
            "short": "The patient or group present at the encounter",
            "definition": "The patient or group present at the encounter.",
            "comment": "While the encounter is always about the patient, the patient might not actually be known in all contexts of use, and there may be a group of patients that could be anonymous (such as in a group therapy for Alcoholics Anonymous - where the recording of the encounter could be used for billing on the number of people/staff and not important to the context of the specific patients) or alternately in veterinary care a herd of sheep receiving treatment (where the animals are not individually tracked).",
            "alias": [
              "patient"
            ],
            "min": 0,
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
            "id": "Encounter.episodeOfCare",
            "path": "Encounter.episodeOfCare",
            "short": "Episode(s) of care that this encounter should be recorded against",
            "definition": "Where a specific encounter should be classified as a part of a specific episode(s) of care this field should be used. This association can facilitate grouping of related encounters together for a specific purpose, such as government reporting, issue tracking, association via a common problem.  The association is recorded on the encounter as these are typically created after the episode of care and grouped on entry rather than editing the episode of care to append another encounter to it (the episode of care could span years).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Encounter.basedOn",
            "path": "Encounter.basedOn",
            "short": "The ServiceRequest that initiated this encounter",
            "definition": "The request this encounter satisfies (e.g. incoming referral or procedure request).",
            "alias": [
              "incomingReferral"
            ],
            "min": 0,
            "max": "*",
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
            "id": "Encounter.participant",
            "path": "Encounter.participant",
            "short": "List of participants involved in the encounter",
            "definition": "The list of people responsible for providing the service.",
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
            "id": "Encounter.participant.type",
            "path": "Encounter.participant.type",
            "short": "Role of participant in encounter",
            "definition": "Role of participant in encounter.",
            "comment": "The participant type indicates how an individual participates in an encounter. It includes non-practitioner participants, and for practitioners this is to describe the action type in the context of this encounter (e.g. Admitting Dr, Attending Dr, Translator, Consulting Dr). This is different to the practitioner roles which are functional roles, derived from terms of employment, education, licensing, etc.",
            "min": 0,
            "max": "*",
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
                  "valueString": "ParticipantType"
                }
              ],
              "strength": "extensible",
              "description": "Role of participant in encounter.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-participant-type"
            }
          },
          {
            "id": "Encounter.participant.period",
            "path": "Encounter.participant.period",
            "short": "Period of time during the encounter that the participant participated",
            "definition": "The period of time that the specified participant participated in the encounter. These can overlap or be sub-sets of the overall encounter's period.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Encounter.participant.individual",
            "path": "Encounter.participant.individual",
            "short": "Persons involved in the encounter other than the patient",
            "definition": "Persons involved in the encounter other than the patient.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Encounter.appointment",
            "path": "Encounter.appointment",
            "short": "The appointment that scheduled this encounter",
            "definition": "The appointment that scheduled this encounter.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Appointment"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Encounter.period",
            "path": "Encounter.period",
            "short": "The start and end time of the encounter",
            "definition": "The start and end time of the encounter.",
            "comment": "If not (yet) known, the end of the Period may be omitted.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Encounter.length",
            "path": "Encounter.length",
            "short": "Quantity of time the encounter lasted (less time absent)",
            "definition": "Quantity of time the encounter lasted. This excludes the time during leaves of absence.",
            "comment": "May differ from the time the Encounter.period lasted because of leave of absence.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ]
          },
          {
            "id": "Encounter.reasonCode",
            "path": "Encounter.reasonCode",
            "short": "Coded reason the encounter takes place",
            "definition": "Reason the encounter takes place, expressed as a code. For admissions, this can be used for a coded admission diagnosis.",
            "comment": "For systems that need to know which was the primary diagnosis, these will be marked with the standard extension primaryDiagnosis (which is a sequence value rather than a flag, 1 = primary diagnosis).",
            "alias": [
              "Indication",
              "Admission diagnosis"
            ],
            "min": 0,
            "max": "*",
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
                  "valueString": "EncounterReason"
                }
              ],
              "strength": "preferred",
              "description": "Reason why the encounter takes place.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-reason"
            }
          },
          {
            "id": "Encounter.reasonReference",
            "path": "Encounter.reasonReference",
            "short": "Reason the encounter takes place (reference)",
            "definition": "Reason the encounter takes place, expressed as a code. For admissions, this can be used for a coded admission diagnosis.",
            "comment": "For systems that need to know which was the primary diagnosis, these will be marked with the standard extension primaryDiagnosis (which is a sequence value rather than a flag, 1 = primary diagnosis).",
            "alias": [
              "Indication",
              "Admission diagnosis"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Procedure",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Encounter.diagnosis",
            "path": "Encounter.diagnosis",
            "short": "The list of diagnosis relevant to this encounter",
            "definition": "The list of diagnosis relevant to this encounter.",
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
            "id": "Encounter.diagnosis.condition",
            "path": "Encounter.diagnosis.condition",
            "short": "The diagnosis or procedure relevant to the encounter",
            "definition": "Reason the encounter takes place, as specified using information from another resource. For admissions, this is the admission diagnosis. The indication will typically be a Condition (with other resources referenced in the evidence.detail), or a Procedure.",
            "comment": "For systems that need to know which was the primary diagnosis, these will be marked with the standard extension primaryDiagnosis (which is a sequence value rather than a flag, 1 = primary diagnosis).",
            "alias": [
              "Admission diagnosis",
              "discharge diagnosis",
              "indication"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Procedure"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Encounter.diagnosis.use",
            "path": "Encounter.diagnosis.use",
            "short": "Role that this diagnosis has within the encounter (e.g. admission, billing, discharge …)",
            "definition": "Role that this diagnosis has within the encounter (e.g. admission, billing, discharge …).",
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
                  "valueString": "DiagnosisRole"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "preferred",
              "description": "The type of diagnosis this condition represents.",
              "valueSet": "http://hl7.org/fhir/ValueSet/diagnosis-role"
            }
          },
          {
            "id": "Encounter.diagnosis.rank",
            "path": "Encounter.diagnosis.rank",
            "short": "Ranking of the diagnosis (for each role type)",
            "definition": "Ranking of the diagnosis (for each role type).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ]
          },
          {
            "id": "Encounter.account",
            "path": "Encounter.account",
            "short": "The set of accounts that may be used for billing for this Encounter",
            "definition": "The set of accounts that may be used for billing for this Encounter.",
            "comment": "The billing system may choose to allocate billable items associated with the Encounter to different referenced Accounts based on internal business rules.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Account"
                ]
              }
            ]
          },
          {
            "id": "Encounter.hospitalization",
            "path": "Encounter.hospitalization",
            "short": "Details about the admission to a healthcare service",
            "definition": "Details about the admission to a healthcare service.",
            "comment": "An Encounter may cover more than just the inpatient stay. Contexts such as outpatients, community clinics, and aged care facilities are also included.\r\rThe duration recorded in the period of this encounter covers the entire scope of this hospitalization record.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Encounter.hospitalization.preAdmissionIdentifier",
            "path": "Encounter.hospitalization.preAdmissionIdentifier",
            "short": "Pre-admission identifier",
            "definition": "Pre-admission identifier.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ]
          },
          {
            "id": "Encounter.hospitalization.origin",
            "path": "Encounter.hospitalization.origin",
            "short": "The location/organization from which the patient came before admission",
            "definition": "The location/organization from which the patient came before admission.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Encounter.hospitalization.admitSource",
            "path": "Encounter.hospitalization.admitSource",
            "short": "From where patient was admitted (physician referral, transfer)",
            "definition": "From where patient was admitted (physician referral, transfer).",
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
                  "valueString": "AdmitSource"
                }
              ],
              "strength": "preferred",
              "description": "From where the patient was admitted.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-admit-source"
            }
          },
          {
            "id": "Encounter.hospitalization.reAdmission",
            "path": "Encounter.hospitalization.reAdmission",
            "short": "The type of hospital re-admission that has occurred (if any). If the value is absent, then this is not identified as a readmission",
            "definition": "Whether this hospitalization is a readmission and why if known.",
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
                  "valueString": "ReAdmissionType"
                }
              ],
              "strength": "example",
              "description": "The reason for re-admission of this hospitalization encounter.",
              "valueSet": "http://terminology.hl7.org/ValueSet/v2-0092"
            }
          },
          {
            "id": "Encounter.hospitalization.dietPreference",
            "path": "Encounter.hospitalization.dietPreference",
            "short": "Diet preferences reported by the patient",
            "definition": "Diet preferences reported by the patient.",
            "comment": "For example, a patient may request both a dairy-free and nut-free diet preference (not mutually exclusive).",
            "requirements": "Used to track patient's diet restrictions and/or preference. For a complete description of the nutrition needs of a patient during their stay, one should use the nutritionOrder resource which links to Encounter.",
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
                  "valueString": "PatientDiet"
                }
              ],
              "strength": "example",
              "description": "Medical, cultural or ethical food preferences to help with catering requirements.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-diet"
            }
          },
          {
            "id": "Encounter.hospitalization.specialCourtesy",
            "path": "Encounter.hospitalization.specialCourtesy",
            "short": "Special courtesies (VIP, board member)",
            "definition": "Special courtesies (VIP, board member).",
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
                  "valueString": "Courtesies"
                }
              ],
              "strength": "preferred",
              "description": "Special courtesies.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-special-courtesy"
            }
          },
          {
            "id": "Encounter.hospitalization.specialArrangement",
            "path": "Encounter.hospitalization.specialArrangement",
            "short": "Wheelchair, translator, stretcher, etc.",
            "definition": "Any special requests that have been made for this hospitalization encounter, such as the provision of specific equipment or other things.",
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
                  "valueString": "Arrangements"
                }
              ],
              "strength": "preferred",
              "description": "Special arrangements.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-special-arrangements"
            }
          },
          {
            "id": "Encounter.hospitalization.destination",
            "path": "Encounter.hospitalization.destination",
            "short": "Location/organization to which the patient is discharged",
            "definition": "Location/organization to which the patient is discharged.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ]
          },
          {
            "id": "Encounter.hospitalization.dischargeDisposition",
            "path": "Encounter.hospitalization.dischargeDisposition",
            "short": "Category or kind of location after discharge",
            "definition": "Category or kind of location after discharge.",
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
                  "valueString": "DischargeDisp"
                }
              ],
              "strength": "example",
              "description": "Discharge Disposition.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-discharge-disposition"
            }
          },
          {
            "id": "Encounter.location",
            "path": "Encounter.location",
            "short": "List of locations where the patient has been",
            "definition": "List of locations where  the patient has been during this encounter.",
            "comment": "Virtual encounters can be recorded in the Encounter by specifying a location reference to a location of type \"kind\" such as \"client's home\" and an encounter.class = \"virtual\".",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "Encounter.location.location",
            "path": "Encounter.location.location",
            "short": "Location the encounter takes place",
            "definition": "The location where the encounter takes place.",
            "min": 1,
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
            "id": "Encounter.location.status",
            "path": "Encounter.location.status",
            "short": "planned | active | reserved | completed",
            "definition": "The status of the participants' presence at the specified location during the period specified. If the participant is no longer at the location, then the period will have an end date/time.",
            "comment": "When the patient is no longer active at a location, then the period end date is entered, and the status may be changed to completed.",
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
                  "valueString": "EncounterLocationStatus"
                }
              ],
              "strength": "required",
              "description": "The status of the location.",
              "valueSet": "http://hl7.org/fhir/ValueSet/encounter-location-status|4.0.0"
            }
          },
          {
            "id": "Encounter.location.physicalType",
            "path": "Encounter.location.physicalType",
            "short": "The physical type of the location (usually the level in the location hierachy - bed room ward etc.)",
            "definition": "This will be used to specify the required levels (bed/ward/room/etc.) desired to be recorded to simplify either messaging or query.",
            "comment": "This information is de-normalized from the Location resource to support the easier understanding of the encounter resource and processing in messaging or query.\n\nThere may be many levels in the hierachy, and this may only pic specific levels that are required for a specific usage scenario.",
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
                  "valueString": "PhysicalType"
                }
              ],
              "strength": "example",
              "description": "Physical form of the location.",
              "valueSet": "http://hl7.org/fhir/ValueSet/location-physical-type"
            }
          },
          {
            "id": "Encounter.location.period",
            "path": "Encounter.location.period",
            "short": "Time period during which the patient was present at the location",
            "definition": "Time period during which the patient was present at the location.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ]
          },
          {
            "id": "Encounter.serviceProvider",
            "path": "Encounter.serviceProvider",
            "short": "The organization (facility) responsible for this encounter",
            "definition": "The organization that is primarily responsible for this Encounter's services. This MAY be the same as the organization on the Patient record, however it could be different, such as if the actor performing the services was from an external organization (which may be billed seperately) for an external consultation.  Refer to the example bundle showing an abbreviated set of Encounters for a colonoscopy.",
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
            "id": "Encounter.partOf",
            "path": "Encounter.partOf",
            "short": "Another Encounter this encounter is part of",
            "definition": "Another Encounter of which this encounter is a part of (administratively or in time).",
            "comment": "This is also used for associating a child's encounter back to the mother's encounter.\r\rRefer to the Notes section in the Patient resource for further details.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-hierarchy",
                    "valueBoolean": true
                  }
                ],
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'Encounter'
    /// </summary>
    // 0. Encounter
    public class Resource_Encounter : FhirKhit.Maker.Common.Resource.ResourceBase                                                           // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_Encounter_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 3. Encounter.statusHistory
            public class Type_StatusHistory : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_StatusHistory_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 4. Encounter.statusHistory.status
                    public ElementDefinitionInfo Element_Status;                                                                            // MakerGen.cs:211
                    // 5. Encounter.statusHistory.period
                    public ElementDefinitionInfo Element_Period;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_StatusHistory_Elements()                                                                                    // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 4. Encounter.statusHistory.status
                            this.Element_Status = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Status",                                                                                    // MakerGen.cs:230
                                Path= "Encounter.statusHistory.status",                                                                     // MakerGen.cs:231
                                Id = "Encounter.statusHistory.status",                                                                      // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
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
                            // 5. Encounter.statusHistory.period
                            this.Element_Period = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Period",                                                                                    // MakerGen.cs:230
                                Path= "Encounter.statusHistory.period",                                                                     // MakerGen.cs:231
                                Id = "Encounter.statusHistory.period",                                                                      // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Period                                                           // MakerGen.cs:350
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
                        Element_Status.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_Period.Write(sDef);                                                                                         // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_StatusHistory_Elements Elements                                                                                 // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_StatusHistory_Elements();                                                              // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_StatusHistory_Elements elements;                                                                                       // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_StatusHistory()                                                                                                 // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Encounter.statusHistory",                                                                                   // MakerGen.cs:420
                        ElementId = "Encounter.statusHistory"                                                                               // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 7. Encounter.classHistory
            public class Type_ClassHistory : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_ClassHistory_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 8. Encounter.classHistory.class
                    public ElementDefinitionInfo Element_Class;                                                                             // MakerGen.cs:211
                    // 9. Encounter.classHistory.period
                    public ElementDefinitionInfo Element_Period;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_ClassHistory_Elements()                                                                                     // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 8. Encounter.classHistory.class
                            this.Element_Class = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Class",                                                                                     // MakerGen.cs:230
                                Path= "Encounter.classHistory.class",                                                                       // MakerGen.cs:231
                                Id = "Encounter.classHistory.class",                                                                        // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Coding                                                           // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 9. Encounter.classHistory.period
                            this.Element_Period = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Period",                                                                                    // MakerGen.cs:230
                                Path= "Encounter.classHistory.period",                                                                      // MakerGen.cs:231
                                Id = "Encounter.classHistory.period",                                                                       // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Period                                                           // MakerGen.cs:350
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
                        Element_Class.Write(sDef);                                                                                          // MakerGen.cs:215
                        Element_Period.Write(sDef);                                                                                         // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_ClassHistory_Elements Elements                                                                                  // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_ClassHistory_Elements();                                                               // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_ClassHistory_Elements elements;                                                                                        // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_ClassHistory()                                                                                                  // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Encounter.classHistory",                                                                                    // MakerGen.cs:420
                        ElementId = "Encounter.classHistory"                                                                                // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 16. Encounter.participant
            public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Participant_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 17. Encounter.participant.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:211
                    // 18. Encounter.participant.period
                    public ElementDefinitionInfo Element_Period;                                                                            // MakerGen.cs:211
                    // 19. Encounter.participant.individual
                    public ElementDefinitionInfo Element_Individual;                                                                        // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Participant_Elements()                                                                                      // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 17. Encounter.participant.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Type",                                                                                      // MakerGen.cs:230
                                Path= "Encounter.participant.type",                                                                         // MakerGen.cs:231
                                Id = "Encounter.participant.type",                                                                          // MakerGen.cs:232
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
                            // 18. Encounter.participant.period
                            this.Element_Period = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Period",                                                                                    // MakerGen.cs:230
                                Path= "Encounter.participant.period",                                                                       // MakerGen.cs:231
                                Id = "Encounter.participant.period",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Period                                                           // MakerGen.cs:350
                                    {                                                                                                       // MakerGen.cs:351
                                    }                                                                                                       // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 19. Encounter.participant.individual
                            this.Element_Individual = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Individual",                                                                                // MakerGen.cs:230
                                Path= "Encounter.participant.individual",                                                                   // MakerGen.cs:231
                                Id = "Encounter.participant.individual",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                         // MakerGen.cs:341
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
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:215
                        Element_Period.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_Individual.Write(sDef);                                                                                     // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Participant_Elements Elements                                                                                   // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Participant_Elements();                                                                // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Participant_Elements elements;                                                                                         // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Participant()                                                                                                   // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Encounter.participant",                                                                                     // MakerGen.cs:420
                        ElementId = "Encounter.participant"                                                                                 // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 25. Encounter.diagnosis
            public class Type_Diagnosis : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Diagnosis_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 26. Encounter.diagnosis.condition
                    public ElementDefinitionInfo Element_Condition;                                                                         // MakerGen.cs:211
                    // 27. Encounter.diagnosis.use
                    public ElementDefinitionInfo Element_Use;                                                                               // MakerGen.cs:211
                    // 28. Encounter.diagnosis.rank
                    public ElementDefinitionInfo Element_Rank;                                                                              // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Diagnosis_Elements()                                                                                        // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 26. Encounter.diagnosis.condition
                            this.Element_Condition = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Condition",                                                                                 // MakerGen.cs:230
                                Path= "Encounter.diagnosis.condition",                                                                      // MakerGen.cs:231
                                Id = "Encounter.diagnosis.condition",                                                                       // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Condition",                                            // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Procedure"                                             // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 27. Encounter.diagnosis.use
                            this.Element_Use = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Use",                                                                                       // MakerGen.cs:230
                                Path= "Encounter.diagnosis.use",                                                                            // MakerGen.cs:231
                                Id = "Encounter.diagnosis.use",                                                                             // MakerGen.cs:232
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
                            // 28. Encounter.diagnosis.rank
                            this.Element_Rank = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Rank",                                                                                      // MakerGen.cs:230
                                Path= "Encounter.diagnosis.rank",                                                                           // MakerGen.cs:231
                                Id = "Encounter.diagnosis.rank",                                                                            // MakerGen.cs:232
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
                    }                                                                                                                       // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        Element_Condition.Write(sDef);                                                                                      // MakerGen.cs:215
                        Element_Use.Write(sDef);                                                                                            // MakerGen.cs:215
                        Element_Rank.Write(sDef);                                                                                           // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Diagnosis_Elements Elements                                                                                     // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Diagnosis_Elements();                                                                  // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Diagnosis_Elements elements;                                                                                           // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Diagnosis()                                                                                                     // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Encounter.diagnosis",                                                                                       // MakerGen.cs:420
                        ElementId = "Encounter.diagnosis"                                                                                   // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 30. Encounter.hospitalization
            public class Type_Hospitalization : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Hospitalization_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 31. Encounter.hospitalization.preAdmissionIdentifier
                    public ElementDefinitionInfo Element_PreAdmissionIdentifier;                                                            // MakerGen.cs:211
                    // 32. Encounter.hospitalization.origin
                    public ElementDefinitionInfo Element_Origin;                                                                            // MakerGen.cs:211
                    // 33. Encounter.hospitalization.admitSource
                    public ElementDefinitionInfo Element_AdmitSource;                                                                       // MakerGen.cs:211
                    // 34. Encounter.hospitalization.reAdmission
                    public ElementDefinitionInfo Element_ReAdmission;                                                                       // MakerGen.cs:211
                    // 35. Encounter.hospitalization.dietPreference
                    public ElementDefinitionInfo Element_DietPreference;                                                                    // MakerGen.cs:211
                    // 36. Encounter.hospitalization.specialCourtesy
                    public ElementDefinitionInfo Element_SpecialCourtesy;                                                                   // MakerGen.cs:211
                    // 37. Encounter.hospitalization.specialArrangement
                    public ElementDefinitionInfo Element_SpecialArrangement;                                                                // MakerGen.cs:211
                    // 38. Encounter.hospitalization.destination
                    public ElementDefinitionInfo Element_Destination;                                                                       // MakerGen.cs:211
                    // 39. Encounter.hospitalization.dischargeDisposition
                    public ElementDefinitionInfo Element_DischargeDisposition;                                                              // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Hospitalization_Elements()                                                                                  // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 31. Encounter.hospitalization.preAdmissionIdentifier
                            this.Element_PreAdmissionIdentifier = new ElementDefinitionInfo                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_PreAdmissionIdentifier",                                                                    // MakerGen.cs:230
                                Path= "Encounter.hospitalization.preAdmissionIdentifier",                                                   // MakerGen.cs:231
                                Id = "Encounter.hospitalization.preAdmissionIdentifier",                                                    // MakerGen.cs:232
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
                        {                                                                                                                   // MakerGen.cs:226
                            // 32. Encounter.hospitalization.origin
                            this.Element_Origin = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Origin",                                                                                    // MakerGen.cs:230
                                Path= "Encounter.hospitalization.origin",                                                                   // MakerGen.cs:231
                                Id = "Encounter.hospitalization.origin",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Location",                                             // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 33. Encounter.hospitalization.admitSource
                            this.Element_AdmitSource = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_AdmitSource",                                                                               // MakerGen.cs:230
                                Path= "Encounter.hospitalization.admitSource",                                                              // MakerGen.cs:231
                                Id = "Encounter.hospitalization.admitSource",                                                               // MakerGen.cs:232
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
                            // 34. Encounter.hospitalization.reAdmission
                            this.Element_ReAdmission = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_ReAdmission",                                                                               // MakerGen.cs:230
                                Path= "Encounter.hospitalization.reAdmission",                                                              // MakerGen.cs:231
                                Id = "Encounter.hospitalization.reAdmission",                                                               // MakerGen.cs:232
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
                            // 35. Encounter.hospitalization.dietPreference
                            this.Element_DietPreference = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_DietPreference",                                                                            // MakerGen.cs:230
                                Path= "Encounter.hospitalization.dietPreference",                                                           // MakerGen.cs:231
                                Id = "Encounter.hospitalization.dietPreference",                                                            // MakerGen.cs:232
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
                            // 36. Encounter.hospitalization.specialCourtesy
                            this.Element_SpecialCourtesy = new ElementDefinitionInfo                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_SpecialCourtesy",                                                                           // MakerGen.cs:230
                                Path= "Encounter.hospitalization.specialCourtesy",                                                          // MakerGen.cs:231
                                Id = "Encounter.hospitalization.specialCourtesy",                                                           // MakerGen.cs:232
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
                            // 37. Encounter.hospitalization.specialArrangement
                            this.Element_SpecialArrangement = new ElementDefinitionInfo                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_SpecialArrangement",                                                                        // MakerGen.cs:230
                                Path= "Encounter.hospitalization.specialArrangement",                                                       // MakerGen.cs:231
                                Id = "Encounter.hospitalization.specialArrangement",                                                        // MakerGen.cs:232
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
                            // 38. Encounter.hospitalization.destination
                            this.Element_Destination = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Destination",                                                                               // MakerGen.cs:230
                                Path= "Encounter.hospitalization.destination",                                                              // MakerGen.cs:231
                                Id = "Encounter.hospitalization.destination",                                                               // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Reference                                                        // MakerGen.cs:338
                                    {                                                                                                       // MakerGen.cs:339
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:341
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Location",                                             // MakerGen.cs:341
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:341
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:342
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 39. Encounter.hospitalization.dischargeDisposition
                            this.Element_DischargeDisposition = new ElementDefinitionInfo                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_DischargeDisposition",                                                                      // MakerGen.cs:230
                                Path= "Encounter.hospitalization.dischargeDisposition",                                                     // MakerGen.cs:231
                                Id = "Encounter.hospitalization.dischargeDisposition",                                                      // MakerGen.cs:232
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
                        Element_PreAdmissionIdentifier.Write(sDef);                                                                         // MakerGen.cs:215
                        Element_Origin.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_AdmitSource.Write(sDef);                                                                                    // MakerGen.cs:215
                        Element_ReAdmission.Write(sDef);                                                                                    // MakerGen.cs:215
                        Element_DietPreference.Write(sDef);                                                                                 // MakerGen.cs:215
                        Element_SpecialCourtesy.Write(sDef);                                                                                // MakerGen.cs:215
                        Element_SpecialArrangement.Write(sDef);                                                                             // MakerGen.cs:215
                        Element_Destination.Write(sDef);                                                                                    // MakerGen.cs:215
                        Element_DischargeDisposition.Write(sDef);                                                                           // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Hospitalization_Elements Elements                                                                               // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Hospitalization_Elements();                                                            // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Hospitalization_Elements elements;                                                                                     // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Hospitalization()                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Encounter.hospitalization",                                                                                 // MakerGen.cs:420
                        ElementId = "Encounter.hospitalization"                                                                             // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 40. Encounter.location
            public class Type_Location : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                public class Type_Location_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:378
                {                                                                                                                           // MakerGen.cs:379
                    // 41. Encounter.location.location
                    public ElementDefinitionInfo Element_Location;                                                                          // MakerGen.cs:211
                    // 42. Encounter.location.status
                    public ElementDefinitionInfo Element_Status;                                                                            // MakerGen.cs:211
                    // 43. Encounter.location.physicalType
                    public ElementDefinitionInfo Element_PhysicalType;                                                                      // MakerGen.cs:211
                    // 44. Encounter.location.period
                    public ElementDefinitionInfo Element_Period;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
                    public Type_Location_Elements()                                                                                         // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:226
                            // 41. Encounter.location.location
                            this.Element_Location = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Location",                                                                                  // MakerGen.cs:230
                                Path= "Encounter.location.location",                                                                        // MakerGen.cs:231
                                Id = "Encounter.location.location",                                                                         // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
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
                            // 42. Encounter.location.status
                            this.Element_Status = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Status",                                                                                    // MakerGen.cs:230
                                Path= "Encounter.location.status",                                                                          // MakerGen.cs:231
                                Id = "Encounter.location.status",                                                                           // MakerGen.cs:232
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
                            // 43. Encounter.location.physicalType
                            this.Element_PhysicalType = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_PhysicalType",                                                                              // MakerGen.cs:230
                                Path= "Encounter.location.physicalType",                                                                    // MakerGen.cs:231
                                Id = "Encounter.location.physicalType",                                                                     // MakerGen.cs:232
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
                            // 44. Encounter.location.period
                            this.Element_Period = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Element_Period",                                                                                    // MakerGen.cs:230
                                Path= "Encounter.location.period",                                                                          // MakerGen.cs:231
                                Id = "Encounter.location.period",                                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Type_Period                                                           // MakerGen.cs:350
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
                        Element_Location.Write(sDef);                                                                                       // MakerGen.cs:215
                        Element_Status.Write(sDef);                                                                                         // MakerGen.cs:215
                        Element_PhysicalType.Write(sDef);                                                                                   // MakerGen.cs:215
                        Element_Period.Write(sDef);                                                                                         // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:394
                }                                                                                                                           // MakerGen.cs:396
                public Type_Location_Elements Elements                                                                                      // MakerGen.cs:398
                {                                                                                                                           // MakerGen.cs:399
                    get                                                                                                                     // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        if (this.elements == null)                                                                                          // MakerGen.cs:402
                            this.elements = new Type_Location_Elements();                                                                   // MakerGen.cs:403
                        return this.elements;                                                                                               // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:406
                Type_Location_Elements elements;                                                                                            // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
                public Type_Location()                                                                                                      // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:411
                }                                                                                                                           // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:416
                {                                                                                                                           // MakerGen.cs:417
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:418
                    {                                                                                                                       // MakerGen.cs:419
                        Path = "Encounter.location",                                                                                        // MakerGen.cs:420
                        ElementId = "Encounter.location"                                                                                    // MakerGen.cs:421
                    });                                                                                                                     // MakerGen.cs:422
                    if (this.elements != null)                                                                                              // MakerGen.cs:423
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:424
                }                                                                                                                           // MakerGen.cs:425
            }                                                                                                                               // MakerGen.cs:426
            // 1. Encounter.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 2. Encounter.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:211
            // 3. Encounter.statusHistory
            public ElementDefinitionInfo Element_StatusHistory;                                                                             // MakerGen.cs:211
            // 6. Encounter.class
            public ElementDefinitionInfo Element_Class;                                                                                     // MakerGen.cs:211
            // 7. Encounter.classHistory
            public ElementDefinitionInfo Element_ClassHistory;                                                                              // MakerGen.cs:211
            // 10. Encounter.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:211
            // 11. Encounter.serviceType
            public ElementDefinitionInfo Element_ServiceType;                                                                               // MakerGen.cs:211
            // 12. Encounter.priority
            public ElementDefinitionInfo Element_Priority;                                                                                  // MakerGen.cs:211
            // 13. Encounter.subject
            public ElementDefinitionInfo Element_Subject;                                                                                   // MakerGen.cs:211
            // 14. Encounter.episodeOfCare
            public ElementDefinitionInfo Element_EpisodeOfCare;                                                                             // MakerGen.cs:211
            // 15. Encounter.basedOn
            public ElementDefinitionInfo Element_BasedOn;                                                                                   // MakerGen.cs:211
            // 16. Encounter.participant
            public ElementDefinitionInfo Element_Participant;                                                                               // MakerGen.cs:211
            // 20. Encounter.appointment
            public ElementDefinitionInfo Element_Appointment;                                                                               // MakerGen.cs:211
            // 21. Encounter.period
            public ElementDefinitionInfo Element_Period;                                                                                    // MakerGen.cs:211
            // 22. Encounter.length
            public ElementDefinitionInfo Element_Length;                                                                                    // MakerGen.cs:211
            // 23. Encounter.reasonCode
            public ElementDefinitionInfo Element_ReasonCode;                                                                                // MakerGen.cs:211
            // 24. Encounter.reasonReference
            public ElementDefinitionInfo Element_ReasonReference;                                                                           // MakerGen.cs:211
            // 25. Encounter.diagnosis
            public ElementDefinitionInfo Element_Diagnosis;                                                                                 // MakerGen.cs:211
            // 29. Encounter.account
            public ElementDefinitionInfo Element_Account;                                                                                   // MakerGen.cs:211
            // 30. Encounter.hospitalization
            public ElementDefinitionInfo Element_Hospitalization;                                                                           // MakerGen.cs:211
            // 40. Encounter.location
            public ElementDefinitionInfo Element_Location;                                                                                  // MakerGen.cs:211
            // 45. Encounter.serviceProvider
            public ElementDefinitionInfo Element_ServiceProvider;                                                                           // MakerGen.cs:211
            // 46. Encounter.partOf
            public ElementDefinitionInfo Element_PartOf;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_Encounter_Elements()                                                                                            // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Encounter.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "Encounter.identifier",                                                                                       // MakerGen.cs:231
                        Id = "Encounter.identifier",                                                                                        // MakerGen.cs:232
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
                    // 2. Encounter.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Status",                                                                                            // MakerGen.cs:230
                        Path= "Encounter.status",                                                                                           // MakerGen.cs:231
                        Id = "Encounter.status",                                                                                            // MakerGen.cs:232
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
                    // 3. Encounter.statusHistory
                    this.Element_StatusHistory = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_StatusHistory",                                                                                     // MakerGen.cs:230
                        Path= "Encounter.statusHistory",                                                                                    // MakerGen.cs:231
                        Id = "Encounter.statusHistory",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_StatusHistory                                                                                          // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. Encounter.class
                    this.Element_Class = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Class",                                                                                             // MakerGen.cs:230
                        Path= "Encounter.class",                                                                                            // MakerGen.cs:231
                        Id = "Encounter.class",                                                                                             // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Coding                                                                   // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. Encounter.classHistory
                    this.Element_ClassHistory = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ClassHistory",                                                                                      // MakerGen.cs:230
                        Path= "Encounter.classHistory",                                                                                     // MakerGen.cs:231
                        Id = "Encounter.classHistory",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_ClassHistory                                                                                           // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. Encounter.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Type",                                                                                              // MakerGen.cs:230
                        Path= "Encounter.type",                                                                                             // MakerGen.cs:231
                        Id = "Encounter.type",                                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. Encounter.serviceType
                    this.Element_ServiceType = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ServiceType",                                                                                       // MakerGen.cs:230
                        Path= "Encounter.serviceType",                                                                                      // MakerGen.cs:231
                        Id = "Encounter.serviceType",                                                                                       // MakerGen.cs:232
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
                    // 12. Encounter.priority
                    this.Element_Priority = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Priority",                                                                                          // MakerGen.cs:230
                        Path= "Encounter.priority",                                                                                         // MakerGen.cs:231
                        Id = "Encounter.priority",                                                                                          // MakerGen.cs:232
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
                    // 13. Encounter.subject
                    this.Element_Subject = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Subject",                                                                                           // MakerGen.cs:230
                        Path= "Encounter.subject",                                                                                          // MakerGen.cs:231
                        Id = "Encounter.subject",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. Encounter.episodeOfCare
                    this.Element_EpisodeOfCare = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_EpisodeOfCare",                                                                                     // MakerGen.cs:230
                        Path= "Encounter.episodeOfCare",                                                                                    // MakerGen.cs:231
                        Id = "Encounter.episodeOfCare",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"                                                 // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 15. Encounter.basedOn
                    this.Element_BasedOn = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_BasedOn",                                                                                           // MakerGen.cs:230
                        Path= "Encounter.basedOn",                                                                                          // MakerGen.cs:231
                        Id = "Encounter.basedOn",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. Encounter.participant
                    this.Element_Participant = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Participant",                                                                                       // MakerGen.cs:230
                        Path= "Encounter.participant",                                                                                      // MakerGen.cs:231
                        Id = "Encounter.participant",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Participant                                                                                            // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 20. Encounter.appointment
                    this.Element_Appointment = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Appointment",                                                                                       // MakerGen.cs:230
                        Path= "Encounter.appointment",                                                                                      // MakerGen.cs:231
                        Id = "Encounter.appointment",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Appointment"                                                   // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 21. Encounter.period
                    this.Element_Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Period",                                                                                            // MakerGen.cs:230
                        Path= "Encounter.period",                                                                                           // MakerGen.cs:231
                        Id = "Encounter.period",                                                                                            // MakerGen.cs:232
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
                    // 22. Encounter.length
                    this.Element_Length = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Length",                                                                                            // MakerGen.cs:230
                        Path= "Encounter.length",                                                                                           // MakerGen.cs:231
                        Id = "Encounter.length",                                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Duration                                                                 // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 23. Encounter.reasonCode
                    this.Element_ReasonCode = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ReasonCode",                                                                                        // MakerGen.cs:230
                        Path= "Encounter.reasonCode",                                                                                       // MakerGen.cs:231
                        Id = "Encounter.reasonCode",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 24. Encounter.reasonReference
                    this.Element_ReasonReference = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ReasonReference",                                                                                   // MakerGen.cs:230
                        Path= "Encounter.reasonReference",                                                                                  // MakerGen.cs:231
                        Id = "Encounter.reasonReference",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Procedure",                                                    // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:341
                                    "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation"                                    // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 25. Encounter.diagnosis
                    this.Element_Diagnosis = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Diagnosis",                                                                                         // MakerGen.cs:230
                        Path= "Encounter.diagnosis",                                                                                        // MakerGen.cs:231
                        Id = "Encounter.diagnosis",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Diagnosis                                                                                              // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 29. Encounter.account
                    this.Element_Account = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Account",                                                                                           // MakerGen.cs:230
                        Path= "Encounter.account",                                                                                          // MakerGen.cs:231
                        Id = "Encounter.account",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Account"                                                       // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 30. Encounter.hospitalization
                    this.Element_Hospitalization = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Hospitalization",                                                                                   // MakerGen.cs:230
                        Path= "Encounter.hospitalization",                                                                                  // MakerGen.cs:231
                        Id = "Encounter.hospitalization",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Hospitalization                                                                                        // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 40. Encounter.location
                    this.Element_Location = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Location",                                                                                          // MakerGen.cs:230
                        Path= "Encounter.location",                                                                                         // MakerGen.cs:231
                        Id = "Encounter.location",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Location                                                                                               // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 45. Encounter.serviceProvider
                    this.Element_ServiceProvider = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ServiceProvider",                                                                                   // MakerGen.cs:230
                        Path= "Encounter.serviceProvider",                                                                                  // MakerGen.cs:231
                        Id = "Encounter.serviceProvider",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
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
                    // 46. Encounter.partOf
                    this.Element_PartOf = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_PartOf",                                                                                            // MakerGen.cs:230
                        Path= "Encounter.partOf",                                                                                           // MakerGen.cs:231
                        Id = "Encounter.partOf",                                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
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
                Element_StatusHistory.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_Class.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_ClassHistory.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_ServiceType.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_Priority.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Subject.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_EpisodeOfCare.Write(sDef);                                                                                          // MakerGen.cs:215
                Element_BasedOn.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Participant.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_Appointment.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_Period.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Length.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_ReasonCode.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_ReasonReference.Write(sDef);                                                                                        // MakerGen.cs:215
                Element_Diagnosis.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_Account.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Hospitalization.Write(sDef);                                                                                        // MakerGen.cs:215
                Element_Location.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_ServiceProvider.Write(sDef);                                                                                        // MakerGen.cs:215
                Element_PartOf.Write(sDef);                                                                                                 // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_Encounter_Elements Elements                                                                                         // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_Encounter_Elements();                                                                      // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_Encounter_Elements elements;                                                                                               // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_Encounter()                                                                                                         // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "Encounter";                                                                                                        // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Encounter";                                                                 // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "Encounter",                                                                                                         // MakerGen.cs:420
                ElementId = "Encounter"                                                                                                     // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
