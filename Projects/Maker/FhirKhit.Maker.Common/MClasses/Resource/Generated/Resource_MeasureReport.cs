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
    #endregion
    /// <summary>
    /// Fhir resource 'MeasureReport'
    /// </summary>
    // 0. MeasureReport
    public partial class Resource_MeasureReport : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 10. MeasureReport.group
        public partial class Type_Group : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 12. MeasureReport.group.population
            public partial class Type_Population : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 13. MeasureReport.group.population.code
                public ElementDefinitionInfo Element_Code;
                // 14. MeasureReport.group.population.count
                public ElementDefinitionInfo Element_Count;
                // 15. MeasureReport.group.population.subjectResults
                public ElementDefinitionInfo Element_SubjectResults;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MeasureReport.group.population",
                        ElementId = "MeasureReport.group.population"
                    });
                    Element_Code.Write(sDef);
                    Element_Count.Write(sDef);
                    Element_SubjectResults.Write(sDef);
                }
                
                public Type_Population()
                {
                    {
                        // 13. MeasureReport.group.population.code
                        this.Element_Code = new ElementDefinitionInfo
                        {
                            Name = "Element_Code",
                            Path= "MeasureReport.group.population.code",
                            Id = "MeasureReport.group.population.code",
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
                        // 14. MeasureReport.group.population.count
                        this.Element_Count = new ElementDefinitionInfo
                        {
                            Name = "Element_Count",
                            Path= "MeasureReport.group.population.count",
                            Id = "MeasureReport.group.population.count",
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
                    {
                        // 15. MeasureReport.group.population.subjectResults
                        this.Element_SubjectResults = new ElementDefinitionInfo
                        {
                            Name = "Element_SubjectResults",
                            Path= "MeasureReport.group.population.subjectResults",
                            Id = "MeasureReport.group.population.subjectResults",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Reference
                                {
                                    TargetProfile = new String[]
                                    {
                                        "http://hl7.org/fhir/StructureDefinition/List"
                                    }
                                }
                            }
                        };
                    }
                }
            }
            // 17. MeasureReport.group.stratifier
            public partial class Type_Stratifier : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 19. MeasureReport.group.stratifier.stratum
                public partial class Type_Stratum : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 21. MeasureReport.group.stratifier.stratum.component
                    public partial class Type_Component : FhirKhit.Maker.Common.Complex.ComplexBase
                    {
                        // 22. MeasureReport.group.stratifier.stratum.component.code
                        public ElementDefinitionInfo Element_Code;
                        // 23. MeasureReport.group.stratifier.stratum.component.value
                        public ElementDefinitionInfo Element_Value;
                        
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                        {
                            base.Write(sDef);
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                            {
                                Path = "MeasureReport.group.stratifier.stratum.component",
                                ElementId = "MeasureReport.group.stratifier.stratum.component"
                            });
                            Element_Code.Write(sDef);
                            Element_Value.Write(sDef);
                        }
                        
                        public Type_Component()
                        {
                            {
                                // 22. MeasureReport.group.stratifier.stratum.component.code
                                this.Element_Code = new ElementDefinitionInfo
                                {
                                    Name = "Element_Code",
                                    Path= "MeasureReport.group.stratifier.stratum.component.code",
                                    Id = "MeasureReport.group.stratifier.stratum.component.code",
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
                                // 23. MeasureReport.group.stratifier.stratum.component.value
                                this.Element_Value = new ElementDefinitionInfo
                                {
                                    Name = "Element_Value",
                                    Path= "MeasureReport.group.stratifier.stratum.component.value",
                                    Id = "MeasureReport.group.stratifier.stratum.component.value",
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
                        }
                    }
                    // 24. MeasureReport.group.stratifier.stratum.population
                    public partial class Type_Population : FhirKhit.Maker.Common.Complex.ComplexBase
                    {
                        // 25. MeasureReport.group.stratifier.stratum.population.code
                        public ElementDefinitionInfo Element_Code;
                        // 26. MeasureReport.group.stratifier.stratum.population.count
                        public ElementDefinitionInfo Element_Count;
                        // 27. MeasureReport.group.stratifier.stratum.population.subjectResults
                        public ElementDefinitionInfo Element_SubjectResults;
                        
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                        {
                            base.Write(sDef);
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                            {
                                Path = "MeasureReport.group.stratifier.stratum.population",
                                ElementId = "MeasureReport.group.stratifier.stratum.population"
                            });
                            Element_Code.Write(sDef);
                            Element_Count.Write(sDef);
                            Element_SubjectResults.Write(sDef);
                        }
                        
                        public Type_Population()
                        {
                            {
                                // 25. MeasureReport.group.stratifier.stratum.population.code
                                this.Element_Code = new ElementDefinitionInfo
                                {
                                    Name = "Element_Code",
                                    Path= "MeasureReport.group.stratifier.stratum.population.code",
                                    Id = "MeasureReport.group.stratifier.stratum.population.code",
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
                                // 26. MeasureReport.group.stratifier.stratum.population.count
                                this.Element_Count = new ElementDefinitionInfo
                                {
                                    Name = "Element_Count",
                                    Path= "MeasureReport.group.stratifier.stratum.population.count",
                                    Id = "MeasureReport.group.stratifier.stratum.population.count",
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
                            {
                                // 27. MeasureReport.group.stratifier.stratum.population.subjectResults
                                this.Element_SubjectResults = new ElementDefinitionInfo
                                {
                                    Name = "Element_SubjectResults",
                                    Path= "MeasureReport.group.stratifier.stratum.population.subjectResults",
                                    Id = "MeasureReport.group.stratifier.stratum.population.subjectResults",
                                    Min = 0,
                                    Max = 1,
                                    Types = new BaseType[]
                                    {
                                        new FhirKhit.Maker.Common.Complex.Type_Reference
                                        {
                                            TargetProfile = new String[]
                                            {
                                                "http://hl7.org/fhir/StructureDefinition/List"
                                            }
                                        }
                                    }
                                };
                            }
                        }
                    }
                    // 20. MeasureReport.group.stratifier.stratum.value
                    public ElementDefinitionInfo Element_Value;
                    // 21. MeasureReport.group.stratifier.stratum.component
                    public ElementDefinitionInfo Element_Component;
                    // 24. MeasureReport.group.stratifier.stratum.population
                    public ElementDefinitionInfo Element_Population;
                    // 28. MeasureReport.group.stratifier.stratum.measureScore
                    public ElementDefinitionInfo Element_MeasureScore;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "MeasureReport.group.stratifier.stratum",
                            ElementId = "MeasureReport.group.stratifier.stratum"
                        });
                        Element_Value.Write(sDef);
                        Element_Component.Write(sDef);
                        Element_Population.Write(sDef);
                        Element_MeasureScore.Write(sDef);
                    }
                    
                    public Type_Stratum()
                    {
                        {
                            // 20. MeasureReport.group.stratifier.stratum.value
                            this.Element_Value = new ElementDefinitionInfo
                            {
                                Name = "Element_Value",
                                Path= "MeasureReport.group.stratifier.stratum.value",
                                Id = "MeasureReport.group.stratifier.stratum.value",
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
                            // 21. MeasureReport.group.stratifier.stratum.component
                            this.Element_Component = new ElementDefinitionInfo
                            {
                                Name = "Element_Component",
                                Path= "MeasureReport.group.stratifier.stratum.component",
                                Id = "MeasureReport.group.stratifier.stratum.component",
                                Min = 0,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                    new Type_Component
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 24. MeasureReport.group.stratifier.stratum.population
                            this.Element_Population = new ElementDefinitionInfo
                            {
                                Name = "Element_Population",
                                Path= "MeasureReport.group.stratifier.stratum.population",
                                Id = "MeasureReport.group.stratifier.stratum.population",
                                Min = 0,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                    new Type_Population
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 28. MeasureReport.group.stratifier.stratum.measureScore
                            this.Element_MeasureScore = new ElementDefinitionInfo
                            {
                                Name = "Element_MeasureScore",
                                Path= "MeasureReport.group.stratifier.stratum.measureScore",
                                Id = "MeasureReport.group.stratifier.stratum.measureScore",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_Quantity
                                    {
                                    }
                                }
                            };
                        }
                    }
                }
                // 18. MeasureReport.group.stratifier.code
                public ElementDefinitionInfo Element_Code;
                // 19. MeasureReport.group.stratifier.stratum
                public ElementDefinitionInfo Element_Stratum;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "MeasureReport.group.stratifier",
                        ElementId = "MeasureReport.group.stratifier"
                    });
                    Element_Code.Write(sDef);
                    Element_Stratum.Write(sDef);
                }
                
                public Type_Stratifier()
                {
                    {
                        // 18. MeasureReport.group.stratifier.code
                        this.Element_Code = new ElementDefinitionInfo
                        {
                            Name = "Element_Code",
                            Path= "MeasureReport.group.stratifier.code",
                            Id = "MeasureReport.group.stratifier.code",
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
                        // 19. MeasureReport.group.stratifier.stratum
                        this.Element_Stratum = new ElementDefinitionInfo
                        {
                            Name = "Element_Stratum",
                            Path= "MeasureReport.group.stratifier.stratum",
                            Id = "MeasureReport.group.stratifier.stratum",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Stratum
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 11. MeasureReport.group.code
            public ElementDefinitionInfo Element_Code;
            // 12. MeasureReport.group.population
            public ElementDefinitionInfo Element_Population;
            // 16. MeasureReport.group.measureScore
            public ElementDefinitionInfo Element_MeasureScore;
            // 17. MeasureReport.group.stratifier
            public ElementDefinitionInfo Element_Stratifier;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "MeasureReport.group",
                    ElementId = "MeasureReport.group"
                });
                Element_Code.Write(sDef);
                Element_Population.Write(sDef);
                Element_MeasureScore.Write(sDef);
                Element_Stratifier.Write(sDef);
            }
            
            public Type_Group()
            {
                {
                    // 11. MeasureReport.group.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "MeasureReport.group.code",
                        Id = "MeasureReport.group.code",
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
                    // 12. MeasureReport.group.population
                    this.Element_Population = new ElementDefinitionInfo
                    {
                        Name = "Element_Population",
                        Path= "MeasureReport.group.population",
                        Id = "MeasureReport.group.population",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Population
                            {
                            }
                        }
                    };
                }
                {
                    // 16. MeasureReport.group.measureScore
                    this.Element_MeasureScore = new ElementDefinitionInfo
                    {
                        Name = "Element_MeasureScore",
                        Path= "MeasureReport.group.measureScore",
                        Id = "MeasureReport.group.measureScore",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Quantity
                            {
                            }
                        }
                    };
                }
                {
                    // 17. MeasureReport.group.stratifier
                    this.Element_Stratifier = new ElementDefinitionInfo
                    {
                        Name = "Element_Stratifier",
                        Path= "MeasureReport.group.stratifier",
                        Id = "MeasureReport.group.stratifier",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Stratifier
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. MeasureReport.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. MeasureReport.status
        public ElementDefinitionInfo Element_Status;
        // 3. MeasureReport.type
        public ElementDefinitionInfo Element_Type;
        // 4. MeasureReport.measure
        public ElementDefinitionInfo Element_Measure;
        // 5. MeasureReport.subject
        public ElementDefinitionInfo Element_Subject;
        // 6. MeasureReport.date
        public ElementDefinitionInfo Element_Date;
        // 7. MeasureReport.reporter
        public ElementDefinitionInfo Element_Reporter;
        // 8. MeasureReport.period
        public ElementDefinitionInfo Element_Period;
        // 9. MeasureReport.improvementNotation
        public ElementDefinitionInfo Element_ImprovementNotation;
        // 10. MeasureReport.group
        public ElementDefinitionInfo Element_Group;
        // 29. MeasureReport.evaluatedResource
        public ElementDefinitionInfo Element_EvaluatedResource;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "MeasureReport",
                ElementId = "MeasureReport"
            });
            Element_Identifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Type.Write(sDef);
            Element_Measure.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Date.Write(sDef);
            Element_Reporter.Write(sDef);
            Element_Period.Write(sDef);
            Element_ImprovementNotation.Write(sDef);
            Element_Group.Write(sDef);
            Element_EvaluatedResource.Write(sDef);
        }
        
        public Resource_MeasureReport()
        {
            {
                // 1. MeasureReport.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "MeasureReport.identifier",
                    Id = "MeasureReport.identifier",
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
                // 2. MeasureReport.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "MeasureReport.status",
                    Id = "MeasureReport.status",
                    Min = 1,
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
                // 3. MeasureReport.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "MeasureReport.type",
                    Id = "MeasureReport.type",
                    Min = 1,
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
                // 4. MeasureReport.measure
                this.Element_Measure = new ElementDefinitionInfo
                {
                    Name = "Element_Measure",
                    Path= "MeasureReport.measure",
                    Id = "MeasureReport.measure",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Measure"
                            }
                        }
                    }
                };
            }
            {
                // 5. MeasureReport.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "MeasureReport.subject",
                    Id = "MeasureReport.subject",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Location",
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                "http://hl7.org/fhir/StructureDefinition/Group"
                            }
                        }
                    }
                };
            }
            {
                // 6. MeasureReport.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "MeasureReport.date",
                    Id = "MeasureReport.date",
                    Min = 0,
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
                // 7. MeasureReport.reporter
                this.Element_Reporter = new ElementDefinitionInfo
                {
                    Name = "Element_Reporter",
                    Path= "MeasureReport.reporter",
                    Id = "MeasureReport.reporter",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Location",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 8. MeasureReport.period
                this.Element_Period = new ElementDefinitionInfo
                {
                    Name = "Element_Period",
                    Path= "MeasureReport.period",
                    Id = "MeasureReport.period",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        }
                    }
                };
            }
            {
                // 9. MeasureReport.improvementNotation
                this.Element_ImprovementNotation = new ElementDefinitionInfo
                {
                    Name = "Element_ImprovementNotation",
                    Path= "MeasureReport.improvementNotation",
                    Id = "MeasureReport.improvementNotation",
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
                // 10. MeasureReport.group
                this.Element_Group = new ElementDefinitionInfo
                {
                    Name = "Element_Group",
                    Path= "MeasureReport.group",
                    Id = "MeasureReport.group",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Group
                        {
                        }
                    }
                };
            }
            {
                // 29. MeasureReport.evaluatedResource
                this.Element_EvaluatedResource = new ElementDefinitionInfo
                {
                    Name = "Element_EvaluatedResource",
                    Path= "MeasureReport.evaluatedResource",
                    Id = "MeasureReport.evaluatedResource",
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
            this.Name = "MeasureReport";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/MeasureReport";
        }
    }
}
