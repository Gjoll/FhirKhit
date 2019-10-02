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
    #endregion
    /// <summary>
    /// Fhir resource 'ImmunizationRecommendation'
    /// </summary>
    // 0. ImmunizationRecommendation
    public class Resource_ImmunizationRecommendation : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 5. ImmunizationRecommendation.recommendation
        public class Type_Recommendation : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 11. ImmunizationRecommendation.recommendation.dateCriterion
            public class Type_DateCriterion : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 12. ImmunizationRecommendation.recommendation.dateCriterion.code
                public ElementDefinitionInfo Element_Code;
                // 13. ImmunizationRecommendation.recommendation.dateCriterion.value
                public ElementDefinitionInfo Element_Value;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ImmunizationRecommendation.recommendation.dateCriterion",
                        ElementId = "ImmunizationRecommendation.recommendation.dateCriterion"
                    });
                    Element_Code.Write(sDef);
                    Element_Value.Write(sDef);
                }
                
                public Type_DateCriterion()
                {
                    {
                        // 12. ImmunizationRecommendation.recommendation.dateCriterion.code
                        this.Element_Code = new ElementDefinitionInfo
                        {
                            Name = "Element_Code",
                            Path= "ImmunizationRecommendation.recommendation.dateCriterion.code",
                            Id = "ImmunizationRecommendation.recommendation.dateCriterion.code",
                            Min = 1,
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
                        // 13. ImmunizationRecommendation.recommendation.dateCriterion.value
                        this.Element_Value = new ElementDefinitionInfo
                        {
                            Name = "Element_Value",
                            Path= "ImmunizationRecommendation.recommendation.dateCriterion.value",
                            Id = "ImmunizationRecommendation.recommendation.dateCriterion.value",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 6. ImmunizationRecommendation.recommendation.vaccineCode
            public ElementDefinitionInfo Element_VaccineCode;
            // 7. ImmunizationRecommendation.recommendation.targetDisease
            public ElementDefinitionInfo Element_TargetDisease;
            // 8. ImmunizationRecommendation.recommendation.contraindicatedVaccineCode
            public ElementDefinitionInfo Element_ContraindicatedVaccineCode;
            // 9. ImmunizationRecommendation.recommendation.forecastStatus
            public ElementDefinitionInfo Element_ForecastStatus;
            // 10. ImmunizationRecommendation.recommendation.forecastReason
            public ElementDefinitionInfo Element_ForecastReason;
            // 11. ImmunizationRecommendation.recommendation.dateCriterion
            public ElementDefinitionInfo Element_DateCriterion;
            // 14. ImmunizationRecommendation.recommendation.description
            public ElementDefinitionInfo Element_Description;
            // 15. ImmunizationRecommendation.recommendation.series
            public ElementDefinitionInfo Element_Series;
            // 16. ImmunizationRecommendation.recommendation.doseNumber[x]
            public ElementDefinitionInfo Element_DoseNumber;
            // 17. ImmunizationRecommendation.recommendation.seriesDoses[x]
            public ElementDefinitionInfo Element_SeriesDoses;
            // 18. ImmunizationRecommendation.recommendation.supportingImmunization
            public ElementDefinitionInfo Element_SupportingImmunization;
            // 19. ImmunizationRecommendation.recommendation.supportingPatientInformation
            public ElementDefinitionInfo Element_SupportingPatientInformation;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ImmunizationRecommendation.recommendation",
                    ElementId = "ImmunizationRecommendation.recommendation"
                });
                Element_VaccineCode.Write(sDef);
                Element_TargetDisease.Write(sDef);
                Element_ContraindicatedVaccineCode.Write(sDef);
                Element_ForecastStatus.Write(sDef);
                Element_ForecastReason.Write(sDef);
                Element_DateCriterion.Write(sDef);
                Element_Description.Write(sDef);
                Element_Series.Write(sDef);
                Element_DoseNumber.Write(sDef);
                Element_SeriesDoses.Write(sDef);
                Element_SupportingImmunization.Write(sDef);
                Element_SupportingPatientInformation.Write(sDef);
            }
            
            public Type_Recommendation()
            {
                {
                    // 6. ImmunizationRecommendation.recommendation.vaccineCode
                    this.Element_VaccineCode = new ElementDefinitionInfo
                    {
                        Name = "Element_VaccineCode",
                        Path= "ImmunizationRecommendation.recommendation.vaccineCode",
                        Id = "ImmunizationRecommendation.recommendation.vaccineCode",
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
                    // 7. ImmunizationRecommendation.recommendation.targetDisease
                    this.Element_TargetDisease = new ElementDefinitionInfo
                    {
                        Name = "Element_TargetDisease",
                        Path= "ImmunizationRecommendation.recommendation.targetDisease",
                        Id = "ImmunizationRecommendation.recommendation.targetDisease",
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
                    // 8. ImmunizationRecommendation.recommendation.contraindicatedVaccineCode
                    this.Element_ContraindicatedVaccineCode = new ElementDefinitionInfo
                    {
                        Name = "Element_ContraindicatedVaccineCode",
                        Path= "ImmunizationRecommendation.recommendation.contraindicatedVaccineCode",
                        Id = "ImmunizationRecommendation.recommendation.contraindicatedVaccineCode",
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
                    // 9. ImmunizationRecommendation.recommendation.forecastStatus
                    this.Element_ForecastStatus = new ElementDefinitionInfo
                    {
                        Name = "Element_ForecastStatus",
                        Path= "ImmunizationRecommendation.recommendation.forecastStatus",
                        Id = "ImmunizationRecommendation.recommendation.forecastStatus",
                        Min = 1,
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
                    // 10. ImmunizationRecommendation.recommendation.forecastReason
                    this.Element_ForecastReason = new ElementDefinitionInfo
                    {
                        Name = "Element_ForecastReason",
                        Path= "ImmunizationRecommendation.recommendation.forecastReason",
                        Id = "ImmunizationRecommendation.recommendation.forecastReason",
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
                    // 11. ImmunizationRecommendation.recommendation.dateCriterion
                    this.Element_DateCriterion = new ElementDefinitionInfo
                    {
                        Name = "Element_DateCriterion",
                        Path= "ImmunizationRecommendation.recommendation.dateCriterion",
                        Id = "ImmunizationRecommendation.recommendation.dateCriterion",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_DateCriterion
                            {
                            }
                        }
                    };
                }
                {
                    // 14. ImmunizationRecommendation.recommendation.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "ImmunizationRecommendation.recommendation.description",
                        Id = "ImmunizationRecommendation.recommendation.description",
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
                    // 15. ImmunizationRecommendation.recommendation.series
                    this.Element_Series = new ElementDefinitionInfo
                    {
                        Name = "Element_Series",
                        Path= "ImmunizationRecommendation.recommendation.series",
                        Id = "ImmunizationRecommendation.recommendation.series",
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
                    // 16. ImmunizationRecommendation.recommendation.doseNumber[x]
                    this.Element_DoseNumber = new ElementDefinitionInfo
                    {
                        Name = "Element_DoseNumber",
                        Path= "ImmunizationRecommendation.recommendation.doseNumber[x]",
                        Id = "ImmunizationRecommendation.recommendation.doseNumber[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
                {
                    // 17. ImmunizationRecommendation.recommendation.seriesDoses[x]
                    this.Element_SeriesDoses = new ElementDefinitionInfo
                    {
                        Name = "Element_SeriesDoses",
                        Path= "ImmunizationRecommendation.recommendation.seriesDoses[x]",
                        Id = "ImmunizationRecommendation.recommendation.seriesDoses[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_String
                            {
                            }
                        }
                    };
                }
                {
                    // 18. ImmunizationRecommendation.recommendation.supportingImmunization
                    this.Element_SupportingImmunization = new ElementDefinitionInfo
                    {
                        Name = "Element_SupportingImmunization",
                        Path= "ImmunizationRecommendation.recommendation.supportingImmunization",
                        Id = "ImmunizationRecommendation.recommendation.supportingImmunization",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Immunization",
                                    "http://hl7.org/fhir/StructureDefinition/ImmunizationEvaluation"
                                }
                            }
                        }
                    };
                }
                {
                    // 19. ImmunizationRecommendation.recommendation.supportingPatientInformation
                    this.Element_SupportingPatientInformation = new ElementDefinitionInfo
                    {
                        Name = "Element_SupportingPatientInformation",
                        Path= "ImmunizationRecommendation.recommendation.supportingPatientInformation",
                        Id = "ImmunizationRecommendation.recommendation.supportingPatientInformation",
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
            }
        }
        // 1. ImmunizationRecommendation.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. ImmunizationRecommendation.patient
        public ElementDefinitionInfo Element_Patient;
        // 3. ImmunizationRecommendation.date
        public ElementDefinitionInfo Element_Date;
        // 4. ImmunizationRecommendation.authority
        public ElementDefinitionInfo Element_Authority;
        // 5. ImmunizationRecommendation.recommendation
        public ElementDefinitionInfo Element_Recommendation;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ImmunizationRecommendation",
                ElementId = "ImmunizationRecommendation"
            });
            Element_Identifier.Write(sDef);
            Element_Patient.Write(sDef);
            Element_Date.Write(sDef);
            Element_Authority.Write(sDef);
            Element_Recommendation.Write(sDef);
        }
        
        public Resource_ImmunizationRecommendation()
        {
            {
                // 1. ImmunizationRecommendation.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ImmunizationRecommendation.identifier",
                    Id = "ImmunizationRecommendation.identifier",
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
                // 2. ImmunizationRecommendation.patient
                this.Element_Patient = new ElementDefinitionInfo
                {
                    Name = "Element_Patient",
                    Path= "ImmunizationRecommendation.patient",
                    Id = "ImmunizationRecommendation.patient",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient"
                            }
                        }
                    }
                };
            }
            {
                // 3. ImmunizationRecommendation.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "ImmunizationRecommendation.date",
                    Id = "ImmunizationRecommendation.date",
                    Min = 1,
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
                // 4. ImmunizationRecommendation.authority
                this.Element_Authority = new ElementDefinitionInfo
                {
                    Name = "Element_Authority",
                    Path= "ImmunizationRecommendation.authority",
                    Id = "ImmunizationRecommendation.authority",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 5. ImmunizationRecommendation.recommendation
                this.Element_Recommendation = new ElementDefinitionInfo
                {
                    Name = "Element_Recommendation",
                    Path= "ImmunizationRecommendation.recommendation",
                    Id = "ImmunizationRecommendation.recommendation",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Recommendation
                        {
                        }
                    }
                };
            }
            this.Name = "ImmunizationRecommendation";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ImmunizationRecommendation";
        }
    }
}
