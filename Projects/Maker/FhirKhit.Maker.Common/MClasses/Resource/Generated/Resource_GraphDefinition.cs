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
      "id": "GraphDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/GraphDefinition",
      "version": "4.0.0",
      "name": "GraphDefinition",
      "status": "draft",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A formal computable definition of a graph of resources - that is, a coherent set of resources that form a graph by following references. The Graph Definition resource defines a set and makes rules about the set.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "GraphDefinition",
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
            "id": "GraphDefinition",
            "path": "GraphDefinition",
            "short": "Definition of a graph of resources",
            "definition": "A formal computable definition of a graph of resources - that is, a coherent set of resources that form a graph by following references. The Graph Definition resource defines a set and makes rules about the set.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "GraphDefinition.url",
            "path": "GraphDefinition.url",
            "short": "Canonical identifier for this graph definition, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this graph definition when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this graph definition is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the graph definition is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the graph definition to be referenced by a single globally unique identifier.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "GraphDefinition.version",
            "path": "GraphDefinition.version",
            "short": "Business version of the graph definition",
            "definition": "The identifier that is used to identify this version of the graph definition when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the graph definition author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different graph definition instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the graph definition with the format [url]|[version].",
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
            "id": "GraphDefinition.name",
            "path": "GraphDefinition.name",
            "short": "Name for this graph definition (computer friendly)",
            "definition": "A natural language name identifying the graph definition. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "GraphDefinition.status",
            "path": "GraphDefinition.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this graph definition. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of graph definitions that are appropriate for use versus not.",
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
            "id": "GraphDefinition.experimental",
            "path": "GraphDefinition.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this graph definition is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of graph definitions that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level graph definition.",
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
            "id": "GraphDefinition.date",
            "path": "GraphDefinition.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the graph definition was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the graph definition changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the graph definition. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "GraphDefinition.publisher",
            "path": "GraphDefinition.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the graph definition.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the graph definition is the organization or individual primarily responsible for the maintenance and upkeep of the graph definition. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the graph definition. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the graph definition.  May also allow for contact.",
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
            "id": "GraphDefinition.contact",
            "path": "GraphDefinition.contact",
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
            "id": "GraphDefinition.description",
            "path": "GraphDefinition.description",
            "short": "Natural language description of the graph definition",
            "definition": "A free text natural language description of the graph definition from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the graph definition was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the graph definition as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the graph definition is presumed to be the predominant language in the place the graph definition was created).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "GraphDefinition.useContext",
            "path": "GraphDefinition.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate graph definition instances.",
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
            "id": "GraphDefinition.jurisdiction",
            "path": "GraphDefinition.jurisdiction",
            "short": "Intended jurisdiction for graph definition (if applicable)",
            "definition": "A legal or geographic region in which the graph definition is intended to be used.",
            "comment": "It may be possible for the graph definition to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "GraphDefinition.purpose",
            "path": "GraphDefinition.purpose",
            "short": "Why this graph definition is defined",
            "definition": "Explanation of why this graph definition is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the graph definition. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this graph definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "GraphDefinition.start",
            "path": "GraphDefinition.start",
            "short": "Type of resource at which the graph starts",
            "definition": "The type of FHIR resource at which instances of this graph start.",
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
            "id": "GraphDefinition.profile",
            "path": "GraphDefinition.profile",
            "short": "Profile on base resource",
            "definition": "The profile that describes the use of the base resource.",
            "comment": "The code does not include the '$' prefix that is always included in the URL when the operation is invoked.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
                ]
              }
            ]
          },
          {
            "id": "GraphDefinition.link",
            "path": "GraphDefinition.link",
            "short": "Links this graph makes rules about",
            "definition": "Links this graph makes rules about.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "GraphDefinition.link.path",
            "path": "GraphDefinition.link.path",
            "short": "Path in the resource that contains the link",
            "definition": "A FHIR expression that identifies one of FHIR References to other resources.",
            "comment": "The path expression cannot contain a resolve() function. If there is no path, the link is a reverse lookup, using target.params. If the path is \"*\" then this means all references in the resource.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "GraphDefinition.link.sliceName",
            "path": "GraphDefinition.link.sliceName",
            "short": "Which slice (if profiled)",
            "definition": "Which slice (if profiled).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "GraphDefinition.link.min",
            "path": "GraphDefinition.link.min",
            "short": "Minimum occurrences for this link",
            "definition": "Minimum occurrences for this link.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "GraphDefinition.link.max",
            "path": "GraphDefinition.link.max",
            "short": "Maximum occurrences for this link",
            "definition": "Maximum occurrences for this link.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "GraphDefinition.link.description",
            "path": "GraphDefinition.link.description",
            "short": "Why this link is specified",
            "definition": "Information about why this link is of interest in this graph definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "GraphDefinition.link.target",
            "path": "GraphDefinition.link.target",
            "short": "Potential target for the link",
            "definition": "Potential target for the link.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "GraphDefinition.link.target.type",
            "path": "GraphDefinition.link.target.type",
            "short": "Type of resource this link refers to",
            "definition": "Type of resource this link refers to.",
            "min": 1,
            "max": "1",
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
            "id": "GraphDefinition.link.target.params",
            "path": "GraphDefinition.link.target.params",
            "short": "Criteria for reverse lookup",
            "definition": "A set of parameters to look up.",
            "comment": "At least one of the parameters must have the value {ref} which identifies the focus resource.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "GraphDefinition.link.target.profile",
            "path": "GraphDefinition.link.target.profile",
            "short": "Profile for the target resource",
            "definition": "Profile for the target resource.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
                ]
              }
            ]
          },
          {
            "id": "GraphDefinition.link.target.compartment",
            "path": "GraphDefinition.link.target.compartment",
            "short": "Compartment Consistency Rules",
            "definition": "Compartment Consistency Rules.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "GraphDefinition.link.target.compartment.use",
            "path": "GraphDefinition.link.target.compartment.use",
            "short": "condition | requirement",
            "definition": "Defines how the compartment rule is used - whether it it is used to test whether resources are subject to the rule, or whether it is a rule that must be followed.",
            "comment": "All conditional rules are evaluated; if they are true, then the rules are evaluated.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "GraphCompartmentUse"
                }
              ],
              "strength": "required",
              "description": "Defines how a compartment rule is used.",
              "valueSet": "http://hl7.org/fhir/ValueSet/graph-compartment-use|4.0.0"
            }
          },
          {
            "id": "GraphDefinition.link.target.compartment.code",
            "path": "GraphDefinition.link.target.compartment.code",
            "short": "Identifies the compartment",
            "definition": "Identifies the compartment.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CompartmentCode"
                }
              ],
              "strength": "required",
              "description": "Identifies a compartment.",
              "valueSet": "http://hl7.org/fhir/ValueSet/compartment-type|4.0.0"
            }
          },
          {
            "id": "GraphDefinition.link.target.compartment.rule",
            "path": "GraphDefinition.link.target.compartment.rule",
            "short": "identical | matching | different | custom",
            "definition": "identical | matching | different | no-rule | custom.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "GraphCompartmentRule"
                }
              ],
              "strength": "required",
              "description": "How a compartment must be linked.",
              "valueSet": "http://hl7.org/fhir/ValueSet/graph-compartment-rule|4.0.0"
            }
          },
          {
            "id": "GraphDefinition.link.target.compartment.expression",
            "path": "GraphDefinition.link.target.compartment.expression",
            "short": "Custom rule, as a FHIRPath expression",
            "definition": "Custom rule, as a FHIRPath expression.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "GraphDefinition.link.target.compartment.description",
            "path": "GraphDefinition.link.target.compartment.description",
            "short": "Documentation for FHIRPath expression",
            "definition": "Documentation for FHIRPath expression.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "GraphDefinition.link.target.link",
            "path": "GraphDefinition.link.target.link",
            "short": "Additional links from target resource",
            "definition": "Additional links from target resource.",
            "min": 0,
            "max": "*",
            "contentReference": "#GraphDefinition.link"
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'GraphDefinition'
    /// </summary>
    // 0. GraphDefinition
    public class Resource_GraphDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                                     // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 15. GraphDefinition.link
        public class Type_Link : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 21. GraphDefinition.link.target
            public class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 25. GraphDefinition.link.target.compartment
                public class Type_Compartment : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:376
                {                                                                                                                           // MakerGen.cs:377
                    // 26. GraphDefinition.link.target.compartment.use
                    public ElementDefinitionInfo Element_Use;                                                                               // MakerGen.cs:212
                    // 27. GraphDefinition.link.target.compartment.code
                    public ElementDefinitionInfo Element_Code;                                                                              // MakerGen.cs:212
                    // 28. GraphDefinition.link.target.compartment.rule
                    public ElementDefinitionInfo Element_Rule;                                                                              // MakerGen.cs:212
                    // 29. GraphDefinition.link.target.compartment.expression
                    public ElementDefinitionInfo Element_Expression;                                                                        // MakerGen.cs:212
                    // 30. GraphDefinition.link.target.compartment.description
                    public ElementDefinitionInfo Element_Description;                                                                       // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        base.Write(sDef);                                                                                                   // MakerGen.cs:385
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            Path = "GraphDefinition.link.target.compartment",                                                               // MakerGen.cs:388
                            ElementId = "GraphDefinition.link.target.compartment"                                                           // MakerGen.cs:389
                        });                                                                                                                 // MakerGen.cs:390
                        Element_Use.Write(sDef);                                                                                            // MakerGen.cs:216
                        Element_Code.Write(sDef);                                                                                           // MakerGen.cs:216
                        Element_Rule.Write(sDef);                                                                                           // MakerGen.cs:216
                        Element_Expression.Write(sDef);                                                                                     // MakerGen.cs:216
                        Element_Description.Write(sDef);                                                                                    // MakerGen.cs:216
                    }                                                                                                                       // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                    public Type_Compartment()                                                                                               // MakerGen.cs:395
                    {                                                                                                                       // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:227
                            // 26. GraphDefinition.link.target.compartment.use
                            this.Element_Use = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Use",                                                                                       // MakerGen.cs:231
                                Path= "GraphDefinition.link.target.compartment.use",                                                        // MakerGen.cs:232
                                Id = "GraphDefinition.link.target.compartment.use",                                                         // MakerGen.cs:233
                                Min = 1,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                      // MakerGen.cs:296
                                    {                                                                                                       // MakerGen.cs:297
                                    }                                                                                                       // MakerGen.cs:300
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 27. GraphDefinition.link.target.compartment.code
                            this.Element_Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Code",                                                                                      // MakerGen.cs:231
                                Path= "GraphDefinition.link.target.compartment.code",                                                       // MakerGen.cs:232
                                Id = "GraphDefinition.link.target.compartment.code",                                                        // MakerGen.cs:233
                                Min = 1,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                      // MakerGen.cs:296
                                    {                                                                                                       // MakerGen.cs:297
                                    }                                                                                                       // MakerGen.cs:300
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 28. GraphDefinition.link.target.compartment.rule
                            this.Element_Rule = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Rule",                                                                                      // MakerGen.cs:231
                                Path= "GraphDefinition.link.target.compartment.rule",                                                       // MakerGen.cs:232
                                Id = "GraphDefinition.link.target.compartment.rule",                                                        // MakerGen.cs:233
                                Min = 1,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                      // MakerGen.cs:296
                                    {                                                                                                       // MakerGen.cs:297
                                    }                                                                                                       // MakerGen.cs:300
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 29. GraphDefinition.link.target.compartment.expression
                            this.Element_Expression = new ElementDefinitionInfo                                                             // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Expression",                                                                                // MakerGen.cs:231
                                Path= "GraphDefinition.link.target.compartment.expression",                                                 // MakerGen.cs:232
                                Id = "GraphDefinition.link.target.compartment.expression",                                                  // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:296
                                    {                                                                                                       // MakerGen.cs:297
                                    }                                                                                                       // MakerGen.cs:300
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:227
                            // 30. GraphDefinition.link.target.compartment.description
                            this.Element_Description = new ElementDefinitionInfo                                                            // MakerGen.cs:229
                            {                                                                                                               // MakerGen.cs:230
                                Name = "Element_Description",                                                                               // MakerGen.cs:231
                                Path= "GraphDefinition.link.target.compartment.description",                                                // MakerGen.cs:232
                                Id = "GraphDefinition.link.target.compartment.description",                                                 // MakerGen.cs:233
                                Min = 0,                                                                                                    // MakerGen.cs:234
                                Max = 1,                                                                                                    // MakerGen.cs:235
                                Types = new BaseType[]                                                                                      // MakerGen.cs:236
                                {                                                                                                           // MakerGen.cs:237
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:296
                                    {                                                                                                       // MakerGen.cs:297
                                    }                                                                                                       // MakerGen.cs:300
                                }                                                                                                           // MakerGen.cs:239
                            };                                                                                                              // MakerGen.cs:240
                        }                                                                                                                   // MakerGen.cs:241
                    }                                                                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:400
                // 22. GraphDefinition.link.target.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:212
                // 23. GraphDefinition.link.target.params
                public ElementDefinitionInfo Element_Params;                                                                                // MakerGen.cs:212
                // 24. GraphDefinition.link.target.profile
                public ElementDefinitionInfo Element_Profile;                                                                               // MakerGen.cs:212
                // 25. GraphDefinition.link.target.compartment
                public ElementDefinitionInfo Element_Compartment;                                                                           // MakerGen.cs:212
                // 31. GraphDefinition.link.target.link
                public ElementDefinitionInfo Element_Link;                                                                                  // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "GraphDefinition.link.target",                                                                               // MakerGen.cs:388
                        ElementId = "GraphDefinition.link.target"                                                                           // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_Params.Write(sDef);                                                                                             // MakerGen.cs:216
                    Element_Profile.Write(sDef);                                                                                            // MakerGen.cs:216
                    Element_Compartment.Write(sDef);                                                                                        // MakerGen.cs:216
                    Element_Link.Write(sDef);                                                                                               // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_Target()                                                                                                        // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 22. GraphDefinition.link.target.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Type",                                                                                          // MakerGen.cs:231
                            Path= "GraphDefinition.link.target.type",                                                                       // MakerGen.cs:232
                            Id = "GraphDefinition.link.target.type",                                                                        // MakerGen.cs:233
                            Min = 1,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 23. GraphDefinition.link.target.params
                        this.Element_Params = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Params",                                                                                        // MakerGen.cs:231
                            Path= "GraphDefinition.link.target.params",                                                                     // MakerGen.cs:232
                            Id = "GraphDefinition.link.target.params",                                                                      // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 24. GraphDefinition.link.target.profile
                        this.Element_Profile = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Profile",                                                                                       // MakerGen.cs:231
                            Path= "GraphDefinition.link.target.profile",                                                                    // MakerGen.cs:232
                            Id = "GraphDefinition.link.target.profile",                                                                     // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                     // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                    TargetProfile = new String[]                                                                            // MakerGen.cs:299
                                    {                                                                                                       // CodeEditorExtensions.cs:28
                                        "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                       // MakerGen.cs:299
                                    }                                                                                                       // CodeEditorExtensions.cs:34
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 25. GraphDefinition.link.target.compartment
                        this.Element_Compartment = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Compartment",                                                                                   // MakerGen.cs:231
                            Path= "GraphDefinition.link.target.compartment",                                                                // MakerGen.cs:232
                            Id = "GraphDefinition.link.target.compartment",                                                                 // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = -1,                                                                                                       // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new Type_Compartment                                                                                        // MakerGen.cs:255
                                {                                                                                                           // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:257
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 31. GraphDefinition.link.target.link
                        this.Element_Link = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Link",                                                                                          // MakerGen.cs:231
                            Path= "GraphDefinition.link.target.link",                                                                       // MakerGen.cs:232
                            Id = "GraphDefinition.link.target.link",                                                                        // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = -1,                                                                                                       // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 16. GraphDefinition.link.path
            public ElementDefinitionInfo Element_Path;                                                                                      // MakerGen.cs:212
            // 17. GraphDefinition.link.sliceName
            public ElementDefinitionInfo Element_SliceName;                                                                                 // MakerGen.cs:212
            // 18. GraphDefinition.link.min
            public ElementDefinitionInfo Element_Min;                                                                                       // MakerGen.cs:212
            // 19. GraphDefinition.link.max
            public ElementDefinitionInfo Element_Max;                                                                                       // MakerGen.cs:212
            // 20. GraphDefinition.link.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:212
            // 21. GraphDefinition.link.target
            public ElementDefinitionInfo Element_Target;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "GraphDefinition.link",                                                                                          // MakerGen.cs:388
                    ElementId = "GraphDefinition.link"                                                                                      // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Path.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_SliceName.Write(sDef);                                                                                              // MakerGen.cs:216
                Element_Min.Write(sDef);                                                                                                    // MakerGen.cs:216
                Element_Max.Write(sDef);                                                                                                    // MakerGen.cs:216
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_Target.Write(sDef);                                                                                                 // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Link()                                                                                                              // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 16. GraphDefinition.link.path
                    this.Element_Path = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Path",                                                                                              // MakerGen.cs:231
                        Path= "GraphDefinition.link.path",                                                                                  // MakerGen.cs:232
                        Id = "GraphDefinition.link.path",                                                                                   // MakerGen.cs:233
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
                    // 17. GraphDefinition.link.sliceName
                    this.Element_SliceName = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_SliceName",                                                                                         // MakerGen.cs:231
                        Path= "GraphDefinition.link.sliceName",                                                                             // MakerGen.cs:232
                        Id = "GraphDefinition.link.sliceName",                                                                              // MakerGen.cs:233
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
                    // 18. GraphDefinition.link.min
                    this.Element_Min = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Min",                                                                                               // MakerGen.cs:231
                        Path= "GraphDefinition.link.min",                                                                                   // MakerGen.cs:232
                        Id = "GraphDefinition.link.min",                                                                                    // MakerGen.cs:233
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
                {                                                                                                                           // MakerGen.cs:227
                    // 19. GraphDefinition.link.max
                    this.Element_Max = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Max",                                                                                               // MakerGen.cs:231
                        Path= "GraphDefinition.link.max",                                                                                   // MakerGen.cs:232
                        Id = "GraphDefinition.link.max",                                                                                    // MakerGen.cs:233
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
                    // 20. GraphDefinition.link.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Description",                                                                                       // MakerGen.cs:231
                        Path= "GraphDefinition.link.description",                                                                           // MakerGen.cs:232
                        Id = "GraphDefinition.link.description",                                                                            // MakerGen.cs:233
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
                    // 21. GraphDefinition.link.target
                    this.Element_Target = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Target",                                                                                            // MakerGen.cs:231
                        Path= "GraphDefinition.link.target",                                                                                // MakerGen.cs:232
                        Id = "GraphDefinition.link.target",                                                                                 // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_Target                                                                                                 // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. GraphDefinition.url
        public ElementDefinitionInfo Element_Url;                                                                                           // MakerGen.cs:212
        // 2. GraphDefinition.version
        public ElementDefinitionInfo Element_Version;                                                                                       // MakerGen.cs:212
        // 3. GraphDefinition.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:212
        // 4. GraphDefinition.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 5. GraphDefinition.experimental
        public ElementDefinitionInfo Element_Experimental;                                                                                  // MakerGen.cs:212
        // 6. GraphDefinition.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:212
        // 7. GraphDefinition.publisher
        public ElementDefinitionInfo Element_Publisher;                                                                                     // MakerGen.cs:212
        // 8. GraphDefinition.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:212
        // 9. GraphDefinition.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:212
        // 10. GraphDefinition.useContext
        public ElementDefinitionInfo Element_UseContext;                                                                                    // MakerGen.cs:212
        // 11. GraphDefinition.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;                                                                                  // MakerGen.cs:212
        // 12. GraphDefinition.purpose
        public ElementDefinitionInfo Element_Purpose;                                                                                       // MakerGen.cs:212
        // 13. GraphDefinition.start
        public ElementDefinitionInfo Element_Start;                                                                                         // MakerGen.cs:212
        // 14. GraphDefinition.profile
        public ElementDefinitionInfo Element_Profile;                                                                                       // MakerGen.cs:212
        // 15. GraphDefinition.link
        public ElementDefinitionInfo Element_Link;                                                                                          // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "GraphDefinition",                                                                                                   // MakerGen.cs:388
                ElementId = "GraphDefinition"                                                                                               // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Url.Write(sDef);                                                                                                        // MakerGen.cs:216
            Element_Version.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Experimental.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_Date.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Publisher.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Contact.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Description.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_UseContext.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Jurisdiction.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_Purpose.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Start.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Profile.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Link.Write(sDef);                                                                                                       // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_GraphDefinition()                                                                                                   // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. GraphDefinition.url
                this.Element_Url = new ElementDefinitionInfo                                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:231
                    Path= "GraphDefinition.url",                                                                                            // MakerGen.cs:232
                    Id = "GraphDefinition.url",                                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. GraphDefinition.version
                this.Element_Version = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Version",                                                                                               // MakerGen.cs:231
                    Path= "GraphDefinition.version",                                                                                        // MakerGen.cs:232
                    Id = "GraphDefinition.version",                                                                                         // MakerGen.cs:233
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
                // 3. GraphDefinition.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:231
                    Path= "GraphDefinition.name",                                                                                           // MakerGen.cs:232
                    Id = "GraphDefinition.name",                                                                                            // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
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
                // 4. GraphDefinition.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "GraphDefinition.status",                                                                                         // MakerGen.cs:232
                    Id = "GraphDefinition.status",                                                                                          // MakerGen.cs:233
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
                // 5. GraphDefinition.experimental
                this.Element_Experimental = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Experimental",                                                                                          // MakerGen.cs:231
                    Path= "GraphDefinition.experimental",                                                                                   // MakerGen.cs:232
                    Id = "GraphDefinition.experimental",                                                                                    // MakerGen.cs:233
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
                // 6. GraphDefinition.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:231
                    Path= "GraphDefinition.date",                                                                                           // MakerGen.cs:232
                    Id = "GraphDefinition.date",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. GraphDefinition.publisher
                this.Element_Publisher = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:231
                    Path= "GraphDefinition.publisher",                                                                                      // MakerGen.cs:232
                    Id = "GraphDefinition.publisher",                                                                                       // MakerGen.cs:233
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
                // 8. GraphDefinition.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:231
                    Path= "GraphDefinition.contact",                                                                                        // MakerGen.cs:232
                    Id = "GraphDefinition.contact",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 9. GraphDefinition.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Description",                                                                                           // MakerGen.cs:231
                    Path= "GraphDefinition.description",                                                                                    // MakerGen.cs:232
                    Id = "GraphDefinition.description",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. GraphDefinition.useContext
                this.Element_UseContext = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:231
                    Path= "GraphDefinition.useContext",                                                                                     // MakerGen.cs:232
                    Id = "GraphDefinition.useContext",                                                                                      // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_UsageContext                                                                 // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. GraphDefinition.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:231
                    Path= "GraphDefinition.jurisdiction",                                                                                   // MakerGen.cs:232
                    Id = "GraphDefinition.jurisdiction",                                                                                    // MakerGen.cs:233
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
                // 12. GraphDefinition.purpose
                this.Element_Purpose = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Purpose",                                                                                               // MakerGen.cs:231
                    Path= "GraphDefinition.purpose",                                                                                        // MakerGen.cs:232
                    Id = "GraphDefinition.purpose",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. GraphDefinition.start
                this.Element_Start = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Start",                                                                                                 // MakerGen.cs:231
                    Path= "GraphDefinition.start",                                                                                          // MakerGen.cs:232
                    Id = "GraphDefinition.start",                                                                                           // MakerGen.cs:233
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
                // 14. GraphDefinition.profile
                this.Element_Profile = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Profile",                                                                                               // MakerGen.cs:231
                    Path= "GraphDefinition.profile",                                                                                        // MakerGen.cs:232
                    Id = "GraphDefinition.profile",                                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
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
                // 15. GraphDefinition.link
                this.Element_Link = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Link",                                                                                                  // MakerGen.cs:231
                    Path= "GraphDefinition.link",                                                                                           // MakerGen.cs:232
                    Id = "GraphDefinition.link",                                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Link                                                                                                       // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "GraphDefinition";                                                                                                  // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/GraphDefinition";                                                           // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
