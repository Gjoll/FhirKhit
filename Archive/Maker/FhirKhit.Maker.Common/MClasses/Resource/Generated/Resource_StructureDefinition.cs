using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
    {
      "resourceType": "StructureDefinition",
      "id": "StructureDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/StructureDefinition",
      "version": "4.0.0",
      "name": "StructureDefinition",
      "status": "active",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A definition of a FHIR structure. This resource is used to describe the underlying resources, data types defined in FHIR, and also for describing extensions and constraints on resources and data types.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "StructureDefinition",
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
            "id": "StructureDefinition",
            "path": "StructureDefinition",
            "short": "Structural Definition",
            "definition": "A definition of a FHIR structure. This resource is used to describe the underlying resources, data types defined in FHIR, and also for describing extensions and constraints on resources and data types.",
            "alias": [
              "Template",
              "Profile"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "StructureDefinition.url",
            "path": "StructureDefinition.url",
            "short": "Canonical identifier for this structure definition, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this structure definition when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this structure definition is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the structure definition is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the structure definition to be referenced by a single globally unique identifier.",
            "alias": [
              "url",
              "authoritative-url",
              "destination",
              "identity"
            ],
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
            "id": "StructureDefinition.identifier",
            "path": "StructureDefinition.identifier",
            "short": "Additional identifier for the structure definition",
            "definition": "A formal identifier that is used to identify this structure definition when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this structure definition outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "StructureDefinition.version",
            "path": "StructureDefinition.version",
            "short": "Business version of the structure definition",
            "definition": "The identifier that is used to identify this version of the structure definition when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the structure definition author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different structure definition instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the structure definition with the format [url]|[version].",
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
            "id": "StructureDefinition.name",
            "path": "StructureDefinition.name",
            "short": "Name for this structure definition (computer friendly)",
            "definition": "A natural language name identifying the structure definition. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
            "comment": "The name is not expected to be globally unique. The name should be a simple alphanumeric type name to ensure that it is machine-processing friendly.Some Examples: \n\n* O2SatObservation\n* PresentationReport\n* Immunization2\n* AcmeAdmissionRecordOld.",
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
            "id": "StructureDefinition.title",
            "path": "StructureDefinition.title",
            "short": "Name for this structure definition (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the structure definition.",
            "comment": "This name does not need to be machine-processing friendly and may contain punctuation, white-space, etc.Applications don't have to use this name but can always fall back to it. The title also corresponds to the label for the root element.",
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
            "id": "StructureDefinition.status",
            "path": "StructureDefinition.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this structure definition. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of structure definitions that are appropriate for use versus not.",
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
            "id": "StructureDefinition.experimental",
            "path": "StructureDefinition.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this structure definition is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of structure definitions that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level structure definition.",
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
            "id": "StructureDefinition.date",
            "path": "StructureDefinition.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the structure definition was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the structure definition changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the structure definition. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "StructureDefinition.publisher",
            "path": "StructureDefinition.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the structure definition.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the structure definition is the organization or individual primarily responsible for the maintenance and upkeep of the structure definition. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the structure definition. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the structure definition.  May also allow for contact.",
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
            "id": "StructureDefinition.contact",
            "path": "StructureDefinition.contact",
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
            "id": "StructureDefinition.description",
            "path": "StructureDefinition.description",
            "short": "Natural language description of the structure definition",
            "definition": "A free text natural language description of the structure definition from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the structure definition was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the structure definition as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the structure definition is presumed to be the predominant language in the place the structure definition was created).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "StructureDefinition.useContext",
            "path": "StructureDefinition.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate structure definition instances.",
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
            "id": "StructureDefinition.jurisdiction",
            "path": "StructureDefinition.jurisdiction",
            "short": "Intended jurisdiction for structure definition (if applicable)",
            "definition": "A legal or geographic region in which the structure definition is intended to be used.",
            "comment": "It may be possible for the structure definition to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "StructureDefinition.purpose",
            "path": "StructureDefinition.purpose",
            "short": "Why this structure definition is defined",
            "definition": "Explanation of why this structure definition is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the structure definition. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this structure definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "StructureDefinition.copyright",
            "path": "StructureDefinition.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the structure definition and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the structure definition.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the structure definition and/or its content.",
            "alias": [
              "License",
              "Restrictions"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "StructureDefinition.keyword",
            "path": "StructureDefinition.keyword",
            "short": "Assist with indexing and finding",
            "definition": "A set of key words or terms from external terminologies that may be used to assist with indexing and searching of templates nby describing the use of this structure definition, or the content it describes.",
            "requirements": "Assist in searching for appropriate StructureDefinitions.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "StructureDefinitionKeyword"
                }
              ],
              "strength": "extensible",
              "description": "Codes for the meaning of the defined structure (SNOMED CT and LOINC codes, as an example).",
              "valueSet": "http://hl7.org/fhir/ValueSet/definition-use"
            }
          },
          {
            "id": "StructureDefinition.fhirVersion",
            "path": "StructureDefinition.fhirVersion",
            "short": "FHIR Version this StructureDefinition targets",
            "definition": "The version of the FHIR specification on which this StructureDefinition is based - this is the formal version of the specification, without the revision number, e.g. [publication].[major].[minor], which is 4.0.0. for this version.",
            "comment": "A StructureDefinition does not need to specify the target it applies to as StructureDefinitions will often be valid across multiple versions of FHIR. FHIR tooling can determine whether a StructureDefinition is consistent with a particular StructureDefinition if desired.",
            "min": 0,
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
                  "valueString": "FHIRVersion"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "All published FHIR Versions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/FHIR-version|4.0.0"
            }
          },
          {
            "id": "StructureDefinition.mapping",
            "path": "StructureDefinition.mapping",
            "short": "External specification that the content is mapped to",
            "definition": "An external specification that the content is mapped to.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "StructureDefinition.mapping.identity",
            "path": "StructureDefinition.mapping.identity",
            "short": "Internal id when this mapping is used",
            "definition": "An Internal id that is used to identify this mapping set when specific mappings are made.",
            "comment": "The specification is described once, with general comments, and then specific mappings are made that reference this declaration.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ]
          },
          {
            "id": "StructureDefinition.mapping.uri",
            "path": "StructureDefinition.mapping.uri",
            "short": "Identifies what this mapping refers to",
            "definition": "An absolute URI that identifies the specification that this mapping is expressed to.",
            "comment": "A formal identity for the specification being mapped to helps with identifying maps consistently.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "condition": [
              "sdf-2"
            ]
          },
          {
            "id": "StructureDefinition.mapping.name",
            "path": "StructureDefinition.mapping.name",
            "short": "Names what this mapping refers to",
            "definition": "A name for the specification that is being mapped to.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "sdf-2"
            ]
          },
          {
            "id": "StructureDefinition.mapping.comment",
            "path": "StructureDefinition.mapping.comment",
            "short": "Versions, Issues, Scope limitations etc.",
            "definition": "Comments about this mapping, including version notes, issues, scope limitations, and other important notes for usage.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "StructureDefinition.kind",
            "path": "StructureDefinition.kind",
            "short": "primitive-type | complex-type | resource | logical",
            "definition": "Defines the kind of structure that this definition is describing.",
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
                  "valueString": "StructureDefinitionKind"
                }
              ],
              "strength": "required",
              "description": "Defines the type of structure that a definition is describing.",
              "valueSet": "http://hl7.org/fhir/ValueSet/structure-definition-kind|4.0.0"
            }
          },
          {
            "id": "StructureDefinition.abstract",
            "path": "StructureDefinition.abstract",
            "short": "Whether the structure is abstract",
            "definition": "Whether structure this definition describes is abstract or not  - that is, whether the structure is not intended to be instantiated. For Resources and Data types, abstract types will never be exchanged  between systems.",
            "comment": "Abstract Resources cannot be instantiated - a concrete sub-type must be used. Abstract datatypes and extensions cannot be used in an instance. For logical models, the exact implication of \"abstract\" will rest with the author, depending how the logical model is used. Flagging a constraint structure as abstract conveys design intent but makes no difference to how the structure definition is handled. Note that inline declared elements that are given the type \"Element\" in the StructureDefinition, but have children described, are anonymous concrete types that specialize Element.",
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
            "id": "StructureDefinition.context",
            "path": "StructureDefinition.context",
            "short": "If an extension, where it can be used in instances",
            "definition": "Identifies the types of resource or data type elements to which the extension can be applied.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "sdf-5"
            ],
            "isSummary": true
          },
          {
            "id": "StructureDefinition.context.type",
            "path": "StructureDefinition.context.type",
            "short": "fhirpath | element | extension",
            "definition": "Defines how to interpret the expression that defines what the context of the extension is.",
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
                  "valueString": "ExtensionContextType"
                }
              ],
              "strength": "required",
              "description": "How an extension context is interpreted.",
              "valueSet": "http://hl7.org/fhir/ValueSet/extension-context-type|4.0.0"
            }
          },
          {
            "id": "StructureDefinition.context.expression",
            "path": "StructureDefinition.context.expression",
            "short": "Where the extension can be used in instances",
            "definition": "An expression that defines where an extension can be used in resources.",
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
            "id": "StructureDefinition.contextInvariant",
            "path": "StructureDefinition.contextInvariant",
            "short": "FHIRPath invariants - when the extension can be used",
            "definition": "A set of rules as FHIRPath Invariants about when the extension can be used (e.g. co-occurrence variants for the extension). All the rules must be true.",
            "comment": "The rules are only evaluated when the extension is present. When evaluating the invariant, the FHIRPath focus is the element that holds the extension, and %extension refers to the extension itself.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "sdf-18"
            ],
            "isSummary": true
          },
          {
            "id": "StructureDefinition.type",
            "path": "StructureDefinition.type",
            "short": "Type defined or constrained by this structure",
            "definition": "The type this structure describes. If the derivation kind is 'specialization' then this is the master definition for a type, and there is always one of these (a data type, an extension, a resource, including abstract ones). Otherwise the structure definition is a constraint on the stated type (and in this case, the type cannot be an abstract type).  References are URLs that are relative to http://hl7.org/fhir/StructureDefinition e.g. \"string\" is a reference to http://hl7.org/fhir/StructureDefinition/string. Absolute URLs are only allowed in logical models.",
            "comment": "Note that in the case of constraints, the type could be determined by chasing through the baseDefinition references until a concrete structure (derivation = specialization) is reached, or by looking at the path of the first element in the snapshot - if present - but providing the type directly makes for simpler tooling and indexing. \n\nThe type must match the elements defined in the differential and the snapshot. For all FHIR defined types, the path name of the element will start with the type name. For logical models, where the type is a URL, the type name SHOULD start with the tail of the type URL where required.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "condition": [
              "sdf-11"
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "FHIRDefinedTypeExt"
                }
              ],
              "strength": "extensible",
              "description": "Either a resource or a data type, including logical model types.",
              "valueSet": "http://hl7.org/fhir/ValueSet/defined-types"
            }
          },
          {
            "id": "StructureDefinition.baseDefinition",
            "path": "StructureDefinition.baseDefinition",
            "short": "Definition that this type is constrained/specialized from",
            "definition": "An absolute URI that is the base structure from which this type is derived, either by specialization or constraint.",
            "comment": "If differential constraints are specified in this structure, they are applied to the base in a \"differential\" fashion. If there is no base, then the differential constraints cannot be provided (snapshot only). Differential structures are useful for the editing perspective, and snapshot structures are suitable for operational use. The FHIR Project provides a number of tools/services to populate snapshots from differential constraints. Logical Models have a base of \"Element\" or another logical model.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "extension": [
                  {
                    "url": "http://hl7.org/fhir/StructureDefinition/structuredefinition-hierarchy",
                    "valueBoolean": true
                  }
                ],
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
                ]
              }
            ],
            "condition": [
              "sdf-4"
            ],
            "isSummary": true
          },
          {
            "id": "StructureDefinition.derivation",
            "path": "StructureDefinition.derivation",
            "short": "specialization | constraint - How relates to base definition",
            "definition": "How the type relates to the baseDefinition.",
            "comment": "If the definition is a specialization, then it adds new elements in the differential, and the snapshot includes the inherited elements.  If the definition is a constraint, then it cannot define new elements, it can only make new rules about existing content (see [Profiling Resources](profiling.html#resources)).",
            "min": 0,
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
                  "valueString": "TypeDerivationRule"
                }
              ],
              "strength": "required",
              "description": "How a type relates to its baseDefinition.",
              "valueSet": "http://hl7.org/fhir/ValueSet/type-derivation-rule|4.0.0"
            }
          },
          {
            "id": "StructureDefinition.snapshot",
            "path": "StructureDefinition.snapshot",
            "short": "Snapshot view of the structure",
            "definition": "A snapshot view is expressed in a standalone form that can be used and interpreted without considering the base StructureDefinition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "sdf-6"
            ]
          },
          {
            "id": "StructureDefinition.snapshot.element",
            "path": "StructureDefinition.snapshot.element",
            "short": "Definition of elements in the resource (if no StructureDefinition)",
            "definition": "Captures constraints on each element within the resource.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "ElementDefinition"
              }
            ],
            "condition": [
              "sdf-3"
            ]
          },
          {
            "id": "StructureDefinition.differential",
            "path": "StructureDefinition.differential",
            "short": "Differential view of the structure",
            "definition": "A differential view is expressed relative to the base StructureDefinition - a statement of differences that it applies.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "sdf-6"
            ]
          },
          {
            "id": "StructureDefinition.differential.element",
            "path": "StructureDefinition.differential.element",
            "short": "Definition of elements in the resource (if no StructureDefinition)",
            "definition": "Captures constraints on each element within the resource.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "ElementDefinition"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'StructureDefinition'
    /// </summary>
    // 0. StructureDefinition
    public partial class Resource_StructureDefinition : FhirKhit.Maker.Common.Resource.Resource_DomainResource                              // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 18. StructureDefinition.mapping
        public partial class Type_Mapping : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 19. StructureDefinition.mapping.identity
            public ElementDefinitionInfo Element_Identity;                                                                                  // MakerGen.cs:217
            // 20. StructureDefinition.mapping.uri
            public ElementDefinitionInfo Element_Uri;                                                                                       // MakerGen.cs:217
            // 21. StructureDefinition.mapping.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:217
            // 22. StructureDefinition.mapping.comment
            public ElementDefinitionInfo Element_Comment;                                                                                   // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "StructureDefinition.mapping",                                                                                   // MakerGen.cs:393
                    ElementId = "StructureDefinition.mapping"                                                                               // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Identity.Write(sDef);                                                                                               // MakerGen.cs:221
                Element_Uri.Write(sDef);                                                                                                    // MakerGen.cs:221
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Comment.Write(sDef);                                                                                                // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Mapping()                                                                                                           // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 19. StructureDefinition.mapping.identity
                    this.Element_Identity = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Identity",                                                                                          // MakerGen.cs:236
                        Path= "StructureDefinition.mapping.identity",                                                                       // MakerGen.cs:237
                        Id = "StructureDefinition.mapping.identity",                                                                        // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Id                                                                // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 20. StructureDefinition.mapping.uri
                    this.Element_Uri = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Uri",                                                                                               // MakerGen.cs:236
                        Path= "StructureDefinition.mapping.uri",                                                                            // MakerGen.cs:237
                        Id = "StructureDefinition.mapping.uri",                                                                             // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                               // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 21. StructureDefinition.mapping.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Name",                                                                                              // MakerGen.cs:236
                        Path= "StructureDefinition.mapping.name",                                                                           // MakerGen.cs:237
                        Id = "StructureDefinition.mapping.name",                                                                            // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 22. StructureDefinition.mapping.comment
                    this.Element_Comment = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Comment",                                                                                           // MakerGen.cs:236
                        Path= "StructureDefinition.mapping.comment",                                                                        // MakerGen.cs:237
                        Id = "StructureDefinition.mapping.comment",                                                                         // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 25. StructureDefinition.context
        public partial class Type_Context : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 26. StructureDefinition.context.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:217
            // 27. StructureDefinition.context.expression
            public ElementDefinitionInfo Element_Expression;                                                                                // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "StructureDefinition.context",                                                                                   // MakerGen.cs:393
                    ElementId = "StructureDefinition.context"                                                                               // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Expression.Write(sDef);                                                                                             // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Context()                                                                                                           // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 26. StructureDefinition.context.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Type",                                                                                              // MakerGen.cs:236
                        Path= "StructureDefinition.context.type",                                                                           // MakerGen.cs:237
                        Id = "StructureDefinition.context.type",                                                                            // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 27. StructureDefinition.context.expression
                    this.Element_Expression = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Expression",                                                                                        // MakerGen.cs:236
                        Path= "StructureDefinition.context.expression",                                                                     // MakerGen.cs:237
                        Id = "StructureDefinition.context.expression",                                                                      // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 32. StructureDefinition.snapshot
        public partial class Type_Snapshot : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 33. StructureDefinition.snapshot.element
            public ElementDefinitionInfo Element_Element;                                                                                   // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "StructureDefinition.snapshot",                                                                                  // MakerGen.cs:393
                    ElementId = "StructureDefinition.snapshot"                                                                              // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Element.Write(sDef);                                                                                                // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Snapshot()                                                                                                          // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 33. StructureDefinition.snapshot.element
                    this.Element_Element = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Element",                                                                                           // MakerGen.cs:236
                        Path= "StructureDefinition.snapshot.element",                                                                       // MakerGen.cs:237
                        Id = "StructureDefinition.snapshot.element",                                                                        // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_ElementDefinition                                                        // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 34. StructureDefinition.differential
        public partial class Type_Differential : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 35. StructureDefinition.differential.element
            public ElementDefinitionInfo Element_Element;                                                                                   // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "StructureDefinition.differential",                                                                              // MakerGen.cs:393
                    ElementId = "StructureDefinition.differential"                                                                          // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Element.Write(sDef);                                                                                                // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Differential()                                                                                                      // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 35. StructureDefinition.differential.element
                    this.Element_Element = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Element",                                                                                           // MakerGen.cs:236
                        Path= "StructureDefinition.differential.element",                                                                   // MakerGen.cs:237
                        Id = "StructureDefinition.differential.element",                                                                    // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_ElementDefinition                                                        // MakerGen.cs:356
                            {                                                                                                               // MakerGen.cs:357
                            }                                                                                                               // MakerGen.cs:358
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. StructureDefinition.url
        public ElementDefinitionInfo Element_Url;                                                                                           // MakerGen.cs:217
        // 2. StructureDefinition.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 3. StructureDefinition.version
        public ElementDefinitionInfo Element_Version;                                                                                       // MakerGen.cs:217
        // 4. StructureDefinition.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:217
        // 5. StructureDefinition.title
        public ElementDefinitionInfo Element_Title;                                                                                         // MakerGen.cs:217
        // 6. StructureDefinition.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:217
        // 7. StructureDefinition.experimental
        public ElementDefinitionInfo Element_Experimental;                                                                                  // MakerGen.cs:217
        // 8. StructureDefinition.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:217
        // 9. StructureDefinition.publisher
        public ElementDefinitionInfo Element_Publisher;                                                                                     // MakerGen.cs:217
        // 10. StructureDefinition.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:217
        // 11. StructureDefinition.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:217
        // 12. StructureDefinition.useContext
        public ElementDefinitionInfo Element_UseContext;                                                                                    // MakerGen.cs:217
        // 13. StructureDefinition.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;                                                                                  // MakerGen.cs:217
        // 14. StructureDefinition.purpose
        public ElementDefinitionInfo Element_Purpose;                                                                                       // MakerGen.cs:217
        // 15. StructureDefinition.copyright
        public ElementDefinitionInfo Element_Copyright;                                                                                     // MakerGen.cs:217
        // 16. StructureDefinition.keyword
        public ElementDefinitionInfo Element_Keyword;                                                                                       // MakerGen.cs:217
        // 17. StructureDefinition.fhirVersion
        public ElementDefinitionInfo Element_FhirVersion;                                                                                   // MakerGen.cs:217
        // 18. StructureDefinition.mapping
        public ElementDefinitionInfo Element_Mapping;                                                                                       // MakerGen.cs:217
        // 23. StructureDefinition.kind
        public ElementDefinitionInfo Element_Kind;                                                                                          // MakerGen.cs:217
        // 24. StructureDefinition.abstract
        public ElementDefinitionInfo Element_Abstract;                                                                                      // MakerGen.cs:217
        // 25. StructureDefinition.context
        public ElementDefinitionInfo Element_Context;                                                                                       // MakerGen.cs:217
        // 28. StructureDefinition.contextInvariant
        public ElementDefinitionInfo Element_ContextInvariant;                                                                              // MakerGen.cs:217
        // 29. StructureDefinition.type
        public ElementDefinitionInfo Element_Type;                                                                                          // MakerGen.cs:217
        // 30. StructureDefinition.baseDefinition
        public ElementDefinitionInfo Element_BaseDefinition;                                                                                // MakerGen.cs:217
        // 31. StructureDefinition.derivation
        public ElementDefinitionInfo Element_Derivation;                                                                                    // MakerGen.cs:217
        // 32. StructureDefinition.snapshot
        public ElementDefinitionInfo Element_Snapshot;                                                                                      // MakerGen.cs:217
        // 34. StructureDefinition.differential
        public ElementDefinitionInfo Element_Differential;                                                                                  // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "StructureDefinition",                                                                                               // MakerGen.cs:393
                ElementId = "StructureDefinition"                                                                                           // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Url.Write(sDef);                                                                                                        // MakerGen.cs:221
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Version.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Title.Write(sDef);                                                                                                      // MakerGen.cs:221
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Experimental.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_Date.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Publisher.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Contact.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Description.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_UseContext.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Jurisdiction.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_Purpose.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Copyright.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Keyword.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_FhirVersion.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_Mapping.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Kind.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Abstract.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_Context.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_ContextInvariant.Write(sDef);                                                                                           // MakerGen.cs:221
            Element_Type.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_BaseDefinition.Write(sDef);                                                                                             // MakerGen.cs:221
            Element_Derivation.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Snapshot.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_Differential.Write(sDef);                                                                                               // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_StructureDefinition()                                                                                               // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. StructureDefinition.url
                this.Element_Url = new ElementDefinitionInfo                                                                                // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:236
                    Path= "StructureDefinition.url",                                                                                        // MakerGen.cs:237
                    Id = "StructureDefinition.url",                                                                                         // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. StructureDefinition.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "StructureDefinition.identifier",                                                                                 // MakerGen.cs:237
                    Id = "StructureDefinition.identifier",                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. StructureDefinition.version
                this.Element_Version = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Version",                                                                                               // MakerGen.cs:236
                    Path= "StructureDefinition.version",                                                                                    // MakerGen.cs:237
                    Id = "StructureDefinition.version",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. StructureDefinition.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:236
                    Path= "StructureDefinition.name",                                                                                       // MakerGen.cs:237
                    Id = "StructureDefinition.name",                                                                                        // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. StructureDefinition.title
                this.Element_Title = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Title",                                                                                                 // MakerGen.cs:236
                    Path= "StructureDefinition.title",                                                                                      // MakerGen.cs:237
                    Id = "StructureDefinition.title",                                                                                       // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. StructureDefinition.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Status",                                                                                                // MakerGen.cs:236
                    Path= "StructureDefinition.status",                                                                                     // MakerGen.cs:237
                    Id = "StructureDefinition.status",                                                                                      // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. StructureDefinition.experimental
                this.Element_Experimental = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Experimental",                                                                                          // MakerGen.cs:236
                    Path= "StructureDefinition.experimental",                                                                               // MakerGen.cs:237
                    Id = "StructureDefinition.experimental",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 8. StructureDefinition.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:236
                    Path= "StructureDefinition.date",                                                                                       // MakerGen.cs:237
                    Id = "StructureDefinition.date",                                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 9. StructureDefinition.publisher
                this.Element_Publisher = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:236
                    Path= "StructureDefinition.publisher",                                                                                  // MakerGen.cs:237
                    Id = "StructureDefinition.publisher",                                                                                   // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 10. StructureDefinition.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:236
                    Path= "StructureDefinition.contact",                                                                                    // MakerGen.cs:237
                    Id = "StructureDefinition.contact",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 11. StructureDefinition.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Description",                                                                                           // MakerGen.cs:236
                    Path= "StructureDefinition.description",                                                                                // MakerGen.cs:237
                    Id = "StructureDefinition.description",                                                                                 // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 12. StructureDefinition.useContext
                this.Element_UseContext = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:236
                    Path= "StructureDefinition.useContext",                                                                                 // MakerGen.cs:237
                    Id = "StructureDefinition.useContext",                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_UsageContext                                                                 // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 13. StructureDefinition.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:236
                    Path= "StructureDefinition.jurisdiction",                                                                               // MakerGen.cs:237
                    Id = "StructureDefinition.jurisdiction",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 14. StructureDefinition.purpose
                this.Element_Purpose = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Purpose",                                                                                               // MakerGen.cs:236
                    Path= "StructureDefinition.purpose",                                                                                    // MakerGen.cs:237
                    Id = "StructureDefinition.purpose",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 15. StructureDefinition.copyright
                this.Element_Copyright = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Copyright",                                                                                             // MakerGen.cs:236
                    Path= "StructureDefinition.copyright",                                                                                  // MakerGen.cs:237
                    Id = "StructureDefinition.copyright",                                                                                   // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 16. StructureDefinition.keyword
                this.Element_Keyword = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Keyword",                                                                                               // MakerGen.cs:236
                    Path= "StructureDefinition.keyword",                                                                                    // MakerGen.cs:237
                    Id = "StructureDefinition.keyword",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Coding                                                                       // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 17. StructureDefinition.fhirVersion
                this.Element_FhirVersion = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_FhirVersion",                                                                                           // MakerGen.cs:236
                    Path= "StructureDefinition.fhirVersion",                                                                                // MakerGen.cs:237
                    Id = "StructureDefinition.fhirVersion",                                                                                 // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 18. StructureDefinition.mapping
                this.Element_Mapping = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Mapping",                                                                                               // MakerGen.cs:236
                    Path= "StructureDefinition.mapping",                                                                                    // MakerGen.cs:237
                    Id = "StructureDefinition.mapping",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Mapping                                                                                                    // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 23. StructureDefinition.kind
                this.Element_Kind = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Kind",                                                                                                  // MakerGen.cs:236
                    Path= "StructureDefinition.kind",                                                                                       // MakerGen.cs:237
                    Id = "StructureDefinition.kind",                                                                                        // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 24. StructureDefinition.abstract
                this.Element_Abstract = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Abstract",                                                                                              // MakerGen.cs:236
                    Path= "StructureDefinition.abstract",                                                                                   // MakerGen.cs:237
                    Id = "StructureDefinition.abstract",                                                                                    // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 25. StructureDefinition.context
                this.Element_Context = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Context",                                                                                               // MakerGen.cs:236
                    Path= "StructureDefinition.context",                                                                                    // MakerGen.cs:237
                    Id = "StructureDefinition.context",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Context                                                                                                    // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 28. StructureDefinition.contextInvariant
                this.Element_ContextInvariant = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ContextInvariant",                                                                                      // MakerGen.cs:236
                    Path= "StructureDefinition.contextInvariant",                                                                           // MakerGen.cs:237
                    Id = "StructureDefinition.contextInvariant",                                                                            // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 29. StructureDefinition.type
                this.Element_Type = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Type",                                                                                                  // MakerGen.cs:236
                    Path= "StructureDefinition.type",                                                                                       // MakerGen.cs:237
                    Id = "StructureDefinition.type",                                                                                        // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 30. StructureDefinition.baseDefinition
                this.Element_BaseDefinition = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_BaseDefinition",                                                                                        // MakerGen.cs:236
                    Path= "StructureDefinition.baseDefinition",                                                                             // MakerGen.cs:237
                    Id = "StructureDefinition.baseDefinition",                                                                              // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:304
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                               // MakerGen.cs:304
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 31. StructureDefinition.derivation
                this.Element_Derivation = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Derivation",                                                                                            // MakerGen.cs:236
                    Path= "StructureDefinition.derivation",                                                                                 // MakerGen.cs:237
                    Id = "StructureDefinition.derivation",                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 32. StructureDefinition.snapshot
                this.Element_Snapshot = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Snapshot",                                                                                              // MakerGen.cs:236
                    Path= "StructureDefinition.snapshot",                                                                                   // MakerGen.cs:237
                    Id = "StructureDefinition.snapshot",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Snapshot                                                                                                   // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 34. StructureDefinition.differential
                this.Element_Differential = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Differential",                                                                                          // MakerGen.cs:236
                    Path= "StructureDefinition.differential",                                                                               // MakerGen.cs:237
                    Id = "StructureDefinition.differential",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Differential                                                                                               // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "StructureDefinition";                                                                                              // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/StructureDefinition";                                                       // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
