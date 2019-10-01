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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'ObservationDefinition'
    /// </summary>
    // 0. ObservationDefinition
    public class ObservationDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                                        // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class ObservationDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 8. ObservationDefinition.quantitativeDetails
            public class Type_QuantitativeDetails : FhirKhit.Maker.Common.Complex.ComplexBase                                               // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_QuantitativeDetails_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 9. ObservationDefinition.quantitativeDetails.customaryUnit
                    public ElementDefinitionInfo CustomaryUnit;                                                                             // MakerGen.cs:236
                    // 10. ObservationDefinition.quantitativeDetails.unit
                    public ElementDefinitionInfo Unit;                                                                                      // MakerGen.cs:236
                    // 11. ObservationDefinition.quantitativeDetails.conversionFactor
                    public ElementDefinitionInfo ConversionFactor;                                                                          // MakerGen.cs:236
                    // 12. ObservationDefinition.quantitativeDetails.decimalPrecision
                    public ElementDefinitionInfo DecimalPrecision;                                                                          // MakerGen.cs:236
                    public Type_QuantitativeDetails_Elements()                                                                              // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 9. ObservationDefinition.quantitativeDetails.customaryUnit
                            this.CustomaryUnit = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "CustomaryUnit",                                                                                     // MakerGen.cs:255
                                Path= "ObservationDefinition.quantitativeDetails.customaryUnit",                                            // MakerGen.cs:256
                                Id = "ObservationDefinition.quantitativeDetails.customaryUnit",                                             // MakerGen.cs:257
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
                            // 10. ObservationDefinition.quantitativeDetails.unit
                            this.Unit = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Unit",                                                                                              // MakerGen.cs:255
                                Path= "ObservationDefinition.quantitativeDetails.unit",                                                     // MakerGen.cs:256
                                Id = "ObservationDefinition.quantitativeDetails.unit",                                                      // MakerGen.cs:257
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
                            // 11. ObservationDefinition.quantitativeDetails.conversionFactor
                            this.ConversionFactor = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "ConversionFactor",                                                                                  // MakerGen.cs:255
                                Path= "ObservationDefinition.quantitativeDetails.conversionFactor",                                         // MakerGen.cs:256
                                Id = "ObservationDefinition.quantitativeDetails.conversionFactor",                                          // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 12. ObservationDefinition.quantitativeDetails.decimalPrecision
                            this.DecimalPrecision = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "DecimalPrecision",                                                                                  // MakerGen.cs:255
                                Path= "ObservationDefinition.quantitativeDetails.decimalPrecision",                                         // MakerGen.cs:256
                                Id = "ObservationDefinition.quantitativeDetails.decimalPrecision",                                          // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        CustomaryUnit.Write(sDef);                                                                                          // MakerGen.cs:240
                        Unit.Write(sDef);                                                                                                   // MakerGen.cs:240
                        ConversionFactor.Write(sDef);                                                                                       // MakerGen.cs:240
                        DecimalPrecision.Write(sDef);                                                                                       // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_QuantitativeDetails_Elements Elements { get; }                                                                  // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_QuantitativeDetails()                                                                                           // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_QuantitativeDetails_Elements();                                                                // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 13. ObservationDefinition.qualifiedInterval
            public class Type_QualifiedInterval : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_QualifiedInterval_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 14. ObservationDefinition.qualifiedInterval.category
                    public ElementDefinitionInfo Category;                                                                                  // MakerGen.cs:236
                    // 15. ObservationDefinition.qualifiedInterval.range
                    public ElementDefinitionInfo Range;                                                                                     // MakerGen.cs:236
                    // 16. ObservationDefinition.qualifiedInterval.context
                    public ElementDefinitionInfo Context;                                                                                   // MakerGen.cs:236
                    // 17. ObservationDefinition.qualifiedInterval.appliesTo
                    public ElementDefinitionInfo AppliesTo;                                                                                 // MakerGen.cs:236
                    // 18. ObservationDefinition.qualifiedInterval.gender
                    public ElementDefinitionInfo Gender;                                                                                    // MakerGen.cs:236
                    // 19. ObservationDefinition.qualifiedInterval.age
                    public ElementDefinitionInfo Age;                                                                                       // MakerGen.cs:236
                    // 20. ObservationDefinition.qualifiedInterval.gestationalAge
                    public ElementDefinitionInfo GestationalAge;                                                                            // MakerGen.cs:236
                    // 21. ObservationDefinition.qualifiedInterval.condition
                    public ElementDefinitionInfo Condition;                                                                                 // MakerGen.cs:236
                    public Type_QualifiedInterval_Elements()                                                                                // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 14. ObservationDefinition.qualifiedInterval.category
                            this.Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Category",                                                                                          // MakerGen.cs:255
                                Path= "ObservationDefinition.qualifiedInterval.category",                                                   // MakerGen.cs:256
                                Id = "ObservationDefinition.qualifiedInterval.category",                                                    // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 15. ObservationDefinition.qualifiedInterval.range
                            this.Range = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Range",                                                                                             // MakerGen.cs:255
                                Path= "ObservationDefinition.qualifiedInterval.range",                                                      // MakerGen.cs:256
                                Id = "ObservationDefinition.qualifiedInterval.range",                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 16. ObservationDefinition.qualifiedInterval.context
                            this.Context = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Context",                                                                                           // MakerGen.cs:255
                                Path= "ObservationDefinition.qualifiedInterval.context",                                                    // MakerGen.cs:256
                                Id = "ObservationDefinition.qualifiedInterval.context",                                                     // MakerGen.cs:257
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
                            // 17. ObservationDefinition.qualifiedInterval.appliesTo
                            this.AppliesTo = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "AppliesTo",                                                                                         // MakerGen.cs:255
                                Path= "ObservationDefinition.qualifiedInterval.appliesTo",                                                  // MakerGen.cs:256
                                Id = "ObservationDefinition.qualifiedInterval.appliesTo",                                                   // MakerGen.cs:257
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
                            // 18. ObservationDefinition.qualifiedInterval.gender
                            this.Gender = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Gender",                                                                                            // MakerGen.cs:255
                                Path= "ObservationDefinition.qualifiedInterval.gender",                                                     // MakerGen.cs:256
                                Id = "ObservationDefinition.qualifiedInterval.gender",                                                      // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 19. ObservationDefinition.qualifiedInterval.age
                            this.Age = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Age",                                                                                               // MakerGen.cs:255
                                Path= "ObservationDefinition.qualifiedInterval.age",                                                        // MakerGen.cs:256
                                Id = "ObservationDefinition.qualifiedInterval.age",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 20. ObservationDefinition.qualifiedInterval.gestationalAge
                            this.GestationalAge = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "GestationalAge",                                                                                    // MakerGen.cs:255
                                Path= "ObservationDefinition.qualifiedInterval.gestationalAge",                                             // MakerGen.cs:256
                                Id = "ObservationDefinition.qualifiedInterval.gestationalAge",                                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 21. ObservationDefinition.qualifiedInterval.condition
                            this.Condition = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Condition",                                                                                         // MakerGen.cs:255
                                Path= "ObservationDefinition.qualifiedInterval.condition",                                                  // MakerGen.cs:256
                                Id = "ObservationDefinition.qualifiedInterval.condition",                                                   // MakerGen.cs:257
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
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Category.Write(sDef);                                                                                               // MakerGen.cs:240
                        Range.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Context.Write(sDef);                                                                                                // MakerGen.cs:240
                        AppliesTo.Write(sDef);                                                                                              // MakerGen.cs:240
                        Gender.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Age.Write(sDef);                                                                                                    // MakerGen.cs:240
                        GestationalAge.Write(sDef);                                                                                         // MakerGen.cs:240
                        Condition.Write(sDef);                                                                                              // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_QualifiedInterval_Elements Elements { get; }                                                                    // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_QualifiedInterval()                                                                                             // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_QualifiedInterval_Elements();                                                                  // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. ObservationDefinition.category
            public ElementDefinitionInfo Category;                                                                                          // MakerGen.cs:236
            // 2. ObservationDefinition.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:236
            // 3. ObservationDefinition.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 4. ObservationDefinition.permittedDataType
            public ElementDefinitionInfo PermittedDataType;                                                                                 // MakerGen.cs:236
            // 5. ObservationDefinition.multipleResultsAllowed
            public ElementDefinitionInfo MultipleResultsAllowed;                                                                            // MakerGen.cs:236
            // 6. ObservationDefinition.method
            public ElementDefinitionInfo Method;                                                                                            // MakerGen.cs:236
            // 7. ObservationDefinition.preferredReportName
            public ElementDefinitionInfo PreferredReportName;                                                                               // MakerGen.cs:236
            // 22. ObservationDefinition.validCodedValueSet
            public ElementDefinitionInfo ValidCodedValueSet;                                                                                // MakerGen.cs:236
            // 23. ObservationDefinition.normalCodedValueSet
            public ElementDefinitionInfo NormalCodedValueSet;                                                                               // MakerGen.cs:236
            // 24. ObservationDefinition.abnormalCodedValueSet
            public ElementDefinitionInfo AbnormalCodedValueSet;                                                                             // MakerGen.cs:236
            // 25. ObservationDefinition.criticalCodedValueSet
            public ElementDefinitionInfo CriticalCodedValueSet;                                                                             // MakerGen.cs:236
            public ObservationDefinition_Elements()                                                                                         // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. ObservationDefinition.category
                    this.Category = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Category",                                                                                                  // MakerGen.cs:255
                        Path= "ObservationDefinition.category",                                                                             // MakerGen.cs:256
                        Id = "ObservationDefinition.category",                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. ObservationDefinition.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Code",                                                                                                      // MakerGen.cs:255
                        Path= "ObservationDefinition.code",                                                                                 // MakerGen.cs:256
                        Id = "ObservationDefinition.code",                                                                                  // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. ObservationDefinition.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "ObservationDefinition.identifier",                                                                           // MakerGen.cs:256
                        Id = "ObservationDefinition.identifier",                                                                            // MakerGen.cs:257
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
                    // 4. ObservationDefinition.permittedDataType
                    this.PermittedDataType = new ElementDefinitionInfo                                                                      // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PermittedDataType",                                                                                         // MakerGen.cs:255
                        Path= "ObservationDefinition.permittedDataType",                                                                    // MakerGen.cs:256
                        Id = "ObservationDefinition.permittedDataType",                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. ObservationDefinition.multipleResultsAllowed
                    this.MultipleResultsAllowed = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "MultipleResultsAllowed",                                                                                    // MakerGen.cs:255
                        Path= "ObservationDefinition.multipleResultsAllowed",                                                               // MakerGen.cs:256
                        Id = "ObservationDefinition.multipleResultsAllowed",                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. ObservationDefinition.method
                    this.Method = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Method",                                                                                                    // MakerGen.cs:255
                        Path= "ObservationDefinition.method",                                                                               // MakerGen.cs:256
                        Id = "ObservationDefinition.method",                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. ObservationDefinition.preferredReportName
                    this.PreferredReportName = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PreferredReportName",                                                                                       // MakerGen.cs:255
                        Path= "ObservationDefinition.preferredReportName",                                                                  // MakerGen.cs:256
                        Id = "ObservationDefinition.preferredReportName",                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 22. ObservationDefinition.validCodedValueSet
                    this.ValidCodedValueSet = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ValidCodedValueSet",                                                                                        // MakerGen.cs:255
                        Path= "ObservationDefinition.validCodedValueSet",                                                                   // MakerGen.cs:256
                        Id = "ObservationDefinition.validCodedValueSet",                                                                    // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 23. ObservationDefinition.normalCodedValueSet
                    this.NormalCodedValueSet = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "NormalCodedValueSet",                                                                                       // MakerGen.cs:255
                        Path= "ObservationDefinition.normalCodedValueSet",                                                                  // MakerGen.cs:256
                        Id = "ObservationDefinition.normalCodedValueSet",                                                                   // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 24. ObservationDefinition.abnormalCodedValueSet
                    this.AbnormalCodedValueSet = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "AbnormalCodedValueSet",                                                                                     // MakerGen.cs:255
                        Path= "ObservationDefinition.abnormalCodedValueSet",                                                                // MakerGen.cs:256
                        Id = "ObservationDefinition.abnormalCodedValueSet",                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 25. ObservationDefinition.criticalCodedValueSet
                    this.CriticalCodedValueSet = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "CriticalCodedValueSet",                                                                                     // MakerGen.cs:255
                        Path= "ObservationDefinition.criticalCodedValueSet",                                                                // MakerGen.cs:256
                        Id = "ObservationDefinition.criticalCodedValueSet",                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Category.Write(sDef);                                                                                                       // MakerGen.cs:240
                Code.Write(sDef);                                                                                                           // MakerGen.cs:240
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                PermittedDataType.Write(sDef);                                                                                              // MakerGen.cs:240
                MultipleResultsAllowed.Write(sDef);                                                                                         // MakerGen.cs:240
                Method.Write(sDef);                                                                                                         // MakerGen.cs:240
                PreferredReportName.Write(sDef);                                                                                            // MakerGen.cs:240
                ValidCodedValueSet.Write(sDef);                                                                                             // MakerGen.cs:240
                NormalCodedValueSet.Write(sDef);                                                                                            // MakerGen.cs:240
                AbnormalCodedValueSet.Write(sDef);                                                                                          // MakerGen.cs:240
                CriticalCodedValueSet.Write(sDef);                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public ObservationDefinition_Elements Elements { get; }                                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public ObservationDefinition()                                                                                                      // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new ObservationDefinition_Elements();                                                                           // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
