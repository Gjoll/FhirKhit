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
      "id": "TestScript",
      "url": "http://hl7.org/fhir/StructureDefinition/TestScript",
      "version": "4.0.0",
      "name": "TestScript",
      "status": "draft",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A structured set of tests against a FHIR server or client implementation to determine compliance against the FHIR specification.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "TestScript",
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
            "id": "TestScript",
            "path": "TestScript",
            "short": "Describes a set of tests",
            "definition": "A structured set of tests against a FHIR server or client implementation to determine compliance against the FHIR specification.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "TestScript.url",
            "path": "TestScript.url",
            "short": "Canonical identifier for this test script, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this test script when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this test script is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the test script is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the test script to be referenced by a single globally unique identifier.",
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
            "id": "TestScript.identifier",
            "path": "TestScript.identifier",
            "short": "Additional identifier for the test script",
            "definition": "A formal identifier that is used to identify this test script when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this test script outside of FHIR, where it is not possible to use the logical URI.",
            "requirements": "Allows externally provided and/or usable business identifiers to be easily associated with the module.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "TestScript.version",
            "path": "TestScript.version",
            "short": "Business version of the test script",
            "definition": "The identifier that is used to identify this version of the test script when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the test script author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different test script instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the test script with the format [url]|[version].",
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
            "id": "TestScript.name",
            "path": "TestScript.name",
            "short": "Name for this test script (computer friendly)",
            "definition": "A natural language name identifying the test script. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "TestScript.title",
            "path": "TestScript.title",
            "short": "Name for this test script (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the test script.",
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
            "id": "TestScript.status",
            "path": "TestScript.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this test script. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of test scripts that are appropriate for use versus not.",
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
            "id": "TestScript.experimental",
            "path": "TestScript.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this test script is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of test scripts that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level test script.",
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
            "id": "TestScript.date",
            "path": "TestScript.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the test script was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the test script changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the test script. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "TestScript.publisher",
            "path": "TestScript.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the test script.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the test script is the organization or individual primarily responsible for the maintenance and upkeep of the test script. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the test script. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the test script.  May also allow for contact.",
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
            "id": "TestScript.contact",
            "path": "TestScript.contact",
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
            "id": "TestScript.description",
            "path": "TestScript.description",
            "short": "Natural language description of the test script",
            "definition": "A free text natural language description of the test script from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the test script was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the test script as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the test script is presumed to be the predominant language in the place the test script was created).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "TestScript.useContext",
            "path": "TestScript.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate test script instances.",
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
            "id": "TestScript.jurisdiction",
            "path": "TestScript.jurisdiction",
            "short": "Intended jurisdiction for test script (if applicable)",
            "definition": "A legal or geographic region in which the test script is intended to be used.",
            "comment": "It may be possible for the test script to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "TestScript.purpose",
            "path": "TestScript.purpose",
            "short": "Why this test script is defined",
            "definition": "Explanation of why this test script is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the test script. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this test script.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "TestScript.copyright",
            "path": "TestScript.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the test script and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the test script.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the test script and/or its content.",
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
            "id": "TestScript.origin",
            "path": "TestScript.origin",
            "short": "An abstract server representing a client or sender in a message exchange",
            "definition": "An abstract server used in operations within this test script in the origin element.",
            "comment": "The purpose of this element is to define the profile of an origin element used elsewhere in the script.  Test engines could then use the origin-profile mapping to offer a filtered list of test systems that can serve as the sender for the interaction.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.origin.index",
            "path": "TestScript.origin.index",
            "short": "The index of the abstract origin server starting at 1",
            "definition": "Abstract name given to an origin server in this test script.  The name is provided as a number starting at 1.",
            "comment": "A given origin index (e.g. 1) can appear only once in the list (e.g. Origin 1 cannot be specified twice ... once as FormFiller and again as FormProcessor within the same script as that could get confusing during test configuration). \n\nDifferent origin indices could play the same actor in the same test script (e.g. You could have two different test systems acting as Form-Filler).\n\nThe origin indices provided elsewhere in the test script must be one of these origin indices.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "TestScript.origin.profile",
            "path": "TestScript.origin.profile",
            "short": "FHIR-Client | FHIR-SDC-FormFiller",
            "definition": "The type of origin profile the test system supports.",
            "comment": "Must be a \"sender\"/\"client\" profile.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "meaningWhenMissing": "FHIR-Client",
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "TestScriptProfileOriginType"
                }
              ],
              "strength": "extensible",
              "description": "The type of origin profile the test system supports.",
              "valueSet": "http://hl7.org/fhir/ValueSet/testscript-profile-origin-types"
            }
          },
          {
            "id": "TestScript.destination",
            "path": "TestScript.destination",
            "short": "An abstract server representing a destination or receiver in a message exchange",
            "definition": "An abstract server used in operations within this test script in the destination element.",
            "comment": "The purpose of this element is to define the profile of a destination element used elsewhere in the script.  Test engines could then use the destination-profile mapping to offer a filtered list of test systems that can serve as the receiver for the interaction.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.destination.index",
            "path": "TestScript.destination.index",
            "short": "The index of the abstract destination server starting at 1",
            "definition": "Abstract name given to a destination server in this test script.  The name is provided as a number starting at 1.",
            "comment": "A given destination index (e.g. 1) can appear only once in the list (e.g. Destination 1 cannot be specified twice ... once as Form-Manager and again as Form-Processor within the same script as that could get confusing during test configuration). \n\nDifferent destination indices could play the same actor in the same test script (e.g. You could have two different test systems acting as Form-Manager).\n\nThe destination indices provided elsewhere in the test script must be one of these destination indices.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "TestScript.destination.profile",
            "path": "TestScript.destination.profile",
            "short": "FHIR-Server | FHIR-SDC-FormManager | FHIR-SDC-FormReceiver | FHIR-SDC-FormProcessor",
            "definition": "The type of destination profile the test system supports.",
            "comment": "Must be a \"receiver\"/\"server\" profile.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "meaningWhenMissing": "FHIR-Server",
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "TestScriptProfileDestinationType"
                }
              ],
              "strength": "extensible",
              "description": "The type of destination profile the test system supports.",
              "valueSet": "http://hl7.org/fhir/ValueSet/testscript-profile-destination-types"
            }
          },
          {
            "id": "TestScript.metadata",
            "path": "TestScript.metadata",
            "short": "Required capability that is assumed to function correctly on the FHIR server being tested",
            "definition": "The required capability must exist and are assumed to function correctly on the FHIR server being tested.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.metadata.link",
            "path": "TestScript.metadata.link",
            "short": "Links to the FHIR specification",
            "definition": "A link to the FHIR specification that this test is covering.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.metadata.link.url",
            "path": "TestScript.metadata.link.url",
            "short": "URL to the specification",
            "definition": "URL to a particular requirement or feature within the FHIR specification.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "TestScript.metadata.link.description",
            "path": "TestScript.metadata.link.description",
            "short": "Short description",
            "definition": "Short description of the link.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.metadata.capability",
            "path": "TestScript.metadata.capability",
            "short": "Capabilities  that are assumed to function correctly on the FHIR server being tested",
            "definition": "Capabilities that must exist and are assumed to function correctly on the FHIR server being tested.",
            "comment": "When the metadata capabilities section is defined at TestScript.metadata or at TestScript.setup.metadata, and the server's conformance statement does not contain the elements defined in the minimal conformance statement, then all the tests in the TestScript are skipped.  When the metadata capabilities section is defined at TestScript.test.metadata and the server's conformance statement does not contain the elements defined in the minimal conformance statement, then only that test is skipped.  The \"metadata.capabilities.required\" and \"metadata.capabilities.validated\" elements only indicate whether the capabilities are the primary focus of the test script or not.  They do not impact the skipping logic.  Capabilities whose \"metadata.capabilities.validated\" flag is true are the primary focus of the test script.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.metadata.capability.required",
            "path": "TestScript.metadata.capability.required",
            "short": "Are the capabilities required?",
            "definition": "Whether or not the test execution will require the given capabilities of the server in order for this test script to execute.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TestScript.metadata.capability.validated",
            "path": "TestScript.metadata.capability.validated",
            "short": "Are the capabilities validated?",
            "definition": "Whether or not the test execution will validate the given capabilities of the server in order for this test script to execute.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TestScript.metadata.capability.description",
            "path": "TestScript.metadata.capability.description",
            "short": "The expected capabilities of the server",
            "definition": "Description of the capabilities that this test script is requiring the server to support.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.metadata.capability.origin",
            "path": "TestScript.metadata.capability.origin",
            "short": "Which origin server these requirements apply to",
            "definition": "Which origin server these requirements apply to.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "TestScript.metadata.capability.destination",
            "path": "TestScript.metadata.capability.destination",
            "short": "Which server these requirements apply to",
            "definition": "Which server these requirements apply to.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "TestScript.metadata.capability.link",
            "path": "TestScript.metadata.capability.link",
            "short": "Links to the FHIR specification",
            "definition": "Links to the FHIR specification that describes this interaction and the resources involved in more detail.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "TestScript.metadata.capability.capabilities",
            "path": "TestScript.metadata.capability.capabilities",
            "short": "Required Capability Statement",
            "definition": "Minimum capabilities required of server for test script to execute successfully.   If server does not meet at a minimum the referenced capability statement, then all tests in this script are skipped.",
            "comment": "The conformance statement of the server has to contain at a minimum the contents of the reference pointed to by this element.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CapabilityStatement"
                ]
              }
            ]
          },
          {
            "id": "TestScript.fixture",
            "path": "TestScript.fixture",
            "short": "Fixture in the test script - by reference (uri)",
            "definition": "Fixture in the test script - by reference (uri). All fixtures are required for the test script to execute.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.fixture.autocreate",
            "path": "TestScript.fixture.autocreate",
            "short": "Whether or not to implicitly create the fixture during setup",
            "definition": "Whether or not to implicitly create the fixture during setup. If true, the fixture is automatically created on each server being tested during setup, therefore no create operation is required for this fixture in the TestScript.setup section.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TestScript.fixture.autodelete",
            "path": "TestScript.fixture.autodelete",
            "short": "Whether or not to implicitly delete the fixture during teardown",
            "definition": "Whether or not to implicitly delete the fixture during teardown. If true, the fixture is automatically deleted on each server being tested during teardown, therefore no delete operation is required for this fixture in the TestScript.teardown section.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TestScript.fixture.resource",
            "path": "TestScript.fixture.resource",
            "short": "Reference of the resource",
            "definition": "Reference to the resource (containing the contents of the resource needed for operations).",
            "comment": "See http://build.fhir.org/resourcelist.html for complete list of resource types.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "TestScript.profile",
            "path": "TestScript.profile",
            "short": "Reference of the validation profile",
            "definition": "Reference to the profile to be used for validation.",
            "comment": "See http://build.fhir.org/resourcelist.html for complete list of resource types.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "TestScript.variable",
            "path": "TestScript.variable",
            "short": "Placeholder for evaluated elements",
            "definition": "Variable is set based either on element value in response body or on header field value in the response headers.",
            "comment": "Variables would be set based either on XPath/JSONPath expressions against fixtures (static and response), or headerField evaluations against response headers. If variable evaluates to nodelist or anything other than a primitive value, then test engine would report an error.  Variables would be used to perform clean replacements in \"operation.params\", \"operation.requestHeader.value\", and \"operation.url\" element values during operation calls and in \"assert.value\" during assertion evaluations. This limits the places that test engines would need to look for placeholders \"${}\".  Variables are scoped to the whole script. They are NOT evaluated at declaration. They are evaluated by test engine when used for substitutions in \"operation.params\", \"operation.requestHeader.value\", and \"operation.url\" element values during operation calls and in \"assert.value\" during assertion evaluations.  See example testscript-search.xml.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.variable.name",
            "path": "TestScript.variable.name",
            "short": "Descriptive name for this variable",
            "definition": "Descriptive name for this variable.",
            "comment": "Placeholders would contain the variable name wrapped in ${} in \"operation.params\", \"operation.requestHeader.value\", and \"operation.url\" elements.  These placeholders would need to be replaced by the variable value before the operation is executed.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.variable.defaultValue",
            "path": "TestScript.variable.defaultValue",
            "short": "Default, hard-coded, or user-defined value for this variable",
            "definition": "A default, hard-coded, or user-defined value for this variable.",
            "comment": "The purpose of this element is to allow for a pre-defined value that can be used as a default or as an override value. Test engines can optionally use this as a placeholder for user-defined execution time values.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.variable.description",
            "path": "TestScript.variable.description",
            "short": "Natural language description of the variable",
            "definition": "A free text natural language description of the variable and its purpose.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.variable.expression",
            "path": "TestScript.variable.expression",
            "short": "The FHIRPath expression against the fixture body",
            "definition": "The FHIRPath expression to evaluate against the fixture body. When variables are defined, only one of either expression, headerField or path must be specified.",
            "comment": "If headerField is defined, then the variable will be evaluated against the headers that sourceId is pointing to.  If expression or path is defined, then the variable will be evaluated against the fixture body that sourceId is pointing to.  It is an error to define any combination of expression, headerField and path.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.variable.headerField",
            "path": "TestScript.variable.headerField",
            "short": "HTTP header field name for source",
            "definition": "Will be used to grab the HTTP header field value from the headers that sourceId is pointing to.",
            "comment": "If headerField is defined, then the variable will be evaluated against the headers that sourceId is pointing to.  If path is defined, then the variable will be evaluated against the fixture body that sourceId is pointing to.  It is an error to define both headerField and path.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.variable.hint",
            "path": "TestScript.variable.hint",
            "short": "Hint help text for default value to enter",
            "definition": "Displayable text string with hint help information to the user when entering a default value.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.variable.path",
            "path": "TestScript.variable.path",
            "short": "XPath or JSONPath against the fixture body",
            "definition": "XPath or JSONPath to evaluate against the fixture body.  When variables are defined, only one of either expression, headerField or path must be specified.",
            "comment": "If headerField is defined, then the variable will be evaluated against the headers that sourceId is pointing to.  If expression or path is defined, then the variable will be evaluated against the fixture body that sourceId is pointing to.  It is an error to define any combination of expression, headerField and path.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.variable.sourceId",
            "path": "TestScript.variable.sourceId",
            "short": "Fixture Id of source expression or headerField within this variable",
            "definition": "Fixture to evaluate the XPath/JSONPath expression or the headerField  against within this variable.",
            "comment": "This can be a statically defined fixture (at the top of the TestScript) or a dynamically set fixture created by responseId of the `action.operation` element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ]
          },
          {
            "id": "TestScript.setup",
            "path": "TestScript.setup",
            "short": "A series of required setup operations before tests are executed",
            "definition": "A series of required setup operations before tests are executed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.setup.action",
            "path": "TestScript.setup.action",
            "short": "A setup operation or assert to perform",
            "definition": "Action would contain either an operation or an assertion.",
            "comment": "An action should contain either an operation or an assertion but not both.  It can contain any number of variables.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation",
            "path": "TestScript.setup.action.operation",
            "short": "The setup operation to perform",
            "definition": "The operation to perform.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.type",
            "path": "TestScript.setup.action.operation.type",
            "short": "The operation code type that will be executed",
            "definition": "Server interaction or operation type.",
            "comment": "See http://build.fhir.org/http.html for list of server interactions.",
            "min": 0,
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
                  "valueString": "TestScriptOperationCode"
                }
              ],
              "strength": "extensible",
              "description": "The allowable operation code types.",
              "valueSet": "http://hl7.org/fhir/ValueSet/testscript-operation-codes"
            }
          },
          {
            "id": "TestScript.setup.action.operation.resource",
            "path": "TestScript.setup.action.operation.resource",
            "short": "Resource type",
            "definition": "The type of the resource.  See http://build.fhir.org/resourcelist.html.",
            "comment": "If \"url\" element is specified, then \"targetId\", \"params\", and \"resource\" elements will be ignored as \"url\" element will have everything needed for constructing the request url.  If \"params\" element is specified, then \"targetId\" element is ignored. For FHIR operations that require a resource (e.g. \"read\" and \"vread\" operations), the \"resource\" element must be specified when \"params\" element is specified.  If \"url\" and \"params\" elements are absent, then the request url will be constructed from \"targetId\" fixture if present. For \"read\" operation, the resource and id values will be extracted from \"targetId\" fixture and used to construct the url. For \"vread\" and \"history\" operations, the versionId value will also be used.",
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
                  "valueString": "FHIRDefinedType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "A list of all the concrete types defined in this version of the FHIR specification - Data Types and Resource Types.",
              "valueSet": "http://hl7.org/fhir/ValueSet/defined-types|4.0.0"
            }
          },
          {
            "id": "TestScript.setup.action.operation.label",
            "path": "TestScript.setup.action.operation.label",
            "short": "Tracking/logging operation label",
            "definition": "The label would be used for tracking/logging purposes by test engines.",
            "comment": "This has no impact on the verification itself.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.description",
            "path": "TestScript.setup.action.operation.description",
            "short": "Tracking/reporting operation description",
            "definition": "The description would be used by test engines for tracking and reporting purposes.",
            "comment": "This has no impact on the verification itself.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.accept",
            "path": "TestScript.setup.action.operation.accept",
            "short": "Mime type to accept in the payload of the response, with charset etc.",
            "definition": "The mime-type to use for RESTful operation in the 'Accept' header.",
            "comment": "If this is specified, then test engine shall set the 'Accept' header to the corresponding value.  If you'd like to explicitly set the 'Accept' to some other value then use the 'requestHeader' element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueCode": "application/fhir+xml"
              }
            ],
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
            "id": "TestScript.setup.action.operation.contentType",
            "path": "TestScript.setup.action.operation.contentType",
            "short": "Mime type of the request payload contents, with charset etc.",
            "definition": "The mime-type to use for RESTful operation in the 'Content-Type' header.",
            "comment": "If this is specified, then test engine shall set the 'Content-Type' header to the corresponding value.  If you'd like to explicitly set the 'Content-Type' to some other value then use the 'requestHeader' element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueCode": "application/fhir+xml"
              }
            ],
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
            "id": "TestScript.setup.action.operation.destination",
            "path": "TestScript.setup.action.operation.destination",
            "short": "Server responding to the request",
            "definition": "The server where the request message is destined for.  Must be one of the server numbers listed in TestScript.destination section.",
            "comment": "If multiple TestScript.destination elements are defined and operation.destination is undefined, test engine will report an error as it cannot determine what destination to use for the exchange.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.encodeRequestUrl",
            "path": "TestScript.setup.action.operation.encodeRequestUrl",
            "short": "Whether or not to send the request url in encoded format",
            "definition": "Whether or not to implicitly send the request url in encoded format. The default is true to match the standard RESTful client behavior. Set to false when communicating with a server that does not support encoded url paths.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.method",
            "path": "TestScript.setup.action.operation.method",
            "short": "delete | get | options | patch | post | put | head",
            "definition": "The HTTP method the test engine MUST use for this operation regardless of any other operation details.",
            "comment": "The primary purpose of the explicit HTTP method is support of  HTTP POST method invocation of the FHIR search. Other uses will include support of negative testing.",
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
                  "valueString": "TestScriptRequestMethodCode"
                }
              ],
              "strength": "required",
              "description": "The allowable request method or HTTP operation codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/http-operations|4.0.0"
            }
          },
          {
            "id": "TestScript.setup.action.operation.origin",
            "path": "TestScript.setup.action.operation.origin",
            "short": "Server initiating the request",
            "definition": "The server where the request message originates from.  Must be one of the server numbers listed in TestScript.origin section.",
            "comment": "If absent, test engine will send the message.  When present, test engine will not send the request message but will wait for the request message to be sent from this origin server.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.params",
            "path": "TestScript.setup.action.operation.params",
            "short": "Explicitly defined path parameters",
            "definition": "Path plus parameters after [type].  Used to set parts of the request URL explicitly.",
            "comment": "If \"url\" element is specified, then \"targetId\", \"params\", and \"resource\" elements will be ignored as \"url\" element will have everything needed for constructing the request url.  If \"params\" element is specified, then \"targetId\" element is ignored.  For FHIR operations that require a resource (e.g. \"read\" and \"vread\" operations), the \"resource\" element must be specified when \"params\" element is specified.  If \"url\" and \"params\" elements are absent, then the request url will be constructed from \"targetId\" fixture if present.  For \"read\" operation, the resource and id values will be extracted from \"targetId\" fixture and used to construct the url.  For \"vread\" and \"history\" operations, the versionId value will also be used.   Test engines would append whatever is specified for \"params\" to the URL after the resource type without tampering with the string (beyond encoding the URL for HTTP).  The \"params\" element does not correspond exactly to \"search parameters\".  Nor is it the \"path\".  It corresponds to the part of the URL that comes after the [type] (when \"resource\" element is specified); e.g. It corresponds to \"/[id]/_history/[vid] {?_format=[mime-type]}\" in the following operation: GET [base]/[type]/[id]/_history/[vid] {?_format=[mime-type]}  Test engines do have to look for placeholders (${}) and replace the variable placeholders with the variable values at runtime before sending the request.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.requestHeader",
            "path": "TestScript.setup.action.operation.requestHeader",
            "short": "Each operation can have one or more header elements",
            "definition": "Header elements would be used to set HTTP headers.",
            "comment": "This gives control to test-script writers to set headers explicitly based on test requirements.  It will allow for testing using:  - \"If-Modified-Since\" and \"If-None-Match\" headers.  See http://build.fhir.org/http.html#2.1.0.5.1 - \"If-Match\" header.  See http://build.fhir.org/http.html#2.1.0.11 - Conditional Create using \"If-None-Exist\".  See http://build.fhir.org/http.html#2.1.0.13.1 - Invalid \"Content-Type\" header for negative testing. - etc.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.requestHeader.field",
            "path": "TestScript.setup.action.operation.requestHeader.field",
            "short": "HTTP header field name",
            "definition": "The HTTP header field e.g. \"Accept\".",
            "comment": "If header element is specified, then field is required.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.requestHeader.value",
            "path": "TestScript.setup.action.operation.requestHeader.value",
            "short": "HTTP headerfield value",
            "definition": "The value of the header e.g. \"application/fhir+xml\".",
            "comment": "If header element is specified, then value is required.  No conversions will be done by the test engine e.g. \"xml\" to \"application/fhir+xml\".  The values will be set in HTTP headers \"as-is\".  Test engines do have to look for placeholders (${}) and replace the variable placeholders with the variable values at runtime before sending the request.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.requestId",
            "path": "TestScript.setup.action.operation.requestId",
            "short": "Fixture Id of mapped request",
            "definition": "The fixture id (maybe new) to map to the request.",
            "comment": "If a requestId is supplied, then the resulting request (both headers and body) is mapped to the fixture ID (which may be entirely new and previously undeclared) designated by \"requestId\".  If requestId is not specified, it is the test engine's responsibility to store the request and use it as the requestId in subsequent assertions when assertion path and/or headerField is specified, direction is equal to request, and the requestId in not specified.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.responseId",
            "path": "TestScript.setup.action.operation.responseId",
            "short": "Fixture Id of mapped response",
            "definition": "The fixture id (maybe new) to map to the response.",
            "comment": "If a responseId is supplied, and the server responds, then the resulting response (both headers and body) is mapped to the fixture ID (which may be entirely new and previously undeclared) designated by \"responseId\".  If responseId is not specified, it is the test engine's responsibility to store the response and use it as the responseId in subsequent assertions when assertion path and/or headerField is specified and the responseId is not specified.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.sourceId",
            "path": "TestScript.setup.action.operation.sourceId",
            "short": "Fixture Id of body for PUT and POST requests",
            "definition": "The id of the fixture used as the body of a PUT or POST request.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.targetId",
            "path": "TestScript.setup.action.operation.targetId",
            "short": "Id of fixture used for extracting the [id],  [type], and [vid] for GET requests",
            "definition": "Id of fixture used for extracting the [id],  [type], and [vid] for GET requests.",
            "comment": "If \"url\" element is specified, then \"targetId\", \"params\", and \"resource\" elements will be ignored as \"url\" element will have everything needed for constructing the request url.  If \"params\" element is specified, then \"targetId\" element is ignored.  For FHIR operations that require a resource (e.g. \"read\" and \"vread\" operations), the \"resource\" element must be specified when \"params\" element is specified.  If \"url\" and \"params\" elements are absent, then the request url will be constructed from \"targetId\" fixture if present.  For \"read\" operation, the resource and id values will be extracted from \"targetId\" fixture and used to construct the url.  For \"vread\" and \"history\" operations, the versionId value will also be used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.operation.url",
            "path": "TestScript.setup.action.operation.url",
            "short": "Request URL",
            "definition": "Complete request URL.",
            "comment": "Used to set the request URL explicitly.  If \"url\" element is defined, then \"targetId\", \"resource\", and \"params\" elements will be ignored.  Test engines would use whatever is specified in \"url\" without tampering with the string (beyond encoding the URL for HTTP).  Test engines do have to look for placeholders (${}) and replace the variable placeholders with the variable values at runtime before sending the request.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert",
            "path": "TestScript.setup.action.assert",
            "short": "The assertion to perform",
            "definition": "Evaluates the results of previous operations to determine if the server under test behaves appropriately.",
            "comment": "In order to evaluate an assertion, the request, response, and results of the most recently executed operation must always be maintained by the test engine.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.label",
            "path": "TestScript.setup.action.assert.label",
            "short": "Tracking/logging assertion label",
            "definition": "The label would be used for tracking/logging purposes by test engines.",
            "comment": "This has no impact on the verification itself.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.description",
            "path": "TestScript.setup.action.assert.description",
            "short": "Tracking/reporting assertion description",
            "definition": "The description would be used by test engines for tracking and reporting purposes.",
            "comment": "This has no impact on the verification itself.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.direction",
            "path": "TestScript.setup.action.assert.direction",
            "short": "response | request",
            "definition": "The direction to use for the assertion.",
            "comment": "If the direction is specified as \"response\" (the default), then the processing of this assert is against the received response message. If the direction is specified as \"request\", then the processing of this assert is against the sent request message.",
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
                  "valueString": "AssertionDirectionType"
                }
              ],
              "strength": "required",
              "description": "The type of direction to use for assertion.",
              "valueSet": "http://hl7.org/fhir/ValueSet/assert-direction-codes|4.0.0"
            }
          },
          {
            "id": "TestScript.setup.action.assert.compareToSourceId",
            "path": "TestScript.setup.action.assert.compareToSourceId",
            "short": "Id of the source fixture to be evaluated",
            "definition": "Id of the source fixture used as the contents to be evaluated by either the \"source/expression\" or \"sourceId/path\" definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.compareToSourceExpression",
            "path": "TestScript.setup.action.assert.compareToSourceExpression",
            "short": "The FHIRPath expression to evaluate against the source fixture",
            "definition": "The FHIRPath expression to evaluate against the source fixture. When compareToSourceId is defined, either compareToSourceExpression or compareToSourcePath must be defined, but not both.",
            "comment": "Thefhirpath expression to be evaluated against the expected fixture to compare to. Ignored if \"assert.value\" is used. The evaluation will be done before the assertion is evaluated.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.compareToSourcePath",
            "path": "TestScript.setup.action.assert.compareToSourcePath",
            "short": "XPath or JSONPath expression to evaluate against the source fixture",
            "definition": "XPath or JSONPath expression to evaluate against the source fixture. When compareToSourceId is defined, either compareToSourceExpression or compareToSourcePath must be defined, but not both.",
            "comment": "The XPath or JSONPath expression to be evaluated against the expected fixture to compare to. Ignored if \"assert.value\" is used. The evaluation will be done before the assertion is evaluated.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.contentType",
            "path": "TestScript.setup.action.assert.contentType",
            "short": "Mime type to compare against the 'Content-Type' header",
            "definition": "The mime-type contents to compare against the request or response message 'Content-Type' header.",
            "comment": "If this is specified, then test engine shall confirm that the content-type of the last operation's headers is set to this value.  If \"assert.sourceId\" element is specified, then the evaluation will be done against the headers mapped to that sourceId (and not the last operation's headers).  If you'd like to have more control over the string, then use 'assert.headerField' instead.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "example": [
              {
                "label": "General",
                "valueCode": "application/fhir+xml"
              }
            ],
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
            "id": "TestScript.setup.action.assert.expression",
            "path": "TestScript.setup.action.assert.expression",
            "short": "The FHIRPath expression to be evaluated",
            "definition": "The FHIRPath expression to be evaluated against the request or response message contents - HTTP headers and payload.",
            "comment": "If both \"expression\" and a \"fixtureId\" are specified, then the expression will be evaluated against the request or response body mapped to the fixtureId.  If \"expression\" is specified and a \"fixtureId\" is not, then the expression will be evaluated against the response body of the last operation.  Test engines are to store the request and response body and headers of the last operation at all times for subsequent assertions.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.headerField",
            "path": "TestScript.setup.action.assert.headerField",
            "short": "HTTP header field name",
            "definition": "The HTTP header field name e.g. 'Location'.",
            "comment": "If \"headerField\" is specified then \"value\" must be specified.  If \"sourceId\" is not specified, then \"headerField\" will be evaluated against the last operation's response headers.  Test engines are to keep track of the last operation's response body and response headers.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.minimumId",
            "path": "TestScript.setup.action.assert.minimumId",
            "short": "Fixture Id of minimum content resource",
            "definition": "The ID of a fixture.  Asserts that the response contains at a minimum the fixture specified by minimumId.",
            "comment": "Asserts that the response contains all the element/content in another fixture pointed to by minimumId.  This can be a statically defined fixture or one that is dynamically set via responseId.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.navigationLinks",
            "path": "TestScript.setup.action.assert.navigationLinks",
            "short": "Perform validation on navigation links?",
            "definition": "Whether or not the test execution performs validation on the bundle navigation links.",
            "comment": "Asserts that the Bundle contains first, last, and next links.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.operator",
            "path": "TestScript.setup.action.assert.operator",
            "short": "equals | notEquals | in | notIn | greaterThan | lessThan | empty | notEmpty | contains | notContains | eval",
            "definition": "The operator type defines the conditional behavior of the assert. If not defined, the default is equals.",
            "comment": "Operators are useful especially for negative testing.  If operator is not specified, then the \"equals\" operator is assumed; e.g. ```<code>   <assert>  <operator value=\"in\" />  <responseCode value=\"200,201,204\" />    </assert>    <assert>  <operator value=\"notEquals\" />  <response value=\"okay\"/>   </assert>    <assert>  <operator value=\"greaterThan\" />    <responseHeader>     <field value=\"Content-Length\" />     <value value=\"0\" />    </responseHeader/>   </assert> </code> ```.",
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
                  "valueString": "AssertionOperatorType"
                }
              ],
              "strength": "required",
              "description": "The type of operator to use for assertion.",
              "valueSet": "http://hl7.org/fhir/ValueSet/assert-operator-codes|4.0.0"
            }
          },
          {
            "id": "TestScript.setup.action.assert.path",
            "path": "TestScript.setup.action.assert.path",
            "short": "XPath or JSONPath expression",
            "definition": "The XPath or JSONPath expression to be evaluated against the fixture representing the response received from server.",
            "comment": "If both \"path\" and a \"fixtureId\" are specified, then the path will be evaluated against the request or response body mapped to the fixtureId.  If \"path\" is specified and a \"fixtureId\" is not, then the path will be evaluated against the response body of the last operation.  Test engines are to store the request and response body and headers of the last operation at all times for subsequent assertions.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.requestMethod",
            "path": "TestScript.setup.action.assert.requestMethod",
            "short": "delete | get | options | patch | post | put | head",
            "definition": "The request method or HTTP operation code to compare against that used by the client system under test.",
            "comment": "If \"requestMethod\" is specified then it will be used in place of \"value\". The \"requestMethod\" will evaluate against the last operation's request HTTP operation.",
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
                  "valueString": "TestScriptRequestMethodCode"
                }
              ],
              "strength": "required",
              "description": "The allowable request method or HTTP operation codes.",
              "valueSet": "http://hl7.org/fhir/ValueSet/http-operations|4.0.0"
            }
          },
          {
            "id": "TestScript.setup.action.assert.requestURL",
            "path": "TestScript.setup.action.assert.requestURL",
            "short": "Request URL comparison value",
            "definition": "The value to use in a comparison against the request URL path string.",
            "comment": "If \"requestURL\" is specified then it will be used in place of \"value\". The \"requestURL\" will evaluate against the last operation's full request URL path string.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.resource",
            "path": "TestScript.setup.action.assert.resource",
            "short": "Resource type",
            "definition": "The type of the resource.  See http://build.fhir.org/resourcelist.html.",
            "comment": "This will be expected resource type in response body e.g. in read, vread, search, etc.  See http://build.fhir.org/resourcelist.html for complete list of resource types; e.g. <assert > <resourceType value=\"Patient\" </assert>.",
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
                  "valueString": "FHIRDefinedType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "A list of all the concrete types defined in this version of the FHIR specification - Data Types and Resource Types.",
              "valueSet": "http://hl7.org/fhir/ValueSet/defined-types|4.0.0"
            }
          },
          {
            "id": "TestScript.setup.action.assert.response",
            "path": "TestScript.setup.action.assert.response",
            "short": "okay | created | noContent | notModified | bad | forbidden | notFound | methodNotAllowed | conflict | gone | preconditionFailed | unprocessable",
            "definition": "okay | created | noContent | notModified | bad | forbidden | notFound | methodNotAllowed | conflict | gone | preconditionFailed | unprocessable.",
            "comment": "This is a shorter way of achieving similar verifications via \"assert.responseCode\".  If you need more control, then use \"assert.responseCode\"  e.g. <assert>  <contentType value=\"json\" />  <response value=\"okay\"/> </assert>.",
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
                  "valueString": "AssertionResponseTypes"
                }
              ],
              "strength": "required",
              "description": "The type of response code to use for assertion.",
              "valueSet": "http://hl7.org/fhir/ValueSet/assert-response-code-types|4.0.0"
            }
          },
          {
            "id": "TestScript.setup.action.assert.responseCode",
            "path": "TestScript.setup.action.assert.responseCode",
            "short": "HTTP response code to test",
            "definition": "The value of the HTTP response code to be tested.",
            "comment": "To be used with \"operator\" attribute value. Asserts that the response code equals this value if \"operator\" is not specified.   If the operator is \"in\" or \"notIn\" then the responseCode would be a comma-separated list of values e.g. \"200,201\". Otherwise, it's expected to be a numeric value.   If \"fixture\" is not specified, then the \"responseBodyId\" value of the last operation is assumed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.sourceId",
            "path": "TestScript.setup.action.assert.sourceId",
            "short": "Fixture Id of source expression or headerField",
            "definition": "Fixture to evaluate the XPath/JSONPath expression or the headerField  against.",
            "comment": "This can be a statically defined fixture (at the top of the testscript) or a dynamically set fixture created by responseId of the action.operation element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.validateProfileId",
            "path": "TestScript.setup.action.assert.validateProfileId",
            "short": "Profile Id of validation profile reference",
            "definition": "The ID of the Profile to validate against.",
            "comment": "The ID of a Profile fixture. Asserts that the response is valid according to the Profile specified by validateProfileId.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.value",
            "path": "TestScript.setup.action.assert.value",
            "short": "The value to compare to",
            "definition": "The value to compare to.",
            "comment": "The string-representation of a number, string, or boolean that is expected.  Test engines do have to look for placeholders (${}) and replace the variable placeholders with the variable values at runtime before comparing this value to the actual value.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.setup.action.assert.warningOnly",
            "path": "TestScript.setup.action.assert.warningOnly",
            "short": "Will this assert produce a warning only on error?",
            "definition": "Whether or not the test execution will produce a warning only on error for this assert.",
            "comment": "If this element is specified and it is true, then assertion failures can be logged by test engine but should not stop the test script execution from proceeding.  There are likely cases where the spec is not clear on what should happen. If the spec says something is optional (maybe a response header for example), but a server doesn’t do it, we could choose to issue a warning.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "TestScript.test",
            "path": "TestScript.test",
            "short": "A test in this script",
            "definition": "A test in this script.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.test.name",
            "path": "TestScript.test.name",
            "short": "Tracking/logging name of this test",
            "definition": "The name of this test used for tracking/logging purposes by test engines.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.test.description",
            "path": "TestScript.test.description",
            "short": "Tracking/reporting short description of the test",
            "definition": "A short description of the test used by test engines for tracking and reporting purposes.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "TestScript.test.action",
            "path": "TestScript.test.action",
            "short": "A test operation or assert to perform",
            "definition": "Action would contain either an operation or an assertion.",
            "comment": "An action should contain either an operation or an assertion but not both.  It can contain any number of variables.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.test.action.operation",
            "path": "TestScript.test.action.operation",
            "short": "The setup operation to perform",
            "definition": "An operation would involve a REST request to a server.",
            "min": 0,
            "max": "1",
            "contentReference": "#TestScript.setup.action.operation"
          },
          {
            "id": "TestScript.test.action.assert",
            "path": "TestScript.test.action.assert",
            "short": "The setup assertion to perform",
            "definition": "Evaluates the results of previous operations to determine if the server under test behaves appropriately.",
            "comment": "In order to evaluate an assertion, the request, response, and results of the most recently executed operation must always be maintained by the test engine.",
            "min": 0,
            "max": "1",
            "contentReference": "#TestScript.setup.action.assert"
          },
          {
            "id": "TestScript.teardown",
            "path": "TestScript.teardown",
            "short": "A series of required clean up steps",
            "definition": "A series of operations required to clean up after all the tests are executed (successfully or otherwise).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.teardown.action",
            "path": "TestScript.teardown.action",
            "short": "One or more teardown operations to perform",
            "definition": "The teardown action will only contain an operation.",
            "comment": "An action should contain either an operation or an assertion but not both.  It can contain any number of variables.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "TestScript.teardown.action.operation",
            "path": "TestScript.teardown.action.operation",
            "short": "The teardown operation to perform",
            "definition": "An operation would involve a REST request to a server.",
            "min": 1,
            "max": "1",
            "contentReference": "#TestScript.setup.action.operation"
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'TestScript'
    /// </summary>
    // 0. TestScript
    public class TestScript : FhirKhit.Maker.Common.Resource.ResourceBase                                                                   // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class TestScript_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                      // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 16. TestScript.origin
            public class Type_Origin : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Origin_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 17. TestScript.origin.index
                    public ElementDefinitionInfo Index;                                                                                     // MakerGen.cs:236
                    // 18. TestScript.origin.profile
                    public ElementDefinitionInfo Profile;                                                                                   // MakerGen.cs:236
                    public Type_Origin_Elements()                                                                                           // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 17. TestScript.origin.index
                            this.Index = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Index",                                                                                             // MakerGen.cs:255
                                Path= "TestScript.origin.index",                                                                            // MakerGen.cs:256
                                Id = "TestScript.origin.index",                                                                             // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 18. TestScript.origin.profile
                            this.Profile = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Profile",                                                                                           // MakerGen.cs:255
                                Path= "TestScript.origin.profile",                                                                          // MakerGen.cs:256
                                Id = "TestScript.origin.profile",                                                                           // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Index.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Profile.Write(sDef);                                                                                                // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Origin_Elements Elements { get; }                                                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Origin()                                                                                                        // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Origin_Elements();                                                                             // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 19. TestScript.destination
            public class Type_Destination : FhirKhit.Maker.Common.Complex.ComplexBase                                                       // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Destination_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                        // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 20. TestScript.destination.index
                    public ElementDefinitionInfo Index;                                                                                     // MakerGen.cs:236
                    // 21. TestScript.destination.profile
                    public ElementDefinitionInfo Profile;                                                                                   // MakerGen.cs:236
                    public Type_Destination_Elements()                                                                                      // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 20. TestScript.destination.index
                            this.Index = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Index",                                                                                             // MakerGen.cs:255
                                Path= "TestScript.destination.index",                                                                       // MakerGen.cs:256
                                Id = "TestScript.destination.index",                                                                        // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 21. TestScript.destination.profile
                            this.Profile = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Profile",                                                                                           // MakerGen.cs:255
                                Path= "TestScript.destination.profile",                                                                     // MakerGen.cs:256
                                Id = "TestScript.destination.profile",                                                                      // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Index.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Profile.Write(sDef);                                                                                                // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Destination_Elements Elements { get; }                                                                          // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Destination()                                                                                                   // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Destination_Elements();                                                                        // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 22. TestScript.metadata
            public class Type_Metadata : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Metadata_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 23. TestScript.metadata.link
                    public class Type_Link : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Link_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 24. TestScript.metadata.link.url
                            public ElementDefinitionInfo Url;                                                                               // MakerGen.cs:236
                            // 25. TestScript.metadata.link.description
                            public ElementDefinitionInfo Description;                                                                       // MakerGen.cs:236
                            public Type_Link_Elements()                                                                                     // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 24. TestScript.metadata.link.url
                                    this.Url = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Url",                                                                                       // MakerGen.cs:255
                                        Path= "TestScript.metadata.link.url",                                                               // MakerGen.cs:256
                                        Id = "TestScript.metadata.link.url",                                                                // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Uri                                                         // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 25. TestScript.metadata.link.description
                                    this.Description = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Description",                                                                               // MakerGen.cs:255
                                        Path= "TestScript.metadata.link.description",                                                       // MakerGen.cs:256
                                        Id = "TestScript.metadata.link.description",                                                        // MakerGen.cs:257
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
                                Url.Write(sDef);                                                                                            // MakerGen.cs:240
                                Description.Write(sDef);                                                                                    // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Link_Elements Elements { get; }                                                                         // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Link()                                                                                                  // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Link_Elements();                                                                       // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 26. TestScript.metadata.capability
                    public class Type_Capability : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Capability_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 27. TestScript.metadata.capability.required
                            public ElementDefinitionInfo Required;                                                                          // MakerGen.cs:236
                            // 28. TestScript.metadata.capability.validated
                            public ElementDefinitionInfo Validated;                                                                         // MakerGen.cs:236
                            // 29. TestScript.metadata.capability.description
                            public ElementDefinitionInfo Description;                                                                       // MakerGen.cs:236
                            // 30. TestScript.metadata.capability.origin
                            public ElementDefinitionInfo Origin;                                                                            // MakerGen.cs:236
                            // 31. TestScript.metadata.capability.destination
                            public ElementDefinitionInfo Destination;                                                                       // MakerGen.cs:236
                            // 32. TestScript.metadata.capability.link
                            public ElementDefinitionInfo Link;                                                                              // MakerGen.cs:236
                            // 33. TestScript.metadata.capability.capabilities
                            public ElementDefinitionInfo Capabilities;                                                                      // MakerGen.cs:236
                            public Type_Capability_Elements()                                                                               // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 27. TestScript.metadata.capability.required
                                    this.Required = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Required",                                                                                  // MakerGen.cs:255
                                        Path= "TestScript.metadata.capability.required",                                                    // MakerGen.cs:256
                                        Id = "TestScript.metadata.capability.required",                                                     // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
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
                                    // 28. TestScript.metadata.capability.validated
                                    this.Validated = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Validated",                                                                                 // MakerGen.cs:255
                                        Path= "TestScript.metadata.capability.validated",                                                   // MakerGen.cs:256
                                        Id = "TestScript.metadata.capability.validated",                                                    // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
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
                                    // 29. TestScript.metadata.capability.description
                                    this.Description = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Description",                                                                               // MakerGen.cs:255
                                        Path= "TestScript.metadata.capability.description",                                                 // MakerGen.cs:256
                                        Id = "TestScript.metadata.capability.description",                                                  // MakerGen.cs:257
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
                                    // 30. TestScript.metadata.capability.origin
                                    this.Origin = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Origin",                                                                                    // MakerGen.cs:255
                                        Path= "TestScript.metadata.capability.origin",                                                      // MakerGen.cs:256
                                        Id = "TestScript.metadata.capability.origin",                                                       // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 31. TestScript.metadata.capability.destination
                                    this.Destination = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Destination",                                                                               // MakerGen.cs:255
                                        Path= "TestScript.metadata.capability.destination",                                                 // MakerGen.cs:256
                                        Id = "TestScript.metadata.capability.destination",                                                  // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 32. TestScript.metadata.capability.link
                                    this.Link = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Link",                                                                                      // MakerGen.cs:255
                                        Path= "TestScript.metadata.capability.link",                                                        // MakerGen.cs:256
                                        Id = "TestScript.metadata.capability.link",                                                         // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Uri                                                         // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 33. TestScript.metadata.capability.capabilities
                                    this.Capabilities = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Capabilities",                                                                              // MakerGen.cs:255
                                        Path= "TestScript.metadata.capability.capabilities",                                                // MakerGen.cs:256
                                        Id = "TestScript.metadata.capability.capabilities",                                                 // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Canonical                                                   // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                                TargetProfile = new String[]                                                                // MakerGen.cs:302
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/CapabilityStatement"                           // MakerGen.cs:302
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Required.Write(sDef);                                                                                       // MakerGen.cs:240
                                Validated.Write(sDef);                                                                                      // MakerGen.cs:240
                                Description.Write(sDef);                                                                                    // MakerGen.cs:240
                                Origin.Write(sDef);                                                                                         // MakerGen.cs:240
                                Destination.Write(sDef);                                                                                    // MakerGen.cs:240
                                Link.Write(sDef);                                                                                           // MakerGen.cs:240
                                Capabilities.Write(sDef);                                                                                   // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Capability_Elements Elements { get; }                                                                   // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Capability()                                                                                            // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Capability_Elements();                                                                 // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    public Type_Metadata_Elements()                                                                                         // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Metadata_Elements Elements { get; }                                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Metadata()                                                                                                      // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Metadata_Elements();                                                                           // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 34. TestScript.fixture
            public class Type_Fixture : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Fixture_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 35. TestScript.fixture.autocreate
                    public ElementDefinitionInfo Autocreate;                                                                                // MakerGen.cs:236
                    // 36. TestScript.fixture.autodelete
                    public ElementDefinitionInfo Autodelete;                                                                                // MakerGen.cs:236
                    // 37. TestScript.fixture.resource
                    public ElementDefinitionInfo Resource;                                                                                  // MakerGen.cs:236
                    public Type_Fixture_Elements()                                                                                          // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 35. TestScript.fixture.autocreate
                            this.Autocreate = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Autocreate",                                                                                        // MakerGen.cs:255
                                Path= "TestScript.fixture.autocreate",                                                                      // MakerGen.cs:256
                                Id = "TestScript.fixture.autocreate",                                                                       // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 36. TestScript.fixture.autodelete
                            this.Autodelete = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Autodelete",                                                                                        // MakerGen.cs:255
                                Path= "TestScript.fixture.autodelete",                                                                      // MakerGen.cs:256
                                Id = "TestScript.fixture.autodelete",                                                                       // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 37. TestScript.fixture.resource
                            this.Resource = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Resource",                                                                                          // MakerGen.cs:255
                                Path= "TestScript.fixture.resource",                                                                        // MakerGen.cs:256
                                Id = "TestScript.fixture.resource",                                                                         // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        Autocreate.Write(sDef);                                                                                             // MakerGen.cs:240
                        Autodelete.Write(sDef);                                                                                             // MakerGen.cs:240
                        Resource.Write(sDef);                                                                                               // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Fixture_Elements Elements { get; }                                                                              // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Fixture()                                                                                                       // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Fixture_Elements();                                                                            // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 39. TestScript.variable
            public class Type_Variable : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Variable_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 40. TestScript.variable.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:236
                    // 41. TestScript.variable.defaultValue
                    public ElementDefinitionInfo DefaultValue;                                                                              // MakerGen.cs:236
                    // 42. TestScript.variable.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:236
                    // 43. TestScript.variable.expression
                    public ElementDefinitionInfo Expression;                                                                                // MakerGen.cs:236
                    // 44. TestScript.variable.headerField
                    public ElementDefinitionInfo HeaderField;                                                                               // MakerGen.cs:236
                    // 45. TestScript.variable.hint
                    public ElementDefinitionInfo Hint;                                                                                      // MakerGen.cs:236
                    // 46. TestScript.variable.path
                    public ElementDefinitionInfo Path;                                                                                      // MakerGen.cs:236
                    // 47. TestScript.variable.sourceId
                    public ElementDefinitionInfo SourceId;                                                                                  // MakerGen.cs:236
                    public Type_Variable_Elements()                                                                                         // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 40. TestScript.variable.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Name",                                                                                              // MakerGen.cs:255
                                Path= "TestScript.variable.name",                                                                           // MakerGen.cs:256
                                Id = "TestScript.variable.name",                                                                            // MakerGen.cs:257
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
                            // 41. TestScript.variable.defaultValue
                            this.DefaultValue = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "DefaultValue",                                                                                      // MakerGen.cs:255
                                Path= "TestScript.variable.defaultValue",                                                                   // MakerGen.cs:256
                                Id = "TestScript.variable.defaultValue",                                                                    // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 42. TestScript.variable.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Description",                                                                                       // MakerGen.cs:255
                                Path= "TestScript.variable.description",                                                                    // MakerGen.cs:256
                                Id = "TestScript.variable.description",                                                                     // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 43. TestScript.variable.expression
                            this.Expression = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Expression",                                                                                        // MakerGen.cs:255
                                Path= "TestScript.variable.expression",                                                                     // MakerGen.cs:256
                                Id = "TestScript.variable.expression",                                                                      // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 44. TestScript.variable.headerField
                            this.HeaderField = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "HeaderField",                                                                                       // MakerGen.cs:255
                                Path= "TestScript.variable.headerField",                                                                    // MakerGen.cs:256
                                Id = "TestScript.variable.headerField",                                                                     // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 45. TestScript.variable.hint
                            this.Hint = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Hint",                                                                                              // MakerGen.cs:255
                                Path= "TestScript.variable.hint",                                                                           // MakerGen.cs:256
                                Id = "TestScript.variable.hint",                                                                            // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 46. TestScript.variable.path
                            this.Path = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Path",                                                                                              // MakerGen.cs:255
                                Path= "TestScript.variable.path",                                                                           // MakerGen.cs:256
                                Id = "TestScript.variable.path",                                                                            // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 47. TestScript.variable.sourceId
                            this.SourceId = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "SourceId",                                                                                          // MakerGen.cs:255
                                Path= "TestScript.variable.sourceId",                                                                       // MakerGen.cs:256
                                Id = "TestScript.variable.sourceId",                                                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:299
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
                        DefaultValue.Write(sDef);                                                                                           // MakerGen.cs:240
                        Description.Write(sDef);                                                                                            // MakerGen.cs:240
                        Expression.Write(sDef);                                                                                             // MakerGen.cs:240
                        HeaderField.Write(sDef);                                                                                            // MakerGen.cs:240
                        Hint.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Path.Write(sDef);                                                                                                   // MakerGen.cs:240
                        SourceId.Write(sDef);                                                                                               // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Variable_Elements Elements { get; }                                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Variable()                                                                                                      // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Variable_Elements();                                                                           // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 48. TestScript.setup
            public class Type_Setup : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Setup_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 49. TestScript.setup.action
                    public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Action_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 50. TestScript.setup.action.operation
                            public class Type_Operation : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:385
                            {                                                                                                               // MakerGen.cs:386
                                public class Type_Operation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                          // MakerGen.cs:387
                                {                                                                                                           // MakerGen.cs:388
                                    // 62. TestScript.setup.action.operation.requestHeader
                                    public class Type_RequestHeader : FhirKhit.Maker.Common.Complex.ComplexBase                             // MakerGen.cs:385
                                    {                                                                                                       // MakerGen.cs:386
                                        public class Type_RequestHeader_Elements : FhirKhit.Maker.Common.Resource.ElementsBase              // MakerGen.cs:387
                                        {                                                                                                   // MakerGen.cs:388
                                            // 63. TestScript.setup.action.operation.requestHeader.field
                                            public ElementDefinitionInfo Field;                                                             // MakerGen.cs:236
                                            // 64. TestScript.setup.action.operation.requestHeader.value
                                            public ElementDefinitionInfo Value;                                                             // MakerGen.cs:236
                                            public Type_RequestHeader_Elements()                                                            // MakerGen.cs:409
                                            {                                                                                               // MakerGen.cs:410
                                                {                                                                                           // MakerGen.cs:251
                                                    // 63. TestScript.setup.action.operation.requestHeader.field
                                                    this.Field = new ElementDefinitionInfo                                                  // MakerGen.cs:253
                                                    {                                                                                       // MakerGen.cs:254
                                                        Name = "Field",                                                                     // MakerGen.cs:255
                                                        Path= "TestScript.setup.action.operation.requestHeader.field",                      // MakerGen.cs:256
                                                        Id = "TestScript.setup.action.operation.requestHeader.field",                       // MakerGen.cs:257
                                                        Min = 1,                                                                            // MakerGen.cs:258
                                                        Max = 1,                                                                            // MakerGen.cs:259
                                                        Types = new BaseType[]                                                              // MakerGen.cs:260
                                                        {                                                                                   // MakerGen.cs:261
                                                            new FhirKhit.Maker.Common.Primitive.String                                      // MakerGen.cs:299
                                                            {                                                                               // MakerGen.cs:300
                                                            }                                                                               // MakerGen.cs:303
                                                        }                                                                                   // MakerGen.cs:263
                                                    };                                                                                      // MakerGen.cs:264
                                                }                                                                                           // MakerGen.cs:366
                                                {                                                                                           // MakerGen.cs:251
                                                    // 64. TestScript.setup.action.operation.requestHeader.value
                                                    this.Value = new ElementDefinitionInfo                                                  // MakerGen.cs:253
                                                    {                                                                                       // MakerGen.cs:254
                                                        Name = "Value",                                                                     // MakerGen.cs:255
                                                        Path= "TestScript.setup.action.operation.requestHeader.value",                      // MakerGen.cs:256
                                                        Id = "TestScript.setup.action.operation.requestHeader.value",                       // MakerGen.cs:257
                                                        Min = 1,                                                                            // MakerGen.cs:258
                                                        Max = 1,                                                                            // MakerGen.cs:259
                                                        Types = new BaseType[]                                                              // MakerGen.cs:260
                                                        {                                                                                   // MakerGen.cs:261
                                                            new FhirKhit.Maker.Common.Primitive.String                                      // MakerGen.cs:299
                                                            {                                                                               // MakerGen.cs:300
                                                            }                                                                               // MakerGen.cs:303
                                                        }                                                                                   // MakerGen.cs:263
                                                    };                                                                                      // MakerGen.cs:264
                                                }                                                                                           // MakerGen.cs:366
                                            }                                                                                               // MakerGen.cs:429
                                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                             // MakerGen.cs:414
                                            {                                                                                               // MakerGen.cs:415
                                                base.Write(sDef);                                                                           // MakerGen.cs:416
                                                Field.Write(sDef);                                                                          // MakerGen.cs:240
                                                Value.Write(sDef);                                                                          // MakerGen.cs:240
                                            }                                                                                               // MakerGen.cs:433
                                        }                                                                                                   // MakerGen.cs:393
                                        public Type_RequestHeader_Elements Elements { get; }                                                // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                                        public Type_RequestHeader()                                                                         // MakerGen.cs:396
                                        {                                                                                                   // MakerGen.cs:397
                                            this.Elements = new Type_RequestHeader_Elements();                                              // MakerGen.cs:398
                                        }                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                 // MakerGen.cs:401
                                        {                                                                                                   // MakerGen.cs:402
                                            this.Elements.Write(sDef);                                                                      // MakerGen.cs:403
                                        }                                                                                                   // MakerGen.cs:404
                                    }                                                                                                       // MakerGen.cs:405
                                    // 51. TestScript.setup.action.operation.type
                                    public ElementDefinitionInfo Type;                                                                      // MakerGen.cs:236
                                    // 52. TestScript.setup.action.operation.resource
                                    public ElementDefinitionInfo Resource;                                                                  // MakerGen.cs:236
                                    // 53. TestScript.setup.action.operation.label
                                    public ElementDefinitionInfo Label;                                                                     // MakerGen.cs:236
                                    // 54. TestScript.setup.action.operation.description
                                    public ElementDefinitionInfo Description;                                                               // MakerGen.cs:236
                                    // 55. TestScript.setup.action.operation.accept
                                    public ElementDefinitionInfo Accept;                                                                    // MakerGen.cs:236
                                    // 56. TestScript.setup.action.operation.contentType
                                    public ElementDefinitionInfo ContentType;                                                               // MakerGen.cs:236
                                    // 57. TestScript.setup.action.operation.destination
                                    public ElementDefinitionInfo Destination;                                                               // MakerGen.cs:236
                                    // 58. TestScript.setup.action.operation.encodeRequestUrl
                                    public ElementDefinitionInfo EncodeRequestUrl;                                                          // MakerGen.cs:236
                                    // 59. TestScript.setup.action.operation.method
                                    public ElementDefinitionInfo Method;                                                                    // MakerGen.cs:236
                                    // 60. TestScript.setup.action.operation.origin
                                    public ElementDefinitionInfo Origin;                                                                    // MakerGen.cs:236
                                    // 61. TestScript.setup.action.operation.params
                                    public ElementDefinitionInfo Params;                                                                    // MakerGen.cs:236
                                    // 65. TestScript.setup.action.operation.requestId
                                    public ElementDefinitionInfo RequestId;                                                                 // MakerGen.cs:236
                                    // 66. TestScript.setup.action.operation.responseId
                                    public ElementDefinitionInfo ResponseId;                                                                // MakerGen.cs:236
                                    // 67. TestScript.setup.action.operation.sourceId
                                    public ElementDefinitionInfo SourceId;                                                                  // MakerGen.cs:236
                                    // 68. TestScript.setup.action.operation.targetId
                                    public ElementDefinitionInfo TargetId;                                                                  // MakerGen.cs:236
                                    // 69. TestScript.setup.action.operation.url
                                    public ElementDefinitionInfo Url;                                                                       // MakerGen.cs:236
                                    public Type_Operation_Elements()                                                                        // MakerGen.cs:409
                                    {                                                                                                       // MakerGen.cs:410
                                        {                                                                                                   // MakerGen.cs:251
                                            // 51. TestScript.setup.action.operation.type
                                            this.Type = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Type",                                                                              // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.type",                                             // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.type",                                              // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Complex.Coding                                                // MakerGen.cs:314
                                                    {                                                                                       // MakerGen.cs:315
                                                    }                                                                                       // MakerGen.cs:318
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 52. TestScript.setup.action.operation.resource
                                            this.Resource = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Resource",                                                                          // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.resource",                                         // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.resource",                                          // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
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
                                            // 53. TestScript.setup.action.operation.label
                                            this.Label = new ElementDefinitionInfo                                                          // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Label",                                                                             // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.label",                                            // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.label",                                             // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 54. TestScript.setup.action.operation.description
                                            this.Description = new ElementDefinitionInfo                                                    // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Description",                                                                       // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.description",                                      // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.description",                                       // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 55. TestScript.setup.action.operation.accept
                                            this.Accept = new ElementDefinitionInfo                                                         // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Accept",                                                                            // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.accept",                                           // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.accept",                                            // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
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
                                            // 56. TestScript.setup.action.operation.contentType
                                            this.ContentType = new ElementDefinitionInfo                                                    // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "ContentType",                                                                       // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.contentType",                                      // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.contentType",                                       // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
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
                                            // 57. TestScript.setup.action.operation.destination
                                            this.Destination = new ElementDefinitionInfo                                                    // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Destination",                                                                       // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.destination",                                      // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.destination",                                       // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Integer                                             // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 58. TestScript.setup.action.operation.encodeRequestUrl
                                            this.EncodeRequestUrl = new ElementDefinitionInfo                                               // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "EncodeRequestUrl",                                                                  // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.encodeRequestUrl",                                 // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.encodeRequestUrl",                                  // MakerGen.cs:257
                                                Min = 1,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Boolean                                             // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 59. TestScript.setup.action.operation.method
                                            this.Method = new ElementDefinitionInfo                                                         // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Method",                                                                            // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.method",                                           // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.method",                                            // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
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
                                            // 60. TestScript.setup.action.operation.origin
                                            this.Origin = new ElementDefinitionInfo                                                         // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Origin",                                                                            // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.origin",                                           // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.origin",                                            // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Integer                                             // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 61. TestScript.setup.action.operation.params
                                            this.Params = new ElementDefinitionInfo                                                         // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Params",                                                                            // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.params",                                           // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.params",                                            // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 65. TestScript.setup.action.operation.requestId
                                            this.RequestId = new ElementDefinitionInfo                                                      // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "RequestId",                                                                         // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.requestId",                                        // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.requestId",                                         // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Id                                                  // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 66. TestScript.setup.action.operation.responseId
                                            this.ResponseId = new ElementDefinitionInfo                                                     // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "ResponseId",                                                                        // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.responseId",                                       // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.responseId",                                        // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Id                                                  // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 67. TestScript.setup.action.operation.sourceId
                                            this.SourceId = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "SourceId",                                                                          // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.sourceId",                                         // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.sourceId",                                          // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Id                                                  // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 68. TestScript.setup.action.operation.targetId
                                            this.TargetId = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "TargetId",                                                                          // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.targetId",                                         // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.targetId",                                          // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Id                                                  // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 69. TestScript.setup.action.operation.url
                                            this.Url = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Url",                                                                               // MakerGen.cs:255
                                                Path= "TestScript.setup.action.operation.url",                                              // MakerGen.cs:256
                                                Id = "TestScript.setup.action.operation.url",                                               // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                    }                                                                                                       // MakerGen.cs:429
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:414
                                    {                                                                                                       // MakerGen.cs:415
                                        base.Write(sDef);                                                                                   // MakerGen.cs:416
                                        Type.Write(sDef);                                                                                   // MakerGen.cs:240
                                        Resource.Write(sDef);                                                                               // MakerGen.cs:240
                                        Label.Write(sDef);                                                                                  // MakerGen.cs:240
                                        Description.Write(sDef);                                                                            // MakerGen.cs:240
                                        Accept.Write(sDef);                                                                                 // MakerGen.cs:240
                                        ContentType.Write(sDef);                                                                            // MakerGen.cs:240
                                        Destination.Write(sDef);                                                                            // MakerGen.cs:240
                                        EncodeRequestUrl.Write(sDef);                                                                       // MakerGen.cs:240
                                        Method.Write(sDef);                                                                                 // MakerGen.cs:240
                                        Origin.Write(sDef);                                                                                 // MakerGen.cs:240
                                        Params.Write(sDef);                                                                                 // MakerGen.cs:240
                                        RequestId.Write(sDef);                                                                              // MakerGen.cs:240
                                        ResponseId.Write(sDef);                                                                             // MakerGen.cs:240
                                        SourceId.Write(sDef);                                                                               // MakerGen.cs:240
                                        TargetId.Write(sDef);                                                                               // MakerGen.cs:240
                                        Url.Write(sDef);                                                                                    // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:433
                                }                                                                                                           // MakerGen.cs:393
                                public Type_Operation_Elements Elements { get; }                                                            // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                                public Type_Operation()                                                                                     // MakerGen.cs:396
                                {                                                                                                           // MakerGen.cs:397
                                    this.Elements = new Type_Operation_Elements();                                                          // MakerGen.cs:398
                                }                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:401
                                {                                                                                                           // MakerGen.cs:402
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:403
                                }                                                                                                           // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                            // 70. TestScript.setup.action.assert
                            public class Type_Assert : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:385
                            {                                                                                                               // MakerGen.cs:386
                                public class Type_Assert_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                             // MakerGen.cs:387
                                {                                                                                                           // MakerGen.cs:388
                                    // 71. TestScript.setup.action.assert.label
                                    public ElementDefinitionInfo Label;                                                                     // MakerGen.cs:236
                                    // 72. TestScript.setup.action.assert.description
                                    public ElementDefinitionInfo Description;                                                               // MakerGen.cs:236
                                    // 73. TestScript.setup.action.assert.direction
                                    public ElementDefinitionInfo Direction;                                                                 // MakerGen.cs:236
                                    // 74. TestScript.setup.action.assert.compareToSourceId
                                    public ElementDefinitionInfo CompareToSourceId;                                                         // MakerGen.cs:236
                                    // 75. TestScript.setup.action.assert.compareToSourceExpression
                                    public ElementDefinitionInfo CompareToSourceExpression;                                                 // MakerGen.cs:236
                                    // 76. TestScript.setup.action.assert.compareToSourcePath
                                    public ElementDefinitionInfo CompareToSourcePath;                                                       // MakerGen.cs:236
                                    // 77. TestScript.setup.action.assert.contentType
                                    public ElementDefinitionInfo ContentType;                                                               // MakerGen.cs:236
                                    // 78. TestScript.setup.action.assert.expression
                                    public ElementDefinitionInfo Expression;                                                                // MakerGen.cs:236
                                    // 79. TestScript.setup.action.assert.headerField
                                    public ElementDefinitionInfo HeaderField;                                                               // MakerGen.cs:236
                                    // 80. TestScript.setup.action.assert.minimumId
                                    public ElementDefinitionInfo MinimumId;                                                                 // MakerGen.cs:236
                                    // 81. TestScript.setup.action.assert.navigationLinks
                                    public ElementDefinitionInfo NavigationLinks;                                                           // MakerGen.cs:236
                                    // 82. TestScript.setup.action.assert.operator
                                    public ElementDefinitionInfo Operator;                                                                  // MakerGen.cs:236
                                    // 83. TestScript.setup.action.assert.path
                                    public ElementDefinitionInfo Path;                                                                      // MakerGen.cs:236
                                    // 84. TestScript.setup.action.assert.requestMethod
                                    public ElementDefinitionInfo RequestMethod;                                                             // MakerGen.cs:236
                                    // 85. TestScript.setup.action.assert.requestURL
                                    public ElementDefinitionInfo RequestURL;                                                                // MakerGen.cs:236
                                    // 86. TestScript.setup.action.assert.resource
                                    public ElementDefinitionInfo Resource;                                                                  // MakerGen.cs:236
                                    // 87. TestScript.setup.action.assert.response
                                    public ElementDefinitionInfo Response;                                                                  // MakerGen.cs:236
                                    // 88. TestScript.setup.action.assert.responseCode
                                    public ElementDefinitionInfo ResponseCode;                                                              // MakerGen.cs:236
                                    // 89. TestScript.setup.action.assert.sourceId
                                    public ElementDefinitionInfo SourceId;                                                                  // MakerGen.cs:236
                                    // 90. TestScript.setup.action.assert.validateProfileId
                                    public ElementDefinitionInfo ValidateProfileId;                                                         // MakerGen.cs:236
                                    // 91. TestScript.setup.action.assert.value
                                    public ElementDefinitionInfo Value;                                                                     // MakerGen.cs:236
                                    // 92. TestScript.setup.action.assert.warningOnly
                                    public ElementDefinitionInfo WarningOnly;                                                               // MakerGen.cs:236
                                    public Type_Assert_Elements()                                                                           // MakerGen.cs:409
                                    {                                                                                                       // MakerGen.cs:410
                                        {                                                                                                   // MakerGen.cs:251
                                            // 71. TestScript.setup.action.assert.label
                                            this.Label = new ElementDefinitionInfo                                                          // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Label",                                                                             // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.label",                                               // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.label",                                                // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 72. TestScript.setup.action.assert.description
                                            this.Description = new ElementDefinitionInfo                                                    // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Description",                                                                       // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.description",                                         // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.description",                                          // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 73. TestScript.setup.action.assert.direction
                                            this.Direction = new ElementDefinitionInfo                                                      // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Direction",                                                                         // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.direction",                                           // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.direction",                                            // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
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
                                            // 74. TestScript.setup.action.assert.compareToSourceId
                                            this.CompareToSourceId = new ElementDefinitionInfo                                              // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "CompareToSourceId",                                                                 // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.compareToSourceId",                                   // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.compareToSourceId",                                    // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 75. TestScript.setup.action.assert.compareToSourceExpression
                                            this.CompareToSourceExpression = new ElementDefinitionInfo                                      // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "CompareToSourceExpression",                                                         // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.compareToSourceExpression",                           // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.compareToSourceExpression",                            // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 76. TestScript.setup.action.assert.compareToSourcePath
                                            this.CompareToSourcePath = new ElementDefinitionInfo                                            // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "CompareToSourcePath",                                                               // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.compareToSourcePath",                                 // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.compareToSourcePath",                                  // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 77. TestScript.setup.action.assert.contentType
                                            this.ContentType = new ElementDefinitionInfo                                                    // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "ContentType",                                                                       // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.contentType",                                         // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.contentType",                                          // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
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
                                            // 78. TestScript.setup.action.assert.expression
                                            this.Expression = new ElementDefinitionInfo                                                     // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Expression",                                                                        // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.expression",                                          // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.expression",                                           // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 79. TestScript.setup.action.assert.headerField
                                            this.HeaderField = new ElementDefinitionInfo                                                    // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "HeaderField",                                                                       // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.headerField",                                         // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.headerField",                                          // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 80. TestScript.setup.action.assert.minimumId
                                            this.MinimumId = new ElementDefinitionInfo                                                      // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "MinimumId",                                                                         // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.minimumId",                                           // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.minimumId",                                            // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 81. TestScript.setup.action.assert.navigationLinks
                                            this.NavigationLinks = new ElementDefinitionInfo                                                // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "NavigationLinks",                                                                   // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.navigationLinks",                                     // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.navigationLinks",                                      // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Boolean                                             // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 82. TestScript.setup.action.assert.operator
                                            this.Operator = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Operator",                                                                          // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.operator",                                            // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.operator",                                             // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
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
                                            // 83. TestScript.setup.action.assert.path
                                            this.Path = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Path",                                                                              // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.path",                                                // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.path",                                                 // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 84. TestScript.setup.action.assert.requestMethod
                                            this.RequestMethod = new ElementDefinitionInfo                                                  // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "RequestMethod",                                                                     // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.requestMethod",                                       // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.requestMethod",                                        // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
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
                                            // 85. TestScript.setup.action.assert.requestURL
                                            this.RequestURL = new ElementDefinitionInfo                                                     // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "RequestURL",                                                                        // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.requestURL",                                          // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.requestURL",                                           // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 86. TestScript.setup.action.assert.resource
                                            this.Resource = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Resource",                                                                          // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.resource",                                            // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.resource",                                             // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
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
                                            // 87. TestScript.setup.action.assert.response
                                            this.Response = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Response",                                                                          // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.response",                                            // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.response",                                             // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
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
                                            // 88. TestScript.setup.action.assert.responseCode
                                            this.ResponseCode = new ElementDefinitionInfo                                                   // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "ResponseCode",                                                                      // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.responseCode",                                        // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.responseCode",                                         // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 89. TestScript.setup.action.assert.sourceId
                                            this.SourceId = new ElementDefinitionInfo                                                       // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "SourceId",                                                                          // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.sourceId",                                            // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.sourceId",                                             // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Id                                                  // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 90. TestScript.setup.action.assert.validateProfileId
                                            this.ValidateProfileId = new ElementDefinitionInfo                                              // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "ValidateProfileId",                                                                 // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.validateProfileId",                                   // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.validateProfileId",                                    // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Id                                                  // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 91. TestScript.setup.action.assert.value
                                            this.Value = new ElementDefinitionInfo                                                          // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "Value",                                                                             // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.value",                                               // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.value",                                                // MakerGen.cs:257
                                                Min = 0,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                        {                                                                                                   // MakerGen.cs:251
                                            // 92. TestScript.setup.action.assert.warningOnly
                                            this.WarningOnly = new ElementDefinitionInfo                                                    // MakerGen.cs:253
                                            {                                                                                               // MakerGen.cs:254
                                                Name = "WarningOnly",                                                                       // MakerGen.cs:255
                                                Path= "TestScript.setup.action.assert.warningOnly",                                         // MakerGen.cs:256
                                                Id = "TestScript.setup.action.assert.warningOnly",                                          // MakerGen.cs:257
                                                Min = 1,                                                                                    // MakerGen.cs:258
                                                Max = 1,                                                                                    // MakerGen.cs:259
                                                Types = new BaseType[]                                                                      // MakerGen.cs:260
                                                {                                                                                           // MakerGen.cs:261
                                                    new FhirKhit.Maker.Common.Primitive.Boolean                                             // MakerGen.cs:299
                                                    {                                                                                       // MakerGen.cs:300
                                                    }                                                                                       // MakerGen.cs:303
                                                }                                                                                           // MakerGen.cs:263
                                            };                                                                                              // MakerGen.cs:264
                                        }                                                                                                   // MakerGen.cs:366
                                    }                                                                                                       // MakerGen.cs:429
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:414
                                    {                                                                                                       // MakerGen.cs:415
                                        base.Write(sDef);                                                                                   // MakerGen.cs:416
                                        Label.Write(sDef);                                                                                  // MakerGen.cs:240
                                        Description.Write(sDef);                                                                            // MakerGen.cs:240
                                        Direction.Write(sDef);                                                                              // MakerGen.cs:240
                                        CompareToSourceId.Write(sDef);                                                                      // MakerGen.cs:240
                                        CompareToSourceExpression.Write(sDef);                                                              // MakerGen.cs:240
                                        CompareToSourcePath.Write(sDef);                                                                    // MakerGen.cs:240
                                        ContentType.Write(sDef);                                                                            // MakerGen.cs:240
                                        Expression.Write(sDef);                                                                             // MakerGen.cs:240
                                        HeaderField.Write(sDef);                                                                            // MakerGen.cs:240
                                        MinimumId.Write(sDef);                                                                              // MakerGen.cs:240
                                        NavigationLinks.Write(sDef);                                                                        // MakerGen.cs:240
                                        Operator.Write(sDef);                                                                               // MakerGen.cs:240
                                        Path.Write(sDef);                                                                                   // MakerGen.cs:240
                                        RequestMethod.Write(sDef);                                                                          // MakerGen.cs:240
                                        RequestURL.Write(sDef);                                                                             // MakerGen.cs:240
                                        Resource.Write(sDef);                                                                               // MakerGen.cs:240
                                        Response.Write(sDef);                                                                               // MakerGen.cs:240
                                        ResponseCode.Write(sDef);                                                                           // MakerGen.cs:240
                                        SourceId.Write(sDef);                                                                               // MakerGen.cs:240
                                        ValidateProfileId.Write(sDef);                                                                      // MakerGen.cs:240
                                        Value.Write(sDef);                                                                                  // MakerGen.cs:240
                                        WarningOnly.Write(sDef);                                                                            // MakerGen.cs:240
                                    }                                                                                                       // MakerGen.cs:433
                                }                                                                                                           // MakerGen.cs:393
                                public Type_Assert_Elements Elements { get; }                                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                                public Type_Assert()                                                                                        // MakerGen.cs:396
                                {                                                                                                           // MakerGen.cs:397
                                    this.Elements = new Type_Assert_Elements();                                                             // MakerGen.cs:398
                                }                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:401
                                {                                                                                                           // MakerGen.cs:402
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:403
                                }                                                                                                           // MakerGen.cs:404
                            }                                                                                                               // MakerGen.cs:405
                            public Type_Action_Elements()                                                                                   // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Action_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Action()                                                                                                // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Action_Elements();                                                                     // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    public Type_Setup_Elements()                                                                                            // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Setup_Elements Elements { get; }                                                                                // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Setup()                                                                                                         // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Setup_Elements();                                                                              // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 93. TestScript.test
            public class Type_Test : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Test_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 96. TestScript.test.action
                    public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Action_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 97. TestScript.test.action.operation
                            public ElementDefinitionInfo Operation;                                                                         // MakerGen.cs:236
                            // 98. TestScript.test.action.assert
                            public ElementDefinitionInfo Assert;                                                                            // MakerGen.cs:236
                            public Type_Action_Elements()                                                                                   // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 97. TestScript.test.action.operation
                                    this.Operation = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Operation",                                                                                 // MakerGen.cs:255
                                        Path= "TestScript.test.action.operation",                                                           // MakerGen.cs:256
                                        Id = "TestScript.test.action.operation",                                                            // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 98. TestScript.test.action.assert
                                    this.Assert = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Assert",                                                                                    // MakerGen.cs:255
                                        Path= "TestScript.test.action.assert",                                                              // MakerGen.cs:256
                                        Id = "TestScript.test.action.assert",                                                               // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Operation.Write(sDef);                                                                                      // MakerGen.cs:240
                                Assert.Write(sDef);                                                                                         // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Action_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Action()                                                                                                // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Action_Elements();                                                                     // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 94. TestScript.test.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:236
                    // 95. TestScript.test.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:236
                    public Type_Test_Elements()                                                                                             // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 94. TestScript.test.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Name",                                                                                              // MakerGen.cs:255
                                Path= "TestScript.test.name",                                                                               // MakerGen.cs:256
                                Id = "TestScript.test.name",                                                                                // MakerGen.cs:257
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
                        {                                                                                                                   // MakerGen.cs:251
                            // 95. TestScript.test.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Description",                                                                                       // MakerGen.cs:255
                                Path= "TestScript.test.description",                                                                        // MakerGen.cs:256
                                Id = "TestScript.test.description",                                                                         // MakerGen.cs:257
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
                        Description.Write(sDef);                                                                                            // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Test_Elements Elements { get; }                                                                                 // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Test()                                                                                                          // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Test_Elements();                                                                               // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 99. TestScript.teardown
            public class Type_Teardown : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Teardown_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 100. TestScript.teardown.action
                    public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Action_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 101. TestScript.teardown.action.operation
                            public ElementDefinitionInfo Operation;                                                                         // MakerGen.cs:236
                            public Type_Action_Elements()                                                                                   // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 101. TestScript.teardown.action.operation
                                    this.Operation = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Operation",                                                                                 // MakerGen.cs:255
                                        Path= "TestScript.teardown.action.operation",                                                       // MakerGen.cs:256
                                        Id = "TestScript.teardown.action.operation",                                                        // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Operation.Write(sDef);                                                                                      // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Action_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Action()                                                                                                // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Action_Elements();                                                                     // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    public Type_Teardown_Elements()                                                                                         // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Teardown_Elements Elements { get; }                                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Teardown()                                                                                                      // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Teardown_Elements();                                                                           // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. TestScript.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:236
            // 2. TestScript.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 3. TestScript.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:236
            // 4. TestScript.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:236
            // 5. TestScript.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:236
            // 6. TestScript.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 7. TestScript.experimental
            public ElementDefinitionInfo Experimental;                                                                                      // MakerGen.cs:236
            // 8. TestScript.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:236
            // 9. TestScript.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:236
            // 10. TestScript.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:236
            // 11. TestScript.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:236
            // 12. TestScript.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:236
            // 13. TestScript.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:236
            // 14. TestScript.purpose
            public ElementDefinitionInfo Purpose;                                                                                           // MakerGen.cs:236
            // 15. TestScript.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:236
            // 38. TestScript.profile
            public ElementDefinitionInfo Profile;                                                                                           // MakerGen.cs:236
            public TestScript_Elements()                                                                                                    // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. TestScript.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Url",                                                                                                       // MakerGen.cs:255
                        Path= "TestScript.url",                                                                                             // MakerGen.cs:256
                        Id = "TestScript.url",                                                                                              // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
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
                    // 2. TestScript.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "TestScript.identifier",                                                                                      // MakerGen.cs:256
                        Id = "TestScript.identifier",                                                                                       // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. TestScript.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Version",                                                                                                   // MakerGen.cs:255
                        Path= "TestScript.version",                                                                                         // MakerGen.cs:256
                        Id = "TestScript.version",                                                                                          // MakerGen.cs:257
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
                    // 4. TestScript.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Name",                                                                                                      // MakerGen.cs:255
                        Path= "TestScript.name",                                                                                            // MakerGen.cs:256
                        Id = "TestScript.name",                                                                                             // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
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
                    // 5. TestScript.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Title",                                                                                                     // MakerGen.cs:255
                        Path= "TestScript.title",                                                                                           // MakerGen.cs:256
                        Id = "TestScript.title",                                                                                            // MakerGen.cs:257
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
                    // 6. TestScript.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "TestScript.status",                                                                                          // MakerGen.cs:256
                        Id = "TestScript.status",                                                                                           // MakerGen.cs:257
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
                    // 7. TestScript.experimental
                    this.Experimental = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Experimental",                                                                                              // MakerGen.cs:255
                        Path= "TestScript.experimental",                                                                                    // MakerGen.cs:256
                        Id = "TestScript.experimental",                                                                                     // MakerGen.cs:257
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
                    // 8. TestScript.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Date",                                                                                                      // MakerGen.cs:255
                        Path= "TestScript.date",                                                                                            // MakerGen.cs:256
                        Id = "TestScript.date",                                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
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
                    // 9. TestScript.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Publisher",                                                                                                 // MakerGen.cs:255
                        Path= "TestScript.publisher",                                                                                       // MakerGen.cs:256
                        Id = "TestScript.publisher",                                                                                        // MakerGen.cs:257
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
                    // 10. TestScript.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Contact",                                                                                                   // MakerGen.cs:255
                        Path= "TestScript.contact",                                                                                         // MakerGen.cs:256
                        Id = "TestScript.contact",                                                                                          // MakerGen.cs:257
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
                    // 11. TestScript.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Description",                                                                                               // MakerGen.cs:255
                        Path= "TestScript.description",                                                                                     // MakerGen.cs:256
                        Id = "TestScript.description",                                                                                      // MakerGen.cs:257
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
                    // 12. TestScript.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "UseContext",                                                                                                // MakerGen.cs:255
                        Path= "TestScript.useContext",                                                                                      // MakerGen.cs:256
                        Id = "TestScript.useContext",                                                                                       // MakerGen.cs:257
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
                    // 13. TestScript.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:255
                        Path= "TestScript.jurisdiction",                                                                                    // MakerGen.cs:256
                        Id = "TestScript.jurisdiction",                                                                                     // MakerGen.cs:257
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
                    // 14. TestScript.purpose
                    this.Purpose = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Purpose",                                                                                                   // MakerGen.cs:255
                        Path= "TestScript.purpose",                                                                                         // MakerGen.cs:256
                        Id = "TestScript.purpose",                                                                                          // MakerGen.cs:257
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
                    // 15. TestScript.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Copyright",                                                                                                 // MakerGen.cs:255
                        Path= "TestScript.copyright",                                                                                       // MakerGen.cs:256
                        Id = "TestScript.copyright",                                                                                        // MakerGen.cs:257
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
                    // 38. TestScript.profile
                    this.Profile = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Profile",                                                                                                   // MakerGen.cs:255
                        Path= "TestScript.profile",                                                                                         // MakerGen.cs:256
                        Id = "TestScript.profile",                                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Url.Write(sDef);                                                                                                            // MakerGen.cs:240
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
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
                Profile.Write(sDef);                                                                                                        // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public TestScript_Elements Elements { get; }                                                                                        // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public TestScript()                                                                                                                 // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new TestScript_Elements();                                                                                      // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
