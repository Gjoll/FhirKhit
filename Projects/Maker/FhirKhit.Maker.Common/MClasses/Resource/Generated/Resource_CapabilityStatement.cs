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
      "id": "CapabilityStatement",
      "url": "http://hl7.org/fhir/StructureDefinition/CapabilityStatement",
      "version": "4.0.0",
      "name": "CapabilityStatement",
      "status": "active",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A Capability Statement documents a set of capabilities (behaviors) of a FHIR Server for a particular version of FHIR that may be used as a statement of actual server functionality or a statement of required or desired server implementation.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "CapabilityStatement",
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
            "id": "CapabilityStatement",
            "path": "CapabilityStatement",
            "short": "A statement of system capabilities",
            "definition": "A Capability Statement documents a set of capabilities (behaviors) of a FHIR Server for a particular version of FHIR that may be used as a statement of actual server functionality or a statement of required or desired server implementation.",
            "comment": "Applications may implement multiple versions (see [Managing Multiple Versions](versioning.html), and the [$versions](capabilitystatement-operation-versions.html) operation). If they do, then a CapabilityStatement describes the system's support for a particular version of FHIR, and the server will have multiple statements, one for each version.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "CapabilityStatement.url",
            "path": "CapabilityStatement.url",
            "short": "Canonical identifier for this capability statement, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this capability statement when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this capability statement is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the capability statement is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the capability statement to be referenced by a single globally unique identifier.",
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
            "id": "CapabilityStatement.version",
            "path": "CapabilityStatement.version",
            "short": "Business version of the capability statement",
            "definition": "The identifier that is used to identify this version of the capability statement when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the capability statement author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different capability statement instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the capability statement with the format [url]|[version].",
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
            "id": "CapabilityStatement.name",
            "path": "CapabilityStatement.name",
            "short": "Name for this capability statement (computer friendly)",
            "definition": "A natural language name identifying the capability statement. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "CapabilityStatement.title",
            "path": "CapabilityStatement.title",
            "short": "Name for this capability statement (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the capability statement.",
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
            "id": "CapabilityStatement.status",
            "path": "CapabilityStatement.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this capability statement. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of capability statements that are appropriate for use versus not.This is not intended for use with actual capability statements, but where capability statements are used to describe possible or desired systems.",
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
            "id": "CapabilityStatement.experimental",
            "path": "CapabilityStatement.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this capability statement is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of capability statements that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level capability statement.",
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
            "id": "CapabilityStatement.date",
            "path": "CapabilityStatement.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the capability statement was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the capability statement changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the capability statement. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "CapabilityStatement.publisher",
            "path": "CapabilityStatement.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the capability statement.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the capability statement is the organization or individual primarily responsible for the maintenance and upkeep of the capability statement. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the capability statement. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the capability statement.  May also allow for contact.",
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
            "id": "CapabilityStatement.contact",
            "path": "CapabilityStatement.contact",
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
            "id": "CapabilityStatement.description",
            "path": "CapabilityStatement.description",
            "short": "Natural language description of the capability statement",
            "definition": "A free text natural language description of the capability statement from a consumer's perspective. Typically, this is used when the capability statement describes a desired rather than an actual solution, for example as a formal expression of requirements as part of an RFP.",
            "comment": "This description can be used to capture details such as why the capability statement was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the capability statement as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the capability statement is presumed to be the predominant language in the place the capability statement was created).This does not need to be populated if the description is adequately implied by the software or implementation details.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ],
            "condition": [
              "cpb-2"
            ]
          },
          {
            "id": "CapabilityStatement.useContext",
            "path": "CapabilityStatement.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate capability statement instances.",
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
            "id": "CapabilityStatement.jurisdiction",
            "path": "CapabilityStatement.jurisdiction",
            "short": "Intended jurisdiction for capability statement (if applicable)",
            "definition": "A legal or geographic region in which the capability statement is intended to be used.",
            "comment": "It may be possible for the capability statement to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "CapabilityStatement.purpose",
            "path": "CapabilityStatement.purpose",
            "short": "Why this capability statement is defined",
            "definition": "Explanation of why this capability statement is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the capability statement. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this capability statement.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "CapabilityStatement.copyright",
            "path": "CapabilityStatement.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the capability statement and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the capability statement.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the capability statement and/or its content.",
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
            "id": "CapabilityStatement.kind",
            "path": "CapabilityStatement.kind",
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
              "cpb-15"
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
            "id": "CapabilityStatement.instantiates",
            "path": "CapabilityStatement.instantiates",
            "short": "Canonical URL of another capability statement this implements",
            "definition": "Reference to a canonical URL of another CapabilityStatement that this software implements. This capability statement is a published API description that corresponds to a business service. The server may actually implement a subset of the capability statement it claims to implement, so the capability statement must specify the full capability details.",
            "comment": "HL7 defines the following Services: [Terminology Service](terminology-service.html).    \n\nMany [Implementation Guides](http://fhir.org/guides/registry) define additional services.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CapabilityStatement"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.imports",
            "path": "CapabilityStatement.imports",
            "short": "Canonical URL of another capability statement this adds to",
            "definition": "Reference to a canonical URL of another CapabilityStatement that this software adds to. The capability statement automatically includes everything in the other statement, and it is not duplicated, though the server may repeat the same resources, interactions and operations to add additional details to them.",
            "comment": "the contents of any directly or indirectly imported CapabilityStatements SHALL NOT overlap, i.e. they cannot refer to the same rest/resource, operations/name, searchparam/name, interaction/code, messaging/endpoint, document/mode pair.\n\nA capability statement that imports another CapabilityStatement automatically instantiates it too (though this is often not a very useful statement for the kinds of CapabilityStatements that are suitable for importing).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CapabilityStatement"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.software",
            "path": "CapabilityStatement.software",
            "short": "Software that is covered by this capability statement",
            "definition": "Software that is covered by this capability statement.  It is used when the capability statement describes the capabilities of a particular software version, independent of an installation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "cpb-2"
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.software.name",
            "path": "CapabilityStatement.software.name",
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
            "id": "CapabilityStatement.software.version",
            "path": "CapabilityStatement.software.version",
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
            "id": "CapabilityStatement.software.releaseDate",
            "path": "CapabilityStatement.software.releaseDate",
            "short": "Date this version was released",
            "definition": "Date this version of the software was released.",
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
            "id": "CapabilityStatement.implementation",
            "path": "CapabilityStatement.implementation",
            "short": "If this describes a specific instance",
            "definition": "Identifies a specific implementation instance that is described by the capability statement - i.e. a particular installation, rather than the capabilities of a software program.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "cpb-2",
              "cpb-15"
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.implementation.description",
            "path": "CapabilityStatement.implementation.description",
            "short": "Describes this specific instance",
            "definition": "Information about the specific installation that this capability statement relates to.",
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
            "id": "CapabilityStatement.implementation.url",
            "path": "CapabilityStatement.implementation.url",
            "short": "Base URL for the installation",
            "definition": "An absolute base URL for the implementation.  This forms the base for REST interfaces as well as the mailbox and document interfaces.",
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
            "id": "CapabilityStatement.implementation.custodian",
            "path": "CapabilityStatement.implementation.custodian",
            "short": "Organization that manages the data",
            "definition": "The organization responsible for the management of the instance and oversight of the data on the server at the specified URL.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.fhirVersion",
            "path": "CapabilityStatement.fhirVersion",
            "short": "FHIR Version the system supports",
            "definition": "The version of the FHIR specification that this CapabilityStatement describes (which SHALL be the same as the FHIR version of the CapabilityStatement itself). There is no default value.",
            "comment": "Servers may implement multiple versions (see [Managing Multiple Versions](versioning.html), and the [$versions](capabilitystatement-operation-versions.html) operation). If they do, and the CapabilityStatement is requested from the server, then this fhirVersion will be either the version requested, or the server's default version.",
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
            "id": "CapabilityStatement.format",
            "path": "CapabilityStatement.format",
            "short": "formats supported (xml | json | ttl | mime type)",
            "definition": "A list of the formats supported by this implementation using their content types.",
            "comment": "\"xml\", \"json\" and \"ttl\" are allowed, which describe the simple encodings described in the specification (and imply appropriate bundle support). Otherwise, mime types are legal here.",
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
                  "valueString": "MimeType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The mime type of an attachment. Any valid mime type is allowed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/mimetypes|4.0.0"
            }
          },
          {
            "id": "CapabilityStatement.patchFormat",
            "path": "CapabilityStatement.patchFormat",
            "short": "Patch formats supported",
            "definition": "A list of the patch formats supported by this implementation using their content types.",
            "comment": "At present, the patch mime types application/json-patch+json and application/xml-patch+xml are legal. Generally, if a server supports PATCH, it would be expected to support the patch formats and match the formats it supports, but this is not always possible or necessary.",
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
                  "valueString": "MimeType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The mime type of an attachment. Any valid mime type is allowed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/mimetypes|4.0.0"
            }
          },
          {
            "id": "CapabilityStatement.implementationGuide",
            "path": "CapabilityStatement.implementationGuide",
            "short": "Implementation guides supported",
            "definition": "A list of implementation guides that the server does (or should) support in their entirety.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ImplementationGuide"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.rest",
            "path": "CapabilityStatement.rest",
            "short": "If the endpoint is a RESTful one",
            "definition": "A definition of the restful capabilities of the solution, if any.",
            "comment": "Multiple repetitions allow definition of both client and/or server behaviors or possibly behaviors under different configuration settings (for software or requirements statements).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "cpb-1"
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.rest.mode",
            "path": "CapabilityStatement.rest.mode",
            "short": "client | server",
            "definition": "Identifies whether this portion of the statement is describing the ability to initiate or receive restful operations.",
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
                  "valueString": "RestfulCapabilityMode"
                }
              ],
              "strength": "required",
              "description": "The mode of a RESTful capability statement.",
              "valueSet": "http://hl7.org/fhir/ValueSet/restful-capability-mode|4.0.0"
            }
          },
          {
            "id": "CapabilityStatement.rest.documentation",
            "path": "CapabilityStatement.rest.documentation",
            "short": "General description of implementation",
            "definition": "Information about the system's restful capabilities that apply across all applications, such as security.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.security",
            "path": "CapabilityStatement.rest.security",
            "short": "Information about security of implementation",
            "definition": "Information about security implementation from an interface perspective - what a client needs to know.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.rest.security.cors",
            "path": "CapabilityStatement.rest.security.cors",
            "short": "Adds CORS Headers (http://enable-cors.org/)",
            "definition": "Server adds CORS headers when responding to requests - this enables Javascript applications to use the server.",
            "comment": "The easiest CORS headers to add are Access-Control-Allow-Origin: * & Access-Control-Request-Method: GET, POST, PUT, DELETE. All servers SHOULD support CORS.",
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
            "id": "CapabilityStatement.rest.security.service",
            "path": "CapabilityStatement.rest.security.service",
            "short": "OAuth | SMART-on-FHIR | NTLM | Basic | Kerberos | Certificates",
            "definition": "Types of security services that are supported/required by the system.",
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
                  "valueString": "RestfulSecurityService"
                }
              ],
              "strength": "extensible",
              "description": "Types of security services used with FHIR.",
              "valueSet": "http://hl7.org/fhir/ValueSet/restful-security-service"
            }
          },
          {
            "id": "CapabilityStatement.rest.security.description",
            "path": "CapabilityStatement.rest.security.description",
            "short": "General description of how security works",
            "definition": "General description of how security works.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.resource",
            "path": "CapabilityStatement.rest.resource",
            "short": "Resource served on the REST interface",
            "definition": "A specification of the restful capabilities of the solution for a specific resource type.",
            "comment": "Max of one repetition per resource type.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.rest.resource.type",
            "path": "CapabilityStatement.rest.resource.type",
            "short": "A resource type that is supported",
            "definition": "A type of resource exposed via the restful interface.",
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
            "id": "CapabilityStatement.rest.resource.profile",
            "path": "CapabilityStatement.rest.resource.profile",
            "short": "Base System profile for all uses of resource",
            "definition": "A specification of the profile that describes the solution's overall support for the resource, including any constraints on cardinality, bindings, lengths or other limitations. See further discussion in [Using Profiles](profiling.html#profile-uses).",
            "comment": "The profile applies to all  resources of this type - i.e. it is the superset of what is supported by the system.",
            "min": 0,
            "max": "1",
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
            "id": "CapabilityStatement.rest.resource.supportedProfile",
            "path": "CapabilityStatement.rest.resource.supportedProfile",
            "short": "Profiles for use cases supported",
            "definition": "A list of profiles that represent different use cases supported by the system. For a server, \"supported by the system\" means the system hosts/produces a set of resources that are conformant to a particular profile, and allows clients that use its services to search using this profile and to find appropriate data. For a client, it means the system will search by this profile and process data according to the guidance implicit in the profile. See further discussion in [Using Profiles](profiling.html#profile-uses).",
            "comment": "Supported profiles are different than the profile that applies to a particular resource in .rest.resource.profile. The resource profile is a general statement of what features of the resource are supported overall by the system - the sum total of the facilities it supports. A supported profile is a deeper statement about the functionality of the data and services provided by the server (or used by the client). A typical case is a laboratory system that produces a set of different reports - this is the list of types of data that it publishes. A key aspect of declaring profiles here is the question of how the client converts knowledge that the server publishes this data into working with the data; the client can inspect individual resources to determine whether they conform to a particular profile, but how does it find the ones that do? It does so by searching using the _profile parameter, so any resources listed here must be valid values for the _profile resource (using the identifier in the target profile).",
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
            "id": "CapabilityStatement.rest.resource.documentation",
            "path": "CapabilityStatement.rest.resource.documentation",
            "short": "Additional information about the use of the resource type",
            "definition": "Additional information about the resource type used by the system.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.resource.interaction",
            "path": "CapabilityStatement.rest.resource.interaction",
            "short": "What operations are supported?",
            "definition": "Identifies a restful operation supported by the solution.",
            "comment": "In general, a Resource will only appear in a CapabilityStatement if the server actually has some capabilities - e.g. there is at least one interaction supported. However interactions can be omitted to support summarization (_summary = true).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.resource.interaction.code",
            "path": "CapabilityStatement.rest.resource.interaction.code",
            "short": "read | vread | update | patch | delete | history-instance | history-type | create | search-type",
            "definition": "Coded identifier of the operation, supported by the system resource.",
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
                  "valueString": "TypeRestfulInteraction"
                }
              ],
              "strength": "required",
              "description": "Operations supported by REST at the type or instance level.",
              "valueSet": "http://hl7.org/fhir/ValueSet/type-restful-interaction|4.0.0"
            }
          },
          {
            "id": "CapabilityStatement.rest.resource.interaction.documentation",
            "path": "CapabilityStatement.rest.resource.interaction.documentation",
            "short": "Anything special about operation behavior",
            "definition": "Guidance specific to the implementation of this operation, such as 'delete is a logical delete' or 'updates are only allowed with version id' or 'creates permitted from pre-authorized certificates only'.",
            "requirements": "REST allows a degree of variability in the implementation of RESTful solutions that is useful for exchange partners to be aware of.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.resource.versioning",
            "path": "CapabilityStatement.rest.resource.versioning",
            "short": "no-version | versioned | versioned-update",
            "definition": "This field is set to no-version to specify that the system does not support (server) or use (client) versioning for this resource type. If this has some other value, the server must at least correctly track and populate the versionId meta-property on resources. If the value is 'versioned-update', then the server supports all the versioning features, including using e-tags for version integrity in the API.",
            "comment": "If a server supports versionIds correctly, it SHOULD support vread too, but is not required to do so.",
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
                  "valueString": "ResourceVersionPolicy"
                }
              ],
              "strength": "required",
              "description": "How the system supports versioning for a resource.",
              "valueSet": "http://hl7.org/fhir/ValueSet/versioning-policy|4.0.0"
            }
          },
          {
            "id": "CapabilityStatement.rest.resource.readHistory",
            "path": "CapabilityStatement.rest.resource.readHistory",
            "short": "Whether vRead can return past versions",
            "definition": "A flag for whether the server is able to return past versions as part of the vRead operation.",
            "comment": "It is useful to support the vRead operation for current operations, even if past versions aren't available.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.resource.updateCreate",
            "path": "CapabilityStatement.rest.resource.updateCreate",
            "short": "If update can commit to a new identity",
            "definition": "A flag to indicate that the server allows or needs to allow the client to create new identities on the server (that is, the client PUTs to a location where there is no existing resource). Allowing this operation means that the server allows the client to create new identities on the server.",
            "comment": "Allowing the clients to create new identities on the server means that the system administrator needs to have confidence that the clients do not create clashing identities between them. Obviously, if there is only one client, this won't happen. While creating identities on the client means that the clients need to be managed, it's much more convenient for many scenarios if such management can be put in place.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.resource.conditionalCreate",
            "path": "CapabilityStatement.rest.resource.conditionalCreate",
            "short": "If allows/uses conditional create",
            "definition": "A flag that indicates that the server supports conditional create.",
            "comment": "Conditional Create is mainly appropriate for interface engine scripts converting from other formats, such as v2.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.resource.conditionalRead",
            "path": "CapabilityStatement.rest.resource.conditionalRead",
            "short": "not-supported | modified-since | not-match | full-support",
            "definition": "A code that indicates how the server supports conditional read.",
            "comment": "Conditional Read is mainly appropriate for interface engine scripts converting from other formats, such as v2.",
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
                  "valueString": "ConditionalReadStatus"
                }
              ],
              "strength": "required",
              "description": "A code that indicates how the server supports conditional read.",
              "valueSet": "http://hl7.org/fhir/ValueSet/conditional-read-status|4.0.0"
            }
          },
          {
            "id": "CapabilityStatement.rest.resource.conditionalUpdate",
            "path": "CapabilityStatement.rest.resource.conditionalUpdate",
            "short": "If allows/uses conditional update",
            "definition": "A flag that indicates that the server supports conditional update.",
            "comment": "Conditional Update is mainly appropriate for interface engine scripts converting from other formats, such as v2.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.resource.conditionalDelete",
            "path": "CapabilityStatement.rest.resource.conditionalDelete",
            "short": "not-supported | single | multiple - how conditional delete is supported",
            "definition": "A code that indicates how the server supports conditional delete.",
            "comment": "Conditional Delete is mainly appropriate for interface engine scripts converting from other formats, such as v2.",
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
                  "valueString": "ConditionalDeleteStatus"
                }
              ],
              "strength": "required",
              "description": "A code that indicates how the server supports conditional delete.",
              "valueSet": "http://hl7.org/fhir/ValueSet/conditional-delete-status|4.0.0"
            }
          },
          {
            "id": "CapabilityStatement.rest.resource.referencePolicy",
            "path": "CapabilityStatement.rest.resource.referencePolicy",
            "short": "literal | logical | resolves | enforced | local",
            "definition": "A set of flags that defines how references are supported.",
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
                  "valueString": "ReferenceHandlingPolicy"
                }
              ],
              "strength": "required",
              "description": "A set of flags that defines how references are supported.",
              "valueSet": "http://hl7.org/fhir/ValueSet/reference-handling-policy|4.0.0"
            }
          },
          {
            "id": "CapabilityStatement.rest.resource.searchInclude",
            "path": "CapabilityStatement.rest.resource.searchInclude",
            "short": "_include values supported by the server",
            "definition": "A list of _include values supported by the server.",
            "comment": "If this list is empty, the server does not support includes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.resource.searchRevInclude",
            "path": "CapabilityStatement.rest.resource.searchRevInclude",
            "short": "_revinclude values supported by the server",
            "definition": "A list of _revinclude (reverse include) values supported by the server.",
            "comment": "If this list is empty, the server does not support reverse includes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.resource.searchParam",
            "path": "CapabilityStatement.rest.resource.searchParam",
            "short": "Search parameters supported by implementation",
            "definition": "Search parameters for implementations to support and/or make use of - either references to ones defined in the specification, or additional ones defined for/by the implementation.",
            "comment": "The search parameters should include the control search parameters such as _sort, _count, etc. that also apply to this resource (though many will be listed at [CapabilityStatement.rest.searchParam](capabilitystatement-definitions.html#CapabilityStatement.rest.searchParam)). The behavior of some search parameters may be further described by other code or extension elements, or narrative within the capability statement or linked [SearchParameter](searchparameter.html#) definitions.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.resource.searchParam.name",
            "path": "CapabilityStatement.rest.resource.searchParam.name",
            "short": "Name of search parameter",
            "definition": "The name of the search parameter used in the interface.",
            "comment": "Parameter names cannot overlap with standard parameter names, and standard parameters cannot be redefined.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.resource.searchParam.definition",
            "path": "CapabilityStatement.rest.resource.searchParam.definition",
            "short": "Source of definition for parameter",
            "definition": "An absolute URI that is a formal reference to where this parameter was first defined, so that a client can be confident of the meaning of the search parameter (a reference to [SearchParameter.url](searchparameter-definitions.html#SearchParameter.url)). This element SHALL be populated if the search parameter refers to a SearchParameter defined by the FHIR core specification or externally defined IGs.",
            "comment": "This SHOULD be present, and matches refers to a SearchParameter by its canonical URL. If systems wish to document their support for modifiers, comparators, target resource types, and chained parameters, they should do using a search parameter resource. This element SHALL be populated if the search parameter refers to a SearchParameter defined by the FHIR core specification or externally defined IGs.",
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
            "id": "CapabilityStatement.rest.resource.searchParam.type",
            "path": "CapabilityStatement.rest.resource.searchParam.type",
            "short": "number | date | string | token | reference | composite | quantity | uri | special",
            "definition": "The type of value a search parameter refers to, and how the content is interpreted.",
            "comment": "While this can be looked up from the definition, it is included here as a convenience for systems that autogenerate a query interface based on the server capability statement.  It SHALL be the same as the type in the search parameter definition.",
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
            "id": "CapabilityStatement.rest.resource.searchParam.documentation",
            "path": "CapabilityStatement.rest.resource.searchParam.documentation",
            "short": "Server-specific usage",
            "definition": "This allows documentation of any distinct behaviors about how the search parameter is used.  For example, text matching algorithms.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.resource.operation",
            "path": "CapabilityStatement.rest.resource.operation",
            "short": "Definition of a resource operation",
            "definition": "Definition of an operation or a named query together with its parameters and their meaning and type. Consult the definition of the operation for details about how to invoke the operation, and the parameters.",
            "comment": "Operations linked from CapabilityStatement.rest.resource.operation must have OperationDefinition.type = true or OperationDefinition.instance = true.    \n\nIf an operation that is listed in multiple CapabilityStatement.rest.resource.operation (e.g. for different resource types), then clients should understand that the operation is only supported on the specified resource types, and that may be a subset of those listed in OperationDefinition.resource.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.rest.resource.operation.name",
            "path": "CapabilityStatement.rest.resource.operation.name",
            "short": "Name by which the operation/query is invoked",
            "definition": "The name of the operation or query. For an operation, this is the name  prefixed with $ and used in the URL. For a query, this is the name used in the _query parameter when the query is called.",
            "comment": "The name here SHOULD be the same as the name in the definition, unless there is a name clash and the name cannot be used. The name does not include the \"$\" portion that is always included in the URL.",
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
            "id": "CapabilityStatement.rest.resource.operation.definition",
            "path": "CapabilityStatement.rest.resource.operation.definition",
            "short": "The defined operation/query",
            "definition": "Where the formal definition can be found. If a server references the base definition of an Operation (i.e. from the specification itself such as ```http://hl7.org/fhir/OperationDefinition/ValueSet-expand```), that means it supports the full capabilities of the operation - e.g. both GET and POST invocation.  If it only supports a subset, it must define its own custom [OperationDefinition](operationdefinition.html#) with a 'base' of the original OperationDefinition.  The custom definition would describe the specific subset of functionality supported.",
            "comment": "This can be used to build an HTML form to invoke the operation, for instance.",
            "min": 1,
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
            "id": "CapabilityStatement.rest.resource.operation.documentation",
            "path": "CapabilityStatement.rest.resource.operation.documentation",
            "short": "Specific details about operation behavior",
            "definition": "Documentation that describes anything special about the operation behavior, possibly detailing different behavior for system, type and instance-level invocation of the operation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.interaction",
            "path": "CapabilityStatement.rest.interaction",
            "short": "What operations are supported?",
            "definition": "A specification of restful operations supported by the system.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.interaction.code",
            "path": "CapabilityStatement.rest.interaction.code",
            "short": "transaction | batch | search-system | history-system",
            "definition": "A coded identifier of the operation, supported by the system.",
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
                  "valueString": "SystemRestfulInteraction"
                }
              ],
              "strength": "required",
              "description": "Operations supported by REST at the system level.",
              "valueSet": "http://hl7.org/fhir/ValueSet/system-restful-interaction|4.0.0"
            }
          },
          {
            "id": "CapabilityStatement.rest.interaction.documentation",
            "path": "CapabilityStatement.rest.interaction.documentation",
            "short": "Anything special about operation behavior",
            "definition": "Guidance specific to the implementation of this operation, such as limitations on the kind of transactions allowed, or information about system wide search is implemented.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "CapabilityStatement.rest.searchParam",
            "path": "CapabilityStatement.rest.searchParam",
            "short": "Search parameters for searching all resources",
            "definition": "Search parameters that are supported for searching all resources for implementations to support and/or make use of - either references to ones defined in the specification, or additional ones defined for/by the implementation.",
            "comment": "Typically, the only search parameters supported for all searches are those that apply to all resources - tags, profiles, text search etc. These search parameters should include the control search parameters such as _sort, _count, etc. that also apply to this resource (though many will be listed at [CapabilityStatement.rest.searchParam](capabilitystatement-definitions.html#CapabilityStatement.rest.searchParam)). The behavior of some search parameters may be further described by other code or extension elements, or narrative within the capability statement or linked [SearchParameter](searchparameter.html#) definitions.",
            "min": 0,
            "max": "*",
            "contentReference": "#CapabilityStatement.rest.resource.searchParam"
          },
          {
            "id": "CapabilityStatement.rest.operation",
            "path": "CapabilityStatement.rest.operation",
            "short": "Definition of a system level operation",
            "definition": "Definition of an operation or a named query together with its parameters and their meaning and type.",
            "comment": "CapabilityStatement.rest.operation is for operations invoked at the system level, or for operations that are supported across multiple resource types. Operations linked from CapabilityStatement.rest.operation must have OperationDefinition.system = true, or more than one Operation.resource.",
            "min": 0,
            "max": "*",
            "contentReference": "#CapabilityStatement.rest.resource.operation",
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.rest.compartment",
            "path": "CapabilityStatement.rest.compartment",
            "short": "Compartments served/used by system",
            "definition": "An absolute URI which is a reference to the definition of a compartment that the system supports. The reference is to a CompartmentDefinition resource by its canonical URL .",
            "comment": "At present, the only defined compartments are at [CompartmentDefinition](compartmentdefinition.html).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CompartmentDefinition"
                ]
              }
            ]
          },
          {
            "id": "CapabilityStatement.messaging",
            "path": "CapabilityStatement.messaging",
            "short": "If messaging is supported",
            "definition": "A description of the messaging capabilities of the solution.",
            "comment": "Multiple repetitions allow the documentation of multiple endpoints per solution.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "cpb-1"
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.messaging.endpoint",
            "path": "CapabilityStatement.messaging.endpoint",
            "short": "Where messages should be sent",
            "definition": "An endpoint (network accessible address) to which messages and/or replies are to be sent.",
            "alias": [
              "3"
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
            "id": "CapabilityStatement.messaging.endpoint.protocol",
            "path": "CapabilityStatement.messaging.endpoint.protocol",
            "short": "http | ftp | mllp +",
            "definition": "A list of the messaging transport protocol(s) identifiers, supported by this endpoint.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "MessageTransport"
                }
              ],
              "strength": "extensible",
              "description": "The protocol used for message transport.",
              "valueSet": "http://hl7.org/fhir/ValueSet/message-transport"
            }
          },
          {
            "id": "CapabilityStatement.messaging.endpoint.address",
            "path": "CapabilityStatement.messaging.endpoint.address",
            "short": "Network address or identifier of the end-point",
            "definition": "The network address of the endpoint. For solutions that do not use network addresses for routing, it can be just an identifier.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "url"
              }
            ]
          },
          {
            "id": "CapabilityStatement.messaging.reliableCache",
            "path": "CapabilityStatement.messaging.reliableCache",
            "short": "Reliable Message Cache Length (min)",
            "definition": "Length if the receiver's reliable messaging cache in minutes (if a receiver) or how long the cache length on the receiver should be (if a sender).",
            "comment": "If this value is missing then the application does not implement (receiver) or depend on (sender) reliable messaging.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ]
          },
          {
            "id": "CapabilityStatement.messaging.documentation",
            "path": "CapabilityStatement.messaging.documentation",
            "short": "Messaging interface behavior details",
            "definition": "Documentation about the system's messaging capabilities for this endpoint not otherwise documented by the capability statement.  For example, the process for becoming an authorized messaging exchange partner.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "CapabilityStatement.messaging.supportedMessage",
            "path": "CapabilityStatement.messaging.supportedMessage",
            "short": "Messages supported by this system",
            "definition": "References to message definitions for messages this system can send or receive.",
            "comment": "This is a proposed alternative to the messaging.event structure.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.messaging.supportedMessage.mode",
            "path": "CapabilityStatement.messaging.supportedMessage.mode",
            "short": "sender | receiver",
            "definition": "The mode of this event declaration - whether application is sender or receiver.",
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
                  "valueString": "EventCapabilityMode"
                }
              ],
              "strength": "required",
              "description": "The mode of a message capability statement.",
              "valueSet": "http://hl7.org/fhir/ValueSet/event-capability-mode|4.0.0"
            }
          },
          {
            "id": "CapabilityStatement.messaging.supportedMessage.definition",
            "path": "CapabilityStatement.messaging.supportedMessage.definition",
            "short": "Message supported by this system",
            "definition": "Points to a message definition that identifies the messaging event, message structure, allowed responses, etc.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/MessageDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.document",
            "path": "CapabilityStatement.document",
            "short": "Document definition",
            "definition": "A document definition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "cpb-1"
            ],
            "isSummary": true
          },
          {
            "id": "CapabilityStatement.document.mode",
            "path": "CapabilityStatement.document.mode",
            "short": "producer | consumer",
            "definition": "Mode of this document declaration - whether an application is a producer or consumer.",
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
                  "valueString": "DocumentMode"
                }
              ],
              "strength": "required",
              "description": "Whether the application produces or consumes documents.",
              "valueSet": "http://hl7.org/fhir/ValueSet/document-mode|4.0.0"
            }
          },
          {
            "id": "CapabilityStatement.document.documentation",
            "path": "CapabilityStatement.document.documentation",
            "short": "Description of document support",
            "definition": "A description of how the application supports or uses the specified document profile.  For example, when documents are created, what action is taken with consumed documents, etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "CapabilityStatement.document.profile",
            "path": "CapabilityStatement.document.profile",
            "short": "Constraint on the resources used in the document",
            "definition": "A profile on the document Bundle that constrains which resources are present, and their contents.",
            "comment": "The profile is actually on the Bundle.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'CapabilityStatement'
    /// </summary>
    // 0. CapabilityStatement
    public partial class Resource_CapabilityStatement : FhirKhit.Maker.Common.Resource.Resource_DomainResource                              // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 18. CapabilityStatement.software
        public partial class Type_Software : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 19. CapabilityStatement.software.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:217
            // 20. CapabilityStatement.software.version
            public ElementDefinitionInfo Element_Version;                                                                                   // MakerGen.cs:217
            // 21. CapabilityStatement.software.releaseDate
            public ElementDefinitionInfo Element_ReleaseDate;                                                                               // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "CapabilityStatement.software",                                                                                  // MakerGen.cs:393
                    ElementId = "CapabilityStatement.software"                                                                              // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Version.Write(sDef);                                                                                                // MakerGen.cs:221
                Element_ReleaseDate.Write(sDef);                                                                                            // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Software()                                                                                                          // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 19. CapabilityStatement.software.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Name",                                                                                              // MakerGen.cs:236
                        Path= "CapabilityStatement.software.name",                                                                          // MakerGen.cs:237
                        Id = "CapabilityStatement.software.name",                                                                           // MakerGen.cs:238
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
                {                                                                                                                           // MakerGen.cs:232
                    // 20. CapabilityStatement.software.version
                    this.Element_Version = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Version",                                                                                           // MakerGen.cs:236
                        Path= "CapabilityStatement.software.version",                                                                       // MakerGen.cs:237
                        Id = "CapabilityStatement.software.version",                                                                        // MakerGen.cs:238
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
                    // 21. CapabilityStatement.software.releaseDate
                    this.Element_ReleaseDate = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ReleaseDate",                                                                                       // MakerGen.cs:236
                        Path= "CapabilityStatement.software.releaseDate",                                                                   // MakerGen.cs:237
                        Id = "CapabilityStatement.software.releaseDate",                                                                    // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                          // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 22. CapabilityStatement.implementation
        public partial class Type_Implementation : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 23. CapabilityStatement.implementation.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:217
            // 24. CapabilityStatement.implementation.url
            public ElementDefinitionInfo Element_Url;                                                                                       // MakerGen.cs:217
            // 25. CapabilityStatement.implementation.custodian
            public ElementDefinitionInfo Element_Custodian;                                                                                 // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "CapabilityStatement.implementation",                                                                            // MakerGen.cs:393
                    ElementId = "CapabilityStatement.implementation"                                                                        // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:221
                Element_Url.Write(sDef);                                                                                                    // MakerGen.cs:221
                Element_Custodian.Write(sDef);                                                                                              // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Implementation()                                                                                                    // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 23. CapabilityStatement.implementation.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Description",                                                                                       // MakerGen.cs:236
                        Path= "CapabilityStatement.implementation.description",                                                             // MakerGen.cs:237
                        Id = "CapabilityStatement.implementation.description",                                                              // MakerGen.cs:238
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
                {                                                                                                                           // MakerGen.cs:232
                    // 24. CapabilityStatement.implementation.url
                    this.Element_Url = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Url",                                                                                               // MakerGen.cs:236
                        Path= "CapabilityStatement.implementation.url",                                                                     // MakerGen.cs:237
                        Id = "CapabilityStatement.implementation.url",                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Url                                                               // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 25. CapabilityStatement.implementation.custodian
                    this.Element_Custodian = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Custodian",                                                                                         // MakerGen.cs:236
                        Path= "CapabilityStatement.implementation.custodian",                                                               // MakerGen.cs:237
                        Id = "CapabilityStatement.implementation.custodian",                                                                // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:344
                            {                                                                                                               // MakerGen.cs:345
                                TargetProfile = new String[]                                                                                // MakerGen.cs:347
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:347
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 30. CapabilityStatement.rest
        public partial class Type_Rest : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 33. CapabilityStatement.rest.security
            public partial class Type_Security : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 34. CapabilityStatement.rest.security.cors
                public ElementDefinitionInfo Element_Cors;                                                                                  // MakerGen.cs:217
                // 35. CapabilityStatement.rest.security.service
                public ElementDefinitionInfo Element_Service;                                                                               // MakerGen.cs:217
                // 36. CapabilityStatement.rest.security.description
                public ElementDefinitionInfo Element_Description;                                                                           // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "CapabilityStatement.rest.security",                                                                         // MakerGen.cs:393
                        ElementId = "CapabilityStatement.rest.security"                                                                     // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Cors.Write(sDef);                                                                                               // MakerGen.cs:221
                    Element_Service.Write(sDef);                                                                                            // MakerGen.cs:221
                    Element_Description.Write(sDef);                                                                                        // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_Security()                                                                                                      // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 34. CapabilityStatement.rest.security.cors
                        this.Element_Cors = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Cors",                                                                                          // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.security.cors",                                                                 // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.security.cors",                                                                  // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                       // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 35. CapabilityStatement.rest.security.service
                        this.Element_Service = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Service",                                                                                       // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.security.service",                                                              // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.security.service",                                                               // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:316
                                {                                                                                                           // MakerGen.cs:317
                                }                                                                                                           // MakerGen.cs:320
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 36. CapabilityStatement.rest.security.description
                        this.Element_Description = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Description",                                                                                   // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.security.description",                                                          // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.security.description",                                                           // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                      // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 37. CapabilityStatement.rest.resource
            public partial class Type_Resource : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 42. CapabilityStatement.rest.resource.interaction
                public partial class Type_Interaction : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 43. CapabilityStatement.rest.resource.interaction.code
                    public ElementDefinitionInfo Element_Code;                                                                              // MakerGen.cs:217
                    // 44. CapabilityStatement.rest.resource.interaction.documentation
                    public ElementDefinitionInfo Element_Documentation;                                                                     // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:388
                    {                                                                                                                       // MakerGen.cs:389
                        base.Write(sDef);                                                                                                   // MakerGen.cs:390
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:391
                        {                                                                                                                   // MakerGen.cs:392
                            Path = "CapabilityStatement.rest.resource.interaction",                                                         // MakerGen.cs:393
                            ElementId = "CapabilityStatement.rest.resource.interaction"                                                     // MakerGen.cs:394
                        });                                                                                                                 // MakerGen.cs:395
                        Element_Code.Write(sDef);                                                                                           // MakerGen.cs:221
                        Element_Documentation.Write(sDef);                                                                                  // MakerGen.cs:221
                    }                                                                                                                       // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                    public Type_Interaction()                                                                                               // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:232
                            // 43. CapabilityStatement.rest.resource.interaction.code
                            this.Element_Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Code",                                                                                      // MakerGen.cs:236
                                Path= "CapabilityStatement.rest.resource.interaction.code",                                                 // MakerGen.cs:237
                                Id = "CapabilityStatement.rest.resource.interaction.code",                                                  // MakerGen.cs:238
                                Min = 1,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                      // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 44. CapabilityStatement.rest.resource.interaction.documentation
                            this.Element_Documentation = new ElementDefinitionInfo                                                          // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Documentation",                                                                             // MakerGen.cs:236
                                Path= "CapabilityStatement.rest.resource.interaction.documentation",                                        // MakerGen.cs:237
                                Id = "CapabilityStatement.rest.resource.interaction.documentation",                                         // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                  // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                    }                                                                                                                       // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:405
                // 55. CapabilityStatement.rest.resource.searchParam
                public partial class Type_SearchParam : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 56. CapabilityStatement.rest.resource.searchParam.name
                    public ElementDefinitionInfo Element_Name;                                                                              // MakerGen.cs:217
                    // 57. CapabilityStatement.rest.resource.searchParam.definition
                    public ElementDefinitionInfo Element_Definition;                                                                        // MakerGen.cs:217
                    // 58. CapabilityStatement.rest.resource.searchParam.type
                    public ElementDefinitionInfo Element_Type;                                                                              // MakerGen.cs:217
                    // 59. CapabilityStatement.rest.resource.searchParam.documentation
                    public ElementDefinitionInfo Element_Documentation;                                                                     // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:388
                    {                                                                                                                       // MakerGen.cs:389
                        base.Write(sDef);                                                                                                   // MakerGen.cs:390
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:391
                        {                                                                                                                   // MakerGen.cs:392
                            Path = "CapabilityStatement.rest.resource.searchParam",                                                         // MakerGen.cs:393
                            ElementId = "CapabilityStatement.rest.resource.searchParam"                                                     // MakerGen.cs:394
                        });                                                                                                                 // MakerGen.cs:395
                        Element_Name.Write(sDef);                                                                                           // MakerGen.cs:221
                        Element_Definition.Write(sDef);                                                                                     // MakerGen.cs:221
                        Element_Type.Write(sDef);                                                                                           // MakerGen.cs:221
                        Element_Documentation.Write(sDef);                                                                                  // MakerGen.cs:221
                    }                                                                                                                       // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                    public Type_SearchParam()                                                                                               // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:232
                            // 56. CapabilityStatement.rest.resource.searchParam.name
                            this.Element_Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Name",                                                                                      // MakerGen.cs:236
                                Path= "CapabilityStatement.rest.resource.searchParam.name",                                                 // MakerGen.cs:237
                                Id = "CapabilityStatement.rest.resource.searchParam.name",                                                  // MakerGen.cs:238
                                Min = 1,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 57. CapabilityStatement.rest.resource.searchParam.definition
                            this.Element_Definition = new ElementDefinitionInfo                                                             // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Definition",                                                                                // MakerGen.cs:236
                                Path= "CapabilityStatement.rest.resource.searchParam.definition",                                           // MakerGen.cs:237
                                Id = "CapabilityStatement.rest.resource.searchParam.definition",                                            // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                 // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:304
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/SearchParameter"                                       // MakerGen.cs:304
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 58. CapabilityStatement.rest.resource.searchParam.type
                            this.Element_Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Type",                                                                                      // MakerGen.cs:236
                                Path= "CapabilityStatement.rest.resource.searchParam.type",                                                 // MakerGen.cs:237
                                Id = "CapabilityStatement.rest.resource.searchParam.type",                                                  // MakerGen.cs:238
                                Min = 1,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                      // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 59. CapabilityStatement.rest.resource.searchParam.documentation
                            this.Element_Documentation = new ElementDefinitionInfo                                                          // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Documentation",                                                                             // MakerGen.cs:236
                                Path= "CapabilityStatement.rest.resource.searchParam.documentation",                                        // MakerGen.cs:237
                                Id = "CapabilityStatement.rest.resource.searchParam.documentation",                                         // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                  // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                    }                                                                                                                       // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:405
                // 60. CapabilityStatement.rest.resource.operation
                public partial class Type_Operation : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 61. CapabilityStatement.rest.resource.operation.name
                    public ElementDefinitionInfo Element_Name;                                                                              // MakerGen.cs:217
                    // 62. CapabilityStatement.rest.resource.operation.definition
                    public ElementDefinitionInfo Element_Definition;                                                                        // MakerGen.cs:217
                    // 63. CapabilityStatement.rest.resource.operation.documentation
                    public ElementDefinitionInfo Element_Documentation;                                                                     // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:388
                    {                                                                                                                       // MakerGen.cs:389
                        base.Write(sDef);                                                                                                   // MakerGen.cs:390
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:391
                        {                                                                                                                   // MakerGen.cs:392
                            Path = "CapabilityStatement.rest.resource.operation",                                                           // MakerGen.cs:393
                            ElementId = "CapabilityStatement.rest.resource.operation"                                                       // MakerGen.cs:394
                        });                                                                                                                 // MakerGen.cs:395
                        Element_Name.Write(sDef);                                                                                           // MakerGen.cs:221
                        Element_Definition.Write(sDef);                                                                                     // MakerGen.cs:221
                        Element_Documentation.Write(sDef);                                                                                  // MakerGen.cs:221
                    }                                                                                                                       // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                    public Type_Operation()                                                                                                 // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:232
                            // 61. CapabilityStatement.rest.resource.operation.name
                            this.Element_Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Name",                                                                                      // MakerGen.cs:236
                                Path= "CapabilityStatement.rest.resource.operation.name",                                                   // MakerGen.cs:237
                                Id = "CapabilityStatement.rest.resource.operation.name",                                                    // MakerGen.cs:238
                                Min = 1,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 62. CapabilityStatement.rest.resource.operation.definition
                            this.Element_Definition = new ElementDefinitionInfo                                                             // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Definition",                                                                                // MakerGen.cs:236
                                Path= "CapabilityStatement.rest.resource.operation.definition",                                             // MakerGen.cs:237
                                Id = "CapabilityStatement.rest.resource.operation.definition",                                              // MakerGen.cs:238
                                Min = 1,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                 // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:304
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/OperationDefinition"                                   // MakerGen.cs:304
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 63. CapabilityStatement.rest.resource.operation.documentation
                            this.Element_Documentation = new ElementDefinitionInfo                                                          // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Documentation",                                                                             // MakerGen.cs:236
                                Path= "CapabilityStatement.rest.resource.operation.documentation",                                          // MakerGen.cs:237
                                Id = "CapabilityStatement.rest.resource.operation.documentation",                                           // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                  // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                    }                                                                                                                       // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:405
                // 38. CapabilityStatement.rest.resource.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:217
                // 39. CapabilityStatement.rest.resource.profile
                public ElementDefinitionInfo Element_Profile;                                                                               // MakerGen.cs:217
                // 40. CapabilityStatement.rest.resource.supportedProfile
                public ElementDefinitionInfo Element_SupportedProfile;                                                                      // MakerGen.cs:217
                // 41. CapabilityStatement.rest.resource.documentation
                public ElementDefinitionInfo Element_Documentation;                                                                         // MakerGen.cs:217
                // 42. CapabilityStatement.rest.resource.interaction
                public ElementDefinitionInfo Element_Interaction;                                                                           // MakerGen.cs:217
                // 45. CapabilityStatement.rest.resource.versioning
                public ElementDefinitionInfo Element_Versioning;                                                                            // MakerGen.cs:217
                // 46. CapabilityStatement.rest.resource.readHistory
                public ElementDefinitionInfo Element_ReadHistory;                                                                           // MakerGen.cs:217
                // 47. CapabilityStatement.rest.resource.updateCreate
                public ElementDefinitionInfo Element_UpdateCreate;                                                                          // MakerGen.cs:217
                // 48. CapabilityStatement.rest.resource.conditionalCreate
                public ElementDefinitionInfo Element_ConditionalCreate;                                                                     // MakerGen.cs:217
                // 49. CapabilityStatement.rest.resource.conditionalRead
                public ElementDefinitionInfo Element_ConditionalRead;                                                                       // MakerGen.cs:217
                // 50. CapabilityStatement.rest.resource.conditionalUpdate
                public ElementDefinitionInfo Element_ConditionalUpdate;                                                                     // MakerGen.cs:217
                // 51. CapabilityStatement.rest.resource.conditionalDelete
                public ElementDefinitionInfo Element_ConditionalDelete;                                                                     // MakerGen.cs:217
                // 52. CapabilityStatement.rest.resource.referencePolicy
                public ElementDefinitionInfo Element_ReferencePolicy;                                                                       // MakerGen.cs:217
                // 53. CapabilityStatement.rest.resource.searchInclude
                public ElementDefinitionInfo Element_SearchInclude;                                                                         // MakerGen.cs:217
                // 54. CapabilityStatement.rest.resource.searchRevInclude
                public ElementDefinitionInfo Element_SearchRevInclude;                                                                      // MakerGen.cs:217
                // 55. CapabilityStatement.rest.resource.searchParam
                public ElementDefinitionInfo Element_SearchParam;                                                                           // MakerGen.cs:217
                // 60. CapabilityStatement.rest.resource.operation
                public ElementDefinitionInfo Element_Operation;                                                                             // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "CapabilityStatement.rest.resource",                                                                         // MakerGen.cs:393
                        ElementId = "CapabilityStatement.rest.resource"                                                                     // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:221
                    Element_Profile.Write(sDef);                                                                                            // MakerGen.cs:221
                    Element_SupportedProfile.Write(sDef);                                                                                   // MakerGen.cs:221
                    Element_Documentation.Write(sDef);                                                                                      // MakerGen.cs:221
                    Element_Interaction.Write(sDef);                                                                                        // MakerGen.cs:221
                    Element_Versioning.Write(sDef);                                                                                         // MakerGen.cs:221
                    Element_ReadHistory.Write(sDef);                                                                                        // MakerGen.cs:221
                    Element_UpdateCreate.Write(sDef);                                                                                       // MakerGen.cs:221
                    Element_ConditionalCreate.Write(sDef);                                                                                  // MakerGen.cs:221
                    Element_ConditionalRead.Write(sDef);                                                                                    // MakerGen.cs:221
                    Element_ConditionalUpdate.Write(sDef);                                                                                  // MakerGen.cs:221
                    Element_ConditionalDelete.Write(sDef);                                                                                  // MakerGen.cs:221
                    Element_ReferencePolicy.Write(sDef);                                                                                    // MakerGen.cs:221
                    Element_SearchInclude.Write(sDef);                                                                                      // MakerGen.cs:221
                    Element_SearchRevInclude.Write(sDef);                                                                                   // MakerGen.cs:221
                    Element_SearchParam.Write(sDef);                                                                                        // MakerGen.cs:221
                    Element_Operation.Write(sDef);                                                                                          // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_Resource()                                                                                                      // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 38. CapabilityStatement.rest.resource.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Type",                                                                                          // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.type",                                                                 // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.type",                                                                  // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 39. CapabilityStatement.rest.resource.profile
                        this.Element_Profile = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Profile",                                                                                       // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.profile",                                                              // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.profile",                                                               // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                     // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                    TargetProfile = new String[]                                                                            // MakerGen.cs:304
                                    {                                                                                                       // CodeEditorExtensions.cs:28
                                        "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                       // MakerGen.cs:304
                                    }                                                                                                       // CodeEditorExtensions.cs:34
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 40. CapabilityStatement.rest.resource.supportedProfile
                        this.Element_SupportedProfile = new ElementDefinitionInfo                                                           // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_SupportedProfile",                                                                              // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.supportedProfile",                                                     // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.supportedProfile",                                                      // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                     // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                    TargetProfile = new String[]                                                                            // MakerGen.cs:304
                                    {                                                                                                       // CodeEditorExtensions.cs:28
                                        "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                       // MakerGen.cs:304
                                    }                                                                                                       // CodeEditorExtensions.cs:34
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 41. CapabilityStatement.rest.resource.documentation
                        this.Element_Documentation = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Documentation",                                                                                 // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.documentation",                                                        // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.documentation",                                                         // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                      // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 42. CapabilityStatement.rest.resource.interaction
                        this.Element_Interaction = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Interaction",                                                                                   // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.interaction",                                                          // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.interaction",                                                           // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new Type_Interaction                                                                                        // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:262
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 45. CapabilityStatement.rest.resource.versioning
                        this.Element_Versioning = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Versioning",                                                                                    // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.versioning",                                                           // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.versioning",                                                            // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 46. CapabilityStatement.rest.resource.readHistory
                        this.Element_ReadHistory = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_ReadHistory",                                                                                   // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.readHistory",                                                          // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.readHistory",                                                           // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                       // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 47. CapabilityStatement.rest.resource.updateCreate
                        this.Element_UpdateCreate = new ElementDefinitionInfo                                                               // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_UpdateCreate",                                                                                  // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.updateCreate",                                                         // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.updateCreate",                                                          // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                       // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 48. CapabilityStatement.rest.resource.conditionalCreate
                        this.Element_ConditionalCreate = new ElementDefinitionInfo                                                          // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_ConditionalCreate",                                                                             // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.conditionalCreate",                                                    // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.conditionalCreate",                                                     // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                       // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 49. CapabilityStatement.rest.resource.conditionalRead
                        this.Element_ConditionalRead = new ElementDefinitionInfo                                                            // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_ConditionalRead",                                                                               // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.conditionalRead",                                                      // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.conditionalRead",                                                       // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 50. CapabilityStatement.rest.resource.conditionalUpdate
                        this.Element_ConditionalUpdate = new ElementDefinitionInfo                                                          // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_ConditionalUpdate",                                                                             // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.conditionalUpdate",                                                    // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.conditionalUpdate",                                                     // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                       // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 51. CapabilityStatement.rest.resource.conditionalDelete
                        this.Element_ConditionalDelete = new ElementDefinitionInfo                                                          // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_ConditionalDelete",                                                                             // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.conditionalDelete",                                                    // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.conditionalDelete",                                                     // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 52. CapabilityStatement.rest.resource.referencePolicy
                        this.Element_ReferencePolicy = new ElementDefinitionInfo                                                            // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_ReferencePolicy",                                                                               // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.referencePolicy",                                                      // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.referencePolicy",                                                       // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 53. CapabilityStatement.rest.resource.searchInclude
                        this.Element_SearchInclude = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_SearchInclude",                                                                                 // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.searchInclude",                                                        // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.searchInclude",                                                         // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 54. CapabilityStatement.rest.resource.searchRevInclude
                        this.Element_SearchRevInclude = new ElementDefinitionInfo                                                           // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_SearchRevInclude",                                                                              // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.searchRevInclude",                                                     // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.searchRevInclude",                                                      // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 55. CapabilityStatement.rest.resource.searchParam
                        this.Element_SearchParam = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_SearchParam",                                                                                   // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.searchParam",                                                          // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.searchParam",                                                           // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new Type_SearchParam                                                                                        // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:262
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 60. CapabilityStatement.rest.resource.operation
                        this.Element_Operation = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Operation",                                                                                     // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.resource.operation",                                                            // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.resource.operation",                                                             // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new Type_Operation                                                                                          // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:262
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 64. CapabilityStatement.rest.interaction
            public partial class Type_Interaction : FhirKhit.Maker.Common.Complex.ComplexBase                                               // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 65. CapabilityStatement.rest.interaction.code
                public ElementDefinitionInfo Element_Code;                                                                                  // MakerGen.cs:217
                // 66. CapabilityStatement.rest.interaction.documentation
                public ElementDefinitionInfo Element_Documentation;                                                                         // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "CapabilityStatement.rest.interaction",                                                                      // MakerGen.cs:393
                        ElementId = "CapabilityStatement.rest.interaction"                                                                  // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Code.Write(sDef);                                                                                               // MakerGen.cs:221
                    Element_Documentation.Write(sDef);                                                                                      // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_Interaction()                                                                                                   // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 65. CapabilityStatement.rest.interaction.code
                        this.Element_Code = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Code",                                                                                          // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.interaction.code",                                                              // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.interaction.code",                                                               // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 66. CapabilityStatement.rest.interaction.documentation
                        this.Element_Documentation = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Documentation",                                                                                 // MakerGen.cs:236
                            Path= "CapabilityStatement.rest.interaction.documentation",                                                     // MakerGen.cs:237
                            Id = "CapabilityStatement.rest.interaction.documentation",                                                      // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                      // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 31. CapabilityStatement.rest.mode
            public ElementDefinitionInfo Element_Mode;                                                                                      // MakerGen.cs:217
            // 32. CapabilityStatement.rest.documentation
            public ElementDefinitionInfo Element_Documentation;                                                                             // MakerGen.cs:217
            // 33. CapabilityStatement.rest.security
            public ElementDefinitionInfo Element_Security;                                                                                  // MakerGen.cs:217
            // 37. CapabilityStatement.rest.resource
            public ElementDefinitionInfo Element_Resource;                                                                                  // MakerGen.cs:217
            // 64. CapabilityStatement.rest.interaction
            public ElementDefinitionInfo Element_Interaction;                                                                               // MakerGen.cs:217
            // 67. CapabilityStatement.rest.searchParam
            public ElementDefinitionInfo Element_SearchParam;                                                                               // MakerGen.cs:217
            // 68. CapabilityStatement.rest.operation
            public ElementDefinitionInfo Element_Operation;                                                                                 // MakerGen.cs:217
            // 69. CapabilityStatement.rest.compartment
            public ElementDefinitionInfo Element_Compartment;                                                                               // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "CapabilityStatement.rest",                                                                                      // MakerGen.cs:393
                    ElementId = "CapabilityStatement.rest"                                                                                  // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Mode.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Documentation.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_Security.Write(sDef);                                                                                               // MakerGen.cs:221
                Element_Resource.Write(sDef);                                                                                               // MakerGen.cs:221
                Element_Interaction.Write(sDef);                                                                                            // MakerGen.cs:221
                Element_SearchParam.Write(sDef);                                                                                            // MakerGen.cs:221
                Element_Operation.Write(sDef);                                                                                              // MakerGen.cs:221
                Element_Compartment.Write(sDef);                                                                                            // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Rest()                                                                                                              // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 31. CapabilityStatement.rest.mode
                    this.Element_Mode = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Mode",                                                                                              // MakerGen.cs:236
                        Path= "CapabilityStatement.rest.mode",                                                                              // MakerGen.cs:237
                        Id = "CapabilityStatement.rest.mode",                                                                               // MakerGen.cs:238
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
                    // 32. CapabilityStatement.rest.documentation
                    this.Element_Documentation = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Documentation",                                                                                     // MakerGen.cs:236
                        Path= "CapabilityStatement.rest.documentation",                                                                     // MakerGen.cs:237
                        Id = "CapabilityStatement.rest.documentation",                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                          // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 33. CapabilityStatement.rest.security
                    this.Element_Security = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Security",                                                                                          // MakerGen.cs:236
                        Path= "CapabilityStatement.rest.security",                                                                          // MakerGen.cs:237
                        Id = "CapabilityStatement.rest.security",                                                                           // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_Security                                                                                               // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 37. CapabilityStatement.rest.resource
                    this.Element_Resource = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Resource",                                                                                          // MakerGen.cs:236
                        Path= "CapabilityStatement.rest.resource",                                                                          // MakerGen.cs:237
                        Id = "CapabilityStatement.rest.resource",                                                                           // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_Resource                                                                                               // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 64. CapabilityStatement.rest.interaction
                    this.Element_Interaction = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Interaction",                                                                                       // MakerGen.cs:236
                        Path= "CapabilityStatement.rest.interaction",                                                                       // MakerGen.cs:237
                        Id = "CapabilityStatement.rest.interaction",                                                                        // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_Interaction                                                                                            // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 67. CapabilityStatement.rest.searchParam
                    this.Element_SearchParam = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_SearchParam",                                                                                       // MakerGen.cs:236
                        Path= "CapabilityStatement.rest.searchParam",                                                                       // MakerGen.cs:237
                        Id = "CapabilityStatement.rest.searchParam",                                                                        // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 68. CapabilityStatement.rest.operation
                    this.Element_Operation = new ElementDefinitionInfo                                                                      // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Operation",                                                                                         // MakerGen.cs:236
                        Path= "CapabilityStatement.rest.operation",                                                                         // MakerGen.cs:237
                        Id = "CapabilityStatement.rest.operation",                                                                          // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 69. CapabilityStatement.rest.compartment
                    this.Element_Compartment = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Compartment",                                                                                       // MakerGen.cs:236
                        Path= "CapabilityStatement.rest.compartment",                                                                       // MakerGen.cs:237
                        Id = "CapabilityStatement.rest.compartment",                                                                        // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                         // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                                TargetProfile = new String[]                                                                                // MakerGen.cs:304
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CompartmentDefinition"                                         // MakerGen.cs:304
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 70. CapabilityStatement.messaging
        public partial class Type_Messaging : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 71. CapabilityStatement.messaging.endpoint
            public partial class Type_Endpoint : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 72. CapabilityStatement.messaging.endpoint.protocol
                public ElementDefinitionInfo Element_Protocol;                                                                              // MakerGen.cs:217
                // 73. CapabilityStatement.messaging.endpoint.address
                public ElementDefinitionInfo Element_Address;                                                                               // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "CapabilityStatement.messaging.endpoint",                                                                    // MakerGen.cs:393
                        ElementId = "CapabilityStatement.messaging.endpoint"                                                                // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Protocol.Write(sDef);                                                                                           // MakerGen.cs:221
                    Element_Address.Write(sDef);                                                                                            // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_Endpoint()                                                                                                      // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 72. CapabilityStatement.messaging.endpoint.protocol
                        this.Element_Protocol = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Protocol",                                                                                      // MakerGen.cs:236
                            Path= "CapabilityStatement.messaging.endpoint.protocol",                                                        // MakerGen.cs:237
                            Id = "CapabilityStatement.messaging.endpoint.protocol",                                                         // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Complex.Type_Coding                                                               // MakerGen.cs:316
                                {                                                                                                           // MakerGen.cs:317
                                }                                                                                                           // MakerGen.cs:320
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 73. CapabilityStatement.messaging.endpoint.address
                        this.Element_Address = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Address",                                                                                       // MakerGen.cs:236
                            Path= "CapabilityStatement.messaging.endpoint.address",                                                         // MakerGen.cs:237
                            Id = "CapabilityStatement.messaging.endpoint.address",                                                          // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Url                                                           // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 76. CapabilityStatement.messaging.supportedMessage
            public partial class Type_SupportedMessage : FhirKhit.Maker.Common.Complex.ComplexBase                                          // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 77. CapabilityStatement.messaging.supportedMessage.mode
                public ElementDefinitionInfo Element_Mode;                                                                                  // MakerGen.cs:217
                // 78. CapabilityStatement.messaging.supportedMessage.definition
                public ElementDefinitionInfo Element_Definition;                                                                            // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "CapabilityStatement.messaging.supportedMessage",                                                            // MakerGen.cs:393
                        ElementId = "CapabilityStatement.messaging.supportedMessage"                                                        // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Mode.Write(sDef);                                                                                               // MakerGen.cs:221
                    Element_Definition.Write(sDef);                                                                                         // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_SupportedMessage()                                                                                              // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 77. CapabilityStatement.messaging.supportedMessage.mode
                        this.Element_Mode = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Mode",                                                                                          // MakerGen.cs:236
                            Path= "CapabilityStatement.messaging.supportedMessage.mode",                                                    // MakerGen.cs:237
                            Id = "CapabilityStatement.messaging.supportedMessage.mode",                                                     // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 78. CapabilityStatement.messaging.supportedMessage.definition
                        this.Element_Definition = new ElementDefinitionInfo                                                                 // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Definition",                                                                                    // MakerGen.cs:236
                            Path= "CapabilityStatement.messaging.supportedMessage.definition",                                              // MakerGen.cs:237
                            Id = "CapabilityStatement.messaging.supportedMessage.definition",                                               // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                     // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                    TargetProfile = new String[]                                                                            // MakerGen.cs:304
                                    {                                                                                                       // CodeEditorExtensions.cs:28
                                        "http://hl7.org/fhir/StructureDefinition/MessageDefinition"                                         // MakerGen.cs:304
                                    }                                                                                                       // CodeEditorExtensions.cs:34
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 71. CapabilityStatement.messaging.endpoint
            public ElementDefinitionInfo Element_Endpoint;                                                                                  // MakerGen.cs:217
            // 74. CapabilityStatement.messaging.reliableCache
            public ElementDefinitionInfo Element_ReliableCache;                                                                             // MakerGen.cs:217
            // 75. CapabilityStatement.messaging.documentation
            public ElementDefinitionInfo Element_Documentation;                                                                             // MakerGen.cs:217
            // 76. CapabilityStatement.messaging.supportedMessage
            public ElementDefinitionInfo Element_SupportedMessage;                                                                          // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "CapabilityStatement.messaging",                                                                                 // MakerGen.cs:393
                    ElementId = "CapabilityStatement.messaging"                                                                             // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Endpoint.Write(sDef);                                                                                               // MakerGen.cs:221
                Element_ReliableCache.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_Documentation.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_SupportedMessage.Write(sDef);                                                                                       // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Messaging()                                                                                                         // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 71. CapabilityStatement.messaging.endpoint
                    this.Element_Endpoint = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Endpoint",                                                                                          // MakerGen.cs:236
                        Path= "CapabilityStatement.messaging.endpoint",                                                                     // MakerGen.cs:237
                        Id = "CapabilityStatement.messaging.endpoint",                                                                      // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_Endpoint                                                                                               // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 74. CapabilityStatement.messaging.reliableCache
                    this.Element_ReliableCache = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_ReliableCache",                                                                                     // MakerGen.cs:236
                        Path= "CapabilityStatement.messaging.reliableCache",                                                                // MakerGen.cs:237
                        Id = "CapabilityStatement.messaging.reliableCache",                                                                 // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt                                                       // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 75. CapabilityStatement.messaging.documentation
                    this.Element_Documentation = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Documentation",                                                                                     // MakerGen.cs:236
                        Path= "CapabilityStatement.messaging.documentation",                                                                // MakerGen.cs:237
                        Id = "CapabilityStatement.messaging.documentation",                                                                 // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                          // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 76. CapabilityStatement.messaging.supportedMessage
                    this.Element_SupportedMessage = new ElementDefinitionInfo                                                               // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_SupportedMessage",                                                                                  // MakerGen.cs:236
                        Path= "CapabilityStatement.messaging.supportedMessage",                                                             // MakerGen.cs:237
                        Id = "CapabilityStatement.messaging.supportedMessage",                                                              // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_SupportedMessage                                                                                       // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 79. CapabilityStatement.document
        public partial class Type_Document : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 80. CapabilityStatement.document.mode
            public ElementDefinitionInfo Element_Mode;                                                                                      // MakerGen.cs:217
            // 81. CapabilityStatement.document.documentation
            public ElementDefinitionInfo Element_Documentation;                                                                             // MakerGen.cs:217
            // 82. CapabilityStatement.document.profile
            public ElementDefinitionInfo Element_Profile;                                                                                   // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "CapabilityStatement.document",                                                                                  // MakerGen.cs:393
                    ElementId = "CapabilityStatement.document"                                                                              // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Mode.Write(sDef);                                                                                                   // MakerGen.cs:221
                Element_Documentation.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_Profile.Write(sDef);                                                                                                // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Document()                                                                                                          // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 80. CapabilityStatement.document.mode
                    this.Element_Mode = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Mode",                                                                                              // MakerGen.cs:236
                        Path= "CapabilityStatement.document.mode",                                                                          // MakerGen.cs:237
                        Id = "CapabilityStatement.document.mode",                                                                           // MakerGen.cs:238
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
                    // 81. CapabilityStatement.document.documentation
                    this.Element_Documentation = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Documentation",                                                                                     // MakerGen.cs:236
                        Path= "CapabilityStatement.document.documentation",                                                                 // MakerGen.cs:237
                        Id = "CapabilityStatement.document.documentation",                                                                  // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                          // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 82. CapabilityStatement.document.profile
                    this.Element_Profile = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Profile",                                                                                           // MakerGen.cs:236
                        Path= "CapabilityStatement.document.profile",                                                                       // MakerGen.cs:237
                        Id = "CapabilityStatement.document.profile",                                                                        // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                         // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                                TargetProfile = new String[]                                                                                // MakerGen.cs:304
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                           // MakerGen.cs:304
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. CapabilityStatement.url
        public ElementDefinitionInfo Element_Url;                                                                                           // MakerGen.cs:217
        // 2. CapabilityStatement.version
        public ElementDefinitionInfo Element_Version;                                                                                       // MakerGen.cs:217
        // 3. CapabilityStatement.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:217
        // 4. CapabilityStatement.title
        public ElementDefinitionInfo Element_Title;                                                                                         // MakerGen.cs:217
        // 5. CapabilityStatement.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:217
        // 6. CapabilityStatement.experimental
        public ElementDefinitionInfo Element_Experimental;                                                                                  // MakerGen.cs:217
        // 7. CapabilityStatement.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:217
        // 8. CapabilityStatement.publisher
        public ElementDefinitionInfo Element_Publisher;                                                                                     // MakerGen.cs:217
        // 9. CapabilityStatement.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:217
        // 10. CapabilityStatement.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:217
        // 11. CapabilityStatement.useContext
        public ElementDefinitionInfo Element_UseContext;                                                                                    // MakerGen.cs:217
        // 12. CapabilityStatement.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;                                                                                  // MakerGen.cs:217
        // 13. CapabilityStatement.purpose
        public ElementDefinitionInfo Element_Purpose;                                                                                       // MakerGen.cs:217
        // 14. CapabilityStatement.copyright
        public ElementDefinitionInfo Element_Copyright;                                                                                     // MakerGen.cs:217
        // 15. CapabilityStatement.kind
        public ElementDefinitionInfo Element_Kind;                                                                                          // MakerGen.cs:217
        // 16. CapabilityStatement.instantiates
        public ElementDefinitionInfo Element_Instantiates;                                                                                  // MakerGen.cs:217
        // 17. CapabilityStatement.imports
        public ElementDefinitionInfo Element_Imports;                                                                                       // MakerGen.cs:217
        // 18. CapabilityStatement.software
        public ElementDefinitionInfo Element_Software;                                                                                      // MakerGen.cs:217
        // 22. CapabilityStatement.implementation
        public ElementDefinitionInfo Element_Implementation;                                                                                // MakerGen.cs:217
        // 26. CapabilityStatement.fhirVersion
        public ElementDefinitionInfo Element_FhirVersion;                                                                                   // MakerGen.cs:217
        // 27. CapabilityStatement.format
        public ElementDefinitionInfo Element_Format;                                                                                        // MakerGen.cs:217
        // 28. CapabilityStatement.patchFormat
        public ElementDefinitionInfo Element_PatchFormat;                                                                                   // MakerGen.cs:217
        // 29. CapabilityStatement.implementationGuide
        public ElementDefinitionInfo Element_ImplementationGuide;                                                                           // MakerGen.cs:217
        // 30. CapabilityStatement.rest
        public ElementDefinitionInfo Element_Rest;                                                                                          // MakerGen.cs:217
        // 70. CapabilityStatement.messaging
        public ElementDefinitionInfo Element_Messaging;                                                                                     // MakerGen.cs:217
        // 79. CapabilityStatement.document
        public ElementDefinitionInfo Element_Document;                                                                                      // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "CapabilityStatement",                                                                                               // MakerGen.cs:393
                ElementId = "CapabilityStatement"                                                                                           // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Url.Write(sDef);                                                                                                        // MakerGen.cs:221
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
            Element_Kind.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Instantiates.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_Imports.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Software.Write(sDef);                                                                                                   // MakerGen.cs:221
            Element_Implementation.Write(sDef);                                                                                             // MakerGen.cs:221
            Element_FhirVersion.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_Format.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_PatchFormat.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_ImplementationGuide.Write(sDef);                                                                                        // MakerGen.cs:221
            Element_Rest.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Messaging.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Document.Write(sDef);                                                                                                   // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_CapabilityStatement()                                                                                               // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. CapabilityStatement.url
                this.Element_Url = new ElementDefinitionInfo                                                                                // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:236
                    Path= "CapabilityStatement.url",                                                                                        // MakerGen.cs:237
                    Id = "CapabilityStatement.url",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
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
                // 2. CapabilityStatement.version
                this.Element_Version = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Version",                                                                                               // MakerGen.cs:236
                    Path= "CapabilityStatement.version",                                                                                    // MakerGen.cs:237
                    Id = "CapabilityStatement.version",                                                                                     // MakerGen.cs:238
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
                // 3. CapabilityStatement.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:236
                    Path= "CapabilityStatement.name",                                                                                       // MakerGen.cs:237
                    Id = "CapabilityStatement.name",                                                                                        // MakerGen.cs:238
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
                // 4. CapabilityStatement.title
                this.Element_Title = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Title",                                                                                                 // MakerGen.cs:236
                    Path= "CapabilityStatement.title",                                                                                      // MakerGen.cs:237
                    Id = "CapabilityStatement.title",                                                                                       // MakerGen.cs:238
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
                // 5. CapabilityStatement.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Status",                                                                                                // MakerGen.cs:236
                    Path= "CapabilityStatement.status",                                                                                     // MakerGen.cs:237
                    Id = "CapabilityStatement.status",                                                                                      // MakerGen.cs:238
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
                // 6. CapabilityStatement.experimental
                this.Element_Experimental = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Experimental",                                                                                          // MakerGen.cs:236
                    Path= "CapabilityStatement.experimental",                                                                               // MakerGen.cs:237
                    Id = "CapabilityStatement.experimental",                                                                                // MakerGen.cs:238
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
                // 7. CapabilityStatement.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:236
                    Path= "CapabilityStatement.date",                                                                                       // MakerGen.cs:237
                    Id = "CapabilityStatement.date",                                                                                        // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
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
                // 8. CapabilityStatement.publisher
                this.Element_Publisher = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:236
                    Path= "CapabilityStatement.publisher",                                                                                  // MakerGen.cs:237
                    Id = "CapabilityStatement.publisher",                                                                                   // MakerGen.cs:238
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
                // 9. CapabilityStatement.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:236
                    Path= "CapabilityStatement.contact",                                                                                    // MakerGen.cs:237
                    Id = "CapabilityStatement.contact",                                                                                     // MakerGen.cs:238
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
                // 10. CapabilityStatement.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Description",                                                                                           // MakerGen.cs:236
                    Path= "CapabilityStatement.description",                                                                                // MakerGen.cs:237
                    Id = "CapabilityStatement.description",                                                                                 // MakerGen.cs:238
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
                // 11. CapabilityStatement.useContext
                this.Element_UseContext = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:236
                    Path= "CapabilityStatement.useContext",                                                                                 // MakerGen.cs:237
                    Id = "CapabilityStatement.useContext",                                                                                  // MakerGen.cs:238
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
                // 12. CapabilityStatement.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:236
                    Path= "CapabilityStatement.jurisdiction",                                                                               // MakerGen.cs:237
                    Id = "CapabilityStatement.jurisdiction",                                                                                // MakerGen.cs:238
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
                // 13. CapabilityStatement.purpose
                this.Element_Purpose = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Purpose",                                                                                               // MakerGen.cs:236
                    Path= "CapabilityStatement.purpose",                                                                                    // MakerGen.cs:237
                    Id = "CapabilityStatement.purpose",                                                                                     // MakerGen.cs:238
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
                // 14. CapabilityStatement.copyright
                this.Element_Copyright = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Copyright",                                                                                             // MakerGen.cs:236
                    Path= "CapabilityStatement.copyright",                                                                                  // MakerGen.cs:237
                    Id = "CapabilityStatement.copyright",                                                                                   // MakerGen.cs:238
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
                // 15. CapabilityStatement.kind
                this.Element_Kind = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Kind",                                                                                                  // MakerGen.cs:236
                    Path= "CapabilityStatement.kind",                                                                                       // MakerGen.cs:237
                    Id = "CapabilityStatement.kind",                                                                                        // MakerGen.cs:238
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
                // 16. CapabilityStatement.instantiates
                this.Element_Instantiates = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Instantiates",                                                                                          // MakerGen.cs:236
                    Path= "CapabilityStatement.instantiates",                                                                               // MakerGen.cs:237
                    Id = "CapabilityStatement.instantiates",                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:304
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/CapabilityStatement"                                               // MakerGen.cs:304
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 17. CapabilityStatement.imports
                this.Element_Imports = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Imports",                                                                                               // MakerGen.cs:236
                    Path= "CapabilityStatement.imports",                                                                                    // MakerGen.cs:237
                    Id = "CapabilityStatement.imports",                                                                                     // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:304
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/CapabilityStatement"                                               // MakerGen.cs:304
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 18. CapabilityStatement.software
                this.Element_Software = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Software",                                                                                              // MakerGen.cs:236
                    Path= "CapabilityStatement.software",                                                                                   // MakerGen.cs:237
                    Id = "CapabilityStatement.software",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Software                                                                                                   // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 22. CapabilityStatement.implementation
                this.Element_Implementation = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Implementation",                                                                                        // MakerGen.cs:236
                    Path= "CapabilityStatement.implementation",                                                                             // MakerGen.cs:237
                    Id = "CapabilityStatement.implementation",                                                                              // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Implementation                                                                                             // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 26. CapabilityStatement.fhirVersion
                this.Element_FhirVersion = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_FhirVersion",                                                                                           // MakerGen.cs:236
                    Path= "CapabilityStatement.fhirVersion",                                                                                // MakerGen.cs:237
                    Id = "CapabilityStatement.fhirVersion",                                                                                 // MakerGen.cs:238
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
                // 27. CapabilityStatement.format
                this.Element_Format = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Format",                                                                                                // MakerGen.cs:236
                    Path= "CapabilityStatement.format",                                                                                     // MakerGen.cs:237
                    Id = "CapabilityStatement.format",                                                                                      // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 28. CapabilityStatement.patchFormat
                this.Element_PatchFormat = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_PatchFormat",                                                                                           // MakerGen.cs:236
                    Path= "CapabilityStatement.patchFormat",                                                                                // MakerGen.cs:237
                    Id = "CapabilityStatement.patchFormat",                                                                                 // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 29. CapabilityStatement.implementationGuide
                this.Element_ImplementationGuide = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_ImplementationGuide",                                                                                   // MakerGen.cs:236
                    Path= "CapabilityStatement.implementationGuide",                                                                        // MakerGen.cs:237
                    Id = "CapabilityStatement.implementationGuide",                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:304
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ImplementationGuide"                                               // MakerGen.cs:304
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 30. CapabilityStatement.rest
                this.Element_Rest = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Rest",                                                                                                  // MakerGen.cs:236
                    Path= "CapabilityStatement.rest",                                                                                       // MakerGen.cs:237
                    Id = "CapabilityStatement.rest",                                                                                        // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Rest                                                                                                       // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 70. CapabilityStatement.messaging
                this.Element_Messaging = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Messaging",                                                                                             // MakerGen.cs:236
                    Path= "CapabilityStatement.messaging",                                                                                  // MakerGen.cs:237
                    Id = "CapabilityStatement.messaging",                                                                                   // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Messaging                                                                                                  // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 79. CapabilityStatement.document
                this.Element_Document = new ElementDefinitionInfo                                                                           // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Document",                                                                                              // MakerGen.cs:236
                    Path= "CapabilityStatement.document",                                                                                   // MakerGen.cs:237
                    Id = "CapabilityStatement.document",                                                                                    // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Document                                                                                                   // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "CapabilityStatement";                                                                                              // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/CapabilityStatement";                                                       // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
