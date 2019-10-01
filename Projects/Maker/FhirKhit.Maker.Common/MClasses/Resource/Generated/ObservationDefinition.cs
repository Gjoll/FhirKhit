using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'ObservationDefinition'
    /// </summary>
    // 0. ObservationDefinition
    public class ObservationDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                                        // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class ObservationDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 8. ObservationDefinition.quantitativeDetails
            public class Type_QuantitativeDetails : FhirKhit.Maker.Common.Complex.ComplexBase                                               // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_QuantitativeDetails_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 9. ObservationDefinition.quantitativeDetails.customaryUnit
                    public ElementDefinitionInfo CustomaryUnit;                                                                             // MakerGen.cs:211
                    // 10. ObservationDefinition.quantitativeDetails.unit
                    public ElementDefinitionInfo Unit;                                                                                      // MakerGen.cs:211
                    // 11. ObservationDefinition.quantitativeDetails.conversionFactor
                    public ElementDefinitionInfo ConversionFactor;                                                                          // MakerGen.cs:211
                    // 12. ObservationDefinition.quantitativeDetails.decimalPrecision
                    public ElementDefinitionInfo DecimalPrecision;                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_QuantitativeDetails_Elements()                                                                              // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 9. ObservationDefinition.quantitativeDetails.customaryUnit
                            this.CustomaryUnit = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "CustomaryUnit",                                                                                     // MakerGen.cs:230
                                Path= "ObservationDefinition.quantitativeDetails.customaryUnit",                                            // MakerGen.cs:231
                                Id = "ObservationDefinition.quantitativeDetails.customaryUnit",                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 10. ObservationDefinition.quantitativeDetails.unit
                            this.Unit = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Unit",                                                                                              // MakerGen.cs:230
                                Path= "ObservationDefinition.quantitativeDetails.unit",                                                     // MakerGen.cs:231
                                Id = "ObservationDefinition.quantitativeDetails.unit",                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 11. ObservationDefinition.quantitativeDetails.conversionFactor
                            this.ConversionFactor = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "ConversionFactor",                                                                                  // MakerGen.cs:230
                                Path= "ObservationDefinition.quantitativeDetails.conversionFactor",                                         // MakerGen.cs:231
                                Id = "ObservationDefinition.quantitativeDetails.conversionFactor",                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 12. ObservationDefinition.quantitativeDetails.decimalPrecision
                            this.DecimalPrecision = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "DecimalPrecision",                                                                                  // MakerGen.cs:230
                                Path= "ObservationDefinition.quantitativeDetails.decimalPrecision",                                         // MakerGen.cs:231
                                Id = "ObservationDefinition.quantitativeDetails.decimalPrecision",                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        CustomaryUnit.Write(sDef);                                                                                          // MakerGen.cs:215
                        Unit.Write(sDef);                                                                                                   // MakerGen.cs:215
                        ConversionFactor.Write(sDef);                                                                                       // MakerGen.cs:215
                        DecimalPrecision.Write(sDef);                                                                                       // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_QuantitativeDetails_Elements Elements                                                                           // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_QuantitativeDetails_Elements();                                                        // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_QuantitativeDetails_Elements elements;                                                                                 // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_QuantitativeDetails()                                                                                           // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "ObservationDefinition.quantitativeDetails",                                                                 // MakerGen.cs:423
                        ElementId = "ObservationDefinition.quantitativeDetails"                                                             // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 13. ObservationDefinition.qualifiedInterval
            public class Type_QualifiedInterval : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_QualifiedInterval_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 14. ObservationDefinition.qualifiedInterval.category
                    public ElementDefinitionInfo Category;                                                                                  // MakerGen.cs:211
                    // 15. ObservationDefinition.qualifiedInterval.range
                    public ElementDefinitionInfo Range;                                                                                     // MakerGen.cs:211
                    // 16. ObservationDefinition.qualifiedInterval.context
                    public ElementDefinitionInfo Context;                                                                                   // MakerGen.cs:211
                    // 17. ObservationDefinition.qualifiedInterval.appliesTo
                    public ElementDefinitionInfo AppliesTo;                                                                                 // MakerGen.cs:211
                    // 18. ObservationDefinition.qualifiedInterval.gender
                    public ElementDefinitionInfo Gender;                                                                                    // MakerGen.cs:211
                    // 19. ObservationDefinition.qualifiedInterval.age
                    public ElementDefinitionInfo Age;                                                                                       // MakerGen.cs:211
                    // 20. ObservationDefinition.qualifiedInterval.gestationalAge
                    public ElementDefinitionInfo GestationalAge;                                                                            // MakerGen.cs:211
                    // 21. ObservationDefinition.qualifiedInterval.condition
                    public ElementDefinitionInfo Condition;                                                                                 // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_QualifiedInterval_Elements()                                                                                // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 14. ObservationDefinition.qualifiedInterval.category
                            this.Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Category",                                                                                          // MakerGen.cs:230
                                Path= "ObservationDefinition.qualifiedInterval.category",                                                   // MakerGen.cs:231
                                Id = "ObservationDefinition.qualifiedInterval.category",                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 15. ObservationDefinition.qualifiedInterval.range
                            this.Range = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Range",                                                                                             // MakerGen.cs:230
                                Path= "ObservationDefinition.qualifiedInterval.range",                                                      // MakerGen.cs:231
                                Id = "ObservationDefinition.qualifiedInterval.range",                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 16. ObservationDefinition.qualifiedInterval.context
                            this.Context = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Context",                                                                                           // MakerGen.cs:230
                                Path= "ObservationDefinition.qualifiedInterval.context",                                                    // MakerGen.cs:231
                                Id = "ObservationDefinition.qualifiedInterval.context",                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 17. ObservationDefinition.qualifiedInterval.appliesTo
                            this.AppliesTo = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "AppliesTo",                                                                                         // MakerGen.cs:230
                                Path= "ObservationDefinition.qualifiedInterval.appliesTo",                                                  // MakerGen.cs:231
                                Id = "ObservationDefinition.qualifiedInterval.appliesTo",                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 18. ObservationDefinition.qualifiedInterval.gender
                            this.Gender = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Gender",                                                                                            // MakerGen.cs:230
                                Path= "ObservationDefinition.qualifiedInterval.gender",                                                     // MakerGen.cs:231
                                Id = "ObservationDefinition.qualifiedInterval.gender",                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 19. ObservationDefinition.qualifiedInterval.age
                            this.Age = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Age",                                                                                               // MakerGen.cs:230
                                Path= "ObservationDefinition.qualifiedInterval.age",                                                        // MakerGen.cs:231
                                Id = "ObservationDefinition.qualifiedInterval.age",                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 20. ObservationDefinition.qualifiedInterval.gestationalAge
                            this.GestationalAge = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "GestationalAge",                                                                                    // MakerGen.cs:230
                                Path= "ObservationDefinition.qualifiedInterval.gestationalAge",                                             // MakerGen.cs:231
                                Id = "ObservationDefinition.qualifiedInterval.gestationalAge",                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 21. ObservationDefinition.qualifiedInterval.condition
                            this.Condition = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Condition",                                                                                         // MakerGen.cs:230
                                Path= "ObservationDefinition.qualifiedInterval.condition",                                                  // MakerGen.cs:231
                                Id = "ObservationDefinition.qualifiedInterval.condition",                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Category.Write(sDef);                                                                                               // MakerGen.cs:215
                        Range.Write(sDef);                                                                                                  // MakerGen.cs:215
                        Context.Write(sDef);                                                                                                // MakerGen.cs:215
                        AppliesTo.Write(sDef);                                                                                              // MakerGen.cs:215
                        Gender.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Age.Write(sDef);                                                                                                    // MakerGen.cs:215
                        GestationalAge.Write(sDef);                                                                                         // MakerGen.cs:215
                        Condition.Write(sDef);                                                                                              // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_QualifiedInterval_Elements Elements                                                                             // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_QualifiedInterval_Elements();                                                          // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_QualifiedInterval_Elements elements;                                                                                   // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_QualifiedInterval()                                                                                             // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "ObservationDefinition.qualifiedInterval",                                                                   // MakerGen.cs:423
                        ElementId = "ObservationDefinition.qualifiedInterval"                                                               // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. ObservationDefinition.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:211
            // 2. ObservationDefinition.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:211
            // 3. ObservationDefinition.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 4. ObservationDefinition.permittedDataType
            public ElementDefinitionInfo PermittedDataType;                                                                                 // MakerGen.cs:211
            // 5. ObservationDefinition.multipleResultsAllowed
            public ElementDefinitionInfo MultipleResultsAllowed;                                                                            // MakerGen.cs:211
            // 6. ObservationDefinition.method
            public ElementDefinitionInfo Method;                                                                                            // MakerGen.cs:211
            // 7. ObservationDefinition.preferredReportName
            public ElementDefinitionInfo PreferredReportName;                                                                               // MakerGen.cs:211
            // 8. ObservationDefinition.quantitativeDetails
            public ElementDefinitionInfo QuantitativeDetails;                                                                               // MakerGen.cs:211
            // 13. ObservationDefinition.qualifiedInterval
            public ElementDefinitionInfo QualifiedInterval;                                                                                 // MakerGen.cs:211
            // 22. ObservationDefinition.validCodedValueSet
            public ElementDefinitionInfo ValidCodedValueSet;                                                                                // MakerGen.cs:211
            // 23. ObservationDefinition.normalCodedValueSet
            public ElementDefinitionInfo NormalCodedValueSet;                                                                               // MakerGen.cs:211
            // 24. ObservationDefinition.abnormalCodedValueSet
            public ElementDefinitionInfo AbnormalCodedValueSet;                                                                             // MakerGen.cs:211
            // 25. ObservationDefinition.criticalCodedValueSet
            public ElementDefinitionInfo CriticalCodedValueSet;                                                                             // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public ObservationDefinition_Elements()                                                                                         // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. ObservationDefinition.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Category",                                                                                                  // MakerGen.cs:230
                        Path= "ObservationDefinition.category",                                                                             // MakerGen.cs:231
                        Id = "ObservationDefinition.category",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. ObservationDefinition.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Code",                                                                                                      // MakerGen.cs:230
                        Path= "ObservationDefinition.code",                                                                                 // MakerGen.cs:231
                        Id = "ObservationDefinition.code",                                                                                  // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. ObservationDefinition.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "ObservationDefinition.identifier",                                                                           // MakerGen.cs:231
                        Id = "ObservationDefinition.identifier",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. ObservationDefinition.permittedDataType
                    this.PermittedDataType = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "PermittedDataType",                                                                                         // MakerGen.cs:230
                        Path= "ObservationDefinition.permittedDataType",                                                                    // MakerGen.cs:231
                        Id = "ObservationDefinition.permittedDataType",                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. ObservationDefinition.multipleResultsAllowed
                    this.MultipleResultsAllowed = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "MultipleResultsAllowed",                                                                                    // MakerGen.cs:230
                        Path= "ObservationDefinition.multipleResultsAllowed",                                                               // MakerGen.cs:231
                        Id = "ObservationDefinition.multipleResultsAllowed",                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. ObservationDefinition.method
                    this.Method = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Method",                                                                                                    // MakerGen.cs:230
                        Path= "ObservationDefinition.method",                                                                               // MakerGen.cs:231
                        Id = "ObservationDefinition.method",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. ObservationDefinition.preferredReportName
                    this.PreferredReportName = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "PreferredReportName",                                                                                       // MakerGen.cs:230
                        Path= "ObservationDefinition.preferredReportName",                                                                  // MakerGen.cs:231
                        Id = "ObservationDefinition.preferredReportName",                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. ObservationDefinition.quantitativeDetails
                    this.QuantitativeDetails = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "QuantitativeDetails",                                                                                       // MakerGen.cs:230
                        Path= "ObservationDefinition.quantitativeDetails",                                                                  // MakerGen.cs:231
                        Id = "ObservationDefinition.quantitativeDetails",                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_QuantitativeDetails                                                                                    // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. ObservationDefinition.qualifiedInterval
                    this.QualifiedInterval = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "QualifiedInterval",                                                                                         // MakerGen.cs:230
                        Path= "ObservationDefinition.qualifiedInterval",                                                                    // MakerGen.cs:231
                        Id = "ObservationDefinition.qualifiedInterval",                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_QualifiedInterval                                                                                      // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 22. ObservationDefinition.validCodedValueSet
                    this.ValidCodedValueSet = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ValidCodedValueSet",                                                                                        // MakerGen.cs:230
                        Path= "ObservationDefinition.validCodedValueSet",                                                                   // MakerGen.cs:231
                        Id = "ObservationDefinition.validCodedValueSet",                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 23. ObservationDefinition.normalCodedValueSet
                    this.NormalCodedValueSet = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "NormalCodedValueSet",                                                                                       // MakerGen.cs:230
                        Path= "ObservationDefinition.normalCodedValueSet",                                                                  // MakerGen.cs:231
                        Id = "ObservationDefinition.normalCodedValueSet",                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 24. ObservationDefinition.abnormalCodedValueSet
                    this.AbnormalCodedValueSet = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "AbnormalCodedValueSet",                                                                                     // MakerGen.cs:230
                        Path= "ObservationDefinition.abnormalCodedValueSet",                                                                // MakerGen.cs:231
                        Id = "ObservationDefinition.abnormalCodedValueSet",                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 25. ObservationDefinition.criticalCodedValueSet
                    this.CriticalCodedValueSet = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "CriticalCodedValueSet",                                                                                     // MakerGen.cs:230
                        Path= "ObservationDefinition.criticalCodedValueSet",                                                                // MakerGen.cs:231
                        Id = "ObservationDefinition.criticalCodedValueSet",                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                      // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Category.Write(sDef);                                                                                                       // MakerGen.cs:215
                Code.Write(sDef);                                                                                                           // MakerGen.cs:215
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                PermittedDataType.Write(sDef);                                                                                              // MakerGen.cs:215
                MultipleResultsAllowed.Write(sDef);                                                                                         // MakerGen.cs:215
                Method.Write(sDef);                                                                                                         // MakerGen.cs:215
                PreferredReportName.Write(sDef);                                                                                            // MakerGen.cs:215
                QuantitativeDetails.Write(sDef);                                                                                            // MakerGen.cs:215
                QualifiedInterval.Write(sDef);                                                                                              // MakerGen.cs:215
                ValidCodedValueSet.Write(sDef);                                                                                             // MakerGen.cs:215
                NormalCodedValueSet.Write(sDef);                                                                                            // MakerGen.cs:215
                AbnormalCodedValueSet.Write(sDef);                                                                                          // MakerGen.cs:215
                CriticalCodedValueSet.Write(sDef);                                                                                          // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public ObservationDefinition_Elements Elements                                                                                      // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new ObservationDefinition_Elements();                                                                   // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        ObservationDefinition_Elements elements;                                                                                            // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public ObservationDefinition()                                                                                                      // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "ObservationDefinition";                                                                                            // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ObservationDefinition";                                                     // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "ObservationDefinition",                                                                                             // MakerGen.cs:423
                ElementId = "ObservationDefinition"                                                                                         // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
