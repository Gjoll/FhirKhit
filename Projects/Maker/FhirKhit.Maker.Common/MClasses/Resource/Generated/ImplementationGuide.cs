using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
    {
      "resourceType": "StructureDefinition",
      "id": "ImplementationGuide",
      "url": "http://hl7.org/fhir/StructureDefinition/ImplementationGuide",
      "version": "4.0.0",
      "name": "ImplementationGuide",
      "status": "draft",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A set of rules of how a particular interoperability or standards problem is solved - typically through the use of FHIR resources. This resource is used to gather all the parts of an implementation guide into a logical whole and to publish a computable definition of all the parts.",
      "purpose": "An implementation guide is able to define default profiles that must apply to any use of a resource, so validation services may need to take one or more implementation guide resources when validating.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ImplementationGuide",
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
            "id": "ImplementationGuide",
            "path": "ImplementationGuide",
            "short": "A set of rules about how FHIR is used",
            "definition": "A set of rules of how a particular interoperability or standards problem is solved - typically through the use of FHIR resources. This resource is used to gather all the parts of an implementation guide into a logical whole and to publish a computable definition of all the parts.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ImplementationGuide.url",
            "path": "ImplementationGuide.url",
            "short": "Canonical identifier for this implementation guide, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this implementation guide when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this implementation guide is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the implementation guide is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the implementation guide to be referenced by a single globally unique identifier. This is required to allow hosting Implementation Guides on multiple different servers, and to allow for the editorial process.",
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
            "id": "ImplementationGuide.version",
            "path": "ImplementationGuide.version",
            "short": "Business version of the implementation guide",
            "definition": "The identifier that is used to identify this version of the implementation guide when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the implementation guide author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different implementation guide instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the implementation guide with the format [url]|[version].",
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
            "id": "ImplementationGuide.name",
            "path": "ImplementationGuide.name",
            "short": "Name for this implementation guide (computer friendly)",
            "definition": "A natural language name identifying the implementation guide. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "ImplementationGuide.title",
            "path": "ImplementationGuide.title",
            "short": "Name for this implementation guide (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the implementation guide.",
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
            "id": "ImplementationGuide.status",
            "path": "ImplementationGuide.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this implementation guide. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of implementation guides that are appropriate for use versus not.",
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
            "id": "ImplementationGuide.experimental",
            "path": "ImplementationGuide.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this implementation guide is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of implementation guides that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level implementation guide.",
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
            "id": "ImplementationGuide.date",
            "path": "ImplementationGuide.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the implementation guide was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the implementation guide changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the implementation guide. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "ImplementationGuide.publisher",
            "path": "ImplementationGuide.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the implementation guide.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the implementation guide is the organization or individual primarily responsible for the maintenance and upkeep of the implementation guide. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the implementation guide. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the implementation guide.  May also allow for contact.",
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
            "id": "ImplementationGuide.contact",
            "path": "ImplementationGuide.contact",
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
            "id": "ImplementationGuide.description",
            "path": "ImplementationGuide.description",
            "short": "Natural language description of the implementation guide",
            "definition": "A free text natural language description of the implementation guide from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the implementation guide was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the implementation guide as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the implementation guide is presumed to be the predominant language in the place the implementation guide was created).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ImplementationGuide.useContext",
            "path": "ImplementationGuide.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate implementation guide instances.",
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
            "id": "ImplementationGuide.jurisdiction",
            "path": "ImplementationGuide.jurisdiction",
            "short": "Intended jurisdiction for implementation guide (if applicable)",
            "definition": "A legal or geographic region in which the implementation guide is intended to be used.",
            "comment": "It may be possible for the implementation guide to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "ImplementationGuide.copyright",
            "path": "ImplementationGuide.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the implementation guide and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the implementation guide.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the implementation guide and/or its content.",
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
            "id": "ImplementationGuide.packageId",
            "path": "ImplementationGuide.packageId",
            "short": "NPM Package name for IG",
            "definition": "The NPM package name for this Implementation Guide, used in the NPM package distribution, which is the primary mechanism by which FHIR based tooling manages IG dependencies. This value must be globally unique, and should be assigned with care.",
            "comment": "Many (if not all) IG publishing tools will require that this element be present. For implementation guides published through HL7 or the FHIR foundation, the FHIR product director assigns package IDs.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImplementationGuide.license",
            "path": "ImplementationGuide.license",
            "short": "SPDX license code for this IG (or not-open-source)",
            "definition": "The license that applies to this Implementation Guide, using an SPDX license code, or 'not-open-source'.",
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
                  "valueString": "SPDXLicense"
                }
              ],
              "strength": "required",
              "description": "The license that applies to an Implementation Guide (using an SPDX license Identifiers, or 'not-open-source'). The binding is required but new SPDX license Identifiers are allowed to be used (https://spdx.org/licenses/).",
              "valueSet": "http://hl7.org/fhir/ValueSet/spdx-license|4.0.0"
            }
          },
          {
            "id": "ImplementationGuide.fhirVersion",
            "path": "ImplementationGuide.fhirVersion",
            "short": "FHIR Version(s) this Implementation Guide targets",
            "definition": "The version(s) of the FHIR specification that this ImplementationGuide targets - e.g. describes how to use. The value of this element is the formal version of the specification, without the revision number, e.g. [publication].[major].[minor], which is 4.0.0. for this version.",
            "comment": "Most implementation guides target a single version - e.g. they describe how to use a particular version, and the profiles and examples etc are valid for that version. But some implementation guides describe how to use multiple different versions of FHIR to solve the same problem, or in concert with each other. Typically, the requirement to support multiple versions arises as implementation matures and different implementation communities are stuck at different versions by regulation or market dynamics.",
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
            "id": "ImplementationGuide.dependsOn",
            "path": "ImplementationGuide.dependsOn",
            "short": "Another Implementation guide this depends on",
            "definition": "Another implementation guide that this implementation depends on. Typically, an implementation guide uses value sets, profiles etc.defined in other implementation guides.",
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
            "id": "ImplementationGuide.dependsOn.uri",
            "path": "ImplementationGuide.dependsOn.uri",
            "short": "Identity of the IG that this depends on",
            "definition": "A canonical reference to the Implementation guide for the dependency.",
            "comment": "Usually, A canonical reference to the implementation guide is the same as the master location at which the implementation guide is published.",
            "min": 1,
            "max": "1",
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
            "id": "ImplementationGuide.dependsOn.packageId",
            "path": "ImplementationGuide.dependsOn.packageId",
            "short": "NPM Package name for IG this depends on",
            "definition": "The NPM package name for the Implementation Guide that this IG depends on.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImplementationGuide.dependsOn.version",
            "path": "ImplementationGuide.dependsOn.version",
            "short": "Version of the IG",
            "definition": "The version of the IG that is depended on, when the correct version is required to understand the IG correctly.",
            "comment": "This follows the syntax of the NPM packaging version field - see [[reference]].",
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
            "id": "ImplementationGuide.global",
            "path": "ImplementationGuide.global",
            "short": "Profiles that apply globally",
            "definition": "A set of profiles that all resources covered by this implementation guide must conform to.",
            "comment": "See [Default Profiles](implementationguide.html#default) for a discussion of which resources are 'covered' by an implementation guide.",
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
            "id": "ImplementationGuide.global.type",
            "path": "ImplementationGuide.global.type",
            "short": "Type this profile applies to",
            "definition": "The type of resource that all instances must conform to.",
            "comment": "The type must match that of the profile that is referred to but is made explicit here as a denormalization so that a system processing the implementation guide resource knows which resources the profile applies to even if the profile itself is not available.",
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
            "id": "ImplementationGuide.global.profile",
            "path": "ImplementationGuide.global.profile",
            "short": "Profile that all resources must conform to",
            "definition": "A reference to the profile that all instances must conform to.",
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
          },
          {
            "id": "ImplementationGuide.definition",
            "path": "ImplementationGuide.definition",
            "short": "Information needed to build the IG",
            "definition": "The information needed by an IG publisher tool to publish the whole implementation guide.",
            "comment": "Principally, this consists of information abuot source resource and file locations, and build parameters and templates.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.grouping",
            "path": "ImplementationGuide.definition.grouping",
            "short": "Grouping used to present related resources in the IG",
            "definition": "A logical group of resources. Logical groups can be used when building pages.",
            "comment": "Groupings are arbitrary sub-divisions of content. Typically, they are used to help build Table of Contents automatically.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.grouping.name",
            "path": "ImplementationGuide.definition.grouping.name",
            "short": "Descriptive name for the package",
            "definition": "The human-readable title to display for the package of resources when rendering the implementation guide.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.grouping.description",
            "path": "ImplementationGuide.definition.grouping.description",
            "short": "Human readable text describing the package",
            "definition": "Human readable text describing the package.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.resource",
            "path": "ImplementationGuide.definition.resource",
            "short": "Resource in the implementation guide",
            "definition": "A resource that is part of the implementation guide. Conformance resources (value set, structure definition, capability statements etc.) are obvious candidates for inclusion, but any kind of resource can be included as an example resource.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.resource.reference",
            "path": "ImplementationGuide.definition.resource.reference",
            "short": "Location of the resource",
            "definition": "Where this resource is found.",
            "comment": "Usually this is a relative URL that locates the resource within the implementation guide. If you authoring an implementation guide, and will publish it using the FHIR publication tooling, use a URI that may point to a resource, or to one of various alternative representations (e.g. spreadsheet). The tooling will convert this when it publishes it.",
            "min": 1,
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
            "id": "ImplementationGuide.definition.resource.fhirVersion",
            "path": "ImplementationGuide.definition.resource.fhirVersion",
            "short": "Versions this applies to (if different to IG)",
            "definition": "Indicates the FHIR Version(s) this artifact is intended to apply to. If no versions are specified, the resource is assumed to apply to all the versions stated in ImplementationGuide.fhirVersion.",
            "comment": "The resource SHALL be valid against all the versions it is specified to apply to. If the resource referred to is a StructureDefinition, the fhirVersion stated in the StructureDefinition cannot disagree with the version specified here; the specified versions SHALL include the version specified by the StructureDefinition, and may include additional versions using the [applicable-version](extension-structuredefinition-applicable-version.html) extension.",
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
            "id": "ImplementationGuide.definition.resource.name",
            "path": "ImplementationGuide.definition.resource.name",
            "short": "Human Name for the resource",
            "definition": "A human assigned name for the resource. All resources SHOULD have a name, but the name may be extracted from the resource (e.g. ValueSet.name).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.resource.description",
            "path": "ImplementationGuide.definition.resource.description",
            "short": "Reason why included in guide",
            "definition": "A description of the reason that a resource has been included in the implementation guide.",
            "comment": "This is mostly used with examples to explain why it is present (though they can have extensive comments in the examples).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.resource.example[x]",
            "path": "ImplementationGuide.definition.resource.example[x]",
            "short": "Is an example/What is this an example of?",
            "definition": "If true or a reference, indicates the resource is an example instance.  If a reference is present, indicates that the example is an example of the specified profile.",
            "comment": "Examples: \n\n* StructureDefinition -> Any \n* ValueSet -> expansion \n* OperationDefinition -> Parameters \n* Questionnaire -> QuestionnaireResponse.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              },
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
                ]
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.resource.groupingId",
            "path": "ImplementationGuide.definition.resource.groupingId",
            "short": "Grouping this is part of",
            "definition": "Reference to the id of the grouping this resource appears in.",
            "comment": "This must correspond to a package.id element within this implementation guide.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.page",
            "path": "ImplementationGuide.definition.page",
            "short": "Page/Section in the Guide",
            "definition": "A page / section in the implementation guide. The root page is the implementation guide home page.",
            "comment": "Pages automatically become sections if they have sub-pages. By convention, the home page is called index.html.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.page.name[x]",
            "path": "ImplementationGuide.definition.page.name[x]",
            "short": "Where to find that page",
            "definition": "The source address for the page.",
            "comment": "The publishing tool will autogenerate source for list (source = n/a) and inject included implementations for include (source = uri of guide to include).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "url"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Binary"
                ]
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.page.title",
            "path": "ImplementationGuide.definition.page.title",
            "short": "Short title shown for navigational assistance",
            "definition": "A short title used to represent this page in navigational structures such as table of contents, bread crumbs, etc.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.page.generation",
            "path": "ImplementationGuide.definition.page.generation",
            "short": "html | markdown | xml | generated",
            "definition": "A code that indicates how the page is generated.",
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
                  "valueString": "GuidePageGeneration"
                }
              ],
              "strength": "required",
              "description": "A code that indicates how the page is generated.",
              "valueSet": "http://hl7.org/fhir/ValueSet/guide-page-generation|4.0.0"
            }
          },
          {
            "id": "ImplementationGuide.definition.page.page",
            "path": "ImplementationGuide.definition.page.page",
            "short": "Nested Pages / Sections",
            "definition": "Nested Pages/Sections under this page.",
            "comment": "The implementation guide breadcrumbs are generated from this structure.",
            "min": 0,
            "max": "*",
            "contentReference": "#ImplementationGuide.definition.page"
          },
          {
            "id": "ImplementationGuide.definition.parameter",
            "path": "ImplementationGuide.definition.parameter",
            "short": "Defines how IG is built by tools",
            "definition": "Defines how IG is built by tools.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.parameter.code",
            "path": "ImplementationGuide.definition.parameter.code",
            "short": "apply | path-resource | path-pages | path-tx-cache | expansion-parameter | rule-broken-links | generate-xml | generate-json | generate-turtle | html-template",
            "definition": "apply | path-resource | path-pages | path-tx-cache | expansion-parameter | rule-broken-links | generate-xml | generate-json | generate-turtle | html-template.",
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
                  "valueString": "GuideParameterCode"
                }
              ],
              "strength": "required",
              "description": "Code of parameter that is input to the guide.",
              "valueSet": "http://hl7.org/fhir/ValueSet/guide-parameter-code|4.0.0"
            }
          },
          {
            "id": "ImplementationGuide.definition.parameter.value",
            "path": "ImplementationGuide.definition.parameter.value",
            "short": "Value for named type",
            "definition": "Value for named type.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.template",
            "path": "ImplementationGuide.definition.template",
            "short": "A template for building resources",
            "definition": "A template for building resources.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.template.code",
            "path": "ImplementationGuide.definition.template.code",
            "short": "Type of template specified",
            "definition": "Type of template specified.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.template.source",
            "path": "ImplementationGuide.definition.template.source",
            "short": "The source location for the template",
            "definition": "The source location for the template.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImplementationGuide.definition.template.scope",
            "path": "ImplementationGuide.definition.template.scope",
            "short": "The scope in which the template applies",
            "definition": "The scope in which the template applies.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImplementationGuide.manifest",
            "path": "ImplementationGuide.manifest",
            "short": "Information about an assembled IG",
            "definition": "Information about an assembled implementation guide, created by the publication tooling.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ImplementationGuide.manifest.rendering",
            "path": "ImplementationGuide.manifest.rendering",
            "short": "Location of rendered implementation guide",
            "definition": "A pointer to official web page, PDF or other rendering of the implementation guide.",
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
            "id": "ImplementationGuide.manifest.resource",
            "path": "ImplementationGuide.manifest.resource",
            "short": "Resource in the implementation guide",
            "definition": "A resource that is part of the implementation guide. Conformance resources (value set, structure definition, capability statements etc.) are obvious candidates for inclusion, but any kind of resource can be included as an example resource.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImplementationGuide.manifest.resource.reference",
            "path": "ImplementationGuide.manifest.resource.reference",
            "short": "Location of the resource",
            "definition": "Where this resource is found.",
            "comment": "Usually this is a relative URL that locates the resource within the implementation guide. If you authoring an implementation guide, and will publish it using the FHIR publication tooling, use a URI that may point to a resource, or to one of various alternative representations (e.g. spreadsheet). The tooling will convert this when it publishes it.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ImplementationGuide.manifest.resource.example[x]",
            "path": "ImplementationGuide.manifest.resource.example[x]",
            "short": "Is an example/What is this an example of?",
            "definition": "If true or a reference, indicates the resource is an example instance.  If a reference is present, indicates that the example is an example of the specified profile.",
            "comment": "Typically, conformance resources and knowledge resources are directly part of the implementation guide, with their normal meaning, and patient linked resources are usually examples. However this is not always true.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              },
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
                ]
              }
            ]
          },
          {
            "id": "ImplementationGuide.manifest.resource.relativePath",
            "path": "ImplementationGuide.manifest.resource.relativePath",
            "short": "Relative path for page in IG",
            "definition": "The relative path for primary page for this resource within the IG.",
            "comment": "Appending 'rendering' + \"/\" + this should resolve to the resource page.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "url"
              }
            ]
          },
          {
            "id": "ImplementationGuide.manifest.page",
            "path": "ImplementationGuide.manifest.page",
            "short": "HTML page within the parent IG",
            "definition": "Information about a page within the IG.",
            "requirements": "Allows validation of hyperlinks from a derived IG to this IG without a local copy of the IG.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ImplementationGuide.manifest.page.name",
            "path": "ImplementationGuide.manifest.page.name",
            "short": "HTML page name",
            "definition": "Relative path to the page.",
            "comment": "Appending 'rendering' + \"/\" + this should resolve to the page.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImplementationGuide.manifest.page.title",
            "path": "ImplementationGuide.manifest.page.title",
            "short": "Title of the page, for references",
            "definition": "Label for the page intended for human display.",
            "requirements": "Allows generation of labels for markdown-generated hyperlinks.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImplementationGuide.manifest.page.anchor",
            "path": "ImplementationGuide.manifest.page.anchor",
            "short": "Anchor available on the page",
            "definition": "The name of an anchor available on the page.",
            "comment": "Appending 'rendering' + \"/\" + page.name + \"#\" + page.anchor should resolve to the anchor.",
            "requirements": "Allows validation of hyperlinks from a derived IG to this IG without a local copy of the IG.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImplementationGuide.manifest.image",
            "path": "ImplementationGuide.manifest.image",
            "short": "Image within the IG",
            "definition": "Indicates a relative path to an image that exists within the IG.",
            "requirements": "Allows validation of image links from a derived IG to this IG without a local copy of the IG.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ImplementationGuide.manifest.other",
            "path": "ImplementationGuide.manifest.other",
            "short": "Additional linkable file in IG",
            "definition": "Indicates the relative path of an additional non-page, non-image file that is part of the IG - e.g. zip, jar and similar files that could be the target of a hyperlink in a derived IG.",
            "requirements": "Allows validation of links from a derived IG to this IG without a local copy of the IG.",
            "min": 0,
            "max": "*",
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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'ImplementationGuide'
    /// </summary>
    // 0. ImplementationGuide
    public class ImplementationGuide : FhirKhit.Maker.Common.Resource.ResourceBase                                                          // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class ImplementationGuide_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 17. ImplementationGuide.dependsOn
            public class Type_DependsOn : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_DependsOn_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 18. ImplementationGuide.dependsOn.uri
                    public ElementDefinitionInfo Uri;                                                                                       // MakerGen.cs:211
                    // 19. ImplementationGuide.dependsOn.packageId
                    public ElementDefinitionInfo PackageId;                                                                                 // MakerGen.cs:211
                    // 20. ImplementationGuide.dependsOn.version
                    public ElementDefinitionInfo Version;                                                                                   // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_DependsOn_Elements()                                                                                        // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 18. ImplementationGuide.dependsOn.uri
                            this.Uri = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Uri",                                                                                               // MakerGen.cs:230
                                Path= "ImplementationGuide.dependsOn.uri",                                                                  // MakerGen.cs:231
                                Id = "ImplementationGuide.dependsOn.uri",                                                                   // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Canonical                                                           // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:298
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/ImplementationGuide"                                   // MakerGen.cs:298
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 19. ImplementationGuide.dependsOn.packageId
                            this.PackageId = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "PackageId",                                                                                         // MakerGen.cs:230
                                Path= "ImplementationGuide.dependsOn.packageId",                                                            // MakerGen.cs:231
                                Id = "ImplementationGuide.dependsOn.packageId",                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 20. ImplementationGuide.dependsOn.version
                            this.Version = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Version",                                                                                           // MakerGen.cs:230
                                Path= "ImplementationGuide.dependsOn.version",                                                              // MakerGen.cs:231
                                Id = "ImplementationGuide.dependsOn.version",                                                               // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Uri.Write(sDef);                                                                                                    // MakerGen.cs:215
                        PackageId.Write(sDef);                                                                                              // MakerGen.cs:215
                        Version.Write(sDef);                                                                                                // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_DependsOn_Elements Elements                                                                                     // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_DependsOn_Elements();                                                                  // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_DependsOn_Elements elements;                                                                                           // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_DependsOn()                                                                                                     // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "ImplementationGuide.dependsOn",                                                                             // MakerGen.cs:423
                        ElementId = "ImplementationGuide.dependsOn"                                                                         // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 21. ImplementationGuide.global
            public class Type_Global : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Global_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 22. ImplementationGuide.global.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:211
                    // 23. ImplementationGuide.global.profile
                    public ElementDefinitionInfo Profile;                                                                                   // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Global_Elements()                                                                                           // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 22. ImplementationGuide.global.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Type",                                                                                              // MakerGen.cs:230
                                Path= "ImplementationGuide.global.type",                                                                    // MakerGen.cs:231
                                Id = "ImplementationGuide.global.type",                                                                     // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 23. ImplementationGuide.global.profile
                            this.Profile = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Profile",                                                                                           // MakerGen.cs:230
                                Path= "ImplementationGuide.global.profile",                                                                 // MakerGen.cs:231
                                Id = "ImplementationGuide.global.profile",                                                                  // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Canonical                                                           // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:298
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                   // MakerGen.cs:298
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Profile.Write(sDef);                                                                                                // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Global_Elements Elements                                                                                        // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Global_Elements();                                                                     // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Global_Elements elements;                                                                                              // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Global()                                                                                                        // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "ImplementationGuide.global",                                                                                // MakerGen.cs:423
                        ElementId = "ImplementationGuide.global"                                                                            // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 24. ImplementationGuide.definition
            public class Type_Definition : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Definition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 25. ImplementationGuide.definition.grouping
                    public class Type_Grouping : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Grouping_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 26. ImplementationGuide.definition.grouping.name
                            public ElementDefinitionInfo Name;                                                                              // MakerGen.cs:211
                            // 27. ImplementationGuide.definition.grouping.description
                            public ElementDefinitionInfo Description;                                                                       // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Grouping_Elements()                                                                                 // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 26. ImplementationGuide.definition.grouping.name
                                    this.Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Name",                                                                                      // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.grouping.name",                                               // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.grouping.name",                                                // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 27. ImplementationGuide.definition.grouping.description
                                    this.Description = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Description",                                                                               // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.grouping.description",                                        // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.grouping.description",                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Name.Write(sDef);                                                                                           // MakerGen.cs:215
                                Description.Write(sDef);                                                                                    // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Grouping_Elements Elements                                                                              // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Grouping_Elements();                                                           // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Grouping_Elements elements;                                                                                    // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Grouping()                                                                                              // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "ImplementationGuide.definition.grouping",                                                           // MakerGen.cs:423
                                ElementId = "ImplementationGuide.definition.grouping"                                                       // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 28. ImplementationGuide.definition.resource
                    public class Type_Resource : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Resource_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 29. ImplementationGuide.definition.resource.reference
                            public ElementDefinitionInfo Reference;                                                                         // MakerGen.cs:211
                            // 30. ImplementationGuide.definition.resource.fhirVersion
                            public ElementDefinitionInfo FhirVersion;                                                                       // MakerGen.cs:211
                            // 31. ImplementationGuide.definition.resource.name
                            public ElementDefinitionInfo Name;                                                                              // MakerGen.cs:211
                            // 32. ImplementationGuide.definition.resource.description
                            public ElementDefinitionInfo Description;                                                                       // MakerGen.cs:211
                            // 33. ImplementationGuide.definition.resource.example[x]
                            public ElementDefinitionInfo Example;                                                                           // MakerGen.cs:211
                            // 34. ImplementationGuide.definition.resource.groupingId
                            public ElementDefinitionInfo GroupingId;                                                                        // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Resource_Elements()                                                                                 // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 29. ImplementationGuide.definition.resource.reference
                                    this.Reference = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Reference",                                                                                 // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.resource.reference",                                          // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.resource.reference",                                           // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:341
                                            {                                                                                               // MakerGen.cs:342
                                                TargetProfile = new String[]                                                                // MakerGen.cs:344
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                      // MakerGen.cs:344
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:345
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 30. ImplementationGuide.definition.resource.fhirVersion
                                    this.FhirVersion = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "FhirVersion",                                                                               // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.resource.fhirVersion",                                        // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.resource.fhirVersion",                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 31. ImplementationGuide.definition.resource.name
                                    this.Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Name",                                                                                      // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.resource.name",                                               // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.resource.name",                                                // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 32. ImplementationGuide.definition.resource.description
                                    this.Description = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Description",                                                                               // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.resource.description",                                        // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.resource.description",                                         // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 33. ImplementationGuide.definition.resource.example[x]
                                    this.Example = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Example",                                                                                   // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.resource.example[x]",                                         // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.resource.example[x]",                                          // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.Canonical                                                   // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                                TargetProfile = new String[]                                                                // MakerGen.cs:298
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                           // MakerGen.cs:298
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 34. ImplementationGuide.definition.resource.groupingId
                                    this.GroupingId = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "GroupingId",                                                                                // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.resource.groupingId",                                         // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.resource.groupingId",                                          // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Id                                                          // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Reference.Write(sDef);                                                                                      // MakerGen.cs:215
                                FhirVersion.Write(sDef);                                                                                    // MakerGen.cs:215
                                Name.Write(sDef);                                                                                           // MakerGen.cs:215
                                Description.Write(sDef);                                                                                    // MakerGen.cs:215
                                Example.Write(sDef);                                                                                        // MakerGen.cs:215
                                GroupingId.Write(sDef);                                                                                     // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Resource_Elements Elements                                                                              // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Resource_Elements();                                                           // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Resource_Elements elements;                                                                                    // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Resource()                                                                                              // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "ImplementationGuide.definition.resource",                                                           // MakerGen.cs:423
                                ElementId = "ImplementationGuide.definition.resource"                                                       // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 35. ImplementationGuide.definition.page
                    public class Type_Page : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Page_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 36. ImplementationGuide.definition.page.name[x]
                            public ElementDefinitionInfo Name;                                                                              // MakerGen.cs:211
                            // 37. ImplementationGuide.definition.page.title
                            public ElementDefinitionInfo Title;                                                                             // MakerGen.cs:211
                            // 38. ImplementationGuide.definition.page.generation
                            public ElementDefinitionInfo Generation;                                                                        // MakerGen.cs:211
                            // 39. ImplementationGuide.definition.page.page
                            public ElementDefinitionInfo Page;                                                                              // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Page_Elements()                                                                                     // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 36. ImplementationGuide.definition.page.name[x]
                                    this.Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Name",                                                                                      // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.page.name[x]",                                                // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.page.name[x]",                                                 // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Url                                                         // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:341
                                            {                                                                                               // MakerGen.cs:342
                                                TargetProfile = new String[]                                                                // MakerGen.cs:344
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Binary"                                        // MakerGen.cs:344
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:345
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 37. ImplementationGuide.definition.page.title
                                    this.Title = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Title",                                                                                     // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.page.title",                                                  // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.page.title",                                                   // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 38. ImplementationGuide.definition.page.generation
                                    this.Generation = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Generation",                                                                                // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.page.generation",                                             // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.page.generation",                                              // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 39. ImplementationGuide.definition.page.page
                                    this.Page = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Page",                                                                                      // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.page.page",                                                   // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.page.page",                                                    // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Name.Write(sDef);                                                                                           // MakerGen.cs:215
                                Title.Write(sDef);                                                                                          // MakerGen.cs:215
                                Generation.Write(sDef);                                                                                     // MakerGen.cs:215
                                Page.Write(sDef);                                                                                           // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Page_Elements Elements                                                                                  // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Page_Elements();                                                               // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Page_Elements elements;                                                                                        // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Page()                                                                                                  // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "ImplementationGuide.definition.page",                                                               // MakerGen.cs:423
                                ElementId = "ImplementationGuide.definition.page"                                                           // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 40. ImplementationGuide.definition.parameter
                    public class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Parameter_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 41. ImplementationGuide.definition.parameter.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:211
                            // 42. ImplementationGuide.definition.parameter.value
                            public ElementDefinitionInfo Value;                                                                             // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Parameter_Elements()                                                                                // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 41. ImplementationGuide.definition.parameter.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Code",                                                                                      // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.parameter.code",                                              // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.parameter.code",                                               // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 42. ImplementationGuide.definition.parameter.value
                                    this.Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Value",                                                                                     // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.parameter.value",                                             // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.parameter.value",                                              // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Code.Write(sDef);                                                                                           // MakerGen.cs:215
                                Value.Write(sDef);                                                                                          // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Parameter_Elements Elements                                                                             // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Parameter_Elements();                                                          // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Parameter_Elements elements;                                                                                   // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Parameter()                                                                                             // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "ImplementationGuide.definition.parameter",                                                          // MakerGen.cs:423
                                ElementId = "ImplementationGuide.definition.parameter"                                                      // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 43. ImplementationGuide.definition.template
                    public class Type_Template : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Template_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 44. ImplementationGuide.definition.template.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:211
                            // 45. ImplementationGuide.definition.template.source
                            public ElementDefinitionInfo Source;                                                                            // MakerGen.cs:211
                            // 46. ImplementationGuide.definition.template.scope
                            public ElementDefinitionInfo Scope;                                                                             // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Template_Elements()                                                                                 // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 44. ImplementationGuide.definition.template.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Code",                                                                                      // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.template.code",                                               // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.template.code",                                                // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 45. ImplementationGuide.definition.template.source
                                    this.Source = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Source",                                                                                    // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.template.source",                                             // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.template.source",                                              // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 46. ImplementationGuide.definition.template.scope
                                    this.Scope = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Scope",                                                                                     // MakerGen.cs:230
                                        Path= "ImplementationGuide.definition.template.scope",                                              // MakerGen.cs:231
                                        Id = "ImplementationGuide.definition.template.scope",                                               // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Code.Write(sDef);                                                                                           // MakerGen.cs:215
                                Source.Write(sDef);                                                                                         // MakerGen.cs:215
                                Scope.Write(sDef);                                                                                          // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Template_Elements Elements                                                                              // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Template_Elements();                                                           // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Template_Elements elements;                                                                                    // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Template()                                                                                              // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "ImplementationGuide.definition.template",                                                           // MakerGen.cs:423
                                ElementId = "ImplementationGuide.definition.template"                                                       // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 25. ImplementationGuide.definition.grouping
                    public ElementDefinitionInfo Grouping;                                                                                  // MakerGen.cs:211
                    // 28. ImplementationGuide.definition.resource
                    public ElementDefinitionInfo Resource;                                                                                  // MakerGen.cs:211
                    // 35. ImplementationGuide.definition.page
                    public ElementDefinitionInfo Page;                                                                                      // MakerGen.cs:211
                    // 40. ImplementationGuide.definition.parameter
                    public ElementDefinitionInfo Parameter;                                                                                 // MakerGen.cs:211
                    // 43. ImplementationGuide.definition.template
                    public ElementDefinitionInfo Template;                                                                                  // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Definition_Elements()                                                                                       // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 25. ImplementationGuide.definition.grouping
                            this.Grouping = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Grouping",                                                                                          // MakerGen.cs:230
                                Path= "ImplementationGuide.definition.grouping",                                                            // MakerGen.cs:231
                                Id = "ImplementationGuide.definition.grouping",                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Grouping                                                                                       // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 28. ImplementationGuide.definition.resource
                            this.Resource = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Resource",                                                                                          // MakerGen.cs:230
                                Path= "ImplementationGuide.definition.resource",                                                            // MakerGen.cs:231
                                Id = "ImplementationGuide.definition.resource",                                                             // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Resource                                                                                       // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 35. ImplementationGuide.definition.page
                            this.Page = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Page",                                                                                              // MakerGen.cs:230
                                Path= "ImplementationGuide.definition.page",                                                                // MakerGen.cs:231
                                Id = "ImplementationGuide.definition.page",                                                                 // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Page                                                                                           // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 40. ImplementationGuide.definition.parameter
                            this.Parameter = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Parameter",                                                                                         // MakerGen.cs:230
                                Path= "ImplementationGuide.definition.parameter",                                                           // MakerGen.cs:231
                                Id = "ImplementationGuide.definition.parameter",                                                            // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Parameter                                                                                      // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 43. ImplementationGuide.definition.template
                            this.Template = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Template",                                                                                          // MakerGen.cs:230
                                Path= "ImplementationGuide.definition.template",                                                            // MakerGen.cs:231
                                Id = "ImplementationGuide.definition.template",                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Template                                                                                       // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Grouping.Write(sDef);                                                                                               // MakerGen.cs:215
                        Resource.Write(sDef);                                                                                               // MakerGen.cs:215
                        Page.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Parameter.Write(sDef);                                                                                              // MakerGen.cs:215
                        Template.Write(sDef);                                                                                               // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Definition_Elements Elements                                                                                    // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Definition_Elements();                                                                 // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Definition_Elements elements;                                                                                          // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Definition()                                                                                                    // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "ImplementationGuide.definition",                                                                            // MakerGen.cs:423
                        ElementId = "ImplementationGuide.definition"                                                                        // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 47. ImplementationGuide.manifest
            public class Type_Manifest : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Manifest_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 49. ImplementationGuide.manifest.resource
                    public class Type_Resource : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Resource_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 50. ImplementationGuide.manifest.resource.reference
                            public ElementDefinitionInfo Reference;                                                                         // MakerGen.cs:211
                            // 51. ImplementationGuide.manifest.resource.example[x]
                            public ElementDefinitionInfo Example;                                                                           // MakerGen.cs:211
                            // 52. ImplementationGuide.manifest.resource.relativePath
                            public ElementDefinitionInfo RelativePath;                                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Resource_Elements()                                                                                 // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 50. ImplementationGuide.manifest.resource.reference
                                    this.Reference = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Reference",                                                                                 // MakerGen.cs:230
                                        Path= "ImplementationGuide.manifest.resource.reference",                                            // MakerGen.cs:231
                                        Id = "ImplementationGuide.manifest.resource.reference",                                             // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:341
                                            {                                                                                               // MakerGen.cs:342
                                                TargetProfile = new String[]                                                                // MakerGen.cs:344
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                      // MakerGen.cs:344
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:345
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 51. ImplementationGuide.manifest.resource.example[x]
                                    this.Example = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Example",                                                                                   // MakerGen.cs:230
                                        Path= "ImplementationGuide.manifest.resource.example[x]",                                           // MakerGen.cs:231
                                        Id = "ImplementationGuide.manifest.resource.example[x]",                                            // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.Canonical                                                   // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                                TargetProfile = new String[]                                                                // MakerGen.cs:298
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                           // MakerGen.cs:298
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 52. ImplementationGuide.manifest.resource.relativePath
                                    this.RelativePath = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "RelativePath",                                                                              // MakerGen.cs:230
                                        Path= "ImplementationGuide.manifest.resource.relativePath",                                         // MakerGen.cs:231
                                        Id = "ImplementationGuide.manifest.resource.relativePath",                                          // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Url                                                         // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Reference.Write(sDef);                                                                                      // MakerGen.cs:215
                                Example.Write(sDef);                                                                                        // MakerGen.cs:215
                                RelativePath.Write(sDef);                                                                                   // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Resource_Elements Elements                                                                              // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Resource_Elements();                                                           // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Resource_Elements elements;                                                                                    // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Resource()                                                                                              // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "ImplementationGuide.manifest.resource",                                                             // MakerGen.cs:423
                                ElementId = "ImplementationGuide.manifest.resource"                                                         // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 53. ImplementationGuide.manifest.page
                    public class Type_Page : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Page_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 54. ImplementationGuide.manifest.page.name
                            public ElementDefinitionInfo Name;                                                                              // MakerGen.cs:211
                            // 55. ImplementationGuide.manifest.page.title
                            public ElementDefinitionInfo Title;                                                                             // MakerGen.cs:211
                            // 56. ImplementationGuide.manifest.page.anchor
                            public ElementDefinitionInfo Anchor;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Page_Elements()                                                                                     // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 54. ImplementationGuide.manifest.page.name
                                    this.Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Name",                                                                                      // MakerGen.cs:230
                                        Path= "ImplementationGuide.manifest.page.name",                                                     // MakerGen.cs:231
                                        Id = "ImplementationGuide.manifest.page.name",                                                      // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 55. ImplementationGuide.manifest.page.title
                                    this.Title = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Title",                                                                                     // MakerGen.cs:230
                                        Path= "ImplementationGuide.manifest.page.title",                                                    // MakerGen.cs:231
                                        Id = "ImplementationGuide.manifest.page.title",                                                     // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 56. ImplementationGuide.manifest.page.anchor
                                    this.Anchor = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Anchor",                                                                                    // MakerGen.cs:230
                                        Path= "ImplementationGuide.manifest.page.anchor",                                                   // MakerGen.cs:231
                                        Id = "ImplementationGuide.manifest.page.anchor",                                                    // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = -1,                                                                                           // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Name.Write(sDef);                                                                                           // MakerGen.cs:215
                                Title.Write(sDef);                                                                                          // MakerGen.cs:215
                                Anchor.Write(sDef);                                                                                         // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Page_Elements Elements                                                                                  // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Page_Elements();                                                               // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Page_Elements elements;                                                                                        // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Page()                                                                                                  // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "ImplementationGuide.manifest.page",                                                                 // MakerGen.cs:423
                                ElementId = "ImplementationGuide.manifest.page"                                                             // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 48. ImplementationGuide.manifest.rendering
                    public ElementDefinitionInfo Rendering;                                                                                 // MakerGen.cs:211
                    // 49. ImplementationGuide.manifest.resource
                    public ElementDefinitionInfo Resource;                                                                                  // MakerGen.cs:211
                    // 53. ImplementationGuide.manifest.page
                    public ElementDefinitionInfo Page;                                                                                      // MakerGen.cs:211
                    // 57. ImplementationGuide.manifest.image
                    public ElementDefinitionInfo Image;                                                                                     // MakerGen.cs:211
                    // 58. ImplementationGuide.manifest.other
                    public ElementDefinitionInfo Other;                                                                                     // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Manifest_Elements()                                                                                         // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 48. ImplementationGuide.manifest.rendering
                            this.Rendering = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Rendering",                                                                                         // MakerGen.cs:230
                                Path= "ImplementationGuide.manifest.rendering",                                                             // MakerGen.cs:231
                                Id = "ImplementationGuide.manifest.rendering",                                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Url                                                                 // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 49. ImplementationGuide.manifest.resource
                            this.Resource = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Resource",                                                                                          // MakerGen.cs:230
                                Path= "ImplementationGuide.manifest.resource",                                                              // MakerGen.cs:231
                                Id = "ImplementationGuide.manifest.resource",                                                               // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Resource                                                                                       // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 53. ImplementationGuide.manifest.page
                            this.Page = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Page",                                                                                              // MakerGen.cs:230
                                Path= "ImplementationGuide.manifest.page",                                                                  // MakerGen.cs:231
                                Id = "ImplementationGuide.manifest.page",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Page                                                                                           // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 57. ImplementationGuide.manifest.image
                            this.Image = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Image",                                                                                             // MakerGen.cs:230
                                Path= "ImplementationGuide.manifest.image",                                                                 // MakerGen.cs:231
                                Id = "ImplementationGuide.manifest.image",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 58. ImplementationGuide.manifest.other
                            this.Other = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Other",                                                                                             // MakerGen.cs:230
                                Path= "ImplementationGuide.manifest.other",                                                                 // MakerGen.cs:231
                                Id = "ImplementationGuide.manifest.other",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Rendering.Write(sDef);                                                                                              // MakerGen.cs:215
                        Resource.Write(sDef);                                                                                               // MakerGen.cs:215
                        Page.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Image.Write(sDef);                                                                                                  // MakerGen.cs:215
                        Other.Write(sDef);                                                                                                  // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Manifest_Elements Elements                                                                                      // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Manifest_Elements();                                                                   // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Manifest_Elements elements;                                                                                            // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Manifest()                                                                                                      // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "ImplementationGuide.manifest",                                                                              // MakerGen.cs:423
                        ElementId = "ImplementationGuide.manifest"                                                                          // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. ImplementationGuide.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:211
            // 2. ImplementationGuide.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:211
            // 3. ImplementationGuide.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:211
            // 4. ImplementationGuide.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:211
            // 5. ImplementationGuide.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 6. ImplementationGuide.experimental
            public ElementDefinitionInfo Experimental;                                                                                      // MakerGen.cs:211
            // 7. ImplementationGuide.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:211
            // 8. ImplementationGuide.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:211
            // 9. ImplementationGuide.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:211
            // 10. ImplementationGuide.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:211
            // 11. ImplementationGuide.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:211
            // 12. ImplementationGuide.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:211
            // 13. ImplementationGuide.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:211
            // 14. ImplementationGuide.packageId
            public ElementDefinitionInfo PackageId;                                                                                         // MakerGen.cs:211
            // 15. ImplementationGuide.license
            public ElementDefinitionInfo License;                                                                                           // MakerGen.cs:211
            // 16. ImplementationGuide.fhirVersion
            public ElementDefinitionInfo FhirVersion;                                                                                       // MakerGen.cs:211
            // 17. ImplementationGuide.dependsOn
            public ElementDefinitionInfo DependsOn;                                                                                         // MakerGen.cs:211
            // 21. ImplementationGuide.global
            public ElementDefinitionInfo Global;                                                                                            // MakerGen.cs:211
            // 24. ImplementationGuide.definition
            public ElementDefinitionInfo Definition;                                                                                        // MakerGen.cs:211
            // 47. ImplementationGuide.manifest
            public ElementDefinitionInfo Manifest;                                                                                          // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public ImplementationGuide_Elements()                                                                                           // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. ImplementationGuide.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Url",                                                                                                       // MakerGen.cs:230
                        Path= "ImplementationGuide.url",                                                                                    // MakerGen.cs:231
                        Id = "ImplementationGuide.url",                                                                                     // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. ImplementationGuide.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Version",                                                                                                   // MakerGen.cs:230
                        Path= "ImplementationGuide.version",                                                                                // MakerGen.cs:231
                        Id = "ImplementationGuide.version",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. ImplementationGuide.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Name",                                                                                                      // MakerGen.cs:230
                        Path= "ImplementationGuide.name",                                                                                   // MakerGen.cs:231
                        Id = "ImplementationGuide.name",                                                                                    // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. ImplementationGuide.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Title",                                                                                                     // MakerGen.cs:230
                        Path= "ImplementationGuide.title",                                                                                  // MakerGen.cs:231
                        Id = "ImplementationGuide.title",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. ImplementationGuide.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "ImplementationGuide.status",                                                                                 // MakerGen.cs:231
                        Id = "ImplementationGuide.status",                                                                                  // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. ImplementationGuide.experimental
                    this.Experimental = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Experimental",                                                                                              // MakerGen.cs:230
                        Path= "ImplementationGuide.experimental",                                                                           // MakerGen.cs:231
                        Id = "ImplementationGuide.experimental",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. ImplementationGuide.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Date",                                                                                                      // MakerGen.cs:230
                        Path= "ImplementationGuide.date",                                                                                   // MakerGen.cs:231
                        Id = "ImplementationGuide.date",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. ImplementationGuide.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Publisher",                                                                                                 // MakerGen.cs:230
                        Path= "ImplementationGuide.publisher",                                                                              // MakerGen.cs:231
                        Id = "ImplementationGuide.publisher",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. ImplementationGuide.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Contact",                                                                                                   // MakerGen.cs:230
                        Path= "ImplementationGuide.contact",                                                                                // MakerGen.cs:231
                        Id = "ImplementationGuide.contact",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. ImplementationGuide.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Description",                                                                                               // MakerGen.cs:230
                        Path= "ImplementationGuide.description",                                                                            // MakerGen.cs:231
                        Id = "ImplementationGuide.description",                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. ImplementationGuide.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "UseContext",                                                                                                // MakerGen.cs:230
                        Path= "ImplementationGuide.useContext",                                                                             // MakerGen.cs:231
                        Id = "ImplementationGuide.useContext",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.UsageContext                                                                  // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. ImplementationGuide.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:230
                        Path= "ImplementationGuide.jurisdiction",                                                                           // MakerGen.cs:231
                        Id = "ImplementationGuide.jurisdiction",                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. ImplementationGuide.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Copyright",                                                                                                 // MakerGen.cs:230
                        Path= "ImplementationGuide.copyright",                                                                              // MakerGen.cs:231
                        Id = "ImplementationGuide.copyright",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. ImplementationGuide.packageId
                    this.PackageId = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "PackageId",                                                                                                 // MakerGen.cs:230
                        Path= "ImplementationGuide.packageId",                                                                              // MakerGen.cs:231
                        Id = "ImplementationGuide.packageId",                                                                               // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Id                                                                          // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 15. ImplementationGuide.license
                    this.License = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "License",                                                                                                   // MakerGen.cs:230
                        Path= "ImplementationGuide.license",                                                                                // MakerGen.cs:231
                        Id = "ImplementationGuide.license",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. ImplementationGuide.fhirVersion
                    this.FhirVersion = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "FhirVersion",                                                                                               // MakerGen.cs:230
                        Path= "ImplementationGuide.fhirVersion",                                                                            // MakerGen.cs:231
                        Id = "ImplementationGuide.fhirVersion",                                                                             // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 17. ImplementationGuide.dependsOn
                    this.DependsOn = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "DependsOn",                                                                                                 // MakerGen.cs:230
                        Path= "ImplementationGuide.dependsOn",                                                                              // MakerGen.cs:231
                        Id = "ImplementationGuide.dependsOn",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_DependsOn                                                                                              // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 21. ImplementationGuide.global
                    this.Global = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Global",                                                                                                    // MakerGen.cs:230
                        Path= "ImplementationGuide.global",                                                                                 // MakerGen.cs:231
                        Id = "ImplementationGuide.global",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Global                                                                                                 // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 24. ImplementationGuide.definition
                    this.Definition = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Definition",                                                                                                // MakerGen.cs:230
                        Path= "ImplementationGuide.definition",                                                                             // MakerGen.cs:231
                        Id = "ImplementationGuide.definition",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Definition                                                                                             // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 47. ImplementationGuide.manifest
                    this.Manifest = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Manifest",                                                                                                  // MakerGen.cs:230
                        Path= "ImplementationGuide.manifest",                                                                               // MakerGen.cs:231
                        Id = "ImplementationGuide.manifest",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Manifest                                                                                               // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Url.Write(sDef);                                                                                                            // MakerGen.cs:215
                Version.Write(sDef);                                                                                                        // MakerGen.cs:215
                Name.Write(sDef);                                                                                                           // MakerGen.cs:215
                Title.Write(sDef);                                                                                                          // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                Experimental.Write(sDef);                                                                                                   // MakerGen.cs:215
                Date.Write(sDef);                                                                                                           // MakerGen.cs:215
                Publisher.Write(sDef);                                                                                                      // MakerGen.cs:215
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:215
                Description.Write(sDef);                                                                                                    // MakerGen.cs:215
                UseContext.Write(sDef);                                                                                                     // MakerGen.cs:215
                Jurisdiction.Write(sDef);                                                                                                   // MakerGen.cs:215
                Copyright.Write(sDef);                                                                                                      // MakerGen.cs:215
                PackageId.Write(sDef);                                                                                                      // MakerGen.cs:215
                License.Write(sDef);                                                                                                        // MakerGen.cs:215
                FhirVersion.Write(sDef);                                                                                                    // MakerGen.cs:215
                DependsOn.Write(sDef);                                                                                                      // MakerGen.cs:215
                Global.Write(sDef);                                                                                                         // MakerGen.cs:215
                Definition.Write(sDef);                                                                                                     // MakerGen.cs:215
                Manifest.Write(sDef);                                                                                                       // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public ImplementationGuide_Elements Elements                                                                                        // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new ImplementationGuide_Elements();                                                                     // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        ImplementationGuide_Elements elements;                                                                                              // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public ImplementationGuide()                                                                                                        // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "ImplementationGuide";                                                                                              // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ImplementationGuide";                                                       // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "ImplementationGuide",                                                                                               // MakerGen.cs:423
                ElementId = "ImplementationGuide"                                                                                           // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
