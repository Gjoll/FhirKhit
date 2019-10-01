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
      "id": "MeasureReport",
      "url": "http://hl7.org/fhir/StructureDefinition/MeasureReport",
      "version": "4.0.0",
      "name": "MeasureReport",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Quality Information)",
      "description": "The MeasureReport resource contains the results of the calculation of a measure; and optionally a reference to the resources involved in that calculation.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "MeasureReport",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "MeasureReport",
            "path": "MeasureReport",
            "short": "Results of a measure evaluation",
            "definition": "The MeasureReport resource contains the results of the calculation of a measure; and optionally a reference to the resources involved in that calculation.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "MeasureReport.identifier",
            "path": "MeasureReport.identifier",
            "short": "Additional identifier for the MeasureReport",
            "definition": "A formal identifier that is used to identify this MeasureReport when it is represented in other formats or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II data type - e.g. to identify this {{title}} outside of FHIR, where the logical URL is not possible to use.",
            "requirements": "Allows externally provided and/or usable business identifiers to be easily associated with the module.",
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
            "id": "MeasureReport.status",
            "path": "MeasureReport.status",
            "short": "complete | pending | error",
            "definition": "The MeasureReport status. No data will be available until the MeasureReport status is complete.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MeasureReportStatus"
                }
              ],
              "strength": "required",
              "description": "The status of the measure report.",
              "valueSet": "http://hl7.org/fhir/ValueSet/measure-report-status|4.0.0"
            }
          },
          {
            "id": "MeasureReport.type",
            "path": "MeasureReport.type",
            "short": "individual | subject-list | summary | data-collection",
            "definition": "The type of measure report. This may be an individual report, which provides the score for the measure for an individual member of the population; a subject-listing, which returns the list of members that meet the various criteria in the measure; a summary report, which returns a population count for each of the criteria in the measure; or a data-collection, which enables the MeasureReport to be used to exchange the data-of-interest for a quality measure.",
            "comment": "Data-collection reports are used only to communicate data-of-interest for a measure. They do not necessarily include all the data for a particular subject or population, but they may.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "condition": [
              "mrp-1"
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MeasureReportType"
                }
              ],
              "strength": "required",
              "description": "The type of the measure report.",
              "valueSet": "http://hl7.org/fhir/ValueSet/measure-report-type|4.0.0"
            }
          },
          {
            "id": "MeasureReport.measure",
            "path": "MeasureReport.measure",
            "short": "What measure was calculated",
            "definition": "A reference to the Measure that was calculated to produce this report.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Measure"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MeasureReport.subject",
            "path": "MeasureReport.subject",
            "short": "What individual(s) the report is for",
            "definition": "Optional subject identifying the individual or individuals the report is for.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Location",
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MeasureReport.date",
            "path": "MeasureReport.date",
            "short": "When the report was generated",
            "definition": "The date this measure report was generated.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MeasureReport.reporter",
            "path": "MeasureReport.reporter",
            "short": "Who is reporting the data",
            "definition": "The individual, location, or organization that is reporting the data.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Location",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "MeasureReport.period",
            "path": "MeasureReport.period",
            "short": "What period the report covers",
            "definition": "The reporting period for which the report was calculated.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MeasureReport.improvementNotation",
            "path": "MeasureReport.improvementNotation",
            "short": "increase | decrease",
            "definition": "Whether improvement in the measure is noted by an increase or decrease in the measure score.",
            "comment": "This element is typically defined by the measure, but reproduced here to ensure the measure score can be interpreted. The element is labeled as a modifier because it changes the interpretation of the reported measure score.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isModifier": true,
            "isModifierReason": "Improvement notation determines how to interpret the measure score (i.e. whether an increase is an improvement)",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MeasureImprovementNotation"
                }
              ],
              "strength": "required",
              "description": "Observation values that indicate what change in a measurement value or score is indicative of an improvement in the measured item or scored issue.",
              "valueSet": "http://hl7.org/fhir/ValueSet/measure-improvement-notation|4.0.0"
            }
          },
          {
            "id": "MeasureReport.group",
            "path": "MeasureReport.group",
            "short": "Measure results for each group",
            "definition": "The results of the calculation, one for each population group in the measure.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "mrp-1"
            ]
          },
          {
            "id": "MeasureReport.group.code",
            "path": "MeasureReport.group.code",
            "short": "Meaning of the group",
            "definition": "The meaning of the population group as defined in the measure definition.",
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
            "id": "MeasureReport.group.population",
            "path": "MeasureReport.group.population",
            "short": "The populations in the group",
            "definition": "The populations that make up the population group, one for each type of population appropriate for the measure.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MeasureReport.group.population.code",
            "path": "MeasureReport.group.population.code",
            "short": "initial-population | numerator | numerator-exclusion | denominator | denominator-exclusion | denominator-exception | measure-population | measure-population-exclusion | measure-observation",
            "definition": "The type of the population.",
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
                  "valueString": "MeasurePopulation"
                }
              ],
              "strength": "extensible",
              "description": "The type of population (e.g. initial, numerator, denominator, etc.).",
              "valueSet": "http://hl7.org/fhir/ValueSet/measure-population"
            }
          },
          {
            "id": "MeasureReport.group.population.count",
            "path": "MeasureReport.group.population.count",
            "short": "Size of the population",
            "definition": "The number of members of the population.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "MeasureReport.group.population.subjectResults",
            "path": "MeasureReport.group.population.subjectResults",
            "short": "For subject-list reports, the subject results in this population",
            "definition": "This element refers to a List of subject level MeasureReport resources, one for each subject in this population.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/List"
                ]
              }
            ]
          },
          {
            "id": "MeasureReport.group.measureScore",
            "path": "MeasureReport.group.measureScore",
            "short": "What score this group achieved",
            "definition": "The measure score for this population group, calculated as appropriate for the measure type and scoring method, and based on the contents of the populations defined in the group.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "MeasureReport.group.stratifier",
            "path": "MeasureReport.group.stratifier",
            "short": "Stratification results",
            "definition": "When a measure includes multiple stratifiers, there will be a stratifier group for each stratifier defined by the measure.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MeasureReport.group.stratifier.code",
            "path": "MeasureReport.group.stratifier.code",
            "short": "What stratifier of the group",
            "definition": "The meaning of this stratifier, as defined in the measure definition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MeasureReport.group.stratifier.stratum",
            "path": "MeasureReport.group.stratifier.stratum",
            "short": "Stratum results, one for each unique value, or set of values, in the stratifier, or stratifier components",
            "definition": "This element contains the results for a single stratum within the stratifier. For example, when stratifying on administrative gender, there will be four strata, one for each possible gender value.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MeasureReport.group.stratifier.stratum.value",
            "path": "MeasureReport.group.stratifier.stratum.value",
            "short": "The stratum value, e.g. male",
            "definition": "The value for this stratum, expressed as a CodeableConcept. When defining stratifiers on complex values, the value must be rendered such that the value for each stratum within the stratifier is unique.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MeasureReport.group.stratifier.stratum.component",
            "path": "MeasureReport.group.stratifier.stratum.component",
            "short": "Stratifier component values",
            "definition": "A stratifier component value.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MeasureReport.group.stratifier.stratum.component.code",
            "path": "MeasureReport.group.stratifier.stratum.component.code",
            "short": "What stratifier component of the group",
            "definition": "The code for the stratum component value.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MeasureReport.group.stratifier.stratum.component.value",
            "path": "MeasureReport.group.stratifier.stratum.component.value",
            "short": "The stratum component value, e.g. male",
            "definition": "The stratum component value.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "MeasureReport.group.stratifier.stratum.population",
            "path": "MeasureReport.group.stratifier.stratum.population",
            "short": "Population results in this stratum",
            "definition": "The populations that make up the stratum, one for each type of population appropriate to the measure.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "MeasureReport.group.stratifier.stratum.population.code",
            "path": "MeasureReport.group.stratifier.stratum.population.code",
            "short": "initial-population | numerator | numerator-exclusion | denominator | denominator-exclusion | denominator-exception | measure-population | measure-population-exclusion | measure-observation",
            "definition": "The type of the population.",
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
                  "valueString": "MeasurePopulation"
                }
              ],
              "strength": "extensible",
              "description": "The type of population (e.g. initial, numerator, denominator, etc.).",
              "valueSet": "http://hl7.org/fhir/ValueSet/measure-population"
            }
          },
          {
            "id": "MeasureReport.group.stratifier.stratum.population.count",
            "path": "MeasureReport.group.stratifier.stratum.population.count",
            "short": "Size of the population",
            "definition": "The number of members of the population in this stratum.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "MeasureReport.group.stratifier.stratum.population.subjectResults",
            "path": "MeasureReport.group.stratifier.stratum.population.subjectResults",
            "short": "For subject-list reports, the subject results in this population",
            "definition": "This element refers to a List of subject level MeasureReport resources, one for each subject in this population in this stratum.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/List"
                ]
              }
            ]
          },
          {
            "id": "MeasureReport.group.stratifier.stratum.measureScore",
            "path": "MeasureReport.group.stratifier.stratum.measureScore",
            "short": "What score this stratum achieved",
            "definition": "The measure score for this stratum, calculated as appropriate for the measure type and scoring method, and based on only the members of this stratum.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              }
            ]
          },
          {
            "id": "MeasureReport.evaluatedResource",
            "path": "MeasureReport.evaluatedResource",
            "short": "What data was used to calculate the measure score",
            "definition": "A reference to a Bundle containing the Resources that were used in the calculation of this measure.",
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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'MeasureReport'
    /// </summary>
    // 0. MeasureReport
    public class MeasureReport : FhirKhit.Maker.Common.Resource.ResourceBase                                                                // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class MeasureReport_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 10. MeasureReport.group
            public class Type_Group : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Group_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 12. MeasureReport.group.population
                    public class Type_Population : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Population_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 13. MeasureReport.group.population.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:211
                            // 14. MeasureReport.group.population.count
                            public ElementDefinitionInfo Count;                                                                             // MakerGen.cs:211
                            // 15. MeasureReport.group.population.subjectResults
                            public ElementDefinitionInfo SubjectResults;                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Population_Elements()                                                                               // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 13. MeasureReport.group.population.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Code",                                                                                      // MakerGen.cs:230
                                        Path= "MeasureReport.group.population.code",                                                        // MakerGen.cs:231
                                        Id = "MeasureReport.group.population.code",                                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 14. MeasureReport.group.population.count
                                    this.Count = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Count",                                                                                     // MakerGen.cs:230
                                        Path= "MeasureReport.group.population.count",                                                       // MakerGen.cs:231
                                        Id = "MeasureReport.group.population.count",                                                        // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 15. MeasureReport.group.population.subjectResults
                                    this.SubjectResults = new ElementDefinitionInfo                                                         // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "SubjectResults",                                                                            // MakerGen.cs:230
                                        Path= "MeasureReport.group.population.subjectResults",                                              // MakerGen.cs:231
                                        Id = "MeasureReport.group.population.subjectResults",                                               // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:341
                                            {                                                                                               // MakerGen.cs:342
                                                TargetProfile = new String[]                                                                // MakerGen.cs:344
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/List"                                          // MakerGen.cs:344
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:345
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Code.Write(sDef);                                                                                           // MakerGen.cs:215
                                Count.Write(sDef);                                                                                          // MakerGen.cs:215
                                SubjectResults.Write(sDef);                                                                                 // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Population_Elements Elements                                                                            // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Population_Elements();                                                         // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Population_Elements elements;                                                                                  // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Population()                                                                                            // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "MeasureReport.group.population",                                                                    // MakerGen.cs:423
                                ElementId = "MeasureReport.group.population"                                                                // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 17. MeasureReport.group.stratifier
                    public class Type_Stratifier : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Stratifier_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 19. MeasureReport.group.stratifier.stratum
                            public class Type_Stratum : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:379
                            {                                                                                                               // MakerGen.cs:380
                                public class Type_Stratum_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                            // MakerGen.cs:381
                                {                                                                                                           // MakerGen.cs:382
                                    // 21. MeasureReport.group.stratifier.stratum.component
                                    public class Type_Component : FhirKhit.Maker.Common.Complex.ComplexBase                                 // MakerGen.cs:379
                                    {                                                                                                       // MakerGen.cs:380
                                        public class Type_Component_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                  // MakerGen.cs:381
                                        {                                                                                                   // MakerGen.cs:382
                                            // 22. MeasureReport.group.stratifier.stratum.component.code
                                            public ElementDefinitionInfo Code;                                                              // MakerGen.cs:211
                                            // 23. MeasureReport.group.stratifier.stratum.component.value
                                            public ElementDefinitionInfo Value;                                                             // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                                            public Type_Component_Elements()                                                                // MakerGen.cs:387
                                            {                                                                                               // MakerGen.cs:388
                                                {                                                                                           // MakerGen.cs:226
                                                    // 22. MeasureReport.group.stratifier.stratum.component.code
                                                    this.Code = new ElementDefinitionInfo                                                   // MakerGen.cs:228
                                                    {                                                                                       // MakerGen.cs:229
                                                        Name = "Code",                                                                      // MakerGen.cs:230
                                                        Path= "MeasureReport.group.stratifier.stratum.component.code",                      // MakerGen.cs:231
                                                        Id = "MeasureReport.group.stratifier.stratum.component.code",                       // MakerGen.cs:232
                                                        Min = 1,                                                                            // MakerGen.cs:233
                                                        Max = 1,                                                                            // MakerGen.cs:234
                                                        Types = new BaseType[]                                                              // MakerGen.cs:235
                                                        {                                                                                   // MakerGen.cs:236
                                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                               // MakerGen.cs:310
                                                            {                                                                               // MakerGen.cs:311
                                                            }                                                                               // MakerGen.cs:314
                                                        }                                                                                   // MakerGen.cs:238
                                                    };                                                                                      // MakerGen.cs:239
                                                }                                                                                           // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:226
                                                    // 23. MeasureReport.group.stratifier.stratum.component.value
                                                    this.Value = new ElementDefinitionInfo                                                  // MakerGen.cs:228
                                                    {                                                                                       // MakerGen.cs:229
                                                        Name = "Value",                                                                     // MakerGen.cs:230
                                                        Path= "MeasureReport.group.stratifier.stratum.component.value",                     // MakerGen.cs:231
                                                        Id = "MeasureReport.group.stratifier.stratum.component.value",                      // MakerGen.cs:232
                                                        Min = 1,                                                                            // MakerGen.cs:233
                                                        Max = 1,                                                                            // MakerGen.cs:234
                                                        Types = new BaseType[]                                                              // MakerGen.cs:235
                                                        {                                                                                   // MakerGen.cs:236
                                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                               // MakerGen.cs:310
                                                            {                                                                               // MakerGen.cs:311
                                                            }                                                                               // MakerGen.cs:314
                                                        }                                                                                   // MakerGen.cs:238
                                                    };                                                                                      // MakerGen.cs:239
                                                }                                                                                           // MakerGen.cs:240
                                            }                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                             // MakerGen.cs:393
                                            {                                                                                               // MakerGen.cs:394
                                                base.Write(sDef);                                                                           // MakerGen.cs:395
                                                Code.Write(sDef);                                                                           // MakerGen.cs:215
                                                Value.Write(sDef);                                                                          // MakerGen.cs:215
                                            }                                                                                               // MakerGen.cs:397
                                        }                                                                                                   // MakerGen.cs:399
                                        public Type_Component_Elements Elements                                                             // MakerGen.cs:401
                                        {                                                                                                   // MakerGen.cs:402
                                            get                                                                                             // MakerGen.cs:403
                                            {                                                                                               // MakerGen.cs:404
                                                if (this.elements == null)                                                                  // MakerGen.cs:405
                                                    this.elements = new Type_Component_Elements();                                          // MakerGen.cs:406
                                                return this.elements;                                                                       // MakerGen.cs:407
                                            }                                                                                               // MakerGen.cs:408
                                        }                                                                                                   // MakerGen.cs:409
                                        Type_Component_Elements elements;                                                                   // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                                        public Type_Component()                                                                             // MakerGen.cs:413
                                        {                                                                                                   // MakerGen.cs:414
                                        }                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                 // MakerGen.cs:419
                                        {                                                                                                   // MakerGen.cs:420
                                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                              // MakerGen.cs:421
                                            {                                                                                               // MakerGen.cs:422
                                                Path = "MeasureReport.group.stratifier.stratum.component",                                  // MakerGen.cs:423
                                                ElementId = "MeasureReport.group.stratifier.stratum.component"                              // MakerGen.cs:424
                                            });                                                                                             // MakerGen.cs:425
                                            if (this.elements != null)                                                                      // MakerGen.cs:426
                                                this.elements.Write(sDef);                                                                  // MakerGen.cs:427
                                        }                                                                                                   // MakerGen.cs:428
                                    }                                                                                                       // MakerGen.cs:429
                                    // 24. MeasureReport.group.stratifier.stratum.population
                                    public class Type_Population : FhirKhit.Maker.Common.Complex.ComplexBase                                // MakerGen.cs:379
                                    {                                                                                                       // MakerGen.cs:380
                                        public class Type_Population_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                 // MakerGen.cs:381
                                        {                                                                                                   // MakerGen.cs:382
                                            // 25. MeasureReport.group.stratifier.stratum.population.code
                                            public ElementDefinitionInfo Code;                                                              // MakerGen.cs:211
                                            // 26. MeasureReport.group.stratifier.stratum.population.count
                                            public ElementDefinitionInfo Count;                                                             // MakerGen.cs:211
                                            // 27. MeasureReport.group.stratifier.stratum.population.subjectResults
                                            public ElementDefinitionInfo SubjectResults;                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                                            public Type_Population_Elements()                                                               // MakerGen.cs:387
                                            {                                                                                               // MakerGen.cs:388
                                                {                                                                                           // MakerGen.cs:226
                                                    // 25. MeasureReport.group.stratifier.stratum.population.code
                                                    this.Code = new ElementDefinitionInfo                                                   // MakerGen.cs:228
                                                    {                                                                                       // MakerGen.cs:229
                                                        Name = "Code",                                                                      // MakerGen.cs:230
                                                        Path= "MeasureReport.group.stratifier.stratum.population.code",                     // MakerGen.cs:231
                                                        Id = "MeasureReport.group.stratifier.stratum.population.code",                      // MakerGen.cs:232
                                                        Min = 0,                                                                            // MakerGen.cs:233
                                                        Max = 1,                                                                            // MakerGen.cs:234
                                                        Types = new BaseType[]                                                              // MakerGen.cs:235
                                                        {                                                                                   // MakerGen.cs:236
                                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                               // MakerGen.cs:310
                                                            {                                                                               // MakerGen.cs:311
                                                            }                                                                               // MakerGen.cs:314
                                                        }                                                                                   // MakerGen.cs:238
                                                    };                                                                                      // MakerGen.cs:239
                                                }                                                                                           // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:226
                                                    // 26. MeasureReport.group.stratifier.stratum.population.count
                                                    this.Count = new ElementDefinitionInfo                                                  // MakerGen.cs:228
                                                    {                                                                                       // MakerGen.cs:229
                                                        Name = "Count",                                                                     // MakerGen.cs:230
                                                        Path= "MeasureReport.group.stratifier.stratum.population.count",                    // MakerGen.cs:231
                                                        Id = "MeasureReport.group.stratifier.stratum.population.count",                     // MakerGen.cs:232
                                                        Min = 0,                                                                            // MakerGen.cs:233
                                                        Max = 1,                                                                            // MakerGen.cs:234
                                                        Types = new BaseType[]                                                              // MakerGen.cs:235
                                                        {                                                                                   // MakerGen.cs:236
                                                            new FhirKhit.Maker.Common.Primitive.Integer                                     // MakerGen.cs:295
                                                            {                                                                               // MakerGen.cs:296
                                                            }                                                                               // MakerGen.cs:299
                                                        }                                                                                   // MakerGen.cs:238
                                                    };                                                                                      // MakerGen.cs:239
                                                }                                                                                           // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:226
                                                    // 27. MeasureReport.group.stratifier.stratum.population.subjectResults
                                                    this.SubjectResults = new ElementDefinitionInfo                                         // MakerGen.cs:228
                                                    {                                                                                       // MakerGen.cs:229
                                                        Name = "SubjectResults",                                                            // MakerGen.cs:230
                                                        Path= "MeasureReport.group.stratifier.stratum.population.subjectResults",           // MakerGen.cs:231
                                                        Id = "MeasureReport.group.stratifier.stratum.population.subjectResults",            // MakerGen.cs:232
                                                        Min = 0,                                                                            // MakerGen.cs:233
                                                        Max = 1,                                                                            // MakerGen.cs:234
                                                        Types = new BaseType[]                                                              // MakerGen.cs:235
                                                        {                                                                                   // MakerGen.cs:236
                                                            new FhirKhit.Maker.Common.Complex.Reference                                     // MakerGen.cs:341
                                                            {                                                                               // MakerGen.cs:342
                                                                TargetProfile = new String[]                                                // MakerGen.cs:344
                                                                {                                                                           // CodeEditorExtensions.cs:28
                                                                    "http://hl7.org/fhir/StructureDefinition/List"                          // MakerGen.cs:344
                                                                }                                                                           // CodeEditorExtensions.cs:34
                                                            }                                                                               // MakerGen.cs:345
                                                        }                                                                                   // MakerGen.cs:238
                                                    };                                                                                      // MakerGen.cs:239
                                                }                                                                                           // MakerGen.cs:240
                                            }                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                             // MakerGen.cs:393
                                            {                                                                                               // MakerGen.cs:394
                                                base.Write(sDef);                                                                           // MakerGen.cs:395
                                                Code.Write(sDef);                                                                           // MakerGen.cs:215
                                                Count.Write(sDef);                                                                          // MakerGen.cs:215
                                                SubjectResults.Write(sDef);                                                                 // MakerGen.cs:215
                                            }                                                                                               // MakerGen.cs:397
                                        }                                                                                                   // MakerGen.cs:399
                                        public Type_Population_Elements Elements                                                            // MakerGen.cs:401
                                        {                                                                                                   // MakerGen.cs:402
                                            get                                                                                             // MakerGen.cs:403
                                            {                                                                                               // MakerGen.cs:404
                                                if (this.elements == null)                                                                  // MakerGen.cs:405
                                                    this.elements = new Type_Population_Elements();                                         // MakerGen.cs:406
                                                return this.elements;                                                                       // MakerGen.cs:407
                                            }                                                                                               // MakerGen.cs:408
                                        }                                                                                                   // MakerGen.cs:409
                                        Type_Population_Elements elements;                                                                  // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                                        public Type_Population()                                                                            // MakerGen.cs:413
                                        {                                                                                                   // MakerGen.cs:414
                                        }                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                 // MakerGen.cs:419
                                        {                                                                                                   // MakerGen.cs:420
                                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                              // MakerGen.cs:421
                                            {                                                                                               // MakerGen.cs:422
                                                Path = "MeasureReport.group.stratifier.stratum.population",                                 // MakerGen.cs:423
                                                ElementId = "MeasureReport.group.stratifier.stratum.population"                             // MakerGen.cs:424
                                            });                                                                                             // MakerGen.cs:425
                                            if (this.elements != null)                                                                      // MakerGen.cs:426
                                                this.elements.Write(sDef);                                                                  // MakerGen.cs:427
                                        }                                                                                                   // MakerGen.cs:428
                                    }                                                                                                       // MakerGen.cs:429
                                    // 20. MeasureReport.group.stratifier.stratum.value
                                    public ElementDefinitionInfo Value;                                                                     // MakerGen.cs:211
                                    // 21. MeasureReport.group.stratifier.stratum.component
                                    public ElementDefinitionInfo Component;                                                                 // MakerGen.cs:211
                                    // 24. MeasureReport.group.stratifier.stratum.population
                                    public ElementDefinitionInfo Population;                                                                // MakerGen.cs:211
                                    // 28. MeasureReport.group.stratifier.stratum.measureScore
                                    public ElementDefinitionInfo MeasureScore;                                                              // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                                    public Type_Stratum_Elements()                                                                          // MakerGen.cs:387
                                    {                                                                                                       // MakerGen.cs:388
                                        {                                                                                                   // MakerGen.cs:226
                                            // 20. MeasureReport.group.stratifier.stratum.value
                                            this.Value = new ElementDefinitionInfo                                                          // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Value",                                                                             // MakerGen.cs:230
                                                Path= "MeasureReport.group.stratifier.stratum.value",                                       // MakerGen.cs:231
                                                Id = "MeasureReport.group.stratifier.stratum.value",                                        // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:310
                                                    {                                                                                       // MakerGen.cs:311
                                                    }                                                                                       // MakerGen.cs:314
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 21. MeasureReport.group.stratifier.stratum.component
                                            this.Component = new ElementDefinitionInfo                                                      // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Component",                                                                         // MakerGen.cs:230
                                                Path= "MeasureReport.group.stratifier.stratum.component",                                   // MakerGen.cs:231
                                                Id = "MeasureReport.group.stratifier.stratum.component",                                    // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = -1,                                                                                   // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new Type_Component                                                                      // MakerGen.cs:254
                                                    {                                                                                       // MakerGen.cs:255
                                                    }                                                                                       // MakerGen.cs:256
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 24. MeasureReport.group.stratifier.stratum.population
                                            this.Population = new ElementDefinitionInfo                                                     // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "Population",                                                                        // MakerGen.cs:230
                                                Path= "MeasureReport.group.stratifier.stratum.population",                                  // MakerGen.cs:231
                                                Id = "MeasureReport.group.stratifier.stratum.population",                                   // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = -1,                                                                                   // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new Type_Population                                                                     // MakerGen.cs:254
                                                    {                                                                                       // MakerGen.cs:255
                                                    }                                                                                       // MakerGen.cs:256
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:226
                                            // 28. MeasureReport.group.stratifier.stratum.measureScore
                                            this.MeasureScore = new ElementDefinitionInfo                                                   // MakerGen.cs:228
                                            {                                                                                               // MakerGen.cs:229
                                                Name = "MeasureScore",                                                                      // MakerGen.cs:230
                                                Path= "MeasureReport.group.stratifier.stratum.measureScore",                                // MakerGen.cs:231
                                                Id = "MeasureReport.group.stratifier.stratum.measureScore",                                 // MakerGen.cs:232
                                                Min = 0,                                                                                    // MakerGen.cs:233
                                                Max = 1,                                                                                    // MakerGen.cs:234
                                                Types = new BaseType[]                                                                      // MakerGen.cs:235
                                                {                                                                                           // MakerGen.cs:236
                                                    new FhirKhit.Maker.Common.Complex.Quantity                                              // MakerGen.cs:353
                                                    {                                                                                       // MakerGen.cs:354
                                                    }                                                                                       // MakerGen.cs:355
                                                }                                                                                           // MakerGen.cs:238
                                            };                                                                                              // MakerGen.cs:239
                                        }                                                                                                   // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:393
                                    {                                                                                                       // MakerGen.cs:394
                                        base.Write(sDef);                                                                                   // MakerGen.cs:395
                                        Value.Write(sDef);                                                                                  // MakerGen.cs:215
                                        Component.Write(sDef);                                                                              // MakerGen.cs:215
                                        Population.Write(sDef);                                                                             // MakerGen.cs:215
                                        MeasureScore.Write(sDef);                                                                           // MakerGen.cs:215
                                    }                                                                                                       // MakerGen.cs:397
                                }                                                                                                           // MakerGen.cs:399
                                public Type_Stratum_Elements Elements                                                                       // MakerGen.cs:401
                                {                                                                                                           // MakerGen.cs:402
                                    get                                                                                                     // MakerGen.cs:403
                                    {                                                                                                       // MakerGen.cs:404
                                        if (this.elements == null)                                                                          // MakerGen.cs:405
                                            this.elements = new Type_Stratum_Elements();                                                    // MakerGen.cs:406
                                        return this.elements;                                                                               // MakerGen.cs:407
                                    }                                                                                                       // MakerGen.cs:408
                                }                                                                                                           // MakerGen.cs:409
                                Type_Stratum_Elements elements;                                                                             // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                                public Type_Stratum()                                                                                       // MakerGen.cs:413
                                {                                                                                                           // MakerGen.cs:414
                                }                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:419
                                {                                                                                                           // MakerGen.cs:420
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:421
                                    {                                                                                                       // MakerGen.cs:422
                                        Path = "MeasureReport.group.stratifier.stratum",                                                    // MakerGen.cs:423
                                        ElementId = "MeasureReport.group.stratifier.stratum"                                                // MakerGen.cs:424
                                    });                                                                                                     // MakerGen.cs:425
                                    if (this.elements != null)                                                                              // MakerGen.cs:426
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:427
                                }                                                                                                           // MakerGen.cs:428
                            }                                                                                                               // MakerGen.cs:429
                            // 18. MeasureReport.group.stratifier.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:211
                            // 19. MeasureReport.group.stratifier.stratum
                            public ElementDefinitionInfo Stratum;                                                                           // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Stratifier_Elements()                                                                               // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 18. MeasureReport.group.stratifier.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Code",                                                                                      // MakerGen.cs:230
                                        Path= "MeasureReport.group.stratifier.code",                                                        // MakerGen.cs:231
                                        Id = "MeasureReport.group.stratifier.code",                                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 19. MeasureReport.group.stratifier.stratum
                                    this.Stratum = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Stratum",                                                                                   // MakerGen.cs:230
                                        Path= "MeasureReport.group.stratifier.stratum",                                                     // MakerGen.cs:231
                                        Id = "MeasureReport.group.stratifier.stratum",                                                      // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new Type_Stratum                                                                                // MakerGen.cs:254
                                            {                                                                                               // MakerGen.cs:255
                                            }                                                                                               // MakerGen.cs:256
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Code.Write(sDef);                                                                                           // MakerGen.cs:215
                                Stratum.Write(sDef);                                                                                        // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Stratifier_Elements Elements                                                                            // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Stratifier_Elements();                                                         // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Stratifier_Elements elements;                                                                                  // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Stratifier()                                                                                            // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "MeasureReport.group.stratifier",                                                                    // MakerGen.cs:423
                                ElementId = "MeasureReport.group.stratifier"                                                                // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 11. MeasureReport.group.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:211
                    // 12. MeasureReport.group.population
                    public ElementDefinitionInfo Population;                                                                                // MakerGen.cs:211
                    // 16. MeasureReport.group.measureScore
                    public ElementDefinitionInfo MeasureScore;                                                                              // MakerGen.cs:211
                    // 17. MeasureReport.group.stratifier
                    public ElementDefinitionInfo Stratifier;                                                                                // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Group_Elements()                                                                                            // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 11. MeasureReport.group.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Code",                                                                                              // MakerGen.cs:230
                                Path= "MeasureReport.group.code",                                                                           // MakerGen.cs:231
                                Id = "MeasureReport.group.code",                                                                            // MakerGen.cs:232
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
                            // 12. MeasureReport.group.population
                            this.Population = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Population",                                                                                        // MakerGen.cs:230
                                Path= "MeasureReport.group.population",                                                                     // MakerGen.cs:231
                                Id = "MeasureReport.group.population",                                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Population                                                                                     // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 16. MeasureReport.group.measureScore
                            this.MeasureScore = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "MeasureScore",                                                                                      // MakerGen.cs:230
                                Path= "MeasureReport.group.measureScore",                                                                   // MakerGen.cs:231
                                Id = "MeasureReport.group.measureScore",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 17. MeasureReport.group.stratifier
                            this.Stratifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Stratifier",                                                                                        // MakerGen.cs:230
                                Path= "MeasureReport.group.stratifier",                                                                     // MakerGen.cs:231
                                Id = "MeasureReport.group.stratifier",                                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Stratifier                                                                                     // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Population.Write(sDef);                                                                                             // MakerGen.cs:215
                        MeasureScore.Write(sDef);                                                                                           // MakerGen.cs:215
                        Stratifier.Write(sDef);                                                                                             // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Group_Elements Elements                                                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Group_Elements();                                                                      // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Group_Elements elements;                                                                                               // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Group()                                                                                                         // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "MeasureReport.group",                                                                                       // MakerGen.cs:423
                        ElementId = "MeasureReport.group"                                                                                   // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. MeasureReport.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 2. MeasureReport.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 3. MeasureReport.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:211
            // 4. MeasureReport.measure
            public ElementDefinitionInfo Measure;                                                                                           // MakerGen.cs:211
            // 5. MeasureReport.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:211
            // 6. MeasureReport.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:211
            // 7. MeasureReport.reporter
            public ElementDefinitionInfo Reporter;                                                                                          // MakerGen.cs:211
            // 8. MeasureReport.period
            public ElementDefinitionInfo Period;                                                                                            // MakerGen.cs:211
            // 9. MeasureReport.improvementNotation
            public ElementDefinitionInfo ImprovementNotation;                                                                               // MakerGen.cs:211
            // 10. MeasureReport.group
            public ElementDefinitionInfo Group;                                                                                             // MakerGen.cs:211
            // 29. MeasureReport.evaluatedResource
            public ElementDefinitionInfo EvaluatedResource;                                                                                 // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public MeasureReport_Elements()                                                                                                 // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. MeasureReport.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "MeasureReport.identifier",                                                                                   // MakerGen.cs:231
                        Id = "MeasureReport.identifier",                                                                                    // MakerGen.cs:232
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
                    // 2. MeasureReport.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "MeasureReport.status",                                                                                       // MakerGen.cs:231
                        Id = "MeasureReport.status",                                                                                        // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. MeasureReport.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Type",                                                                                                      // MakerGen.cs:230
                        Path= "MeasureReport.type",                                                                                         // MakerGen.cs:231
                        Id = "MeasureReport.type",                                                                                          // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. MeasureReport.measure
                    this.Measure = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Measure",                                                                                                   // MakerGen.cs:230
                        Path= "MeasureReport.measure",                                                                                      // MakerGen.cs:231
                        Id = "MeasureReport.measure",                                                                                       // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                                TargetProfile = new String[]                                                                                // MakerGen.cs:298
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Measure"                                                       // MakerGen.cs:298
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. MeasureReport.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Subject",                                                                                                   // MakerGen.cs:230
                        Path= "MeasureReport.subject",                                                                                      // MakerGen.cs:231
                        Id = "MeasureReport.subject",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Location",                                                     // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. MeasureReport.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Date",                                                                                                      // MakerGen.cs:230
                        Path= "MeasureReport.date",                                                                                         // MakerGen.cs:231
                        Id = "MeasureReport.date",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. MeasureReport.reporter
                    this.Reporter = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Reporter",                                                                                                  // MakerGen.cs:230
                        Path= "MeasureReport.reporter",                                                                                     // MakerGen.cs:231
                        Id = "MeasureReport.reporter",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Location",                                                     // MakerGen.cs:344
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. MeasureReport.period
                    this.Period = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Period",                                                                                                    // MakerGen.cs:230
                        Path= "MeasureReport.period",                                                                                       // MakerGen.cs:231
                        Id = "MeasureReport.period",                                                                                        // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. MeasureReport.improvementNotation
                    this.ImprovementNotation = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ImprovementNotation",                                                                                       // MakerGen.cs:230
                        Path= "MeasureReport.improvementNotation",                                                                          // MakerGen.cs:231
                        Id = "MeasureReport.improvementNotation",                                                                           // MakerGen.cs:232
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
                    // 10. MeasureReport.group
                    this.Group = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Group",                                                                                                     // MakerGen.cs:230
                        Path= "MeasureReport.group",                                                                                        // MakerGen.cs:231
                        Id = "MeasureReport.group",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Group                                                                                                  // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 29. MeasureReport.evaluatedResource
                    this.EvaluatedResource = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "EvaluatedResource",                                                                                         // MakerGen.cs:230
                        Path= "MeasureReport.evaluatedResource",                                                                            // MakerGen.cs:231
                        Id = "MeasureReport.evaluatedResource",                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:344
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
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                Type.Write(sDef);                                                                                                           // MakerGen.cs:215
                Measure.Write(sDef);                                                                                                        // MakerGen.cs:215
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:215
                Date.Write(sDef);                                                                                                           // MakerGen.cs:215
                Reporter.Write(sDef);                                                                                                       // MakerGen.cs:215
                Period.Write(sDef);                                                                                                         // MakerGen.cs:215
                ImprovementNotation.Write(sDef);                                                                                            // MakerGen.cs:215
                Group.Write(sDef);                                                                                                          // MakerGen.cs:215
                EvaluatedResource.Write(sDef);                                                                                              // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public MeasureReport_Elements Elements                                                                                              // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new MeasureReport_Elements();                                                                           // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        MeasureReport_Elements elements;                                                                                                    // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public MeasureReport()                                                                                                              // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "MeasureReport";                                                                                                    // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MeasureReport";                                                             // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "MeasureReport",                                                                                                     // MakerGen.cs:423
                ElementId = "MeasureReport"                                                                                                 // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
