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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'ImmunizationRecommendation'
    /// </summary>
    // 0. ImmunizationRecommendation
    public class ImmunizationRecommendation : FhirKhit.Maker.Common.Resource.ResourceBase                                                   // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 5. ImmunizationRecommendation.recommendation
        public class Type_Recommendation : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 11. ImmunizationRecommendation.recommendation.dateCriterion
            public class Type_DateCriterion : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 12. ImmunizationRecommendation.recommendation.dateCriterion.code
                public MakerElementInstance Element_Code;                                                                                   // MakerGen.cs:232
                // 13. ImmunizationRecommendation.recommendation.dateCriterion.value
                public MakerElementInstance Element_Value;                                                                                  // MakerGen.cs:232
                public Type_DateCriterion()                                                                                                 // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 12. ImmunizationRecommendation.recommendation.dateCriterion.code
                        this.Element_Code = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Code",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 13. ImmunizationRecommendation.recommendation.dateCriterion.value
                        this.Element_Value = new MakerElementInstance                                                                       // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Value",                                                                                         // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.DateTime()                                                              // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 6. ImmunizationRecommendation.recommendation.vaccineCode
            public MakerElementInstance Element_VaccineCode;                                                                                // MakerGen.cs:232
            // 7. ImmunizationRecommendation.recommendation.targetDisease
            public MakerElementInstance Element_TargetDisease;                                                                              // MakerGen.cs:232
            // 8. ImmunizationRecommendation.recommendation.contraindicatedVaccineCode
            public MakerElementInstance Element_ContraindicatedVaccineCode;                                                                 // MakerGen.cs:232
            // 9. ImmunizationRecommendation.recommendation.forecastStatus
            public MakerElementInstance Element_ForecastStatus;                                                                             // MakerGen.cs:232
            // 10. ImmunizationRecommendation.recommendation.forecastReason
            public MakerElementInstance Element_ForecastReason;                                                                             // MakerGen.cs:232
            // 14. ImmunizationRecommendation.recommendation.description
            public MakerElementInstance Element_Description;                                                                                // MakerGen.cs:232
            // 15. ImmunizationRecommendation.recommendation.series
            public MakerElementInstance Element_Series;                                                                                     // MakerGen.cs:232
            // 16. ImmunizationRecommendation.recommendation.doseNumber[x]
            public MakerElementInstance Element_DoseNumber;                                                                                 // MakerGen.cs:232
            // 17. ImmunizationRecommendation.recommendation.seriesDoses[x]
            public MakerElementInstance Element_SeriesDoses;                                                                                // MakerGen.cs:232
            // 18. ImmunizationRecommendation.recommendation.supportingImmunization
            public MakerElementInstance Element_SupportingImmunization;                                                                     // MakerGen.cs:232
            // 19. ImmunizationRecommendation.recommendation.supportingPatientInformation
            public MakerElementInstance Element_SupportingPatientInformation;                                                               // MakerGen.cs:232
            public Type_Recommendation()                                                                                                    // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 6. ImmunizationRecommendation.recommendation.vaccineCode
                    this.Element_VaccineCode = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_VaccineCode",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 7. ImmunizationRecommendation.recommendation.targetDisease
                    this.Element_TargetDisease = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_TargetDisease",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 8. ImmunizationRecommendation.recommendation.contraindicatedVaccineCode
                    this.Element_ContraindicatedVaccineCode = new MakerElementInstance                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ContraindicatedVaccineCode",                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 9. ImmunizationRecommendation.recommendation.forecastStatus
                    this.Element_ForecastStatus = new MakerElementInstance                                                                  // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ForecastStatus",                                                                                    // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 10. ImmunizationRecommendation.recommendation.forecastReason
                    this.Element_ForecastReason = new MakerElementInstance                                                                  // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ForecastReason",                                                                                    // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                             // MakerGen.cs:292
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 14. ImmunizationRecommendation.recommendation.description
                    this.Element_Description = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Description",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 15. ImmunizationRecommendation.recommendation.series
                    this.Element_Series = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Series",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 16. ImmunizationRecommendation.recommendation.doseNumber[x]
                    this.Element_DoseNumber = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_DoseNumber",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt(),                                                              // MakerGen.cs:286
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 17. ImmunizationRecommendation.recommendation.seriesDoses[x]
                    this.Element_SeriesDoses = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SeriesDoses",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.PositiveInt(),                                                              // MakerGen.cs:286
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 18. ImmunizationRecommendation.recommendation.supportingImmunization
                    this.Element_SupportingImmunization = new MakerElementInstance                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SupportingImmunization",                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 19. ImmunizationRecommendation.recommendation.supportingPatientInformation
                    this.Element_SupportingPatientInformation = new MakerElementInstance                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SupportingPatientInformation",                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. ImmunizationRecommendation.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 2. ImmunizationRecommendation.patient
        public MakerElementInstance Element_Patient;                                                                                        // MakerGen.cs:232
        // 3. ImmunizationRecommendation.date
        public MakerElementInstance Element_Date;                                                                                           // MakerGen.cs:232
        // 4. ImmunizationRecommendation.authority
        public MakerElementInstance Element_Authority;                                                                                      // MakerGen.cs:232
        public ImmunizationRecommendation()                                                                                                 // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. ImmunizationRecommendation.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. ImmunizationRecommendation.patient
                this.Element_Patient = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. ImmunizationRecommendation.date
                this.Element_Date = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. ImmunizationRecommendation.authority
                this.Element_Authority = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Authority",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
