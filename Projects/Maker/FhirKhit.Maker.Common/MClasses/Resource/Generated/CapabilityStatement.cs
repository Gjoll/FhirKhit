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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'CapabilityStatement'
    /// </summary>
    // 0. CapabilityStatement
    public class CapabilityStatement : FhirKhit.Maker.Common.Resource.ResourceBase                                                          // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 18. CapabilityStatement.software
        public class Type_Software : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 19. CapabilityStatement.software.name
            public MakerElementInstance Element_Name;                                                                                       // MakerGen.cs:232
            // 20. CapabilityStatement.software.version
            public MakerElementInstance Element_Version;                                                                                    // MakerGen.cs:232
            // 21. CapabilityStatement.software.releaseDate
            public MakerElementInstance Element_ReleaseDate;                                                                                // MakerGen.cs:232
            public Type_Software()                                                                                                          // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 19. CapabilityStatement.software.name
                    this.Element_Name = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Name",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 20. CapabilityStatement.software.version
                    this.Element_Version = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Version",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 21. CapabilityStatement.software.releaseDate
                    this.Element_ReleaseDate = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ReleaseDate",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.DateTime()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 22. CapabilityStatement.implementation
        public class Type_Implementation : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 23. CapabilityStatement.implementation.description
            public MakerElementInstance Element_Description;                                                                                // MakerGen.cs:232
            // 24. CapabilityStatement.implementation.url
            public MakerElementInstance Element_Url;                                                                                        // MakerGen.cs:232
            // 25. CapabilityStatement.implementation.custodian
            public MakerElementInstance Element_Custodian;                                                                                  // MakerGen.cs:232
            public Type_Implementation()                                                                                                    // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 23. CapabilityStatement.implementation.description
                    this.Element_Description = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Description",                                                                                       // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String()                                                                    // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 24. CapabilityStatement.implementation.url
                    this.Element_Url = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Url",                                                                                               // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Url()                                                                       // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 25. CapabilityStatement.implementation.custodian
                    this.Element_Custodian = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Custodian",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 30. CapabilityStatement.rest
        public class Type_Rest : FhirKhit.Maker.Common.Complex.ComplexBase                                                                  // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 33. CapabilityStatement.rest.security
            public class Type_Security : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 34. CapabilityStatement.rest.security.cors
                public MakerElementInstance Element_Cors;                                                                                   // MakerGen.cs:232
                // 35. CapabilityStatement.rest.security.service
                public MakerElementInstance Element_Service;                                                                                // MakerGen.cs:232
                // 36. CapabilityStatement.rest.security.description
                public MakerElementInstance Element_Description;                                                                            // MakerGen.cs:232
                public Type_Security()                                                                                                      // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 34. CapabilityStatement.rest.security.cors
                        this.Element_Cors = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Cors",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Boolean()                                                               // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 35. CapabilityStatement.rest.security.service
                        this.Element_Service = new MakerElementInstance                                                                     // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Service",                                                                                       // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                         // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 36. CapabilityStatement.rest.security.description
                        this.Element_Description = new MakerElementInstance                                                                 // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Description",                                                                                   // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Markdown()                                                              // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 37. CapabilityStatement.rest.resource
            public class Type_Resource : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 42. CapabilityStatement.rest.resource.interaction
                public class Type_Interaction : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 43. CapabilityStatement.rest.resource.interaction.code
                    public MakerElementInstance Element_Code;                                                                               // MakerGen.cs:232
                    // 44. CapabilityStatement.rest.resource.interaction.documentation
                    public MakerElementInstance Element_Documentation;                                                                      // MakerGen.cs:232
                    public Type_Interaction()                                                                                               // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 43. CapabilityStatement.rest.resource.interaction.code
                            this.Element_Code = new MakerElementInstance                                                                    // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Code",                                                                                      // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Code()                                                              // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 44. CapabilityStatement.rest.resource.interaction.documentation
                            this.Element_Documentation = new MakerElementInstance                                                           // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Documentation",                                                                             // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Markdown()                                                          // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                // 55. CapabilityStatement.rest.resource.searchParam
                public class Type_SearchParam : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 56. CapabilityStatement.rest.resource.searchParam.name
                    public MakerElementInstance Element_Name;                                                                               // MakerGen.cs:232
                    // 57. CapabilityStatement.rest.resource.searchParam.definition
                    public MakerElementInstance Element_Definition;                                                                         // MakerGen.cs:232
                    // 58. CapabilityStatement.rest.resource.searchParam.type
                    public MakerElementInstance Element_Type;                                                                               // MakerGen.cs:232
                    // 59. CapabilityStatement.rest.resource.searchParam.documentation
                    public MakerElementInstance Element_Documentation;                                                                      // MakerGen.cs:232
                    public Type_SearchParam()                                                                                               // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 56. CapabilityStatement.rest.resource.searchParam.name
                            this.Element_Name = new MakerElementInstance                                                                    // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Name",                                                                                      // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String()                                                            // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 57. CapabilityStatement.rest.resource.searchParam.definition
                            this.Element_Definition = new MakerElementInstance                                                              // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Definition",                                                                                // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Canonical()                                                         // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 58. CapabilityStatement.rest.resource.searchParam.type
                            this.Element_Type = new MakerElementInstance                                                                    // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Type",                                                                                      // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Code()                                                              // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 59. CapabilityStatement.rest.resource.searchParam.documentation
                            this.Element_Documentation = new MakerElementInstance                                                           // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Documentation",                                                                             // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Markdown()                                                          // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                // 60. CapabilityStatement.rest.resource.operation
                public class Type_Operation : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:352
                {                                                                                                                           // MakerGen.cs:353
                    // 61. CapabilityStatement.rest.resource.operation.name
                    public MakerElementInstance Element_Name;                                                                               // MakerGen.cs:232
                    // 62. CapabilityStatement.rest.resource.operation.definition
                    public MakerElementInstance Element_Definition;                                                                         // MakerGen.cs:232
                    // 63. CapabilityStatement.rest.resource.operation.documentation
                    public MakerElementInstance Element_Documentation;                                                                      // MakerGen.cs:232
                    public Type_Operation()                                                                                                 // MakerGen.cs:361
                    {                                                                                                                       // MakerGen.cs:362
                        {                                                                                                                   // MakerGen.cs:243
                            // 61. CapabilityStatement.rest.resource.operation.name
                            this.Element_Name = new MakerElementInstance                                                                    // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Name",                                                                                      // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String()                                                            // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 62. CapabilityStatement.rest.resource.operation.definition
                            this.Element_Definition = new MakerElementInstance                                                              // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Definition",                                                                                // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Canonical()                                                         // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                        {                                                                                                                   // MakerGen.cs:243
                            // 63. CapabilityStatement.rest.resource.operation.documentation
                            this.Element_Documentation = new MakerElementInstance                                                           // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Documentation",                                                                             // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBase_Type[]                                                                                // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Markdown()                                                          // MakerGen.cs:286
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:334
                    }                                                                                                                       // MakerGen.cs:373
                }                                                                                                                           // MakerGen.cs:357
                // 38. CapabilityStatement.rest.resource.type
                public MakerElementInstance Element_Type;                                                                                   // MakerGen.cs:232
                // 39. CapabilityStatement.rest.resource.profile
                public MakerElementInstance Element_Profile;                                                                                // MakerGen.cs:232
                // 40. CapabilityStatement.rest.resource.supportedProfile
                public MakerElementInstance Element_SupportedProfile;                                                                       // MakerGen.cs:232
                // 41. CapabilityStatement.rest.resource.documentation
                public MakerElementInstance Element_Documentation;                                                                          // MakerGen.cs:232
                // 45. CapabilityStatement.rest.resource.versioning
                public MakerElementInstance Element_Versioning;                                                                             // MakerGen.cs:232
                // 46. CapabilityStatement.rest.resource.readHistory
                public MakerElementInstance Element_ReadHistory;                                                                            // MakerGen.cs:232
                // 47. CapabilityStatement.rest.resource.updateCreate
                public MakerElementInstance Element_UpdateCreate;                                                                           // MakerGen.cs:232
                // 48. CapabilityStatement.rest.resource.conditionalCreate
                public MakerElementInstance Element_ConditionalCreate;                                                                      // MakerGen.cs:232
                // 49. CapabilityStatement.rest.resource.conditionalRead
                public MakerElementInstance Element_ConditionalRead;                                                                        // MakerGen.cs:232
                // 50. CapabilityStatement.rest.resource.conditionalUpdate
                public MakerElementInstance Element_ConditionalUpdate;                                                                      // MakerGen.cs:232
                // 51. CapabilityStatement.rest.resource.conditionalDelete
                public MakerElementInstance Element_ConditionalDelete;                                                                      // MakerGen.cs:232
                // 52. CapabilityStatement.rest.resource.referencePolicy
                public MakerElementInstance Element_ReferencePolicy;                                                                        // MakerGen.cs:232
                // 53. CapabilityStatement.rest.resource.searchInclude
                public MakerElementInstance Element_SearchInclude;                                                                          // MakerGen.cs:232
                // 54. CapabilityStatement.rest.resource.searchRevInclude
                public MakerElementInstance Element_SearchRevInclude;                                                                       // MakerGen.cs:232
                public Type_Resource()                                                                                                      // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 38. CapabilityStatement.rest.resource.type
                        this.Element_Type = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Type",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Code()                                                                  // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 39. CapabilityStatement.rest.resource.profile
                        this.Element_Profile = new MakerElementInstance                                                                     // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Profile",                                                                                       // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Canonical()                                                             // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 40. CapabilityStatement.rest.resource.supportedProfile
                        this.Element_SupportedProfile = new MakerElementInstance                                                            // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_SupportedProfile",                                                                              // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Canonical()                                                             // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 41. CapabilityStatement.rest.resource.documentation
                        this.Element_Documentation = new MakerElementInstance                                                               // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Documentation",                                                                                 // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Markdown()                                                              // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 45. CapabilityStatement.rest.resource.versioning
                        this.Element_Versioning = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Versioning",                                                                                    // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Code()                                                                  // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 46. CapabilityStatement.rest.resource.readHistory
                        this.Element_ReadHistory = new MakerElementInstance                                                                 // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ReadHistory",                                                                                   // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Boolean()                                                               // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 47. CapabilityStatement.rest.resource.updateCreate
                        this.Element_UpdateCreate = new MakerElementInstance                                                                // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_UpdateCreate",                                                                                  // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Boolean()                                                               // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 48. CapabilityStatement.rest.resource.conditionalCreate
                        this.Element_ConditionalCreate = new MakerElementInstance                                                           // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ConditionalCreate",                                                                             // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Boolean()                                                               // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 49. CapabilityStatement.rest.resource.conditionalRead
                        this.Element_ConditionalRead = new MakerElementInstance                                                             // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ConditionalRead",                                                                               // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Code()                                                                  // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 50. CapabilityStatement.rest.resource.conditionalUpdate
                        this.Element_ConditionalUpdate = new MakerElementInstance                                                           // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ConditionalUpdate",                                                                             // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Boolean()                                                               // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 51. CapabilityStatement.rest.resource.conditionalDelete
                        this.Element_ConditionalDelete = new MakerElementInstance                                                           // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ConditionalDelete",                                                                             // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Code()                                                                  // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 52. CapabilityStatement.rest.resource.referencePolicy
                        this.Element_ReferencePolicy = new MakerElementInstance                                                             // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_ReferencePolicy",                                                                               // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Code()                                                                  // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 53. CapabilityStatement.rest.resource.searchInclude
                        this.Element_SearchInclude = new MakerElementInstance                                                               // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_SearchInclude",                                                                                 // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 54. CapabilityStatement.rest.resource.searchRevInclude
                        this.Element_SearchRevInclude = new MakerElementInstance                                                            // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_SearchRevInclude",                                                                              // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String()                                                                // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 64. CapabilityStatement.rest.interaction
            public class Type_Interaction : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 65. CapabilityStatement.rest.interaction.code
                public MakerElementInstance Element_Code;                                                                                   // MakerGen.cs:232
                // 66. CapabilityStatement.rest.interaction.documentation
                public MakerElementInstance Element_Documentation;                                                                          // MakerGen.cs:232
                public Type_Interaction()                                                                                                   // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 65. CapabilityStatement.rest.interaction.code
                        this.Element_Code = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Code",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Code()                                                                  // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 66. CapabilityStatement.rest.interaction.documentation
                        this.Element_Documentation = new MakerElementInstance                                                               // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Documentation",                                                                                 // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Markdown()                                                              // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 31. CapabilityStatement.rest.mode
            public MakerElementInstance Element_Mode;                                                                                       // MakerGen.cs:232
            // 32. CapabilityStatement.rest.documentation
            public MakerElementInstance Element_Documentation;                                                                              // MakerGen.cs:232
            // 67. CapabilityStatement.rest.searchParam
            public MakerElementInstance Element_SearchParam;                                                                                // MakerGen.cs:232
            // 68. CapabilityStatement.rest.operation
            public MakerElementInstance Element_Operation;                                                                                  // MakerGen.cs:232
            // 69. CapabilityStatement.rest.compartment
            public MakerElementInstance Element_Compartment;                                                                                // MakerGen.cs:232
            public Type_Rest()                                                                                                              // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 31. CapabilityStatement.rest.mode
                    this.Element_Mode = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Mode",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 32. CapabilityStatement.rest.documentation
                    this.Element_Documentation = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Documentation",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Markdown()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 67. CapabilityStatement.rest.searchParam
                    this.Element_SearchParam = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_SearchParam",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 68. CapabilityStatement.rest.operation
                    this.Element_Operation = new MakerElementInstance                                                                       // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Operation",                                                                                         // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 69. CapabilityStatement.rest.compartment
                    this.Element_Compartment = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Compartment",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Canonical()                                                                 // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 70. CapabilityStatement.messaging
        public class Type_Messaging : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 71. CapabilityStatement.messaging.endpoint
            public class Type_Endpoint : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 72. CapabilityStatement.messaging.endpoint.protocol
                public MakerElementInstance Element_Protocol;                                                                               // MakerGen.cs:232
                // 73. CapabilityStatement.messaging.endpoint.address
                public MakerElementInstance Element_Address;                                                                                // MakerGen.cs:232
                public Type_Endpoint()                                                                                                      // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 72. CapabilityStatement.messaging.endpoint.protocol
                        this.Element_Protocol = new MakerElementInstance                                                                    // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Protocol",                                                                                      // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Coding()                                                                  // MakerGen.cs:292
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 73. CapabilityStatement.messaging.endpoint.address
                        this.Element_Address = new MakerElementInstance                                                                     // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Address",                                                                                       // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Url()                                                                   // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 76. CapabilityStatement.messaging.supportedMessage
            public class Type_SupportedMessage : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:352
            {                                                                                                                               // MakerGen.cs:353
                // 77. CapabilityStatement.messaging.supportedMessage.mode
                public MakerElementInstance Element_Mode;                                                                                   // MakerGen.cs:232
                // 78. CapabilityStatement.messaging.supportedMessage.definition
                public MakerElementInstance Element_Definition;                                                                             // MakerGen.cs:232
                public Type_SupportedMessage()                                                                                              // MakerGen.cs:361
                {                                                                                                                           // MakerGen.cs:362
                    {                                                                                                                       // MakerGen.cs:243
                        // 77. CapabilityStatement.messaging.supportedMessage.mode
                        this.Element_Mode = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Mode",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Code()                                                                  // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                    {                                                                                                                       // MakerGen.cs:243
                        // 78. CapabilityStatement.messaging.supportedMessage.definition
                        this.Element_Definition = new MakerElementInstance                                                                  // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Definition",                                                                                    // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBase_Type[]                                                                                    // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Canonical()                                                             // MakerGen.cs:286
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:334
                }                                                                                                                           // MakerGen.cs:373
            }                                                                                                                               // MakerGen.cs:357
            // 74. CapabilityStatement.messaging.reliableCache
            public MakerElementInstance Element_ReliableCache;                                                                              // MakerGen.cs:232
            // 75. CapabilityStatement.messaging.documentation
            public MakerElementInstance Element_Documentation;                                                                              // MakerGen.cs:232
            public Type_Messaging()                                                                                                         // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 74. CapabilityStatement.messaging.reliableCache
                    this.Element_ReliableCache = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ReliableCache",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.UnsignedInt()                                                               // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 75. CapabilityStatement.messaging.documentation
                    this.Element_Documentation = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Documentation",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Markdown()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 79. CapabilityStatement.document
        public class Type_Document : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:352
        {                                                                                                                                   // MakerGen.cs:353
            // 80. CapabilityStatement.document.mode
            public MakerElementInstance Element_Mode;                                                                                       // MakerGen.cs:232
            // 81. CapabilityStatement.document.documentation
            public MakerElementInstance Element_Documentation;                                                                              // MakerGen.cs:232
            // 82. CapabilityStatement.document.profile
            public MakerElementInstance Element_Profile;                                                                                    // MakerGen.cs:232
            public Type_Document()                                                                                                          // MakerGen.cs:361
            {                                                                                                                               // MakerGen.cs:362
                {                                                                                                                           // MakerGen.cs:243
                    // 80. CapabilityStatement.document.mode
                    this.Element_Mode = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Mode",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code()                                                                      // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 81. CapabilityStatement.document.documentation
                    this.Element_Documentation = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Documentation",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Markdown()                                                                  // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
                {                                                                                                                           // MakerGen.cs:243
                    // 82. CapabilityStatement.document.profile
                    this.Element_Profile = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Profile",                                                                                           // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBase_Type[]                                                                                        // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Canonical()                                                                 // MakerGen.cs:286
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:334
            }                                                                                                                               // MakerGen.cs:373
        }                                                                                                                                   // MakerGen.cs:357
        // 1. CapabilityStatement.url
        public MakerElementInstance Element_Url;                                                                                            // MakerGen.cs:232
        // 2. CapabilityStatement.version
        public MakerElementInstance Element_Version;                                                                                        // MakerGen.cs:232
        // 3. CapabilityStatement.name
        public MakerElementInstance Element_Name;                                                                                           // MakerGen.cs:232
        // 4. CapabilityStatement.title
        public MakerElementInstance Element_Title;                                                                                          // MakerGen.cs:232
        // 5. CapabilityStatement.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 6. CapabilityStatement.experimental
        public MakerElementInstance Element_Experimental;                                                                                   // MakerGen.cs:232
        // 7. CapabilityStatement.date
        public MakerElementInstance Element_Date;                                                                                           // MakerGen.cs:232
        // 8. CapabilityStatement.publisher
        public MakerElementInstance Element_Publisher;                                                                                      // MakerGen.cs:232
        // 9. CapabilityStatement.contact
        public MakerElementInstance Element_Contact;                                                                                        // MakerGen.cs:232
        // 10. CapabilityStatement.description
        public MakerElementInstance Element_Description;                                                                                    // MakerGen.cs:232
        // 11. CapabilityStatement.useContext
        public MakerElementInstance Element_UseContext;                                                                                     // MakerGen.cs:232
        // 12. CapabilityStatement.jurisdiction
        public MakerElementInstance Element_Jurisdiction;                                                                                   // MakerGen.cs:232
        // 13. CapabilityStatement.purpose
        public MakerElementInstance Element_Purpose;                                                                                        // MakerGen.cs:232
        // 14. CapabilityStatement.copyright
        public MakerElementInstance Element_Copyright;                                                                                      // MakerGen.cs:232
        // 15. CapabilityStatement.kind
        public MakerElementInstance Element_Kind;                                                                                           // MakerGen.cs:232
        // 16. CapabilityStatement.instantiates
        public MakerElementInstance Element_Instantiates;                                                                                   // MakerGen.cs:232
        // 17. CapabilityStatement.imports
        public MakerElementInstance Element_Imports;                                                                                        // MakerGen.cs:232
        // 26. CapabilityStatement.fhirVersion
        public MakerElementInstance Element_FhirVersion;                                                                                    // MakerGen.cs:232
        // 27. CapabilityStatement.format
        public MakerElementInstance Element_Format;                                                                                         // MakerGen.cs:232
        // 28. CapabilityStatement.patchFormat
        public MakerElementInstance Element_PatchFormat;                                                                                    // MakerGen.cs:232
        // 29. CapabilityStatement.implementationGuide
        public MakerElementInstance Element_ImplementationGuide;                                                                            // MakerGen.cs:232
        public CapabilityStatement()                                                                                                        // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. CapabilityStatement.url
                this.Element_Url = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Uri()                                                                           // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. CapabilityStatement.version
                this.Element_Version = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Version",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. CapabilityStatement.name
                this.Element_Name = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. CapabilityStatement.title
                this.Element_Title = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Title",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. CapabilityStatement.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. CapabilityStatement.experimental
                this.Element_Experimental = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Experimental",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean()                                                                       // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. CapabilityStatement.date
                this.Element_Date = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. CapabilityStatement.publisher
                this.Element_Publisher = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 9. CapabilityStatement.contact
                this.Element_Contact = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 10. CapabilityStatement.description
                this.Element_Description = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Description",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 11. CapabilityStatement.useContext
                this.Element_UseContext = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 12. CapabilityStatement.jurisdiction
                this.Element_Jurisdiction = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 13. CapabilityStatement.purpose
                this.Element_Purpose = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Purpose",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 14. CapabilityStatement.copyright
                this.Element_Copyright = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Copyright",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 15. CapabilityStatement.kind
                this.Element_Kind = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Kind",                                                                                                  // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 16. CapabilityStatement.instantiates
                this.Element_Instantiates = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Instantiates",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Canonical()                                                                     // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 17. CapabilityStatement.imports
                this.Element_Imports = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Imports",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Canonical()                                                                     // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 26. CapabilityStatement.fhirVersion
                this.Element_FhirVersion = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_FhirVersion",                                                                                           // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 27. CapabilityStatement.format
                this.Element_Format = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Format",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 28. CapabilityStatement.patchFormat
                this.Element_PatchFormat = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_PatchFormat",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 29. CapabilityStatement.implementationGuide
                this.Element_ImplementationGuide = new MakerElementInstance                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ImplementationGuide",                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Canonical()                                                                     // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
