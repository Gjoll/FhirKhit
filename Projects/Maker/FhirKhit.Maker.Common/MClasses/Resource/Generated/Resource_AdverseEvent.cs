using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'AdverseEvent'
    /// </summary>
    // 0. AdverseEvent
    public class Resource_AdverseEvent : FhirKhit.Maker.Common.Resource.ResourceBase                                                        // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 17. AdverseEvent.suspectEntity
        public class Type_SuspectEntity : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 19. AdverseEvent.suspectEntity.causality
            public class Type_Causality : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 20. AdverseEvent.suspectEntity.causality.assessment
                public ElementDefinitionInfo Element_Assessment;                                                                            // MakerGen.cs:212
                // 21. AdverseEvent.suspectEntity.causality.productRelatedness
                public ElementDefinitionInfo Element_ProductRelatedness;                                                                    // MakerGen.cs:212
                // 22. AdverseEvent.suspectEntity.causality.author
                public ElementDefinitionInfo Element_Author;                                                                                // MakerGen.cs:212
                // 23. AdverseEvent.suspectEntity.causality.method
                public ElementDefinitionInfo Element_Method;                                                                                // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "AdverseEvent.suspectEntity.causality",                                                                      // MakerGen.cs:388
                        ElementId = "AdverseEvent.suspectEntity.causality"                                                                  // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Assessment.Write(sDef);                                                                                         // MakerGen.cs:216
                    Element_ProductRelatedness.Write(sDef);                                                                                 // MakerGen.cs:216
                    Element_Author.Write(sDef);                                                                                             // MakerGen.cs:216
                    Element_Method.Write(sDef);                                                                                             // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_Causality()                                                                                                     // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 20. AdverseEvent.suspectEntity.causality.assessment
                        this.Element_Assessment = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Assessment",                                                                                    // MakerGen.cs:231
                            Path= "AdverseEvent.suspectEntity.causality.assessment",                                                        // MakerGen.cs:232
                            Id = "AdverseEvent.suspectEntity.causality.assessment",                                                         // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 21. AdverseEvent.suspectEntity.causality.productRelatedness
                        this.Element_ProductRelatedness = new ElementDefinitionInfo                                                         // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_ProductRelatedness",                                                                            // MakerGen.cs:231
                            Path= "AdverseEvent.suspectEntity.causality.productRelatedness",                                                // MakerGen.cs:232
                            Id = "AdverseEvent.suspectEntity.causality.productRelatedness",                                                 // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 22. AdverseEvent.suspectEntity.causality.author
                        this.Element_Author = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Author",                                                                                        // MakerGen.cs:231
                            Path= "AdverseEvent.suspectEntity.causality.author",                                                            // MakerGen.cs:232
                            Id = "AdverseEvent.suspectEntity.causality.author",                                                             // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_Reference                                                            // MakerGen.cs:339
                                {                                                                                                           // MakerGen.cs:340
                                    TargetProfile = new String[]                                                                            // MakerGen.cs:342
                                    {                                                                                                       // CodeEditorExtensions.cs:28
                                        "http://hl7.org/fhir/StructureDefinition/Practitioner",                                             // MakerGen.cs:342
                                        "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                          // MakerGen.cs:342
                                    }                                                                                                       // CodeEditorExtensions.cs:34
                                }                                                                                                           // MakerGen.cs:343
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 23. AdverseEvent.suspectEntity.causality.method
                        this.Element_Method = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Method",                                                                                        // MakerGen.cs:231
                            Path= "AdverseEvent.suspectEntity.causality.method",                                                            // MakerGen.cs:232
                            Id = "AdverseEvent.suspectEntity.causality.method",                                                             // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 18. AdverseEvent.suspectEntity.instance
            public ElementDefinitionInfo Element_Instance;                                                                                  // MakerGen.cs:212
            // 19. AdverseEvent.suspectEntity.causality
            public ElementDefinitionInfo Element_Causality;                                                                                 // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "AdverseEvent.suspectEntity",                                                                                    // MakerGen.cs:388
                    ElementId = "AdverseEvent.suspectEntity"                                                                                // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Instance.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Causality.Write(sDef);                                                                                              // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_SuspectEntity()                                                                                                     // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 18. AdverseEvent.suspectEntity.instance
                    this.Element_Instance = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Instance",                                                                                          // MakerGen.cs:231
                        Path= "AdverseEvent.suspectEntity.instance",                                                                        // MakerGen.cs:232
                        Id = "AdverseEvent.suspectEntity.instance",                                                                         // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Immunization",                                                 // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Procedure",                                                    // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Substance",                                                    // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Medication",                                                   // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",                                     // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/MedicationStatement",                                          // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/Device"                                                        // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 19. AdverseEvent.suspectEntity.causality
                    this.Element_Causality = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Causality",                                                                                         // MakerGen.cs:231
                        Path= "AdverseEvent.suspectEntity.causality",                                                                       // MakerGen.cs:232
                        Id = "AdverseEvent.suspectEntity.causality",                                                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_Causality                                                                                              // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. AdverseEvent.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. AdverseEvent.actuality
        public ElementDefinitionInfo Element_Actuality;                                                                                     // MakerGen.cs:212
        // 3. AdverseEvent.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:212
        // 4. AdverseEvent.event
        public ElementDefinitionInfo Element_Event;                                                                                         // MakerGen.cs:212
        // 5. AdverseEvent.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:212
        // 6. AdverseEvent.encounter
        public ElementDefinitionInfo Element_Encounter;                                                                                     // MakerGen.cs:212
        // 7. AdverseEvent.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:212
        // 8. AdverseEvent.detected
        public ElementDefinitionInfo Element_Detected;                                                                                      // MakerGen.cs:212
        // 9. AdverseEvent.recordedDate
        public ElementDefinitionInfo Element_RecordedDate;                                                                                  // MakerGen.cs:212
        // 10. AdverseEvent.resultingCondition
        public ElementDefinitionInfo Element_ResultingCondition;                                                                            // MakerGen.cs:212
        // 11. AdverseEvent.location
        public ElementDefinitionInfo Element_Location;                                                                                      // MakerGen.cs:212
        // 12. AdverseEvent.seriousness
        public ElementDefinitionInfo Element_Seriousness;                                                                                   // MakerGen.cs:212
        // 13. AdverseEvent.severity
        public ElementDefinitionInfo Element_Severity;                                                                                      // MakerGen.cs:212
        // 14. AdverseEvent.outcome
        public ElementDefinitionInfo Element_Outcome;                                                                                       // MakerGen.cs:212
        // 15. AdverseEvent.recorder
        public ElementDefinitionInfo Element_Recorder;                                                                                      // MakerGen.cs:212
        // 16. AdverseEvent.contributor
        public ElementDefinitionInfo Element_Contributor;                                                                                   // MakerGen.cs:212
        // 17. AdverseEvent.suspectEntity
        public ElementDefinitionInfo Element_SuspectEntity;                                                                                 // MakerGen.cs:212
        // 24. AdverseEvent.subjectMedicalHistory
        public ElementDefinitionInfo Element_SubjectMedicalHistory;                                                                         // MakerGen.cs:212
        // 25. AdverseEvent.referenceDocument
        public ElementDefinitionInfo Element_ReferenceDocument;                                                                             // MakerGen.cs:212
        // 26. AdverseEvent.study
        public ElementDefinitionInfo Element_Study;                                                                                         // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "AdverseEvent",                                                                                                      // MakerGen.cs:388
                ElementId = "AdverseEvent"                                                                                                  // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Actuality.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Event.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Encounter.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Date.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Detected.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_RecordedDate.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_ResultingCondition.Write(sDef);                                                                                         // MakerGen.cs:216
            Element_Location.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Seriousness.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Severity.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Outcome.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Recorder.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Contributor.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_SuspectEntity.Write(sDef);                                                                                              // MakerGen.cs:216
            Element_SubjectMedicalHistory.Write(sDef);                                                                                      // MakerGen.cs:216
            Element_ReferenceDocument.Write(sDef);                                                                                          // MakerGen.cs:216
            Element_Study.Write(sDef);                                                                                                      // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_AdverseEvent()                                                                                                      // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. AdverseEvent.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "AdverseEvent.identifier",                                                                                        // MakerGen.cs:232
                    Id = "AdverseEvent.identifier",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. AdverseEvent.actuality
                this.Element_Actuality = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Actuality",                                                                                             // MakerGen.cs:231
                    Path= "AdverseEvent.actuality",                                                                                         // MakerGen.cs:232
                    Id = "AdverseEvent.actuality",                                                                                          // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. AdverseEvent.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Category",                                                                                              // MakerGen.cs:231
                    Path= "AdverseEvent.category",                                                                                          // MakerGen.cs:232
                    Id = "AdverseEvent.category",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. AdverseEvent.event
                this.Element_Event = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Event",                                                                                                 // MakerGen.cs:231
                    Path= "AdverseEvent.event",                                                                                             // MakerGen.cs:232
                    Id = "AdverseEvent.event",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. AdverseEvent.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:231
                    Path= "AdverseEvent.subject",                                                                                           // MakerGen.cs:232
                    Id = "AdverseEvent.subject",                                                                                            // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Group",                                                            // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                     // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. AdverseEvent.encounter
                this.Element_Encounter = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:231
                    Path= "AdverseEvent.encounter",                                                                                         // MakerGen.cs:232
                    Id = "AdverseEvent.encounter",                                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. AdverseEvent.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:231
                    Path= "AdverseEvent.date",                                                                                              // MakerGen.cs:232
                    Id = "AdverseEvent.date",                                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. AdverseEvent.detected
                this.Element_Detected = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Detected",                                                                                              // MakerGen.cs:231
                    Path= "AdverseEvent.detected",                                                                                          // MakerGen.cs:232
                    Id = "AdverseEvent.detected",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 9. AdverseEvent.recordedDate
                this.Element_RecordedDate = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_RecordedDate",                                                                                          // MakerGen.cs:231
                    Path= "AdverseEvent.recordedDate",                                                                                      // MakerGen.cs:232
                    Id = "AdverseEvent.recordedDate",                                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. AdverseEvent.resultingCondition
                this.Element_ResultingCondition = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ResultingCondition",                                                                                    // MakerGen.cs:231
                    Path= "AdverseEvent.resultingCondition",                                                                                // MakerGen.cs:232
                    Id = "AdverseEvent.resultingCondition",                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Condition"                                                         // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. AdverseEvent.location
                this.Element_Location = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Location",                                                                                              // MakerGen.cs:231
                    Path= "AdverseEvent.location",                                                                                          // MakerGen.cs:232
                    Id = "AdverseEvent.location",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Location"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. AdverseEvent.seriousness
                this.Element_Seriousness = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Seriousness",                                                                                           // MakerGen.cs:231
                    Path= "AdverseEvent.seriousness",                                                                                       // MakerGen.cs:232
                    Id = "AdverseEvent.seriousness",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. AdverseEvent.severity
                this.Element_Severity = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Severity",                                                                                              // MakerGen.cs:231
                    Path= "AdverseEvent.severity",                                                                                          // MakerGen.cs:232
                    Id = "AdverseEvent.severity",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 14. AdverseEvent.outcome
                this.Element_Outcome = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Outcome",                                                                                               // MakerGen.cs:231
                    Path= "AdverseEvent.outcome",                                                                                           // MakerGen.cs:232
                    Id = "AdverseEvent.outcome",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 15. AdverseEvent.recorder
                this.Element_Recorder = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Recorder",                                                                                              // MakerGen.cs:231
                    Path= "AdverseEvent.recorder",                                                                                          // MakerGen.cs:232
                    Id = "AdverseEvent.recorder",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                     // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 16. AdverseEvent.contributor
                this.Element_Contributor = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Contributor",                                                                                           // MakerGen.cs:231
                    Path= "AdverseEvent.contributor",                                                                                       // MakerGen.cs:232
                    Id = "AdverseEvent.contributor",                                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Device"                                                            // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 17. AdverseEvent.suspectEntity
                this.Element_SuspectEntity = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_SuspectEntity",                                                                                         // MakerGen.cs:231
                    Path= "AdverseEvent.suspectEntity",                                                                                     // MakerGen.cs:232
                    Id = "AdverseEvent.suspectEntity",                                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_SuspectEntity                                                                                              // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 24. AdverseEvent.subjectMedicalHistory
                this.Element_SubjectMedicalHistory = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_SubjectMedicalHistory",                                                                                 // MakerGen.cs:231
                    Path= "AdverseEvent.subjectMedicalHistory",                                                                             // MakerGen.cs:232
                    Id = "AdverseEvent.subjectMedicalHistory",                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Condition",                                                        // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Observation",                                                      // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance",                                               // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory",                                              // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Immunization",                                                     // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Procedure",                                                        // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/Media",                                                            // MakerGen.cs:342
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                                 // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 25. AdverseEvent.referenceDocument
                this.Element_ReferenceDocument = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ReferenceDocument",                                                                                     // MakerGen.cs:231
                    Path= "AdverseEvent.referenceDocument",                                                                                 // MakerGen.cs:232
                    Id = "AdverseEvent.referenceDocument",                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                                 // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 26. AdverseEvent.study
                this.Element_Study = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Study",                                                                                                 // MakerGen.cs:231
                    Path= "AdverseEvent.study",                                                                                             // MakerGen.cs:232
                    Id = "AdverseEvent.study",                                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ResearchStudy"                                                     // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "AdverseEvent";                                                                                                     // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/AdverseEvent";                                                              // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
