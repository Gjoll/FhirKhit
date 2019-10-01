using System;                                                                                                                               // MakerGen.cs:391
using System.Diagnostics;                                                                                                                   // MakerGen.cs:392
using System.IO;                                                                                                                            // MakerGen.cs:393
using System.Linq;                                                                                                                          // MakerGen.cs:394
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:396
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:397
{                                                                                                                                           // MakerGen.cs:398
    #region Json                                                                                                                            // MakerGen.cs:399
    #if NEVER                                                                                                                               // MakerGen.cs:400
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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'RiskAssessment'
    /// </summary>
    // 0. RiskAssessment
    public class RiskAssessment : FhirKhit.Maker.Common.Resource.ResourceBase                                                               // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 15. RiskAssessment.prediction
        public class Type_Prediction : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 16. RiskAssessment.prediction.outcome
            public MakerElementInstance Element_Outcome;                                                                                    // MakerGen.cs:232
            // 17. RiskAssessment.prediction.probability[x]
            public MakerElementInstance Element_Probability;                                                                                // MakerGen.cs:232
            // 18. RiskAssessment.prediction.qualitativeRisk
            public MakerElementInstance Element_QualitativeRisk;                                                                            // MakerGen.cs:232
            // 19. RiskAssessment.prediction.relativeRisk
            public MakerElementInstance Element_RelativeRisk;                                                                               // MakerGen.cs:232
            // 20. RiskAssessment.prediction.when[x]
            public MakerElementInstance Element_When;                                                                                       // MakerGen.cs:232
            // 21. RiskAssessment.prediction.rationale
            public MakerElementInstance Element_Rationale;                                                                                  // MakerGen.cs:232
            public Type_Prediction()                                                                                                        // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 16. RiskAssessment.prediction.outcome
                    this.Element_Outcome = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Outcome",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 17. RiskAssessment.prediction.probability[x]
                    this.Element_Probability = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Probability",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal(),                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 18. RiskAssessment.prediction.qualitativeRisk
                    this.Element_QualitativeRisk = new MakerElementInstance                                                                 // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_QualitativeRisk",                                                                                   // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 19. RiskAssessment.prediction.relativeRisk
                    this.Element_RelativeRisk = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_RelativeRisk",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 20. RiskAssessment.prediction.when[x]
                    this.Element_When = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_When",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 21. RiskAssessment.prediction.rationale
                    this.Element_Rationale = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Rationale",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. RiskAssessment.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. RiskAssessment.basedOn
        public MakerElementInstance Element_BasedOn;                                                                                        // MakerGen.cs:232
        // 3. RiskAssessment.parent
        public MakerElementInstance Element_Parent;                                                                                         // MakerGen.cs:232
        // 4. RiskAssessment.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 5. RiskAssessment.method
        public MakerElementInstance Element_Method;                                                                                         // MakerGen.cs:232
        // 6. RiskAssessment.code
        public MakerElementInstance Element_Code;                                                                                           // MakerGen.cs:232
        // 7. RiskAssessment.subject
        public MakerElementInstance Element_Subject;                                                                                        // MakerGen.cs:232
        // 8. RiskAssessment.encounter
        public MakerElementInstance Element_Encounter;                                                                                      // MakerGen.cs:232
        // 9. RiskAssessment.occurrence[x]
        public MakerElementInstance Element_Occurrence;                                                                                     // MakerGen.cs:232
        // 10. RiskAssessment.condition
        public MakerElementInstance Element_Condition;                                                                                      // MakerGen.cs:232
        // 11. RiskAssessment.performer
        public MakerElementInstance Element_Performer;                                                                                      // MakerGen.cs:232
        // 12. RiskAssessment.reasonCode
        public MakerElementInstance Element_ReasonCode;                                                                                     // MakerGen.cs:232
        // 13. RiskAssessment.reasonReference
        public MakerElementInstance Element_ReasonReference;                                                                                // MakerGen.cs:232
        // 14. RiskAssessment.basis
        public MakerElementInstance Element_Basis;                                                                                          // MakerGen.cs:232
        // 22. RiskAssessment.mitigation
        public MakerElementInstance Element_Mitigation;                                                                                     // MakerGen.cs:232
        // 23. RiskAssessment.note
        public MakerElementInstance Element_Note;                                                                                           // MakerGen.cs:232
        public RiskAssessment()                                                                                                             // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. RiskAssessment.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. RiskAssessment.basedOn
                this.Element_BasedOn = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_BasedOn",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. RiskAssessment.parent
                this.Element_Parent = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Parent",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. RiskAssessment.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. RiskAssessment.method
                this.Element_Method = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Method",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. RiskAssessment.code
                this.Element_Code = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. RiskAssessment.subject
                this.Element_Subject = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. RiskAssessment.encounter
                this.Element_Encounter = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 9. RiskAssessment.occurrence[x]
                this.Element_Occurrence = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Occurrence",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime(),                                                                     // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 10. RiskAssessment.condition
                this.Element_Condition = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Condition",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 11. RiskAssessment.performer
                this.Element_Performer = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Performer",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 12. RiskAssessment.reasonCode
                this.Element_ReasonCode = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 13. RiskAssessment.reasonReference
                this.Element_ReasonReference = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 14. RiskAssessment.basis
                this.Element_Basis = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Basis",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 22. RiskAssessment.mitigation
                this.Element_Mitigation = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Mitigation",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 23. RiskAssessment.note
                this.Element_Note = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
