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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'ImmunizationRecommendation'
    /// </summary>
    // 0. ImmunizationRecommendation
    public class Resource_ImmunizationRecommendation : FhirKhit.Maker.Common.Resource.ResourceBase                                          // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 5. ImmunizationRecommendation.recommendation
        public class Type_Recommendation : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 11. ImmunizationRecommendation.recommendation.dateCriterion
            public class Type_DateCriterion : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 12. ImmunizationRecommendation.recommendation.dateCriterion.code
                public ElementDefinitionInfo Element_Code;                                                                                  // MakerGen.cs:212
                // 13. ImmunizationRecommendation.recommendation.dateCriterion.value
                public ElementDefinitionInfo Element_Value;                                                                                 // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "ImmunizationRecommendation.recommendation.dateCriterion",                                                   // MakerGen.cs:388
                        ElementId = "ImmunizationRecommendation.recommendation.dateCriterion"                                               // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Code.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_Value.Write(sDef);                                                                                              // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_DateCriterion()                                                                                                 // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 12. ImmunizationRecommendation.recommendation.dateCriterion.code
                        this.Element_Code = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Code",                                                                                          // MakerGen.cs:231
                            Path= "ImmunizationRecommendation.recommendation.dateCriterion.code",                                           // MakerGen.cs:232
                            Id = "ImmunizationRecommendation.recommendation.dateCriterion.code",                                            // MakerGen.cs:233
                            Min = 1,                                                                                                        // MakerGen.cs:234
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
                        // 13. ImmunizationRecommendation.recommendation.dateCriterion.value
                        this.Element_Value = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Value",                                                                                         // MakerGen.cs:231
                            Path= "ImmunizationRecommendation.recommendation.dateCriterion.value",                                          // MakerGen.cs:232
                            Id = "ImmunizationRecommendation.recommendation.dateCriterion.value",                                           // MakerGen.cs:233
                            Min = 1,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                      // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 6. ImmunizationRecommendation.recommendation.vaccineCode
            public ElementDefinitionInfo Element_VaccineCode;                                                                               // MakerGen.cs:212
            // 7. ImmunizationRecommendation.recommendation.targetDisease
            public ElementDefinitionInfo Element_TargetDisease;                                                                             // MakerGen.cs:212
            // 8. ImmunizationRecommendation.recommendation.contraindicatedVaccineCode
            public ElementDefinitionInfo Element_ContraindicatedVaccineCode;                                                                // MakerGen.cs:212
            // 9. ImmunizationRecommendation.recommendation.forecastStatus
            public ElementDefinitionInfo Element_ForecastStatus;                                                                            // MakerGen.cs:212
            // 10. ImmunizationRecommendation.recommendation.forecastReason
            public ElementDefinitionInfo Element_ForecastReason;                                                                            // MakerGen.cs:212
            // 11. ImmunizationRecommendation.recommendation.dateCriterion
            public ElementDefinitionInfo Element_DateCriterion;                                                                             // MakerGen.cs:212
            // 14. ImmunizationRecommendation.recommendation.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:212
            // 15. ImmunizationRecommendation.recommendation.series
            public ElementDefinitionInfo Element_Series;                                                                                    // MakerGen.cs:212
            // 16. ImmunizationRecommendation.recommendation.doseNumber[x]
            public ElementDefinitionInfo Element_DoseNumber;                                                                                // MakerGen.cs:212
            // 17. ImmunizationRecommendation.recommendation.seriesDoses[x]
            public ElementDefinitionInfo Element_SeriesDoses;                                                                               // MakerGen.cs:212
            // 18. ImmunizationRecommendation.recommendation.supportingImmunization
            public ElementDefinitionInfo Element_SupportingImmunization;                                                                    // MakerGen.cs:212
            // 19. ImmunizationRecommendation.recommendation.supportingPatientInformation
            public ElementDefinitionInfo Element_SupportingPatientInformation;                                                              // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "ImmunizationRecommendation.recommendation",                                                                     // MakerGen.cs:388
                    ElementId = "ImmunizationRecommendation.recommendation"                                                                 // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_VaccineCode.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_TargetDisease.Write(sDef);                                                                                          // MakerGen.cs:216
                Element_ContraindicatedVaccineCode.Write(sDef);                                                                             // MakerGen.cs:216
                Element_ForecastStatus.Write(sDef);                                                                                         // MakerGen.cs:216
                Element_ForecastReason.Write(sDef);                                                                                         // MakerGen.cs:216
                Element_DateCriterion.Write(sDef);                                                                                          // MakerGen.cs:216
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_Series.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_DoseNumber.Write(sDef);                                                                                             // MakerGen.cs:216
                Element_SeriesDoses.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_SupportingImmunization.Write(sDef);                                                                                 // MakerGen.cs:216
                Element_SupportingPatientInformation.Write(sDef);                                                                           // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Recommendation()                                                                                                    // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 6. ImmunizationRecommendation.recommendation.vaccineCode
                    this.Element_VaccineCode = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_VaccineCode",                                                                                       // MakerGen.cs:231
                        Path= "ImmunizationRecommendation.recommendation.vaccineCode",                                                      // MakerGen.cs:232
                        Id = "ImmunizationRecommendation.recommendation.vaccineCode",                                                       // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 7. ImmunizationRecommendation.recommendation.targetDisease
                    this.Element_TargetDisease = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_TargetDisease",                                                                                     // MakerGen.cs:231
                        Path= "ImmunizationRecommendation.recommendation.targetDisease",                                                    // MakerGen.cs:232
                        Id = "ImmunizationRecommendation.recommendation.targetDisease",                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 8. ImmunizationRecommendation.recommendation.contraindicatedVaccineCode
                    this.Element_ContraindicatedVaccineCode = new ElementDefinitionInfo                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_ContraindicatedVaccineCode",                                                                        // MakerGen.cs:231
                        Path= "ImmunizationRecommendation.recommendation.contraindicatedVaccineCode",                                       // MakerGen.cs:232
                        Id = "ImmunizationRecommendation.recommendation.contraindicatedVaccineCode",                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 9. ImmunizationRecommendation.recommendation.forecastStatus
                    this.Element_ForecastStatus = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_ForecastStatus",                                                                                    // MakerGen.cs:231
                        Path= "ImmunizationRecommendation.recommendation.forecastStatus",                                                   // MakerGen.cs:232
                        Id = "ImmunizationRecommendation.recommendation.forecastStatus",                                                    // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 10. ImmunizationRecommendation.recommendation.forecastReason
                    this.Element_ForecastReason = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_ForecastReason",                                                                                    // MakerGen.cs:231
                        Path= "ImmunizationRecommendation.recommendation.forecastReason",                                                   // MakerGen.cs:232
                        Id = "ImmunizationRecommendation.recommendation.forecastReason",                                                    // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 11. ImmunizationRecommendation.recommendation.dateCriterion
                    this.Element_DateCriterion = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_DateCriterion",                                                                                     // MakerGen.cs:231
                        Path= "ImmunizationRecommendation.recommendation.dateCriterion",                                                    // MakerGen.cs:232
                        Id = "ImmunizationRecommendation.recommendation.dateCriterion",                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_DateCriterion                                                                                          // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 14. ImmunizationRecommendation.recommendation.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Description",                                                                                       // MakerGen.cs:231
                        Path= "ImmunizationRecommendation.recommendation.description",                                                      // MakerGen.cs:232
                        Id = "ImmunizationRecommendation.recommendation.description",                                                       // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 15. ImmunizationRecommendation.recommendation.series
                    this.Element_Series = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Series",                                                                                            // MakerGen.cs:231
                        Path= "ImmunizationRecommendation.recommendation.series",                                                           // MakerGen.cs:232
                        Id = "ImmunizationRecommendation.recommendation.series",                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 16. ImmunizationRecommendation.recommendation.doseNumber[x]
                    this.Element_DoseNumber = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_DoseNumber",                                                                                        // MakerGen.cs:231
                        Path= "ImmunizationRecommendation.recommendation.doseNumber[x]",                                                    // MakerGen.cs:232
                        Id = "ImmunizationRecommendation.recommendation.doseNumber[x]",                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                       // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            },                                                                                                              // MakerGen.cs:300
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 17. ImmunizationRecommendation.recommendation.seriesDoses[x]
                    this.Element_SeriesDoses = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_SeriesDoses",                                                                                       // MakerGen.cs:231
                        Path= "ImmunizationRecommendation.recommendation.seriesDoses[x]",                                                   // MakerGen.cs:232
                        Id = "ImmunizationRecommendation.recommendation.seriesDoses[x]",                                                    // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                       // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            },                                                                                                              // MakerGen.cs:300
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 18. ImmunizationRecommendation.recommendation.supportingImmunization
                    this.Element_SupportingImmunization = new ElementDefinitionInfo                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_SupportingImmunization",                                                                            // MakerGen.cs:231
                        Path= "ImmunizationRecommendation.recommendation.supportingImmunization",                                           // MakerGen.cs:232
                        Id = "ImmunizationRecommendation.recommendation.supportingImmunization",                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Immunization",                                                 // MakerGen.cs:342
                                    "http://hl7.org/fhir/StructureDefinition/ImmunizationEvaluation"                                        // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 19. ImmunizationRecommendation.recommendation.supportingPatientInformation
                    this.Element_SupportingPatientInformation = new ElementDefinitionInfo                                                   // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_SupportingPatientInformation",                                                                      // MakerGen.cs:231
                        Path= "ImmunizationRecommendation.recommendation.supportingPatientInformation",                                     // MakerGen.cs:232
                        Id = "ImmunizationRecommendation.recommendation.supportingPatientInformation",                                      // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. ImmunizationRecommendation.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 2. ImmunizationRecommendation.patient
        public ElementDefinitionInfo Element_Patient;                                                                                       // MakerGen.cs:212
        // 3. ImmunizationRecommendation.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:212
        // 4. ImmunizationRecommendation.authority
        public ElementDefinitionInfo Element_Authority;                                                                                     // MakerGen.cs:212
        // 5. ImmunizationRecommendation.recommendation
        public ElementDefinitionInfo Element_Recommendation;                                                                                // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "ImmunizationRecommendation",                                                                                        // MakerGen.cs:388
                ElementId = "ImmunizationRecommendation"                                                                                    // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Patient.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Date.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Authority.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Recommendation.Write(sDef);                                                                                             // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_ImmunizationRecommendation()                                                                                        // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. ImmunizationRecommendation.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "ImmunizationRecommendation.identifier",                                                                          // MakerGen.cs:232
                    Id = "ImmunizationRecommendation.identifier",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. ImmunizationRecommendation.patient
                this.Element_Patient = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Patient",                                                                                               // MakerGen.cs:231
                    Path= "ImmunizationRecommendation.patient",                                                                             // MakerGen.cs:232
                    Id = "ImmunizationRecommendation.patient",                                                                              // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient"                                                           // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. ImmunizationRecommendation.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:231
                    Path= "ImmunizationRecommendation.date",                                                                                // MakerGen.cs:232
                    Id = "ImmunizationRecommendation.date",                                                                                 // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
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
                // 4. ImmunizationRecommendation.authority
                this.Element_Authority = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Authority",                                                                                             // MakerGen.cs:231
                    Path= "ImmunizationRecommendation.authority",                                                                           // MakerGen.cs:232
                    Id = "ImmunizationRecommendation.authority",                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. ImmunizationRecommendation.recommendation
                this.Element_Recommendation = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Recommendation",                                                                                        // MakerGen.cs:231
                    Path= "ImmunizationRecommendation.recommendation",                                                                      // MakerGen.cs:232
                    Id = "ImmunizationRecommendation.recommendation",                                                                       // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Recommendation                                                                                             // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "ImmunizationRecommendation";                                                                                       // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation";                                                // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
