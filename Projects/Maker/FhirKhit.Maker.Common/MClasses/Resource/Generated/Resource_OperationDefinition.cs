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
      "id": "OperationDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/OperationDefinition",
      "version": "4.0.0",
      "name": "OperationDefinition",
      "status": "active",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A formal computable definition of an operation (on the RESTful interface) or a named query (using the search interaction).",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "OperationDefinition",
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
            "id": "OperationDefinition",
            "path": "OperationDefinition",
            "short": "Definition of an operation or a named query",
            "definition": "A formal computable definition of an operation (on the RESTful interface) or a named query (using the search interaction).",
            "min": 0,
            "max": "*"
          },
          {
            "id": "OperationDefinition.url",
            "path": "OperationDefinition.url",
            "short": "Canonical identifier for this operation definition, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this operation definition when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this operation definition is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the operation definition is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the operation definition to be referenced by a single globally unique identifier.",
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
            "id": "OperationDefinition.version",
            "path": "OperationDefinition.version",
            "short": "Business version of the operation definition",
            "definition": "The identifier that is used to identify this version of the operation definition when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the operation definition author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different operation definition instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the operation definition with the format [url]|[version].",
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
            "id": "OperationDefinition.name",
            "path": "OperationDefinition.name",
            "short": "Name for this operation definition (computer friendly)",
            "definition": "A natural language name identifying the operation definition. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "OperationDefinition.title",
            "path": "OperationDefinition.title",
            "short": "Name for this operation definition (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the operation definition.",
            "comment": "This name does not need to be machine-processing friendly and may contain punctuation, white-space, etc.",
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
            "id": "OperationDefinition.status",
            "path": "OperationDefinition.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this operation definition. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of operation definitions that are appropriate for use versus not.",
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
            "id": "OperationDefinition.kind",
            "path": "OperationDefinition.kind",
            "short": "operation | query",
            "definition": "Whether this is an operation or a named query.",
            "comment": "Named queries are invoked differently, and have different capabilities.",
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
                  "valueString": "OperationKind"
                }
              ],
              "strength": "required",
              "description": "Whether an operation is a normal operation or a query.",
              "valueSet": "http://hl7.org/fhir/ValueSet/operation-kind|4.0.0"
            }
          },
          {
            "id": "OperationDefinition.experimental",
            "path": "OperationDefinition.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this operation definition is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of operation definitions that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level operation definition.",
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
            "id": "OperationDefinition.date",
            "path": "OperationDefinition.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the operation definition was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the operation definition changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the operation definition. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "OperationDefinition.publisher",
            "path": "OperationDefinition.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the operation definition.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the operation definition is the organization or individual primarily responsible for the maintenance and upkeep of the operation definition. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the operation definition. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the operation definition.  May also allow for contact.",
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
            "id": "OperationDefinition.contact",
            "path": "OperationDefinition.contact",
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
            "id": "OperationDefinition.description",
            "path": "OperationDefinition.description",
            "short": "Natural language description of the operation definition",
            "definition": "A free text natural language description of the operation definition from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the operation definition was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the operation definition as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the operation definition is presumed to be the predominant language in the place the operation definition was created).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "OperationDefinition.useContext",
            "path": "OperationDefinition.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate operation definition instances.",
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
            "id": "OperationDefinition.jurisdiction",
            "path": "OperationDefinition.jurisdiction",
            "short": "Intended jurisdiction for operation definition (if applicable)",
            "definition": "A legal or geographic region in which the operation definition is intended to be used.",
            "comment": "It may be possible for the operation definition to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "OperationDefinition.purpose",
            "path": "OperationDefinition.purpose",
            "short": "Why this operation definition is defined",
            "definition": "Explanation of why this operation definition is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the operation definition. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this operation definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "OperationDefinition.affectsState",
            "path": "OperationDefinition.affectsState",
            "short": "Whether content is changed by the operation",
            "definition": "Whether the operation affects state. Side effects such as producing audit trail entries do not count as 'affecting  state'.",
            "comment": "What http methods can be used for the operation depends on the .affectsState value and whether the input parameters are primitive or complex:\n\n1. Servers SHALL support POST method for all operations.\n\n2. Servers SHALL support GET method if all the parameters for the operation are primitive or there are no parameters and the operation has affectsState = false.",
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
            "id": "OperationDefinition.code",
            "path": "OperationDefinition.code",
            "short": "Name used to invoke the operation",
            "definition": "The name used to invoke the operation.",
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
            "id": "OperationDefinition.comment",
            "path": "OperationDefinition.comment",
            "short": "Additional information about use",
            "definition": "Additional information about how to use this operation or named query.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "OperationDefinition.base",
            "path": "OperationDefinition.base",
            "short": "Marks this as a profile of the base",
            "definition": "Indicates that this operation definition is a constraining profile on the base.",
            "comment": "A constrained profile can make optional parameters required or not used and clarify documentation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/OperationDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "OperationDefinition.resource",
            "path": "OperationDefinition.resource",
            "short": "Types this operation applies to",
            "definition": "The types on which this operation can be executed.",
            "comment": "If the type is an abstract resource (\"Resource\" or \"DomainResource\") then the operation can be invoked on any concrete specialization.",
            "min": 0,
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
            "id": "OperationDefinition.system",
            "path": "OperationDefinition.system",
            "short": "Invoke at the system level?",
            "definition": "Indicates whether this operation or named query can be invoked at the system level (e.g. without needing to choose a resource type for the context).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "OperationDefinition.type",
            "path": "OperationDefinition.type",
            "short": "Invoke at the type level?",
            "definition": "Indicates whether this operation or named query can be invoked at the resource type level for any given resource type level (e.g. without needing to choose a specific resource id for the context).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "OperationDefinition.instance",
            "path": "OperationDefinition.instance",
            "short": "Invoke on an instance?",
            "definition": "Indicates whether this operation can be invoked on a particular instance of one of the given types.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isSummary": true
          },
          {
            "id": "OperationDefinition.inputProfile",
            "path": "OperationDefinition.inputProfile",
            "short": "Validation information for in parameters",
            "definition": "Additional validation information for the in parameters - a single profile that covers all the parameters. The profile is a constraint on the parameters resource as a whole.",
            "comment": "If present the profile shall not conflict with what is specified in the parameters in the operation definition (max/min etc.), though it may provide additional constraints. The constraints expressed in the profile apply whether the operation is invoked by a POST wih parameters or not.",
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
            "id": "OperationDefinition.outputProfile",
            "path": "OperationDefinition.outputProfile",
            "short": "Validation information for out parameters",
            "definition": "Additional validation information for the out parameters - a single profile that covers all the parameters. The profile is a constraint on the parameters resource.",
            "comment": "If present the profile shall not conflict with what is specified in the parameters in the operation definition (max/min etc.), though it may provide additional constraints. The constraints expressed in the profile apply whether the operation is invoked by a POST wih parameters or not.",
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
            "id": "OperationDefinition.parameter",
            "path": "OperationDefinition.parameter",
            "short": "Parameters for the operation/query",
            "definition": "The parameters for the operation/query.",
            "comment": "Query Definitions only have one output parameter, named \"result\". This might not be described, but can be to allow a profile to be defined.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "OperationDefinition.parameter.name",
            "path": "OperationDefinition.parameter.name",
            "short": "Name in Parameters.parameter.name or in URL",
            "definition": "The name of used to identify the parameter.",
            "comment": "This name must be a token (start with a letter in a..z, and only contain letters, numerals, and underscore. Note that for search parameters (type = string, with a search type), the name may be altered by the search modifiers.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ]
          },
          {
            "id": "OperationDefinition.parameter.use",
            "path": "OperationDefinition.parameter.use",
            "short": "in | out",
            "definition": "Whether this is an input or an output parameter.",
            "comment": "If a parameter name is used for both an input and an output parameter, the parameter should be defined twice.",
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
                  "valueString": "OperationParameterUse"
                }
              ],
              "strength": "required",
              "description": "Whether an operation parameter is an input or an output parameter.",
              "valueSet": "http://hl7.org/fhir/ValueSet/operation-parameter-use|4.0.0"
            }
          },
          {
            "id": "OperationDefinition.parameter.min",
            "path": "OperationDefinition.parameter.min",
            "short": "Minimum Cardinality",
            "definition": "The minimum number of times this parameter SHALL appear in the request or response.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "OperationDefinition.parameter.max",
            "path": "OperationDefinition.parameter.max",
            "short": "Maximum Cardinality (a number or *)",
            "definition": "The maximum number of times this element is permitted to appear in the request or response.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "OperationDefinition.parameter.documentation",
            "path": "OperationDefinition.parameter.documentation",
            "short": "Description of meaning/use",
            "definition": "Describes the meaning or use of this parameter.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "OperationDefinition.parameter.type",
            "path": "OperationDefinition.parameter.type",
            "short": "What type this parameter has",
            "definition": "The type for this parameter.",
            "comment": "if there is no stated parameter, then the parameter is a multi-part parameter; type and must have at least one part defined.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "condition": [
              "opd-1"
            ],
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
            "id": "OperationDefinition.parameter.targetProfile",
            "path": "OperationDefinition.parameter.targetProfile",
            "short": "If type is Reference | canonical, allowed targets",
            "definition": "Used when the type is \"Reference\" or \"canonical\", and identifies a profile structure or implementation Guide that applies to the target of the reference this parameter refers to. If any profiles are specified, then the content must conform to at least one of them. The URL can be a local reference - to a contained StructureDefinition, or a reference to another StructureDefinition or Implementation Guide by a canonical URL. When an implementation guide is specified, the target resource SHALL conform to at least one profile defined in the implementation guide.",
            "comment": "Often, these profiles are the base definitions from the spec (e.g. http://hl7.org/fhir/StructureDefinition/Patient).",
            "min": 0,
            "max": "*",
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
            "id": "OperationDefinition.parameter.searchType",
            "path": "OperationDefinition.parameter.searchType",
            "short": "number | date | string | token | reference | composite | quantity | uri | special",
            "definition": "How the parameter is understood as a search parameter. This is only used if the parameter type is 'string'.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "condition": [
              "opd-2"
            ],
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
            "id": "OperationDefinition.parameter.binding",
            "path": "OperationDefinition.parameter.binding",
            "short": "ValueSet details if this is coded",
            "definition": "Binds to a value set if this parameter is coded (code, Coding, CodeableConcept).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "OperationDefinition.parameter.binding.strength",
            "path": "OperationDefinition.parameter.binding.strength",
            "short": "required | extensible | preferred | example",
            "definition": "Indicates the degree of conformance expectations associated with this binding - that is, the degree to which the provided value set must be adhered to in the instances.",
            "comment": "For further discussion, see [Using Terminologies](terminologies.html).",
            "alias": [
              "conformance",
              "extensibility"
            ],
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
                  "valueString": "BindingStrength"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "Indication of the degree of conformance expectations associated with a binding.",
              "valueSet": "http://hl7.org/fhir/ValueSet/binding-strength|4.0.0"
            }
          },
          {
            "id": "OperationDefinition.parameter.binding.valueSet",
            "path": "OperationDefinition.parameter.binding.valueSet",
            "short": "Source of value set",
            "definition": "Points to the value set or external definition (e.g. implicit value set) that identifies the set of codes to be used.",
            "comment": "For value sets with a referenceResource, the display can contain the value set description.  The reference may be version-specific or not.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ValueSet"
                ]
              }
            ]
          },
          {
            "id": "OperationDefinition.parameter.referencedFrom",
            "path": "OperationDefinition.parameter.referencedFrom",
            "short": "References to this parameter",
            "definition": "Identifies other resource parameters within the operation invocation that are expected to resolve to this resource.",
            "comment": "Resolution applies if the referenced parameter exists.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "OperationDefinition.parameter.referencedFrom.source",
            "path": "OperationDefinition.parameter.referencedFrom.source",
            "short": "Referencing parameter",
            "definition": "The name of the parameter or dot-separated path of parameter names pointing to the resource parameter that is expected to contain a reference to this resource.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "OperationDefinition.parameter.referencedFrom.sourceId",
            "path": "OperationDefinition.parameter.referencedFrom.sourceId",
            "short": "Element id of reference",
            "definition": "The id of the element in the referencing resource that is expected to resolve to this resource.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "OperationDefinition.parameter.part",
            "path": "OperationDefinition.parameter.part",
            "short": "Parts of a nested Parameter",
            "definition": "The parts of a nested Parameter.",
            "comment": "Query Definitions only have one output parameter, named \"result\". This might not be described, but can be to allow a profile to be defined.",
            "min": 0,
            "max": "*",
            "contentReference": "#OperationDefinition.parameter",
            "condition": [
              "opd-1"
            ]
          },
          {
            "id": "OperationDefinition.overload",
            "path": "OperationDefinition.overload",
            "short": "Define overloaded variants for when  generating code",
            "definition": "Defines an appropriate combination of parameters to use when invoking this operation, to help code generators when generating overloaded parameter sets for this operation.",
            "comment": "The combinations are suggestions as to which sets of parameters to use together, but the combinations are not intended to be authoritative.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "OperationDefinition.overload.parameterName",
            "path": "OperationDefinition.overload.parameterName",
            "short": "Name of parameter to include in overload",
            "definition": "Name of parameter to include in overload.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "OperationDefinition.overload.comment",
            "path": "OperationDefinition.overload.comment",
            "short": "Comments to go on overload",
            "definition": "Comments to go on overload.",
            "min": 0,
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
    #endregion
    /// <summary>
    /// Fhir resource 'OperationDefinition'
    /// </summary>
    // 0. OperationDefinition
    public class Resource_OperationDefinition : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 25. OperationDefinition.parameter
        public class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 34. OperationDefinition.parameter.binding
            public class Type_Binding : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 35. OperationDefinition.parameter.binding.strength
                public ElementDefinitionInfo Element_Strength;
                // 36. OperationDefinition.parameter.binding.valueSet
                public ElementDefinitionInfo Element_ValueSet;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "OperationDefinition.parameter.binding",
                        ElementId = "OperationDefinition.parameter.binding"
                    });
                    Element_Strength.Write(sDef);
                    Element_ValueSet.Write(sDef);
                }
                
                public Type_Binding()
                {
                    {
                        // 35. OperationDefinition.parameter.binding.strength
                        this.Element_Strength = new ElementDefinitionInfo
                        {
                            Name = "Element_Strength",
                            Path= "OperationDefinition.parameter.binding.strength",
                            Id = "OperationDefinition.parameter.binding.strength",
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
                        // 36. OperationDefinition.parameter.binding.valueSet
                        this.Element_ValueSet = new ElementDefinitionInfo
                        {
                            Name = "Element_ValueSet",
                            Path= "OperationDefinition.parameter.binding.valueSet",
                            Id = "OperationDefinition.parameter.binding.valueSet",
                            Min = 1,
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
                }
            }
            // 37. OperationDefinition.parameter.referencedFrom
            public class Type_ReferencedFrom : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 38. OperationDefinition.parameter.referencedFrom.source
                public ElementDefinitionInfo Element_Source;
                // 39. OperationDefinition.parameter.referencedFrom.sourceId
                public ElementDefinitionInfo Element_SourceId;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "OperationDefinition.parameter.referencedFrom",
                        ElementId = "OperationDefinition.parameter.referencedFrom"
                    });
                    Element_Source.Write(sDef);
                    Element_SourceId.Write(sDef);
                }
                
                public Type_ReferencedFrom()
                {
                    {
                        // 38. OperationDefinition.parameter.referencedFrom.source
                        this.Element_Source = new ElementDefinitionInfo
                        {
                            Name = "Element_Source",
                            Path= "OperationDefinition.parameter.referencedFrom.source",
                            Id = "OperationDefinition.parameter.referencedFrom.source",
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
                        // 39. OperationDefinition.parameter.referencedFrom.sourceId
                        this.Element_SourceId = new ElementDefinitionInfo
                        {
                            Name = "Element_SourceId",
                            Path= "OperationDefinition.parameter.referencedFrom.sourceId",
                            Id = "OperationDefinition.parameter.referencedFrom.sourceId",
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
            // 26. OperationDefinition.parameter.name
            public ElementDefinitionInfo Element_Name;
            // 27. OperationDefinition.parameter.use
            public ElementDefinitionInfo Element_Use;
            // 28. OperationDefinition.parameter.min
            public ElementDefinitionInfo Element_Min;
            // 29. OperationDefinition.parameter.max
            public ElementDefinitionInfo Element_Max;
            // 30. OperationDefinition.parameter.documentation
            public ElementDefinitionInfo Element_Documentation;
            // 31. OperationDefinition.parameter.type
            public ElementDefinitionInfo Element_Type;
            // 32. OperationDefinition.parameter.targetProfile
            public ElementDefinitionInfo Element_TargetProfile;
            // 33. OperationDefinition.parameter.searchType
            public ElementDefinitionInfo Element_SearchType;
            // 34. OperationDefinition.parameter.binding
            public ElementDefinitionInfo Element_Binding;
            // 37. OperationDefinition.parameter.referencedFrom
            public ElementDefinitionInfo Element_ReferencedFrom;
            // 40. OperationDefinition.parameter.part
            public ElementDefinitionInfo Element_Part;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "OperationDefinition.parameter",
                    ElementId = "OperationDefinition.parameter"
                });
                Element_Name.Write(sDef);
                Element_Use.Write(sDef);
                Element_Min.Write(sDef);
                Element_Max.Write(sDef);
                Element_Documentation.Write(sDef);
                Element_Type.Write(sDef);
                Element_TargetProfile.Write(sDef);
                Element_SearchType.Write(sDef);
                Element_Binding.Write(sDef);
                Element_ReferencedFrom.Write(sDef);
                Element_Part.Write(sDef);
            }
            
            public Type_Parameter()
            {
                {
                    // 26. OperationDefinition.parameter.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "OperationDefinition.parameter.name",
                        Id = "OperationDefinition.parameter.name",
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
                    // 27. OperationDefinition.parameter.use
                    this.Element_Use = new ElementDefinitionInfo
                    {
                        Name = "Element_Use",
                        Path= "OperationDefinition.parameter.use",
                        Id = "OperationDefinition.parameter.use",
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
                    // 28. OperationDefinition.parameter.min
                    this.Element_Min = new ElementDefinitionInfo
                    {
                        Name = "Element_Min",
                        Path= "OperationDefinition.parameter.min",
                        Id = "OperationDefinition.parameter.min",
                        Min = 1,
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
                    // 29. OperationDefinition.parameter.max
                    this.Element_Max = new ElementDefinitionInfo
                    {
                        Name = "Element_Max",
                        Path= "OperationDefinition.parameter.max",
                        Id = "OperationDefinition.parameter.max",
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
                    // 30. OperationDefinition.parameter.documentation
                    this.Element_Documentation = new ElementDefinitionInfo
                    {
                        Name = "Element_Documentation",
                        Path= "OperationDefinition.parameter.documentation",
                        Id = "OperationDefinition.parameter.documentation",
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
                    // 31. OperationDefinition.parameter.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "OperationDefinition.parameter.type",
                        Id = "OperationDefinition.parameter.type",
                        Min = 0,
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
                    // 32. OperationDefinition.parameter.targetProfile
                    this.Element_TargetProfile = new ElementDefinitionInfo
                    {
                        Name = "Element_TargetProfile",
                        Path= "OperationDefinition.parameter.targetProfile",
                        Id = "OperationDefinition.parameter.targetProfile",
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
                    // 33. OperationDefinition.parameter.searchType
                    this.Element_SearchType = new ElementDefinitionInfo
                    {
                        Name = "Element_SearchType",
                        Path= "OperationDefinition.parameter.searchType",
                        Id = "OperationDefinition.parameter.searchType",
                        Min = 0,
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
                    // 34. OperationDefinition.parameter.binding
                    this.Element_Binding = new ElementDefinitionInfo
                    {
                        Name = "Element_Binding",
                        Path= "OperationDefinition.parameter.binding",
                        Id = "OperationDefinition.parameter.binding",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new Type_Binding
                            {
                            }
                        }
                    };
                }
                {
                    // 37. OperationDefinition.parameter.referencedFrom
                    this.Element_ReferencedFrom = new ElementDefinitionInfo
                    {
                        Name = "Element_ReferencedFrom",
                        Path= "OperationDefinition.parameter.referencedFrom",
                        Id = "OperationDefinition.parameter.referencedFrom",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_ReferencedFrom
                            {
                            }
                        }
                    };
                }
                {
                    // 40. OperationDefinition.parameter.part
                    this.Element_Part = new ElementDefinitionInfo
                    {
                        Name = "Element_Part",
                        Path= "OperationDefinition.parameter.part",
                        Id = "OperationDefinition.parameter.part",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
            }
        }
        // 41. OperationDefinition.overload
        public class Type_Overload : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 42. OperationDefinition.overload.parameterName
            public ElementDefinitionInfo Element_ParameterName;
            // 43. OperationDefinition.overload.comment
            public ElementDefinitionInfo Element_Comment;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "OperationDefinition.overload",
                    ElementId = "OperationDefinition.overload"
                });
                Element_ParameterName.Write(sDef);
                Element_Comment.Write(sDef);
            }
            
            public Type_Overload()
            {
                {
                    // 42. OperationDefinition.overload.parameterName
                    this.Element_ParameterName = new ElementDefinitionInfo
                    {
                        Name = "Element_ParameterName",
                        Path= "OperationDefinition.overload.parameterName",
                        Id = "OperationDefinition.overload.parameterName",
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
                    // 43. OperationDefinition.overload.comment
                    this.Element_Comment = new ElementDefinitionInfo
                    {
                        Name = "Element_Comment",
                        Path= "OperationDefinition.overload.comment",
                        Id = "OperationDefinition.overload.comment",
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
        // 1. OperationDefinition.url
        public ElementDefinitionInfo Element_Url;
        // 2. OperationDefinition.version
        public ElementDefinitionInfo Element_Version;
        // 3. OperationDefinition.name
        public ElementDefinitionInfo Element_Name;
        // 4. OperationDefinition.title
        public ElementDefinitionInfo Element_Title;
        // 5. OperationDefinition.status
        public ElementDefinitionInfo Element_Status;
        // 6. OperationDefinition.kind
        public ElementDefinitionInfo Element_Kind;
        // 7. OperationDefinition.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 8. OperationDefinition.date
        public ElementDefinitionInfo Element_Date;
        // 9. OperationDefinition.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 10. OperationDefinition.contact
        public ElementDefinitionInfo Element_Contact;
        // 11. OperationDefinition.description
        public ElementDefinitionInfo Element_Description;
        // 12. OperationDefinition.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 13. OperationDefinition.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 14. OperationDefinition.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 15. OperationDefinition.affectsState
        public ElementDefinitionInfo Element_AffectsState;
        // 16. OperationDefinition.code
        public ElementDefinitionInfo Element_Code;
        // 17. OperationDefinition.comment
        public ElementDefinitionInfo Element_Comment;
        // 18. OperationDefinition.base
        public ElementDefinitionInfo Element_Base;
        // 19. OperationDefinition.resource
        public ElementDefinitionInfo Element_Resource;
        // 20. OperationDefinition.system
        public ElementDefinitionInfo Element_System;
        // 21. OperationDefinition.type
        public ElementDefinitionInfo Element_Type;
        // 22. OperationDefinition.instance
        public ElementDefinitionInfo Element_Instance;
        // 23. OperationDefinition.inputProfile
        public ElementDefinitionInfo Element_InputProfile;
        // 24. OperationDefinition.outputProfile
        public ElementDefinitionInfo Element_OutputProfile;
        // 25. OperationDefinition.parameter
        public ElementDefinitionInfo Element_Parameter;
        // 41. OperationDefinition.overload
        public ElementDefinitionInfo Element_Overload;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "OperationDefinition",
                ElementId = "OperationDefinition"
            });
            Element_Url.Write(sDef);
            Element_Version.Write(sDef);
            Element_Name.Write(sDef);
            Element_Title.Write(sDef);
            Element_Status.Write(sDef);
            Element_Kind.Write(sDef);
            Element_Experimental.Write(sDef);
            Element_Date.Write(sDef);
            Element_Publisher.Write(sDef);
            Element_Contact.Write(sDef);
            Element_Description.Write(sDef);
            Element_UseContext.Write(sDef);
            Element_Jurisdiction.Write(sDef);
            Element_Purpose.Write(sDef);
            Element_AffectsState.Write(sDef);
            Element_Code.Write(sDef);
            Element_Comment.Write(sDef);
            Element_Base.Write(sDef);
            Element_Resource.Write(sDef);
            Element_System.Write(sDef);
            Element_Type.Write(sDef);
            Element_Instance.Write(sDef);
            Element_InputProfile.Write(sDef);
            Element_OutputProfile.Write(sDef);
            Element_Parameter.Write(sDef);
            Element_Overload.Write(sDef);
        }
        
        public Resource_OperationDefinition()
        {
            {
                // 1. OperationDefinition.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "OperationDefinition.url",
                    Id = "OperationDefinition.url",
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
                // 2. OperationDefinition.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "OperationDefinition.version",
                    Id = "OperationDefinition.version",
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
                // 3. OperationDefinition.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "OperationDefinition.name",
                    Id = "OperationDefinition.name",
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
                // 4. OperationDefinition.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "OperationDefinition.title",
                    Id = "OperationDefinition.title",
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
                // 5. OperationDefinition.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "OperationDefinition.status",
                    Id = "OperationDefinition.status",
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
                // 6. OperationDefinition.kind
                this.Element_Kind = new ElementDefinitionInfo
                {
                    Name = "Element_Kind",
                    Path= "OperationDefinition.kind",
                    Id = "OperationDefinition.kind",
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
                // 7. OperationDefinition.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "OperationDefinition.experimental",
                    Id = "OperationDefinition.experimental",
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
                // 8. OperationDefinition.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "OperationDefinition.date",
                    Id = "OperationDefinition.date",
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
                // 9. OperationDefinition.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "OperationDefinition.publisher",
                    Id = "OperationDefinition.publisher",
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
                // 10. OperationDefinition.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "OperationDefinition.contact",
                    Id = "OperationDefinition.contact",
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
                // 11. OperationDefinition.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "OperationDefinition.description",
                    Id = "OperationDefinition.description",
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
                // 12. OperationDefinition.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "OperationDefinition.useContext",
                    Id = "OperationDefinition.useContext",
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
                // 13. OperationDefinition.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "OperationDefinition.jurisdiction",
                    Id = "OperationDefinition.jurisdiction",
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
                // 14. OperationDefinition.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "OperationDefinition.purpose",
                    Id = "OperationDefinition.purpose",
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
                // 15. OperationDefinition.affectsState
                this.Element_AffectsState = new ElementDefinitionInfo
                {
                    Name = "Element_AffectsState",
                    Path= "OperationDefinition.affectsState",
                    Id = "OperationDefinition.affectsState",
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
                // 16. OperationDefinition.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "OperationDefinition.code",
                    Id = "OperationDefinition.code",
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
                // 17. OperationDefinition.comment
                this.Element_Comment = new ElementDefinitionInfo
                {
                    Name = "Element_Comment",
                    Path= "OperationDefinition.comment",
                    Id = "OperationDefinition.comment",
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
                // 18. OperationDefinition.base
                this.Element_Base = new ElementDefinitionInfo
                {
                    Name = "Element_Base",
                    Path= "OperationDefinition.base",
                    Id = "OperationDefinition.base",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/OperationDefinition"
                            }
                        }
                    }
                };
            }
            {
                // 19. OperationDefinition.resource
                this.Element_Resource = new ElementDefinitionInfo
                {
                    Name = "Element_Resource",
                    Path= "OperationDefinition.resource",
                    Id = "OperationDefinition.resource",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 20. OperationDefinition.system
                this.Element_System = new ElementDefinitionInfo
                {
                    Name = "Element_System",
                    Path= "OperationDefinition.system",
                    Id = "OperationDefinition.system",
                    Min = 1,
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
                // 21. OperationDefinition.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "OperationDefinition.type",
                    Id = "OperationDefinition.type",
                    Min = 1,
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
                // 22. OperationDefinition.instance
                this.Element_Instance = new ElementDefinitionInfo
                {
                    Name = "Element_Instance",
                    Path= "OperationDefinition.instance",
                    Id = "OperationDefinition.instance",
                    Min = 1,
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
                // 23. OperationDefinition.inputProfile
                this.Element_InputProfile = new ElementDefinitionInfo
                {
                    Name = "Element_InputProfile",
                    Path= "OperationDefinition.inputProfile",
                    Id = "OperationDefinition.inputProfile",
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
                // 24. OperationDefinition.outputProfile
                this.Element_OutputProfile = new ElementDefinitionInfo
                {
                    Name = "Element_OutputProfile",
                    Path= "OperationDefinition.outputProfile",
                    Id = "OperationDefinition.outputProfile",
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
                // 25. OperationDefinition.parameter
                this.Element_Parameter = new ElementDefinitionInfo
                {
                    Name = "Element_Parameter",
                    Path= "OperationDefinition.parameter",
                    Id = "OperationDefinition.parameter",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Parameter
                        {
                        }
                    }
                };
            }
            {
                // 41. OperationDefinition.overload
                this.Element_Overload = new ElementDefinitionInfo
                {
                    Name = "Element_Overload",
                    Path= "OperationDefinition.overload",
                    Id = "OperationDefinition.overload",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Overload
                        {
                        }
                    }
                };
            }
            this.Name = "OperationDefinition";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/OperationDefinition";
        }
    }
}
