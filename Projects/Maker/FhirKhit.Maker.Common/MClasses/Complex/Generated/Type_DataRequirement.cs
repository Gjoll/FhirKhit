using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Complex
{
    #region Json
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "DataRequirement",
      "url": "http://hl7.org/fhir/StructureDefinition/DataRequirement",
      "version": "4.0.0",
      "name": "DataRequirement",
      "status": "draft",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for DataRequirement Type: Describes a required data item for evaluation in terms of the type of data, and optional code or date-based filters of the data.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "DataRequirement",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "DataRequirement",
            "path": "DataRequirement",
            "short": "Describes a required data item",
            "definition": "Describes a required data item for evaluation in terms of the type of data, and optional code or date-based filters of the data.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "DataRequirement.type",
            "path": "DataRequirement.type",
            "short": "The type of the required data",
            "definition": "The type of the required data, specified as the type name of a resource. For profiles, this value is set to the type of the base resource of the profile.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "FHIRAllTypes"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "A list of all the concrete types defined in this version of the FHIR specification - Abstract Types, Data Types and Resource Types.",
              "valueSet": "http://hl7.org/fhir/ValueSet/all-types|4.0.0"
            }
          },
          {
            "id": "DataRequirement.profile",
            "path": "DataRequirement.profile",
            "short": "The profile of the required data",
            "definition": "The profile of the required data, specified as the uri of the profile definition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.subject[x]",
            "path": "DataRequirement.subject[x]",
            "short": "E.g. Patient, Practitioner, RelatedPerson, Organization, Location, Device",
            "definition": "The intended subjects of the data requirement. If this element is not provided, a Patient subject is assumed.",
            "comment": "The subject of a data requirement is critical, as the data being specified is determined with respect to a particular subject. This corresponds roughly to the notion of a Compartment in that it limits what data is available based on its relationship to the subject. In CQL, this corresponds to the context declaration.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ],
            "meaningWhenMissing": "Patient",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SubjectType"
                }
              ],
              "strength": "extensible",
              "description": "The possible types of subjects for a data requirement (E.g., Patient, Practitioner, Organization, Location, etc.).",
              "valueSet": "http://hl7.org/fhir/ValueSet/subject-type"
            }
          },
          {
            "id": "DataRequirement.mustSupport",
            "path": "DataRequirement.mustSupport",
            "short": "Indicates specific structure elements that are referenced by the knowledge module",
            "definition": "Indicates that specific elements of the type are referenced by the knowledge module and must be supported by the consumer in order to obtain an effective evaluation. This does not mean that a value is required for this element, only that the consuming system must understand the element and be able to provide values for it if they are available. \n\nThe value of mustSupport SHALL be a FHIRPath resolveable on the type of the DataRequirement. The path SHALL consist only of identifiers, constant indexers, and .resolve() (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.codeFilter",
            "path": "DataRequirement.codeFilter",
            "short": "What codes are expected",
            "definition": "Code filters specify additional constraints on the data, specifying the value set of interest for a particular element of the data. Each code filter defines an additional constraint on the data, i.e. code filters are AND'ed, not OR'ed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Element"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.codeFilter.path",
            "path": "DataRequirement.codeFilter.path",
            "short": "A code-valued attribute to filter on",
            "definition": "The code-valued attribute of the filter. The specified path SHALL be a FHIRPath resolveable on the specified type of the DataRequirement, and SHALL consist only of identifiers, constant indexers, and .resolve(). The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details). Note that the index must be an integer constant. The path must resolve to an element of type code, Coding, or CodeableConcept.",
            "comment": "The path attribute contains a [Simple FHIRPath Subset](fhirpath.html#simple) that allows path traversal, but not calculation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.codeFilter.searchParam",
            "path": "DataRequirement.codeFilter.searchParam",
            "short": "A coded (token) parameter to search on",
            "definition": "A token parameter that refers to a search parameter defined on the specified type of the DataRequirement, and which searches on elements of type code, Coding, or CodeableConcept.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.codeFilter.valueSet",
            "path": "DataRequirement.codeFilter.valueSet",
            "short": "Valueset for the filter",
            "definition": "The valueset for the code filter. The valueSet and code elements are additive. If valueSet is specified, the filter will return only those data items for which the value of the code-valued element specified in the path is a member of the specified valueset.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ValueSet"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.codeFilter.code",
            "path": "DataRequirement.codeFilter.code",
            "short": "What code is expected",
            "definition": "The codes for the code filter. If values are given, the filter will return only those data items for which the code-valued attribute specified by the path has a value that is one of the specified codes. If codes are specified in addition to a value set, the filter returns items matching a code in the value set or one of the specified codes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.dateFilter",
            "path": "DataRequirement.dateFilter",
            "short": "What dates/date ranges are expected",
            "definition": "Date filters specify additional constraints on the data in terms of the applicable date range for specific elements. Each date filter specifies an additional constraint on the data, i.e. date filters are AND'ed, not OR'ed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Element"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.dateFilter.path",
            "path": "DataRequirement.dateFilter.path",
            "short": "A date-valued attribute to filter on",
            "definition": "The date-valued attribute of the filter. The specified path SHALL be a FHIRPath resolveable on the specified type of the DataRequirement, and SHALL consist only of identifiers, constant indexers, and .resolve(). The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details). Note that the index must be an integer constant. The path must resolve to an element of type date, dateTime, Period, Schedule, or Timing.",
            "comment": "The path attribute contains a [Simple FHIR Subset](fhirpath.html#simple) that allows path traversal, but not calculation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.dateFilter.searchParam",
            "path": "DataRequirement.dateFilter.searchParam",
            "short": "A date valued parameter to search on",
            "definition": "A date parameter that refers to a search parameter defined on the specified type of the DataRequirement, and which searches on elements of type date, dateTime, Period, Schedule, or Timing.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.dateFilter.value[x]",
            "path": "DataRequirement.dateFilter.value[x]",
            "short": "The value of the filter, as a Period, DateTime, or Duration value",
            "definition": "The value of the filter. If period is specified, the filter will return only those data items that fall within the bounds determined by the Period, inclusive of the period boundaries. If dateTime is specified, the filter will return only those data items that are equal to the specified dateTime. If a Duration is specified, the filter will return only those data items that fall within Duration before now.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              },
              {
                "code": "Duration"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.limit",
            "path": "DataRequirement.limit",
            "short": "Number of results",
            "definition": "Specifies a maximum number of results that are required (uses the _count search parameter).",
            "comment": "This element can be used in combination with the sort element to specify quota requirements such as \"the most recent 5\" or \"the highest 5\".",
            "requirements": "Enables the requirement \"most recent 5 results\" to be expressed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "positiveInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.sort",
            "path": "DataRequirement.sort",
            "short": "Order of the results",
            "definition": "Specifies the order of the results to be returned.",
            "comment": "This element can be used in combination with the sort element to specify quota requirements such as \"the most recent 5\" or \"the highest 5\". When multiple sorts are specified, they are applied in the order they appear in the resource.",
            "requirements": "Enables the requirement \"most recent 5 results\" to be expressed.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Element"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.sort.path",
            "path": "DataRequirement.sort.path",
            "short": "The name of the attribute to perform the sort",
            "definition": "The attribute of the sort. The specified path must be resolvable from the type of the required data. The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements. Note that the index must be an integer constant.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "DataRequirement.sort.direction",
            "path": "DataRequirement.sort.direction",
            "short": "ascending | descending",
            "definition": "The direction of the sort, ascending or descending.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SortDirection"
                }
              ],
              "strength": "required",
              "description": "The possible sort directions, ascending or descending.",
              "valueSet": "http://hl7.org/fhir/ValueSet/sort-direction|4.0.0"
            }
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir complex 'DataRequirement'
    /// </summary>
    // 0. DataRequirement
    public partial class Type_DataRequirement : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 5. DataRequirement.codeFilter
        public partial class Type_CodeFilter : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 6. DataRequirement.codeFilter.path
            public ElementDefinitionInfo Element_Path;
            // 7. DataRequirement.codeFilter.searchParam
            public ElementDefinitionInfo Element_SearchParam;
            // 8. DataRequirement.codeFilter.valueSet
            public ElementDefinitionInfo Element_ValueSet;
            // 9. DataRequirement.codeFilter.code
            public ElementDefinitionInfo Element_Code;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DataRequirement.codeFilter",
                    ElementId = "DataRequirement.codeFilter"
                });
                Element_Path.Write(sDef);
                Element_SearchParam.Write(sDef);
                Element_ValueSet.Write(sDef);
                Element_Code.Write(sDef);
            }
            
            public Type_CodeFilter()
            {
                {
                    // 6. DataRequirement.codeFilter.path
                    this.Element_Path = new ElementDefinitionInfo
                    {
                        Name = "Element_Path",
                        Path= "DataRequirement.codeFilter.path",
                        Id = "DataRequirement.codeFilter.path",
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
                    // 7. DataRequirement.codeFilter.searchParam
                    this.Element_SearchParam = new ElementDefinitionInfo
                    {
                        Name = "Element_SearchParam",
                        Path= "DataRequirement.codeFilter.searchParam",
                        Id = "DataRequirement.codeFilter.searchParam",
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
                    // 8. DataRequirement.codeFilter.valueSet
                    this.Element_ValueSet = new ElementDefinitionInfo
                    {
                        Name = "Element_ValueSet",
                        Path= "DataRequirement.codeFilter.valueSet",
                        Id = "DataRequirement.codeFilter.valueSet",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
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
                    // 9. DataRequirement.codeFilter.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "DataRequirement.codeFilter.code",
                        Id = "DataRequirement.codeFilter.code",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
            }
        }
        // 10. DataRequirement.dateFilter
        public partial class Type_DateFilter : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 11. DataRequirement.dateFilter.path
            public ElementDefinitionInfo Element_Path;
            // 12. DataRequirement.dateFilter.searchParam
            public ElementDefinitionInfo Element_SearchParam;
            // 13. DataRequirement.dateFilter.value[x]
            public ElementDefinitionInfo Element_Value;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DataRequirement.dateFilter",
                    ElementId = "DataRequirement.dateFilter"
                });
                Element_Path.Write(sDef);
                Element_SearchParam.Write(sDef);
                Element_Value.Write(sDef);
            }
            
            public Type_DateFilter()
            {
                {
                    // 11. DataRequirement.dateFilter.path
                    this.Element_Path = new ElementDefinitionInfo
                    {
                        Name = "Element_Path",
                        Path= "DataRequirement.dateFilter.path",
                        Id = "DataRequirement.dateFilter.path",
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
                    // 12. DataRequirement.dateFilter.searchParam
                    this.Element_SearchParam = new ElementDefinitionInfo
                    {
                        Name = "Element_SearchParam",
                        Path= "DataRequirement.dateFilter.searchParam",
                        Id = "DataRequirement.dateFilter.searchParam",
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
                    // 13. DataRequirement.dateFilter.value[x]
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "DataRequirement.dateFilter.value[x]",
                        Id = "DataRequirement.dateFilter.value[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            }
                        }
                    };
                }
            }
        }
        // 15. DataRequirement.sort
        public partial class Type_Sort : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 16. DataRequirement.sort.path
            public ElementDefinitionInfo Element_Path;
            // 17. DataRequirement.sort.direction
            public ElementDefinitionInfo Element_Direction;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "DataRequirement.sort",
                    ElementId = "DataRequirement.sort"
                });
                Element_Path.Write(sDef);
                Element_Direction.Write(sDef);
            }
            
            public Type_Sort()
            {
                {
                    // 16. DataRequirement.sort.path
                    this.Element_Path = new ElementDefinitionInfo
                    {
                        Name = "Element_Path",
                        Path= "DataRequirement.sort.path",
                        Id = "DataRequirement.sort.path",
                        Min = 1,
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
                    // 17. DataRequirement.sort.direction
                    this.Element_Direction = new ElementDefinitionInfo
                    {
                        Name = "Element_Direction",
                        Path= "DataRequirement.sort.direction",
                        Id = "DataRequirement.sort.direction",
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
            }
        }
        // 1. DataRequirement.type
        public ElementDefinitionInfo Element_Type;
        // 2. DataRequirement.profile
        public ElementDefinitionInfo Element_Profile;
        // 3. DataRequirement.subject[x]
        public ElementDefinitionInfo Element_Subject;
        // 4. DataRequirement.mustSupport
        public ElementDefinitionInfo Element_MustSupport;
        // 5. DataRequirement.codeFilter
        public ElementDefinitionInfo Element_CodeFilter;
        // 10. DataRequirement.dateFilter
        public ElementDefinitionInfo Element_DateFilter;
        // 14. DataRequirement.limit
        public ElementDefinitionInfo Element_Limit;
        // 15. DataRequirement.sort
        public ElementDefinitionInfo Element_Sort;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "DataRequirement",
                ElementId = "DataRequirement"
            });
            Element_Type.Write(sDef);
            Element_Profile.Write(sDef);
            Element_Subject.Write(sDef);
            Element_MustSupport.Write(sDef);
            Element_CodeFilter.Write(sDef);
            Element_DateFilter.Write(sDef);
            Element_Limit.Write(sDef);
            Element_Sort.Write(sDef);
        }
        
        public Type_DataRequirement()
        {
            {
                // 1. DataRequirement.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "DataRequirement.type",
                    Id = "DataRequirement.type",
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
                // 2. DataRequirement.profile
                this.Element_Profile = new ElementDefinitionInfo
                {
                    Name = "Element_Profile",
                    Path= "DataRequirement.profile",
                    Id = "DataRequirement.profile",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
                            }
                        }
                    }
                };
            }
            {
                // 3. DataRequirement.subject[x]
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "DataRequirement.subject[x]",
                    Id = "DataRequirement.subject[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Group"
                            }
                        }
                    }
                };
            }
            {
                // 4. DataRequirement.mustSupport
                this.Element_MustSupport = new ElementDefinitionInfo
                {
                    Name = "Element_MustSupport",
                    Path= "DataRequirement.mustSupport",
                    Id = "DataRequirement.mustSupport",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                        {
                        }
                    }
                };
            }
            {
                // 5. DataRequirement.codeFilter
                this.Element_CodeFilter = new ElementDefinitionInfo
                {
                    Name = "Element_CodeFilter",
                    Path= "DataRequirement.codeFilter",
                    Id = "DataRequirement.codeFilter",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_CodeFilter
                        {
                        }
                    }
                };
            }
            {
                // 10. DataRequirement.dateFilter
                this.Element_DateFilter = new ElementDefinitionInfo
                {
                    Name = "Element_DateFilter",
                    Path= "DataRequirement.dateFilter",
                    Id = "DataRequirement.dateFilter",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_DateFilter
                        {
                        }
                    }
                };
            }
            {
                // 14. DataRequirement.limit
                this.Element_Limit = new ElementDefinitionInfo
                {
                    Name = "Element_Limit",
                    Path= "DataRequirement.limit",
                    Id = "DataRequirement.limit",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                        {
                        }
                    }
                };
            }
            {
                // 15. DataRequirement.sort
                this.Element_Sort = new ElementDefinitionInfo
                {
                    Name = "Element_Sort",
                    Path= "DataRequirement.sort",
                    Id = "DataRequirement.sort",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Sort
                        {
                        }
                    }
                };
            }
        }
    }
}
