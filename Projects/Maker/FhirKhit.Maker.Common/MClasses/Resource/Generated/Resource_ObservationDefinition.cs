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
      "id": "ObservationDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/ObservationDefinition",
      "version": "4.0.0",
      "name": "ObservationDefinition",
      "status": "draft",
      "publisher": "Health Level Seven International (Orders and Observations)",
      "description": "Set of definitional characteristics for a kind of observation or measurement produced or consumed by an orderable health care service.",
      "purpose": "In a catalog of health-related services that use or produce observations and measurements, this resource describes the expected characteristics of these observation / measurements.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ObservationDefinition",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ObservationDefinition",
            "path": "ObservationDefinition",
            "short": "Definition of an observation",
            "definition": "Set of definitional characteristics for a kind of observation or measurement produced or consumed by an orderable health care service.",
            "comment": "An instance of this resource informs the consumer of a health-related service (such as a lab diagnostic test or panel) about how the observations used or produced by this service will look like.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ObservationDefinition.category",
            "path": "ObservationDefinition.category",
            "short": "Category of observation",
            "definition": "A code that classifies the general type of observation.",
            "comment": "This element allows various categorization schemes based on the owner’s definition of the category and effectively multiple categories can be used for one instance of ObservationDefinition. The level of granularity is defined by the category concepts in the value set.",
            "requirements": "Used for filtering what kinds of observations are retrieved and displayed.",
            "alias": [
              "Class of observation"
            ],
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
                  "valueString": "ObservationCategory"
                }
              ],
              "strength": "example",
              "description": "Codes for high level observation categories.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-category"
            }
          },
          {
            "id": "ObservationDefinition.code",
            "path": "ObservationDefinition.code",
            "short": "Type of observation (code / type)",
            "definition": "Describes what will be observed. Sometimes this is called the observation \"name\".",
            "requirements": "Knowing what kind of observation is being made is essential to understanding the observation.",
            "alias": [
              "Name"
            ],
            "min": 1,
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
                  "valueString": "ObservationCode"
                }
              ],
              "strength": "example",
              "description": "Codes identifying names of simple observations.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-codes"
            }
          },
          {
            "id": "ObservationDefinition.identifier",
            "path": "ObservationDefinition.identifier",
            "short": "Business identifier for this ObservationDefinition instance",
            "definition": "A unique identifier assigned to this ObservationDefinition artifact.",
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
            "id": "ObservationDefinition.permittedDataType",
            "path": "ObservationDefinition.permittedDataType",
            "short": "Quantity | CodeableConcept | string | boolean | integer | Range | Ratio | SampledData | time | dateTime | Period",
            "definition": "The data types allowed for the value element of the instance observations conforming to this ObservationDefinition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "code"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueCode": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ObservationDataType"
                }
              ],
              "strength": "required",
              "description": "Permitted data type for observation value.",
              "valueSet": "http://hl7.org/fhir/ValueSet/permitted-data-type|4.0.0"
            }
          },
          {
            "id": "ObservationDefinition.multipleResultsAllowed",
            "path": "ObservationDefinition.multipleResultsAllowed",
            "short": "Multiple results allowed",
            "definition": "Multiple results allowed for observations conforming to this ObservationDefinition.",
            "comment": "An example of observation allowing multiple results is \"bacteria identified by culture\". Conversely, the measurement of a potassium level allows a single result.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueBoolean": true
              }
            ]
          },
          {
            "id": "ObservationDefinition.method",
            "path": "ObservationDefinition.method",
            "short": "Method used to produce the observation",
            "definition": "The method or technique used to perform the observation.",
            "comment": "Only used if not implicit in observation code.",
            "requirements": "In some cases, method can impact results.",
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
                  "valueString": "ObservationMethod"
                }
              ],
              "strength": "example",
              "description": "Methods for simple observations.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-methods"
            }
          },
          {
            "id": "ObservationDefinition.preferredReportName",
            "path": "ObservationDefinition.preferredReportName",
            "short": "Preferred report name",
            "definition": "The preferred name to be used when reporting the results of observations conforming to this ObservationDefinition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ObservationDefinition.quantitativeDetails",
            "path": "ObservationDefinition.quantitativeDetails",
            "short": "Characteristics of quantitative results",
            "definition": "Characteristics for quantitative results of this observation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ObservationDefinition.quantitativeDetails.customaryUnit",
            "path": "ObservationDefinition.quantitativeDetails.customaryUnit",
            "short": "Customary unit for quantitative results",
            "definition": "Customary unit used to report quantitative results of observations conforming to this ObservationDefinition.",
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
                  "valueString": "ObservationUnit"
                }
              ],
              "strength": "extensible",
              "description": "Codes identifying units of measure.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ucum-units"
            }
          },
          {
            "id": "ObservationDefinition.quantitativeDetails.unit",
            "path": "ObservationDefinition.quantitativeDetails.unit",
            "short": "SI unit for quantitative results",
            "definition": "SI unit used to report quantitative results of observations conforming to this ObservationDefinition.",
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
                  "valueString": "ObservationUnit"
                }
              ],
              "strength": "extensible",
              "description": "Codes identifying units of measure.",
              "valueSet": "http://hl7.org/fhir/ValueSet/ucum-units"
            }
          },
          {
            "id": "ObservationDefinition.quantitativeDetails.conversionFactor",
            "path": "ObservationDefinition.quantitativeDetails.conversionFactor",
            "short": "SI to Customary unit conversion factor",
            "definition": "Factor for converting value expressed with SI unit to value expressed with customary unit.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "ObservationDefinition.quantitativeDetails.decimalPrecision",
            "path": "ObservationDefinition.quantitativeDetails.decimalPrecision",
            "short": "Decimal precision of observation quantitative results",
            "definition": "Number of digits after decimal separator when the results of such observations are of type Quantity.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "ObservationDefinition.qualifiedInterval",
            "path": "ObservationDefinition.qualifiedInterval",
            "short": "Qualified range for continuous and ordinal observation results",
            "definition": "Multiple  ranges of results qualified by different contexts for ordinal or continuous observations conforming to this ObservationDefinition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ObservationDefinition.qualifiedInterval.category",
            "path": "ObservationDefinition.qualifiedInterval.category",
            "short": "reference | critical | absolute",
            "definition": "The category of interval of values for continuous or ordinal observations conforming to this ObservationDefinition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueCode": "critical"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ObservationRangeCategory"
                }
              ],
              "strength": "required",
              "description": "Codes identifying the category of observation range.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-range-category|4.0.0"
            }
          },
          {
            "id": "ObservationDefinition.qualifiedInterval.range",
            "path": "ObservationDefinition.qualifiedInterval.range",
            "short": "The interval itself, for continuous or ordinal observations",
            "definition": "The low and high values determining the interval. There may be only one of the two.",
            "requirements": "The unit may be not relevant for ordinal values. In case it is there, it is the same as quantitativeDetails.unit.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Range"
              }
            ]
          },
          {
            "id": "ObservationDefinition.qualifiedInterval.context",
            "path": "ObservationDefinition.qualifiedInterval.context",
            "short": "Range context qualifier",
            "definition": "Codes to indicate the health context the range applies to. For example, the normal or therapeutic range.",
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
                  "valueString": "ObservationRangeMeaning"
                }
              ],
              "strength": "extensible",
              "description": "Code identifying the health context of a range.",
              "valueSet": "http://hl7.org/fhir/ValueSet/referencerange-meaning"
            }
          },
          {
            "id": "ObservationDefinition.qualifiedInterval.appliesTo",
            "path": "ObservationDefinition.qualifiedInterval.appliesTo",
            "short": "Targetted population of the range",
            "definition": "Codes to indicate the target population this reference range applies to.",
            "comment": "If this element is not present then the global population is assumed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ObservationRangeAppliesTo"
                }
              ],
              "strength": "example",
              "description": "Codes identifying the population the reference range applies to.",
              "valueSet": "http://hl7.org/fhir/ValueSet/referencerange-appliesto"
            }
          },
          {
            "id": "ObservationDefinition.qualifiedInterval.gender",
            "path": "ObservationDefinition.qualifiedInterval.gender",
            "short": "male | female | other | unknown",
            "definition": "Sex of the population the range applies to.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueCode": "female"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AdministrativeGender"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The gender of a person used for administrative purposes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/administrative-gender|4.0.0"
            }
          },
          {
            "id": "ObservationDefinition.qualifiedInterval.age",
            "path": "ObservationDefinition.qualifiedInterval.age",
            "short": "Applicable age range, if relevant",
            "definition": "The age at which this reference range is applicable. This is a neonatal age (e.g. number of weeks at term) if the meaning says so.",
            "comment": "Some analytes vary greatly over age.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Range"
              }
            ]
          },
          {
            "id": "ObservationDefinition.qualifiedInterval.gestationalAge",
            "path": "ObservationDefinition.qualifiedInterval.gestationalAge",
            "short": "Applicable gestational age range, if relevant",
            "definition": "The gestational age to which this reference range is applicable, in the context of pregnancy.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Range"
              }
            ]
          },
          {
            "id": "ObservationDefinition.qualifiedInterval.condition",
            "path": "ObservationDefinition.qualifiedInterval.condition",
            "short": "Condition associated with the reference range",
            "definition": "Text based condition for which the reference range is valid.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ObservationDefinition.validCodedValueSet",
            "path": "ObservationDefinition.validCodedValueSet",
            "short": "Value set of valid coded values for the observations conforming to this ObservationDefinition",
            "definition": "The set of valid coded results for the observations  conforming to this ObservationDefinition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ValueSet"
                ]
              }
            ]
          },
          {
            "id": "ObservationDefinition.normalCodedValueSet",
            "path": "ObservationDefinition.normalCodedValueSet",
            "short": "Value set of normal coded values for the observations conforming to this ObservationDefinition",
            "definition": "The set of normal coded results for the observations conforming to this ObservationDefinition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ValueSet"
                ]
              }
            ]
          },
          {
            "id": "ObservationDefinition.abnormalCodedValueSet",
            "path": "ObservationDefinition.abnormalCodedValueSet",
            "short": "Value set of abnormal coded values for the observations conforming to this ObservationDefinition",
            "definition": "The set of abnormal coded results for the observation conforming to this ObservationDefinition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ValueSet"
                ]
              }
            ]
          },
          {
            "id": "ObservationDefinition.criticalCodedValueSet",
            "path": "ObservationDefinition.criticalCodedValueSet",
            "short": "Value set of critical coded values for the observations conforming to this ObservationDefinition",
            "definition": "The set of critical coded results for the observation conforming to this ObservationDefinition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ValueSet"
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
    /// Fhir resource 'ObservationDefinition'
    /// </summary>
    // 0. ObservationDefinition
    public class Resource_ObservationDefinition : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 8. ObservationDefinition.quantitativeDetails
        public class Type_QuantitativeDetails : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 9. ObservationDefinition.quantitativeDetails.customaryUnit
            public ElementDefinitionInfo Element_CustomaryUnit;
            // 10. ObservationDefinition.quantitativeDetails.unit
            public ElementDefinitionInfo Element_Unit;
            // 11. ObservationDefinition.quantitativeDetails.conversionFactor
            public ElementDefinitionInfo Element_ConversionFactor;
            // 12. ObservationDefinition.quantitativeDetails.decimalPrecision
            public ElementDefinitionInfo Element_DecimalPrecision;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ObservationDefinition.quantitativeDetails",
                    ElementId = "ObservationDefinition.quantitativeDetails"
                });
                Element_CustomaryUnit.Write(sDef);
                Element_Unit.Write(sDef);
                Element_ConversionFactor.Write(sDef);
                Element_DecimalPrecision.Write(sDef);
            }
            
            public Type_QuantitativeDetails()
            {
                {
                    // 9. ObservationDefinition.quantitativeDetails.customaryUnit
                    this.Element_CustomaryUnit = new ElementDefinitionInfo
                    {
                        Name = "Element_CustomaryUnit",
                        Path= "ObservationDefinition.quantitativeDetails.customaryUnit",
                        Id = "ObservationDefinition.quantitativeDetails.customaryUnit",
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
                    // 10. ObservationDefinition.quantitativeDetails.unit
                    this.Element_Unit = new ElementDefinitionInfo
                    {
                        Name = "Element_Unit",
                        Path= "ObservationDefinition.quantitativeDetails.unit",
                        Id = "ObservationDefinition.quantitativeDetails.unit",
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
                    // 11. ObservationDefinition.quantitativeDetails.conversionFactor
                    this.Element_ConversionFactor = new ElementDefinitionInfo
                    {
                        Name = "Element_ConversionFactor",
                        Path= "ObservationDefinition.quantitativeDetails.conversionFactor",
                        Id = "ObservationDefinition.quantitativeDetails.conversionFactor",
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
                    // 12. ObservationDefinition.quantitativeDetails.decimalPrecision
                    this.Element_DecimalPrecision = new ElementDefinitionInfo
                    {
                        Name = "Element_DecimalPrecision",
                        Path= "ObservationDefinition.quantitativeDetails.decimalPrecision",
                        Id = "ObservationDefinition.quantitativeDetails.decimalPrecision",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                            {
                            }
                        }
                    };
                }
            }
        }
        // 13. ObservationDefinition.qualifiedInterval
        public class Type_QualifiedInterval : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 14. ObservationDefinition.qualifiedInterval.category
            public ElementDefinitionInfo Element_Category;
            // 15. ObservationDefinition.qualifiedInterval.range
            public ElementDefinitionInfo Element_Range;
            // 16. ObservationDefinition.qualifiedInterval.context
            public ElementDefinitionInfo Element_Context;
            // 17. ObservationDefinition.qualifiedInterval.appliesTo
            public ElementDefinitionInfo Element_AppliesTo;
            // 18. ObservationDefinition.qualifiedInterval.gender
            public ElementDefinitionInfo Element_Gender;
            // 19. ObservationDefinition.qualifiedInterval.age
            public ElementDefinitionInfo Element_Age;
            // 20. ObservationDefinition.qualifiedInterval.gestationalAge
            public ElementDefinitionInfo Element_GestationalAge;
            // 21. ObservationDefinition.qualifiedInterval.condition
            public ElementDefinitionInfo Element_Condition;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ObservationDefinition.qualifiedInterval",
                    ElementId = "ObservationDefinition.qualifiedInterval"
                });
                Element_Category.Write(sDef);
                Element_Range.Write(sDef);
                Element_Context.Write(sDef);
                Element_AppliesTo.Write(sDef);
                Element_Gender.Write(sDef);
                Element_Age.Write(sDef);
                Element_GestationalAge.Write(sDef);
                Element_Condition.Write(sDef);
            }
            
            public Type_QualifiedInterval()
            {
                {
                    // 14. ObservationDefinition.qualifiedInterval.category
                    this.Element_Category = new ElementDefinitionInfo
                    {
                        Name = "Element_Category",
                        Path= "ObservationDefinition.qualifiedInterval.category",
                        Id = "ObservationDefinition.qualifiedInterval.category",
                        Min = 0,
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
                    // 15. ObservationDefinition.qualifiedInterval.range
                    this.Element_Range = new ElementDefinitionInfo
                    {
                        Name = "Element_Range",
                        Path= "ObservationDefinition.qualifiedInterval.range",
                        Id = "ObservationDefinition.qualifiedInterval.range",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            }
                        }
                    };
                }
                {
                    // 16. ObservationDefinition.qualifiedInterval.context
                    this.Element_Context = new ElementDefinitionInfo
                    {
                        Name = "Element_Context",
                        Path= "ObservationDefinition.qualifiedInterval.context",
                        Id = "ObservationDefinition.qualifiedInterval.context",
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
                    // 17. ObservationDefinition.qualifiedInterval.appliesTo
                    this.Element_AppliesTo = new ElementDefinitionInfo
                    {
                        Name = "Element_AppliesTo",
                        Path= "ObservationDefinition.qualifiedInterval.appliesTo",
                        Id = "ObservationDefinition.qualifiedInterval.appliesTo",
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
                    // 18. ObservationDefinition.qualifiedInterval.gender
                    this.Element_Gender = new ElementDefinitionInfo
                    {
                        Name = "Element_Gender",
                        Path= "ObservationDefinition.qualifiedInterval.gender",
                        Id = "ObservationDefinition.qualifiedInterval.gender",
                        Min = 0,
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
                    // 19. ObservationDefinition.qualifiedInterval.age
                    this.Element_Age = new ElementDefinitionInfo
                    {
                        Name = "Element_Age",
                        Path= "ObservationDefinition.qualifiedInterval.age",
                        Id = "ObservationDefinition.qualifiedInterval.age",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            }
                        }
                    };
                }
                {
                    // 20. ObservationDefinition.qualifiedInterval.gestationalAge
                    this.Element_GestationalAge = new ElementDefinitionInfo
                    {
                        Name = "Element_GestationalAge",
                        Path= "ObservationDefinition.qualifiedInterval.gestationalAge",
                        Id = "ObservationDefinition.qualifiedInterval.gestationalAge",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            }
                        }
                    };
                }
                {
                    // 21. ObservationDefinition.qualifiedInterval.condition
                    this.Element_Condition = new ElementDefinitionInfo
                    {
                        Name = "Element_Condition",
                        Path= "ObservationDefinition.qualifiedInterval.condition",
                        Id = "ObservationDefinition.qualifiedInterval.condition",
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
        // 1. ObservationDefinition.category
        public ElementDefinitionInfo Element_Category;
        // 2. ObservationDefinition.code
        public ElementDefinitionInfo Element_Code;
        // 3. ObservationDefinition.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 4. ObservationDefinition.permittedDataType
        public ElementDefinitionInfo Element_PermittedDataType;
        // 5. ObservationDefinition.multipleResultsAllowed
        public ElementDefinitionInfo Element_MultipleResultsAllowed;
        // 6. ObservationDefinition.method
        public ElementDefinitionInfo Element_Method;
        // 7. ObservationDefinition.preferredReportName
        public ElementDefinitionInfo Element_PreferredReportName;
        // 8. ObservationDefinition.quantitativeDetails
        public ElementDefinitionInfo Element_QuantitativeDetails;
        // 13. ObservationDefinition.qualifiedInterval
        public ElementDefinitionInfo Element_QualifiedInterval;
        // 22. ObservationDefinition.validCodedValueSet
        public ElementDefinitionInfo Element_ValidCodedValueSet;
        // 23. ObservationDefinition.normalCodedValueSet
        public ElementDefinitionInfo Element_NormalCodedValueSet;
        // 24. ObservationDefinition.abnormalCodedValueSet
        public ElementDefinitionInfo Element_AbnormalCodedValueSet;
        // 25. ObservationDefinition.criticalCodedValueSet
        public ElementDefinitionInfo Element_CriticalCodedValueSet;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ObservationDefinition",
                ElementId = "ObservationDefinition"
            });
            Element_Category.Write(sDef);
            Element_Code.Write(sDef);
            Element_Identifier.Write(sDef);
            Element_PermittedDataType.Write(sDef);
            Element_MultipleResultsAllowed.Write(sDef);
            Element_Method.Write(sDef);
            Element_PreferredReportName.Write(sDef);
            Element_QuantitativeDetails.Write(sDef);
            Element_QualifiedInterval.Write(sDef);
            Element_ValidCodedValueSet.Write(sDef);
            Element_NormalCodedValueSet.Write(sDef);
            Element_AbnormalCodedValueSet.Write(sDef);
            Element_CriticalCodedValueSet.Write(sDef);
        }
        
        public Resource_ObservationDefinition()
        {
            {
                // 1. ObservationDefinition.category
                this.Element_Category = new ElementDefinitionInfo
                {
                    Name = "Element_Category",
                    Path= "ObservationDefinition.category",
                    Id = "ObservationDefinition.category",
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
                // 2. ObservationDefinition.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "ObservationDefinition.code",
                    Id = "ObservationDefinition.code",
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
                // 3. ObservationDefinition.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ObservationDefinition.identifier",
                    Id = "ObservationDefinition.identifier",
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
                // 4. ObservationDefinition.permittedDataType
                this.Element_PermittedDataType = new ElementDefinitionInfo
                {
                    Name = "Element_PermittedDataType",
                    Path= "ObservationDefinition.permittedDataType",
                    Id = "ObservationDefinition.permittedDataType",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 5. ObservationDefinition.multipleResultsAllowed
                this.Element_MultipleResultsAllowed = new ElementDefinitionInfo
                {
                    Name = "Element_MultipleResultsAllowed",
                    Path= "ObservationDefinition.multipleResultsAllowed",
                    Id = "ObservationDefinition.multipleResultsAllowed",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                        {
                        }
                    }
                };
            }
            {
                // 6. ObservationDefinition.method
                this.Element_Method = new ElementDefinitionInfo
                {
                    Name = "Element_Method",
                    Path= "ObservationDefinition.method",
                    Id = "ObservationDefinition.method",
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
                // 7. ObservationDefinition.preferredReportName
                this.Element_PreferredReportName = new ElementDefinitionInfo
                {
                    Name = "Element_PreferredReportName",
                    Path= "ObservationDefinition.preferredReportName",
                    Id = "ObservationDefinition.preferredReportName",
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
                // 8. ObservationDefinition.quantitativeDetails
                this.Element_QuantitativeDetails = new ElementDefinitionInfo
                {
                    Name = "Element_QuantitativeDetails",
                    Path= "ObservationDefinition.quantitativeDetails",
                    Id = "ObservationDefinition.quantitativeDetails",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_QuantitativeDetails
                        {
                        }
                    }
                };
            }
            {
                // 13. ObservationDefinition.qualifiedInterval
                this.Element_QualifiedInterval = new ElementDefinitionInfo
                {
                    Name = "Element_QualifiedInterval",
                    Path= "ObservationDefinition.qualifiedInterval",
                    Id = "ObservationDefinition.qualifiedInterval",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_QualifiedInterval
                        {
                        }
                    }
                };
            }
            {
                // 22. ObservationDefinition.validCodedValueSet
                this.Element_ValidCodedValueSet = new ElementDefinitionInfo
                {
                    Name = "Element_ValidCodedValueSet",
                    Path= "ObservationDefinition.validCodedValueSet",
                    Id = "ObservationDefinition.validCodedValueSet",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ValueSet"
                            }
                        }
                    }
                };
            }
            {
                // 23. ObservationDefinition.normalCodedValueSet
                this.Element_NormalCodedValueSet = new ElementDefinitionInfo
                {
                    Name = "Element_NormalCodedValueSet",
                    Path= "ObservationDefinition.normalCodedValueSet",
                    Id = "ObservationDefinition.normalCodedValueSet",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ValueSet"
                            }
                        }
                    }
                };
            }
            {
                // 24. ObservationDefinition.abnormalCodedValueSet
                this.Element_AbnormalCodedValueSet = new ElementDefinitionInfo
                {
                    Name = "Element_AbnormalCodedValueSet",
                    Path= "ObservationDefinition.abnormalCodedValueSet",
                    Id = "ObservationDefinition.abnormalCodedValueSet",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ValueSet"
                            }
                        }
                    }
                };
            }
            {
                // 25. ObservationDefinition.criticalCodedValueSet
                this.Element_CriticalCodedValueSet = new ElementDefinitionInfo
                {
                    Name = "Element_CriticalCodedValueSet",
                    Path= "ObservationDefinition.criticalCodedValueSet",
                    Id = "ObservationDefinition.criticalCodedValueSet",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ValueSet"
                            }
                        }
                    }
                };
            }
            this.Name = "ObservationDefinition";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ObservationDefinition";
        }
    }
}
