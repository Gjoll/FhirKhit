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
      "id": "RiskAssessment",
      "url": "http://hl7.org/fhir/StructureDefinition/RiskAssessment",
      "version": "4.0.0",
      "name": "RiskAssessment",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Decision Support)",
      "description": "An assessment of the likely outcome(s) for a patient or other subject as well as the likelihood of each outcome.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "RiskAssessment",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "RiskAssessment",
            "path": "RiskAssessment",
            "short": "Potential outcomes for a subject with likelihood",
            "definition": "An assessment of the likely outcome(s) for a patient or other subject as well as the likelihood of each outcome.",
            "alias": [
              "Prognosis"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "RiskAssessment.identifier",
            "path": "RiskAssessment.identifier",
            "short": "Unique identifier for the assessment",
            "definition": "Business identifier assigned to the risk assessment.",
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
            "id": "RiskAssessment.basedOn",
            "path": "RiskAssessment.basedOn",
            "short": "Request fulfilled by this assessment",
            "definition": "A reference to the request that is fulfilled by this risk assessment.",
            "min": 0,
            "max": "1",
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
            "id": "RiskAssessment.parent",
            "path": "RiskAssessment.parent",
            "short": "Part of this occurrence",
            "definition": "A reference to a resource that this risk assessment is part of, such as a Procedure.",
            "min": 0,
            "max": "1",
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
            "id": "RiskAssessment.status",
            "path": "RiskAssessment.status",
            "short": "registered | preliminary | final | amended +",
            "definition": "The status of the RiskAssessment, using the same statuses as an Observation.",
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
                  "valueString": "RiskAssessmentStatus"
                }
              ],
              "strength": "required",
              "description": "The status of the risk assessment; e.g. preliminary, final, amended, etc.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-status|4.0.0"
            }
          },
          {
            "id": "RiskAssessment.method",
            "path": "RiskAssessment.method",
            "short": "Evaluation mechanism",
            "definition": "The algorithm, process or mechanism used to evaluate the risk.",
            "requirements": "The method can influence the results of the assessment.",
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
                  "valueString": "RiskAssessmentMethod"
                }
              ],
              "strength": "example",
              "description": "The mechanism or algorithm used to make the assessment; e.g. TIMI, PRISM, Cardiff Type 2 diabetes, etc."
            }
          },
          {
            "id": "RiskAssessment.code",
            "path": "RiskAssessment.code",
            "short": "Type of assessment",
            "definition": "The type of the risk assessment performed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RiskAssessment.subject",
            "path": "RiskAssessment.subject",
            "short": "Who/what does assessment apply to?",
            "definition": "The patient or group the risk assessment applies to.",
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
            "id": "RiskAssessment.encounter",
            "path": "RiskAssessment.encounter",
            "short": "Where was assessment performed?",
            "definition": "The encounter where the assessment was performed.",
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
            "id": "RiskAssessment.occurrence[x]",
            "path": "RiskAssessment.occurrence[x]",
            "short": "When was assessment made?",
            "definition": "The date (and possibly time) the risk assessment was performed.",
            "requirements": "The assessment results lose validity the more time elapses from when they are first made.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RiskAssessment.condition",
            "path": "RiskAssessment.condition",
            "short": "Condition assessed",
            "definition": "For assessments or prognosis specific to a particular condition, indicates the condition being assessed.",
            "min": 0,
            "max": "1",
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
            "id": "RiskAssessment.performer",
            "path": "RiskAssessment.performer",
            "short": "Who did assessment?",
            "definition": "The provider or software application that performed the assessment.",
            "min": 0,
            "max": "1",
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
            "id": "RiskAssessment.reasonCode",
            "path": "RiskAssessment.reasonCode",
            "short": "Why the assessment was necessary?",
            "definition": "The reason the risk assessment was performed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "RiskAssessment.reasonReference",
            "path": "RiskAssessment.reasonReference",
            "short": "Why the assessment was necessary?",
            "definition": "Resources supporting the reason the risk assessment was performed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ]
          },
          {
            "id": "RiskAssessment.basis",
            "path": "RiskAssessment.basis",
            "short": "Information used in assessment",
            "definition": "Indicates the source data considered as part of the assessment (for example, FamilyHistory, Observations, Procedures, Conditions, etc.).",
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
            "id": "RiskAssessment.prediction",
            "path": "RiskAssessment.prediction",
            "short": "Outcome predicted",
            "definition": "Describes the expected outcome for the subject.",
            "comment": "Multiple repetitions can be used to identify the same type of outcome in different timeframes as well as different types of outcomes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "RiskAssessment.prediction.outcome",
            "path": "RiskAssessment.prediction.outcome",
            "short": "Possible outcome for the subject",
            "definition": "One of the potential outcomes for the patient (e.g. remission, death,  a particular condition).",
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
                  "valueString": "RiskAssessmentOutcome"
                }
              ],
              "strength": "example",
              "description": "The condition or other outcome; e.g. death, remission, amputation, infection, etc."
            }
          },
          {
            "id": "RiskAssessment.prediction.probability[x]",
            "path": "RiskAssessment.prediction.probability[x]",
            "short": "Likelihood of specified outcome",
            "definition": "Indicates how likely the outcome is (in the specified timeframe).",
            "comment": "If range is used, it represents the lower and upper bounds of certainty; e.g. 40-60%  Decimal values are expressed as percentages as well (max = 100).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              },
              {
                "code": "Range"
              }
            ]
          },
          {
            "id": "RiskAssessment.prediction.qualitativeRisk",
            "path": "RiskAssessment.prediction.qualitativeRisk",
            "short": "Likelihood of specified outcome as a qualitative value",
            "definition": "Indicates how likely the outcome is (in the specified timeframe), expressed as a qualitative value (e.g. low, medium, or high).",
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
                  "valueString": "RiskAssessmentProbability"
                }
              ],
              "strength": "example",
              "description": "The likelihood of the occurrence of a specified outcome.",
              "valueSet": "http://hl7.org/fhir/ValueSet/risk-probability"
            }
          },
          {
            "id": "RiskAssessment.prediction.relativeRisk",
            "path": "RiskAssessment.prediction.relativeRisk",
            "short": "Relative likelihood",
            "definition": "Indicates the risk for this particular subject (with their specific characteristics) divided by the risk of the population in general.  (Numbers greater than 1 = higher risk than the population, numbers less than 1 = lower risk.).",
            "requirements": "Absolute risk is less meaningful than relative risk.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "RiskAssessment.prediction.when[x]",
            "path": "RiskAssessment.prediction.when[x]",
            "short": "Timeframe or age range",
            "definition": "Indicates the period of time or age range of the subject to which the specified probability applies.",
            "comment": "If not specified, the risk applies \"over the subject's lifespan\".",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              },
              {
                "code": "Range"
              }
            ]
          },
          {
            "id": "RiskAssessment.prediction.rationale",
            "path": "RiskAssessment.prediction.rationale",
            "short": "Explanation of prediction",
            "definition": "Additional information explaining the basis for the prediction.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "RiskAssessment.mitigation",
            "path": "RiskAssessment.mitigation",
            "short": "How to reduce risk",
            "definition": "A description of the steps that might be taken to reduce the identified risk(s).",
            "requirements": "One of the main reasons for assessing risks is to identify whether interventional steps are needed to reduce risk.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "RiskAssessment.note",
            "path": "RiskAssessment.note",
            "short": "Comments on the risk assessment",
            "definition": "Additional comments about the risk assessment.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'RiskAssessment'
    /// </summary>
    // 0. RiskAssessment
    public class Resource_RiskAssessment : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 15. RiskAssessment.prediction
        public class Type_Prediction : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 16. RiskAssessment.prediction.outcome
            public ElementDefinitionInfo Element_Outcome;
            // 17. RiskAssessment.prediction.probability[x]
            public ElementDefinitionInfo Element_Probability;
            // 18. RiskAssessment.prediction.qualitativeRisk
            public ElementDefinitionInfo Element_QualitativeRisk;
            // 19. RiskAssessment.prediction.relativeRisk
            public ElementDefinitionInfo Element_RelativeRisk;
            // 20. RiskAssessment.prediction.when[x]
            public ElementDefinitionInfo Element_When;
            // 21. RiskAssessment.prediction.rationale
            public ElementDefinitionInfo Element_Rationale;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "RiskAssessment.prediction",
                    ElementId = "RiskAssessment.prediction"
                });
                Element_Outcome.Write(sDef);
                Element_Probability.Write(sDef);
                Element_QualitativeRisk.Write(sDef);
                Element_RelativeRisk.Write(sDef);
                Element_When.Write(sDef);
                Element_Rationale.Write(sDef);
            }
            
            public Type_Prediction()
            {
                {
                    // 16. RiskAssessment.prediction.outcome
                    this.Element_Outcome = new ElementDefinitionInfo
                    {
                        Name = "Element_Outcome",
                        Path= "RiskAssessment.prediction.outcome",
                        Id = "RiskAssessment.prediction.outcome",
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
                    // 17. RiskAssessment.prediction.probability[x]
                    this.Element_Probability = new ElementDefinitionInfo
                    {
                        Name = "Element_Probability",
                        Path= "RiskAssessment.prediction.probability[x]",
                        Id = "RiskAssessment.prediction.probability[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            }
                        }
                    };
                }
                {
                    // 18. RiskAssessment.prediction.qualitativeRisk
                    this.Element_QualitativeRisk = new ElementDefinitionInfo
                    {
                        Name = "Element_QualitativeRisk",
                        Path= "RiskAssessment.prediction.qualitativeRisk",
                        Id = "RiskAssessment.prediction.qualitativeRisk",
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
                    // 19. RiskAssessment.prediction.relativeRisk
                    this.Element_RelativeRisk = new ElementDefinitionInfo
                    {
                        Name = "Element_RelativeRisk",
                        Path= "RiskAssessment.prediction.relativeRisk",
                        Id = "RiskAssessment.prediction.relativeRisk",
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
                    // 20. RiskAssessment.prediction.when[x]
                    this.Element_When = new ElementDefinitionInfo
                    {
                        Name = "Element_When",
                        Path= "RiskAssessment.prediction.when[x]",
                        Id = "RiskAssessment.prediction.when[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            }
                        }
                    };
                }
                {
                    // 21. RiskAssessment.prediction.rationale
                    this.Element_Rationale = new ElementDefinitionInfo
                    {
                        Name = "Element_Rationale",
                        Path= "RiskAssessment.prediction.rationale",
                        Id = "RiskAssessment.prediction.rationale",
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
            }
        }
        // 1. RiskAssessment.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. RiskAssessment.basedOn
        public ElementDefinitionInfo Element_BasedOn;
        // 3. RiskAssessment.parent
        public ElementDefinitionInfo Element_Parent;
        // 4. RiskAssessment.status
        public ElementDefinitionInfo Element_Status;
        // 5. RiskAssessment.method
        public ElementDefinitionInfo Element_Method;
        // 6. RiskAssessment.code
        public ElementDefinitionInfo Element_Code;
        // 7. RiskAssessment.subject
        public ElementDefinitionInfo Element_Subject;
        // 8. RiskAssessment.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 9. RiskAssessment.occurrence[x]
        public ElementDefinitionInfo Element_Occurrence;
        // 10. RiskAssessment.condition
        public ElementDefinitionInfo Element_Condition;
        // 11. RiskAssessment.performer
        public ElementDefinitionInfo Element_Performer;
        // 12. RiskAssessment.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;
        // 13. RiskAssessment.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;
        // 14. RiskAssessment.basis
        public ElementDefinitionInfo Element_Basis;
        // 15. RiskAssessment.prediction
        public ElementDefinitionInfo Element_Prediction;
        // 22. RiskAssessment.mitigation
        public ElementDefinitionInfo Element_Mitigation;
        // 23. RiskAssessment.note
        public ElementDefinitionInfo Element_Note;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "RiskAssessment",
                ElementId = "RiskAssessment"
            });
            Element_Identifier.Write(sDef);
            Element_BasedOn.Write(sDef);
            Element_Parent.Write(sDef);
            Element_Status.Write(sDef);
            Element_Method.Write(sDef);
            Element_Code.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Occurrence.Write(sDef);
            Element_Condition.Write(sDef);
            Element_Performer.Write(sDef);
            Element_ReasonCode.Write(sDef);
            Element_ReasonReference.Write(sDef);
            Element_Basis.Write(sDef);
            Element_Prediction.Write(sDef);
            Element_Mitigation.Write(sDef);
            Element_Note.Write(sDef);
        }
        
        public Resource_RiskAssessment()
        {
            {
                // 1. RiskAssessment.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "RiskAssessment.identifier",
                    Id = "RiskAssessment.identifier",
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
                // 2. RiskAssessment.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo
                {
                    Name = "Element_BasedOn",
                    Path= "RiskAssessment.basedOn",
                    Id = "RiskAssessment.basedOn",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
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
                // 3. RiskAssessment.parent
                this.Element_Parent = new ElementDefinitionInfo
                {
                    Name = "Element_Parent",
                    Path= "RiskAssessment.parent",
                    Id = "RiskAssessment.parent",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
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
                // 4. RiskAssessment.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "RiskAssessment.status",
                    Id = "RiskAssessment.status",
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
                // 5. RiskAssessment.method
                this.Element_Method = new ElementDefinitionInfo
                {
                    Name = "Element_Method",
                    Path= "RiskAssessment.method",
                    Id = "RiskAssessment.method",
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
                // 6. RiskAssessment.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "RiskAssessment.code",
                    Id = "RiskAssessment.code",
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
                // 7. RiskAssessment.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "RiskAssessment.subject",
                    Id = "RiskAssessment.subject",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Group"
                            }
                        }
                    }
                };
            }
            {
                // 8. RiskAssessment.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "RiskAssessment.encounter",
                    Id = "RiskAssessment.encounter",
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
                // 9. RiskAssessment.occurrence[x]
                this.Element_Occurrence = new ElementDefinitionInfo
                {
                    Name = "Element_Occurrence",
                    Path= "RiskAssessment.occurrence[x]",
                    Id = "RiskAssessment.occurrence[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        }
                    }
                };
            }
            {
                // 10. RiskAssessment.condition
                this.Element_Condition = new ElementDefinitionInfo
                {
                    Name = "Element_Condition",
                    Path= "RiskAssessment.condition",
                    Id = "RiskAssessment.condition",
                    Min = 0,
                    Max = 1,
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
                // 11. RiskAssessment.performer
                this.Element_Performer = new ElementDefinitionInfo
                {
                    Name = "Element_Performer",
                    Path= "RiskAssessment.performer",
                    Id = "RiskAssessment.performer",
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
                                "http://hl7.org/fhir/StructureDefinition/Device"
                            }
                        }
                    }
                };
            }
            {
                // 12. RiskAssessment.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonCode",
                    Path= "RiskAssessment.reasonCode",
                    Id = "RiskAssessment.reasonCode",
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
                // 13. RiskAssessment.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonReference",
                    Path= "RiskAssessment.reasonReference",
                    Id = "RiskAssessment.reasonReference",
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
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                            }
                        }
                    }
                };
            }
            {
                // 14. RiskAssessment.basis
                this.Element_Basis = new ElementDefinitionInfo
                {
                    Name = "Element_Basis",
                    Path= "RiskAssessment.basis",
                    Id = "RiskAssessment.basis",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
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
                // 15. RiskAssessment.prediction
                this.Element_Prediction = new ElementDefinitionInfo
                {
                    Name = "Element_Prediction",
                    Path= "RiskAssessment.prediction",
                    Id = "RiskAssessment.prediction",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Prediction
                        {
                        }
                    }
                };
            }
            {
                // 22. RiskAssessment.mitigation
                this.Element_Mitigation = new ElementDefinitionInfo
                {
                    Name = "Element_Mitigation",
                    Path= "RiskAssessment.mitigation",
                    Id = "RiskAssessment.mitigation",
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
                // 23. RiskAssessment.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "RiskAssessment.note",
                    Id = "RiskAssessment.note",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Annotation
                        {
                        }
                    }
                };
            }
            this.Name = "RiskAssessment";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/RiskAssessment";
        }
    }
}
