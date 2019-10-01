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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'Encounter'
    /// </summary>
    // 0. Encounter
    public class Encounter : FhirKhit.Maker.Common.Resource.ResourceBase                                                                    // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class Encounter_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                       // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 3. Encounter.statusHistory
            public class Type_StatusHistory : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_StatusHistory_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 4. Encounter.statusHistory.status
                    public ElementDefinitionInfo Status;                                                                                    // MakerGen.cs:236
                    // 5. Encounter.statusHistory.period
                    public ElementDefinitionInfo Period;                                                                                    // MakerGen.cs:236
                    public Type_StatusHistory_Elements()                                                                                    // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 4. Encounter.statusHistory.status
                            this.Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Status",                                                                                            // MakerGen.cs:255
                                Path= "Encounter.statusHistory.status",                                                                     // MakerGen.cs:256
                                Id = "Encounter.statusHistory.status",                                                                      // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
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
                            // 5. Encounter.statusHistory.period
                            this.Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Period",                                                                                            // MakerGen.cs:255
                                Path= "Encounter.statusHistory.period",                                                                     // MakerGen.cs:256
                                Id = "Encounter.statusHistory.period",                                                                      // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Status.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Period.Write(sDef);                                                                                                 // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_StatusHistory_Elements Elements { get; }                                                                        // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_StatusHistory()                                                                                                 // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_StatusHistory_Elements();                                                                      // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 7. Encounter.classHistory
            public class Type_ClassHistory : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_ClassHistory_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 8. Encounter.classHistory.class
                    public ElementDefinitionInfo Class;                                                                                     // MakerGen.cs:236
                    // 9. Encounter.classHistory.period
                    public ElementDefinitionInfo Period;                                                                                    // MakerGen.cs:236
                    public Type_ClassHistory_Elements()                                                                                     // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 8. Encounter.classHistory.class
                            this.Class = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Class",                                                                                             // MakerGen.cs:255
                                Path= "Encounter.classHistory.class",                                                                       // MakerGen.cs:256
                                Id = "Encounter.classHistory.class",                                                                        // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 9. Encounter.classHistory.period
                            this.Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Period",                                                                                            // MakerGen.cs:255
                                Path= "Encounter.classHistory.period",                                                                      // MakerGen.cs:256
                                Id = "Encounter.classHistory.period",                                                                       // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Class.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Period.Write(sDef);                                                                                                 // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_ClassHistory_Elements Elements { get; }                                                                         // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_ClassHistory()                                                                                                  // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_ClassHistory_Elements();                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 16. Encounter.participant
            public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Participant_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 17. Encounter.participant.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 18. Encounter.participant.period
                    public ElementDefinitionInfo Period;                                                                                    // MakerGen.cs:236
                    // 19. Encounter.participant.individual
                    public ElementDefinitionInfo Individual;                                                                                // MakerGen.cs:236
                    public Type_Participant_Elements()                                                                                      // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 17. Encounter.participant.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "Encounter.participant.type",                                                                         // MakerGen.cs:256
                                Id = "Encounter.participant.type",                                                                          // MakerGen.cs:257
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
                            // 18. Encounter.participant.period
                            this.Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Period",                                                                                            // MakerGen.cs:255
                                Path= "Encounter.participant.period",                                                                       // MakerGen.cs:256
                                Id = "Encounter.participant.period",                                                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 19. Encounter.participant.individual
                            this.Individual = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Individual",                                                                                        // MakerGen.cs:255
                                Path= "Encounter.participant.individual",                                                                   // MakerGen.cs:256
                                Id = "Encounter.participant.individual",                                                                    // MakerGen.cs:257
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
                        Period.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Individual.Write(sDef);                                                                                             // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Participant_Elements Elements { get; }                                                                          // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Participant()                                                                                                   // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Participant_Elements();                                                                        // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 25. Encounter.diagnosis
            public class Type_Diagnosis : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Diagnosis_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 26. Encounter.diagnosis.condition
                    public ElementDefinitionInfo Condition;                                                                                 // MakerGen.cs:236
                    // 27. Encounter.diagnosis.use
                    public ElementDefinitionInfo Use;                                                                                       // MakerGen.cs:236
                    // 28. Encounter.diagnosis.rank
                    public ElementDefinitionInfo Rank;                                                                                      // MakerGen.cs:236
                    public Type_Diagnosis_Elements()                                                                                        // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 26. Encounter.diagnosis.condition
                            this.Condition = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Condition",                                                                                         // MakerGen.cs:255
                                Path= "Encounter.diagnosis.condition",                                                                      // MakerGen.cs:256
                                Id = "Encounter.diagnosis.condition",                                                                       // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Condition",                                            // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Procedure"                                             // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 27. Encounter.diagnosis.use
                            this.Use = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Use",                                                                                               // MakerGen.cs:255
                                Path= "Encounter.diagnosis.use",                                                                            // MakerGen.cs:256
                                Id = "Encounter.diagnosis.use",                                                                             // MakerGen.cs:257
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
                            // 28. Encounter.diagnosis.rank
                            this.Rank = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Rank",                                                                                              // MakerGen.cs:255
                                Path= "Encounter.diagnosis.rank",                                                                           // MakerGen.cs:256
                                Id = "Encounter.diagnosis.rank",                                                                            // MakerGen.cs:257
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
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Condition.Write(sDef);                                                                                              // MakerGen.cs:240
                        Use.Write(sDef);                                                                                                    // MakerGen.cs:240
                        Rank.Write(sDef);                                                                                                   // MakerGen.cs:240
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
            // 30. Encounter.hospitalization
            public class Type_Hospitalization : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Hospitalization_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 31. Encounter.hospitalization.preAdmissionIdentifier
                    public ElementDefinitionInfo PreAdmissionIdentifier;                                                                    // MakerGen.cs:236
                    // 32. Encounter.hospitalization.origin
                    public ElementDefinitionInfo Origin;                                                                                    // MakerGen.cs:236
                    // 33. Encounter.hospitalization.admitSource
                    public ElementDefinitionInfo AdmitSource;                                                                               // MakerGen.cs:236
                    // 34. Encounter.hospitalization.reAdmission
                    public ElementDefinitionInfo ReAdmission;                                                                               // MakerGen.cs:236
                    // 35. Encounter.hospitalization.dietPreference
                    public ElementDefinitionInfo DietPreference;                                                                            // MakerGen.cs:236
                    // 36. Encounter.hospitalization.specialCourtesy
                    public ElementDefinitionInfo SpecialCourtesy;                                                                           // MakerGen.cs:236
                    // 37. Encounter.hospitalization.specialArrangement
                    public ElementDefinitionInfo SpecialArrangement;                                                                        // MakerGen.cs:236
                    // 38. Encounter.hospitalization.destination
                    public ElementDefinitionInfo Destination;                                                                               // MakerGen.cs:236
                    // 39. Encounter.hospitalization.dischargeDisposition
                    public ElementDefinitionInfo DischargeDisposition;                                                                      // MakerGen.cs:236
                    public Type_Hospitalization_Elements()                                                                                  // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 31. Encounter.hospitalization.preAdmissionIdentifier
                            this.PreAdmissionIdentifier = new ElementDefinitionInfo                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "PreAdmissionIdentifier",                                                                            // MakerGen.cs:255
                                Path= "Encounter.hospitalization.preAdmissionIdentifier",                                                   // MakerGen.cs:256
                                Id = "Encounter.hospitalization.preAdmissionIdentifier",                                                    // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 32. Encounter.hospitalization.origin
                            this.Origin = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Origin",                                                                                            // MakerGen.cs:255
                                Path= "Encounter.hospitalization.origin",                                                                   // MakerGen.cs:256
                                Id = "Encounter.hospitalization.origin",                                                                    // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Location",                                             // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 33. Encounter.hospitalization.admitSource
                            this.AdmitSource = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "AdmitSource",                                                                                       // MakerGen.cs:255
                                Path= "Encounter.hospitalization.admitSource",                                                              // MakerGen.cs:256
                                Id = "Encounter.hospitalization.admitSource",                                                               // MakerGen.cs:257
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
                            // 34. Encounter.hospitalization.reAdmission
                            this.ReAdmission = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ReAdmission",                                                                                       // MakerGen.cs:255
                                Path= "Encounter.hospitalization.reAdmission",                                                              // MakerGen.cs:256
                                Id = "Encounter.hospitalization.reAdmission",                                                               // MakerGen.cs:257
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
                            // 35. Encounter.hospitalization.dietPreference
                            this.DietPreference = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "DietPreference",                                                                                    // MakerGen.cs:255
                                Path= "Encounter.hospitalization.dietPreference",                                                           // MakerGen.cs:256
                                Id = "Encounter.hospitalization.dietPreference",                                                            // MakerGen.cs:257
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
                            // 36. Encounter.hospitalization.specialCourtesy
                            this.SpecialCourtesy = new ElementDefinitionInfo                                                                // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "SpecialCourtesy",                                                                                   // MakerGen.cs:255
                                Path= "Encounter.hospitalization.specialCourtesy",                                                          // MakerGen.cs:256
                                Id = "Encounter.hospitalization.specialCourtesy",                                                           // MakerGen.cs:257
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
                            // 37. Encounter.hospitalization.specialArrangement
                            this.SpecialArrangement = new ElementDefinitionInfo                                                             // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "SpecialArrangement",                                                                                // MakerGen.cs:255
                                Path= "Encounter.hospitalization.specialArrangement",                                                       // MakerGen.cs:256
                                Id = "Encounter.hospitalization.specialArrangement",                                                        // MakerGen.cs:257
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
                            // 38. Encounter.hospitalization.destination
                            this.Destination = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Destination",                                                                                       // MakerGen.cs:255
                                Path= "Encounter.hospitalization.destination",                                                              // MakerGen.cs:256
                                Id = "Encounter.hospitalization.destination",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Location",                                             // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Organization"                                          // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 39. Encounter.hospitalization.dischargeDisposition
                            this.DischargeDisposition = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "DischargeDisposition",                                                                              // MakerGen.cs:255
                                Path= "Encounter.hospitalization.dischargeDisposition",                                                     // MakerGen.cs:256
                                Id = "Encounter.hospitalization.dischargeDisposition",                                                      // MakerGen.cs:257
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
                        PreAdmissionIdentifier.Write(sDef);                                                                                 // MakerGen.cs:240
                        Origin.Write(sDef);                                                                                                 // MakerGen.cs:240
                        AdmitSource.Write(sDef);                                                                                            // MakerGen.cs:240
                        ReAdmission.Write(sDef);                                                                                            // MakerGen.cs:240
                        DietPreference.Write(sDef);                                                                                         // MakerGen.cs:240
                        SpecialCourtesy.Write(sDef);                                                                                        // MakerGen.cs:240
                        SpecialArrangement.Write(sDef);                                                                                     // MakerGen.cs:240
                        Destination.Write(sDef);                                                                                            // MakerGen.cs:240
                        DischargeDisposition.Write(sDef);                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Hospitalization_Elements Elements { get; }                                                                      // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Hospitalization()                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Hospitalization_Elements();                                                                    // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 40. Encounter.location
            public class Type_Location : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Location_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 41. Encounter.location.location
                    public ElementDefinitionInfo Location;                                                                                  // MakerGen.cs:236
                    // 42. Encounter.location.status
                    public ElementDefinitionInfo Status;                                                                                    // MakerGen.cs:236
                    // 43. Encounter.location.physicalType
                    public ElementDefinitionInfo PhysicalType;                                                                              // MakerGen.cs:236
                    // 44. Encounter.location.period
                    public ElementDefinitionInfo Period;                                                                                    // MakerGen.cs:236
                    public Type_Location_Elements()                                                                                         // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 41. Encounter.location.location
                            this.Location = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Location",                                                                                          // MakerGen.cs:255
                                Path= "Encounter.location.location",                                                                        // MakerGen.cs:256
                                Id = "Encounter.location.location",                                                                         // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
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
                            // 42. Encounter.location.status
                            this.Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Status",                                                                                            // MakerGen.cs:255
                                Path= "Encounter.location.status",                                                                          // MakerGen.cs:256
                                Id = "Encounter.location.status",                                                                           // MakerGen.cs:257
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
                            // 43. Encounter.location.physicalType
                            this.PhysicalType = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "PhysicalType",                                                                                      // MakerGen.cs:255
                                Path= "Encounter.location.physicalType",                                                                    // MakerGen.cs:256
                                Id = "Encounter.location.physicalType",                                                                     // MakerGen.cs:257
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
                            // 44. Encounter.location.period
                            this.Period = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Period",                                                                                            // MakerGen.cs:255
                                Path= "Encounter.location.period",                                                                          // MakerGen.cs:256
                                Id = "Encounter.location.period",                                                                           // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Location.Write(sDef);                                                                                               // MakerGen.cs:240
                        Status.Write(sDef);                                                                                                 // MakerGen.cs:240
                        PhysicalType.Write(sDef);                                                                                           // MakerGen.cs:240
                        Period.Write(sDef);                                                                                                 // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Location_Elements Elements { get; }                                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Location()                                                                                                      // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Location_Elements();                                                                           // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. Encounter.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. Encounter.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 6. Encounter.class
            public ElementDefinitionInfo Class;                                                                                             // MakerGen.cs:236
            // 10. Encounter.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:236
            // 11. Encounter.serviceType
            public ElementDefinitionInfo ServiceType;                                                                                       // MakerGen.cs:236
            // 12. Encounter.priority
            public ElementDefinitionInfo Priority;                                                                                          // MakerGen.cs:236
            // 13. Encounter.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:236
            // 14. Encounter.episodeOfCare
            public ElementDefinitionInfo EpisodeOfCare;                                                                                     // MakerGen.cs:236
            // 15. Encounter.basedOn
            public ElementDefinitionInfo BasedOn;                                                                                           // MakerGen.cs:236
            // 20. Encounter.appointment
            public ElementDefinitionInfo Appointment;                                                                                       // MakerGen.cs:236
            // 21. Encounter.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:236
            // 22. Encounter.length
            public ElementDefinitionInfo Length;                                                                                            // MakerGen.cs:236
            // 23. Encounter.reasonCode
            public ElementDefinitionInfo ReasonCode;                                                                                        // MakerGen.cs:236
            // 24. Encounter.reasonReference
            public ElementDefinitionInfo ReasonReference;                                                                                   // MakerGen.cs:236
            // 29. Encounter.account
            public ElementDefinitionInfo Account;                                                                                           // MakerGen.cs:236
            // 45. Encounter.serviceProvider
            public ElementDefinitionInfo ServiceProvider;                                                                                   // MakerGen.cs:236
            // 46. Encounter.partOf
            public ElementDefinitionInfo PartOf;                                                                                            // MakerGen.cs:236
            public Encounter_Elements()                                                                                                     // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. Encounter.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "Encounter.identifier",                                                                                       // MakerGen.cs:256
                        Id = "Encounter.identifier",                                                                                        // MakerGen.cs:257
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
                    // 2. Encounter.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "Encounter.status",                                                                                           // MakerGen.cs:256
                        Id = "Encounter.status",                                                                                            // MakerGen.cs:257
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
                    // 6. Encounter.class
                    this.Class = new ElementDefinitionInfo                                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Class",                                                                                                     // MakerGen.cs:255
                        Path= "Encounter.class",                                                                                            // MakerGen.cs:256
                        Id = "Encounter.class",                                                                                             // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. Encounter.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Type",                                                                                                      // MakerGen.cs:255
                        Path= "Encounter.type",                                                                                             // MakerGen.cs:256
                        Id = "Encounter.type",                                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 11. Encounter.serviceType
                    this.ServiceType = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ServiceType",                                                                                               // MakerGen.cs:255
                        Path= "Encounter.serviceType",                                                                                      // MakerGen.cs:256
                        Id = "Encounter.serviceType",                                                                                       // MakerGen.cs:257
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
                    // 12. Encounter.priority
                    this.Priority = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Priority",                                                                                                  // MakerGen.cs:255
                        Path= "Encounter.priority",                                                                                         // MakerGen.cs:256
                        Id = "Encounter.priority",                                                                                          // MakerGen.cs:257
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
                    // 13. Encounter.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Subject",                                                                                                   // MakerGen.cs:255
                        Path= "Encounter.subject",                                                                                          // MakerGen.cs:256
                        Id = "Encounter.subject",                                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 14. Encounter.episodeOfCare
                    this.EpisodeOfCare = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "EpisodeOfCare",                                                                                             // MakerGen.cs:255
                        Path= "Encounter.episodeOfCare",                                                                                    // MakerGen.cs:256
                        Id = "Encounter.episodeOfCare",                                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/EpisodeOfCare"                                                 // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 15. Encounter.basedOn
                    this.BasedOn = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "BasedOn",                                                                                                   // MakerGen.cs:255
                        Path= "Encounter.basedOn",                                                                                          // MakerGen.cs:256
                        Id = "Encounter.basedOn",                                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
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
                    // 20. Encounter.appointment
                    this.Appointment = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Appointment",                                                                                               // MakerGen.cs:255
                        Path= "Encounter.appointment",                                                                                      // MakerGen.cs:256
                        Id = "Encounter.appointment",                                                                                       // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Appointment"                                                   // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 21. Encounter.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Period",                                                                                                    // MakerGen.cs:255
                        Path= "Encounter.period",                                                                                           // MakerGen.cs:256
                        Id = "Encounter.period",                                                                                            // MakerGen.cs:257
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
                    // 22. Encounter.length
                    this.Length = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Length",                                                                                                    // MakerGen.cs:255
                        Path= "Encounter.length",                                                                                           // MakerGen.cs:256
                        Id = "Encounter.length",                                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Duration                                                                      // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 23. Encounter.reasonCode
                    this.ReasonCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ReasonCode",                                                                                                // MakerGen.cs:255
                        Path= "Encounter.reasonCode",                                                                                       // MakerGen.cs:256
                        Id = "Encounter.reasonCode",                                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 24. Encounter.reasonReference
                    this.ReasonReference = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ReasonReference",                                                                                           // MakerGen.cs:255
                        Path= "Encounter.reasonReference",                                                                                  // MakerGen.cs:256
                        Id = "Encounter.reasonReference",                                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Procedure",                                                    // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation"                                    // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 29. Encounter.account
                    this.Account = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Account",                                                                                                   // MakerGen.cs:255
                        Path= "Encounter.account",                                                                                          // MakerGen.cs:256
                        Id = "Encounter.account",                                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Account"                                                       // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 45. Encounter.serviceProvider
                    this.ServiceProvider = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ServiceProvider",                                                                                           // MakerGen.cs:255
                        Path= "Encounter.serviceProvider",                                                                                  // MakerGen.cs:256
                        Id = "Encounter.serviceProvider",                                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
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
                    // 46. Encounter.partOf
                    this.PartOf = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PartOf",                                                                                                    // MakerGen.cs:255
                        Path= "Encounter.partOf",                                                                                           // MakerGen.cs:256
                        Id = "Encounter.partOf",                                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Class.Write(sDef);                                                                                                          // MakerGen.cs:240
                Type.Write(sDef);                                                                                                           // MakerGen.cs:240
                ServiceType.Write(sDef);                                                                                                    // MakerGen.cs:240
                Priority.Write(sDef);                                                                                                       // MakerGen.cs:240
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:240
                EpisodeOfCare.Write(sDef);                                                                                                  // MakerGen.cs:240
                BasedOn.Write(sDef);                                                                                                        // MakerGen.cs:240
                Appointment.Write(sDef);                                                                                                    // MakerGen.cs:240
                Period.Write(sDef);                                                                                                         // MakerGen.cs:240
                Length.Write(sDef);                                                                                                         // MakerGen.cs:240
                ReasonCode.Write(sDef);                                                                                                     // MakerGen.cs:240
                ReasonReference.Write(sDef);                                                                                                // MakerGen.cs:240
                Account.Write(sDef);                                                                                                        // MakerGen.cs:240
                ServiceProvider.Write(sDef);                                                                                                // MakerGen.cs:240
                PartOf.Write(sDef);                                                                                                         // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public Encounter_Elements Elements { get; }                                                                                         // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public Encounter()                                                                                                                  // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new Encounter_Elements();                                                                                       // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
