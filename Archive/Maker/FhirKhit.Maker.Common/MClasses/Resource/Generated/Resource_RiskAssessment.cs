using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'RiskAssessment'
    /// </summary>
    // 0. RiskAssessment
    public partial class Resource_RiskAssessment : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                   // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 15. RiskAssessment.prediction
        public partial class Type_Prediction : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 16. RiskAssessment.prediction.outcome
            public ElementDefinitionInfo Element_Outcome;                                                                                   // MakerGen.cs:217
            // 17. RiskAssessment.prediction.probability[x]
            public ElementDefinitionInfo Element_Probability;                                                                               // MakerGen.cs:217
            // 18. RiskAssessment.prediction.qualitativeRisk
            public ElementDefinitionInfo Element_QualitativeRisk;                                                                           // MakerGen.cs:217
            // 19. RiskAssessment.prediction.relativeRisk
            public ElementDefinitionInfo Element_RelativeRisk;                                                                              // MakerGen.cs:217
            // 20. RiskAssessment.prediction.when[x]
            public ElementDefinitionInfo Element_When;                                                                                      // MakerGen.cs:217
            // 21. RiskAssessment.prediction.rationale
            public ElementDefinitionInfo Element_Rationale;                                                                                 // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "RiskAssessment.prediction",                                                                                     // MakerGen.cs:393
                    ElementId = "RiskAssessment.prediction"                                                                                 // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Outcome.Write(sDef);                                                                                                // MakerGen.cs:221
                Element_Probability.Write(sDef);                                                                                            // MakerGen.cs:221
                Element_QualitativeRisk.Write(sDef);                                                                                        // MakerGen.cs:221
                Element_RelativeRisk.Write(sDef);                                                                                           // MakerGen.cs:221
                Element_When.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Rationale.Write(sDef);                                                                                              // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Prediction()                                                                                                        // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 16. RiskAssessment.prediction.outcome
                    this.Element_Outcome = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Outcome",                                                                                           // MakerGen.cs:236
                        Path= "RiskAssessment.prediction.outcome",                                                                          // MakerGen.cs:237
                        Id = "RiskAssessment.prediction.outcome",                                                                           // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 17. RiskAssessment.prediction.probability[x]
                    this.Element_Probability = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Probability",                                                                                       // MakerGen.cs:236
                        Path= "RiskAssessment.prediction.probability[x]",                                                                   // MakerGen.cs:237
                        Id = "RiskAssessment.prediction.probability[x]",                                                                    // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            },                                                                                                              // MakerGen.cs:305
                            new FhirKhit.Maker.Common.Complex.Type_Range                                                                    // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 18. RiskAssessment.prediction.qualitativeRisk
                    this.Element_QualitativeRisk = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_QualitativeRisk",                                                                                   // MakerGen.cs:236
                        Path= "RiskAssessment.prediction.qualitativeRisk",                                                                  // MakerGen.cs:237
                        Id = "RiskAssessment.prediction.qualitativeRisk",                                                                   // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:316
                            {                                                                                                               // MakerGen.cs:317
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 19. RiskAssessment.prediction.relativeRisk
                    this.Element_RelativeRisk = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_RelativeRisk",                                                                                      // MakerGen.cs:236
                        Path= "RiskAssessment.prediction.relativeRisk",                                                                     // MakerGen.cs:237
                        Id = "RiskAssessment.prediction.relativeRisk",                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 20. RiskAssessment.prediction.when[x]
                    this.Element_When = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_When",                                                                                              // MakerGen.cs:236
                        Path= "RiskAssessment.prediction.when[x]",                                                                          // MakerGen.cs:237
                        Id = "RiskAssessment.prediction.when[x]",                                                                           // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            },                                                                                                              // MakerGen.cs:358
                            new FhirKhit.Maker.Common.Complex.Type_Range                                                                    // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 21. RiskAssessment.prediction.rationale
                    this.Element_Rationale = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Rationale",                                                                                         // MakerGen.cs:236
                        Path= "RiskAssessment.prediction.rationale",                                                                        // MakerGen.cs:237
                        Id = "RiskAssessment.prediction.rationale",                                                                         // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. RiskAssessment.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 2. RiskAssessment.basedOn
        public ElementDefinitionInfo Element_BasedOn;                                                                                       // MakerGen.cs:217
        // 3. RiskAssessment.parent
        public ElementDefinitionInfo Element_Parent;                                                                                        // MakerGen.cs:217
        // 4. RiskAssessment.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:217
        // 5. RiskAssessment.method
        public ElementDefinitionInfo Element_Method;                                                                                        // MakerGen.cs:217
        // 6. RiskAssessment.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:217
        // 7. RiskAssessment.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:217
        // 8. RiskAssessment.encounter
        public ElementDefinitionInfo Element_Encounter;                                                                                     // MakerGen.cs:217
        // 9. RiskAssessment.occurrence[x]
        public ElementDefinitionInfo Element_Occurrence;                                                                                    // MakerGen.cs:217
        // 10. RiskAssessment.condition
        public ElementDefinitionInfo Element_Condition;                                                                                     // MakerGen.cs:217
        // 11. RiskAssessment.performer
        public ElementDefinitionInfo Element_Performer;                                                                                     // MakerGen.cs:217
        // 12. RiskAssessment.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;                                                                                    // MakerGen.cs:217
        // 13. RiskAssessment.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;                                                                               // MakerGen.cs:217
        // 14. RiskAssessment.basis
        public ElementDefinitionInfo Element_Basis;                                                                                         // MakerGen.cs:217
        // 15. RiskAssessment.prediction
        public ElementDefinitionInfo Element_Prediction;                                                                                    // MakerGen.cs:217
        // 22. RiskAssessment.mitigation
        public ElementDefinitionInfo Element_Mitigation;                                                                                    // MakerGen.cs:217
        // 23. RiskAssessment.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "RiskAssessment",                                                                                                    // MakerGen.cs:393
                ElementId = "RiskAssessment"                                                                                                // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_BasedOn.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Parent.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Method.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Encounter.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Occurrence.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Condition.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Performer.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_ReasonCode.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_ReasonReference.Write(sDef);                                                                                            // MakerGen.cs:221
            Element_Basis.Write(sDef);                                                                                                      // MakerGen.cs:221
            Element_Prediction.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Mitigation.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_RiskAssessment()                                                                                                    // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. RiskAssessment.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "RiskAssessment.identifier",                                                                                      // MakerGen.cs:237
                    Id = "RiskAssessment.identifier",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. RiskAssessment.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_BasedOn",                                                                                               // MakerGen.cs:236
                    Path= "RiskAssessment.basedOn",                                                                                         // MakerGen.cs:237
                    Id = "RiskAssessment.basedOn",                                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. RiskAssessment.parent
                this.Element_Parent = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Parent",                                                                                                // MakerGen.cs:236
                    Path= "RiskAssessment.parent",                                                                                          // MakerGen.cs:237
                    Id = "RiskAssessment.parent",                                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. RiskAssessment.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Status",                                                                                                // MakerGen.cs:236
                    Path= "RiskAssessment.status",                                                                                          // MakerGen.cs:237
                    Id = "RiskAssessment.status",                                                                                           // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. RiskAssessment.method
                this.Element_Method = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Method",                                                                                                // MakerGen.cs:236
                    Path= "RiskAssessment.method",                                                                                          // MakerGen.cs:237
                    Id = "RiskAssessment.method",                                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. RiskAssessment.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:236
                    Path= "RiskAssessment.code",                                                                                            // MakerGen.cs:237
                    Id = "RiskAssessment.code",                                                                                             // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. RiskAssessment.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:236
                    Path= "RiskAssessment.subject",                                                                                         // MakerGen.cs:237
                    Id = "RiskAssessment.subject",                                                                                          // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Group"                                                             // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 8. RiskAssessment.encounter
                this.Element_Encounter = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Encounter",                                                                                             // MakerGen.cs:236
                    Path= "RiskAssessment.encounter",                                                                                       // MakerGen.cs:237
                    Id = "RiskAssessment.encounter",                                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Encounter"                                                         // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 9. RiskAssessment.occurrence[x]
                this.Element_Occurrence = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Occurrence",                                                                                            // MakerGen.cs:236
                    Path= "RiskAssessment.occurrence[x]",                                                                                   // MakerGen.cs:237
                    Id = "RiskAssessment.occurrence[x]",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 10. RiskAssessment.condition
                this.Element_Condition = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Condition",                                                                                             // MakerGen.cs:236
                    Path= "RiskAssessment.condition",                                                                                       // MakerGen.cs:237
                    Id = "RiskAssessment.condition",                                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Condition"                                                         // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 11. RiskAssessment.performer
                this.Element_Performer = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Performer",                                                                                             // MakerGen.cs:236
                    Path= "RiskAssessment.performer",                                                                                       // MakerGen.cs:237
                    Id = "RiskAssessment.performer",                                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Device"                                                            // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 12. RiskAssessment.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ReasonCode",                                                                                            // MakerGen.cs:236
                    Path= "RiskAssessment.reasonCode",                                                                                      // MakerGen.cs:237
                    Id = "RiskAssessment.reasonCode",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 13. RiskAssessment.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ReasonReference",                                                                                       // MakerGen.cs:236
                    Path= "RiskAssessment.reasonReference",                                                                                 // MakerGen.cs:237
                    Id = "RiskAssessment.reasonReference",                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Condition",                                                        // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/Observation",                                                      // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                                 // MakerGen.cs:347
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                                 // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 14. RiskAssessment.basis
                this.Element_Basis = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Basis",                                                                                                 // MakerGen.cs:236
                    Path= "RiskAssessment.basis",                                                                                           // MakerGen.cs:237
                    Id = "RiskAssessment.basis",                                                                                            // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:344
                        {                                                                                                                   // MakerGen.cs:345
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:347
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:347
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:348
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 15. RiskAssessment.prediction
                this.Element_Prediction = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Prediction",                                                                                            // MakerGen.cs:236
                    Path= "RiskAssessment.prediction",                                                                                      // MakerGen.cs:237
                    Id = "RiskAssessment.prediction",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Prediction                                                                                                 // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 22. RiskAssessment.mitigation
                this.Element_Mitigation = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Mitigation",                                                                                            // MakerGen.cs:236
                    Path= "RiskAssessment.mitigation",                                                                                      // MakerGen.cs:237
                    Id = "RiskAssessment.mitigation",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 23. RiskAssessment.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:236
                    Path= "RiskAssessment.note",                                                                                            // MakerGen.cs:237
                    Id = "RiskAssessment.note",                                                                                             // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "RiskAssessment";                                                                                                   // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/RiskAssessment";                                                            // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
