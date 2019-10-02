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
    #endregion
    /// <summary>
    /// Fhir resource 'TestScript'
    /// </summary>
    // 0. TestScript
    public partial class Resource_TestScript : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 16. TestScript.origin
        public partial class Type_Origin : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 17. TestScript.origin.index
            public ElementDefinitionInfo Element_Index;
            // 18. TestScript.origin.profile
            public ElementDefinitionInfo Element_Profile;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TestScript.origin",
                    ElementId = "TestScript.origin"
                });
                Element_Index.Write(sDef);
                Element_Profile.Write(sDef);
            }
            
            public Type_Origin()
            {
                {
                    // 17. TestScript.origin.index
                    this.Element_Index = new ElementDefinitionInfo
                    {
                        Name = "Element_Index",
                        Path= "TestScript.origin.index",
                        Id = "TestScript.origin.index",
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
                    // 18. TestScript.origin.profile
                    this.Element_Profile = new ElementDefinitionInfo
                    {
                        Name = "Element_Profile",
                        Path= "TestScript.origin.profile",
                        Id = "TestScript.origin.profile",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
            }
        }
        // 19. TestScript.destination
        public partial class Type_Destination : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 20. TestScript.destination.index
            public ElementDefinitionInfo Element_Index;
            // 21. TestScript.destination.profile
            public ElementDefinitionInfo Element_Profile;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TestScript.destination",
                    ElementId = "TestScript.destination"
                });
                Element_Index.Write(sDef);
                Element_Profile.Write(sDef);
            }
            
            public Type_Destination()
            {
                {
                    // 20. TestScript.destination.index
                    this.Element_Index = new ElementDefinitionInfo
                    {
                        Name = "Element_Index",
                        Path= "TestScript.destination.index",
                        Id = "TestScript.destination.index",
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
                    // 21. TestScript.destination.profile
                    this.Element_Profile = new ElementDefinitionInfo
                    {
                        Name = "Element_Profile",
                        Path= "TestScript.destination.profile",
                        Id = "TestScript.destination.profile",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
            }
        }
        // 22. TestScript.metadata
        public partial class Type_Metadata : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 23. TestScript.metadata.link
            public partial class Type_Link : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 24. TestScript.metadata.link.url
                public ElementDefinitionInfo Element_Url;
                // 25. TestScript.metadata.link.description
                public ElementDefinitionInfo Element_Description;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "TestScript.metadata.link",
                        ElementId = "TestScript.metadata.link"
                    });
                    Element_Url.Write(sDef);
                    Element_Description.Write(sDef);
                }
                
                public Type_Link()
                {
                    {
                        // 24. TestScript.metadata.link.url
                        this.Element_Url = new ElementDefinitionInfo
                        {
                            Name = "Element_Url",
                            Path= "TestScript.metadata.link.url",
                            Id = "TestScript.metadata.link.url",
                            Min = 1,
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
                        // 25. TestScript.metadata.link.description
                        this.Element_Description = new ElementDefinitionInfo
                        {
                            Name = "Element_Description",
                            Path= "TestScript.metadata.link.description",
                            Id = "TestScript.metadata.link.description",
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
            // 26. TestScript.metadata.capability
            public partial class Type_Capability : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 27. TestScript.metadata.capability.required
                public ElementDefinitionInfo Element_Required;
                // 28. TestScript.metadata.capability.validated
                public ElementDefinitionInfo Element_Validated;
                // 29. TestScript.metadata.capability.description
                public ElementDefinitionInfo Element_Description;
                // 30. TestScript.metadata.capability.origin
                public ElementDefinitionInfo Element_Origin;
                // 31. TestScript.metadata.capability.destination
                public ElementDefinitionInfo Element_Destination;
                // 32. TestScript.metadata.capability.link
                public ElementDefinitionInfo Element_Link;
                // 33. TestScript.metadata.capability.capabilities
                public ElementDefinitionInfo Element_Capabilities;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "TestScript.metadata.capability",
                        ElementId = "TestScript.metadata.capability"
                    });
                    Element_Required.Write(sDef);
                    Element_Validated.Write(sDef);
                    Element_Description.Write(sDef);
                    Element_Origin.Write(sDef);
                    Element_Destination.Write(sDef);
                    Element_Link.Write(sDef);
                    Element_Capabilities.Write(sDef);
                }
                
                public Type_Capability()
                {
                    {
                        // 27. TestScript.metadata.capability.required
                        this.Element_Required = new ElementDefinitionInfo
                        {
                            Name = "Element_Required",
                            Path= "TestScript.metadata.capability.required",
                            Id = "TestScript.metadata.capability.required",
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
                        // 28. TestScript.metadata.capability.validated
                        this.Element_Validated = new ElementDefinitionInfo
                        {
                            Name = "Element_Validated",
                            Path= "TestScript.metadata.capability.validated",
                            Id = "TestScript.metadata.capability.validated",
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
                        // 29. TestScript.metadata.capability.description
                        this.Element_Description = new ElementDefinitionInfo
                        {
                            Name = "Element_Description",
                            Path= "TestScript.metadata.capability.description",
                            Id = "TestScript.metadata.capability.description",
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
                        // 30. TestScript.metadata.capability.origin
                        this.Element_Origin = new ElementDefinitionInfo
                        {
                            Name = "Element_Origin",
                            Path= "TestScript.metadata.capability.origin",
                            Id = "TestScript.metadata.capability.origin",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                                {
                                }
                            }
                        };
                    }
                    {
                        // 31. TestScript.metadata.capability.destination
                        this.Element_Destination = new ElementDefinitionInfo
                        {
                            Name = "Element_Destination",
                            Path= "TestScript.metadata.capability.destination",
                            Id = "TestScript.metadata.capability.destination",
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
                        // 32. TestScript.metadata.capability.link
                        this.Element_Link = new ElementDefinitionInfo
                        {
                            Name = "Element_Link",
                            Path= "TestScript.metadata.capability.link",
                            Id = "TestScript.metadata.capability.link",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                                {
                                }
                            }
                        };
                    }
                    {
                        // 33. TestScript.metadata.capability.capabilities
                        this.Element_Capabilities = new ElementDefinitionInfo
                        {
                            Name = "Element_Capabilities",
                            Path= "TestScript.metadata.capability.capabilities",
                            Id = "TestScript.metadata.capability.capabilities",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                                {
                                    TargetProfile = new String[]
                                    {
                                        "http://hl7.org/fhir/StructureDefinition/CapabilityStatement"
                                    }
                                }
                            }
                        };
                    }
                }
            }
            // 23. TestScript.metadata.link
            public ElementDefinitionInfo Element_Link;
            // 26. TestScript.metadata.capability
            public ElementDefinitionInfo Element_Capability;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TestScript.metadata",
                    ElementId = "TestScript.metadata"
                });
                Element_Link.Write(sDef);
                Element_Capability.Write(sDef);
            }
            
            public Type_Metadata()
            {
                {
                    // 23. TestScript.metadata.link
                    this.Element_Link = new ElementDefinitionInfo
                    {
                        Name = "Element_Link",
                        Path= "TestScript.metadata.link",
                        Id = "TestScript.metadata.link",
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
                {
                    // 26. TestScript.metadata.capability
                    this.Element_Capability = new ElementDefinitionInfo
                    {
                        Name = "Element_Capability",
                        Path= "TestScript.metadata.capability",
                        Id = "TestScript.metadata.capability",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Capability
                            {
                            }
                        }
                    };
                }
            }
        }
        // 34. TestScript.fixture
        public partial class Type_Fixture : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 35. TestScript.fixture.autocreate
            public ElementDefinitionInfo Element_Autocreate;
            // 36. TestScript.fixture.autodelete
            public ElementDefinitionInfo Element_Autodelete;
            // 37. TestScript.fixture.resource
            public ElementDefinitionInfo Element_Resource;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TestScript.fixture",
                    ElementId = "TestScript.fixture"
                });
                Element_Autocreate.Write(sDef);
                Element_Autodelete.Write(sDef);
                Element_Resource.Write(sDef);
            }
            
            public Type_Fixture()
            {
                {
                    // 35. TestScript.fixture.autocreate
                    this.Element_Autocreate = new ElementDefinitionInfo
                    {
                        Name = "Element_Autocreate",
                        Path= "TestScript.fixture.autocreate",
                        Id = "TestScript.fixture.autocreate",
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
                    // 36. TestScript.fixture.autodelete
                    this.Element_Autodelete = new ElementDefinitionInfo
                    {
                        Name = "Element_Autodelete",
                        Path= "TestScript.fixture.autodelete",
                        Id = "TestScript.fixture.autodelete",
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
                    // 37. TestScript.fixture.resource
                    this.Element_Resource = new ElementDefinitionInfo
                    {
                        Name = "Element_Resource",
                        Path= "TestScript.fixture.resource",
                        Id = "TestScript.fixture.resource",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Resource"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 39. TestScript.variable
        public partial class Type_Variable : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 40. TestScript.variable.name
            public ElementDefinitionInfo Element_Name;
            // 41. TestScript.variable.defaultValue
            public ElementDefinitionInfo Element_DefaultValue;
            // 42. TestScript.variable.description
            public ElementDefinitionInfo Element_Description;
            // 43. TestScript.variable.expression
            public ElementDefinitionInfo Element_Expression;
            // 44. TestScript.variable.headerField
            public ElementDefinitionInfo Element_HeaderField;
            // 45. TestScript.variable.hint
            public ElementDefinitionInfo Element_Hint;
            // 46. TestScript.variable.path
            public ElementDefinitionInfo Element_Path;
            // 47. TestScript.variable.sourceId
            public ElementDefinitionInfo Element_SourceId;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TestScript.variable",
                    ElementId = "TestScript.variable"
                });
                Element_Name.Write(sDef);
                Element_DefaultValue.Write(sDef);
                Element_Description.Write(sDef);
                Element_Expression.Write(sDef);
                Element_HeaderField.Write(sDef);
                Element_Hint.Write(sDef);
                Element_Path.Write(sDef);
                Element_SourceId.Write(sDef);
            }
            
            public Type_Variable()
            {
                {
                    // 40. TestScript.variable.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "TestScript.variable.name",
                        Id = "TestScript.variable.name",
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
                    // 41. TestScript.variable.defaultValue
                    this.Element_DefaultValue = new ElementDefinitionInfo
                    {
                        Name = "Element_DefaultValue",
                        Path= "TestScript.variable.defaultValue",
                        Id = "TestScript.variable.defaultValue",
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
                    // 42. TestScript.variable.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "TestScript.variable.description",
                        Id = "TestScript.variable.description",
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
                    // 43. TestScript.variable.expression
                    this.Element_Expression = new ElementDefinitionInfo
                    {
                        Name = "Element_Expression",
                        Path= "TestScript.variable.expression",
                        Id = "TestScript.variable.expression",
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
                    // 44. TestScript.variable.headerField
                    this.Element_HeaderField = new ElementDefinitionInfo
                    {
                        Name = "Element_HeaderField",
                        Path= "TestScript.variable.headerField",
                        Id = "TestScript.variable.headerField",
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
                    // 45. TestScript.variable.hint
                    this.Element_Hint = new ElementDefinitionInfo
                    {
                        Name = "Element_Hint",
                        Path= "TestScript.variable.hint",
                        Id = "TestScript.variable.hint",
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
                    // 46. TestScript.variable.path
                    this.Element_Path = new ElementDefinitionInfo
                    {
                        Name = "Element_Path",
                        Path= "TestScript.variable.path",
                        Id = "TestScript.variable.path",
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
                    // 47. TestScript.variable.sourceId
                    this.Element_SourceId = new ElementDefinitionInfo
                    {
                        Name = "Element_SourceId",
                        Path= "TestScript.variable.sourceId",
                        Id = "TestScript.variable.sourceId",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Id
                            {
                            }
                        }
                    };
                }
            }
        }
        // 48. TestScript.setup
        public partial class Type_Setup : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 49. TestScript.setup.action
            public partial class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 50. TestScript.setup.action.operation
                public partial class Type_Operation : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 62. TestScript.setup.action.operation.requestHeader
                    public partial class Type_RequestHeader : FhirKhit.Maker.Common.Complex.ComplexBase
                    {
                        // 63. TestScript.setup.action.operation.requestHeader.field
                        public ElementDefinitionInfo Element_Field;
                        // 64. TestScript.setup.action.operation.requestHeader.value
                        public ElementDefinitionInfo Element_Value;
                        
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                        {
                            base.Write(sDef);
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                            {
                                Path = "TestScript.setup.action.operation.requestHeader",
                                ElementId = "TestScript.setup.action.operation.requestHeader"
                            });
                            Element_Field.Write(sDef);
                            Element_Value.Write(sDef);
                        }
                        
                        public Type_RequestHeader()
                        {
                            {
                                // 63. TestScript.setup.action.operation.requestHeader.field
                                this.Element_Field = new ElementDefinitionInfo
                                {
                                    Name = "Element_Field",
                                    Path= "TestScript.setup.action.operation.requestHeader.field",
                                    Id = "TestScript.setup.action.operation.requestHeader.field",
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
                                // 64. TestScript.setup.action.operation.requestHeader.value
                                this.Element_Value = new ElementDefinitionInfo
                                {
                                    Name = "Element_Value",
                                    Path= "TestScript.setup.action.operation.requestHeader.value",
                                    Id = "TestScript.setup.action.operation.requestHeader.value",
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
                        }
                    }
                    // 51. TestScript.setup.action.operation.type
                    public ElementDefinitionInfo Element_Type;
                    // 52. TestScript.setup.action.operation.resource
                    public ElementDefinitionInfo Element_Resource;
                    // 53. TestScript.setup.action.operation.label
                    public ElementDefinitionInfo Element_Label;
                    // 54. TestScript.setup.action.operation.description
                    public ElementDefinitionInfo Element_Description;
                    // 55. TestScript.setup.action.operation.accept
                    public ElementDefinitionInfo Element_Accept;
                    // 56. TestScript.setup.action.operation.contentType
                    public ElementDefinitionInfo Element_ContentType;
                    // 57. TestScript.setup.action.operation.destination
                    public ElementDefinitionInfo Element_Destination;
                    // 58. TestScript.setup.action.operation.encodeRequestUrl
                    public ElementDefinitionInfo Element_EncodeRequestUrl;
                    // 59. TestScript.setup.action.operation.method
                    public ElementDefinitionInfo Element_Method;
                    // 60. TestScript.setup.action.operation.origin
                    public ElementDefinitionInfo Element_Origin;
                    // 61. TestScript.setup.action.operation.params
                    public ElementDefinitionInfo Element_Params;
                    // 62. TestScript.setup.action.operation.requestHeader
                    public ElementDefinitionInfo Element_RequestHeader;
                    // 65. TestScript.setup.action.operation.requestId
                    public ElementDefinitionInfo Element_RequestId;
                    // 66. TestScript.setup.action.operation.responseId
                    public ElementDefinitionInfo Element_ResponseId;
                    // 67. TestScript.setup.action.operation.sourceId
                    public ElementDefinitionInfo Element_SourceId;
                    // 68. TestScript.setup.action.operation.targetId
                    public ElementDefinitionInfo Element_TargetId;
                    // 69. TestScript.setup.action.operation.url
                    public ElementDefinitionInfo Element_Url;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "TestScript.setup.action.operation",
                            ElementId = "TestScript.setup.action.operation"
                        });
                        Element_Type.Write(sDef);
                        Element_Resource.Write(sDef);
                        Element_Label.Write(sDef);
                        Element_Description.Write(sDef);
                        Element_Accept.Write(sDef);
                        Element_ContentType.Write(sDef);
                        Element_Destination.Write(sDef);
                        Element_EncodeRequestUrl.Write(sDef);
                        Element_Method.Write(sDef);
                        Element_Origin.Write(sDef);
                        Element_Params.Write(sDef);
                        Element_RequestHeader.Write(sDef);
                        Element_RequestId.Write(sDef);
                        Element_ResponseId.Write(sDef);
                        Element_SourceId.Write(sDef);
                        Element_TargetId.Write(sDef);
                        Element_Url.Write(sDef);
                    }
                    
                    public Type_Operation()
                    {
                        {
                            // 51. TestScript.setup.action.operation.type
                            this.Element_Type = new ElementDefinitionInfo
                            {
                                Name = "Element_Type",
                                Path= "TestScript.setup.action.operation.type",
                                Id = "TestScript.setup.action.operation.type",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Complex.Type_Coding
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 52. TestScript.setup.action.operation.resource
                            this.Element_Resource = new ElementDefinitionInfo
                            {
                                Name = "Element_Resource",
                                Path= "TestScript.setup.action.operation.resource",
                                Id = "TestScript.setup.action.operation.resource",
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
                            // 53. TestScript.setup.action.operation.label
                            this.Element_Label = new ElementDefinitionInfo
                            {
                                Name = "Element_Label",
                                Path= "TestScript.setup.action.operation.label",
                                Id = "TestScript.setup.action.operation.label",
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
                            // 54. TestScript.setup.action.operation.description
                            this.Element_Description = new ElementDefinitionInfo
                            {
                                Name = "Element_Description",
                                Path= "TestScript.setup.action.operation.description",
                                Id = "TestScript.setup.action.operation.description",
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
                            // 55. TestScript.setup.action.operation.accept
                            this.Element_Accept = new ElementDefinitionInfo
                            {
                                Name = "Element_Accept",
                                Path= "TestScript.setup.action.operation.accept",
                                Id = "TestScript.setup.action.operation.accept",
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
                            // 56. TestScript.setup.action.operation.contentType
                            this.Element_ContentType = new ElementDefinitionInfo
                            {
                                Name = "Element_ContentType",
                                Path= "TestScript.setup.action.operation.contentType",
                                Id = "TestScript.setup.action.operation.contentType",
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
                            // 57. TestScript.setup.action.operation.destination
                            this.Element_Destination = new ElementDefinitionInfo
                            {
                                Name = "Element_Destination",
                                Path= "TestScript.setup.action.operation.destination",
                                Id = "TestScript.setup.action.operation.destination",
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
                            // 58. TestScript.setup.action.operation.encodeRequestUrl
                            this.Element_EncodeRequestUrl = new ElementDefinitionInfo
                            {
                                Name = "Element_EncodeRequestUrl",
                                Path= "TestScript.setup.action.operation.encodeRequestUrl",
                                Id = "TestScript.setup.action.operation.encodeRequestUrl",
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
                            // 59. TestScript.setup.action.operation.method
                            this.Element_Method = new ElementDefinitionInfo
                            {
                                Name = "Element_Method",
                                Path= "TestScript.setup.action.operation.method",
                                Id = "TestScript.setup.action.operation.method",
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
                            // 60. TestScript.setup.action.operation.origin
                            this.Element_Origin = new ElementDefinitionInfo
                            {
                                Name = "Element_Origin",
                                Path= "TestScript.setup.action.operation.origin",
                                Id = "TestScript.setup.action.operation.origin",
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
                            // 61. TestScript.setup.action.operation.params
                            this.Element_Params = new ElementDefinitionInfo
                            {
                                Name = "Element_Params",
                                Path= "TestScript.setup.action.operation.params",
                                Id = "TestScript.setup.action.operation.params",
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
                            // 62. TestScript.setup.action.operation.requestHeader
                            this.Element_RequestHeader = new ElementDefinitionInfo
                            {
                                Name = "Element_RequestHeader",
                                Path= "TestScript.setup.action.operation.requestHeader",
                                Id = "TestScript.setup.action.operation.requestHeader",
                                Min = 0,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                    new Type_RequestHeader
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 65. TestScript.setup.action.operation.requestId
                            this.Element_RequestId = new ElementDefinitionInfo
                            {
                                Name = "Element_RequestId",
                                Path= "TestScript.setup.action.operation.requestId",
                                Id = "TestScript.setup.action.operation.requestId",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Id
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 66. TestScript.setup.action.operation.responseId
                            this.Element_ResponseId = new ElementDefinitionInfo
                            {
                                Name = "Element_ResponseId",
                                Path= "TestScript.setup.action.operation.responseId",
                                Id = "TestScript.setup.action.operation.responseId",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Id
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 67. TestScript.setup.action.operation.sourceId
                            this.Element_SourceId = new ElementDefinitionInfo
                            {
                                Name = "Element_SourceId",
                                Path= "TestScript.setup.action.operation.sourceId",
                                Id = "TestScript.setup.action.operation.sourceId",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Id
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 68. TestScript.setup.action.operation.targetId
                            this.Element_TargetId = new ElementDefinitionInfo
                            {
                                Name = "Element_TargetId",
                                Path= "TestScript.setup.action.operation.targetId",
                                Id = "TestScript.setup.action.operation.targetId",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Id
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 69. TestScript.setup.action.operation.url
                            this.Element_Url = new ElementDefinitionInfo
                            {
                                Name = "Element_Url",
                                Path= "TestScript.setup.action.operation.url",
                                Id = "TestScript.setup.action.operation.url",
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
                // 70. TestScript.setup.action.assert
                public partial class Type_Assert : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 71. TestScript.setup.action.assert.label
                    public ElementDefinitionInfo Element_Label;
                    // 72. TestScript.setup.action.assert.description
                    public ElementDefinitionInfo Element_Description;
                    // 73. TestScript.setup.action.assert.direction
                    public ElementDefinitionInfo Element_Direction;
                    // 74. TestScript.setup.action.assert.compareToSourceId
                    public ElementDefinitionInfo Element_CompareToSourceId;
                    // 75. TestScript.setup.action.assert.compareToSourceExpression
                    public ElementDefinitionInfo Element_CompareToSourceExpression;
                    // 76. TestScript.setup.action.assert.compareToSourcePath
                    public ElementDefinitionInfo Element_CompareToSourcePath;
                    // 77. TestScript.setup.action.assert.contentType
                    public ElementDefinitionInfo Element_ContentType;
                    // 78. TestScript.setup.action.assert.expression
                    public ElementDefinitionInfo Element_Expression;
                    // 79. TestScript.setup.action.assert.headerField
                    public ElementDefinitionInfo Element_HeaderField;
                    // 80. TestScript.setup.action.assert.minimumId
                    public ElementDefinitionInfo Element_MinimumId;
                    // 81. TestScript.setup.action.assert.navigationLinks
                    public ElementDefinitionInfo Element_NavigationLinks;
                    // 82. TestScript.setup.action.assert.operator
                    public ElementDefinitionInfo Element_Operator;
                    // 83. TestScript.setup.action.assert.path
                    public ElementDefinitionInfo Element_Path;
                    // 84. TestScript.setup.action.assert.requestMethod
                    public ElementDefinitionInfo Element_RequestMethod;
                    // 85. TestScript.setup.action.assert.requestURL
                    public ElementDefinitionInfo Element_RequestURL;
                    // 86. TestScript.setup.action.assert.resource
                    public ElementDefinitionInfo Element_Resource;
                    // 87. TestScript.setup.action.assert.response
                    public ElementDefinitionInfo Element_Response;
                    // 88. TestScript.setup.action.assert.responseCode
                    public ElementDefinitionInfo Element_ResponseCode;
                    // 89. TestScript.setup.action.assert.sourceId
                    public ElementDefinitionInfo Element_SourceId;
                    // 90. TestScript.setup.action.assert.validateProfileId
                    public ElementDefinitionInfo Element_ValidateProfileId;
                    // 91. TestScript.setup.action.assert.value
                    public ElementDefinitionInfo Element_Value;
                    // 92. TestScript.setup.action.assert.warningOnly
                    public ElementDefinitionInfo Element_WarningOnly;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "TestScript.setup.action.assert",
                            ElementId = "TestScript.setup.action.assert"
                        });
                        Element_Label.Write(sDef);
                        Element_Description.Write(sDef);
                        Element_Direction.Write(sDef);
                        Element_CompareToSourceId.Write(sDef);
                        Element_CompareToSourceExpression.Write(sDef);
                        Element_CompareToSourcePath.Write(sDef);
                        Element_ContentType.Write(sDef);
                        Element_Expression.Write(sDef);
                        Element_HeaderField.Write(sDef);
                        Element_MinimumId.Write(sDef);
                        Element_NavigationLinks.Write(sDef);
                        Element_Operator.Write(sDef);
                        Element_Path.Write(sDef);
                        Element_RequestMethod.Write(sDef);
                        Element_RequestURL.Write(sDef);
                        Element_Resource.Write(sDef);
                        Element_Response.Write(sDef);
                        Element_ResponseCode.Write(sDef);
                        Element_SourceId.Write(sDef);
                        Element_ValidateProfileId.Write(sDef);
                        Element_Value.Write(sDef);
                        Element_WarningOnly.Write(sDef);
                    }
                    
                    public Type_Assert()
                    {
                        {
                            // 71. TestScript.setup.action.assert.label
                            this.Element_Label = new ElementDefinitionInfo
                            {
                                Name = "Element_Label",
                                Path= "TestScript.setup.action.assert.label",
                                Id = "TestScript.setup.action.assert.label",
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
                            // 72. TestScript.setup.action.assert.description
                            this.Element_Description = new ElementDefinitionInfo
                            {
                                Name = "Element_Description",
                                Path= "TestScript.setup.action.assert.description",
                                Id = "TestScript.setup.action.assert.description",
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
                            // 73. TestScript.setup.action.assert.direction
                            this.Element_Direction = new ElementDefinitionInfo
                            {
                                Name = "Element_Direction",
                                Path= "TestScript.setup.action.assert.direction",
                                Id = "TestScript.setup.action.assert.direction",
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
                            // 74. TestScript.setup.action.assert.compareToSourceId
                            this.Element_CompareToSourceId = new ElementDefinitionInfo
                            {
                                Name = "Element_CompareToSourceId",
                                Path= "TestScript.setup.action.assert.compareToSourceId",
                                Id = "TestScript.setup.action.assert.compareToSourceId",
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
                            // 75. TestScript.setup.action.assert.compareToSourceExpression
                            this.Element_CompareToSourceExpression = new ElementDefinitionInfo
                            {
                                Name = "Element_CompareToSourceExpression",
                                Path= "TestScript.setup.action.assert.compareToSourceExpression",
                                Id = "TestScript.setup.action.assert.compareToSourceExpression",
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
                            // 76. TestScript.setup.action.assert.compareToSourcePath
                            this.Element_CompareToSourcePath = new ElementDefinitionInfo
                            {
                                Name = "Element_CompareToSourcePath",
                                Path= "TestScript.setup.action.assert.compareToSourcePath",
                                Id = "TestScript.setup.action.assert.compareToSourcePath",
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
                            // 77. TestScript.setup.action.assert.contentType
                            this.Element_ContentType = new ElementDefinitionInfo
                            {
                                Name = "Element_ContentType",
                                Path= "TestScript.setup.action.assert.contentType",
                                Id = "TestScript.setup.action.assert.contentType",
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
                            // 78. TestScript.setup.action.assert.expression
                            this.Element_Expression = new ElementDefinitionInfo
                            {
                                Name = "Element_Expression",
                                Path= "TestScript.setup.action.assert.expression",
                                Id = "TestScript.setup.action.assert.expression",
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
                            // 79. TestScript.setup.action.assert.headerField
                            this.Element_HeaderField = new ElementDefinitionInfo
                            {
                                Name = "Element_HeaderField",
                                Path= "TestScript.setup.action.assert.headerField",
                                Id = "TestScript.setup.action.assert.headerField",
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
                            // 80. TestScript.setup.action.assert.minimumId
                            this.Element_MinimumId = new ElementDefinitionInfo
                            {
                                Name = "Element_MinimumId",
                                Path= "TestScript.setup.action.assert.minimumId",
                                Id = "TestScript.setup.action.assert.minimumId",
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
                            // 81. TestScript.setup.action.assert.navigationLinks
                            this.Element_NavigationLinks = new ElementDefinitionInfo
                            {
                                Name = "Element_NavigationLinks",
                                Path= "TestScript.setup.action.assert.navigationLinks",
                                Id = "TestScript.setup.action.assert.navigationLinks",
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
                            // 82. TestScript.setup.action.assert.operator
                            this.Element_Operator = new ElementDefinitionInfo
                            {
                                Name = "Element_Operator",
                                Path= "TestScript.setup.action.assert.operator",
                                Id = "TestScript.setup.action.assert.operator",
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
                            // 83. TestScript.setup.action.assert.path
                            this.Element_Path = new ElementDefinitionInfo
                            {
                                Name = "Element_Path",
                                Path= "TestScript.setup.action.assert.path",
                                Id = "TestScript.setup.action.assert.path",
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
                            // 84. TestScript.setup.action.assert.requestMethod
                            this.Element_RequestMethod = new ElementDefinitionInfo
                            {
                                Name = "Element_RequestMethod",
                                Path= "TestScript.setup.action.assert.requestMethod",
                                Id = "TestScript.setup.action.assert.requestMethod",
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
                            // 85. TestScript.setup.action.assert.requestURL
                            this.Element_RequestURL = new ElementDefinitionInfo
                            {
                                Name = "Element_RequestURL",
                                Path= "TestScript.setup.action.assert.requestURL",
                                Id = "TestScript.setup.action.assert.requestURL",
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
                            // 86. TestScript.setup.action.assert.resource
                            this.Element_Resource = new ElementDefinitionInfo
                            {
                                Name = "Element_Resource",
                                Path= "TestScript.setup.action.assert.resource",
                                Id = "TestScript.setup.action.assert.resource",
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
                            // 87. TestScript.setup.action.assert.response
                            this.Element_Response = new ElementDefinitionInfo
                            {
                                Name = "Element_Response",
                                Path= "TestScript.setup.action.assert.response",
                                Id = "TestScript.setup.action.assert.response",
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
                            // 88. TestScript.setup.action.assert.responseCode
                            this.Element_ResponseCode = new ElementDefinitionInfo
                            {
                                Name = "Element_ResponseCode",
                                Path= "TestScript.setup.action.assert.responseCode",
                                Id = "TestScript.setup.action.assert.responseCode",
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
                            // 89. TestScript.setup.action.assert.sourceId
                            this.Element_SourceId = new ElementDefinitionInfo
                            {
                                Name = "Element_SourceId",
                                Path= "TestScript.setup.action.assert.sourceId",
                                Id = "TestScript.setup.action.assert.sourceId",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Id
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 90. TestScript.setup.action.assert.validateProfileId
                            this.Element_ValidateProfileId = new ElementDefinitionInfo
                            {
                                Name = "Element_ValidateProfileId",
                                Path= "TestScript.setup.action.assert.validateProfileId",
                                Id = "TestScript.setup.action.assert.validateProfileId",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Id
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 91. TestScript.setup.action.assert.value
                            this.Element_Value = new ElementDefinitionInfo
                            {
                                Name = "Element_Value",
                                Path= "TestScript.setup.action.assert.value",
                                Id = "TestScript.setup.action.assert.value",
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
                            // 92. TestScript.setup.action.assert.warningOnly
                            this.Element_WarningOnly = new ElementDefinitionInfo
                            {
                                Name = "Element_WarningOnly",
                                Path= "TestScript.setup.action.assert.warningOnly",
                                Id = "TestScript.setup.action.assert.warningOnly",
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
                // 50. TestScript.setup.action.operation
                public ElementDefinitionInfo Element_Operation;
                // 70. TestScript.setup.action.assert
                public ElementDefinitionInfo Element_Assert;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "TestScript.setup.action",
                        ElementId = "TestScript.setup.action"
                    });
                    Element_Operation.Write(sDef);
                    Element_Assert.Write(sDef);
                }
                
                public Type_Action()
                {
                    {
                        // 50. TestScript.setup.action.operation
                        this.Element_Operation = new ElementDefinitionInfo
                        {
                            Name = "Element_Operation",
                            Path= "TestScript.setup.action.operation",
                            Id = "TestScript.setup.action.operation",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new Type_Operation
                                {
                                }
                            }
                        };
                    }
                    {
                        // 70. TestScript.setup.action.assert
                        this.Element_Assert = new ElementDefinitionInfo
                        {
                            Name = "Element_Assert",
                            Path= "TestScript.setup.action.assert",
                            Id = "TestScript.setup.action.assert",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new Type_Assert
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 49. TestScript.setup.action
            public ElementDefinitionInfo Element_Action;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TestScript.setup",
                    ElementId = "TestScript.setup"
                });
                Element_Action.Write(sDef);
            }
            
            public Type_Setup()
            {
                {
                    // 49. TestScript.setup.action
                    this.Element_Action = new ElementDefinitionInfo
                    {
                        Name = "Element_Action",
                        Path= "TestScript.setup.action",
                        Id = "TestScript.setup.action",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Action
                            {
                            }
                        }
                    };
                }
            }
        }
        // 93. TestScript.test
        public partial class Type_Test : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 96. TestScript.test.action
            public partial class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 97. TestScript.test.action.operation
                public ElementDefinitionInfo Element_Operation;
                // 98. TestScript.test.action.assert
                public ElementDefinitionInfo Element_Assert;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "TestScript.test.action",
                        ElementId = "TestScript.test.action"
                    });
                    Element_Operation.Write(sDef);
                    Element_Assert.Write(sDef);
                }
                
                public Type_Action()
                {
                    {
                        // 97. TestScript.test.action.operation
                        this.Element_Operation = new ElementDefinitionInfo
                        {
                            Name = "Element_Operation",
                            Path= "TestScript.test.action.operation",
                            Id = "TestScript.test.action.operation",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                    {
                        // 98. TestScript.test.action.assert
                        this.Element_Assert = new ElementDefinitionInfo
                        {
                            Name = "Element_Assert",
                            Path= "TestScript.test.action.assert",
                            Id = "TestScript.test.action.assert",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                }
            }
            // 94. TestScript.test.name
            public ElementDefinitionInfo Element_Name;
            // 95. TestScript.test.description
            public ElementDefinitionInfo Element_Description;
            // 96. TestScript.test.action
            public ElementDefinitionInfo Element_Action;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TestScript.test",
                    ElementId = "TestScript.test"
                });
                Element_Name.Write(sDef);
                Element_Description.Write(sDef);
                Element_Action.Write(sDef);
            }
            
            public Type_Test()
            {
                {
                    // 94. TestScript.test.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "TestScript.test.name",
                        Id = "TestScript.test.name",
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
                    // 95. TestScript.test.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "TestScript.test.description",
                        Id = "TestScript.test.description",
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
                    // 96. TestScript.test.action
                    this.Element_Action = new ElementDefinitionInfo
                    {
                        Name = "Element_Action",
                        Path= "TestScript.test.action",
                        Id = "TestScript.test.action",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Action
                            {
                            }
                        }
                    };
                }
            }
        }
        // 99. TestScript.teardown
        public partial class Type_Teardown : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 100. TestScript.teardown.action
            public partial class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 101. TestScript.teardown.action.operation
                public ElementDefinitionInfo Element_Operation;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "TestScript.teardown.action",
                        ElementId = "TestScript.teardown.action"
                    });
                    Element_Operation.Write(sDef);
                }
                
                public Type_Action()
                {
                    {
                        // 101. TestScript.teardown.action.operation
                        this.Element_Operation = new ElementDefinitionInfo
                        {
                            Name = "Element_Operation",
                            Path= "TestScript.teardown.action.operation",
                            Id = "TestScript.teardown.action.operation",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                }
            }
            // 100. TestScript.teardown.action
            public ElementDefinitionInfo Element_Action;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "TestScript.teardown",
                    ElementId = "TestScript.teardown"
                });
                Element_Action.Write(sDef);
            }
            
            public Type_Teardown()
            {
                {
                    // 100. TestScript.teardown.action
                    this.Element_Action = new ElementDefinitionInfo
                    {
                        Name = "Element_Action",
                        Path= "TestScript.teardown.action",
                        Id = "TestScript.teardown.action",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Action
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. TestScript.url
        public ElementDefinitionInfo Element_Url;
        // 2. TestScript.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. TestScript.version
        public ElementDefinitionInfo Element_Version;
        // 4. TestScript.name
        public ElementDefinitionInfo Element_Name;
        // 5. TestScript.title
        public ElementDefinitionInfo Element_Title;
        // 6. TestScript.status
        public ElementDefinitionInfo Element_Status;
        // 7. TestScript.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 8. TestScript.date
        public ElementDefinitionInfo Element_Date;
        // 9. TestScript.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 10. TestScript.contact
        public ElementDefinitionInfo Element_Contact;
        // 11. TestScript.description
        public ElementDefinitionInfo Element_Description;
        // 12. TestScript.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 13. TestScript.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 14. TestScript.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 15. TestScript.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 16. TestScript.origin
        public ElementDefinitionInfo Element_Origin;
        // 19. TestScript.destination
        public ElementDefinitionInfo Element_Destination;
        // 22. TestScript.metadata
        public ElementDefinitionInfo Element_Metadata;
        // 34. TestScript.fixture
        public ElementDefinitionInfo Element_Fixture;
        // 38. TestScript.profile
        public ElementDefinitionInfo Element_Profile;
        // 39. TestScript.variable
        public ElementDefinitionInfo Element_Variable;
        // 48. TestScript.setup
        public ElementDefinitionInfo Element_Setup;
        // 93. TestScript.test
        public ElementDefinitionInfo Element_Test;
        // 99. TestScript.teardown
        public ElementDefinitionInfo Element_Teardown;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "TestScript",
                ElementId = "TestScript"
            });
            Element_Url.Write(sDef);
            Element_Identifier.Write(sDef);
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
            Element_Origin.Write(sDef);
            Element_Destination.Write(sDef);
            Element_Metadata.Write(sDef);
            Element_Fixture.Write(sDef);
            Element_Profile.Write(sDef);
            Element_Variable.Write(sDef);
            Element_Setup.Write(sDef);
            Element_Test.Write(sDef);
            Element_Teardown.Write(sDef);
        }
        
        public Resource_TestScript()
        {
            {
                // 1. TestScript.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "TestScript.url",
                    Id = "TestScript.url",
                    Min = 1,
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
                // 2. TestScript.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "TestScript.identifier",
                    Id = "TestScript.identifier",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 3. TestScript.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "TestScript.version",
                    Id = "TestScript.version",
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
                // 4. TestScript.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "TestScript.name",
                    Id = "TestScript.name",
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
                // 5. TestScript.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "TestScript.title",
                    Id = "TestScript.title",
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
                // 6. TestScript.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "TestScript.status",
                    Id = "TestScript.status",
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
                // 7. TestScript.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "TestScript.experimental",
                    Id = "TestScript.experimental",
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
                // 8. TestScript.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "TestScript.date",
                    Id = "TestScript.date",
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
                // 9. TestScript.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "TestScript.publisher",
                    Id = "TestScript.publisher",
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
                // 10. TestScript.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "TestScript.contact",
                    Id = "TestScript.contact",
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
                // 11. TestScript.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "TestScript.description",
                    Id = "TestScript.description",
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
                // 12. TestScript.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "TestScript.useContext",
                    Id = "TestScript.useContext",
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
                // 13. TestScript.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "TestScript.jurisdiction",
                    Id = "TestScript.jurisdiction",
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
                // 14. TestScript.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "TestScript.purpose",
                    Id = "TestScript.purpose",
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
                // 15. TestScript.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "TestScript.copyright",
                    Id = "TestScript.copyright",
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
                // 16. TestScript.origin
                this.Element_Origin = new ElementDefinitionInfo
                {
                    Name = "Element_Origin",
                    Path= "TestScript.origin",
                    Id = "TestScript.origin",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Origin
                        {
                        }
                    }
                };
            }
            {
                // 19. TestScript.destination
                this.Element_Destination = new ElementDefinitionInfo
                {
                    Name = "Element_Destination",
                    Path= "TestScript.destination",
                    Id = "TestScript.destination",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Destination
                        {
                        }
                    }
                };
            }
            {
                // 22. TestScript.metadata
                this.Element_Metadata = new ElementDefinitionInfo
                {
                    Name = "Element_Metadata",
                    Path= "TestScript.metadata",
                    Id = "TestScript.metadata",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Metadata
                        {
                        }
                    }
                };
            }
            {
                // 34. TestScript.fixture
                this.Element_Fixture = new ElementDefinitionInfo
                {
                    Name = "Element_Fixture",
                    Path= "TestScript.fixture",
                    Id = "TestScript.fixture",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Fixture
                        {
                        }
                    }
                };
            }
            {
                // 38. TestScript.profile
                this.Element_Profile = new ElementDefinitionInfo
                {
                    Name = "Element_Profile",
                    Path= "TestScript.profile",
                    Id = "TestScript.profile",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Resource"
                            }
                        }
                    }
                };
            }
            {
                // 39. TestScript.variable
                this.Element_Variable = new ElementDefinitionInfo
                {
                    Name = "Element_Variable",
                    Path= "TestScript.variable",
                    Id = "TestScript.variable",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Variable
                        {
                        }
                    }
                };
            }
            {
                // 48. TestScript.setup
                this.Element_Setup = new ElementDefinitionInfo
                {
                    Name = "Element_Setup",
                    Path= "TestScript.setup",
                    Id = "TestScript.setup",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Setup
                        {
                        }
                    }
                };
            }
            {
                // 93. TestScript.test
                this.Element_Test = new ElementDefinitionInfo
                {
                    Name = "Element_Test",
                    Path= "TestScript.test",
                    Id = "TestScript.test",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Test
                        {
                        }
                    }
                };
            }
            {
                // 99. TestScript.teardown
                this.Element_Teardown = new ElementDefinitionInfo
                {
                    Name = "Element_Teardown",
                    Path= "TestScript.teardown",
                    Id = "TestScript.teardown",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Teardown
                        {
                        }
                    }
                };
            }
            this.Name = "TestScript";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/TestScript";
        }
    }
}
