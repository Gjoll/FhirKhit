using System;                                                                                                                               // MakerGen.cs:482
using System.Diagnostics;                                                                                                                   // MakerGen.cs:483
using System.IO;                                                                                                                            // MakerGen.cs:484
using System.Linq;                                                                                                                          // MakerGen.cs:485
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:486
                                                                                                                                            // MakerGen.cs:487
namespace FhirKhit.Maker.Common.Complex                                                                                                     // MakerGen.cs:488
{                                                                                                                                           // MakerGen.cs:489
    #region Json                                                                                                                            // MakerGen.cs:490
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
    #endregion                                                                                                                              // MakerGen.cs:494
    /// <summary>
    /// Fhir complex 'DataRequirement'
    /// </summary>
    // 0. DataRequirement
    public class Type_DataRequirement : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 5. DataRequirement.codeFilter
        public class Type_CodeFilter : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 6. DataRequirement.codeFilter.path
            public ElementDefinitionInfo Element_Path;                                                                                      // MakerGen.cs:212
            // 7. DataRequirement.codeFilter.searchParam
            public ElementDefinitionInfo Element_SearchParam;                                                                               // MakerGen.cs:212
            // 8. DataRequirement.codeFilter.valueSet
            public ElementDefinitionInfo Element_ValueSet;                                                                                  // MakerGen.cs:212
            // 9. DataRequirement.codeFilter.code
            public ElementDefinitionInfo Element_Code;                                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "DataRequirement.codeFilter",                                                                                    // MakerGen.cs:388
                    ElementId = "DataRequirement.codeFilter"                                                                                // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Path.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_SearchParam.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_ValueSet.Write(sDef);                                                                                               // MakerGen.cs:216
                Element_Code.Write(sDef);                                                                                                   // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_CodeFilter()                                                                                                        // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 6. DataRequirement.codeFilter.path
                    this.Element_Path = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Path",                                                                                              // MakerGen.cs:231
                        Path= "DataRequirement.codeFilter.path",                                                                            // MakerGen.cs:232
                        Id = "DataRequirement.codeFilter.path",                                                                             // MakerGen.cs:233
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
                    // 7. DataRequirement.codeFilter.searchParam
                    this.Element_SearchParam = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_SearchParam",                                                                                       // MakerGen.cs:231
                        Path= "DataRequirement.codeFilter.searchParam",                                                                     // MakerGen.cs:232
                        Id = "DataRequirement.codeFilter.searchParam",                                                                      // MakerGen.cs:233
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
                    // 8. DataRequirement.codeFilter.valueSet
                    this.Element_ValueSet = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_ValueSet",                                                                                          // MakerGen.cs:231
                        Path= "DataRequirement.codeFilter.valueSet",                                                                        // MakerGen.cs:232
                        Id = "DataRequirement.codeFilter.valueSet",                                                                         // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                         // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                                TargetProfile = new String[]                                                                                // MakerGen.cs:299
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                      // MakerGen.cs:299
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 9. DataRequirement.codeFilter.code
                    this.Element_Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Code",                                                                                              // MakerGen.cs:231
                        Path= "DataRequirement.codeFilter.code",                                                                            // MakerGen.cs:232
                        Id = "DataRequirement.codeFilter.code",                                                                             // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Coding                                                                   // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 10. DataRequirement.dateFilter
        public class Type_DateFilter : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 11. DataRequirement.dateFilter.path
            public ElementDefinitionInfo Element_Path;                                                                                      // MakerGen.cs:212
            // 12. DataRequirement.dateFilter.searchParam
            public ElementDefinitionInfo Element_SearchParam;                                                                               // MakerGen.cs:212
            // 13. DataRequirement.dateFilter.value[x]
            public ElementDefinitionInfo Element_Value;                                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "DataRequirement.dateFilter",                                                                                    // MakerGen.cs:388
                    ElementId = "DataRequirement.dateFilter"                                                                                // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Path.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_SearchParam.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_Value.Write(sDef);                                                                                                  // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_DateFilter()                                                                                                        // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 11. DataRequirement.dateFilter.path
                    this.Element_Path = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Path",                                                                                              // MakerGen.cs:231
                        Path= "DataRequirement.dateFilter.path",                                                                            // MakerGen.cs:232
                        Id = "DataRequirement.dateFilter.path",                                                                             // MakerGen.cs:233
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
                    // 12. DataRequirement.dateFilter.searchParam
                    this.Element_SearchParam = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_SearchParam",                                                                                       // MakerGen.cs:231
                        Path= "DataRequirement.dateFilter.searchParam",                                                                     // MakerGen.cs:232
                        Id = "DataRequirement.dateFilter.searchParam",                                                                      // MakerGen.cs:233
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
                    // 13. DataRequirement.dateFilter.value[x]
                    this.Element_Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Value",                                                                                             // MakerGen.cs:231
                        Path= "DataRequirement.dateFilter.value[x]",                                                                        // MakerGen.cs:232
                        Id = "DataRequirement.dateFilter.value[x]",                                                                         // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            },                                                                                                              // MakerGen.cs:300
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            },                                                                                                              // MakerGen.cs:353
                            new FhirKhit.Maker.Common.Complex.Type_Duration                                                                 // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 15. DataRequirement.sort
        public class Type_Sort : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 16. DataRequirement.sort.path
            public ElementDefinitionInfo Element_Path;                                                                                      // MakerGen.cs:212
            // 17. DataRequirement.sort.direction
            public ElementDefinitionInfo Element_Direction;                                                                                 // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "DataRequirement.sort",                                                                                          // MakerGen.cs:388
                    ElementId = "DataRequirement.sort"                                                                                      // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Path.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_Direction.Write(sDef);                                                                                              // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Sort()                                                                                                              // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 16. DataRequirement.sort.path
                    this.Element_Path = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Path",                                                                                              // MakerGen.cs:231
                        Path= "DataRequirement.sort.path",                                                                                  // MakerGen.cs:232
                        Id = "DataRequirement.sort.path",                                                                                   // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
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
                    // 17. DataRequirement.sort.direction
                    this.Element_Direction = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Direction",                                                                                         // MakerGen.cs:231
                        Path= "DataRequirement.sort.direction",                                                                             // MakerGen.cs:232
                        Id = "DataRequirement.sort.direction",                                                                              // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. DataRequirement.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:212
        // 2. DataRequirement.profile
        public ElementDefinitionInfo Element_Profile;                                                                                       // MakerGen.cs:212
        // 3. DataRequirement.subject[x]
        public ElementDefinitionInfo Element_Subject;                                                                                       // MakerGen.cs:212
        // 4. DataRequirement.mustSupport
        public ElementDefinitionInfo Element_MustSupport;                                                                                   // MakerGen.cs:212
        // 5. DataRequirement.codeFilter
        public ElementDefinitionInfo Element_CodeFilter;                                                                                    // MakerGen.cs:212
        // 10. DataRequirement.dateFilter
        public ElementDefinitionInfo Element_DateFilter;                                                                                    // MakerGen.cs:212
        // 14. DataRequirement.limit
        public ElementDefinitionInfo Element_Limit;                                                                                         // MakerGen.cs:212
        // 15. DataRequirement.sort
        public ElementDefinitionInfo Element_Sort;                                                                                          // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "DataRequirement",                                                                                                   // MakerGen.cs:388
                ElementId = "DataRequirement"                                                                                               // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Profile.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Subject.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_MustSupport.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_CodeFilter.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_DateFilter.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Limit.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Sort.Write(sDef);                                                                                                       // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Type_DataRequirement()                                                                                                       // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. DataRequirement.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:231
                    Path= "DataRequirement.type",                                                                                           // MakerGen.cs:232
                    Id = "DataRequirement.type",                                                                                            // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. DataRequirement.profile
                this.Element_Profile = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Profile",                                                                                               // MakerGen.cs:231
                    Path= "DataRequirement.profile",                                                                                        // MakerGen.cs:232
                    Id = "DataRequirement.profile",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:299
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                               // MakerGen.cs:299
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. DataRequirement.subject[x]
                this.Element_Subject = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Subject",                                                                                               // MakerGen.cs:231
                    Path= "DataRequirement.subject[x]",                                                                                     // MakerGen.cs:232
                    Id = "DataRequirement.subject[x]",                                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        },                                                                                                                  // MakerGen.cs:315
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/Group"                                                             // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. DataRequirement.mustSupport
                this.Element_MustSupport = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_MustSupport",                                                                                           // MakerGen.cs:231
                    Path= "DataRequirement.mustSupport",                                                                                    // MakerGen.cs:232
                    Id = "DataRequirement.mustSupport",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. DataRequirement.codeFilter
                this.Element_CodeFilter = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_CodeFilter",                                                                                            // MakerGen.cs:231
                    Path= "DataRequirement.codeFilter",                                                                                     // MakerGen.cs:232
                    Id = "DataRequirement.codeFilter",                                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_CodeFilter                                                                                                 // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. DataRequirement.dateFilter
                this.Element_DateFilter = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_DateFilter",                                                                                            // MakerGen.cs:231
                    Path= "DataRequirement.dateFilter",                                                                                     // MakerGen.cs:232
                    Id = "DataRequirement.dateFilter",                                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_DateFilter                                                                                                 // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 14. DataRequirement.limit
                this.Element_Limit = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Limit",                                                                                                 // MakerGen.cs:231
                    Path= "DataRequirement.limit",                                                                                          // MakerGen.cs:232
                    Id = "DataRequirement.limit",                                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt                                                           // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 15. DataRequirement.sort
                this.Element_Sort = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Sort",                                                                                                  // MakerGen.cs:231
                    Path= "DataRequirement.sort",                                                                                           // MakerGen.cs:232
                    Id = "DataRequirement.sort",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Sort                                                                                                       // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:499
