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
      "id": "AdverseEvent",
      "url": "http://hl7.org/fhir/StructureDefinition/AdverseEvent",
      "version": "4.0.0",
      "name": "AdverseEvent",
      "status": "draft",
      "publisher": "Health Level Seven International (Patient Care)",
      "description": "Actual or  potential/avoided event causing unintended physical injury resulting from or contributed to by medical care, a research study or other healthcare setting factors that requires additional monitoring, treatment, or hospitalization, or that results in death.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "AdverseEvent",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "AdverseEvent",
            "path": "AdverseEvent",
            "short": "Medical care, research study or other healthcare event causing physical injury",
            "definition": "Actual or  potential/avoided event causing unintended physical injury resulting from or contributed to by medical care, a research study or other healthcare setting factors that requires additional monitoring, treatment, or hospitalization, or that results in death.",
            "alias": [
              "AE"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "AdverseEvent.identifier",
            "path": "AdverseEvent.identifier",
            "short": "Business identifier for the event",
            "definition": "Business identifiers assigned to this adverse event by the performer or other systems which remain constant as the resource is updated and propagates from server to server.",
            "comment": "This is a business identifier, not a resource identifier (see [discussion](resource.html#identifiers)).  It is best practice for the identifier to only appear on a single resource instance, however business practices may occasionally dictate that multiple resource instances with the same identifier can exist - possibly even with different resource types.  For example, multiple Patient and a Person resource instance might share the same social insurance number.",
            "requirements": "Allows identification of the adverse event as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "AdverseEvent.actuality",
            "path": "AdverseEvent.actuality",
            "short": "actual | potential",
            "definition": "Whether the event actually happened, or just had the potential to. Note that this is independent of whether anyone was affected or harmed or how severely.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it has a potential code that indicates the adverse event did not actually happen.",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AdverseEventActuality"
                }
              ],
              "strength": "required",
              "description": "Overall nature of the adverse event, e.g. real or potential.",
              "valueSet": "http://hl7.org/fhir/ValueSet/adverse-event-actuality|4.0.0"
            }
          },
          {
            "id": "AdverseEvent.category",
            "path": "AdverseEvent.category",
            "short": "product-problem | product-quality | product-use-error | wrong-dose | incorrect-prescribing-information | wrong-technique | wrong-route-of-administration | wrong-rate | wrong-duration | wrong-time | expired-drug | medical-device-use-error | problem-different-manufacturer | unsafe-physical-environment",
            "definition": "The overall type of event, intended for search and filtering purposes.",
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
                  "valueString": "AdverseEventCategory"
                }
              ],
              "strength": "extensible",
              "description": "Overall categorization of the event, e.g. product-related or situational.",
              "valueSet": "http://hl7.org/fhir/ValueSet/adverse-event-category"
            }
          },
          {
            "id": "AdverseEvent.event",
            "path": "AdverseEvent.event",
            "short": "Type of the event itself in relation to the subject",
            "definition": "This element defines the specific type of event that occurred or that was prevented from occurring.",
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
                  "valueString": "AdverseEventType"
                }
              ],
              "strength": "example",
              "description": "Detailed type of event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/adverse-event-type"
            }
          },
          {
            "id": "AdverseEvent.subject",
            "path": "AdverseEvent.subject",
            "short": "Subject impacted by event",
            "definition": "This subject or group impacted by the event.",
            "comment": "If AdverseEvent.resultingCondition differs among members of the group, then use Patient as the subject.",
            "requirements": "Allows for exposure of biohazard (such as legionella) to a group of individuals in a hospital.",
            "alias": [
              "patient"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "AdverseEvent.encounter",
            "path": "AdverseEvent.encounter",
            "short": "Encounter created as part of",
            "definition": "The Encounter during which AdverseEvent was created or to which the creation of this record is tightly associated.",
            "comment": "This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter.  For example, if a medication administration was considered an adverse event because it resulted in a rash, then the encounter when the medication administration was given is the context.  If the patient reports the AdverseEvent during a second encounter, that second encounter is not the context.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "AdverseEvent.date",
            "path": "AdverseEvent.date",
            "short": "When the event occurred",
            "definition": "The date (and perhaps time) when the adverse event occurred.",
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
            "id": "AdverseEvent.detected",
            "path": "AdverseEvent.detected",
            "short": "When the event was detected",
            "definition": "Estimated or actual date the AdverseEvent began, in the opinion of the reporter.",
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
            "id": "AdverseEvent.recordedDate",
            "path": "AdverseEvent.recordedDate",
            "short": "When the event was recorded",
            "definition": "The date on which the existence of the AdverseEvent was first recorded.",
            "comment": "The recordedDate represents the date when this particular AdverseEvent record was created in the system, not the date of the most recent update.  The date of the last record modification can be retrieved from the resource metadata.",
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
            "id": "AdverseEvent.resultingCondition",
            "path": "AdverseEvent.resultingCondition",
            "short": "Effect on the subject due to this event",
            "definition": "Includes information about the reaction that occurred as a result of exposure to a substance (for example, a drug or a chemical).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "AdverseEvent.location",
            "path": "AdverseEvent.location",
            "short": "Location where adverse event occurred",
            "definition": "The information about where the adverse event occurred.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "AdverseEvent.seriousness",
            "path": "AdverseEvent.seriousness",
            "short": "Seriousness of the event",
            "definition": "Assessment whether this event was of real importance.",
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
                  "valueString": "AdverseEventSeriousness"
                }
              ],
              "strength": "example",
              "description": "Overall seriousness of this event for the patient.",
              "valueSet": "http://hl7.org/fhir/ValueSet/adverse-event-seriousness"
            }
          },
          {
            "id": "AdverseEvent.severity",
            "path": "AdverseEvent.severity",
            "short": "mild | moderate | severe",
            "definition": "Describes the severity of the adverse event, in relation to the subject. Contrast to AdverseEvent.seriousness - a severe rash might not be serious, but a mild heart problem is.",
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
                  "valueString": "AdverseEventSeverity"
                }
              ],
              "strength": "required",
              "description": "The severity of the adverse event itself, in direct relation to the subject.",
              "valueSet": "http://hl7.org/fhir/ValueSet/adverse-event-severity|4.0.0"
            }
          },
          {
            "id": "AdverseEvent.outcome",
            "path": "AdverseEvent.outcome",
            "short": "resolved | recovering | ongoing | resolvedWithSequelae | fatal | unknown",
            "definition": "Describes the type of outcome from the adverse event.",
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
                  "valueString": "AdverseEventOutcome"
                }
              ],
              "strength": "required",
              "description": "TODO (and should this be required?).",
              "valueSet": "http://hl7.org/fhir/ValueSet/adverse-event-outcome|4.0.0"
            }
          },
          {
            "id": "AdverseEvent.recorder",
            "path": "AdverseEvent.recorder",
            "short": "Who recorded the adverse event",
            "definition": "Information on who recorded the adverse event.  May be the patient or a practitioner.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "AdverseEvent.contributor",
            "path": "AdverseEvent.contributor",
            "short": "Who  was involved in the adverse event or the potential adverse event",
            "definition": "Parties that may or should contribute or have contributed information to the adverse event, which can consist of one or more activities.  Such information includes information leading to the decision to perform the activity and how to perform the activity (e.g. consultant), information that the activity itself seeks to reveal (e.g. informant of clinical history), or information about what activity was performed (e.g. informant witness).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "AdverseEvent.suspectEntity",
            "path": "AdverseEvent.suspectEntity",
            "short": "The suspected agent causing the adverse event",
            "definition": "Describes the entity that is suspected to have caused the adverse event.",
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
            "id": "AdverseEvent.suspectEntity.instance",
            "path": "AdverseEvent.suspectEntity.instance",
            "short": "Refers to the specific entity that caused the adverse event",
            "definition": "Identifies the actual instance of what caused the adverse event.  May be a substance, medication, medication administration, medication statement or a device.",
            "alias": [
              "Substance or Medication or Device"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Immunization",
                  "http://hl7.org/fhir/StructureDefinition/Procedure",
                  "http://hl7.org/fhir/StructureDefinition/Substance",
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",
                  "http://hl7.org/fhir/StructureDefinition/MedicationStatement",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "AdverseEvent.suspectEntity.causality",
            "path": "AdverseEvent.suspectEntity.causality",
            "short": "Information on the possible cause of the event",
            "definition": "Information on the possible cause of the event.",
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
            "id": "AdverseEvent.suspectEntity.causality.assessment",
            "path": "AdverseEvent.suspectEntity.causality.assessment",
            "short": "Assessment of if the entity caused the event",
            "definition": "Assessment of if the entity caused the event.",
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
                  "valueString": "AdverseEventCausalityAssessment"
                }
              ],
              "strength": "example",
              "description": "Codes for the assessment of whether the entity caused the event.",
              "valueSet": "http://hl7.org/fhir/ValueSet/adverse-event-causality-assess"
            }
          },
          {
            "id": "AdverseEvent.suspectEntity.causality.productRelatedness",
            "path": "AdverseEvent.suspectEntity.causality.productRelatedness",
            "short": "AdverseEvent.suspectEntity.causalityProductRelatedness",
            "definition": "AdverseEvent.suspectEntity.causalityProductRelatedness.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "AdverseEvent.suspectEntity.causality.author",
            "path": "AdverseEvent.suspectEntity.causality.author",
            "short": "AdverseEvent.suspectEntity.causalityAuthor",
            "definition": "AdverseEvent.suspectEntity.causalityAuthor.",
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
            ],
            "isSummary": true
          },
          {
            "id": "AdverseEvent.suspectEntity.causality.method",
            "path": "AdverseEvent.suspectEntity.causality.method",
            "short": "ProbabilityScale | Bayesian | Checklist",
            "definition": "ProbabilityScale | Bayesian | Checklist.",
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
                  "valueString": "AdverseEventCausalityMethod"
                }
              ],
              "strength": "example",
              "description": "TODO.",
              "valueSet": "http://hl7.org/fhir/ValueSet/adverse-event-causality-method"
            }
          },
          {
            "id": "AdverseEvent.subjectMedicalHistory",
            "path": "AdverseEvent.subjectMedicalHistory",
            "short": "AdverseEvent.subjectMedicalHistory",
            "definition": "AdverseEvent.subjectMedicalHistory.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance",
                  "http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory",
                  "http://hl7.org/fhir/StructureDefinition/Immunization",
                  "http://hl7.org/fhir/StructureDefinition/Procedure",
                  "http://hl7.org/fhir/StructureDefinition/Media",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "AdverseEvent.referenceDocument",
            "path": "AdverseEvent.referenceDocument",
            "short": "AdverseEvent.referenceDocument",
            "definition": "AdverseEvent.referenceDocument.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "AdverseEvent.study",
            "path": "AdverseEvent.study",
            "short": "AdverseEvent.study",
            "definition": "AdverseEvent.study.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ResearchStudy"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'AdverseEvent'
    /// </summary>
    // 0. AdverseEvent
    public class AdverseEvent : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class AdverseEvent_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 17. AdverseEvent.suspectEntity
            public class Type_SuspectEntity : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_SuspectEntity_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 19. AdverseEvent.suspectEntity.causality
                    public class Type_Causality : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Causality_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 20. AdverseEvent.suspectEntity.causality.assessment
                            public ElementDefinitionInfo Assessment;                                                                        // MakerGen.cs:216
                            // 21. AdverseEvent.suspectEntity.causality.productRelatedness
                            public ElementDefinitionInfo ProductRelatedness;                                                                // MakerGen.cs:216
                            // 22. AdverseEvent.suspectEntity.causality.author
                            public ElementDefinitionInfo Author;                                                                            // MakerGen.cs:216
                            // 23. AdverseEvent.suspectEntity.causality.method
                            public ElementDefinitionInfo Method;                                                                            // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Causality_Elements()                                                                                // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 20. AdverseEvent.suspectEntity.causality.assessment
                                    this.Assessment = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Assessment",                                                                                // MakerGen.cs:235
                                        Path= "AdverseEvent.suspectEntity.causality.assessment",                                            // MakerGen.cs:236
                                        Id = "AdverseEvent.suspectEntity.causality.assessment",                                             // MakerGen.cs:237
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
                                    // 21. AdverseEvent.suspectEntity.causality.productRelatedness
                                    this.ProductRelatedness = new ElementDefinitionInfo                                                     // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "ProductRelatedness",                                                                        // MakerGen.cs:235
                                        Path= "AdverseEvent.suspectEntity.causality.productRelatedness",                                    // MakerGen.cs:236
                                        Id = "AdverseEvent.suspectEntity.causality.productRelatedness",                                     // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 22. AdverseEvent.suspectEntity.causality.author
                                    this.Author = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Author",                                                                                    // MakerGen.cs:235
                                        Path= "AdverseEvent.suspectEntity.causality.author",                                                // MakerGen.cs:236
                                        Id = "AdverseEvent.suspectEntity.causality.author",                                                 // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:346
                                            {                                                                                               // MakerGen.cs:347
                                                TargetProfile = new String[]                                                                // MakerGen.cs:349
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                 // MakerGen.cs:349
                                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                              // MakerGen.cs:349
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:350
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 23. AdverseEvent.suspectEntity.causality.method
                                    this.Method = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Method",                                                                                    // MakerGen.cs:235
                                        Path= "AdverseEvent.suspectEntity.causality.method",                                                // MakerGen.cs:236
                                        Id = "AdverseEvent.suspectEntity.causality.method",                                                 // MakerGen.cs:237
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
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Assessment.Write(sDef);                                                                                     // MakerGen.cs:220
                                ProductRelatedness.Write(sDef);                                                                             // MakerGen.cs:220
                                Author.Write(sDef);                                                                                         // MakerGen.cs:220
                                Method.Write(sDef);                                                                                         // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Causality_Elements Elements                                                                             // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Causality_Elements();                                                          // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Causality_Elements elements;                                                                                   // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Causality()                                                                                             // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "AdverseEvent.suspectEntity.causality",                                                              // MakerGen.cs:428
                                ElementId = "AdverseEvent.suspectEntity.causality"                                                          // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 18. AdverseEvent.suspectEntity.instance
                    public ElementDefinitionInfo Instance;                                                                                  // MakerGen.cs:216
                    // 19. AdverseEvent.suspectEntity.causality
                    public ElementDefinitionInfo Causality;                                                                                 // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_SuspectEntity_Elements()                                                                                    // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 18. AdverseEvent.suspectEntity.instance
                            this.Instance = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Instance",                                                                                          // MakerGen.cs:235
                                Path= "AdverseEvent.suspectEntity.instance",                                                                // MakerGen.cs:236
                                Id = "AdverseEvent.suspectEntity.instance",                                                                 // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Immunization",                                         // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Procedure",                                            // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Substance",                                            // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Medication",                                           // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",                             // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/MedicationStatement",                                  // MakerGen.cs:349
                                            "http://hl7.org/fhir/StructureDefinition/Device"                                                // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 19. AdverseEvent.suspectEntity.causality
                            this.Causality = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Causality",                                                                                         // MakerGen.cs:235
                                Path= "AdverseEvent.suspectEntity.causality",                                                               // MakerGen.cs:236
                                Id = "AdverseEvent.suspectEntity.causality",                                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Causality                                                                                      // MakerGen.cs:259
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
                        Instance.Write(sDef);                                                                                               // MakerGen.cs:220
                        Causality.Write(sDef);                                                                                              // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_SuspectEntity_Elements Elements                                                                                 // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_SuspectEntity_Elements();                                                              // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_SuspectEntity_Elements elements;                                                                                       // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_SuspectEntity()                                                                                                 // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "AdverseEvent.suspectEntity",                                                                                // MakerGen.cs:428
                        ElementId = "AdverseEvent.suspectEntity"                                                                            // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. AdverseEvent.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 2. AdverseEvent.actuality
            public ElementDefinitionInfo Actuality;                                                                                         // MakerGen.cs:216
            // 3. AdverseEvent.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:216
            // 4. AdverseEvent.event
            public ElementDefinitionInfo Event;                                                                                             // MakerGen.cs:216
            // 5. AdverseEvent.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 6. AdverseEvent.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:216
            // 7. AdverseEvent.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:216
            // 8. AdverseEvent.detected
            public ElementDefinitionInfo Detected;                                                                                          // MakerGen.cs:216
            // 9. AdverseEvent.recordedDate
            public ElementDefinitionInfo RecordedDate;                                                                                      // MakerGen.cs:216
            // 10. AdverseEvent.resultingCondition
            public ElementDefinitionInfo ResultingCondition;                                                                                // MakerGen.cs:216
            // 11. AdverseEvent.location
            public ElementDefinitionInfo Location;                                                                                          // MakerGen.cs:216
            // 12. AdverseEvent.seriousness
            public ElementDefinitionInfo Seriousness;                                                                                       // MakerGen.cs:216
            // 13. AdverseEvent.severity
            public ElementDefinitionInfo Severity;                                                                                          // MakerGen.cs:216
            // 14. AdverseEvent.outcome
            public ElementDefinitionInfo Outcome;                                                                                           // MakerGen.cs:216
            // 15. AdverseEvent.recorder
            public ElementDefinitionInfo Recorder;                                                                                          // MakerGen.cs:216
            // 16. AdverseEvent.contributor
            public ElementDefinitionInfo Contributor;                                                                                       // MakerGen.cs:216
            // 17. AdverseEvent.suspectEntity
            public ElementDefinitionInfo SuspectEntity;                                                                                     // MakerGen.cs:216
            // 24. AdverseEvent.subjectMedicalHistory
            public ElementDefinitionInfo SubjectMedicalHistory;                                                                             // MakerGen.cs:216
            // 25. AdverseEvent.referenceDocument
            public ElementDefinitionInfo ReferenceDocument;                                                                                 // MakerGen.cs:216
            // 26. AdverseEvent.study
            public ElementDefinitionInfo Study;                                                                                             // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public AdverseEvent_Elements()                                                                                                  // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. AdverseEvent.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "AdverseEvent.identifier",                                                                                    // MakerGen.cs:236
                        Id = "AdverseEvent.identifier",                                                                                     // MakerGen.cs:237
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
                    // 2. AdverseEvent.actuality
                    this.Actuality = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Actuality",                                                                                                 // MakerGen.cs:235
                        Path= "AdverseEvent.actuality",                                                                                     // MakerGen.cs:236
                        Id = "AdverseEvent.actuality",                                                                                      // MakerGen.cs:237
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
                    // 3. AdverseEvent.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Category",                                                                                                  // MakerGen.cs:235
                        Path= "AdverseEvent.category",                                                                                      // MakerGen.cs:236
                        Id = "AdverseEvent.category",                                                                                       // MakerGen.cs:237
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
                    // 4. AdverseEvent.event
                    this.Event = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Event",                                                                                                     // MakerGen.cs:235
                        Path= "AdverseEvent.event",                                                                                         // MakerGen.cs:236
                        Id = "AdverseEvent.event",                                                                                          // MakerGen.cs:237
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
                    // 5. AdverseEvent.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "AdverseEvent.subject",                                                                                       // MakerGen.cs:236
                        Id = "AdverseEvent.subject",                                                                                        // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Group",                                                        // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. AdverseEvent.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Encounter",                                                                                                 // MakerGen.cs:235
                        Path= "AdverseEvent.encounter",                                                                                     // MakerGen.cs:236
                        Id = "AdverseEvent.encounter",                                                                                      // MakerGen.cs:237
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
                    // 7. AdverseEvent.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Date",                                                                                                      // MakerGen.cs:235
                        Path= "AdverseEvent.date",                                                                                          // MakerGen.cs:236
                        Id = "AdverseEvent.date",                                                                                           // MakerGen.cs:237
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
                    // 8. AdverseEvent.detected
                    this.Detected = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Detected",                                                                                                  // MakerGen.cs:235
                        Path= "AdverseEvent.detected",                                                                                      // MakerGen.cs:236
                        Id = "AdverseEvent.detected",                                                                                       // MakerGen.cs:237
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
                    // 9. AdverseEvent.recordedDate
                    this.RecordedDate = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "RecordedDate",                                                                                              // MakerGen.cs:235
                        Path= "AdverseEvent.recordedDate",                                                                                  // MakerGen.cs:236
                        Id = "AdverseEvent.recordedDate",                                                                                   // MakerGen.cs:237
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
                    // 10. AdverseEvent.resultingCondition
                    this.ResultingCondition = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ResultingCondition",                                                                                        // MakerGen.cs:235
                        Path= "AdverseEvent.resultingCondition",                                                                            // MakerGen.cs:236
                        Id = "AdverseEvent.resultingCondition",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition"                                                     // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. AdverseEvent.location
                    this.Location = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Location",                                                                                                  // MakerGen.cs:235
                        Path= "AdverseEvent.location",                                                                                      // MakerGen.cs:236
                        Id = "AdverseEvent.location",                                                                                       // MakerGen.cs:237
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
                    // 12. AdverseEvent.seriousness
                    this.Seriousness = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Seriousness",                                                                                               // MakerGen.cs:235
                        Path= "AdverseEvent.seriousness",                                                                                   // MakerGen.cs:236
                        Id = "AdverseEvent.seriousness",                                                                                    // MakerGen.cs:237
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
                    // 13. AdverseEvent.severity
                    this.Severity = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Severity",                                                                                                  // MakerGen.cs:235
                        Path= "AdverseEvent.severity",                                                                                      // MakerGen.cs:236
                        Id = "AdverseEvent.severity",                                                                                       // MakerGen.cs:237
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
                    // 14. AdverseEvent.outcome
                    this.Outcome = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Outcome",                                                                                                   // MakerGen.cs:235
                        Path= "AdverseEvent.outcome",                                                                                       // MakerGen.cs:236
                        Id = "AdverseEvent.outcome",                                                                                        // MakerGen.cs:237
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
                    // 15. AdverseEvent.recorder
                    this.Recorder = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Recorder",                                                                                                  // MakerGen.cs:235
                        Path= "AdverseEvent.recorder",                                                                                      // MakerGen.cs:236
                        Id = "AdverseEvent.recorder",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 16. AdverseEvent.contributor
                    this.Contributor = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Contributor",                                                                                               // MakerGen.cs:235
                        Path= "AdverseEvent.contributor",                                                                                   // MakerGen.cs:236
                        Id = "AdverseEvent.contributor",                                                                                    // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 17. AdverseEvent.suspectEntity
                    this.SuspectEntity = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SuspectEntity",                                                                                             // MakerGen.cs:235
                        Path= "AdverseEvent.suspectEntity",                                                                                 // MakerGen.cs:236
                        Id = "AdverseEvent.suspectEntity",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_SuspectEntity                                                                                          // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 24. AdverseEvent.subjectMedicalHistory
                    this.SubjectMedicalHistory = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SubjectMedicalHistory",                                                                                     // MakerGen.cs:235
                        Path= "AdverseEvent.subjectMedicalHistory",                                                                         // MakerGen.cs:236
                        Id = "AdverseEvent.subjectMedicalHistory",                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance",                                           // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory",                                          // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Immunization",                                                 // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Procedure",                                                    // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/Media",                                                        // MakerGen.cs:349
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 25. AdverseEvent.referenceDocument
                    this.ReferenceDocument = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ReferenceDocument",                                                                                         // MakerGen.cs:235
                        Path= "AdverseEvent.referenceDocument",                                                                             // MakerGen.cs:236
                        Id = "AdverseEvent.referenceDocument",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 26. AdverseEvent.study
                    this.Study = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Study",                                                                                                     // MakerGen.cs:235
                        Path= "AdverseEvent.study",                                                                                         // MakerGen.cs:236
                        Id = "AdverseEvent.study",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ResearchStudy"                                                 // MakerGen.cs:349
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
                Actuality.Write(sDef);                                                                                                      // MakerGen.cs:220
                Category.Write(sDef);                                                                                                       // MakerGen.cs:220
                Event.Write(sDef);                                                                                                          // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:220
                Date.Write(sDef);                                                                                                           // MakerGen.cs:220
                Detected.Write(sDef);                                                                                                       // MakerGen.cs:220
                RecordedDate.Write(sDef);                                                                                                   // MakerGen.cs:220
                ResultingCondition.Write(sDef);                                                                                             // MakerGen.cs:220
                Location.Write(sDef);                                                                                                       // MakerGen.cs:220
                Seriousness.Write(sDef);                                                                                                    // MakerGen.cs:220
                Severity.Write(sDef);                                                                                                       // MakerGen.cs:220
                Outcome.Write(sDef);                                                                                                        // MakerGen.cs:220
                Recorder.Write(sDef);                                                                                                       // MakerGen.cs:220
                Contributor.Write(sDef);                                                                                                    // MakerGen.cs:220
                SuspectEntity.Write(sDef);                                                                                                  // MakerGen.cs:220
                SubjectMedicalHistory.Write(sDef);                                                                                          // MakerGen.cs:220
                ReferenceDocument.Write(sDef);                                                                                              // MakerGen.cs:220
                Study.Write(sDef);                                                                                                          // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public AdverseEvent_Elements Elements                                                                                               // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new AdverseEvent_Elements();                                                                            // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        AdverseEvent_Elements elements;                                                                                                     // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public AdverseEvent()                                                                                                               // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "AdverseEvent";                                                                                                     // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/AdverseEvent";                                                              // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "AdverseEvent",                                                                                                      // MakerGen.cs:428
                ElementId = "AdverseEvent"                                                                                                  // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
