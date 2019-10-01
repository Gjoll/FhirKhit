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
      "id": "ImmunizationRecommendation",
      "url": "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation",
      "version": "4.0.0",
      "name": "ImmunizationRecommendation",
      "status": "draft",
      "publisher": "Health Level Seven International (Public Health and Emergency Response)",
      "description": "A patient's point-in-time set of recommendations (i.e. forecasting) according to a published schedule with optional supporting justification.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ImmunizationRecommendation",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ImmunizationRecommendation",
            "path": "ImmunizationRecommendation",
            "short": "Guidance or advice relating to an immunization",
            "definition": "A patient's point-in-time set of recommendations (i.e. forecasting) according to a published schedule with optional supporting justification.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ImmunizationRecommendation.identifier",
            "path": "ImmunizationRecommendation.identifier",
            "short": "Business identifier",
            "definition": "A unique identifier assigned to this particular recommendation record.",
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
            "id": "ImmunizationRecommendation.patient",
            "path": "ImmunizationRecommendation.patient",
            "short": "Who this profile is for",
            "definition": "The patient the recommendation(s) are for.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImmunizationRecommendation.date",
            "path": "ImmunizationRecommendation.date",
            "short": "Date recommendation(s) created",
            "definition": "The date the immunization recommendation(s) were created.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImmunizationRecommendation.authority",
            "path": "ImmunizationRecommendation.authority",
            "short": "Who is responsible for protocol",
            "definition": "Indicates the authority who published the protocol (e.g. ACIP).",
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
            "id": "ImmunizationRecommendation.recommendation",
            "path": "ImmunizationRecommendation.recommendation",
            "short": "Vaccine administration recommendations",
            "definition": "Vaccine administration recommendations.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImmunizationRecommendation.recommendation.vaccineCode",
            "path": "ImmunizationRecommendation.recommendation.vaccineCode",
            "short": "Vaccine  or vaccine group recommendation applies to",
            "definition": "Vaccine(s) or vaccine group that pertain to the recommendation.",
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
                  "valueString": "VaccineCode"
                }
              ],
              "strength": "example",
              "description": "The type of vaccine administered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/vaccine-code"
            }
          },
          {
            "id": "ImmunizationRecommendation.recommendation.targetDisease",
            "path": "ImmunizationRecommendation.recommendation.targetDisease",
            "short": "Disease to be immunized against",
            "definition": "The targeted disease for the recommendation.",
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
                  "valueString": "TargetDisease"
                }
              ],
              "strength": "example",
              "description": "The disease that the recommended vaccination targets.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-recommendation-target-disease"
            }
          },
          {
            "id": "ImmunizationRecommendation.recommendation.contraindicatedVaccineCode",
            "path": "ImmunizationRecommendation.recommendation.contraindicatedVaccineCode",
            "short": "Vaccine which is contraindicated to fulfill the recommendation",
            "definition": "Vaccine(s) which should not be used to fulfill the recommendation.",
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
                  "valueString": "VaccineCode"
                }
              ],
              "strength": "example",
              "description": "The type of vaccine administered.",
              "valueSet": "http://hl7.org/fhir/ValueSet/vaccine-code"
            }
          },
          {
            "id": "ImmunizationRecommendation.recommendation.forecastStatus",
            "path": "ImmunizationRecommendation.recommendation.forecastStatus",
            "short": "Vaccine recommendation status",
            "definition": "Indicates the patient status with respect to the path to immunity for the target disease.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because the forecastStatus indicates whether a patient needs additional doses (due, overdue, etc) or not  (contraindicated, complete, etc).",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ImmunizationRecommendationStatus"
                }
              ],
              "strength": "example",
              "description": "The patient's status with respect to a vaccination protocol.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-recommendation-status"
            }
          },
          {
            "id": "ImmunizationRecommendation.recommendation.forecastReason",
            "path": "ImmunizationRecommendation.recommendation.forecastReason",
            "short": "Vaccine administration status reason",
            "definition": "The reason for the assigned forecast status.",
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
                  "valueString": "ImmunizationRecommendationReason"
                }
              ],
              "strength": "example",
              "description": "The reason for the patient's status with respect to a vaccination protocol.",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-recommendation-reason"
            }
          },
          {
            "id": "ImmunizationRecommendation.recommendation.dateCriterion",
            "path": "ImmunizationRecommendation.recommendation.dateCriterion",
            "short": "Dates governing proposed immunization",
            "definition": "Vaccine date recommendations.  For example, earliest date to administer, latest date to administer, etc.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ImmunizationRecommendation.recommendation.dateCriterion.code",
            "path": "ImmunizationRecommendation.recommendation.dateCriterion.code",
            "short": "Type of date",
            "definition": "Date classification of recommendation.  For example, earliest date to give, latest date to give, etc.",
            "min": 1,
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
                  "valueString": "ImmunizationRecommendationDateCriterion"
                }
              ],
              "strength": "example",
              "description": "Classifies date criterion with respect to conveying information about a patient's vaccination status (e.g. due date, latest to give date, etc.).",
              "valueSet": "http://hl7.org/fhir/ValueSet/immunization-recommendation-date-criterion"
            }
          },
          {
            "id": "ImmunizationRecommendation.recommendation.dateCriterion.value",
            "path": "ImmunizationRecommendation.recommendation.dateCriterion.value",
            "short": "Recommended date",
            "definition": "The date whose meaning is specified by dateCriterion.code.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "ImmunizationRecommendation.recommendation.description",
            "path": "ImmunizationRecommendation.recommendation.description",
            "short": "Protocol details",
            "definition": "Contains the description about the protocol under which the vaccine was administered.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImmunizationRecommendation.recommendation.series",
            "path": "ImmunizationRecommendation.recommendation.series",
            "short": "Name of vaccination series",
            "definition": "One possible path to achieve presumed immunity against a disease - within the context of an authority.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImmunizationRecommendation.recommendation.doseNumber[x]",
            "path": "ImmunizationRecommendation.recommendation.doseNumber[x]",
            "short": "Recommended dose number within series",
            "definition": "Nominal position of the recommended dose in a series (e.g. dose 2 is the next recommended dose).",
            "comment": "The use of an integer is prefered if known. A string should only be used in cases where an interger is not available (such as when documenting a recurring booster dose).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              },
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImmunizationRecommendation.recommendation.seriesDoses[x]",
            "path": "ImmunizationRecommendation.recommendation.seriesDoses[x]",
            "short": "Recommended number of doses for immunity",
            "definition": "The recommended number of doses to achieve immunity.",
            "comment": "The use of an integer is prefered if known. A string should only be used in cases where an interger is not available (such as when documenting a recurring booster dose).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              },
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImmunizationRecommendation.recommendation.supportingImmunization",
            "path": "ImmunizationRecommendation.recommendation.supportingImmunization",
            "short": "Past immunizations supporting recommendation",
            "definition": "Immunization event history and/or evaluation that supports the status and recommendation.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Immunization",
                  "http://hl7.org/fhir/StructureDefinition/ImmunizationEvaluation"
                ]
              }
            ]
          },
          {
            "id": "ImmunizationRecommendation.recommendation.supportingPatientInformation",
            "path": "ImmunizationRecommendation.recommendation.supportingPatientInformation",
            "short": "Patient observations supporting recommendation",
            "definition": "Patient Information that supports the status and recommendation.  This includes patient observations, adverse reactions and allergy/intolerance information.",
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
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'ImmunizationRecommendation'
    /// </summary>
    // 0. ImmunizationRecommendation
    public class ImmunizationRecommendation : FhirKhit.Maker.Common.Resource.ResourceBase                                                   // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class ImmunizationRecommendation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 5. ImmunizationRecommendation.recommendation
            public class Type_Recommendation : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Recommendation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 11. ImmunizationRecommendation.recommendation.dateCriterion
                    public class Type_DateCriterion : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_DateCriterion_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                              // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 12. ImmunizationRecommendation.recommendation.dateCriterion.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:236
                            // 13. ImmunizationRecommendation.recommendation.dateCriterion.value
                            public ElementDefinitionInfo Value;                                                                             // MakerGen.cs:236
                            public Type_DateCriterion_Elements()                                                                            // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 12. ImmunizationRecommendation.recommendation.dateCriterion.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Code",                                                                                      // MakerGen.cs:255
                                        Path= "ImmunizationRecommendation.recommendation.dateCriterion.code",                               // MakerGen.cs:256
                                        Id = "ImmunizationRecommendation.recommendation.dateCriterion.code",                                // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            }                                                                                               // MakerGen.cs:318
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 13. ImmunizationRecommendation.recommendation.dateCriterion.value
                                    this.Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Value",                                                                                     // MakerGen.cs:255
                                        Path= "ImmunizationRecommendation.recommendation.dateCriterion.value",                              // MakerGen.cs:256
                                        Id = "ImmunizationRecommendation.recommendation.dateCriterion.value",                               // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.DateTime                                                    // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Code.Write(sDef);                                                                                           // MakerGen.cs:240
                                Value.Write(sDef);                                                                                          // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_DateCriterion_Elements Elements { get; }                                                                // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_DateCriterion()                                                                                         // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_DateCriterion_Elements();                                                              // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 6. ImmunizationRecommendation.recommendation.vaccineCode
                    public ElementDefinitionInfo VaccineCode;                                                                               // MakerGen.cs:236
                    // 7. ImmunizationRecommendation.recommendation.targetDisease
                    public ElementDefinitionInfo TargetDisease;                                                                             // MakerGen.cs:236
                    // 8. ImmunizationRecommendation.recommendation.contraindicatedVaccineCode
                    public ElementDefinitionInfo ContraindicatedVaccineCode;                                                                // MakerGen.cs:236
                    // 9. ImmunizationRecommendation.recommendation.forecastStatus
                    public ElementDefinitionInfo ForecastStatus;                                                                            // MakerGen.cs:236
                    // 10. ImmunizationRecommendation.recommendation.forecastReason
                    public ElementDefinitionInfo ForecastReason;                                                                            // MakerGen.cs:236
                    // 14. ImmunizationRecommendation.recommendation.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:236
                    // 15. ImmunizationRecommendation.recommendation.series
                    public ElementDefinitionInfo Series;                                                                                    // MakerGen.cs:236
                    // 16. ImmunizationRecommendation.recommendation.doseNumber[x]
                    public ElementDefinitionInfo DoseNumber;                                                                                // MakerGen.cs:236
                    // 17. ImmunizationRecommendation.recommendation.seriesDoses[x]
                    public ElementDefinitionInfo SeriesDoses;                                                                               // MakerGen.cs:236
                    // 18. ImmunizationRecommendation.recommendation.supportingImmunization
                    public ElementDefinitionInfo SupportingImmunization;                                                                    // MakerGen.cs:236
                    // 19. ImmunizationRecommendation.recommendation.supportingPatientInformation
                    public ElementDefinitionInfo SupportingPatientInformation;                                                              // MakerGen.cs:236
                    public Type_Recommendation_Elements()                                                                                   // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 6. ImmunizationRecommendation.recommendation.vaccineCode
                            this.VaccineCode = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "VaccineCode",                                                                                       // MakerGen.cs:255
                                Path= "ImmunizationRecommendation.recommendation.vaccineCode",                                              // MakerGen.cs:256
                                Id = "ImmunizationRecommendation.recommendation.vaccineCode",                                               // MakerGen.cs:257
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
                            // 7. ImmunizationRecommendation.recommendation.targetDisease
                            this.TargetDisease = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "TargetDisease",                                                                                     // MakerGen.cs:255
                                Path= "ImmunizationRecommendation.recommendation.targetDisease",                                            // MakerGen.cs:256
                                Id = "ImmunizationRecommendation.recommendation.targetDisease",                                             // MakerGen.cs:257
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
                            // 8. ImmunizationRecommendation.recommendation.contraindicatedVaccineCode
                            this.ContraindicatedVaccineCode = new ElementDefinitionInfo                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ContraindicatedVaccineCode",                                                                        // MakerGen.cs:255
                                Path= "ImmunizationRecommendation.recommendation.contraindicatedVaccineCode",                               // MakerGen.cs:256
                                Id = "ImmunizationRecommendation.recommendation.contraindicatedVaccineCode",                                // MakerGen.cs:257
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
                            // 9. ImmunizationRecommendation.recommendation.forecastStatus
                            this.ForecastStatus = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ForecastStatus",                                                                                    // MakerGen.cs:255
                                Path= "ImmunizationRecommendation.recommendation.forecastStatus",                                           // MakerGen.cs:256
                                Id = "ImmunizationRecommendation.recommendation.forecastStatus",                                            // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
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
                            // 10. ImmunizationRecommendation.recommendation.forecastReason
                            this.ForecastReason = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ForecastReason",                                                                                    // MakerGen.cs:255
                                Path= "ImmunizationRecommendation.recommendation.forecastReason",                                           // MakerGen.cs:256
                                Id = "ImmunizationRecommendation.recommendation.forecastReason",                                            // MakerGen.cs:257
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
                            // 14. ImmunizationRecommendation.recommendation.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Description",                                                                                       // MakerGen.cs:255
                                Path= "ImmunizationRecommendation.recommendation.description",                                              // MakerGen.cs:256
                                Id = "ImmunizationRecommendation.recommendation.description",                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 15. ImmunizationRecommendation.recommendation.series
                            this.Series = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Series",                                                                                            // MakerGen.cs:255
                                Path= "ImmunizationRecommendation.recommendation.series",                                                   // MakerGen.cs:256
                                Id = "ImmunizationRecommendation.recommendation.series",                                                    // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 16. ImmunizationRecommendation.recommendation.doseNumber[x]
                            this.DoseNumber = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "DoseNumber",                                                                                        // MakerGen.cs:255
                                Path= "ImmunizationRecommendation.recommendation.doseNumber[x]",                                            // MakerGen.cs:256
                                Id = "ImmunizationRecommendation.recommendation.doseNumber[x]",                                             // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 17. ImmunizationRecommendation.recommendation.seriesDoses[x]
                            this.SeriesDoses = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "SeriesDoses",                                                                                       // MakerGen.cs:255
                                Path= "ImmunizationRecommendation.recommendation.seriesDoses[x]",                                           // MakerGen.cs:256
                                Id = "ImmunizationRecommendation.recommendation.seriesDoses[x]",                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 18. ImmunizationRecommendation.recommendation.supportingImmunization
                            this.SupportingImmunization = new ElementDefinitionInfo                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "SupportingImmunization",                                                                            // MakerGen.cs:255
                                Path= "ImmunizationRecommendation.recommendation.supportingImmunization",                                   // MakerGen.cs:256
                                Id = "ImmunizationRecommendation.recommendation.supportingImmunization",                                    // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Immunization",                                         // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/ImmunizationEvaluation"                                // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 19. ImmunizationRecommendation.recommendation.supportingPatientInformation
                            this.SupportingPatientInformation = new ElementDefinitionInfo                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "SupportingPatientInformation",                                                                      // MakerGen.cs:255
                                Path= "ImmunizationRecommendation.recommendation.supportingPatientInformation",                             // MakerGen.cs:256
                                Id = "ImmunizationRecommendation.recommendation.supportingPatientInformation",                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        VaccineCode.Write(sDef);                                                                                            // MakerGen.cs:240
                        TargetDisease.Write(sDef);                                                                                          // MakerGen.cs:240
                        ContraindicatedVaccineCode.Write(sDef);                                                                             // MakerGen.cs:240
                        ForecastStatus.Write(sDef);                                                                                         // MakerGen.cs:240
                        ForecastReason.Write(sDef);                                                                                         // MakerGen.cs:240
                        Description.Write(sDef);                                                                                            // MakerGen.cs:240
                        Series.Write(sDef);                                                                                                 // MakerGen.cs:240
                        DoseNumber.Write(sDef);                                                                                             // MakerGen.cs:240
                        SeriesDoses.Write(sDef);                                                                                            // MakerGen.cs:240
                        SupportingImmunization.Write(sDef);                                                                                 // MakerGen.cs:240
                        SupportingPatientInformation.Write(sDef);                                                                           // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Recommendation_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Recommendation()                                                                                                // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Recommendation_Elements();                                                                     // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. ImmunizationRecommendation.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. ImmunizationRecommendation.patient
            public ElementDefinitionInfo Patient;                                                                                           // MakerGen.cs:236
            // 3. ImmunizationRecommendation.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:236
            // 4. ImmunizationRecommendation.authority
            public ElementDefinitionInfo Authority;                                                                                         // MakerGen.cs:236
            public ImmunizationRecommendation_Elements()                                                                                    // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. ImmunizationRecommendation.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "ImmunizationRecommendation.identifier",                                                                      // MakerGen.cs:256
                        Id = "ImmunizationRecommendation.identifier",                                                                       // MakerGen.cs:257
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
                    // 2. ImmunizationRecommendation.patient
                    this.Patient = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Patient",                                                                                                   // MakerGen.cs:255
                        Path= "ImmunizationRecommendation.patient",                                                                         // MakerGen.cs:256
                        Id = "ImmunizationRecommendation.patient",                                                                          // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient"                                                       // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. ImmunizationRecommendation.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Date",                                                                                                      // MakerGen.cs:255
                        Path= "ImmunizationRecommendation.date",                                                                            // MakerGen.cs:256
                        Id = "ImmunizationRecommendation.date",                                                                             // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. ImmunizationRecommendation.authority
                    this.Authority = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Authority",                                                                                                 // MakerGen.cs:255
                        Path= "ImmunizationRecommendation.authority",                                                                       // MakerGen.cs:256
                        Id = "ImmunizationRecommendation.authority",                                                                        // MakerGen.cs:257
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
            }                                                                                                                               // MakerGen.cs:429
            public void override Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                Patient.Write(sDef);                                                                                                        // MakerGen.cs:240
                Date.Write(sDef);                                                                                                           // MakerGen.cs:240
                Authority.Write(sDef);                                                                                                      // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public ImmunizationRecommendation_Elements Elements { get; }                                                                        // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public ImmunizationRecommendation()                                                                                                 // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new ImmunizationRecommendation_Elements();                                                                      // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
