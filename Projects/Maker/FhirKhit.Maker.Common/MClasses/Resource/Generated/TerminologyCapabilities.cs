using System;                                                                                                                               // MakerGen.cs:451
using System.Diagnostics;                                                                                                                   // MakerGen.cs:452
using System.IO;                                                                                                                            // MakerGen.cs:453
using System.Linq;                                                                                                                          // MakerGen.cs:454
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:455
                                                                                                                                            // MakerGen.cs:456
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:457
{                                                                                                                                           // MakerGen.cs:458
    #region Json                                                                                                                            // MakerGen.cs:459
    #if NEVER                                                                                                                               // MakerGen.cs:460
    {
      "resourceType": "StructureDefinition",
      "id": "TerminologyCapabilities",
      "url": "http://hl7.org/fhir/StructureDefinition/TerminologyCapabilities",
      "version": "4.0.0",
      "name": "TerminologyCapabilities",
      "status": "draft",
      "publisher": "Health Level Seven International (Vocabulary)",
      "description": "A TerminologyCapabilities resource documents a set of capabilities (behaviors) of a FHIR Terminology Server that may be used as a statement of actual server functionality or a statement of required or desired server implementation.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "TerminologyCapabilities",
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
            "id": "TerminologyCapabilities",
            "path": "TerminologyCapabilities",
            "short": "A statement of system capabilities",
            "definition": "A TerminologyCapabilities resource documents a set of capabilities (behaviors) of a FHIR Terminology Server that may be used as a statement of actual server functionality or a statement of required or desired server implementation.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "TerminologyCapabilities.url",
            "path": "TerminologyCapabilities.url",
            "short": "Canonical identifier for this terminology capabilities, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this terminology capabilities when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this terminology capabilities is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the terminology capabilities is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the terminology capabilities to be referenced by a single globally unique identifier.",
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
            "id": "TerminologyCapabilities.version",
            "path": "TerminologyCapabilities.version",
            "short": "Business version of the terminology capabilities",
            "definition": "The identifier that is used to identify this version of the terminology capabilities when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the terminology capabilities author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different terminology capabilities instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the terminology capabilities with the format [url]|[version].",
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
            "id": "TerminologyCapabilities.name",
            "path": "TerminologyCapabilities.name",
            "short": "Name for this terminology capabilities (computer friendly)",
            "definition": "A natural language name identifying the terminology capabilities. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
            "comment": "The name is not expected to be globally unique. The name should be a simple alphanumeric type name to ensure that it is machine-processing friendly.",
            "requirements": "Support human navigation and code generation.",
            "min": 0,
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
            "id": "TerminologyCapabilities.title",
            "path": "TerminologyCapabilities.title",
            "short": "Name for this terminology capabilities (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the terminology capabilities.",
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
            "id": "TerminologyCapabilities.status",
            "path": "TerminologyCapabilities.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this terminology capabilities. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of terminology capabilitiess that are appropriate for use versus not.This is not intended for use with actual capability statements, but where capability statements are used to describe possible or desired systems.",
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
            "id": "TerminologyCapabilities.experimental",
            "path": "TerminologyCapabilities.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this terminology capabilities is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of terminology capabilitiess that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level terminology capabilities.",
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
            "id": "TerminologyCapabilities.date",
            "path": "TerminologyCapabilities.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the terminology capabilities was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the terminology capabilities changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the terminology capabilities. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
            "alias": [
              "Revision Date"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ],
            "isSummary": true
          },
          {
            "id": "TerminologyCapabilities.publisher",
            "path": "TerminologyCapabilities.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the terminology capabilities.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the terminology capabilities is the organization or individual primarily responsible for the maintenance and upkeep of the terminology capabilities. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the terminology capabilities. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the terminology capabilities.  May also allow for contact.",
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
            "id": "TerminologyCapabilities.contact",
            "path": "TerminologyCapabilities.contact",
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
            "id": "TerminologyCapabilities.description",
            "path": "TerminologyCapabilities.description",
            "short": "Natural language description of the terminology capabilities",
            "definition": "A free text natural language description of the terminology capabilities from a consumer's perspective. Typically, this is used when the capability statement describes a desired rather than an actual solution, for example as a formal expression of requirements as part of an RFP.",
            "comment": "This description can be used to capture details such as why the terminology capabilities was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the terminology capabilities as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the terminology capabilities is presumed to be the predominant language in the place the terminology capabilities was created).This does not need to be populated if the description is adequately implied by the software or implementation details.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.useContext",
            "path": "TerminologyCapabilities.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate terminology capabilities instances.",
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
            "id": "TerminologyCapabilities.jurisdiction",
            "path": "TerminologyCapabilities.jurisdiction",
            "short": "Intended jurisdiction for terminology capabilities (if applicable)",
            "definition": "A legal or geographic region in which the terminology capabilities is intended to be used.",
            "comment": "It may be possible for the terminology capabilities to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "TerminologyCapabilities.purpose",
            "path": "TerminologyCapabilities.purpose",
            "short": "Why this terminology capabilities is defined",
            "definition": "Explanation of why this terminology capabilities is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the terminology capabilities. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this terminology capabilities.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.copyright",
            "path": "TerminologyCapabilities.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the terminology capabilities and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the terminology capabilities.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the terminology capabilities and/or its content.",
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
            ],
            "isSummary": true
          },
          {
            "id": "TerminologyCapabilities.kind",
            "path": "TerminologyCapabilities.kind",
            "short": "instance | capability | requirements",
            "definition": "The way that this statement is intended to be used, to describe an actual running instance of software, a particular product (kind, not instance of software) or a class of implementation (e.g. a desired purchase).",
            "requirements": "Allow searching the 3 modes.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "condition": [
              "tcp-3",
              "tcp-4",
              "tcp-5"
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "CapabilityStatementKind"
                }
              ],
              "strength": "required",
              "description": "How a capability statement is intended to be used.",
              "valueSet": "http://hl7.org/fhir/ValueSet/capability-statement-kind|4.0.0"
            }
          },
          {
            "id": "TerminologyCapabilities.software",
            "path": "TerminologyCapabilities.software",
            "short": "Software that is covered by this terminology capability statement",
            "definition": "Software that is covered by this terminology capability statement.  It is used when the statement describes the capabilities of a particular software version, independent of an installation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "tcp-2"
            ],
            "isSummary": true
          },
          {
            "id": "TerminologyCapabilities.software.name",
            "path": "TerminologyCapabilities.software.name",
            "short": "A name the software is known by",
            "definition": "Name the software is known by.",
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
            "id": "TerminologyCapabilities.software.version",
            "path": "TerminologyCapabilities.software.version",
            "short": "Version covered by this statement",
            "definition": "The version identifier for the software covered by this statement.",
            "comment": "If possible, a version should be specified, as statements are likely to be different for different versions of software.",
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
            "id": "TerminologyCapabilities.implementation",
            "path": "TerminologyCapabilities.implementation",
            "short": "If this describes a specific instance",
            "definition": "Identifies a specific implementation instance that is described by the terminology capability statement - i.e. a particular installation, rather than the capabilities of a software program.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "tcp-2",
              "tcp-5"
            ],
            "isSummary": true
          },
          {
            "id": "TerminologyCapabilities.implementation.description",
            "path": "TerminologyCapabilities.implementation.description",
            "short": "Describes this specific instance",
            "definition": "Information about the specific installation that this terminology capability statement relates to.",
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
            "id": "TerminologyCapabilities.implementation.url",
            "path": "TerminologyCapabilities.implementation.url",
            "short": "Base URL for the implementation",
            "definition": "An absolute base URL for the implementation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "url"
              }
            ],
            "isSummary": true
          },
          {
            "id": "TerminologyCapabilities.lockedDate",
            "path": "TerminologyCapabilities.lockedDate",
            "short": "Whether lockedDate is supported",
            "definition": "Whether the server supports lockedDate.",
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
            "id": "TerminologyCapabilities.codeSystem",
            "path": "TerminologyCapabilities.codeSystem",
            "short": "A code system supported by the server",
            "definition": "Identifies a code system that is supported by the server. If there is a no code system URL, then this declares the general assumptions a client can make about support for any CodeSystem resource.",
            "comment": "The code system - identified by its system URL - may also be declared explicitly as a Code System Resource at /CodeSystem, but it might not be.",
            "alias": [
              "1"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.codeSystem.uri",
            "path": "TerminologyCapabilities.codeSystem.uri",
            "short": "URI for the Code System",
            "definition": "URI for the Code System.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CodeSystem"
                ]
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.codeSystem.version",
            "path": "TerminologyCapabilities.codeSystem.version",
            "short": "Version of Code System supported",
            "definition": "For the code system, a list of versions that are supported by the server.",
            "comment": "Language translations might not be available for all codes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.codeSystem.version.code",
            "path": "TerminologyCapabilities.codeSystem.version.code",
            "short": "Version identifier for this version",
            "definition": "For version-less code systems, there should be a single version with no identifier.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "tcp-1"
            ],
            "isSummary": true
          },
          {
            "id": "TerminologyCapabilities.codeSystem.version.isDefault",
            "path": "TerminologyCapabilities.codeSystem.version.isDefault",
            "short": "If this is the default version for this code system",
            "definition": "If this is the default version for this code system.",
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
            "id": "TerminologyCapabilities.codeSystem.version.compositional",
            "path": "TerminologyCapabilities.codeSystem.version.compositional",
            "short": "If compositional grammar is supported",
            "definition": "If the compositional grammar defined by the code system is supported.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.codeSystem.version.language",
            "path": "TerminologyCapabilities.codeSystem.version.language",
            "short": "Language Displays supported",
            "definition": "Language Displays supported.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "code"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.codeSystem.version.filter",
            "path": "TerminologyCapabilities.codeSystem.version.filter",
            "short": "Filter Properties supported",
            "definition": "Filter Properties supported.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.codeSystem.version.filter.code",
            "path": "TerminologyCapabilities.codeSystem.version.filter.code",
            "short": "Code of the property supported",
            "definition": "Code of the property supported.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.codeSystem.version.filter.op",
            "path": "TerminologyCapabilities.codeSystem.version.filter.op",
            "short": "Operations supported for the property",
            "definition": "Operations supported for the property.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "code"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.codeSystem.version.property",
            "path": "TerminologyCapabilities.codeSystem.version.property",
            "short": "Properties supported for $lookup",
            "definition": "Properties supported for $lookup.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "code"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.codeSystem.subsumption",
            "path": "TerminologyCapabilities.codeSystem.subsumption",
            "short": "Whether subsumption is supported",
            "definition": "True if subsumption is supported for this version of the code system.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.expansion",
            "path": "TerminologyCapabilities.expansion",
            "short": "Information about the [ValueSet/$expand](valueset-operation-expand.html) operation",
            "definition": "Information about the [ValueSet/$expand](valueset-operation-expand.html) operation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.expansion.hierarchical",
            "path": "TerminologyCapabilities.expansion.hierarchical",
            "short": "Whether the server can return nested value sets",
            "definition": "Whether the server can return nested value sets.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.expansion.paging",
            "path": "TerminologyCapabilities.expansion.paging",
            "short": "Whether the server supports paging on expansion",
            "definition": "Whether the server supports paging on expansion.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.expansion.incomplete",
            "path": "TerminologyCapabilities.expansion.incomplete",
            "short": "Allow request for incomplete expansions?",
            "definition": "Allow request for incomplete expansions?",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.expansion.parameter",
            "path": "TerminologyCapabilities.expansion.parameter",
            "short": "Supported expansion parameter",
            "definition": "Supported expansion parameter.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.expansion.parameter.name",
            "path": "TerminologyCapabilities.expansion.parameter.name",
            "short": "Expansion Parameter name",
            "definition": "Expansion Parameter name.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.expansion.parameter.documentation",
            "path": "TerminologyCapabilities.expansion.parameter.documentation",
            "short": "Description of support for parameter",
            "definition": "Description of support for parameter.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.expansion.textFilter",
            "path": "TerminologyCapabilities.expansion.textFilter",
            "short": "Documentation about text searching works",
            "definition": "Documentation about text searching works.",
            "comment": "This documentation should cover things like case sensitivity,  use of punctuation if not ignored, what wild cards are supported (if any), whether text is starts with or contains, and whether word order matters.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.codeSearch",
            "path": "TerminologyCapabilities.codeSearch",
            "short": "explicit | all",
            "definition": "The degree to which the server supports the code search parameter on ValueSet, if it is supported.",
            "comment": "See notes on the [ValueSet](valueset.html#) resource.",
            "min": 0,
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
                  "valueString": "CodeSearchSupport"
                }
              ],
              "strength": "required",
              "description": "The degree to which the server supports the code search parameter on ValueSet, if it is supported.",
              "valueSet": "http://hl7.org/fhir/ValueSet/code-search-support|4.0.0"
            }
          },
          {
            "id": "TerminologyCapabilities.validateCode",
            "path": "TerminologyCapabilities.validateCode",
            "short": "Information about the [ValueSet/$validate-code](valueset-operation-validate-code.html) operation",
            "definition": "Information about the [ValueSet/$validate-code](valueset-operation-validate-code.html) operation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.validateCode.translations",
            "path": "TerminologyCapabilities.validateCode.translations",
            "short": "Whether translations are validated",
            "definition": "Whether translations are validated.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.translation",
            "path": "TerminologyCapabilities.translation",
            "short": "Information about the [ConceptMap/$translate](conceptmap-operation-translate.html) operation",
            "definition": "Information about the [ConceptMap/$translate](conceptmap-operation-translate.html) operation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.translation.needsMap",
            "path": "TerminologyCapabilities.translation.needsMap",
            "short": "Whether the client must identify the map",
            "definition": "Whether the client must identify the map.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.closure",
            "path": "TerminologyCapabilities.closure",
            "short": "Information about the [ConceptMap/$closure](conceptmap-operation-closure.html) operation",
            "definition": "Whether the $closure operation is supported.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TerminologyCapabilities.closure.translation",
            "path": "TerminologyCapabilities.closure.translation",
            "short": "If cross-system closure is supported",
            "definition": "If cross-system closure is supported.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'TerminologyCapabilities'
    /// </summary>
    // 0. TerminologyCapabilities
    public class TerminologyCapabilities : FhirKhit.Maker.Common.Resource.ResourceBase                                                      // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class TerminologyCapabilities_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 16. TerminologyCapabilities.software
            public class Type_Software : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Software_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 17. TerminologyCapabilities.software.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:236
                    // 18. TerminologyCapabilities.software.version
                    public ElementDefinitionInfo Version;                                                                                   // MakerGen.cs:236
                    public Type_Software_Elements()                                                                                         // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 17. TerminologyCapabilities.software.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Name",                                                                                              // MakerGen.cs:255
                                Path= "TerminologyCapabilities.software.name",                                                              // MakerGen.cs:256
                                Id = "TerminologyCapabilities.software.name",                                                               // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 18. TerminologyCapabilities.software.version
                            this.Version = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Version",                                                                                           // MakerGen.cs:255
                                Path= "TerminologyCapabilities.software.version",                                                           // MakerGen.cs:256
                                Id = "TerminologyCapabilities.software.version",                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Version.Write(sDef);                                                                                                // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Software_Elements Elements { get; }                                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Software()                                                                                                      // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Software_Elements();                                                                           // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 19. TerminologyCapabilities.implementation
            public class Type_Implementation : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Implementation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 20. TerminologyCapabilities.implementation.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:236
                    // 21. TerminologyCapabilities.implementation.url
                    public ElementDefinitionInfo Url;                                                                                       // MakerGen.cs:236
                    public Type_Implementation_Elements()                                                                                   // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 20. TerminologyCapabilities.implementation.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Description",                                                                                       // MakerGen.cs:255
                                Path= "TerminologyCapabilities.implementation.description",                                                 // MakerGen.cs:256
                                Id = "TerminologyCapabilities.implementation.description",                                                  // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 21. TerminologyCapabilities.implementation.url
                            this.Url = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Url",                                                                                               // MakerGen.cs:255
                                Path= "TerminologyCapabilities.implementation.url",                                                         // MakerGen.cs:256
                                Id = "TerminologyCapabilities.implementation.url",                                                          // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Url                                                                 // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Description.Write(sDef);                                                                                            // MakerGen.cs:240
                        Url.Write(sDef);                                                                                                    // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Implementation_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Implementation()                                                                                                // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Implementation_Elements();                                                                     // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 23. TerminologyCapabilities.codeSystem
            public class Type_CodeSystem : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_CodeSystem_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 25. TerminologyCapabilities.codeSystem.version
                    public class Type_Version : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Version_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 30. TerminologyCapabilities.codeSystem.version.filter
                            public class Type_Filter : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:385
                            {                                                                                                               // MakerGen.cs:386
                                public class Type_Filter_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                             // MakerGen.cs:387
                                {                                                                                                           // MakerGen.cs:388
                                    // 31. TerminologyCapabilities.codeSystem.version.filter.code
                                    public ElementDefinitionInfo Code;                                                                      // MakerGen.cs:236
                                    // 32. TerminologyCapabilities.codeSystem.version.filter.op
                                    public ElementDefinitionInfo Op;                                                                        // MakerGen.cs:236
                                    public Type_Filter_Elements()                                                                           // MakerGen.cs:409
                                    {                                                                                                       // MakerGen.cs:410
                                        {                                                                                                   // MakerGen.cs:251
                                            // 31. TerminologyCapabilities.codeSystem.version.filter.code
                                            this.Code = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Code",                                                                              // MakerGen.cs:255
                                                Path= "TerminologyCapabilities.codeSystem.version.filter.code",                             // MakerGen.cs:256
                                                Id = "TerminologyCapabilities.codeSystem.version.filter.code",                              // MakerGen.cs:257
                                                Min = 1,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Code                                                // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 32. TerminologyCapabilities.codeSystem.version.filter.op
                                            this.Op = new ElementDefinitionInfo                                                             // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Op",                                                                                // MakerGen.cs:255
                                                Path= "TerminologyCapabilities.codeSystem.version.filter.op",                               // MakerGen.cs:256
                                                Id = "TerminologyCapabilities.codeSystem.version.filter.op",                                // MakerGen.cs:257
                                                Min = 1,                                                                                    // MakerGen.cs:258
                                                Max = -1,                                                                                   // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Code                                                // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                    }                                                                                                       // MakerGen.cs:429
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:414
                                    {                                                                                                       // MakerGen.cs:415
                                        base.Write(sDef);                                                                                   // MakerGen.cs:416
                                        Code.Write(sDef);                                                                                   // MakerGen.cs:240
                                        Op.Write(sDef);                                                                                     // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:433
                                }                                                                                                           // MakerGen.cs:393
                                public Type_Filter_Elements Elements { get; }                                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                                public Type_Filter()                                                                                        // MakerGen.cs:396
                                {                                                                                                           // MakerGen.cs:397
                                    this.Elements = new Type_Filter_Elements();                                                             // MakerGen.cs:398
                                }                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:401
                                {                                                                                                           // MakerGen.cs:402
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:403
                                }                                                                                                           // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                            // 26. TerminologyCapabilities.codeSystem.version.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:236
                            // 27. TerminologyCapabilities.codeSystem.version.isDefault
                            public ElementDefinitionInfo IsDefault;                                                                         // MakerGen.cs:236
                            // 28. TerminologyCapabilities.codeSystem.version.compositional
                            public ElementDefinitionInfo Compositional;                                                                     // MakerGen.cs:236
                            // 29. TerminologyCapabilities.codeSystem.version.language
                            public ElementDefinitionInfo Language;                                                                          // MakerGen.cs:236
                            // 33. TerminologyCapabilities.codeSystem.version.property
                            public ElementDefinitionInfo Property;                                                                          // MakerGen.cs:236
                            public Type_Version_Elements()                                                                                  // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 26. TerminologyCapabilities.codeSystem.version.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Code",                                                                                      // MakerGen.cs:255
                                        Path= "TerminologyCapabilities.codeSystem.version.code",                                            // MakerGen.cs:256
                                        Id = "TerminologyCapabilities.codeSystem.version.code",                                             // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 27. TerminologyCapabilities.codeSystem.version.isDefault
                                    this.IsDefault = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "IsDefault",                                                                                 // MakerGen.cs:255
                                        Path= "TerminologyCapabilities.codeSystem.version.isDefault",                                       // MakerGen.cs:256
                                        Id = "TerminologyCapabilities.codeSystem.version.isDefault",                                        // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 28. TerminologyCapabilities.codeSystem.version.compositional
                                    this.Compositional = new ElementDefinitionInfo                                                          // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Compositional",                                                                             // MakerGen.cs:255
                                        Path= "TerminologyCapabilities.codeSystem.version.compositional",                                   // MakerGen.cs:256
                                        Id = "TerminologyCapabilities.codeSystem.version.compositional",                                    // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 29. TerminologyCapabilities.codeSystem.version.language
                                    this.Language = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Language",                                                                                  // MakerGen.cs:255
                                        Path= "TerminologyCapabilities.codeSystem.version.language",                                        // MakerGen.cs:256
                                        Id = "TerminologyCapabilities.codeSystem.version.language",                                         // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 33. TerminologyCapabilities.codeSystem.version.property
                                    this.Property = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Property",                                                                                  // MakerGen.cs:255
                                        Path= "TerminologyCapabilities.codeSystem.version.property",                                        // MakerGen.cs:256
                                        Id = "TerminologyCapabilities.codeSystem.version.property",                                         // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Code.Write(sDef);                                                                                           // MakerGen.cs:240
                                IsDefault.Write(sDef);                                                                                      // MakerGen.cs:240
                                Compositional.Write(sDef);                                                                                  // MakerGen.cs:240
                                Language.Write(sDef);                                                                                       // MakerGen.cs:240
                                Property.Write(sDef);                                                                                       // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Version_Elements Elements { get; }                                                                      // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Version()                                                                                               // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Version_Elements();                                                                    // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 24. TerminologyCapabilities.codeSystem.uri
                    public ElementDefinitionInfo Uri;                                                                                       // MakerGen.cs:236
                    // 34. TerminologyCapabilities.codeSystem.subsumption
                    public ElementDefinitionInfo Subsumption;                                                                               // MakerGen.cs:236
                    public Type_CodeSystem_Elements()                                                                                       // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 24. TerminologyCapabilities.codeSystem.uri
                            this.Uri = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Uri",                                                                                               // MakerGen.cs:255
                                Path= "TerminologyCapabilities.codeSystem.uri",                                                             // MakerGen.cs:256
                                Id = "TerminologyCapabilities.codeSystem.uri",                                                              // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Canonical                                                           // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:302
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/CodeSystem"                                            // MakerGen.cs:302
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 34. TerminologyCapabilities.codeSystem.subsumption
                            this.Subsumption = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Subsumption",                                                                                       // MakerGen.cs:255
                                Path= "TerminologyCapabilities.codeSystem.subsumption",                                                     // MakerGen.cs:256
                                Id = "TerminologyCapabilities.codeSystem.subsumption",                                                      // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Uri.Write(sDef);                                                                                                    // MakerGen.cs:240
                        Subsumption.Write(sDef);                                                                                            // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_CodeSystem_Elements Elements { get; }                                                                           // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_CodeSystem()                                                                                                    // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_CodeSystem_Elements();                                                                         // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 35. TerminologyCapabilities.expansion
            public class Type_Expansion : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Expansion_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 39. TerminologyCapabilities.expansion.parameter
                    public class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Parameter_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 40. TerminologyCapabilities.expansion.parameter.name
                            public ElementDefinitionInfo Name;                                                                              // MakerGen.cs:236
                            // 41. TerminologyCapabilities.expansion.parameter.documentation
                            public ElementDefinitionInfo Documentation;                                                                     // MakerGen.cs:236
                            public Type_Parameter_Elements()                                                                                // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 40. TerminologyCapabilities.expansion.parameter.name
                                    this.Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Name",                                                                                      // MakerGen.cs:255
                                        Path= "TerminologyCapabilities.expansion.parameter.name",                                           // MakerGen.cs:256
                                        Id = "TerminologyCapabilities.expansion.parameter.name",                                            // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 41. TerminologyCapabilities.expansion.parameter.documentation
                                    this.Documentation = new ElementDefinitionInfo                                                          // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Documentation",                                                                             // MakerGen.cs:255
                                        Path= "TerminologyCapabilities.expansion.parameter.documentation",                                  // MakerGen.cs:256
                                        Id = "TerminologyCapabilities.expansion.parameter.documentation",                                   // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Name.Write(sDef);                                                                                           // MakerGen.cs:240
                                Documentation.Write(sDef);                                                                                  // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Parameter_Elements Elements { get; }                                                                    // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Parameter()                                                                                             // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Parameter_Elements();                                                                  // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 36. TerminologyCapabilities.expansion.hierarchical
                    public ElementDefinitionInfo Hierarchical;                                                                              // MakerGen.cs:236
                    // 37. TerminologyCapabilities.expansion.paging
                    public ElementDefinitionInfo Paging;                                                                                    // MakerGen.cs:236
                    // 38. TerminologyCapabilities.expansion.incomplete
                    public ElementDefinitionInfo Incomplete;                                                                                // MakerGen.cs:236
                    // 42. TerminologyCapabilities.expansion.textFilter
                    public ElementDefinitionInfo TextFilter;                                                                                // MakerGen.cs:236
                    public Type_Expansion_Elements()                                                                                        // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 36. TerminologyCapabilities.expansion.hierarchical
                            this.Hierarchical = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Hierarchical",                                                                                      // MakerGen.cs:255
                                Path= "TerminologyCapabilities.expansion.hierarchical",                                                     // MakerGen.cs:256
                                Id = "TerminologyCapabilities.expansion.hierarchical",                                                      // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 37. TerminologyCapabilities.expansion.paging
                            this.Paging = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Paging",                                                                                            // MakerGen.cs:255
                                Path= "TerminologyCapabilities.expansion.paging",                                                           // MakerGen.cs:256
                                Id = "TerminologyCapabilities.expansion.paging",                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 38. TerminologyCapabilities.expansion.incomplete
                            this.Incomplete = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Incomplete",                                                                                        // MakerGen.cs:255
                                Path= "TerminologyCapabilities.expansion.incomplete",                                                       // MakerGen.cs:256
                                Id = "TerminologyCapabilities.expansion.incomplete",                                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 42. TerminologyCapabilities.expansion.textFilter
                            this.TextFilter = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "TextFilter",                                                                                        // MakerGen.cs:255
                                Path= "TerminologyCapabilities.expansion.textFilter",                                                       // MakerGen.cs:256
                                Id = "TerminologyCapabilities.expansion.textFilter",                                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Markdown                                                            // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Hierarchical.Write(sDef);                                                                                           // MakerGen.cs:240
                        Paging.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Incomplete.Write(sDef);                                                                                             // MakerGen.cs:240
                        TextFilter.Write(sDef);                                                                                             // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Expansion_Elements Elements { get; }                                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Expansion()                                                                                                     // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Expansion_Elements();                                                                          // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 44. TerminologyCapabilities.validateCode
            public class Type_ValidateCode : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_ValidateCode_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 45. TerminologyCapabilities.validateCode.translations
                    public ElementDefinitionInfo Translations;                                                                              // MakerGen.cs:236
                    public Type_ValidateCode_Elements()                                                                                     // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 45. TerminologyCapabilities.validateCode.translations
                            this.Translations = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Translations",                                                                                      // MakerGen.cs:255
                                Path= "TerminologyCapabilities.validateCode.translations",                                                  // MakerGen.cs:256
                                Id = "TerminologyCapabilities.validateCode.translations",                                                   // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Translations.Write(sDef);                                                                                           // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_ValidateCode_Elements Elements { get; }                                                                         // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_ValidateCode()                                                                                                  // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_ValidateCode_Elements();                                                                       // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 46. TerminologyCapabilities.translation
            public class Type_Translation : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Translation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 47. TerminologyCapabilities.translation.needsMap
                    public ElementDefinitionInfo NeedsMap;                                                                                  // MakerGen.cs:236
                    public Type_Translation_Elements()                                                                                      // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 47. TerminologyCapabilities.translation.needsMap
                            this.NeedsMap = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "NeedsMap",                                                                                          // MakerGen.cs:255
                                Path= "TerminologyCapabilities.translation.needsMap",                                                       // MakerGen.cs:256
                                Id = "TerminologyCapabilities.translation.needsMap",                                                        // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        NeedsMap.Write(sDef);                                                                                               // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Translation_Elements Elements { get; }                                                                          // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Translation()                                                                                                   // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Translation_Elements();                                                                        // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 48. TerminologyCapabilities.closure
            public class Type_Closure : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Closure_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 49. TerminologyCapabilities.closure.translation
                    public ElementDefinitionInfo Translation;                                                                               // MakerGen.cs:236
                    public Type_Closure_Elements()                                                                                          // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 49. TerminologyCapabilities.closure.translation
                            this.Translation = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Translation",                                                                                       // MakerGen.cs:255
                                Path= "TerminologyCapabilities.closure.translation",                                                        // MakerGen.cs:256
                                Id = "TerminologyCapabilities.closure.translation",                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Translation.Write(sDef);                                                                                            // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Closure_Elements Elements { get; }                                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Closure()                                                                                                       // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Closure_Elements();                                                                            // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. TerminologyCapabilities.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:236
            // 2. TerminologyCapabilities.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:236
            // 3. TerminologyCapabilities.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:236
            // 4. TerminologyCapabilities.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:236
            // 5. TerminologyCapabilities.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 6. TerminologyCapabilities.experimental
            public ElementDefinitionInfo Experimental;                                                                                      // MakerGen.cs:236
            // 7. TerminologyCapabilities.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:236
            // 8. TerminologyCapabilities.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:236
            // 9. TerminologyCapabilities.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:236
            // 10. TerminologyCapabilities.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:236
            // 11. TerminologyCapabilities.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:236
            // 12. TerminologyCapabilities.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:236
            // 13. TerminologyCapabilities.purpose
            public ElementDefinitionInfo Purpose;                                                                                           // MakerGen.cs:236
            // 14. TerminologyCapabilities.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:236
            // 15. TerminologyCapabilities.kind
            public ElementDefinitionInfo Kind;                                                                                              // MakerGen.cs:236
            // 22. TerminologyCapabilities.lockedDate
            public ElementDefinitionInfo LockedDate;                                                                                        // MakerGen.cs:236
            // 43. TerminologyCapabilities.codeSearch
            public ElementDefinitionInfo CodeSearch;                                                                                        // MakerGen.cs:236
            public TerminologyCapabilities_Elements()                                                                                       // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. TerminologyCapabilities.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Url",                                                                                                       // MakerGen.cs:255
                        Path= "TerminologyCapabilities.url",                                                                                // MakerGen.cs:256
                        Id = "TerminologyCapabilities.url",                                                                                 // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. TerminologyCapabilities.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Version",                                                                                                   // MakerGen.cs:255
                        Path= "TerminologyCapabilities.version",                                                                            // MakerGen.cs:256
                        Id = "TerminologyCapabilities.version",                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. TerminologyCapabilities.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Name",                                                                                                      // MakerGen.cs:255
                        Path= "TerminologyCapabilities.name",                                                                               // MakerGen.cs:256
                        Id = "TerminologyCapabilities.name",                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. TerminologyCapabilities.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Title",                                                                                                     // MakerGen.cs:255
                        Path= "TerminologyCapabilities.title",                                                                              // MakerGen.cs:256
                        Id = "TerminologyCapabilities.title",                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. TerminologyCapabilities.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "TerminologyCapabilities.status",                                                                             // MakerGen.cs:256
                        Id = "TerminologyCapabilities.status",                                                                              // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. TerminologyCapabilities.experimental
                    this.Experimental = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Experimental",                                                                                              // MakerGen.cs:255
                        Path= "TerminologyCapabilities.experimental",                                                                       // MakerGen.cs:256
                        Id = "TerminologyCapabilities.experimental",                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. TerminologyCapabilities.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Date",                                                                                                      // MakerGen.cs:255
                        Path= "TerminologyCapabilities.date",                                                                               // MakerGen.cs:256
                        Id = "TerminologyCapabilities.date",                                                                                // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 8. TerminologyCapabilities.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Publisher",                                                                                                 // MakerGen.cs:255
                        Path= "TerminologyCapabilities.publisher",                                                                          // MakerGen.cs:256
                        Id = "TerminologyCapabilities.publisher",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. TerminologyCapabilities.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Contact",                                                                                                   // MakerGen.cs:255
                        Path= "TerminologyCapabilities.contact",                                                                            // MakerGen.cs:256
                        Id = "TerminologyCapabilities.contact",                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. TerminologyCapabilities.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Description",                                                                                               // MakerGen.cs:255
                        Path= "TerminologyCapabilities.description",                                                                        // MakerGen.cs:256
                        Id = "TerminologyCapabilities.description",                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 11. TerminologyCapabilities.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "UseContext",                                                                                                // MakerGen.cs:255
                        Path= "TerminologyCapabilities.useContext",                                                                         // MakerGen.cs:256
                        Id = "TerminologyCapabilities.useContext",                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.UsageContext                                                                  // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 12. TerminologyCapabilities.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:255
                        Path= "TerminologyCapabilities.jurisdiction",                                                                       // MakerGen.cs:256
                        Id = "TerminologyCapabilities.jurisdiction",                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 13. TerminologyCapabilities.purpose
                    this.Purpose = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Purpose",                                                                                                   // MakerGen.cs:255
                        Path= "TerminologyCapabilities.purpose",                                                                            // MakerGen.cs:256
                        Id = "TerminologyCapabilities.purpose",                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 14. TerminologyCapabilities.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Copyright",                                                                                                 // MakerGen.cs:255
                        Path= "TerminologyCapabilities.copyright",                                                                          // MakerGen.cs:256
                        Id = "TerminologyCapabilities.copyright",                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 15. TerminologyCapabilities.kind
                    this.Kind = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Kind",                                                                                                      // MakerGen.cs:255
                        Path= "TerminologyCapabilities.kind",                                                                               // MakerGen.cs:256
                        Id = "TerminologyCapabilities.kind",                                                                                // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 22. TerminologyCapabilities.lockedDate
                    this.LockedDate = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "LockedDate",                                                                                                // MakerGen.cs:255
                        Path= "TerminologyCapabilities.lockedDate",                                                                         // MakerGen.cs:256
                        Id = "TerminologyCapabilities.lockedDate",                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 43. TerminologyCapabilities.codeSearch
                    this.CodeSearch = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "CodeSearch",                                                                                                // MakerGen.cs:255
                        Path= "TerminologyCapabilities.codeSearch",                                                                         // MakerGen.cs:256
                        Id = "TerminologyCapabilities.codeSearch",                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Url.Write(sDef);                                                                                                            // MakerGen.cs:240
                Version.Write(sDef);                                                                                                        // MakerGen.cs:240
                Name.Write(sDef);                                                                                                           // MakerGen.cs:240
                Title.Write(sDef);                                                                                                          // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Experimental.Write(sDef);                                                                                                   // MakerGen.cs:240
                Date.Write(sDef);                                                                                                           // MakerGen.cs:240
                Publisher.Write(sDef);                                                                                                      // MakerGen.cs:240
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:240
                Description.Write(sDef);                                                                                                    // MakerGen.cs:240
                UseContext.Write(sDef);                                                                                                     // MakerGen.cs:240
                Jurisdiction.Write(sDef);                                                                                                   // MakerGen.cs:240
                Purpose.Write(sDef);                                                                                                        // MakerGen.cs:240
                Copyright.Write(sDef);                                                                                                      // MakerGen.cs:240
                Kind.Write(sDef);                                                                                                           // MakerGen.cs:240
                LockedDate.Write(sDef);                                                                                                     // MakerGen.cs:240
                CodeSearch.Write(sDef);                                                                                                     // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public TerminologyCapabilities_Elements Elements { get; }                                                                           // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public TerminologyCapabilities()                                                                                                    // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new TerminologyCapabilities_Elements();                                                                         // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
