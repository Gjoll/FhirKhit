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
    #endregion
    /// <summary>
    /// Fhir resource 'AdverseEvent'
    /// </summary>
    // 0. AdverseEvent
    public partial class Resource_AdverseEvent : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 17. AdverseEvent.suspectEntity
        public partial class Type_SuspectEntity : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 19. AdverseEvent.suspectEntity.causality
            public partial class Type_Causality : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 20. AdverseEvent.suspectEntity.causality.assessment
                public ElementDefinitionInfo Element_Assessment;
                // 21. AdverseEvent.suspectEntity.causality.productRelatedness
                public ElementDefinitionInfo Element_ProductRelatedness;
                // 22. AdverseEvent.suspectEntity.causality.author
                public ElementDefinitionInfo Element_Author;
                // 23. AdverseEvent.suspectEntity.causality.method
                public ElementDefinitionInfo Element_Method;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "AdverseEvent.suspectEntity.causality",
                        ElementId = "AdverseEvent.suspectEntity.causality"
                    });
                    Element_Assessment.Write(sDef);
                    Element_ProductRelatedness.Write(sDef);
                    Element_Author.Write(sDef);
                    Element_Method.Write(sDef);
                }
                
                public Type_Causality()
                {
                    {
                        // 20. AdverseEvent.suspectEntity.causality.assessment
                        this.Element_Assessment = new ElementDefinitionInfo
                        {
                            Name = "Element_Assessment",
                            Path= "AdverseEvent.suspectEntity.causality.assessment",
                            Id = "AdverseEvent.suspectEntity.causality.assessment",
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
                        // 21. AdverseEvent.suspectEntity.causality.productRelatedness
                        this.Element_ProductRelatedness = new ElementDefinitionInfo
                        {
                            Name = "Element_ProductRelatedness",
                            Path= "AdverseEvent.suspectEntity.causality.productRelatedness",
                            Id = "AdverseEvent.suspectEntity.causality.productRelatedness",
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
                        // 22. AdverseEvent.suspectEntity.causality.author
                        this.Element_Author = new ElementDefinitionInfo
                        {
                            Name = "Element_Author",
                            Path= "AdverseEvent.suspectEntity.causality.author",
                            Id = "AdverseEvent.suspectEntity.causality.author",
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
                        // 23. AdverseEvent.suspectEntity.causality.method
                        this.Element_Method = new ElementDefinitionInfo
                        {
                            Name = "Element_Method",
                            Path= "AdverseEvent.suspectEntity.causality.method",
                            Id = "AdverseEvent.suspectEntity.causality.method",
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
            // 18. AdverseEvent.suspectEntity.instance
            public ElementDefinitionInfo Element_Instance;
            // 19. AdverseEvent.suspectEntity.causality
            public ElementDefinitionInfo Element_Causality;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "AdverseEvent.suspectEntity",
                    ElementId = "AdverseEvent.suspectEntity"
                });
                Element_Instance.Write(sDef);
                Element_Causality.Write(sDef);
            }
            
            public Type_SuspectEntity()
            {
                {
                    // 18. AdverseEvent.suspectEntity.instance
                    this.Element_Instance = new ElementDefinitionInfo
                    {
                        Name = "Element_Instance",
                        Path= "AdverseEvent.suspectEntity.instance",
                        Id = "AdverseEvent.suspectEntity.instance",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Immunization",
                                    "http://hl7.org/fhir/StructureDefinition/Procedure",
                                    "http://hl7.org/fhir/StructureDefinition/Substance",
                                    "http://hl7.org/fhir/StructureDefinition/Medication",
                                    "http://hl7.org/fhir/StructureDefinition/MedicationAdministration",
                                    "http://hl7.org/fhir/StructureDefinition/MedicationStatement",
                                    "http://hl7.org/fhir/StructureDefinition/Device"
                                }
                            }
                        }
                    };
                }
                {
                    // 19. AdverseEvent.suspectEntity.causality
                    this.Element_Causality = new ElementDefinitionInfo
                    {
                        Name = "Element_Causality",
                        Path= "AdverseEvent.suspectEntity.causality",
                        Id = "AdverseEvent.suspectEntity.causality",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Causality
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. AdverseEvent.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. AdverseEvent.actuality
        public ElementDefinitionInfo Element_Actuality;
        // 3. AdverseEvent.category
        public ElementDefinitionInfo Element_Category;
        // 4. AdverseEvent.event
        public ElementDefinitionInfo Element_Event;
        // 5. AdverseEvent.subject
        public ElementDefinitionInfo Element_Subject;
        // 6. AdverseEvent.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 7. AdverseEvent.date
        public ElementDefinitionInfo Element_Date;
        // 8. AdverseEvent.detected
        public ElementDefinitionInfo Element_Detected;
        // 9. AdverseEvent.recordedDate
        public ElementDefinitionInfo Element_RecordedDate;
        // 10. AdverseEvent.resultingCondition
        public ElementDefinitionInfo Element_ResultingCondition;
        // 11. AdverseEvent.location
        public ElementDefinitionInfo Element_Location;
        // 12. AdverseEvent.seriousness
        public ElementDefinitionInfo Element_Seriousness;
        // 13. AdverseEvent.severity
        public ElementDefinitionInfo Element_Severity;
        // 14. AdverseEvent.outcome
        public ElementDefinitionInfo Element_Outcome;
        // 15. AdverseEvent.recorder
        public ElementDefinitionInfo Element_Recorder;
        // 16. AdverseEvent.contributor
        public ElementDefinitionInfo Element_Contributor;
        // 17. AdverseEvent.suspectEntity
        public ElementDefinitionInfo Element_SuspectEntity;
        // 24. AdverseEvent.subjectMedicalHistory
        public ElementDefinitionInfo Element_SubjectMedicalHistory;
        // 25. AdverseEvent.referenceDocument
        public ElementDefinitionInfo Element_ReferenceDocument;
        // 26. AdverseEvent.study
        public ElementDefinitionInfo Element_Study;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "AdverseEvent",
                ElementId = "AdverseEvent"
            });
            Element_Identifier.Write(sDef);
            Element_Actuality.Write(sDef);
            Element_Category.Write(sDef);
            Element_Event.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Date.Write(sDef);
            Element_Detected.Write(sDef);
            Element_RecordedDate.Write(sDef);
            Element_ResultingCondition.Write(sDef);
            Element_Location.Write(sDef);
            Element_Seriousness.Write(sDef);
            Element_Severity.Write(sDef);
            Element_Outcome.Write(sDef);
            Element_Recorder.Write(sDef);
            Element_Contributor.Write(sDef);
            Element_SuspectEntity.Write(sDef);
            Element_SubjectMedicalHistory.Write(sDef);
            Element_ReferenceDocument.Write(sDef);
            Element_Study.Write(sDef);
        }
        
        public Resource_AdverseEvent()
        {
            {
                // 1. AdverseEvent.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "AdverseEvent.identifier",
                    Id = "AdverseEvent.identifier",
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
                // 2. AdverseEvent.actuality
                this.Element_Actuality = new ElementDefinitionInfo
                {
                    Name = "Element_Actuality",
                    Path= "AdverseEvent.actuality",
                    Id = "AdverseEvent.actuality",
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
                // 3. AdverseEvent.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "AdverseEvent.category",
                    Id = "AdverseEvent.category",
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
                // 4. AdverseEvent.event
                this.Element_Event = new ElementDefinitionInfo
                {
                    Name = "Element_Event",
                    Path= "AdverseEvent.event",
                    Id = "AdverseEvent.event",
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
                // 5. AdverseEvent.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "AdverseEvent.subject",
                    Id = "AdverseEvent.subject",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Group",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                            }
                        }
                    }
                };
            }
            {
                // 6. AdverseEvent.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "AdverseEvent.encounter",
                    Id = "AdverseEvent.encounter",
                    Min = 0,
                    Max = 1,
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
                // 7. AdverseEvent.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "AdverseEvent.date",
                    Id = "AdverseEvent.date",
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
                // 8. AdverseEvent.detected
                this.Element_Detected = new ElementDefinitionInfo
                {
                    Name = "Element_Detected",
                    Path= "AdverseEvent.detected",
                    Id = "AdverseEvent.detected",
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
                // 9. AdverseEvent.recordedDate
                this.Element_RecordedDate = new ElementDefinitionInfo
                {
                    Name = "Element_RecordedDate",
                    Path= "AdverseEvent.recordedDate",
                    Id = "AdverseEvent.recordedDate",
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
                // 10. AdverseEvent.resultingCondition
                this.Element_ResultingCondition = new ElementDefinitionInfo
                {
                    Name = "Element_ResultingCondition",
                    Path= "AdverseEvent.resultingCondition",
                    Id = "AdverseEvent.resultingCondition",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
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
                // 11. AdverseEvent.location
                this.Element_Location = new ElementDefinitionInfo
                {
                    Name = "Element_Location",
                    Path= "AdverseEvent.location",
                    Id = "AdverseEvent.location",
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
                // 12. AdverseEvent.seriousness
                this.Element_Seriousness = new ElementDefinitionInfo
                {
                    Name = "Element_Seriousness",
                    Path= "AdverseEvent.seriousness",
                    Id = "AdverseEvent.seriousness",
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
                // 13. AdverseEvent.severity
                this.Element_Severity = new ElementDefinitionInfo
                {
                    Name = "Element_Severity",
                    Path= "AdverseEvent.severity",
                    Id = "AdverseEvent.severity",
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
                // 14. AdverseEvent.outcome
                this.Element_Outcome = new ElementDefinitionInfo
                {
                    Name = "Element_Outcome",
                    Path= "AdverseEvent.outcome",
                    Id = "AdverseEvent.outcome",
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
                // 15. AdverseEvent.recorder
                this.Element_Recorder = new ElementDefinitionInfo
                {
                    Name = "Element_Recorder",
                    Path= "AdverseEvent.recorder",
                    Id = "AdverseEvent.recorder",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                            }
                        }
                    }
                };
            }
            {
                // 16. AdverseEvent.contributor
                this.Element_Contributor = new ElementDefinitionInfo
                {
                    Name = "Element_Contributor",
                    Path= "AdverseEvent.contributor",
                    Id = "AdverseEvent.contributor",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Device"
                            }
                        }
                    }
                };
            }
            {
                // 17. AdverseEvent.suspectEntity
                this.Element_SuspectEntity = new ElementDefinitionInfo
                {
                    Name = "Element_SuspectEntity",
                    Path= "AdverseEvent.suspectEntity",
                    Id = "AdverseEvent.suspectEntity",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_SuspectEntity
                        {
                        }
                    }
                };
            }
            {
                // 24. AdverseEvent.subjectMedicalHistory
                this.Element_SubjectMedicalHistory = new ElementDefinitionInfo
                {
                    Name = "Element_SubjectMedicalHistory",
                    Path= "AdverseEvent.subjectMedicalHistory",
                    Id = "AdverseEvent.subjectMedicalHistory",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Condition",
                                "http://hl7.org/fhir/StructureDefinition/Observation",
                                "http://hl7.org/fhir/StructureDefinition/AllergyIntolerance",
                                "http://hl7.org/fhir/StructureDefinition/FamilyMemberHistory",
                                "http://hl7.org/fhir/StructureDefinition/Immunization",
                                "http://hl7.org/fhir/StructureDefinition/Procedure",
                                "http://hl7.org/fhir/StructureDefinition/Media",
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                            }
                        }
                    }
                };
            }
            {
                // 25. AdverseEvent.referenceDocument
                this.Element_ReferenceDocument = new ElementDefinitionInfo
                {
                    Name = "Element_ReferenceDocument",
                    Path= "AdverseEvent.referenceDocument",
                    Id = "AdverseEvent.referenceDocument",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                            }
                        }
                    }
                };
            }
            {
                // 26. AdverseEvent.study
                this.Element_Study = new ElementDefinitionInfo
                {
                    Name = "Element_Study",
                    Path= "AdverseEvent.study",
                    Id = "AdverseEvent.study",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ResearchStudy"
                            }
                        }
                    }
                };
            }
            this.Name = "AdverseEvent";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/AdverseEvent";
        }
    }
}
