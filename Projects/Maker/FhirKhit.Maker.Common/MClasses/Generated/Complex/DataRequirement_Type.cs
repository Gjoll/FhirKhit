using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;
                                                                                                                                            // MakerGen.cs:267
namespace FhirKhit.Maker.Common                                                                                                             // MakerGen.cs:268
{                                                                                                                                           // MakerGen.cs:269
    /// <summary>
    /// Fhir primitive 'DataRequirement'
    /// {
    ///   "resourceType": "StructureDefinition",
    ///   "id": "DataRequirement",
    ///   "url": "http://hl7.org/fhir/StructureDefinition/DataRequirement",
    ///   "version": "4.0.0",
    ///   "name": "DataRequirement",
    ///   "status": "draft",
    ///   "publisher": "HL7 FHIR Standard",
    ///   "description": "Base StructureDefinition for DataRequirement Type: Describes a required data item for evaluation in terms of the type of data, and optional code or date-based filters of the data.",
    ///   "fhirVersion": "4.0.0",
    ///   "kind": "complex-type",
    ///   "abstract": false,
    ///   "type": "DataRequirement",
    ///   "baseDefinition": "http://hl7.org/fhir/StructureDefinition/Element",
    ///   "derivation": "specialization",
    ///   "differential": {
    ///     "element": [
    ///       {
    ///         "id": "DataRequirement",
    ///         "path": "DataRequirement",
    ///         "short": "Describes a required data item",
    ///         "definition": "Describes a required data item for evaluation in terms of the type of data, and optional code or date-based filters of the data.",
    ///         "min": 0,
    ///         "max": "*"
    ///       },
    ///       {
    ///         "id": "DataRequirement.type",
    ///         "path": "DataRequirement.type",
    ///         "short": "The type of the required data",
    ///         "definition": "The type of the required data, specified as the type name of a resource. For profiles, this value is set to the type of the base resource of the profile.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "FHIRAllTypes"
    ///             },
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
    ///               "valueBoolean": true
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "A list of all the concrete types defined in this version of the FHIR specification - Abstract Types, Data Types and Resource Types.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/all-types|4.0.0"
    ///         }
    ///       },
    ///       {
    ///         "id": "DataRequirement.profile",
    ///         "path": "DataRequirement.profile",
    ///         "short": "The profile of the required data",
    ///         "definition": "The profile of the required data, specified as the uri of the profile definition.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "canonical",
    ///             "targetProfile": [
    ///               "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.subject[x]",
    ///         "path": "DataRequirement.subject[x]",
    ///         "short": "E.g. Patient, Practitioner, RelatedPerson, Organization, Location, Device",
    ///         "definition": "The intended subjects of the data requirement. If this element is not provided, a Patient subject is assumed.",
    ///         "comment": "The subject of a data requirement is critical, as the data being specified is determined with respect to a particular subject. This corresponds roughly to the notion of a Compartment in that it limits what data is available based on its relationship to the subject. In CQL, this corresponds to the context declaration.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "CodeableConcept"
    ///           },
    ///           {
    ///             "code": "Reference",
    ///             "targetProfile": [
    ///               "http://hl7.org/fhir/StructureDefinition/Group"
    ///             ]
    ///           }
    ///         ],
    ///         "meaningWhenMissing": "Patient",
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "SubjectType"
    ///             }
    ///           ],
    ///           "strength": "extensible",
    ///           "description": "The possible types of subjects for a data requirement (E.g., Patient, Practitioner, Organization, Location, etc.).",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/subject-type"
    ///         }
    ///       },
    ///       {
    ///         "id": "DataRequirement.mustSupport",
    ///         "path": "DataRequirement.mustSupport",
    ///         "short": "Indicates specific structure elements that are referenced by the knowledge module",
    ///         "definition": "Indicates that specific elements of the type are referenced by the knowledge module and must be supported by the consumer in order to obtain an effective evaluation. This does not mean that a value is required for this element, only that the consuming system must understand the element and be able to provide values for it if they are available. \n\nThe value of mustSupport SHALL be a FHIRPath resolveable on the type of the DataRequirement. The path SHALL consist only of identifiers, constant indexers, and .resolve() (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details).",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.codeFilter",
    ///         "path": "DataRequirement.codeFilter",
    ///         "short": "What codes are expected",
    ///         "definition": "Code filters specify additional constraints on the data, specifying the value set of interest for a particular element of the data. Each code filter defines an additional constraint on the data, i.e. code filters are AND'ed, not OR'ed.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "Element"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.codeFilter.path",
    ///         "path": "DataRequirement.codeFilter.path",
    ///         "short": "A code-valued attribute to filter on",
    ///         "definition": "The code-valued attribute of the filter. The specified path SHALL be a FHIRPath resolveable on the specified type of the DataRequirement, and SHALL consist only of identifiers, constant indexers, and .resolve(). The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details). Note that the index must be an integer constant. The path must resolve to an element of type code, Coding, or CodeableConcept.",
    ///         "comment": "The path attribute contains a [Simple FHIRPath Subset](fhirpath.html#simple) that allows path traversal, but not calculation.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.codeFilter.searchParam",
    ///         "path": "DataRequirement.codeFilter.searchParam",
    ///         "short": "A coded (token) parameter to search on",
    ///         "definition": "A token parameter that refers to a search parameter defined on the specified type of the DataRequirement, and which searches on elements of type code, Coding, or CodeableConcept.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.codeFilter.valueSet",
    ///         "path": "DataRequirement.codeFilter.valueSet",
    ///         "short": "Valueset for the filter",
    ///         "definition": "The valueset for the code filter. The valueSet and code elements are additive. If valueSet is specified, the filter will return only those data items for which the value of the code-valued element specified in the path is a member of the specified valueset.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "canonical",
    ///             "targetProfile": [
    ///               "http://hl7.org/fhir/StructureDefinition/ValueSet"
    ///             ]
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.codeFilter.code",
    ///         "path": "DataRequirement.codeFilter.code",
    ///         "short": "What code is expected",
    ///         "definition": "The codes for the code filter. If values are given, the filter will return only those data items for which the code-valued attribute specified by the path has a value that is one of the specified codes. If codes are specified in addition to a value set, the filter returns items matching a code in the value set or one of the specified codes.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "Coding"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.dateFilter",
    ///         "path": "DataRequirement.dateFilter",
    ///         "short": "What dates/date ranges are expected",
    ///         "definition": "Date filters specify additional constraints on the data in terms of the applicable date range for specific elements. Each date filter specifies an additional constraint on the data, i.e. date filters are AND'ed, not OR'ed.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "Element"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.dateFilter.path",
    ///         "path": "DataRequirement.dateFilter.path",
    ///         "short": "A date-valued attribute to filter on",
    ///         "definition": "The date-valued attribute of the filter. The specified path SHALL be a FHIRPath resolveable on the specified type of the DataRequirement, and SHALL consist only of identifiers, constant indexers, and .resolve(). The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details). Note that the index must be an integer constant. The path must resolve to an element of type date, dateTime, Period, Schedule, or Timing.",
    ///         "comment": "The path attribute contains a [Simple FHIR Subset](fhirpath.html#simple) that allows path traversal, but not calculation.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.dateFilter.searchParam",
    ///         "path": "DataRequirement.dateFilter.searchParam",
    ///         "short": "A date valued parameter to search on",
    ///         "definition": "A date parameter that refers to a search parameter defined on the specified type of the DataRequirement, and which searches on elements of type date, dateTime, Period, Schedule, or Timing.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.dateFilter.value[x]",
    ///         "path": "DataRequirement.dateFilter.value[x]",
    ///         "short": "The value of the filter, as a Period, DateTime, or Duration value",
    ///         "definition": "The value of the filter. If period is specified, the filter will return only those data items that fall within the bounds determined by the Period, inclusive of the period boundaries. If dateTime is specified, the filter will return only those data items that are equal to the specified dateTime. If a Duration is specified, the filter will return only those data items that fall within Duration before now.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "dateTime"
    ///           },
    ///           {
    ///             "code": "Period"
    ///           },
    ///           {
    ///             "code": "Duration"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.limit",
    ///         "path": "DataRequirement.limit",
    ///         "short": "Number of results",
    ///         "definition": "Specifies a maximum number of results that are required (uses the _count search parameter).",
    ///         "comment": "This element can be used in combination with the sort element to specify quota requirements such as \"the most recent 5\" or \"the highest 5\".",
    ///         "requirements": "Enables the requirement \"most recent 5 results\" to be expressed.",
    ///         "min": 0,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "positiveInt"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.sort",
    ///         "path": "DataRequirement.sort",
    ///         "short": "Order of the results",
    ///         "definition": "Specifies the order of the results to be returned.",
    ///         "comment": "This element can be used in combination with the sort element to specify quota requirements such as \"the most recent 5\" or \"the highest 5\". When multiple sorts are specified, they are applied in the order they appear in the resource.",
    ///         "requirements": "Enables the requirement \"most recent 5 results\" to be expressed.",
    ///         "min": 0,
    ///         "max": "*",
    ///         "type": [
    ///           {
    ///             "code": "Element"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.sort.path",
    ///         "path": "DataRequirement.sort.path",
    ///         "short": "The name of the attribute to perform the sort",
    ///         "definition": "The attribute of the sort. The specified path must be resolvable from the type of the required data. The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements. Note that the index must be an integer constant.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "string"
    ///           }
    ///         ],
    ///         "isSummary": true
    ///       },
    ///       {
    ///         "id": "DataRequirement.sort.direction",
    ///         "path": "DataRequirement.sort.direction",
    ///         "short": "ascending | descending",
    ///         "definition": "The direction of the sort, ascending or descending.",
    ///         "min": 1,
    ///         "max": "1",
    ///         "type": [
    ///           {
    ///             "code": "code"
    ///           }
    ///         ],
    ///         "isSummary": true,
    ///         "binding": {
    ///           "extension": [
    ///             {
    ///               "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
    ///               "valueString": "SortDirection"
    ///             }
    ///           ],
    ///           "strength": "required",
    ///           "description": "The possible sort directions, ascending or descending.",
    ///           "valueSet": "http://hl7.org/fhir/ValueSet/sort-direction|4.0.0"
    ///         }
    ///       }
    ///     ]
    ///   }
    /// }
    /// </summary>
    // 0. DataRequirement
    public class DataRequirement_Type : Complex_Type                                                                                        // MakerGen.cs:220
    {                                                                                                                                       // MakerGen.cs:221
        // 6. DataRequirement.codeFilter.path
        public class Path_Type : Complex_Type                                                                                               // MakerGen.cs:220
        {                                                                                                                                   // MakerGen.cs:221
            public Path_Type()                                                                                                              // MakerGen.cs:229
            {                                                                                                                               // MakerGen.cs:230
            }                                                                                                                               // MakerGen.cs:244
        }                                                                                                                                   // MakerGen.cs:225
        // 7. DataRequirement.codeFilter.searchParam
        public class SearchParam_Type : Complex_Type                                                                                        // MakerGen.cs:220
        {                                                                                                                                   // MakerGen.cs:221
            public SearchParam_Type()                                                                                                       // MakerGen.cs:229
            {                                                                                                                               // MakerGen.cs:230
            }                                                                                                                               // MakerGen.cs:244
        }                                                                                                                                   // MakerGen.cs:225
        // 8. DataRequirement.codeFilter.valueSet
        public class ValueSet_Type : Complex_Type                                                                                           // MakerGen.cs:220
        {                                                                                                                                   // MakerGen.cs:221
            public ValueSet_Type()                                                                                                          // MakerGen.cs:229
            {                                                                                                                               // MakerGen.cs:230
            }                                                                                                                               // MakerGen.cs:244
        }                                                                                                                                   // MakerGen.cs:225
        // 9. DataRequirement.codeFilter.code
        public class Code_Type : Complex_Type                                                                                               // MakerGen.cs:220
        {                                                                                                                                   // MakerGen.cs:221
            public Code_Type()                                                                                                              // MakerGen.cs:229
            {                                                                                                                               // MakerGen.cs:230
            }                                                                                                                               // MakerGen.cs:244
        }                                                                                                                                   // MakerGen.cs:225
        // 11. DataRequirement.dateFilter.path
        public class Path_Type : Complex_Type                                                                                               // MakerGen.cs:220
        {                                                                                                                                   // MakerGen.cs:221
            public Path_Type()                                                                                                              // MakerGen.cs:229
            {                                                                                                                               // MakerGen.cs:230
            }                                                                                                                               // MakerGen.cs:244
        }                                                                                                                                   // MakerGen.cs:225
        // 12. DataRequirement.dateFilter.searchParam
        public class SearchParam_Type : Complex_Type                                                                                        // MakerGen.cs:220
        {                                                                                                                                   // MakerGen.cs:221
            public SearchParam_Type()                                                                                                       // MakerGen.cs:229
            {                                                                                                                               // MakerGen.cs:230
            }                                                                                                                               // MakerGen.cs:244
        }                                                                                                                                   // MakerGen.cs:225
        // 13. DataRequirement.dateFilter.value[x]
        public class ValueX_Type : Complex_Type                                                                                             // MakerGen.cs:220
        {                                                                                                                                   // MakerGen.cs:221
            public ValueX_Type()                                                                                                            // MakerGen.cs:229
            {                                                                                                                               // MakerGen.cs:230
            }                                                                                                                               // MakerGen.cs:244
        }                                                                                                                                   // MakerGen.cs:225
        // 16. DataRequirement.sort.path
        public class Path_Type : Complex_Type                                                                                               // MakerGen.cs:220
        {                                                                                                                                   // MakerGen.cs:221
            public Path_Type()                                                                                                              // MakerGen.cs:229
            {                                                                                                                               // MakerGen.cs:230
            }                                                                                                                               // MakerGen.cs:244
        }                                                                                                                                   // MakerGen.cs:225
        // 17. DataRequirement.sort.direction
        public class Direction_Type : Complex_Type                                                                                          // MakerGen.cs:220
        {                                                                                                                                   // MakerGen.cs:221
            public Direction_Type()                                                                                                         // MakerGen.cs:229
            {                                                                                                                               // MakerGen.cs:230
            }                                                                                                                               // MakerGen.cs:244
        }                                                                                                                                   // MakerGen.cs:225
        // 1. DataRequirement.type
        public ElementInstance Type;                                                                                                        // MakerGen.cs:203
        // 2. DataRequirement.profile
        public ElementInstance Profile;                                                                                                     // MakerGen.cs:203
        // 3. DataRequirement.subject[x]
        public ElementInstance SubjectX;                                                                                                    // MakerGen.cs:203
        // 4. DataRequirement.mustSupport
        public ElementInstance MustSupport;                                                                                                 // MakerGen.cs:203
        // 5. DataRequirement.codeFilter
        public ElementInstance CodeFilter;                                                                                                  // MakerGen.cs:203
        // 10. DataRequirement.dateFilter
        public ElementInstance DateFilter;                                                                                                  // MakerGen.cs:203
        // 14. DataRequirement.limit
        public ElementInstance Limit;                                                                                                       // MakerGen.cs:203
        // 15. DataRequirement.sort
        public ElementInstance Sort;                                                                                                        // MakerGen.cs:203
        public DataRequirement_Type()                                                                                                       // MakerGen.cs:229
        {                                                                                                                                   // MakerGen.cs:230
        }                                                                                                                                   // MakerGen.cs:244
    }                                                                                                                                       // MakerGen.cs:225
}                                                                                                                                           // MakerGen.cs:275