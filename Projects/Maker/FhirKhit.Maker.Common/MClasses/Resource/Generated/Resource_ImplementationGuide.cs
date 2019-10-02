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
    #endregion
    /// <summary>
    /// Fhir resource 'ImplementationGuide'
    /// </summary>
    // 0. ImplementationGuide
    public class Resource_ImplementationGuide : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 17. ImplementationGuide.dependsOn
        public class Type_DependsOn : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 18. ImplementationGuide.dependsOn.uri
            public ElementDefinitionInfo Element_Uri;
            // 19. ImplementationGuide.dependsOn.packageId
            public ElementDefinitionInfo Element_PackageId;
            // 20. ImplementationGuide.dependsOn.version
            public ElementDefinitionInfo Element_Version;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ImplementationGuide.dependsOn",
                    ElementId = "ImplementationGuide.dependsOn"
                });
                Element_Uri.Write(sDef);
                Element_PackageId.Write(sDef);
                Element_Version.Write(sDef);
            }
            
            public Type_DependsOn()
            {
                {
                    // 18. ImplementationGuide.dependsOn.uri
                    this.Element_Uri = new ElementDefinitionInfo
                    {
                        Name = "Element_Uri",
                        Path= "ImplementationGuide.dependsOn.uri",
                        Id = "ImplementationGuide.dependsOn.uri",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/ImplementationGuide"
                                }
                            }
                        }
                    };
                }
                {
                    // 19. ImplementationGuide.dependsOn.packageId
                    this.Element_PackageId = new ElementDefinitionInfo
                    {
                        Name = "Element_PackageId",
                        Path= "ImplementationGuide.dependsOn.packageId",
                        Id = "ImplementationGuide.dependsOn.packageId",
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
                    // 20. ImplementationGuide.dependsOn.version
                    this.Element_Version = new ElementDefinitionInfo
                    {
                        Name = "Element_Version",
                        Path= "ImplementationGuide.dependsOn.version",
                        Id = "ImplementationGuide.dependsOn.version",
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
        // 21. ImplementationGuide.global
        public class Type_Global : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 22. ImplementationGuide.global.type
            public ElementDefinitionInfo Element_Type;
            // 23. ImplementationGuide.global.profile
            public ElementDefinitionInfo Element_Profile;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ImplementationGuide.global",
                    ElementId = "ImplementationGuide.global"
                });
                Element_Type.Write(sDef);
                Element_Profile.Write(sDef);
            }
            
            public Type_Global()
            {
                {
                    // 22. ImplementationGuide.global.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "ImplementationGuide.global.type",
                        Id = "ImplementationGuide.global.type",
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
                    // 23. ImplementationGuide.global.profile
                    this.Element_Profile = new ElementDefinitionInfo
                    {
                        Name = "Element_Profile",
                        Path= "ImplementationGuide.global.profile",
                        Id = "ImplementationGuide.global.profile",
                        Min = 1,
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
            }
        }
        // 24. ImplementationGuide.definition
        public class Type_Definition : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 25. ImplementationGuide.definition.grouping
            public class Type_Grouping : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 26. ImplementationGuide.definition.grouping.name
                public ElementDefinitionInfo Element_Name;
                // 27. ImplementationGuide.definition.grouping.description
                public ElementDefinitionInfo Element_Description;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ImplementationGuide.definition.grouping",
                        ElementId = "ImplementationGuide.definition.grouping"
                    });
                    Element_Name.Write(sDef);
                    Element_Description.Write(sDef);
                }
                
                public Type_Grouping()
                {
                    {
                        // 26. ImplementationGuide.definition.grouping.name
                        this.Element_Name = new ElementDefinitionInfo
                        {
                            Name = "Element_Name",
                            Path= "ImplementationGuide.definition.grouping.name",
                            Id = "ImplementationGuide.definition.grouping.name",
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
                        // 27. ImplementationGuide.definition.grouping.description
                        this.Element_Description = new ElementDefinitionInfo
                        {
                            Name = "Element_Description",
                            Path= "ImplementationGuide.definition.grouping.description",
                            Id = "ImplementationGuide.definition.grouping.description",
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
            // 28. ImplementationGuide.definition.resource
            public class Type_Resource : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 29. ImplementationGuide.definition.resource.reference
                public ElementDefinitionInfo Element_Reference;
                // 30. ImplementationGuide.definition.resource.fhirVersion
                public ElementDefinitionInfo Element_FhirVersion;
                // 31. ImplementationGuide.definition.resource.name
                public ElementDefinitionInfo Element_Name;
                // 32. ImplementationGuide.definition.resource.description
                public ElementDefinitionInfo Element_Description;
                // 33. ImplementationGuide.definition.resource.example[x]
                public ElementDefinitionInfo Element_Example;
                // 34. ImplementationGuide.definition.resource.groupingId
                public ElementDefinitionInfo Element_GroupingId;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ImplementationGuide.definition.resource",
                        ElementId = "ImplementationGuide.definition.resource"
                    });
                    Element_Reference.Write(sDef);
                    Element_FhirVersion.Write(sDef);
                    Element_Name.Write(sDef);
                    Element_Description.Write(sDef);
                    Element_Example.Write(sDef);
                    Element_GroupingId.Write(sDef);
                }
                
                public Type_Resource()
                {
                    {
                        // 29. ImplementationGuide.definition.resource.reference
                        this.Element_Reference = new ElementDefinitionInfo
                        {
                            Name = "Element_Reference",
                            Path= "ImplementationGuide.definition.resource.reference",
                            Id = "ImplementationGuide.definition.resource.reference",
                            Min = 1,
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
                    {
                        // 30. ImplementationGuide.definition.resource.fhirVersion
                        this.Element_FhirVersion = new ElementDefinitionInfo
                        {
                            Name = "Element_FhirVersion",
                            Path= "ImplementationGuide.definition.resource.fhirVersion",
                            Id = "ImplementationGuide.definition.resource.fhirVersion",
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
                        // 31. ImplementationGuide.definition.resource.name
                        this.Element_Name = new ElementDefinitionInfo
                        {
                            Name = "Element_Name",
                            Path= "ImplementationGuide.definition.resource.name",
                            Id = "ImplementationGuide.definition.resource.name",
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
                        // 32. ImplementationGuide.definition.resource.description
                        this.Element_Description = new ElementDefinitionInfo
                        {
                            Name = "Element_Description",
                            Path= "ImplementationGuide.definition.resource.description",
                            Id = "ImplementationGuide.definition.resource.description",
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
                        // 33. ImplementationGuide.definition.resource.example[x]
                        this.Element_Example = new ElementDefinitionInfo
                        {
                            Name = "Element_Example",
                            Path= "ImplementationGuide.definition.resource.example[x]",
                            Id = "ImplementationGuide.definition.resource.example[x]",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                                {
                                },
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
                        // 34. ImplementationGuide.definition.resource.groupingId
                        this.Element_GroupingId = new ElementDefinitionInfo
                        {
                            Name = "Element_GroupingId",
                            Path= "ImplementationGuide.definition.resource.groupingId",
                            Id = "ImplementationGuide.definition.resource.groupingId",
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
            // 35. ImplementationGuide.definition.page
            public class Type_Page : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 36. ImplementationGuide.definition.page.name[x]
                public ElementDefinitionInfo Element_Name;
                // 37. ImplementationGuide.definition.page.title
                public ElementDefinitionInfo Element_Title;
                // 38. ImplementationGuide.definition.page.generation
                public ElementDefinitionInfo Element_Generation;
                // 39. ImplementationGuide.definition.page.page
                public ElementDefinitionInfo Element_Page;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ImplementationGuide.definition.page",
                        ElementId = "ImplementationGuide.definition.page"
                    });
                    Element_Name.Write(sDef);
                    Element_Title.Write(sDef);
                    Element_Generation.Write(sDef);
                    Element_Page.Write(sDef);
                }
                
                public Type_Page()
                {
                    {
                        // 36. ImplementationGuide.definition.page.name[x]
                        this.Element_Name = new ElementDefinitionInfo
                        {
                            Name = "Element_Name",
                            Path= "ImplementationGuide.definition.page.name[x]",
                            Id = "ImplementationGuide.definition.page.name[x]",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Url
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Reference
                                {
                                    TargetProfile = new String[]
                                    {
                                        "http://hl7.org/fhir/StructureDefinition/Binary"
                                    }
                                }
                            }
                        };
                    }
                    {
                        // 37. ImplementationGuide.definition.page.title
                        this.Element_Title = new ElementDefinitionInfo
                        {
                            Name = "Element_Title",
                            Path= "ImplementationGuide.definition.page.title",
                            Id = "ImplementationGuide.definition.page.title",
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
                        // 38. ImplementationGuide.definition.page.generation
                        this.Element_Generation = new ElementDefinitionInfo
                        {
                            Name = "Element_Generation",
                            Path= "ImplementationGuide.definition.page.generation",
                            Id = "ImplementationGuide.definition.page.generation",
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
                        // 39. ImplementationGuide.definition.page.page
                        this.Element_Page = new ElementDefinitionInfo
                        {
                            Name = "Element_Page",
                            Path= "ImplementationGuide.definition.page.page",
                            Id = "ImplementationGuide.definition.page.page",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                }
            }
            // 40. ImplementationGuide.definition.parameter
            public class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 41. ImplementationGuide.definition.parameter.code
                public ElementDefinitionInfo Element_Code;
                // 42. ImplementationGuide.definition.parameter.value
                public ElementDefinitionInfo Element_Value;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ImplementationGuide.definition.parameter",
                        ElementId = "ImplementationGuide.definition.parameter"
                    });
                    Element_Code.Write(sDef);
                    Element_Value.Write(sDef);
                }
                
                public Type_Parameter()
                {
                    {
                        // 41. ImplementationGuide.definition.parameter.code
                        this.Element_Code = new ElementDefinitionInfo
                        {
                            Name = "Element_Code",
                            Path= "ImplementationGuide.definition.parameter.code",
                            Id = "ImplementationGuide.definition.parameter.code",
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
                        // 42. ImplementationGuide.definition.parameter.value
                        this.Element_Value = new ElementDefinitionInfo
                        {
                            Name = "Element_Value",
                            Path= "ImplementationGuide.definition.parameter.value",
                            Id = "ImplementationGuide.definition.parameter.value",
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
            // 43. ImplementationGuide.definition.template
            public class Type_Template : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 44. ImplementationGuide.definition.template.code
                public ElementDefinitionInfo Element_Code;
                // 45. ImplementationGuide.definition.template.source
                public ElementDefinitionInfo Element_Source;
                // 46. ImplementationGuide.definition.template.scope
                public ElementDefinitionInfo Element_Scope;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ImplementationGuide.definition.template",
                        ElementId = "ImplementationGuide.definition.template"
                    });
                    Element_Code.Write(sDef);
                    Element_Source.Write(sDef);
                    Element_Scope.Write(sDef);
                }
                
                public Type_Template()
                {
                    {
                        // 44. ImplementationGuide.definition.template.code
                        this.Element_Code = new ElementDefinitionInfo
                        {
                            Name = "Element_Code",
                            Path= "ImplementationGuide.definition.template.code",
                            Id = "ImplementationGuide.definition.template.code",
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
                        // 45. ImplementationGuide.definition.template.source
                        this.Element_Source = new ElementDefinitionInfo
                        {
                            Name = "Element_Source",
                            Path= "ImplementationGuide.definition.template.source",
                            Id = "ImplementationGuide.definition.template.source",
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
                        // 46. ImplementationGuide.definition.template.scope
                        this.Element_Scope = new ElementDefinitionInfo
                        {
                            Name = "Element_Scope",
                            Path= "ImplementationGuide.definition.template.scope",
                            Id = "ImplementationGuide.definition.template.scope",
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
            // 25. ImplementationGuide.definition.grouping
            public ElementDefinitionInfo Element_Grouping;
            // 28. ImplementationGuide.definition.resource
            public ElementDefinitionInfo Element_Resource;
            // 35. ImplementationGuide.definition.page
            public ElementDefinitionInfo Element_Page;
            // 40. ImplementationGuide.definition.parameter
            public ElementDefinitionInfo Element_Parameter;
            // 43. ImplementationGuide.definition.template
            public ElementDefinitionInfo Element_Template;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ImplementationGuide.definition",
                    ElementId = "ImplementationGuide.definition"
                });
                Element_Grouping.Write(sDef);
                Element_Resource.Write(sDef);
                Element_Page.Write(sDef);
                Element_Parameter.Write(sDef);
                Element_Template.Write(sDef);
            }
            
            public Type_Definition()
            {
                {
                    // 25. ImplementationGuide.definition.grouping
                    this.Element_Grouping = new ElementDefinitionInfo
                    {
                        Name = "Element_Grouping",
                        Path= "ImplementationGuide.definition.grouping",
                        Id = "ImplementationGuide.definition.grouping",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Grouping
                            {
                            }
                        }
                    };
                }
                {
                    // 28. ImplementationGuide.definition.resource
                    this.Element_Resource = new ElementDefinitionInfo
                    {
                        Name = "Element_Resource",
                        Path= "ImplementationGuide.definition.resource",
                        Id = "ImplementationGuide.definition.resource",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Resource
                            {
                            }
                        }
                    };
                }
                {
                    // 35. ImplementationGuide.definition.page
                    this.Element_Page = new ElementDefinitionInfo
                    {
                        Name = "Element_Page",
                        Path= "ImplementationGuide.definition.page",
                        Id = "ImplementationGuide.definition.page",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new Type_Page
                            {
                            }
                        }
                    };
                }
                {
                    // 40. ImplementationGuide.definition.parameter
                    this.Element_Parameter = new ElementDefinitionInfo
                    {
                        Name = "Element_Parameter",
                        Path= "ImplementationGuide.definition.parameter",
                        Id = "ImplementationGuide.definition.parameter",
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
                    // 43. ImplementationGuide.definition.template
                    this.Element_Template = new ElementDefinitionInfo
                    {
                        Name = "Element_Template",
                        Path= "ImplementationGuide.definition.template",
                        Id = "ImplementationGuide.definition.template",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Template
                            {
                            }
                        }
                    };
                }
            }
        }
        // 47. ImplementationGuide.manifest
        public class Type_Manifest : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 49. ImplementationGuide.manifest.resource
            public class Type_Resource : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 50. ImplementationGuide.manifest.resource.reference
                public ElementDefinitionInfo Element_Reference;
                // 51. ImplementationGuide.manifest.resource.example[x]
                public ElementDefinitionInfo Element_Example;
                // 52. ImplementationGuide.manifest.resource.relativePath
                public ElementDefinitionInfo Element_RelativePath;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ImplementationGuide.manifest.resource",
                        ElementId = "ImplementationGuide.manifest.resource"
                    });
                    Element_Reference.Write(sDef);
                    Element_Example.Write(sDef);
                    Element_RelativePath.Write(sDef);
                }
                
                public Type_Resource()
                {
                    {
                        // 50. ImplementationGuide.manifest.resource.reference
                        this.Element_Reference = new ElementDefinitionInfo
                        {
                            Name = "Element_Reference",
                            Path= "ImplementationGuide.manifest.resource.reference",
                            Id = "ImplementationGuide.manifest.resource.reference",
                            Min = 1,
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
                    {
                        // 51. ImplementationGuide.manifest.resource.example[x]
                        this.Element_Example = new ElementDefinitionInfo
                        {
                            Name = "Element_Example",
                            Path= "ImplementationGuide.manifest.resource.example[x]",
                            Id = "ImplementationGuide.manifest.resource.example[x]",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                                {
                                },
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
                        // 52. ImplementationGuide.manifest.resource.relativePath
                        this.Element_RelativePath = new ElementDefinitionInfo
                        {
                            Name = "Element_RelativePath",
                            Path= "ImplementationGuide.manifest.resource.relativePath",
                            Id = "ImplementationGuide.manifest.resource.relativePath",
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
            // 53. ImplementationGuide.manifest.page
            public class Type_Page : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 54. ImplementationGuide.manifest.page.name
                public ElementDefinitionInfo Element_Name;
                // 55. ImplementationGuide.manifest.page.title
                public ElementDefinitionInfo Element_Title;
                // 56. ImplementationGuide.manifest.page.anchor
                public ElementDefinitionInfo Element_Anchor;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ImplementationGuide.manifest.page",
                        ElementId = "ImplementationGuide.manifest.page"
                    });
                    Element_Name.Write(sDef);
                    Element_Title.Write(sDef);
                    Element_Anchor.Write(sDef);
                }
                
                public Type_Page()
                {
                    {
                        // 54. ImplementationGuide.manifest.page.name
                        this.Element_Name = new ElementDefinitionInfo
                        {
                            Name = "Element_Name",
                            Path= "ImplementationGuide.manifest.page.name",
                            Id = "ImplementationGuide.manifest.page.name",
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
                        // 55. ImplementationGuide.manifest.page.title
                        this.Element_Title = new ElementDefinitionInfo
                        {
                            Name = "Element_Title",
                            Path= "ImplementationGuide.manifest.page.title",
                            Id = "ImplementationGuide.manifest.page.title",
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
                        // 56. ImplementationGuide.manifest.page.anchor
                        this.Element_Anchor = new ElementDefinitionInfo
                        {
                            Name = "Element_Anchor",
                            Path= "ImplementationGuide.manifest.page.anchor",
                            Id = "ImplementationGuide.manifest.page.anchor",
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
                }
            }
            // 48. ImplementationGuide.manifest.rendering
            public ElementDefinitionInfo Element_Rendering;
            // 49. ImplementationGuide.manifest.resource
            public ElementDefinitionInfo Element_Resource;
            // 53. ImplementationGuide.manifest.page
            public ElementDefinitionInfo Element_Page;
            // 57. ImplementationGuide.manifest.image
            public ElementDefinitionInfo Element_Image;
            // 58. ImplementationGuide.manifest.other
            public ElementDefinitionInfo Element_Other;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ImplementationGuide.manifest",
                    ElementId = "ImplementationGuide.manifest"
                });
                Element_Rendering.Write(sDef);
                Element_Resource.Write(sDef);
                Element_Page.Write(sDef);
                Element_Image.Write(sDef);
                Element_Other.Write(sDef);
            }
            
            public Type_Manifest()
            {
                {
                    // 48. ImplementationGuide.manifest.rendering
                    this.Element_Rendering = new ElementDefinitionInfo
                    {
                        Name = "Element_Rendering",
                        Path= "ImplementationGuide.manifest.rendering",
                        Id = "ImplementationGuide.manifest.rendering",
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
                {
                    // 49. ImplementationGuide.manifest.resource
                    this.Element_Resource = new ElementDefinitionInfo
                    {
                        Name = "Element_Resource",
                        Path= "ImplementationGuide.manifest.resource",
                        Id = "ImplementationGuide.manifest.resource",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Resource
                            {
                            }
                        }
                    };
                }
                {
                    // 53. ImplementationGuide.manifest.page
                    this.Element_Page = new ElementDefinitionInfo
                    {
                        Name = "Element_Page",
                        Path= "ImplementationGuide.manifest.page",
                        Id = "ImplementationGuide.manifest.page",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Page
                            {
                            }
                        }
                    };
                }
                {
                    // 57. ImplementationGuide.manifest.image
                    this.Element_Image = new ElementDefinitionInfo
                    {
                        Name = "Element_Image",
                        Path= "ImplementationGuide.manifest.image",
                        Id = "ImplementationGuide.manifest.image",
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
                    // 58. ImplementationGuide.manifest.other
                    this.Element_Other = new ElementDefinitionInfo
                    {
                        Name = "Element_Other",
                        Path= "ImplementationGuide.manifest.other",
                        Id = "ImplementationGuide.manifest.other",
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
            }
        }
        // 1. ImplementationGuide.url
        public ElementDefinitionInfo Element_Url;
        // 2. ImplementationGuide.version
        public ElementDefinitionInfo Element_Version;
        // 3. ImplementationGuide.name
        public ElementDefinitionInfo Element_Name;
        // 4. ImplementationGuide.title
        public ElementDefinitionInfo Element_Title;
        // 5. ImplementationGuide.status
        public ElementDefinitionInfo Element_Status;
        // 6. ImplementationGuide.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 7. ImplementationGuide.date
        public ElementDefinitionInfo Element_Date;
        // 8. ImplementationGuide.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 9. ImplementationGuide.contact
        public ElementDefinitionInfo Element_Contact;
        // 10. ImplementationGuide.description
        public ElementDefinitionInfo Element_Description;
        // 11. ImplementationGuide.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 12. ImplementationGuide.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 13. ImplementationGuide.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 14. ImplementationGuide.packageId
        public ElementDefinitionInfo Element_PackageId;
        // 15. ImplementationGuide.license
        public ElementDefinitionInfo Element_License;
        // 16. ImplementationGuide.fhirVersion
        public ElementDefinitionInfo Element_FhirVersion;
        // 17. ImplementationGuide.dependsOn
        public ElementDefinitionInfo Element_DependsOn;
        // 21. ImplementationGuide.global
        public ElementDefinitionInfo Element_Global;
        // 24. ImplementationGuide.definition
        public ElementDefinitionInfo Element_Definition;
        // 47. ImplementationGuide.manifest
        public ElementDefinitionInfo Element_Manifest;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ImplementationGuide",
                ElementId = "ImplementationGuide"
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
            Element_Copyright.Write(sDef);
            Element_PackageId.Write(sDef);
            Element_License.Write(sDef);
            Element_FhirVersion.Write(sDef);
            Element_DependsOn.Write(sDef);
            Element_Global.Write(sDef);
            Element_Definition.Write(sDef);
            Element_Manifest.Write(sDef);
        }
        
        public Resource_ImplementationGuide()
        {
            {
                // 1. ImplementationGuide.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "ImplementationGuide.url",
                    Id = "ImplementationGuide.url",
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
                // 2. ImplementationGuide.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "ImplementationGuide.version",
                    Id = "ImplementationGuide.version",
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
                // 3. ImplementationGuide.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "ImplementationGuide.name",
                    Id = "ImplementationGuide.name",
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
                // 4. ImplementationGuide.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "ImplementationGuide.title",
                    Id = "ImplementationGuide.title",
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
                // 5. ImplementationGuide.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ImplementationGuide.status",
                    Id = "ImplementationGuide.status",
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
                // 6. ImplementationGuide.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "ImplementationGuide.experimental",
                    Id = "ImplementationGuide.experimental",
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
                // 7. ImplementationGuide.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "ImplementationGuide.date",
                    Id = "ImplementationGuide.date",
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
                // 8. ImplementationGuide.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "ImplementationGuide.publisher",
                    Id = "ImplementationGuide.publisher",
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
                // 9. ImplementationGuide.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "ImplementationGuide.contact",
                    Id = "ImplementationGuide.contact",
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
                // 10. ImplementationGuide.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "ImplementationGuide.description",
                    Id = "ImplementationGuide.description",
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
                // 11. ImplementationGuide.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "ImplementationGuide.useContext",
                    Id = "ImplementationGuide.useContext",
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
                // 12. ImplementationGuide.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "ImplementationGuide.jurisdiction",
                    Id = "ImplementationGuide.jurisdiction",
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
                // 13. ImplementationGuide.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "ImplementationGuide.copyright",
                    Id = "ImplementationGuide.copyright",
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
                // 14. ImplementationGuide.packageId
                this.Element_PackageId = new ElementDefinitionInfo
                {
                    Name = "Element_PackageId",
                    Path= "ImplementationGuide.packageId",
                    Id = "ImplementationGuide.packageId",
                    Min = 1,
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
                // 15. ImplementationGuide.license
                this.Element_License = new ElementDefinitionInfo
                {
                    Name = "Element_License",
                    Path= "ImplementationGuide.license",
                    Id = "ImplementationGuide.license",
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
                // 16. ImplementationGuide.fhirVersion
                this.Element_FhirVersion = new ElementDefinitionInfo
                {
                    Name = "Element_FhirVersion",
                    Path= "ImplementationGuide.fhirVersion",
                    Id = "ImplementationGuide.fhirVersion",
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
            {
                // 17. ImplementationGuide.dependsOn
                this.Element_DependsOn = new ElementDefinitionInfo
                {
                    Name = "Element_DependsOn",
                    Path= "ImplementationGuide.dependsOn",
                    Id = "ImplementationGuide.dependsOn",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_DependsOn
                        {
                        }
                    }
                };
            }
            {
                // 21. ImplementationGuide.global
                this.Element_Global = new ElementDefinitionInfo
                {
                    Name = "Element_Global",
                    Path= "ImplementationGuide.global",
                    Id = "ImplementationGuide.global",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Global
                        {
                        }
                    }
                };
            }
            {
                // 24. ImplementationGuide.definition
                this.Element_Definition = new ElementDefinitionInfo
                {
                    Name = "Element_Definition",
                    Path= "ImplementationGuide.definition",
                    Id = "ImplementationGuide.definition",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Definition
                        {
                        }
                    }
                };
            }
            {
                // 47. ImplementationGuide.manifest
                this.Element_Manifest = new ElementDefinitionInfo
                {
                    Name = "Element_Manifest",
                    Path= "ImplementationGuide.manifest",
                    Id = "ImplementationGuide.manifest",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Manifest
                        {
                        }
                    }
                };
            }
            this.Name = "ImplementationGuide";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ImplementationGuide";
        }
    }
}
