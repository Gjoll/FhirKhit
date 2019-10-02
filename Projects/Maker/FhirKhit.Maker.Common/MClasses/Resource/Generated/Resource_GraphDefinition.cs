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
    #endregion
    /// <summary>
    /// Fhir resource 'GraphDefinition'
    /// </summary>
    // 0. GraphDefinition
    public class Resource_GraphDefinition : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 15. GraphDefinition.link
        public class Type_Link : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 21. GraphDefinition.link.target
            public class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 25. GraphDefinition.link.target.compartment
                public class Type_Compartment : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 26. GraphDefinition.link.target.compartment.use
                    public ElementDefinitionInfo Element_Use;
                    // 27. GraphDefinition.link.target.compartment.code
                    public ElementDefinitionInfo Element_Code;
                    // 28. GraphDefinition.link.target.compartment.rule
                    public ElementDefinitionInfo Element_Rule;
                    // 29. GraphDefinition.link.target.compartment.expression
                    public ElementDefinitionInfo Element_Expression;
                    // 30. GraphDefinition.link.target.compartment.description
                    public ElementDefinitionInfo Element_Description;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "GraphDefinition.link.target.compartment",
                            ElementId = "GraphDefinition.link.target.compartment"
                        });
                        Element_Use.Write(sDef);
                        Element_Code.Write(sDef);
                        Element_Rule.Write(sDef);
                        Element_Expression.Write(sDef);
                        Element_Description.Write(sDef);
                    }
                    
                    public Type_Compartment()
                    {
                        {
                            // 26. GraphDefinition.link.target.compartment.use
                            this.Element_Use = new ElementDefinitionInfo
                            {
                                Name = "Element_Use",
                                Path= "GraphDefinition.link.target.compartment.use",
                                Id = "GraphDefinition.link.target.compartment.use",
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
                            // 27. GraphDefinition.link.target.compartment.code
                            this.Element_Code = new ElementDefinitionInfo
                            {
                                Name = "Element_Code",
                                Path= "GraphDefinition.link.target.compartment.code",
                                Id = "GraphDefinition.link.target.compartment.code",
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
                            // 28. GraphDefinition.link.target.compartment.rule
                            this.Element_Rule = new ElementDefinitionInfo
                            {
                                Name = "Element_Rule",
                                Path= "GraphDefinition.link.target.compartment.rule",
                                Id = "GraphDefinition.link.target.compartment.rule",
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
                            // 29. GraphDefinition.link.target.compartment.expression
                            this.Element_Expression = new ElementDefinitionInfo
                            {
                                Name = "Element_Expression",
                                Path= "GraphDefinition.link.target.compartment.expression",
                                Id = "GraphDefinition.link.target.compartment.expression",
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
                            // 30. GraphDefinition.link.target.compartment.description
                            this.Element_Description = new ElementDefinitionInfo
                            {
                                Name = "Element_Description",
                                Path= "GraphDefinition.link.target.compartment.description",
                                Id = "GraphDefinition.link.target.compartment.description",
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
                    }
                }
                // 22. GraphDefinition.link.target.type
                public ElementDefinitionInfo Element_Type;
                // 23. GraphDefinition.link.target.params
                public ElementDefinitionInfo Element_Params;
                // 24. GraphDefinition.link.target.profile
                public ElementDefinitionInfo Element_Profile;
                // 25. GraphDefinition.link.target.compartment
                public ElementDefinitionInfo Element_Compartment;
                // 31. GraphDefinition.link.target.link
                public ElementDefinitionInfo Element_Link;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "GraphDefinition.link.target",
                        ElementId = "GraphDefinition.link.target"
                    });
                    Element_Type.Write(sDef);
                    Element_Params.Write(sDef);
                    Element_Profile.Write(sDef);
                    Element_Compartment.Write(sDef);
                    Element_Link.Write(sDef);
                }
                
                public Type_Target()
                {
                    {
                        // 22. GraphDefinition.link.target.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "GraphDefinition.link.target.type",
                            Id = "GraphDefinition.link.target.type",
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
                        // 23. GraphDefinition.link.target.params
                        this.Element_Params = new ElementDefinitionInfo
                        {
                            Name = "Element_Params",
                            Path= "GraphDefinition.link.target.params",
                            Id = "GraphDefinition.link.target.params",
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
                        // 24. GraphDefinition.link.target.profile
                        this.Element_Profile = new ElementDefinitionInfo
                        {
                            Name = "Element_Profile",
                            Path= "GraphDefinition.link.target.profile",
                            Id = "GraphDefinition.link.target.profile",
                            Min = 0,
                            Max = 1,
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
                        // 25. GraphDefinition.link.target.compartment
                        this.Element_Compartment = new ElementDefinitionInfo
                        {
                            Name = "Element_Compartment",
                            Path= "GraphDefinition.link.target.compartment",
                            Id = "GraphDefinition.link.target.compartment",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Compartment
                                {
                                }
                            }
                        };
                    }
                    {
                        // 31. GraphDefinition.link.target.link
                        this.Element_Link = new ElementDefinitionInfo
                        {
                            Name = "Element_Link",
                            Path= "GraphDefinition.link.target.link",
                            Id = "GraphDefinition.link.target.link",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                }
            }
            // 16. GraphDefinition.link.path
            public ElementDefinitionInfo Element_Path;
            // 17. GraphDefinition.link.sliceName
            public ElementDefinitionInfo Element_SliceName;
            // 18. GraphDefinition.link.min
            public ElementDefinitionInfo Element_Min;
            // 19. GraphDefinition.link.max
            public ElementDefinitionInfo Element_Max;
            // 20. GraphDefinition.link.description
            public ElementDefinitionInfo Element_Description;
            // 21. GraphDefinition.link.target
            public ElementDefinitionInfo Element_Target;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "GraphDefinition.link",
                    ElementId = "GraphDefinition.link"
                });
                Element_Path.Write(sDef);
                Element_SliceName.Write(sDef);
                Element_Min.Write(sDef);
                Element_Max.Write(sDef);
                Element_Description.Write(sDef);
                Element_Target.Write(sDef);
            }
            
            public Type_Link()
            {
                {
                    // 16. GraphDefinition.link.path
                    this.Element_Path = new ElementDefinitionInfo
                    {
                        Name = "Element_Path",
                        Path= "GraphDefinition.link.path",
                        Id = "GraphDefinition.link.path",
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
                    // 17. GraphDefinition.link.sliceName
                    this.Element_SliceName = new ElementDefinitionInfo
                    {
                        Name = "Element_SliceName",
                        Path= "GraphDefinition.link.sliceName",
                        Id = "GraphDefinition.link.sliceName",
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
                    // 18. GraphDefinition.link.min
                    this.Element_Min = new ElementDefinitionInfo
                    {
                        Name = "Element_Min",
                        Path= "GraphDefinition.link.min",
                        Id = "GraphDefinition.link.min",
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
                    // 19. GraphDefinition.link.max
                    this.Element_Max = new ElementDefinitionInfo
                    {
                        Name = "Element_Max",
                        Path= "GraphDefinition.link.max",
                        Id = "GraphDefinition.link.max",
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
                    // 20. GraphDefinition.link.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "GraphDefinition.link.description",
                        Id = "GraphDefinition.link.description",
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
                    // 21. GraphDefinition.link.target
                    this.Element_Target = new ElementDefinitionInfo
                    {
                        Name = "Element_Target",
                        Path= "GraphDefinition.link.target",
                        Id = "GraphDefinition.link.target",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Target
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. GraphDefinition.url
        public ElementDefinitionInfo Element_Url;
        // 2. GraphDefinition.version
        public ElementDefinitionInfo Element_Version;
        // 3. GraphDefinition.name
        public ElementDefinitionInfo Element_Name;
        // 4. GraphDefinition.status
        public ElementDefinitionInfo Element_Status;
        // 5. GraphDefinition.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 6. GraphDefinition.date
        public ElementDefinitionInfo Element_Date;
        // 7. GraphDefinition.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 8. GraphDefinition.contact
        public ElementDefinitionInfo Element_Contact;
        // 9. GraphDefinition.description
        public ElementDefinitionInfo Element_Description;
        // 10. GraphDefinition.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 11. GraphDefinition.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 12. GraphDefinition.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 13. GraphDefinition.start
        public ElementDefinitionInfo Element_Start;
        // 14. GraphDefinition.profile
        public ElementDefinitionInfo Element_Profile;
        // 15. GraphDefinition.link
        public ElementDefinitionInfo Element_Link;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "GraphDefinition",
                ElementId = "GraphDefinition"
            });
            Element_Url.Write(sDef);
            Element_Version.Write(sDef);
            Element_Name.Write(sDef);
            Element_Status.Write(sDef);
            Element_Experimental.Write(sDef);
            Element_Date.Write(sDef);
            Element_Publisher.Write(sDef);
            Element_Contact.Write(sDef);
            Element_Description.Write(sDef);
            Element_UseContext.Write(sDef);
            Element_Jurisdiction.Write(sDef);
            Element_Purpose.Write(sDef);
            Element_Start.Write(sDef);
            Element_Profile.Write(sDef);
            Element_Link.Write(sDef);
        }
        
        public Resource_GraphDefinition()
        {
            {
                // 1. GraphDefinition.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "GraphDefinition.url",
                    Id = "GraphDefinition.url",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        }
                    }
                };
            }
            {
                // 2. GraphDefinition.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "GraphDefinition.version",
                    Id = "GraphDefinition.version",
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
                // 3. GraphDefinition.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "GraphDefinition.name",
                    Id = "GraphDefinition.name",
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
                // 4. GraphDefinition.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "GraphDefinition.status",
                    Id = "GraphDefinition.status",
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
                // 5. GraphDefinition.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "GraphDefinition.experimental",
                    Id = "GraphDefinition.experimental",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                        {
                        }
                    }
                };
            }
            {
                // 6. GraphDefinition.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "GraphDefinition.date",
                    Id = "GraphDefinition.date",
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
                // 7. GraphDefinition.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "GraphDefinition.publisher",
                    Id = "GraphDefinition.publisher",
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
                // 8. GraphDefinition.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "GraphDefinition.contact",
                    Id = "GraphDefinition.contact",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail
                        {
                        }
                    }
                };
            }
            {
                // 9. GraphDefinition.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "GraphDefinition.description",
                    Id = "GraphDefinition.description",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                        {
                        }
                    }
                };
            }
            {
                // 10. GraphDefinition.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "GraphDefinition.useContext",
                    Id = "GraphDefinition.useContext",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_UsageContext
                        {
                        }
                    }
                };
            }
            {
                // 11. GraphDefinition.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "GraphDefinition.jurisdiction",
                    Id = "GraphDefinition.jurisdiction",
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
                // 12. GraphDefinition.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "GraphDefinition.purpose",
                    Id = "GraphDefinition.purpose",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                        {
                        }
                    }
                };
            }
            {
                // 13. GraphDefinition.start
                this.Element_Start = new ElementDefinitionInfo
                {
                    Name = "Element_Start",
                    Path= "GraphDefinition.start",
                    Id = "GraphDefinition.start",
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
                // 14. GraphDefinition.profile
                this.Element_Profile = new ElementDefinitionInfo
                {
                    Name = "Element_Profile",
                    Path= "GraphDefinition.profile",
                    Id = "GraphDefinition.profile",
                    Min = 0,
                    Max = 1,
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
                // 15. GraphDefinition.link
                this.Element_Link = new ElementDefinitionInfo
                {
                    Name = "Element_Link",
                    Path= "GraphDefinition.link",
                    Id = "GraphDefinition.link",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Link
                        {
                        }
                    }
                };
            }
            this.Name = "GraphDefinition";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/GraphDefinition";
        }
    }
}
