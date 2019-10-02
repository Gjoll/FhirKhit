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
      "id": "SearchParameter",
      "url": "http://hl7.org/fhir/StructureDefinition/SearchParameter",
      "version": "4.0.0",
      "name": "SearchParameter",
      "status": "draft",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A search parameter that defines a named search item that can be used to search/filter on a resource.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "SearchParameter",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "_baseDefinition": {
        "extension": [
          {
            "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-codegen-super",
            "valueString": "MetadataResource"
          }
        ]
      },
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "SearchParameter",
            "path": "SearchParameter",
            "short": "Search parameter for a resource",
            "definition": "A search parameter that defines a named search item that can be used to search/filter on a resource.",
            "comment": "In FHIR, search is not performed directly on a resource (by XML or JSON path), but on a named parameter that maps into the resource content.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "SearchParameter.url",
            "path": "SearchParameter.url",
            "short": "Canonical identifier for this search parameter, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this search parameter when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this search parameter is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the search parameter is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the search parameter to be referenced by a single globally unique identifier. To allow referencing and reusing search parameter definitions under other names on operational systems (in case of name clash).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SearchParameter.version",
            "path": "SearchParameter.version",
            "short": "Business version of the search parameter",
            "definition": "The identifier that is used to identify this version of the search parameter when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the search parameter author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different search parameter instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the search parameter with the format [url]|[version].",
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
            "id": "SearchParameter.name",
            "path": "SearchParameter.name",
            "short": "Name for this search parameter (computer friendly)",
            "definition": "A natural language name identifying the search parameter. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
            "comment": "The name is not expected to be globally unique. The name should be a simple alphanumeric type name to ensure that it is machine-processing friendly.",
            "requirements": "Support human navigation and code generation.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "inv-0"
            ],
            "isSummary": true
          },
          {
            "id": "SearchParameter.derivedFrom",
            "path": "SearchParameter.derivedFrom",
            "short": "Original definition for the search parameter",
            "definition": "Where this search parameter is originally defined. If a derivedFrom is provided, then the details in the search parameter must be consistent with the definition from which it is defined. i.e. the parameter should have the same meaning, and (usually) the functionality should be a proper subset of the underlying search parameter.",
            "comment": "The intent of this is that a server can designate that it provides support for a search parameter defined in the specification itself (e.g.  [`value-quantity`](http://hl7.org/fhir/SearchParameter/Observation-value-quantity), but detail how it is supported by the server.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/SearchParameter"
                ]
              }
            ]
          },
          {
            "id": "SearchParameter.status",
            "path": "SearchParameter.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this search parameter. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of search parameters that are appropriate for use versus not.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This is labeled as \"Is Modifier\" because applications should not use a retired {{title}} without due consideration",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "PublicationStatus"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The lifecycle status of an artifact.",
              "valueSet": "http://hl7.org/fhir/ValueSet/publication-status|4.0.0"
            }
          },
          {
            "id": "SearchParameter.experimental",
            "path": "SearchParameter.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this search parameter is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of search parameters that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level search parameter.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SearchParameter.date",
            "path": "SearchParameter.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the search parameter was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the search parameter changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the search parameter. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
            "alias": [
              "Revision Date"
            ],
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
            "id": "SearchParameter.publisher",
            "path": "SearchParameter.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the search parameter.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the search parameter is the organization or individual primarily responsible for the maintenance and upkeep of the search parameter. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the search parameter. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the search parameter.  May also allow for contact.",
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
            "id": "SearchParameter.contact",
            "path": "SearchParameter.contact",
            "short": "Contact details for the publisher",
            "definition": "Contact details to assist a user in finding and communicating with the publisher.",
            "comment": "May be a web site, an email address, a telephone number, etc.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactDetail"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SearchParameter.description",
            "path": "SearchParameter.description",
            "short": "Natural language description of the search parameter",
            "definition": "And how it used.",
            "comment": "This description can be used to capture details such as why the search parameter was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the search parameter as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the search parameter is presumed to be the predominant language in the place the search parameter was created).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SearchParameter.useContext",
            "path": "SearchParameter.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate search parameter instances.",
            "comment": "When multiple useContexts are specified, there is no expectation that all or any of the contexts apply.",
            "requirements": "Assist in searching for appropriate content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "UsageContext"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SearchParameter.jurisdiction",
            "path": "SearchParameter.jurisdiction",
            "short": "Intended jurisdiction for search parameter (if applicable)",
            "definition": "A legal or geographic region in which the search parameter is intended to be used.",
            "comment": "It may be possible for the search parameter to be used in jurisdictions other than those for which it was originally designed or intended.",
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
                  "valueString": "Jurisdiction"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "extensible",
              "description": "Countries and regions within which this artifact is targeted for use.",
              "valueSet": "http://hl7.org/fhir/ValueSet/jurisdiction"
            }
          },
          {
            "id": "SearchParameter.purpose",
            "path": "SearchParameter.purpose",
            "short": "Why this search parameter is defined",
            "definition": "Explanation of why this search parameter is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the search parameter. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this search parameter.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "SearchParameter.code",
            "path": "SearchParameter.code",
            "short": "Code used in URL",
            "definition": "The code used in the URL or the parameter name in a parameters resource for this search parameter.",
            "comment": "For maximum compatibility, use only lowercase ASCII characters.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true
          },
          {
            "id": "SearchParameter.base",
            "path": "SearchParameter.base",
            "short": "The resource type(s) this search parameter applies to",
            "definition": "The base resource type(s) that this search parameter can be used against.",
            "comment": "A search parameter must always apply to at least one resource type. When search parameters apply to more than one resource type, they can be used against any of the listed resource types, or in a cross-type search (see [Cross Resource Search](http.html#xres-search)).",
            "min": 1,
            "max": "*",
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
                  "valueString": "ResourceType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "One of the resource types defined as part of this version of FHIR.",
              "valueSet": "http://hl7.org/fhir/ValueSet/resource-types|4.0.0"
            }
          },
          {
            "id": "SearchParameter.type",
            "path": "SearchParameter.type",
            "short": "number | date | string | token | reference | composite | quantity | uri | special",
            "definition": "The type of value that a search parameter may contain, and how the content is interpreted.",
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
                  "valueString": "SearchParamType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "Data types allowed to be used for search parameters.",
              "valueSet": "http://hl7.org/fhir/ValueSet/search-param-type|4.0.0"
            }
          },
          {
            "id": "SearchParameter.expression",
            "path": "SearchParameter.expression",
            "short": "FHIRPath expression that extracts the values",
            "definition": "A FHIRPath expression that returns a set of elements for the search parameter.",
            "comment": "Note that the elements returned by the expression are sometimes complex elements where logic is required to determine quite how to handle them; e.g. CodeableConcepts may contain text and/or multiple codings, where the codings themselves contain a code and a system. For composite search parameters, the outcome of the expression must a collection of base elements from which the composites are derived.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "spd-1"
            ]
          },
          {
            "id": "SearchParameter.xpath",
            "path": "SearchParameter.xpath",
            "short": "XPath that extracts the values",
            "definition": "An XPath expression that returns a set of elements for the search parameter.",
            "comment": "Note that the elements returned by the XPath are sometimes complex elements where logic is required to determine quite how to handle them; e.g. CodeableConcepts may contain text and/or multiple codings, where the codings themselves contain a code and a system.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "spd-1"
            ]
          },
          {
            "id": "SearchParameter.xpathUsage",
            "path": "SearchParameter.xpathUsage",
            "short": "normal | phonetic | nearby | distance | other",
            "definition": "How the search parameter relates to the set of elements returned by evaluating the xpath query.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "condition": [
              "spd-1"
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "XPathUsageType"
                }
              ],
              "strength": "required",
              "description": "How a search parameter relates to the set of elements returned by evaluating its xpath query.",
              "valueSet": "http://hl7.org/fhir/ValueSet/search-xpath-usage|4.0.0"
            }
          },
          {
            "id": "SearchParameter.target",
            "path": "SearchParameter.target",
            "short": "Types of resource (if a resource reference)",
            "definition": "Types of resource (if a resource is referenced).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ResourceType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "One of the resource types defined as part of this version of FHIR.",
              "valueSet": "http://hl7.org/fhir/ValueSet/resource-types|4.0.0"
            }
          },
          {
            "id": "SearchParameter.multipleOr",
            "path": "SearchParameter.multipleOr",
            "short": "Allow multiple values per parameter (or)",
            "definition": "Whether multiple values are allowed for each time the parameter exists. Values are separated by commas, and the parameter matches if any of the values match.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "SearchParameter.multipleAnd",
            "path": "SearchParameter.multipleAnd",
            "short": "Allow multiple parameters (and)",
            "definition": "Whether multiple parameters are allowed - e.g. more than one parameter with the same name. The search matches if all the parameters match.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "SearchParameter.comparator",
            "path": "SearchParameter.comparator",
            "short": "eq | ne | gt | lt | ge | le | sa | eb | ap",
            "definition": "Comparators supported for the search parameter.",
            "comment": "If no comparators are listed, clients should not expect servers to support any comparators.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SearchComparator"
                }
              ],
              "strength": "required",
              "description": "What Search Comparator Codes are supported in search.",
              "valueSet": "http://hl7.org/fhir/ValueSet/search-comparator|4.0.0"
            }
          },
          {
            "id": "SearchParameter.modifier",
            "path": "SearchParameter.modifier",
            "short": "missing | exact | contains | not | text | in | not-in | below | above | type | identifier | ofType",
            "definition": "A modifier supported for the search parameter.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SearchModifierCode"
                }
              ],
              "strength": "required",
              "description": "A supported modifier for a search parameter.",
              "valueSet": "http://hl7.org/fhir/ValueSet/search-modifier-code|4.0.0"
            }
          },
          {
            "id": "SearchParameter.chain",
            "path": "SearchParameter.chain",
            "short": "Chained names supported",
            "definition": "Contains the names of any search parameters which may be chained to the containing search parameter. Chained parameters may be added to search parameters of type reference and specify that resources will only be returned if they contain a reference to a resource which matches the chained parameter value. Values for this field should be drawn from SearchParameter.code for a parameter on the target resource type.",
            "comment": "Systems are not required to list all the chain names they support, but if they don't list them, clients might not know to use them.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "SearchParameter.component",
            "path": "SearchParameter.component",
            "short": "For Composite resources to define the parts",
            "definition": "Used to define the parts of a composite search parameter.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "SearchParameter.component.definition",
            "path": "SearchParameter.component.definition",
            "short": "Defines how the part works",
            "definition": "The definition of the search parameter that describes this part.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/SearchParameter"
                ]
              }
            ]
          },
          {
            "id": "SearchParameter.component.expression",
            "path": "SearchParameter.component.expression",
            "short": "Subexpression relative to main expression",
            "definition": "A sub-expression that defines how to extract values for this component from the output of the main SearchParameter.expression.",
            "comment": "This expression overrides the expression in the definition and extracts the index values from the outcome of the composite expression.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'SearchParameter'
    /// </summary>
    // 0. SearchParameter
    public class Resource_SearchParameter : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                          // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 26. SearchParameter.component
        public class Type_Component : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 27. SearchParameter.component.definition
            public ElementDefinitionInfo Element_Definition;                                                                                // MakerGen.cs:219
            // 28. SearchParameter.component.expression
            public ElementDefinitionInfo Element_Expression;                                                                                // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "SearchParameter.component",                                                                                     // MakerGen.cs:395
                    ElementId = "SearchParameter.component"                                                                                 // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Definition.Write(sDef);                                                                                             // MakerGen.cs:223
                Element_Expression.Write(sDef);                                                                                             // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Component()                                                                                                         // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 27. SearchParameter.component.definition
                    this.Element_Definition = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Definition",                                                                                        // MakerGen.cs:238
                        Path= "SearchParameter.component.definition",                                                                       // MakerGen.cs:239
                        Id = "SearchParameter.component.definition",                                                                        // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                         // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                                TargetProfile = new String[]                                                                                // MakerGen.cs:306
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/SearchParameter"                                               // MakerGen.cs:306
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 28. SearchParameter.component.expression
                    this.Element_Expression = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Expression",                                                                                        // MakerGen.cs:238
                        Path= "SearchParameter.component.expression",                                                                       // MakerGen.cs:239
                        Id = "SearchParameter.component.expression",                                                                        // MakerGen.cs:240
                        Min = 1,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. SearchParameter.url
        public ElementDefinitionInfo Element_Url;                                                                                           // MakerGen.cs:219
        // 2. SearchParameter.version
        public ElementDefinitionInfo Element_Version;                                                                                       // MakerGen.cs:219
        // 3. SearchParameter.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:219
        // 4. SearchParameter.derivedFrom
        public ElementDefinitionInfo Element_DerivedFrom;                                                                                   // MakerGen.cs:219
        // 5. SearchParameter.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 6. SearchParameter.experimental
        public ElementDefinitionInfo Element_Experimental;                                                                                  // MakerGen.cs:219
        // 7. SearchParameter.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:219
        // 8. SearchParameter.publisher
        public ElementDefinitionInfo Element_Publisher;                                                                                     // MakerGen.cs:219
        // 9. SearchParameter.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:219
        // 10. SearchParameter.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:219
        // 11. SearchParameter.useContext
        public ElementDefinitionInfo Element_UseContext;                                                                                    // MakerGen.cs:219
        // 12. SearchParameter.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;                                                                                  // MakerGen.cs:219
        // 13. SearchParameter.purpose
        public ElementDefinitionInfo Element_Purpose;                                                                                       // MakerGen.cs:219
        // 14. SearchParameter.code
        public ElementDefinitionInfo Element_Code;                                                                                          // MakerGen.cs:219
        // 15. SearchParameter.base
        public ElementDefinitionInfo Element_Base;                                                                                          // MakerGen.cs:219
        // 16. SearchParameter.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:219
        // 17. SearchParameter.expression
        public ElementDefinitionInfo Element_Expression;                                                                                    // MakerGen.cs:219
        // 18. SearchParameter.xpath
        public ElementDefinitionInfo Element_Xpath;                                                                                         // MakerGen.cs:219
        // 19. SearchParameter.xpathUsage
        public ElementDefinitionInfo Element_XpathUsage;                                                                                    // MakerGen.cs:219
        // 20. SearchParameter.target
        public ElementDefinitionInfo Element_Target;                                                                                        // MakerGen.cs:219
        // 21. SearchParameter.multipleOr
        public ElementDefinitionInfo Element_MultipleOr;                                                                                    // MakerGen.cs:219
        // 22. SearchParameter.multipleAnd
        public ElementDefinitionInfo Element_MultipleAnd;                                                                                   // MakerGen.cs:219
        // 23. SearchParameter.comparator
        public ElementDefinitionInfo Element_Comparator;                                                                                    // MakerGen.cs:219
        // 24. SearchParameter.modifier
        public ElementDefinitionInfo Element_Modifier;                                                                                      // MakerGen.cs:219
        // 25. SearchParameter.chain
        public ElementDefinitionInfo Element_Chain;                                                                                         // MakerGen.cs:219
        // 26. SearchParameter.component
        public ElementDefinitionInfo Element_Component;                                                                                     // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "SearchParameter",                                                                                                   // MakerGen.cs:395
                ElementId = "SearchParameter"                                                                                               // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Url.Write(sDef);                                                                                                        // MakerGen.cs:223
            Element_Version.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_DerivedFrom.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Experimental.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Date.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Publisher.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Contact.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Description.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_UseContext.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Jurisdiction.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Purpose.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Code.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Base.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Expression.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Xpath.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_XpathUsage.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Target.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_MultipleOr.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_MultipleAnd.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Comparator.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Modifier.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Chain.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Component.Write(sDef);                                                                                                  // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_SearchParameter()                                                                                                   // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. SearchParameter.url
                this.Element_Url = new ElementDefinitionInfo                                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:238
                    Path= "SearchParameter.url",                                                                                            // MakerGen.cs:239
                    Id = "SearchParameter.url",                                                                                             // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. SearchParameter.version
                this.Element_Version = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Version",                                                                                               // MakerGen.cs:238
                    Path= "SearchParameter.version",                                                                                        // MakerGen.cs:239
                    Id = "SearchParameter.version",                                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. SearchParameter.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:238
                    Path= "SearchParameter.name",                                                                                           // MakerGen.cs:239
                    Id = "SearchParameter.name",                                                                                            // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. SearchParameter.derivedFrom
                this.Element_DerivedFrom = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_DerivedFrom",                                                                                           // MakerGen.cs:238
                    Path= "SearchParameter.derivedFrom",                                                                                    // MakerGen.cs:239
                    Id = "SearchParameter.derivedFrom",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:306
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/SearchParameter"                                                   // MakerGen.cs:306
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. SearchParameter.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "SearchParameter.status",                                                                                         // MakerGen.cs:239
                    Id = "SearchParameter.status",                                                                                          // MakerGen.cs:240
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
                // 6. SearchParameter.experimental
                this.Element_Experimental = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Experimental",                                                                                          // MakerGen.cs:238
                    Path= "SearchParameter.experimental",                                                                                   // MakerGen.cs:239
                    Id = "SearchParameter.experimental",                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. SearchParameter.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:238
                    Path= "SearchParameter.date",                                                                                           // MakerGen.cs:239
                    Id = "SearchParameter.date",                                                                                            // MakerGen.cs:240
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
                // 8. SearchParameter.publisher
                this.Element_Publisher = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:238
                    Path= "SearchParameter.publisher",                                                                                      // MakerGen.cs:239
                    Id = "SearchParameter.publisher",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. SearchParameter.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:238
                    Path= "SearchParameter.contact",                                                                                        // MakerGen.cs:239
                    Id = "SearchParameter.contact",                                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. SearchParameter.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Description",                                                                                           // MakerGen.cs:238
                    Path= "SearchParameter.description",                                                                                    // MakerGen.cs:239
                    Id = "SearchParameter.description",                                                                                     // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. SearchParameter.useContext
                this.Element_UseContext = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:238
                    Path= "SearchParameter.useContext",                                                                                     // MakerGen.cs:239
                    Id = "SearchParameter.useContext",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_UsageContext                                                                 // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 12. SearchParameter.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:238
                    Path= "SearchParameter.jurisdiction",                                                                                   // MakerGen.cs:239
                    Id = "SearchParameter.jurisdiction",                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 13. SearchParameter.purpose
                this.Element_Purpose = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Purpose",                                                                                               // MakerGen.cs:238
                    Path= "SearchParameter.purpose",                                                                                        // MakerGen.cs:239
                    Id = "SearchParameter.purpose",                                                                                         // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 14. SearchParameter.code
                this.Element_Code = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Code",                                                                                                  // MakerGen.cs:238
                    Path= "SearchParameter.code",                                                                                           // MakerGen.cs:239
                    Id = "SearchParameter.code",                                                                                            // MakerGen.cs:240
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
                // 15. SearchParameter.base
                this.Element_Base = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Base",                                                                                                  // MakerGen.cs:238
                    Path= "SearchParameter.base",                                                                                           // MakerGen.cs:239
                    Id = "SearchParameter.base",                                                                                            // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 16. SearchParameter.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:238
                    Path= "SearchParameter.type",                                                                                           // MakerGen.cs:239
                    Id = "SearchParameter.type",                                                                                            // MakerGen.cs:240
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
                // 17. SearchParameter.expression
                this.Element_Expression = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Expression",                                                                                            // MakerGen.cs:238
                    Path= "SearchParameter.expression",                                                                                     // MakerGen.cs:239
                    Id = "SearchParameter.expression",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 18. SearchParameter.xpath
                this.Element_Xpath = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Xpath",                                                                                                 // MakerGen.cs:238
                    Path= "SearchParameter.xpath",                                                                                          // MakerGen.cs:239
                    Id = "SearchParameter.xpath",                                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 19. SearchParameter.xpathUsage
                this.Element_XpathUsage = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_XpathUsage",                                                                                            // MakerGen.cs:238
                    Path= "SearchParameter.xpathUsage",                                                                                     // MakerGen.cs:239
                    Id = "SearchParameter.xpathUsage",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
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
                // 20. SearchParameter.target
                this.Element_Target = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Target",                                                                                                // MakerGen.cs:238
                    Path= "SearchParameter.target",                                                                                         // MakerGen.cs:239
                    Id = "SearchParameter.target",                                                                                          // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 21. SearchParameter.multipleOr
                this.Element_MultipleOr = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_MultipleOr",                                                                                            // MakerGen.cs:238
                    Path= "SearchParameter.multipleOr",                                                                                     // MakerGen.cs:239
                    Id = "SearchParameter.multipleOr",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 22. SearchParameter.multipleAnd
                this.Element_MultipleAnd = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_MultipleAnd",                                                                                           // MakerGen.cs:238
                    Path= "SearchParameter.multipleAnd",                                                                                    // MakerGen.cs:239
                    Id = "SearchParameter.multipleAnd",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 23. SearchParameter.comparator
                this.Element_Comparator = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Comparator",                                                                                            // MakerGen.cs:238
                    Path= "SearchParameter.comparator",                                                                                     // MakerGen.cs:239
                    Id = "SearchParameter.comparator",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 24. SearchParameter.modifier
                this.Element_Modifier = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Modifier",                                                                                              // MakerGen.cs:238
                    Path= "SearchParameter.modifier",                                                                                       // MakerGen.cs:239
                    Id = "SearchParameter.modifier",                                                                                        // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 25. SearchParameter.chain
                this.Element_Chain = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Chain",                                                                                                 // MakerGen.cs:238
                    Path= "SearchParameter.chain",                                                                                          // MakerGen.cs:239
                    Id = "SearchParameter.chain",                                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 26. SearchParameter.component
                this.Element_Component = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Component",                                                                                             // MakerGen.cs:238
                    Path= "SearchParameter.component",                                                                                      // MakerGen.cs:239
                    Id = "SearchParameter.component",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Component                                                                                                  // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "SearchParameter";                                                                                                  // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/SearchParameter";                                                           // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
