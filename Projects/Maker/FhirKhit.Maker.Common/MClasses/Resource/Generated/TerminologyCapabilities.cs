using System;                                                                                                                               // MakerGen.cs:391
using System.Diagnostics;                                                                                                                   // MakerGen.cs:392
using System.IO;                                                                                                                            // MakerGen.cs:393
using System.Linq;                                                                                                                          // MakerGen.cs:394
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:396
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:397
{                                                                                                                                           // MakerGen.cs:398
    #region Json                                                                                                                            // MakerGen.cs:399
    #if NEVER                                                                                                                               // MakerGen.cs:400
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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'TerminologyCapabilities'
    /// </summary>
    // 0. TerminologyCapabilities
    public class TerminologyCapabilities : FhirKhit.Maker.Common.Resource.ResourceBase                                                      // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 16. TerminologyCapabilities.software
        public class Type_Software : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 17. TerminologyCapabilities.software.name
            public MakerElementInstance Element_Name;                                                                                       // MakerGen.cs:232
            // 18. TerminologyCapabilities.software.version
            public MakerElementInstance Element_Version;                                                                                    // MakerGen.cs:232
            public Type_Software()                                                                                                          // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 17. TerminologyCapabilities.software.name
                    this.Element_Name = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Name",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 18. TerminologyCapabilities.software.version
                    this.Element_Version = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Version",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 19. TerminologyCapabilities.implementation
        public class Type_Implementation : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 20. TerminologyCapabilities.implementation.description
            public MakerElementInstance Element_Description;                                                                                // MakerGen.cs:232
            // 21. TerminologyCapabilities.implementation.url
            public MakerElementInstance Element_Url;                                                                                        // MakerGen.cs:232
            public Type_Implementation()                                                                                                    // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 20. TerminologyCapabilities.implementation.description
                    this.Element_Description = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Description",                                                                                       // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 21. TerminologyCapabilities.implementation.url
                    this.Element_Url = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Url",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Url()                                                                       // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 23. TerminologyCapabilities.codeSystem
        public class Type_CodeSystem : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 25. TerminologyCapabilities.codeSystem.version
            public class Type_Version : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 30. TerminologyCapabilities.codeSystem.version.filter
                public class Type_Filter : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 31. TerminologyCapabilities.codeSystem.version.filter.code
                    public MakerElementInstance Element_Code;                                                                               // MakerGen.cs:232
                    // 32. TerminologyCapabilities.codeSystem.version.filter.op
                    public MakerElementInstance Element_Op;                                                                                 // MakerGen.cs:232
                    public Type_Filter()                                                                                                    // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 31. TerminologyCapabilities.codeSystem.version.filter.code
                            this.Element_Code = new MakerElementInstance                                                                    // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Code",                                                                                      // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Code()                                                              // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 32. TerminologyCapabilities.codeSystem.version.filter.op
                            this.Element_Op = new MakerElementInstance                                                                      // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Op",                                                                                        // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Code()                                                              // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                // 26. TerminologyCapabilities.codeSystem.version.code
                public MakerElementInstance Element_Code;                                                                                   // MakerGen.cs:232
                // 27. TerminologyCapabilities.codeSystem.version.isDefault
                public MakerElementInstance Element_IsDefault;                                                                              // MakerGen.cs:232
                // 28. TerminologyCapabilities.codeSystem.version.compositional
                public MakerElementInstance Element_Compositional;                                                                          // MakerGen.cs:232
                // 29. TerminologyCapabilities.codeSystem.version.language
                public MakerElementInstance Element_Language;                                                                               // MakerGen.cs:232
                // 33. TerminologyCapabilities.codeSystem.version.property
                public MakerElementInstance Element_Property;                                                                               // MakerGen.cs:232
                public Type_Version()                                                                                                       // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 26. TerminologyCapabilities.codeSystem.version.code
                        this.Element_Code = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Code",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 27. TerminologyCapabilities.codeSystem.version.isDefault
                        this.Element_IsDefault = new MakerElementInstance                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_IsDefault",                                                                                     // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Boolean()                                                               // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 28. TerminologyCapabilities.codeSystem.version.compositional
                        this.Element_Compositional = new MakerElementInstance                                                               // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Compositional",                                                                                 // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Boolean()                                                               // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 29. TerminologyCapabilities.codeSystem.version.language
                        this.Element_Language = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Language",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Code()                                                                  // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 33. TerminologyCapabilities.codeSystem.version.property
                        this.Element_Property = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Property",                                                                                      // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Code()                                                                  // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 24. TerminologyCapabilities.codeSystem.uri
            public MakerElementInstance Element_Uri;                                                                                        // MakerGen.cs:232
            // 34. TerminologyCapabilities.codeSystem.subsumption
            public MakerElementInstance Element_Subsumption;                                                                                // MakerGen.cs:232
            public Type_CodeSystem()                                                                                                        // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 24. TerminologyCapabilities.codeSystem.uri
                    this.Element_Uri = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Uri",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Canonical()                                                                 // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 34. TerminologyCapabilities.codeSystem.subsumption
                    this.Element_Subsumption = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Subsumption",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 35. TerminologyCapabilities.expansion
        public class Type_Expansion : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 39. TerminologyCapabilities.expansion.parameter
            public class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 40. TerminologyCapabilities.expansion.parameter.name
                public MakerElementInstance Element_Name;                                                                                   // MakerGen.cs:232
                // 41. TerminologyCapabilities.expansion.parameter.documentation
                public MakerElementInstance Element_Documentation;                                                                          // MakerGen.cs:232
                public Type_Parameter()                                                                                                     // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 40. TerminologyCapabilities.expansion.parameter.name
                        this.Element_Name = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Name",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Code()                                                                  // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 41. TerminologyCapabilities.expansion.parameter.documentation
                        this.Element_Documentation = new MakerElementInstance                                                               // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Documentation",                                                                                 // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 36. TerminologyCapabilities.expansion.hierarchical
            public MakerElementInstance Element_Hierarchical;                                                                               // MakerGen.cs:232
            // 37. TerminologyCapabilities.expansion.paging
            public MakerElementInstance Element_Paging;                                                                                     // MakerGen.cs:232
            // 38. TerminologyCapabilities.expansion.incomplete
            public MakerElementInstance Element_Incomplete;                                                                                 // MakerGen.cs:232
            // 42. TerminologyCapabilities.expansion.textFilter
            public MakerElementInstance Element_TextFilter;                                                                                 // MakerGen.cs:232
            public Type_Expansion()                                                                                                         // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 36. TerminologyCapabilities.expansion.hierarchical
                    this.Element_Hierarchical = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Hierarchical",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 37. TerminologyCapabilities.expansion.paging
                    this.Element_Paging = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Paging",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 38. TerminologyCapabilities.expansion.incomplete
                    this.Element_Incomplete = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Incomplete",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 42. TerminologyCapabilities.expansion.textFilter
                    this.Element_TextFilter = new MakerElementInstance                                                                      // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_TextFilter",                                                                                        // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Markdown()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 44. TerminologyCapabilities.validateCode
        public class Type_ValidateCode : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 45. TerminologyCapabilities.validateCode.translations
            public MakerElementInstance Element_Translations;                                                                               // MakerGen.cs:232
            public Type_ValidateCode()                                                                                                      // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 45. TerminologyCapabilities.validateCode.translations
                    this.Element_Translations = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Translations",                                                                                      // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 46. TerminologyCapabilities.translation
        public class Type_Translation : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 47. TerminologyCapabilities.translation.needsMap
            public MakerElementInstance Element_NeedsMap;                                                                                   // MakerGen.cs:232
            public Type_Translation()                                                                                                       // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 47. TerminologyCapabilities.translation.needsMap
                    this.Element_NeedsMap = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_NeedsMap",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 48. TerminologyCapabilities.closure
        public class Type_Closure : FhirKhit.Maker.Common.Complex.ComplexBase                                                               // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 49. TerminologyCapabilities.closure.translation
            public MakerElementInstance Element_Translation;                                                                                // MakerGen.cs:232
            public Type_Closure()                                                                                                           // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 49. TerminologyCapabilities.closure.translation
                    this.Element_Translation = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Translation",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Boolean()                                                                   // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. TerminologyCapabilities.url
        public MakerElementInstance Element_Url;                                                                                            // MakerGen.cs:232
        // 2. TerminologyCapabilities.version
        public MakerElementInstance Element_Version;                                                                                        // MakerGen.cs:232
        // 3. TerminologyCapabilities.name
        public MakerElementInstance Element_Name;                                                                                           // MakerGen.cs:232
        // 4. TerminologyCapabilities.title
        public MakerElementInstance Element_Title;                                                                                          // MakerGen.cs:232
        // 5. TerminologyCapabilities.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 6. TerminologyCapabilities.experimental
        public MakerElementInstance Element_Experimental;                                                                                   // MakerGen.cs:232
        // 7. TerminologyCapabilities.date
        public MakerElementInstance Element_Date;                                                                                           // MakerGen.cs:232
        // 8. TerminologyCapabilities.publisher
        public MakerElementInstance Element_Publisher;                                                                                      // MakerGen.cs:232
        // 9. TerminologyCapabilities.contact
        public MakerElementInstance Element_Contact;                                                                                        // MakerGen.cs:232
        // 10. TerminologyCapabilities.description
        public MakerElementInstance Element_Description;                                                                                    // MakerGen.cs:232
        // 11. TerminologyCapabilities.useContext
        public MakerElementInstance Element_UseContext;                                                                                     // MakerGen.cs:232
        // 12. TerminologyCapabilities.jurisdiction
        public MakerElementInstance Element_Jurisdiction;                                                                                   // MakerGen.cs:232
        // 13. TerminologyCapabilities.purpose
        public MakerElementInstance Element_Purpose;                                                                                        // MakerGen.cs:232
        // 14. TerminologyCapabilities.copyright
        public MakerElementInstance Element_Copyright;                                                                                      // MakerGen.cs:232
        // 15. TerminologyCapabilities.kind
        public MakerElementInstance Element_Kind;                                                                                           // MakerGen.cs:232
        // 22. TerminologyCapabilities.lockedDate
        public MakerElementInstance Element_LockedDate;                                                                                     // MakerGen.cs:232
        // 43. TerminologyCapabilities.codeSearch
        public MakerElementInstance Element_CodeSearch;                                                                                     // MakerGen.cs:232
        public TerminologyCapabilities()                                                                                                    // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. TerminologyCapabilities.url
                this.Element_Url = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Uri()                                                                           // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. TerminologyCapabilities.version
                this.Element_Version = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Version",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. TerminologyCapabilities.name
                this.Element_Name = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. TerminologyCapabilities.title
                this.Element_Title = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Title",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. TerminologyCapabilities.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. TerminologyCapabilities.experimental
                this.Element_Experimental = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Experimental",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean()                                                                       // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. TerminologyCapabilities.date
                this.Element_Date = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. TerminologyCapabilities.publisher
                this.Element_Publisher = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 9. TerminologyCapabilities.contact
                this.Element_Contact = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 10. TerminologyCapabilities.description
                this.Element_Description = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Description",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 11. TerminologyCapabilities.useContext
                this.Element_UseContext = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 12. TerminologyCapabilities.jurisdiction
                this.Element_Jurisdiction = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 13. TerminologyCapabilities.purpose
                this.Element_Purpose = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Purpose",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 14. TerminologyCapabilities.copyright
                this.Element_Copyright = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Copyright",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 15. TerminologyCapabilities.kind
                this.Element_Kind = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Kind",                                                                                                  // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 22. TerminologyCapabilities.lockedDate
                this.Element_LockedDate = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_LockedDate",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean()                                                                       // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 43. TerminologyCapabilities.codeSearch
                this.Element_CodeSearch = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_CodeSearch",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
