using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'MeasureReport'
    /// </summary>
    // 0. MeasureReport
    public class Resource_MeasureReport : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                            // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 10. MeasureReport.group
        public class Type_Group : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 12. MeasureReport.group.population
            public class Type_Population : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 13. MeasureReport.group.population.code
                public ElementDefinitionInfo Element_Code;                                                                                  // MakerGen.cs:219
                // 14. MeasureReport.group.population.count
                public ElementDefinitionInfo Element_Count;                                                                                 // MakerGen.cs:219
                // 15. MeasureReport.group.population.subjectResults
                public ElementDefinitionInfo Element_SubjectResults;                                                                        // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "MeasureReport.group.population",                                                                            // MakerGen.cs:395
                        ElementId = "MeasureReport.group.population"                                                                        // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Code.Write(sDef);                                                                                               // MakerGen.cs:223
                    Element_Count.Write(sDef);                                                                                              // MakerGen.cs:223
                    Element_SubjectResults.Write(sDef);                                                                                     // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Population()                                                                                                    // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 13. MeasureReport.group.population.code
                        this.Element_Code = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Code",                                                                                          // MakerGen.cs:238
                            Path= "MeasureReport.group.population.code",                                                                    // MakerGen.cs:239
                            Id = "MeasureReport.group.population.code",                                                                     // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 14. MeasureReport.group.population.count
                        this.Element_Count = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Count",                                                                                         // MakerGen.cs:238
                            Path= "MeasureReport.group.population.count",                                                                   // MakerGen.cs:239
                            Id = "MeasureReport.group.population.count",                                                                    // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 15. MeasureReport.group.population.subjectResults
                        this.Element_SubjectResults = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_SubjectResults",                                                                                // MakerGen.cs:238
                            Path= "MeasureReport.group.population.subjectResults",                                                          // MakerGen.cs:239
                            Id = "MeasureReport.group.population.subjectResults",                                                           // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Reference                                                            // MakerGen.cs:346
                                {                                                                                                           // MakerGen.cs:347
                                    TargetProfile = new String[]                                                                            // MakerGen.cs:349
                                    {                                                                                                       // CodeEditorExtensions.cs:28
                                        "http://hl7.org/fhir/StructureDefinition/List"                                                      // MakerGen.cs:349
                                    }                                                                                                       // CodeEditorExtensions.cs:34
                                }                                                                                                           // MakerGen.cs:350
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 17. MeasureReport.group.stratifier
            public class Type_Stratifier : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 19. MeasureReport.group.stratifier.stratum
                public class Type_Stratum : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    // 21. MeasureReport.group.stratifier.stratum.component
                    public class Type_Component : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        // 22. MeasureReport.group.stratifier.stratum.component.code
                        public ElementDefinitionInfo Element_Code;                                                                          // MakerGen.cs:219
                        // 23. MeasureReport.group.stratifier.stratum.component.value
                        public ElementDefinitionInfo Element_Value;                                                                         // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:390
                        {                                                                                                                   // MakerGen.cs:391
                            base.Write(sDef);                                                                                               // MakerGen.cs:392
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                Path = "MeasureReport.group.stratifier.stratum.component",                                                  // MakerGen.cs:395
                                ElementId = "MeasureReport.group.stratifier.stratum.component"                                              // MakerGen.cs:396
                            });                                                                                                             // MakerGen.cs:397
                            Element_Code.Write(sDef);                                                                                       // MakerGen.cs:223
                            Element_Value.Write(sDef);                                                                                      // MakerGen.cs:223
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                        public Type_Component()                                                                                             // MakerGen.cs:402
                        {                                                                                                                   // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:234
                                // 22. MeasureReport.group.stratifier.stratum.component.code
                                this.Element_Code = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    Name = "Element_Code",                                                                                  // MakerGen.cs:238
                                    Path= "MeasureReport.group.stratifier.stratum.component.code",                                          // MakerGen.cs:239
                                    Id = "MeasureReport.group.stratifier.stratum.component.code",                                           // MakerGen.cs:240
                                    Min = 1,                                                                                                // MakerGen.cs:241
                                    Max = 1,                                                                                                // MakerGen.cs:242
                                    Types = new BaseType[]                                                                                  // MakerGen.cs:243
                                    {                                                                                                       // MakerGen.cs:244
                                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                              // MakerGen.cs:318
                                        {                                                                                                   // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:322
                                    }                                                                                                       // MakerGen.cs:246
                                };                                                                                                          // MakerGen.cs:247
                            }                                                                                                               // MakerGen.cs:248
                            {                                                                                                               // MakerGen.cs:234
                                // 23. MeasureReport.group.stratifier.stratum.component.value
                                this.Element_Value = new ElementDefinitionInfo                                                              // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    Name = "Element_Value",                                                                                 // MakerGen.cs:238
                                    Path= "MeasureReport.group.stratifier.stratum.component.value",                                         // MakerGen.cs:239
                                    Id = "MeasureReport.group.stratifier.stratum.component.value",                                          // MakerGen.cs:240
                                    Min = 1,                                                                                                // MakerGen.cs:241
                                    Max = 1,                                                                                                // MakerGen.cs:242
                                    Types = new BaseType[]                                                                                  // MakerGen.cs:243
                                    {                                                                                                       // MakerGen.cs:244
                                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                              // MakerGen.cs:318
                                        {                                                                                                   // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:322
                                    }                                                                                                       // MakerGen.cs:246
                                };                                                                                                          // MakerGen.cs:247
                            }                                                                                                               // MakerGen.cs:248
                        }                                                                                                                   // MakerGen.cs:405
                    }                                                                                                                       // MakerGen.cs:407
                    // 24. MeasureReport.group.stratifier.stratum.population
                    public class Type_Population : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        // 25. MeasureReport.group.stratifier.stratum.population.code
                        public ElementDefinitionInfo Element_Code;                                                                          // MakerGen.cs:219
                        // 26. MeasureReport.group.stratifier.stratum.population.count
                        public ElementDefinitionInfo Element_Count;                                                                         // MakerGen.cs:219
                        // 27. MeasureReport.group.stratifier.stratum.population.subjectResults
                        public ElementDefinitionInfo Element_SubjectResults;                                                                // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:390
                        {                                                                                                                   // MakerGen.cs:391
                            base.Write(sDef);                                                                                               // MakerGen.cs:392
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                Path = "MeasureReport.group.stratifier.stratum.population",                                                 // MakerGen.cs:395
                                ElementId = "MeasureReport.group.stratifier.stratum.population"                                             // MakerGen.cs:396
                            });                                                                                                             // MakerGen.cs:397
                            Element_Code.Write(sDef);                                                                                       // MakerGen.cs:223
                            Element_Count.Write(sDef);                                                                                      // MakerGen.cs:223
                            Element_SubjectResults.Write(sDef);                                                                             // MakerGen.cs:223
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                        public Type_Population()                                                                                            // MakerGen.cs:402
                        {                                                                                                                   // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:234
                                // 25. MeasureReport.group.stratifier.stratum.population.code
                                this.Element_Code = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    Name = "Element_Code",                                                                                  // MakerGen.cs:238
                                    Path= "MeasureReport.group.stratifier.stratum.population.code",                                         // MakerGen.cs:239
                                    Id = "MeasureReport.group.stratifier.stratum.population.code",                                          // MakerGen.cs:240
                                    Min = 0,                                                                                                // MakerGen.cs:241
                                    Max = 1,                                                                                                // MakerGen.cs:242
                                    Types = new BaseType[]                                                                                  // MakerGen.cs:243
                                    {                                                                                                       // MakerGen.cs:244
                                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                              // MakerGen.cs:318
                                        {                                                                                                   // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:322
                                    }                                                                                                       // MakerGen.cs:246
                                };                                                                                                          // MakerGen.cs:247
                            }                                                                                                               // MakerGen.cs:248
                            {                                                                                                               // MakerGen.cs:234
                                // 26. MeasureReport.group.stratifier.stratum.population.count
                                this.Element_Count = new ElementDefinitionInfo                                                              // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    Name = "Element_Count",                                                                                 // MakerGen.cs:238
                                    Path= "MeasureReport.group.stratifier.stratum.population.count",                                        // MakerGen.cs:239
                                    Id = "MeasureReport.group.stratifier.stratum.population.count",                                         // MakerGen.cs:240
                                    Min = 0,                                                                                                // MakerGen.cs:241
                                    Max = 1,                                                                                                // MakerGen.cs:242
                                    Types = new BaseType[]                                                                                  // MakerGen.cs:243
                                    {                                                                                                       // MakerGen.cs:244
                                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                               // MakerGen.cs:303
                                        {                                                                                                   // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:307
                                    }                                                                                                       // MakerGen.cs:246
                                };                                                                                                          // MakerGen.cs:247
                            }                                                                                                               // MakerGen.cs:248
                            {                                                                                                               // MakerGen.cs:234
                                // 27. MeasureReport.group.stratifier.stratum.population.subjectResults
                                this.Element_SubjectResults = new ElementDefinitionInfo                                                     // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    Name = "Element_SubjectResults",                                                                        // MakerGen.cs:238
                                    Path= "MeasureReport.group.stratifier.stratum.population.subjectResults",                               // MakerGen.cs:239
                                    Id = "MeasureReport.group.stratifier.stratum.population.subjectResults",                                // MakerGen.cs:240
                                    Min = 0,                                                                                                // MakerGen.cs:241
                                    Max = 1,                                                                                                // MakerGen.cs:242
                                    Types = new BaseType[]                                                                                  // MakerGen.cs:243
                                    {                                                                                                       // MakerGen.cs:244
                                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                    // MakerGen.cs:346
                                        {                                                                                                   // MakerGen.cs:347
                                            TargetProfile = new String[]                                                                    // MakerGen.cs:349
                                            {                                                                                               // CodeEditorExtensions.cs:28
                                                "http://hl7.org/fhir/StructureDefinition/List"                                              // MakerGen.cs:349
                                            }                                                                                               // CodeEditorExtensions.cs:34
                                        }                                                                                                   // MakerGen.cs:350
                                    }                                                                                                       // MakerGen.cs:246
                                };                                                                                                          // MakerGen.cs:247
                            }                                                                                                               // MakerGen.cs:248
                        }                                                                                                                   // MakerGen.cs:405
                    }                                                                                                                       // MakerGen.cs:407
                    // 20. MeasureReport.group.stratifier.stratum.value
                    public ElementDefinitionInfo Element_Value;                                                                             // MakerGen.cs:219
                    // 21. MeasureReport.group.stratifier.stratum.component
                    public ElementDefinitionInfo Element_Component;                                                                         // MakerGen.cs:219
                    // 24. MeasureReport.group.stratifier.stratum.population
                    public ElementDefinitionInfo Element_Population;                                                                        // MakerGen.cs:219
                    // 28. MeasureReport.group.stratifier.stratum.measureScore
                    public ElementDefinitionInfo Element_MeasureScore;                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:390
                    {                                                                                                                       // MakerGen.cs:391
                        base.Write(sDef);                                                                                                   // MakerGen.cs:392
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:394
                            Path = "MeasureReport.group.stratifier.stratum",                                                                // MakerGen.cs:395
                            ElementId = "MeasureReport.group.stratifier.stratum"                                                            // MakerGen.cs:396
                        });                                                                                                                 // MakerGen.cs:397
                        Element_Value.Write(sDef);                                                                                          // MakerGen.cs:223
                        Element_Component.Write(sDef);                                                                                      // MakerGen.cs:223
                        Element_Population.Write(sDef);                                                                                     // MakerGen.cs:223
                        Element_MeasureScore.Write(sDef);                                                                                   // MakerGen.cs:223
                    }                                                                                                                       // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                    public Type_Stratum()                                                                                                   // MakerGen.cs:402
                    {                                                                                                                       // MakerGen.cs:403
                        {                                                                                                                   // MakerGen.cs:234
                            // 20. MeasureReport.group.stratifier.stratum.value
                            this.Element_Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Value",                                                                                     // MakerGen.cs:238
                                Path= "MeasureReport.group.stratifier.stratum.value",                                                       // MakerGen.cs:239
                                Id = "MeasureReport.group.stratifier.stratum.value",                                                        // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                  // MakerGen.cs:318
                                    {                                                                                                       // MakerGen.cs:319
                                    }                                                                                                       // MakerGen.cs:322
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 21. MeasureReport.group.stratifier.stratum.component
                            this.Element_Component = new ElementDefinitionInfo                                                              // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Component",                                                                                 // MakerGen.cs:238
                                Path= "MeasureReport.group.stratifier.stratum.component",                                                   // MakerGen.cs:239
                                Id = "MeasureReport.group.stratifier.stratum.component",                                                    // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = -1,                                                                                                   // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new Type_Component                                                                                      // MakerGen.cs:262
                                    {                                                                                                       // MakerGen.cs:263
                                    }                                                                                                       // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 24. MeasureReport.group.stratifier.stratum.population
                            this.Element_Population = new ElementDefinitionInfo                                                             // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_Population",                                                                                // MakerGen.cs:238
                                Path= "MeasureReport.group.stratifier.stratum.population",                                                  // MakerGen.cs:239
                                Id = "MeasureReport.group.stratifier.stratum.population",                                                   // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = -1,                                                                                                   // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new Type_Population                                                                                     // MakerGen.cs:262
                                    {                                                                                                       // MakerGen.cs:263
                                    }                                                                                                       // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                        {                                                                                                                   // MakerGen.cs:234
                            // 28. MeasureReport.group.stratifier.stratum.measureScore
                            this.Element_MeasureScore = new ElementDefinitionInfo                                                           // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                Name = "Element_MeasureScore",                                                                              // MakerGen.cs:238
                                Path= "MeasureReport.group.stratifier.stratum.measureScore",                                                // MakerGen.cs:239
                                Id = "MeasureReport.group.stratifier.stratum.measureScore",                                                 // MakerGen.cs:240
                                Min = 0,                                                                                                    // MakerGen.cs:241
                                Max = 1,                                                                                                    // MakerGen.cs:242
                                Types = new BaseType[]                                                                                      // MakerGen.cs:243
                                {                                                                                                           // MakerGen.cs:244
                                    new FhirKhit.Maker.Common.Complex.Type_Quantity                                                         // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:246
                            };                                                                                                              // MakerGen.cs:247
                        }                                                                                                                   // MakerGen.cs:248
                    }                                                                                                                       // MakerGen.cs:405
                }                                                                                                                           // MakerGen.cs:407
                // 18. MeasureReport.group.stratifier.code
                public ElementDefinitionInfo Element_Code;                                                                                  // MakerGen.cs:219
                // 19. MeasureReport.group.stratifier.stratum
                public ElementDefinitionInfo Element_Stratum;                                                                               // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "MeasureReport.group.stratifier",                                                                            // MakerGen.cs:395
                        ElementId = "MeasureReport.group.stratifier"                                                                        // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Code.Write(sDef);                                                                                               // MakerGen.cs:223
                    Element_Stratum.Write(sDef);                                                                                            // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_Stratifier()                                                                                                    // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 18. MeasureReport.group.stratifier.code
                        this.Element_Code = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Code",                                                                                          // MakerGen.cs:238
                            Path= "MeasureReport.group.stratifier.code",                                                                    // MakerGen.cs:239
                            Id = "MeasureReport.group.stratifier.code",                                                                     // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 19. MeasureReport.group.stratifier.stratum
                        this.Element_Stratum = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Stratum",                                                                                       // MakerGen.cs:238
                            Path= "MeasureReport.group.stratifier.stratum",                                                                 // MakerGen.cs:239
                            Id = "MeasureReport.group.stratifier.stratum",                                                                  // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new Type_Stratum                                                                                            // MakerGen.cs:262
                                {                                                                                                           // MakerGen.cs:263
                                }                                                                                                           // MakerGen.cs:264
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 11. MeasureReport.group.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:219
            // 12. MeasureReport.group.population
            public ElementDefinitionInfo Element_Population;                                                                                // MakerGen.cs:219
            // 16. MeasureReport.group.measureScore
            public ElementDefinitionInfo Element_MeasureScore;                                                                              // MakerGen.cs:219
            // 17. MeasureReport.group.stratifier
            public ElementDefinitionInfo Element_Stratifier;                                                                                // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "MeasureReport.group",                                                                                           // MakerGen.cs:395
                    ElementId = "MeasureReport.group"                                                                                       // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Population.Write(sDef);                                                                                             // MakerGen.cs:223
                Element_MeasureScore.Write(sDef);                                                                                           // MakerGen.cs:223
                Element_Stratifier.Write(sDef);                                                                                             // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Group()                                                                                                             // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 11. MeasureReport.group.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Code",                                                                                              // MakerGen.cs:238
                        Path= "MeasureReport.group.code",                                                                                   // MakerGen.cs:239
                        Id = "MeasureReport.group.code",                                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 12. MeasureReport.group.population
                    this.Element_Population = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Population",                                                                                        // MakerGen.cs:238
                        Path= "MeasureReport.group.population",                                                                             // MakerGen.cs:239
                        Id = "MeasureReport.group.population",                                                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Population                                                                                             // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 16. MeasureReport.group.measureScore
                    this.Element_MeasureScore = new ElementDefinitionInfo                                                                   // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_MeasureScore",                                                                                      // MakerGen.cs:238
                        Path= "MeasureReport.group.measureScore",                                                                           // MakerGen.cs:239
                        Id = "MeasureReport.group.measureScore",                                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Quantity                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 17. MeasureReport.group.stratifier
                    this.Element_Stratifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Stratifier",                                                                                        // MakerGen.cs:238
                        Path= "MeasureReport.group.stratifier",                                                                             // MakerGen.cs:239
                        Id = "MeasureReport.group.stratifier",                                                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_Stratifier                                                                                             // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. MeasureReport.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 2. MeasureReport.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 3. MeasureReport.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:219
        // 4. MeasureReport.measure
        public ElementDefinitionInfo Element_Measure;                                                                                       // MakerGen.cs:219
        // 5. MeasureReport.subject
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:219
        // 6. MeasureReport.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:219
        // 7. MeasureReport.reporter
        public ElementDefinitionInfo Element_Reporter;                                                                                      // MakerGen.cs:219
        // 8. MeasureReport.period
        public ElementDefinitionInfo Element_Period;                                                                                        // MakerGen.cs:219
        // 9. MeasureReport.improvementNotation
        public ElementDefinitionInfo Element_ImprovementNotation;                                                                           // MakerGen.cs:219
        // 10. MeasureReport.group
        public ElementDefinitionInfo Element_Group;                                                                                         // MakerGen.cs:219
        // 29. MeasureReport.evaluatedResource
        public ElementDefinitionInfo Element_EvaluatedResource;                                                                             // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "MeasureReport",                                                                                                     // MakerGen.cs:395
                ElementId = "MeasureReport"                                                                                                 // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Measure.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Date.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Reporter.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Period.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_ImprovementNotation.Write(sDef);                                                                                        // MakerGen.cs:223
            Element_Group.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_EvaluatedResource.Write(sDef);                                                                                          // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_MeasureReport()                                                                                                     // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. MeasureReport.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "MeasureReport.identifier",                                                                                       // MakerGen.cs:239
                    Id = "MeasureReport.identifier",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. MeasureReport.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "MeasureReport.status",                                                                                           // MakerGen.cs:239
                    Id = "MeasureReport.status",                                                                                            // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. MeasureReport.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:238
                    Path= "MeasureReport.type",                                                                                             // MakerGen.cs:239
                    Id = "MeasureReport.type",                                                                                              // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. MeasureReport.measure
                this.Element_Measure = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Measure",                                                                                               // MakerGen.cs:238
                    Path= "MeasureReport.measure",                                                                                          // MakerGen.cs:239
                    Id = "MeasureReport.measure",                                                                                           // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:306
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Measure"                                                           // MakerGen.cs:306
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. MeasureReport.subject
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:238
                    Path= "MeasureReport.subject",                                                                                          // MakerGen.cs:239
                    Id = "MeasureReport.subject",                                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Patient",                                                          // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Location",                                                         // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Device",                                                           // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                    // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Group"                                                             // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. MeasureReport.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:238
                    Path= "MeasureReport.date",                                                                                             // MakerGen.cs:239
                    Id = "MeasureReport.date",                                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. MeasureReport.reporter
                this.Element_Reporter = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Reporter",                                                                                              // MakerGen.cs:238
                    Path= "MeasureReport.reporter",                                                                                         // MakerGen.cs:239
                    Id = "MeasureReport.reporter",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                     // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                                 // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Location",                                                         // MakerGen.cs:349
                                "http://hl7.org/fhir/StructureDefinition/Organization"                                                      // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. MeasureReport.period
                this.Element_Period = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Period",                                                                                                // MakerGen.cs:238
                    Path= "MeasureReport.period",                                                                                           // MakerGen.cs:239
                    Id = "MeasureReport.period",                                                                                            // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. MeasureReport.improvementNotation
                this.Element_ImprovementNotation = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ImprovementNotation",                                                                                   // MakerGen.cs:238
                    Path= "MeasureReport.improvementNotation",                                                                              // MakerGen.cs:239
                    Id = "MeasureReport.improvementNotation",                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. MeasureReport.group
                this.Element_Group = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Group",                                                                                                 // MakerGen.cs:238
                    Path= "MeasureReport.group",                                                                                            // MakerGen.cs:239
                    Id = "MeasureReport.group",                                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Group                                                                                                      // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 29. MeasureReport.evaluatedResource
                this.Element_EvaluatedResource = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_EvaluatedResource",                                                                                     // MakerGen.cs:238
                    Path= "MeasureReport.evaluatedResource",                                                                                // MakerGen.cs:239
                    Id = "MeasureReport.evaluatedResource",                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Resource"                                                          // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "MeasureReport";                                                                                                    // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MeasureReport";                                                             // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
