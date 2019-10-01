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
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'ObservationDefinition'
    /// </summary>
    // 0. ObservationDefinition
    public class Resource_ObservationDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                               // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 8. ObservationDefinition.quantitativeDetails
        public class Type_QuantitativeDetails : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 9. ObservationDefinition.quantitativeDetails.customaryUnit
            public ElementDefinitionInfo Element_CustomaryUnit;                                                                             // MakerGen.cs:212
            // 10. ObservationDefinition.quantitativeDetails.unit
            public ElementDefinitionInfo Element_Unit;                                                                                      // MakerGen.cs:212
            // 11. ObservationDefinition.quantitativeDetails.conversionFactor
            public ElementDefinitionInfo Element_ConversionFactor;                                                                          // MakerGen.cs:212
            // 12. ObservationDefinition.quantitativeDetails.decimalPrecision
            public ElementDefinitionInfo Element_DecimalPrecision;                                                                          // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "ObservationDefinition.quantitativeDetails",                                                                     // MakerGen.cs:388
                    ElementId = "ObservationDefinition.quantitativeDetails"                                                                 // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_CustomaryUnit.Write(sDef);                                                                                          // MakerGen.cs:216
                Element_Unit.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_ConversionFactor.Write(sDef);                                                                                       // MakerGen.cs:216
                Element_DecimalPrecision.Write(sDef);                                                                                       // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_QuantitativeDetails()                                                                                               // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 9. ObservationDefinition.quantitativeDetails.customaryUnit
                    this.Element_CustomaryUnit = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_CustomaryUnit",                                                                                     // MakerGen.cs:231
                        Path= "ObservationDefinition.quantitativeDetails.customaryUnit",                                                    // MakerGen.cs:232
                        Id = "ObservationDefinition.quantitativeDetails.customaryUnit",                                                     // MakerGen.cs:233
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
                    // 10. ObservationDefinition.quantitativeDetails.unit
                    this.Element_Unit = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Unit",                                                                                              // MakerGen.cs:231
                        Path= "ObservationDefinition.quantitativeDetails.unit",                                                             // MakerGen.cs:232
                        Id = "ObservationDefinition.quantitativeDetails.unit",                                                              // MakerGen.cs:233
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
                    // 11. ObservationDefinition.quantitativeDetails.conversionFactor
                    this.Element_ConversionFactor = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_ConversionFactor",                                                                                  // MakerGen.cs:231
                        Path= "ObservationDefinition.quantitativeDetails.conversionFactor",                                                 // MakerGen.cs:232
                        Id = "ObservationDefinition.quantitativeDetails.conversionFactor",                                                  // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 12. ObservationDefinition.quantitativeDetails.decimalPrecision
                    this.Element_DecimalPrecision = new ElementDefinitionInfo                                                               // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_DecimalPrecision",                                                                                  // MakerGen.cs:231
                        Path= "ObservationDefinition.quantitativeDetails.decimalPrecision",                                                 // MakerGen.cs:232
                        Id = "ObservationDefinition.quantitativeDetails.decimalPrecision",                                                  // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 13. ObservationDefinition.qualifiedInterval
        public class Type_QualifiedInterval : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 14. ObservationDefinition.qualifiedInterval.category
            public ElementDefinitionInfo Element_Category;                                                                                  // MakerGen.cs:212
            // 15. ObservationDefinition.qualifiedInterval.range
            public ElementDefinitionInfo Element_Range;                                                                                     // MakerGen.cs:212
            // 16. ObservationDefinition.qualifiedInterval.context
            public ElementDefinitionInfo Element_Context;                                                                                   // MakerGen.cs:212
            // 17. ObservationDefinition.qualifiedInterval.appliesTo
            public ElementDefinitionInfo Element_AppliesTo;                                                                                 // MakerGen.cs:212
            // 18. ObservationDefinition.qualifiedInterval.gender
            public ElementDefinitionInfo Element_Gender;                                                                                    // MakerGen.cs:212
            // 19. ObservationDefinition.qualifiedInterval.age
            public ElementDefinitionInfo Element_Age;                                                                                       // MakerGen.cs:212
            // 20. ObservationDefinition.qualifiedInterval.gestationalAge
            public ElementDefinitionInfo Element_GestationalAge;                                                                            // MakerGen.cs:212
            // 21. ObservationDefinition.qualifiedInterval.condition
            public ElementDefinitionInfo Element_Condition;                                                                                 // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "ObservationDefinition.qualifiedInterval",                                                                       // MakerGen.cs:388
                    ElementId = "ObservationDefinition.qualifiedInterval"                                                                   // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Category.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Range.Write(sDef);                                                                                                  // MakerGen.cs:216
                Element_Context.Write(sDef);                                                                                                // MakerGen.cs:216
                Element_AppliesTo.Write(sDef);                                                                                              // MakerGen.cs:216
                Element_Gender.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Age.Write(sDef);                                                                                                    // MakerGen.cs:216
                Element_GestationalAge.Write(sDef);                                                                                         // MakerGen.cs:216
                Element_Condition.Write(sDef);                                                                                              // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_QualifiedInterval()                                                                                                 // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 14. ObservationDefinition.qualifiedInterval.category
                    this.Element_Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Category",                                                                                          // MakerGen.cs:231
                        Path= "ObservationDefinition.qualifiedInterval.category",                                                           // MakerGen.cs:232
                        Id = "ObservationDefinition.qualifiedInterval.category",                                                            // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 15. ObservationDefinition.qualifiedInterval.range
                    this.Element_Range = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Range",                                                                                             // MakerGen.cs:231
                        Path= "ObservationDefinition.qualifiedInterval.range",                                                              // MakerGen.cs:232
                        Id = "ObservationDefinition.qualifiedInterval.range",                                                               // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Range                                                                    // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 16. ObservationDefinition.qualifiedInterval.context
                    this.Element_Context = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Context",                                                                                           // MakerGen.cs:231
                        Path= "ObservationDefinition.qualifiedInterval.context",                                                            // MakerGen.cs:232
                        Id = "ObservationDefinition.qualifiedInterval.context",                                                             // MakerGen.cs:233
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
                    // 17. ObservationDefinition.qualifiedInterval.appliesTo
                    this.Element_AppliesTo = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_AppliesTo",                                                                                         // MakerGen.cs:231
                        Path= "ObservationDefinition.qualifiedInterval.appliesTo",                                                          // MakerGen.cs:232
                        Id = "ObservationDefinition.qualifiedInterval.appliesTo",                                                           // MakerGen.cs:233
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
                    // 18. ObservationDefinition.qualifiedInterval.gender
                    this.Element_Gender = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Gender",                                                                                            // MakerGen.cs:231
                        Path= "ObservationDefinition.qualifiedInterval.gender",                                                             // MakerGen.cs:232
                        Id = "ObservationDefinition.qualifiedInterval.gender",                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 19. ObservationDefinition.qualifiedInterval.age
                    this.Element_Age = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Age",                                                                                               // MakerGen.cs:231
                        Path= "ObservationDefinition.qualifiedInterval.age",                                                                // MakerGen.cs:232
                        Id = "ObservationDefinition.qualifiedInterval.age",                                                                 // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Range                                                                    // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 20. ObservationDefinition.qualifiedInterval.gestationalAge
                    this.Element_GestationalAge = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_GestationalAge",                                                                                    // MakerGen.cs:231
                        Path= "ObservationDefinition.qualifiedInterval.gestationalAge",                                                     // MakerGen.cs:232
                        Id = "ObservationDefinition.qualifiedInterval.gestationalAge",                                                      // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Range                                                                    // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 21. ObservationDefinition.qualifiedInterval.condition
                    this.Element_Condition = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Condition",                                                                                         // MakerGen.cs:231
                        Path= "ObservationDefinition.qualifiedInterval.condition",                                                          // MakerGen.cs:232
                        Id = "ObservationDefinition.qualifiedInterval.condition",                                                           // MakerGen.cs:233
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
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. ObservationDefinition.category
        public ElementDefinitionInfo Element_Category;                                                                                      // MakerGen.cs:212
        // 2. ObservationDefinition.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:212
        // 3. ObservationDefinition.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 4. ObservationDefinition.permittedDataType
        public ElementDefinitionInfo Element_PermittedDataType;                                                                             // MakerGen.cs:212
        // 5. ObservationDefinition.multipleResultsAllowed
        public ElementDefinitionInfo Element_MultipleResultsAllowed;                                                                        // MakerGen.cs:212
        // 6. ObservationDefinition.method
        public ElementDefinitionInfo Element_Method;                                                                                        // MakerGen.cs:212
        // 7. ObservationDefinition.preferredReportName
        public ElementDefinitionInfo Element_PreferredReportName;                                                                           // MakerGen.cs:212
        // 8. ObservationDefinition.quantitativeDetails
        public ElementDefinitionInfo Element_QuantitativeDetails;                                                                           // MakerGen.cs:212
        // 13. ObservationDefinition.qualifiedInterval
        public ElementDefinitionInfo Element_QualifiedInterval;                                                                             // MakerGen.cs:212
        // 22. ObservationDefinition.validCodedValueSet
        public ElementDefinitionInfo Element_ValidCodedValueSet;                                                                            // MakerGen.cs:212
        // 23. ObservationDefinition.normalCodedValueSet
        public ElementDefinitionInfo Element_NormalCodedValueSet;                                                                           // MakerGen.cs:212
        // 24. ObservationDefinition.abnormalCodedValueSet
        public ElementDefinitionInfo Element_AbnormalCodedValueSet;                                                                         // MakerGen.cs:212
        // 25. ObservationDefinition.criticalCodedValueSet
        public ElementDefinitionInfo Element_CriticalCodedValueSet;                                                                         // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "ObservationDefinition",                                                                                             // MakerGen.cs:388
                ElementId = "ObservationDefinition"                                                                                         // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Category.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_PermittedDataType.Write(sDef);                                                                                          // MakerGen.cs:216
            Element_MultipleResultsAllowed.Write(sDef);                                                                                     // MakerGen.cs:216
            Element_Method.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_PreferredReportName.Write(sDef);                                                                                        // MakerGen.cs:216
            Element_QuantitativeDetails.Write(sDef);                                                                                        // MakerGen.cs:216
            Element_QualifiedInterval.Write(sDef);                                                                                          // MakerGen.cs:216
            Element_ValidCodedValueSet.Write(sDef);                                                                                         // MakerGen.cs:216
            Element_NormalCodedValueSet.Write(sDef);                                                                                        // MakerGen.cs:216
            Element_AbnormalCodedValueSet.Write(sDef);                                                                                      // MakerGen.cs:216
            Element_CriticalCodedValueSet.Write(sDef);                                                                                      // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_ObservationDefinition()                                                                                             // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. ObservationDefinition.category
                this.Element_Category = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Category",                                                                                              // MakerGen.cs:231
                    Path= "ObservationDefinition.category",                                                                                 // MakerGen.cs:232
                    Id = "ObservationDefinition.category",                                                                                  // MakerGen.cs:233
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
                // 2. ObservationDefinition.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:231
                    Path= "ObservationDefinition.code",                                                                                     // MakerGen.cs:232
                    Id = "ObservationDefinition.code",                                                                                      // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
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
                // 3. ObservationDefinition.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "ObservationDefinition.identifier",                                                                               // MakerGen.cs:232
                    Id = "ObservationDefinition.identifier",                                                                                // MakerGen.cs:233
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
                // 4. ObservationDefinition.permittedDataType
                this.Element_PermittedDataType = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PermittedDataType",                                                                                     // MakerGen.cs:231
                    Path= "ObservationDefinition.permittedDataType",                                                                        // MakerGen.cs:232
                    Id = "ObservationDefinition.permittedDataType",                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. ObservationDefinition.multipleResultsAllowed
                this.Element_MultipleResultsAllowed = new ElementDefinitionInfo                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_MultipleResultsAllowed",                                                                                // MakerGen.cs:231
                    Path= "ObservationDefinition.multipleResultsAllowed",                                                                   // MakerGen.cs:232
                    Id = "ObservationDefinition.multipleResultsAllowed",                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. ObservationDefinition.method
                this.Element_Method = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Method",                                                                                                // MakerGen.cs:231
                    Path= "ObservationDefinition.method",                                                                                   // MakerGen.cs:232
                    Id = "ObservationDefinition.method",                                                                                    // MakerGen.cs:233
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
                // 7. ObservationDefinition.preferredReportName
                this.Element_PreferredReportName = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_PreferredReportName",                                                                                   // MakerGen.cs:231
                    Path= "ObservationDefinition.preferredReportName",                                                                      // MakerGen.cs:232
                    Id = "ObservationDefinition.preferredReportName",                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. ObservationDefinition.quantitativeDetails
                this.Element_QuantitativeDetails = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_QuantitativeDetails",                                                                                   // MakerGen.cs:231
                    Path= "ObservationDefinition.quantitativeDetails",                                                                      // MakerGen.cs:232
                    Id = "ObservationDefinition.quantitativeDetails",                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_QuantitativeDetails                                                                                        // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. ObservationDefinition.qualifiedInterval
                this.Element_QualifiedInterval = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_QualifiedInterval",                                                                                     // MakerGen.cs:231
                    Path= "ObservationDefinition.qualifiedInterval",                                                                        // MakerGen.cs:232
                    Id = "ObservationDefinition.qualifiedInterval",                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_QualifiedInterval                                                                                          // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 22. ObservationDefinition.validCodedValueSet
                this.Element_ValidCodedValueSet = new ElementDefinitionInfo                                                                 // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ValidCodedValueSet",                                                                                    // MakerGen.cs:231
                    Path= "ObservationDefinition.validCodedValueSet",                                                                       // MakerGen.cs:232
                    Id = "ObservationDefinition.validCodedValueSet",                                                                        // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 23. ObservationDefinition.normalCodedValueSet
                this.Element_NormalCodedValueSet = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_NormalCodedValueSet",                                                                                   // MakerGen.cs:231
                    Path= "ObservationDefinition.normalCodedValueSet",                                                                      // MakerGen.cs:232
                    Id = "ObservationDefinition.normalCodedValueSet",                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 24. ObservationDefinition.abnormalCodedValueSet
                this.Element_AbnormalCodedValueSet = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_AbnormalCodedValueSet",                                                                                 // MakerGen.cs:231
                    Path= "ObservationDefinition.abnormalCodedValueSet",                                                                    // MakerGen.cs:232
                    Id = "ObservationDefinition.abnormalCodedValueSet",                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 25. ObservationDefinition.criticalCodedValueSet
                this.Element_CriticalCodedValueSet = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_CriticalCodedValueSet",                                                                                 // MakerGen.cs:231
                    Path= "ObservationDefinition.criticalCodedValueSet",                                                                    // MakerGen.cs:232
                    Id = "ObservationDefinition.criticalCodedValueSet",                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                          // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "ObservationDefinition";                                                                                            // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ObservationDefinition";                                                     // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
