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
    #endregion
    /// <summary>
    /// Fhir resource 'TerminologyCapabilities'
    /// </summary>
    // 0. TerminologyCapabilities
    public partial class Resource_TerminologyCapabilities : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 16. TerminologyCapabilities.software
        public partial class Type_Software : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 17. TerminologyCapabilities.software.name
            public ElementDefinitionInfo Element_Name;
            // 18. TerminologyCapabilities.software.version
            public ElementDefinitionInfo Element_Version;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TerminologyCapabilities.software",
                    ElementId = "TerminologyCapabilities.software"
                });
                Element_Name.Write(sDef);
                Element_Version.Write(sDef);
            }
            
            public Type_Software()
            {
                {
                    // 17. TerminologyCapabilities.software.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "TerminologyCapabilities.software.name",
                        Id = "TerminologyCapabilities.software.name",
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
                    // 18. TerminologyCapabilities.software.version
                    this.Element_Version = new ElementDefinitionInfo
                    {
                        Name = "Element_Version",
                        Path= "TerminologyCapabilities.software.version",
                        Id = "TerminologyCapabilities.software.version",
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
        // 19. TerminologyCapabilities.implementation
        public partial class Type_Implementation : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 20. TerminologyCapabilities.implementation.description
            public ElementDefinitionInfo Element_Description;
            // 21. TerminologyCapabilities.implementation.url
            public ElementDefinitionInfo Element_Url;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TerminologyCapabilities.implementation",
                    ElementId = "TerminologyCapabilities.implementation"
                });
                Element_Description.Write(sDef);
                Element_Url.Write(sDef);
            }
            
            public Type_Implementation()
            {
                {
                    // 20. TerminologyCapabilities.implementation.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "TerminologyCapabilities.implementation.description",
                        Id = "TerminologyCapabilities.implementation.description",
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
                    // 21. TerminologyCapabilities.implementation.url
                    this.Element_Url = new ElementDefinitionInfo
                    {
                        Name = "Element_Url",
                        Path= "TerminologyCapabilities.implementation.url",
                        Id = "TerminologyCapabilities.implementation.url",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Url
                            {
                            }
                        }
                    };
                }
            }
        }
        // 23. TerminologyCapabilities.codeSystem
        public partial class Type_CodeSystem : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 25. TerminologyCapabilities.codeSystem.version
            public partial class Type_Version : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 30. TerminologyCapabilities.codeSystem.version.filter
                public partial class Type_Filter : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 31. TerminologyCapabilities.codeSystem.version.filter.code
                    public ElementDefinitionInfo Element_Code;
                    // 32. TerminologyCapabilities.codeSystem.version.filter.op
                    public ElementDefinitionInfo Element_Op;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "TerminologyCapabilities.codeSystem.version.filter",
                            ElementId = "TerminologyCapabilities.codeSystem.version.filter"
                        });
                        Element_Code.Write(sDef);
                        Element_Op.Write(sDef);
                    }
                    
                    public Type_Filter()
                    {
                        {
                            // 31. TerminologyCapabilities.codeSystem.version.filter.code
                            this.Element_Code = new ElementDefinitionInfo
                            {
                                Name = "Element_Code",
                                Path= "TerminologyCapabilities.codeSystem.version.filter.code",
                                Id = "TerminologyCapabilities.codeSystem.version.filter.code",
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
                            // 32. TerminologyCapabilities.codeSystem.version.filter.op
                            this.Element_Op = new ElementDefinitionInfo
                            {
                                Name = "Element_Op",
                                Path= "TerminologyCapabilities.codeSystem.version.filter.op",
                                Id = "TerminologyCapabilities.codeSystem.version.filter.op",
                                Min = 1,
                                Max = -1,
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
                // 26. TerminologyCapabilities.codeSystem.version.code
                public ElementDefinitionInfo Element_Code;
                // 27. TerminologyCapabilities.codeSystem.version.isDefault
                public ElementDefinitionInfo Element_IsDefault;
                // 28. TerminologyCapabilities.codeSystem.version.compositional
                public ElementDefinitionInfo Element_Compositional;
                // 29. TerminologyCapabilities.codeSystem.version.language
                public ElementDefinitionInfo Element_Language;
                // 30. TerminologyCapabilities.codeSystem.version.filter
                public ElementDefinitionInfo Element_Filter;
                // 33. TerminologyCapabilities.codeSystem.version.property
                public ElementDefinitionInfo Element_Property;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "TerminologyCapabilities.codeSystem.version",
                        ElementId = "TerminologyCapabilities.codeSystem.version"
                    });
                    Element_Code.Write(sDef);
                    Element_IsDefault.Write(sDef);
                    Element_Compositional.Write(sDef);
                    Element_Language.Write(sDef);
                    Element_Filter.Write(sDef);
                    Element_Property.Write(sDef);
                }
                
                public Type_Version()
                {
                    {
                        // 26. TerminologyCapabilities.codeSystem.version.code
                        this.Element_Code = new ElementDefinitionInfo
                        {
                            Name = "Element_Code",
                            Path= "TerminologyCapabilities.codeSystem.version.code",
                            Id = "TerminologyCapabilities.codeSystem.version.code",
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
                        // 27. TerminologyCapabilities.codeSystem.version.isDefault
                        this.Element_IsDefault = new ElementDefinitionInfo
                        {
                            Name = "Element_IsDefault",
                            Path= "TerminologyCapabilities.codeSystem.version.isDefault",
                            Id = "TerminologyCapabilities.codeSystem.version.isDefault",
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
                        // 28. TerminologyCapabilities.codeSystem.version.compositional
                        this.Element_Compositional = new ElementDefinitionInfo
                        {
                            Name = "Element_Compositional",
                            Path= "TerminologyCapabilities.codeSystem.version.compositional",
                            Id = "TerminologyCapabilities.codeSystem.version.compositional",
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
                        // 29. TerminologyCapabilities.codeSystem.version.language
                        this.Element_Language = new ElementDefinitionInfo
                        {
                            Name = "Element_Language",
                            Path= "TerminologyCapabilities.codeSystem.version.language",
                            Id = "TerminologyCapabilities.codeSystem.version.language",
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
                        // 30. TerminologyCapabilities.codeSystem.version.filter
                        this.Element_Filter = new ElementDefinitionInfo
                        {
                            Name = "Element_Filter",
                            Path= "TerminologyCapabilities.codeSystem.version.filter",
                            Id = "TerminologyCapabilities.codeSystem.version.filter",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Filter
                                {
                                }
                            }
                        };
                    }
                    {
                        // 33. TerminologyCapabilities.codeSystem.version.property
                        this.Element_Property = new ElementDefinitionInfo
                        {
                            Name = "Element_Property",
                            Path= "TerminologyCapabilities.codeSystem.version.property",
                            Id = "TerminologyCapabilities.codeSystem.version.property",
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
                }
            }
            // 24. TerminologyCapabilities.codeSystem.uri
            public ElementDefinitionInfo Element_Uri;
            // 25. TerminologyCapabilities.codeSystem.version
            public ElementDefinitionInfo Element_Version;
            // 34. TerminologyCapabilities.codeSystem.subsumption
            public ElementDefinitionInfo Element_Subsumption;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TerminologyCapabilities.codeSystem",
                    ElementId = "TerminologyCapabilities.codeSystem"
                });
                Element_Uri.Write(sDef);
                Element_Version.Write(sDef);
                Element_Subsumption.Write(sDef);
            }
            
            public Type_CodeSystem()
            {
                {
                    // 24. TerminologyCapabilities.codeSystem.uri
                    this.Element_Uri = new ElementDefinitionInfo
                    {
                        Name = "Element_Uri",
                        Path= "TerminologyCapabilities.codeSystem.uri",
                        Id = "TerminologyCapabilities.codeSystem.uri",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/CodeSystem"
                                }
                            }
                        }
                    };
                }
                {
                    // 25. TerminologyCapabilities.codeSystem.version
                    this.Element_Version = new ElementDefinitionInfo
                    {
                        Name = "Element_Version",
                        Path= "TerminologyCapabilities.codeSystem.version",
                        Id = "TerminologyCapabilities.codeSystem.version",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Version
                            {
                            }
                        }
                    };
                }
                {
                    // 34. TerminologyCapabilities.codeSystem.subsumption
                    this.Element_Subsumption = new ElementDefinitionInfo
                    {
                        Name = "Element_Subsumption",
                        Path= "TerminologyCapabilities.codeSystem.subsumption",
                        Id = "TerminologyCapabilities.codeSystem.subsumption",
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
            }
        }
        // 35. TerminologyCapabilities.expansion
        public partial class Type_Expansion : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 39. TerminologyCapabilities.expansion.parameter
            public partial class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 40. TerminologyCapabilities.expansion.parameter.name
                public ElementDefinitionInfo Element_Name;
                // 41. TerminologyCapabilities.expansion.parameter.documentation
                public ElementDefinitionInfo Element_Documentation;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "TerminologyCapabilities.expansion.parameter",
                        ElementId = "TerminologyCapabilities.expansion.parameter"
                    });
                    Element_Name.Write(sDef);
                    Element_Documentation.Write(sDef);
                }
                
                public Type_Parameter()
                {
                    {
                        // 40. TerminologyCapabilities.expansion.parameter.name
                        this.Element_Name = new ElementDefinitionInfo
                        {
                            Name = "Element_Name",
                            Path= "TerminologyCapabilities.expansion.parameter.name",
                            Id = "TerminologyCapabilities.expansion.parameter.name",
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
                        // 41. TerminologyCapabilities.expansion.parameter.documentation
                        this.Element_Documentation = new ElementDefinitionInfo
                        {
                            Name = "Element_Documentation",
                            Path= "TerminologyCapabilities.expansion.parameter.documentation",
                            Id = "TerminologyCapabilities.expansion.parameter.documentation",
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
            // 36. TerminologyCapabilities.expansion.hierarchical
            public ElementDefinitionInfo Element_Hierarchical;
            // 37. TerminologyCapabilities.expansion.paging
            public ElementDefinitionInfo Element_Paging;
            // 38. TerminologyCapabilities.expansion.incomplete
            public ElementDefinitionInfo Element_Incomplete;
            // 39. TerminologyCapabilities.expansion.parameter
            public ElementDefinitionInfo Element_Parameter;
            // 42. TerminologyCapabilities.expansion.textFilter
            public ElementDefinitionInfo Element_TextFilter;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TerminologyCapabilities.expansion",
                    ElementId = "TerminologyCapabilities.expansion"
                });
                Element_Hierarchical.Write(sDef);
                Element_Paging.Write(sDef);
                Element_Incomplete.Write(sDef);
                Element_Parameter.Write(sDef);
                Element_TextFilter.Write(sDef);
            }
            
            public Type_Expansion()
            {
                {
                    // 36. TerminologyCapabilities.expansion.hierarchical
                    this.Element_Hierarchical = new ElementDefinitionInfo
                    {
                        Name = "Element_Hierarchical",
                        Path= "TerminologyCapabilities.expansion.hierarchical",
                        Id = "TerminologyCapabilities.expansion.hierarchical",
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
                    // 37. TerminologyCapabilities.expansion.paging
                    this.Element_Paging = new ElementDefinitionInfo
                    {
                        Name = "Element_Paging",
                        Path= "TerminologyCapabilities.expansion.paging",
                        Id = "TerminologyCapabilities.expansion.paging",
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
                    // 38. TerminologyCapabilities.expansion.incomplete
                    this.Element_Incomplete = new ElementDefinitionInfo
                    {
                        Name = "Element_Incomplete",
                        Path= "TerminologyCapabilities.expansion.incomplete",
                        Id = "TerminologyCapabilities.expansion.incomplete",
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
                    // 39. TerminologyCapabilities.expansion.parameter
                    this.Element_Parameter = new ElementDefinitionInfo
                    {
                        Name = "Element_Parameter",
                        Path= "TerminologyCapabilities.expansion.parameter",
                        Id = "TerminologyCapabilities.expansion.parameter",
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
                    // 42. TerminologyCapabilities.expansion.textFilter
                    this.Element_TextFilter = new ElementDefinitionInfo
                    {
                        Name = "Element_TextFilter",
                        Path= "TerminologyCapabilities.expansion.textFilter",
                        Id = "TerminologyCapabilities.expansion.textFilter",
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
            }
        }
        // 44. TerminologyCapabilities.validateCode
        public partial class Type_ValidateCode : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 45. TerminologyCapabilities.validateCode.translations
            public ElementDefinitionInfo Element_Translations;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TerminologyCapabilities.validateCode",
                    ElementId = "TerminologyCapabilities.validateCode"
                });
                Element_Translations.Write(sDef);
            }
            
            public Type_ValidateCode()
            {
                {
                    // 45. TerminologyCapabilities.validateCode.translations
                    this.Element_Translations = new ElementDefinitionInfo
                    {
                        Name = "Element_Translations",
                        Path= "TerminologyCapabilities.validateCode.translations",
                        Id = "TerminologyCapabilities.validateCode.translations",
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
            }
        }
        // 46. TerminologyCapabilities.translation
        public partial class Type_Translation : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 47. TerminologyCapabilities.translation.needsMap
            public ElementDefinitionInfo Element_NeedsMap;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TerminologyCapabilities.translation",
                    ElementId = "TerminologyCapabilities.translation"
                });
                Element_NeedsMap.Write(sDef);
            }
            
            public Type_Translation()
            {
                {
                    // 47. TerminologyCapabilities.translation.needsMap
                    this.Element_NeedsMap = new ElementDefinitionInfo
                    {
                        Name = "Element_NeedsMap",
                        Path= "TerminologyCapabilities.translation.needsMap",
                        Id = "TerminologyCapabilities.translation.needsMap",
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
            }
        }
        // 48. TerminologyCapabilities.closure
        public partial class Type_Closure : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 49. TerminologyCapabilities.closure.translation
            public ElementDefinitionInfo Element_Translation;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TerminologyCapabilities.closure",
                    ElementId = "TerminologyCapabilities.closure"
                });
                Element_Translation.Write(sDef);
            }
            
            public Type_Closure()
            {
                {
                    // 49. TerminologyCapabilities.closure.translation
                    this.Element_Translation = new ElementDefinitionInfo
                    {
                        Name = "Element_Translation",
                        Path= "TerminologyCapabilities.closure.translation",
                        Id = "TerminologyCapabilities.closure.translation",
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
            }
        }
        // 1. TerminologyCapabilities.url
        public ElementDefinitionInfo Element_Url;
        // 2. TerminologyCapabilities.version
        public ElementDefinitionInfo Element_Version;
        // 3. TerminologyCapabilities.name
        public ElementDefinitionInfo Element_Name;
        // 4. TerminologyCapabilities.title
        public ElementDefinitionInfo Element_Title;
        // 5. TerminologyCapabilities.status
        public ElementDefinitionInfo Element_Status;
        // 6. TerminologyCapabilities.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 7. TerminologyCapabilities.date
        public ElementDefinitionInfo Element_Date;
        // 8. TerminologyCapabilities.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 9. TerminologyCapabilities.contact
        public ElementDefinitionInfo Element_Contact;
        // 10. TerminologyCapabilities.description
        public ElementDefinitionInfo Element_Description;
        // 11. TerminologyCapabilities.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 12. TerminologyCapabilities.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 13. TerminologyCapabilities.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 14. TerminologyCapabilities.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 15. TerminologyCapabilities.kind
        public ElementDefinitionInfo Element_Kind;
        // 16. TerminologyCapabilities.software
        public ElementDefinitionInfo Element_Software;
        // 19. TerminologyCapabilities.implementation
        public ElementDefinitionInfo Element_Implementation;
        // 22. TerminologyCapabilities.lockedDate
        public ElementDefinitionInfo Element_LockedDate;
        // 23. TerminologyCapabilities.codeSystem
        public ElementDefinitionInfo Element_CodeSystem;
        // 35. TerminologyCapabilities.expansion
        public ElementDefinitionInfo Element_Expansion;
        // 43. TerminologyCapabilities.codeSearch
        public ElementDefinitionInfo Element_CodeSearch;
        // 44. TerminologyCapabilities.validateCode
        public ElementDefinitionInfo Element_ValidateCode;
        // 46. TerminologyCapabilities.translation
        public ElementDefinitionInfo Element_Translation;
        // 48. TerminologyCapabilities.closure
        public ElementDefinitionInfo Element_Closure;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "TerminologyCapabilities",
                ElementId = "TerminologyCapabilities"
            });
            Element_Url.Write(sDef);
            Element_Version.Write(sDef);
            Element_Name.Write(sDef);
            Element_Title.Write(sDef);
            Element_Status.Write(sDef);
            Element_Experimental.Write(sDef);
            Element_Date.Write(sDef);
            Element_Publisher.Write(sDef);
            Element_Contact.Write(sDef);
            Element_Description.Write(sDef);
            Element_UseContext.Write(sDef);
            Element_Jurisdiction.Write(sDef);
            Element_Purpose.Write(sDef);
            Element_Copyright.Write(sDef);
            Element_Kind.Write(sDef);
            Element_Software.Write(sDef);
            Element_Implementation.Write(sDef);
            Element_LockedDate.Write(sDef);
            Element_CodeSystem.Write(sDef);
            Element_Expansion.Write(sDef);
            Element_CodeSearch.Write(sDef);
            Element_ValidateCode.Write(sDef);
            Element_Translation.Write(sDef);
            Element_Closure.Write(sDef);
        }
        
        public Resource_TerminologyCapabilities()
        {
            {
                // 1. TerminologyCapabilities.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "TerminologyCapabilities.url",
                    Id = "TerminologyCapabilities.url",
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
                // 2. TerminologyCapabilities.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "TerminologyCapabilities.version",
                    Id = "TerminologyCapabilities.version",
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
                // 3. TerminologyCapabilities.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "TerminologyCapabilities.name",
                    Id = "TerminologyCapabilities.name",
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
                // 4. TerminologyCapabilities.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "TerminologyCapabilities.title",
                    Id = "TerminologyCapabilities.title",
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
                // 5. TerminologyCapabilities.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "TerminologyCapabilities.status",
                    Id = "TerminologyCapabilities.status",
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
                // 6. TerminologyCapabilities.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "TerminologyCapabilities.experimental",
                    Id = "TerminologyCapabilities.experimental",
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
                // 7. TerminologyCapabilities.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "TerminologyCapabilities.date",
                    Id = "TerminologyCapabilities.date",
                    Min = 1,
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
                // 8. TerminologyCapabilities.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "TerminologyCapabilities.publisher",
                    Id = "TerminologyCapabilities.publisher",
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
                // 9. TerminologyCapabilities.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "TerminologyCapabilities.contact",
                    Id = "TerminologyCapabilities.contact",
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
                // 10. TerminologyCapabilities.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "TerminologyCapabilities.description",
                    Id = "TerminologyCapabilities.description",
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
                // 11. TerminologyCapabilities.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "TerminologyCapabilities.useContext",
                    Id = "TerminologyCapabilities.useContext",
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
                // 12. TerminologyCapabilities.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "TerminologyCapabilities.jurisdiction",
                    Id = "TerminologyCapabilities.jurisdiction",
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
                // 13. TerminologyCapabilities.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "TerminologyCapabilities.purpose",
                    Id = "TerminologyCapabilities.purpose",
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
                // 14. TerminologyCapabilities.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "TerminologyCapabilities.copyright",
                    Id = "TerminologyCapabilities.copyright",
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
                // 15. TerminologyCapabilities.kind
                this.Element_Kind = new ElementDefinitionInfo
                {
                    Name = "Element_Kind",
                    Path= "TerminologyCapabilities.kind",
                    Id = "TerminologyCapabilities.kind",
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
                // 16. TerminologyCapabilities.software
                this.Element_Software = new ElementDefinitionInfo
                {
                    Name = "Element_Software",
                    Path= "TerminologyCapabilities.software",
                    Id = "TerminologyCapabilities.software",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Software
                        {
                        }
                    }
                };
            }
            {
                // 19. TerminologyCapabilities.implementation
                this.Element_Implementation = new ElementDefinitionInfo
                {
                    Name = "Element_Implementation",
                    Path= "TerminologyCapabilities.implementation",
                    Id = "TerminologyCapabilities.implementation",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Implementation
                        {
                        }
                    }
                };
            }
            {
                // 22. TerminologyCapabilities.lockedDate
                this.Element_LockedDate = new ElementDefinitionInfo
                {
                    Name = "Element_LockedDate",
                    Path= "TerminologyCapabilities.lockedDate",
                    Id = "TerminologyCapabilities.lockedDate",
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
                // 23. TerminologyCapabilities.codeSystem
                this.Element_CodeSystem = new ElementDefinitionInfo
                {
                    Name = "Element_CodeSystem",
                    Path= "TerminologyCapabilities.codeSystem",
                    Id = "TerminologyCapabilities.codeSystem",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_CodeSystem
                        {
                        }
                    }
                };
            }
            {
                // 35. TerminologyCapabilities.expansion
                this.Element_Expansion = new ElementDefinitionInfo
                {
                    Name = "Element_Expansion",
                    Path= "TerminologyCapabilities.expansion",
                    Id = "TerminologyCapabilities.expansion",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Expansion
                        {
                        }
                    }
                };
            }
            {
                // 43. TerminologyCapabilities.codeSearch
                this.Element_CodeSearch = new ElementDefinitionInfo
                {
                    Name = "Element_CodeSearch",
                    Path= "TerminologyCapabilities.codeSearch",
                    Id = "TerminologyCapabilities.codeSearch",
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
                // 44. TerminologyCapabilities.validateCode
                this.Element_ValidateCode = new ElementDefinitionInfo
                {
                    Name = "Element_ValidateCode",
                    Path= "TerminologyCapabilities.validateCode",
                    Id = "TerminologyCapabilities.validateCode",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_ValidateCode
                        {
                        }
                    }
                };
            }
            {
                // 46. TerminologyCapabilities.translation
                this.Element_Translation = new ElementDefinitionInfo
                {
                    Name = "Element_Translation",
                    Path= "TerminologyCapabilities.translation",
                    Id = "TerminologyCapabilities.translation",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Translation
                        {
                        }
                    }
                };
            }
            {
                // 48. TerminologyCapabilities.closure
                this.Element_Closure = new ElementDefinitionInfo
                {
                    Name = "Element_Closure",
                    Path= "TerminologyCapabilities.closure",
                    Id = "TerminologyCapabilities.closure",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Closure
                        {
                        }
                    }
                };
            }
            this.Name = "TerminologyCapabilities";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/TerminologyCapabilities";
        }
    }
}
