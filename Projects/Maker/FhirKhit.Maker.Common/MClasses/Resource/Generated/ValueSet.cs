using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
    {
      "resourceType": "StructureDefinition",
      "id": "ValueSet",
      "url": "http://hl7.org/fhir/StructureDefinition/ValueSet",
      "version": "4.0.0",
      "name": "ValueSet",
      "status": "active",
      "publisher": "Health Level Seven International (Vocabulary)",
      "description": "A ValueSet resource instance specifies a set of codes drawn from one or more code systems, intended for use in a particular context. Value sets link between [[[CodeSystem]]] definitions and their use in [coded elements](terminologies.html).",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ValueSet",
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
            "id": "ValueSet",
            "path": "ValueSet",
            "short": "A set of codes drawn from one or more code systems",
            "definition": "A ValueSet resource instance specifies a set of codes drawn from one or more code systems, intended for use in a particular context. Value sets link between [CodeSystem](codesystem.html) definitions and their use in [coded elements](terminologies.html).",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ValueSet.url",
            "path": "ValueSet.url",
            "short": "Canonical identifier for this value set, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this value set when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this value set is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the value set is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the value set to be referenced by a single globally unique identifier.",
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
            "id": "ValueSet.identifier",
            "path": "ValueSet.identifier",
            "short": "Additional identifier for the value set (business identifier)",
            "definition": "A formal identifier that is used to identify this value set when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this value set outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "ValueSet.version",
            "path": "ValueSet.version",
            "short": "Business version of the value set",
            "definition": "The identifier that is used to identify this version of the value set when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the value set author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different value set instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the value set with the format [url]|[version].",
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
            "id": "ValueSet.name",
            "path": "ValueSet.name",
            "short": "Name for this value set (computer friendly)",
            "definition": "A natural language name identifying the value set. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
            "comment": "The name is not expected to be globally unique. The name should be a simple alphanumeric type name to ensure that it is machine-processing friendly.A name should be provided unless the value set is a contained resource (e.g. an anonymous value set in a profile). Most registries will require a name.",
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
            "id": "ValueSet.title",
            "path": "ValueSet.title",
            "short": "Name for this value set (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the value set.",
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
            "id": "ValueSet.status",
            "path": "ValueSet.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this value set. Enables tracking the life-cycle of the content. The status of the value set applies to the value set definition (ValueSet.compose) and the associated ValueSet metadata. Expansions do not have a state.",
            "comment": "Allows filtering of value sets that are appropriate for use versus not.See also the [valueset-workflowStatus](extension-valueset-workflowstatus.html) extension for additional status information related to the editorial process.",
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
            "id": "ValueSet.experimental",
            "path": "ValueSet.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this value set is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of value sets that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level value set.",
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
            "id": "ValueSet.date",
            "path": "ValueSet.date",
            "short": "Date last changed",
            "definition": "The date (and optionally time) when the value set was created or revised (e.g. the 'content logical definition').",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the value set. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "ValueSet.publisher",
            "path": "ValueSet.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the value set.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the value set is the organization or individual primarily responsible for the maintenance and upkeep of the value set. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the value set. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the value set.  May also allow for contact.",
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
            "id": "ValueSet.contact",
            "path": "ValueSet.contact",
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
            "id": "ValueSet.description",
            "path": "ValueSet.description",
            "short": "Natural language description of the value set",
            "definition": "A free text natural language description of the value set from a consumer's perspective. The textual description specifies the span of meanings for concepts to be included within the Value Set Expansion, and also may specify the intended use and limitations of the Value Set.",
            "comment": "This description can be used to capture details such as why the value set was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the value set as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the value set is presumed to be the predominant language in the place the value set was created).The description is not intended to describe the semantics of the Value Set - there are no intrinsic semantics separate from the codes contained in its expansion. The description should capture its intended use, which is needed for ensuring integrity for its use in models across future changes. A description should be provided unless the value set is a contained resource (e.g. an anonymous value set in a profile). Most registries will require a description.",
            "alias": [
              "Scope",
              "Purpose"
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
            "id": "ValueSet.useContext",
            "path": "ValueSet.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate value set instances.",
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
            "id": "ValueSet.jurisdiction",
            "path": "ValueSet.jurisdiction",
            "short": "Intended jurisdiction for value set (if applicable)",
            "definition": "A legal or geographic region in which the value set is intended to be used.",
            "comment": "It may be possible for the value set to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "ValueSet.immutable",
            "path": "ValueSet.immutable",
            "short": "Indicates whether or not any change to the content logical definition may occur",
            "definition": "If this is set to 'true', then no new versions of the content logical definition can be created.  Note: Other metadata might still change.",
            "comment": "Normally immutability is set to 'false', which is the default assumption if it is not populated.  Note that the implication is that if this is set to 'true', there may be only one ValueSet version for this definition. Immutability tends to be set to 'true' in one of two cases: - Where the value set, by the nature of its usage, cannot change.  For example \"All specializations of ACT in ActClassCode\" - Where there's no safe way to express the \"Purpose\" such that someone else could safely make changes to the value set definition. Source workflow control must guarantee that the same URI always yields the same definition.",
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
            "id": "ValueSet.purpose",
            "path": "ValueSet.purpose",
            "short": "Why this value set is defined",
            "definition": "Explanation of why this value set is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the value set. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this value set.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ValueSet.copyright",
            "path": "ValueSet.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the value set and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the value set.",
            "comment": "nullFrequently, the copyright differs between the value set and the codes that are included. The copyright statement should clearly differentiate between these when required.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the value set and/or its content.",
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
            "id": "ValueSet.compose",
            "path": "ValueSet.compose",
            "short": "Content logical definition of the value set (CLD)",
            "definition": "A set of criteria that define the contents of the value set by including or excluding codes selected from the specified code system(s) that the value set draws from. This is also known as the Content Logical Definition (CLD).",
            "alias": [
              "Content Logical Definition",
              "CLD"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ValueSet.compose.lockedDate",
            "path": "ValueSet.compose.lockedDate",
            "short": "Fixed date for references with no specified version (transitive)",
            "definition": "The Locked Date is  the effective date that is used to determine the version of all referenced Code Systems and Value Set Definitions included in the compose that are not already tied to a specific version.",
            "comment": "With a defined lockedDate the value set is considered \"Locked\". Otherwise, the value set may have different expansions as underlying code systems and/or value sets evolve.  The interpretation of lockedDate is often dependent on the context - e.g. a SNOMED CT derived value set with a lockedDate will have a different expansion in USA than in UK.  If a value set specifies a version for include and exclude statements, and also specifies a locked date, the specified versions need to be available that date, or the value set will not be usable.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ValueSet.compose.inactive",
            "path": "ValueSet.compose.inactive",
            "short": "Whether inactive codes are in the value set",
            "definition": "Whether inactive codes - codes that are not approved for current use - are in the value set. If inactive = true, inactive codes are to be included in the expansion, if inactive = false, the inactive codes will not be included in the expansion. If absent, the behavior is determined by the implementation, or by the applicable $expand parameters (but generally, inactive codes would be expected to be included).",
            "comment": "Note that in the FHIR terminology framework, \"deprecated\" does not mean inactive, but in some code systems, e.g. LOINC, \"deprecated\" does mean inactive. Code systems should define what codes are considered to be inactive. If this is not clearly defined (including in the FHIR code system resource), then all codes are assumed to be active.\n\nThe Value Set Definition specification defines an ActiveOnly element, which is the reverse of this element e.g. (ValueSet.compose.inactive=FALSE) is the same as (VSD.ActiveOnly=TRUE).",
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
            "id": "ValueSet.compose.include",
            "path": "ValueSet.compose.include",
            "short": "Include one or more codes from a code system or other value set(s)",
            "definition": "Include one or more codes from a code system or other value set(s).",
            "comment": "All the conditions in an include must be true. If a system is listed, all the codes from the system are listed. If one or more filters are listed, all of the filters must apply. If one or more value sets are listed, the codes must be in all the value sets. E.g. each include is 'include all the codes that meet all these conditions'.",
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
            "id": "ValueSet.compose.include.system",
            "path": "ValueSet.compose.include.system",
            "short": "The system the codes come from",
            "definition": "An absolute URI which is the code system from which the selected codes come from.",
            "comment": "If there are no codes or filters, the entire code system is included. Note that the set of codes that are included may contain abstract codes. See ''Coding.system'' for further documentation about the correct value for the system element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "condition": [
              "vsd-1",
              "vsd-2"
            ],
            "isSummary": true
          },
          {
            "id": "ValueSet.compose.include.version",
            "path": "ValueSet.compose.include.version",
            "short": "Specific version of the code system referred to",
            "definition": "The version of the code system that the codes are selected from, or the special version '*' for all versions.",
            "comment": "This is used when selecting the descendants of a concept - they may change between versions. If no version is specified, then the exact contents of the value set might not be known until a context of use binds it to a particular version. The special value '*' means all versions; It is at server discretion regarding expansions and which versions must be supported.",
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
            "id": "ValueSet.compose.include.concept",
            "path": "ValueSet.compose.include.concept",
            "short": "A concept defined in the system",
            "definition": "Specifies a concept to be included or excluded.",
            "comment": "The list of concepts is considered ordered, though the order might not have any particular significance. Typically, the order of an expansion follows that defined in the compose element.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "vsd-3"
            ]
          },
          {
            "id": "ValueSet.compose.include.concept.code",
            "path": "ValueSet.compose.include.concept.code",
            "short": "Code or expression from system",
            "definition": "Specifies a code for the concept to be included or excluded.",
            "comment": "Expressions are allowed if defined by the underlying code system.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ]
          },
          {
            "id": "ValueSet.compose.include.concept.display",
            "path": "ValueSet.compose.include.concept.display",
            "short": "Text to display for this code for this value set in this valueset",
            "definition": "The text to display to the user for this concept in the context of this valueset. If no display is provided, then applications using the value set use the display specified for the code by the system.",
            "comment": "The value set resource allows for an alternative display to be specified for when this concept is used in this particular value set. See notes in the value set narrative about the correct use of this element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ValueSet.compose.include.concept.designation",
            "path": "ValueSet.compose.include.concept.designation",
            "short": "Additional representations for this concept",
            "definition": "Additional representations for this concept when used in this value set - other languages, aliases, specialized purposes, used for particular purposes, etc.",
            "comment": "Concepts have both a ```display``` and an array of ```designation```. The display is equivalent to a special designation with an implied ```designation.use``` of \"primary code\" and a language equal to the [Resource Language](resource.html#language).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ValueSet.compose.include.concept.designation.language",
            "path": "ValueSet.compose.include.concept.designation.language",
            "short": "Human language of the designation",
            "definition": "The language this designation is defined for.",
            "comment": "In the absence of a language, the resource language applies.",
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
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-maxValueSet",
                  "valueCanonical": "http://hl7.org/fhir/ValueSet/all-languages"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "Language"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "preferred",
              "description": "A human language.",
              "valueSet": "http://hl7.org/fhir/ValueSet/languages"
            }
          },
          {
            "id": "ValueSet.compose.include.concept.designation.use",
            "path": "ValueSet.compose.include.concept.designation.use",
            "short": "Types of uses of designations",
            "definition": "A code that represents types of uses of designations.",
            "comment": "If no use is provided, the designation can be assumed to be suitable for general display to a human user.",
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
                  "valueString": "ConceptDesignationUse"
                }
              ],
              "strength": "extensible",
              "description": "Details of how a designation would be used.",
              "valueSet": "http://hl7.org/fhir/ValueSet/designation-use"
            }
          },
          {
            "id": "ValueSet.compose.include.concept.designation.value",
            "path": "ValueSet.compose.include.concept.designation.value",
            "short": "The text value for this designation",
            "definition": "The text value for this designation.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ValueSet.compose.include.filter",
            "path": "ValueSet.compose.include.filter",
            "short": "Select codes/concepts by their properties (including relationships)",
            "definition": "Select concepts by specify a matching criterion based on the properties (including relationships) defined by the system, or on filters defined by the system. If multiple filters are specified, they SHALL all be true.",
            "comment": "Selecting codes by specifying filters based on properties is only possible where the underlying code system defines appropriate properties. Note that in some cases, the underlying code system defines the logical concepts but not the literal codes for the concepts. In such cases, the literal definitions may be provided by a third party.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "vsd-3"
            ],
            "isSummary": true
          },
          {
            "id": "ValueSet.compose.include.filter.property",
            "path": "ValueSet.compose.include.filter.property",
            "short": "A property/filter defined by the code system",
            "definition": "A code that identifies a property or a filter defined in the code system.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ValueSet.compose.include.filter.op",
            "path": "ValueSet.compose.include.filter.op",
            "short": "= | is-a | descendent-of | is-not-a | regex | in | not-in | generalizes | exists",
            "definition": "The kind of operation to perform as a part of the filter criteria.",
            "comment": "In case filter.property represents a property of the system, the operation applies to the selected property. In case filter.property represents a filter of the system, the operation SHALL match one of the CodeSystem.filter.operator values.",
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
                  "valueString": "FilterOperator"
                }
              ],
              "strength": "required",
              "description": "The kind of operation to perform as a part of a property based filter.",
              "valueSet": "http://hl7.org/fhir/ValueSet/filter-operator|4.0.0"
            }
          },
          {
            "id": "ValueSet.compose.include.filter.value",
            "path": "ValueSet.compose.include.filter.value",
            "short": "Code from the system, or regex criteria, or boolean value for exists",
            "definition": "The match value may be either a code defined by the system, or a string value, which is a regex match on the literal string of the property value  (if the filter represents a property defined in CodeSystem) or of the system filter value (if the filter represents a filter defined in CodeSystem) when the operation is 'regex', or one of the values (true and false), when the operation is 'exists'.",
            "comment": "Use regex matching with care - full regex matching on every SNOMED CT term is prohibitive, for example.",
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
            "id": "ValueSet.compose.include.valueSet",
            "path": "ValueSet.compose.include.valueSet",
            "short": "Select the contents included in this value set",
            "definition": "Selects the concepts found in this value set (based on its value set definition). This is an absolute URI that is a reference to ValueSet.url.  If multiple value sets are specified this includes the union of the contents of all of the referenced value sets.",
            "comment": "The value set URI is either a logical reference to a defined value set such as a [SNOMED CT reference set](snomedct.html#implicit), or a direct reference to a value set definition using ValueSet.url. The reference might not refer to an actual FHIR ValueSet resource; in this case, whatever is referred to is an implicit definition of a value set that needs to be clear about how versions are resolved.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ValueSet"
                ]
              }
            ],
            "condition": [
              "vsd-1"
            ],
            "isSummary": true
          },
          {
            "id": "ValueSet.compose.exclude",
            "path": "ValueSet.compose.exclude",
            "short": "Explicitly exclude codes from a code system or other value sets",
            "definition": "Exclude one or more codes from the value set based on code system filters and/or other value sets.",
            "comment": "Usually this is used to selectively exclude codes that were included by subsumption in the inclusions. Any display names specified for the codes are ignored.",
            "min": 0,
            "max": "*",
            "contentReference": "#ValueSet.compose.include",
            "condition": [
              "vsd-2"
            ]
          },
          {
            "id": "ValueSet.expansion",
            "path": "ValueSet.expansion",
            "short": "Used when the value set is \"expanded\"",
            "definition": "A value set can also be \"expanded\", where the value set is turned into a simple collection of enumerated codes. This element holds the expansion, if it has been performed.",
            "comment": "Expansion is performed to produce a collection of codes that are ready to use for data entry or validation. Value set expansions are always considered to be stateless - they are a record of the set of codes in the value set at a point in time under a given set of conditions, and are not subject to ongoing maintenance.\n\nExpansion.parameter is  a simplified list of parameters - a subset of the features of the [Parameters](parameters.html) resource.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ValueSet.expansion.identifier",
            "path": "ValueSet.expansion.identifier",
            "short": "Identifies the value set expansion (business identifier)",
            "definition": "An identifier that uniquely identifies this expansion of the valueset, based on a unique combination of the provided parameters, the system default parameters, and the underlying system code system versions etc. Systems may re-use the same identifier as long as those factors remain the same, and the expansion is the same, but are not required to do so. This is a business identifier.",
            "comment": "Typically, this uri is a UUID (e.g. urn:uuid:8230ff20-c97a-4167-a59d-dc2cb9df16dd).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "ValueSet.expansion.timestamp",
            "path": "ValueSet.expansion.timestamp",
            "short": "Time ValueSet expansion happened",
            "definition": "The time at which the expansion was produced by the expanding system.",
            "comment": "This SHOULD be a fully populated instant, but in some circumstances, value sets are expanded by hand, and the expansion is published without that precision.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "ValueSet.expansion.total",
            "path": "ValueSet.expansion.total",
            "short": "Total number of codes in the expansion",
            "definition": "The total number of concepts in the expansion. If the number of concept nodes in this resource is less than the stated number, then the server can return more using the offset parameter.",
            "comment": "Paging only applies to flat expansions.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "ValueSet.expansion.offset",
            "path": "ValueSet.expansion.offset",
            "short": "Offset at which this resource starts",
            "definition": "If paging is being used, the offset at which this resource starts.  I.e. this resource is a partial view into the expansion. If paging is not being used, this element SHALL NOT be present.",
            "comment": "Paging only applies to flat expansions. If a filter is applied, the count is the number of concepts that matched the filter, not the number of concepts in an unfiltered view of the expansion.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ],
            "meaningWhenMissing": "Paging is not being used"
          },
          {
            "id": "ValueSet.expansion.parameter",
            "path": "ValueSet.expansion.parameter",
            "short": "Parameter that controlled the expansion process",
            "definition": "A parameter that controlled the expansion process. These parameters may be used by users of expanded value sets to check whether the expansion is suitable for a particular purpose, or to pick the correct expansion.",
            "comment": "The server decides which parameters to include here, but at a minimum, the list SHOULD include all of the parameters that affect the $expand operation. If the expansion will be persisted all of these parameters SHALL be included. If the codeSystem on the server has a specified version then this version SHALL be provided as a parameter in the expansion (note that not all code systems have a version).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ValueSet.expansion.parameter.name",
            "path": "ValueSet.expansion.parameter.name",
            "short": "Name as assigned by the client or server",
            "definition": "Name of the input parameter to the $expand operation; may be a server-assigned name for additional default or other server-supplied parameters used to control the expansion process.",
            "comment": "The names are assigned at the discretion of the server.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ValueSet.expansion.parameter.value[x]",
            "path": "ValueSet.expansion.parameter.value[x]",
            "short": "Value of the named parameter",
            "definition": "The value of the parameter.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              },
              {
                "code": "boolean"
              },
              {
                "code": "integer"
              },
              {
                "code": "decimal"
              },
              {
                "code": "uri"
              },
              {
                "code": "code"
              },
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "ValueSet.expansion.contains",
            "path": "ValueSet.expansion.contains",
            "short": "Codes in the value set",
            "definition": "The codes that are contained in the value set expansion.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ValueSet.expansion.contains.system",
            "path": "ValueSet.expansion.contains.system",
            "short": "System value for the code",
            "definition": "An absolute URI which is the code system in which the code for this item in the expansion is defined.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "ValueSet.expansion.contains.abstract",
            "path": "ValueSet.expansion.contains.abstract",
            "short": "If user cannot select this entry",
            "definition": "If true, this entry is included in the expansion for navigational purposes, and the user cannot select the code directly as a proper value.",
            "comment": "This should not be understood to exclude its use for searching (e.g. by subsumption testing). The client should know whether it is appropriate for the user to select an abstract code or not.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "If this is not populated, systems can assume that the concept it not abstract. This SHALL always be populated for abstract concepts"
          },
          {
            "id": "ValueSet.expansion.contains.inactive",
            "path": "ValueSet.expansion.contains.inactive",
            "short": "If concept is inactive in the code system",
            "definition": "If the concept is inactive in the code system that defines it. Inactive codes are those that are no longer to be used, but are maintained by the code system for understanding legacy data. It might not be known or specified whether an concept is inactive (and it may depend on the context of use).",
            "comment": "This should only have a value if the concept is inactive.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ]
          },
          {
            "id": "ValueSet.expansion.contains.version",
            "path": "ValueSet.expansion.contains.version",
            "short": "Version in which this code/display is defined",
            "definition": "The version of the code system from this code was taken. Note that a well-maintained code system does not need the version reported, because the meaning of codes is consistent across versions. However this cannot consistently be assured, and when the meaning is not guaranteed to be consistent, the version SHOULD be exchanged.",
            "comment": "The exact value of the version string is specified by the system from which the code is derived.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ValueSet.expansion.contains.code",
            "path": "ValueSet.expansion.contains.code",
            "short": "Code - if blank, this is not a selectable code",
            "definition": "The code for this item in the expansion hierarchy. If this code is missing the entry in the hierarchy is a place holder (abstract) and does not represent a valid code in the value set.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "condition": [
              "vsd-6"
            ]
          },
          {
            "id": "ValueSet.expansion.contains.display",
            "path": "ValueSet.expansion.contains.display",
            "short": "User display for the concept",
            "definition": "The recommended display for this item in the expansion.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "vsd-6"
            ]
          },
          {
            "id": "ValueSet.expansion.contains.designation",
            "path": "ValueSet.expansion.contains.designation",
            "short": "Additional representations for this item",
            "definition": "Additional representations for this item - other languages, aliases, specialized purposes, used for particular purposes, etc. These are relevant when the conditions of the expansion do not fix to a single correct representation.",
            "comment": "The designations provided must be based on the value set and code system definitions.",
            "min": 0,
            "max": "*",
            "contentReference": "#ValueSet.compose.include.concept.designation"
          },
          {
            "id": "ValueSet.expansion.contains.contains",
            "path": "ValueSet.expansion.contains.contains",
            "short": "Codes contained under this entry",
            "definition": "Other codes and entries contained under this entry in the hierarchy.",
            "comment": "If the expansion uses this element, there is  no implication about the logical relationship between them, and the  structure cannot be used for logical inferencing. The structure  exists to provide navigational assistance for helping human users to  locate codes in the expansion.",
            "min": 0,
            "max": "*",
            "contentReference": "#ValueSet.expansion.contains"
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'ValueSet'
    /// </summary>
    // 0. ValueSet
    public class ValueSet : FhirKhit.Maker.Common.Resource.ResourceBase                                                                     // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class ValueSet_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                        // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 17. ValueSet.compose
            public class Type_Compose : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Compose_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 20. ValueSet.compose.include
                    public class Type_Include : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Include_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 23. ValueSet.compose.include.concept
                            public class Type_Concept : FhirKhit.Maker.Common.Complex.ComplexBase                                           // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                public class Type_Concept_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                            // MakerGen.cs:386
                                {                                                                                                           // MakerGen.cs:387
                                    // 26. ValueSet.compose.include.concept.designation
                                    public class Type_Designation : FhirKhit.Maker.Common.Complex.ComplexBase                               // MakerGen.cs:384
                                    {                                                                                                       // MakerGen.cs:385
                                        public class Type_Designation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                // MakerGen.cs:386
                                        {                                                                                                   // MakerGen.cs:387
                                            // 27. ValueSet.compose.include.concept.designation.language
                                            public ElementDefinitionInfo Language;                                                          // MakerGen.cs:216
                                            // 28. ValueSet.compose.include.concept.designation.use
                                            public ElementDefinitionInfo Use;                                                               // MakerGen.cs:216
                                            // 29. ValueSet.compose.include.concept.designation.value
                                            public ElementDefinitionInfo Value;                                                             // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                                            public Type_Designation_Elements()                                                              // MakerGen.cs:392
                                            {                                                                                               // MakerGen.cs:393
                                                {                                                                                           // MakerGen.cs:231
                                                    // 27. ValueSet.compose.include.concept.designation.language
                                                    this.Language = new ElementDefinitionInfo                                               // MakerGen.cs:233
                                                    {                                                                                       // MakerGen.cs:234
                                                        Name = "Language",                                                                  // MakerGen.cs:235
                                                        Path= "ValueSet.compose.include.concept.designation.language",                      // MakerGen.cs:236
                                                        Id = "ValueSet.compose.include.concept.designation.language",                       // MakerGen.cs:237
                                                        Min = 0,                                                                            // MakerGen.cs:238
                                                        Max = 1,                                                                            // MakerGen.cs:239
                                                        Types = new BaseType[]                                                              // MakerGen.cs:240
                                                        {                                                                                   // MakerGen.cs:241
                                                            new FhirKhit.Maker.Common.Primitive.Code                                        // MakerGen.cs:300
                                                            {                                                                               // MakerGen.cs:301
                                                            }                                                                               // MakerGen.cs:304
                                                        }                                                                                   // MakerGen.cs:243
                                                    };                                                                                      // MakerGen.cs:244
                                                }                                                                                           // MakerGen.cs:245
                                                {                                                                                           // MakerGen.cs:231
                                                    // 28. ValueSet.compose.include.concept.designation.use
                                                    this.Use = new ElementDefinitionInfo                                                    // MakerGen.cs:233
                                                    {                                                                                       // MakerGen.cs:234
                                                        Name = "Use",                                                                       // MakerGen.cs:235
                                                        Path= "ValueSet.compose.include.concept.designation.use",                           // MakerGen.cs:236
                                                        Id = "ValueSet.compose.include.concept.designation.use",                            // MakerGen.cs:237
                                                        Min = 0,                                                                            // MakerGen.cs:238
                                                        Max = 1,                                                                            // MakerGen.cs:239
                                                        Types = new BaseType[]                                                              // MakerGen.cs:240
                                                        {                                                                                   // MakerGen.cs:241
                                                            new FhirKhit.Maker.Common.Complex.Coding                                        // MakerGen.cs:315
                                                            {                                                                               // MakerGen.cs:316
                                                            }                                                                               // MakerGen.cs:319
                                                        }                                                                                   // MakerGen.cs:243
                                                    };                                                                                      // MakerGen.cs:244
                                                }                                                                                           // MakerGen.cs:245
                                                {                                                                                           // MakerGen.cs:231
                                                    // 29. ValueSet.compose.include.concept.designation.value
                                                    this.Value = new ElementDefinitionInfo                                                  // MakerGen.cs:233
                                                    {                                                                                       // MakerGen.cs:234
                                                        Name = "Value",                                                                     // MakerGen.cs:235
                                                        Path= "ValueSet.compose.include.concept.designation.value",                         // MakerGen.cs:236
                                                        Id = "ValueSet.compose.include.concept.designation.value",                          // MakerGen.cs:237
                                                        Min = 1,                                                                            // MakerGen.cs:238
                                                        Max = 1,                                                                            // MakerGen.cs:239
                                                        Types = new BaseType[]                                                              // MakerGen.cs:240
                                                        {                                                                                   // MakerGen.cs:241
                                                            new FhirKhit.Maker.Common.Primitive.String                                      // MakerGen.cs:300
                                                            {                                                                               // MakerGen.cs:301
                                                            }                                                                               // MakerGen.cs:304
                                                        }                                                                                   // MakerGen.cs:243
                                                    };                                                                                      // MakerGen.cs:244
                                                }                                                                                           // MakerGen.cs:245
                                            }                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                             // MakerGen.cs:398
                                            {                                                                                               // MakerGen.cs:399
                                                base.Write(sDef);                                                                           // MakerGen.cs:400
                                                Language.Write(sDef);                                                                       // MakerGen.cs:220
                                                Use.Write(sDef);                                                                            // MakerGen.cs:220
                                                Value.Write(sDef);                                                                          // MakerGen.cs:220
                                            }                                                                                               // MakerGen.cs:402
                                        }                                                                                                   // MakerGen.cs:404
                                        public Type_Designation_Elements Elements                                                           // MakerGen.cs:406
                                        {                                                                                                   // MakerGen.cs:407
                                            get                                                                                             // MakerGen.cs:408
                                            {                                                                                               // MakerGen.cs:409
                                                if (this.elements == null)                                                                  // MakerGen.cs:410
                                                    this.elements = new Type_Designation_Elements();                                        // MakerGen.cs:411
                                                return this.elements;                                                                       // MakerGen.cs:412
                                            }                                                                                               // MakerGen.cs:413
                                        }                                                                                                   // MakerGen.cs:414
                                        Type_Designation_Elements elements;                                                                 // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                                        public Type_Designation()                                                                           // MakerGen.cs:418
                                        {                                                                                                   // MakerGen.cs:419
                                        }                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                 // MakerGen.cs:424
                                        {                                                                                                   // MakerGen.cs:425
                                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                              // MakerGen.cs:426
                                            {                                                                                               // MakerGen.cs:427
                                                Path = "ValueSet.compose.include.concept.designation",                                      // MakerGen.cs:428
                                                ElementId = "ValueSet.compose.include.concept.designation"                                  // MakerGen.cs:429
                                            });                                                                                             // MakerGen.cs:430
                                            if (this.elements != null)                                                                      // MakerGen.cs:431
                                                this.elements.Write(sDef);                                                                  // MakerGen.cs:432
                                        }                                                                                                   // MakerGen.cs:433
                                    }                                                                                                       // MakerGen.cs:434
                                    // 24. ValueSet.compose.include.concept.code
                                    public ElementDefinitionInfo Code;                                                                      // MakerGen.cs:216
                                    // 25. ValueSet.compose.include.concept.display
                                    public ElementDefinitionInfo Display;                                                                   // MakerGen.cs:216
                                    // 26. ValueSet.compose.include.concept.designation
                                    public ElementDefinitionInfo Designation;                                                               // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                                    public Type_Concept_Elements()                                                                          // MakerGen.cs:392
                                    {                                                                                                       // MakerGen.cs:393
                                        {                                                                                                   // MakerGen.cs:231
                                            // 24. ValueSet.compose.include.concept.code
                                            this.Code = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Code",                                                                              // MakerGen.cs:235
                                                Path= "ValueSet.compose.include.concept.code",                                              // MakerGen.cs:236
                                                Id = "ValueSet.compose.include.concept.code",                                               // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Code                                                // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 25. ValueSet.compose.include.concept.display
                                            this.Display = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Display",                                                                           // MakerGen.cs:235
                                                Path= "ValueSet.compose.include.concept.display",                                           // MakerGen.cs:236
                                                Id = "ValueSet.compose.include.concept.display",                                            // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 26. ValueSet.compose.include.concept.designation
                                            this.Designation = new ElementDefinitionInfo                                                    // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Designation",                                                                       // MakerGen.cs:235
                                                Path= "ValueSet.compose.include.concept.designation",                                       // MakerGen.cs:236
                                                Id = "ValueSet.compose.include.concept.designation",                                        // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new Type_Designation                                                                    // MakerGen.cs:259
                                                    {                                                                                       // MakerGen.cs:260
                                                    }                                                                                       // MakerGen.cs:261
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:398
                                    {                                                                                                       // MakerGen.cs:399
                                        base.Write(sDef);                                                                                   // MakerGen.cs:400
                                        Code.Write(sDef);                                                                                   // MakerGen.cs:220
                                        Display.Write(sDef);                                                                                // MakerGen.cs:220
                                        Designation.Write(sDef);                                                                            // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:402
                                }                                                                                                           // MakerGen.cs:404
                                public Type_Concept_Elements Elements                                                                       // MakerGen.cs:406
                                {                                                                                                           // MakerGen.cs:407
                                    get                                                                                                     // MakerGen.cs:408
                                    {                                                                                                       // MakerGen.cs:409
                                        if (this.elements == null)                                                                          // MakerGen.cs:410
                                            this.elements = new Type_Concept_Elements();                                                    // MakerGen.cs:411
                                        return this.elements;                                                                               // MakerGen.cs:412
                                    }                                                                                                       // MakerGen.cs:413
                                }                                                                                                           // MakerGen.cs:414
                                Type_Concept_Elements elements;                                                                             // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                                public Type_Concept()                                                                                       // MakerGen.cs:418
                                {                                                                                                           // MakerGen.cs:419
                                }                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:424
                                {                                                                                                           // MakerGen.cs:425
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:426
                                    {                                                                                                       // MakerGen.cs:427
                                        Path = "ValueSet.compose.include.concept",                                                          // MakerGen.cs:428
                                        ElementId = "ValueSet.compose.include.concept"                                                      // MakerGen.cs:429
                                    });                                                                                                     // MakerGen.cs:430
                                    if (this.elements != null)                                                                              // MakerGen.cs:431
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:432
                                }                                                                                                           // MakerGen.cs:433
                            }                                                                                                               // MakerGen.cs:434
                            // 30. ValueSet.compose.include.filter
                            public class Type_Filter : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                public class Type_Filter_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                             // MakerGen.cs:386
                                {                                                                                                           // MakerGen.cs:387
                                    // 31. ValueSet.compose.include.filter.property
                                    public ElementDefinitionInfo Property;                                                                  // MakerGen.cs:216
                                    // 32. ValueSet.compose.include.filter.op
                                    public ElementDefinitionInfo Op;                                                                        // MakerGen.cs:216
                                    // 33. ValueSet.compose.include.filter.value
                                    public ElementDefinitionInfo Value;                                                                     // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                                    public Type_Filter_Elements()                                                                           // MakerGen.cs:392
                                    {                                                                                                       // MakerGen.cs:393
                                        {                                                                                                   // MakerGen.cs:231
                                            // 31. ValueSet.compose.include.filter.property
                                            this.Property = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Property",                                                                          // MakerGen.cs:235
                                                Path= "ValueSet.compose.include.filter.property",                                           // MakerGen.cs:236
                                                Id = "ValueSet.compose.include.filter.property",                                            // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Code                                                // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 32. ValueSet.compose.include.filter.op
                                            this.Op = new ElementDefinitionInfo                                                             // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Op",                                                                                // MakerGen.cs:235
                                                Path= "ValueSet.compose.include.filter.op",                                                 // MakerGen.cs:236
                                                Id = "ValueSet.compose.include.filter.op",                                                  // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Code                                                // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 33. ValueSet.compose.include.filter.value
                                            this.Value = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Value",                                                                             // MakerGen.cs:235
                                                Path= "ValueSet.compose.include.filter.value",                                              // MakerGen.cs:236
                                                Id = "ValueSet.compose.include.filter.value",                                               // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:398
                                    {                                                                                                       // MakerGen.cs:399
                                        base.Write(sDef);                                                                                   // MakerGen.cs:400
                                        Property.Write(sDef);                                                                               // MakerGen.cs:220
                                        Op.Write(sDef);                                                                                     // MakerGen.cs:220
                                        Value.Write(sDef);                                                                                  // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:402
                                }                                                                                                           // MakerGen.cs:404
                                public Type_Filter_Elements Elements                                                                        // MakerGen.cs:406
                                {                                                                                                           // MakerGen.cs:407
                                    get                                                                                                     // MakerGen.cs:408
                                    {                                                                                                       // MakerGen.cs:409
                                        if (this.elements == null)                                                                          // MakerGen.cs:410
                                            this.elements = new Type_Filter_Elements();                                                     // MakerGen.cs:411
                                        return this.elements;                                                                               // MakerGen.cs:412
                                    }                                                                                                       // MakerGen.cs:413
                                }                                                                                                           // MakerGen.cs:414
                                Type_Filter_Elements elements;                                                                              // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                                public Type_Filter()                                                                                        // MakerGen.cs:418
                                {                                                                                                           // MakerGen.cs:419
                                }                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:424
                                {                                                                                                           // MakerGen.cs:425
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:426
                                    {                                                                                                       // MakerGen.cs:427
                                        Path = "ValueSet.compose.include.filter",                                                           // MakerGen.cs:428
                                        ElementId = "ValueSet.compose.include.filter"                                                       // MakerGen.cs:429
                                    });                                                                                                     // MakerGen.cs:430
                                    if (this.elements != null)                                                                              // MakerGen.cs:431
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:432
                                }                                                                                                           // MakerGen.cs:433
                            }                                                                                                               // MakerGen.cs:434
                            // 21. ValueSet.compose.include.system
                            public ElementDefinitionInfo System;                                                                            // MakerGen.cs:216
                            // 22. ValueSet.compose.include.version
                            public ElementDefinitionInfo Version;                                                                           // MakerGen.cs:216
                            // 23. ValueSet.compose.include.concept
                            public ElementDefinitionInfo Concept;                                                                           // MakerGen.cs:216
                            // 30. ValueSet.compose.include.filter
                            public ElementDefinitionInfo Filter;                                                                            // MakerGen.cs:216
                            // 34. ValueSet.compose.include.valueSet
                            public ElementDefinitionInfo ValueSet;                                                                          // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Include_Elements()                                                                                  // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 21. ValueSet.compose.include.system
                                    this.System = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "System",                                                                                    // MakerGen.cs:235
                                        Path= "ValueSet.compose.include.system",                                                            // MakerGen.cs:236
                                        Id = "ValueSet.compose.include.system",                                                             // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Uri                                                         // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 22. ValueSet.compose.include.version
                                    this.Version = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Version",                                                                                   // MakerGen.cs:235
                                        Path= "ValueSet.compose.include.version",                                                           // MakerGen.cs:236
                                        Id = "ValueSet.compose.include.version",                                                            // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 23. ValueSet.compose.include.concept
                                    this.Concept = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Concept",                                                                                   // MakerGen.cs:235
                                        Path= "ValueSet.compose.include.concept",                                                           // MakerGen.cs:236
                                        Id = "ValueSet.compose.include.concept",                                                            // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Concept                                                                                // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 30. ValueSet.compose.include.filter
                                    this.Filter = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Filter",                                                                                    // MakerGen.cs:235
                                        Path= "ValueSet.compose.include.filter",                                                            // MakerGen.cs:236
                                        Id = "ValueSet.compose.include.filter",                                                             // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Filter                                                                                 // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 34. ValueSet.compose.include.valueSet
                                    this.ValueSet = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "ValueSet",                                                                                  // MakerGen.cs:235
                                        Path= "ValueSet.compose.include.valueSet",                                                          // MakerGen.cs:236
                                        Id = "ValueSet.compose.include.valueSet",                                                           // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Canonical                                                   // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                                TargetProfile = new String[]                                                                // MakerGen.cs:303
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/ValueSet"                                      // MakerGen.cs:303
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                System.Write(sDef);                                                                                         // MakerGen.cs:220
                                Version.Write(sDef);                                                                                        // MakerGen.cs:220
                                Concept.Write(sDef);                                                                                        // MakerGen.cs:220
                                Filter.Write(sDef);                                                                                         // MakerGen.cs:220
                                ValueSet.Write(sDef);                                                                                       // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Include_Elements Elements                                                                               // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Include_Elements();                                                            // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Include_Elements elements;                                                                                     // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Include()                                                                                               // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "ValueSet.compose.include",                                                                          // MakerGen.cs:428
                                ElementId = "ValueSet.compose.include"                                                                      // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 18. ValueSet.compose.lockedDate
                    public ElementDefinitionInfo LockedDate;                                                                                // MakerGen.cs:216
                    // 19. ValueSet.compose.inactive
                    public ElementDefinitionInfo Inactive;                                                                                  // MakerGen.cs:216
                    // 20. ValueSet.compose.include
                    public ElementDefinitionInfo Include;                                                                                   // MakerGen.cs:216
                    // 35. ValueSet.compose.exclude
                    public ElementDefinitionInfo Exclude;                                                                                   // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Compose_Elements()                                                                                          // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 18. ValueSet.compose.lockedDate
                            this.LockedDate = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "LockedDate",                                                                                        // MakerGen.cs:235
                                Path= "ValueSet.compose.lockedDate",                                                                        // MakerGen.cs:236
                                Id = "ValueSet.compose.lockedDate",                                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 19. ValueSet.compose.inactive
                            this.Inactive = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Inactive",                                                                                          // MakerGen.cs:235
                                Path= "ValueSet.compose.inactive",                                                                          // MakerGen.cs:236
                                Id = "ValueSet.compose.inactive",                                                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 20. ValueSet.compose.include
                            this.Include = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Include",                                                                                           // MakerGen.cs:235
                                Path= "ValueSet.compose.include",                                                                           // MakerGen.cs:236
                                Id = "ValueSet.compose.include",                                                                            // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Include                                                                                        // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 35. ValueSet.compose.exclude
                            this.Exclude = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Exclude",                                                                                           // MakerGen.cs:235
                                Path= "ValueSet.compose.exclude",                                                                           // MakerGen.cs:236
                                Id = "ValueSet.compose.exclude",                                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        LockedDate.Write(sDef);                                                                                             // MakerGen.cs:220
                        Inactive.Write(sDef);                                                                                               // MakerGen.cs:220
                        Include.Write(sDef);                                                                                                // MakerGen.cs:220
                        Exclude.Write(sDef);                                                                                                // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Compose_Elements Elements                                                                                       // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Compose_Elements();                                                                    // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Compose_Elements elements;                                                                                             // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Compose()                                                                                                       // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "ValueSet.compose",                                                                                          // MakerGen.cs:428
                        ElementId = "ValueSet.compose"                                                                                      // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 36. ValueSet.expansion
            public class Type_Expansion : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Expansion_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 41. ValueSet.expansion.parameter
                    public class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Parameter_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 42. ValueSet.expansion.parameter.name
                            public ElementDefinitionInfo Name;                                                                              // MakerGen.cs:216
                            // 43. ValueSet.expansion.parameter.value[x]
                            public ElementDefinitionInfo Value;                                                                             // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Parameter_Elements()                                                                                // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 42. ValueSet.expansion.parameter.name
                                    this.Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Name",                                                                                      // MakerGen.cs:235
                                        Path= "ValueSet.expansion.parameter.name",                                                          // MakerGen.cs:236
                                        Id = "ValueSet.expansion.parameter.name",                                                           // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 43. ValueSet.expansion.parameter.value[x]
                                    this.Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Value",                                                                                     // MakerGen.cs:235
                                        Path= "ValueSet.expansion.parameter.value[x]",                                                      // MakerGen.cs:236
                                        Id = "ValueSet.expansion.parameter.value[x]",                                                       // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            },                                                                                              // MakerGen.cs:304
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            },                                                                                              // MakerGen.cs:304
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            },                                                                                              // MakerGen.cs:304
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            },                                                                                              // MakerGen.cs:304
                                            new FhirKhit.Maker.Common.Primitive.Uri                                                         // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            },                                                                                              // MakerGen.cs:304
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            },                                                                                              // MakerGen.cs:304
                                            new FhirKhit.Maker.Common.Primitive.DateTime                                                    // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Name.Write(sDef);                                                                                           // MakerGen.cs:220
                                Value.Write(sDef);                                                                                          // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Parameter_Elements Elements                                                                             // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Parameter_Elements();                                                          // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Parameter_Elements elements;                                                                                   // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Parameter()                                                                                             // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "ValueSet.expansion.parameter",                                                                      // MakerGen.cs:428
                                ElementId = "ValueSet.expansion.parameter"                                                                  // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 44. ValueSet.expansion.contains
                    public class Type_Contains : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Contains_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 45. ValueSet.expansion.contains.system
                            public ElementDefinitionInfo System;                                                                            // MakerGen.cs:216
                            // 46. ValueSet.expansion.contains.abstract
                            public ElementDefinitionInfo Abstract;                                                                          // MakerGen.cs:216
                            // 47. ValueSet.expansion.contains.inactive
                            public ElementDefinitionInfo Inactive;                                                                          // MakerGen.cs:216
                            // 48. ValueSet.expansion.contains.version
                            public ElementDefinitionInfo Version;                                                                           // MakerGen.cs:216
                            // 49. ValueSet.expansion.contains.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:216
                            // 50. ValueSet.expansion.contains.display
                            public ElementDefinitionInfo Display;                                                                           // MakerGen.cs:216
                            // 51. ValueSet.expansion.contains.designation
                            public ElementDefinitionInfo Designation;                                                                       // MakerGen.cs:216
                            // 52. ValueSet.expansion.contains.contains
                            public ElementDefinitionInfo Contains;                                                                          // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Contains_Elements()                                                                                 // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 45. ValueSet.expansion.contains.system
                                    this.System = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "System",                                                                                    // MakerGen.cs:235
                                        Path= "ValueSet.expansion.contains.system",                                                         // MakerGen.cs:236
                                        Id = "ValueSet.expansion.contains.system",                                                          // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Uri                                                         // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 46. ValueSet.expansion.contains.abstract
                                    this.Abstract = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Abstract",                                                                                  // MakerGen.cs:235
                                        Path= "ValueSet.expansion.contains.abstract",                                                       // MakerGen.cs:236
                                        Id = "ValueSet.expansion.contains.abstract",                                                        // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 47. ValueSet.expansion.contains.inactive
                                    this.Inactive = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Inactive",                                                                                  // MakerGen.cs:235
                                        Path= "ValueSet.expansion.contains.inactive",                                                       // MakerGen.cs:236
                                        Id = "ValueSet.expansion.contains.inactive",                                                        // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 48. ValueSet.expansion.contains.version
                                    this.Version = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Version",                                                                                   // MakerGen.cs:235
                                        Path= "ValueSet.expansion.contains.version",                                                        // MakerGen.cs:236
                                        Id = "ValueSet.expansion.contains.version",                                                         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 49. ValueSet.expansion.contains.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Code",                                                                                      // MakerGen.cs:235
                                        Path= "ValueSet.expansion.contains.code",                                                           // MakerGen.cs:236
                                        Id = "ValueSet.expansion.contains.code",                                                            // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 50. ValueSet.expansion.contains.display
                                    this.Display = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Display",                                                                                   // MakerGen.cs:235
                                        Path= "ValueSet.expansion.contains.display",                                                        // MakerGen.cs:236
                                        Id = "ValueSet.expansion.contains.display",                                                         // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 51. ValueSet.expansion.contains.designation
                                    this.Designation = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Designation",                                                                               // MakerGen.cs:235
                                        Path= "ValueSet.expansion.contains.designation",                                                    // MakerGen.cs:236
                                        Id = "ValueSet.expansion.contains.designation",                                                     // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 52. ValueSet.expansion.contains.contains
                                    this.Contains = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Contains",                                                                                  // MakerGen.cs:235
                                        Path= "ValueSet.expansion.contains.contains",                                                       // MakerGen.cs:236
                                        Id = "ValueSet.expansion.contains.contains",                                                        // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                System.Write(sDef);                                                                                         // MakerGen.cs:220
                                Abstract.Write(sDef);                                                                                       // MakerGen.cs:220
                                Inactive.Write(sDef);                                                                                       // MakerGen.cs:220
                                Version.Write(sDef);                                                                                        // MakerGen.cs:220
                                Code.Write(sDef);                                                                                           // MakerGen.cs:220
                                Display.Write(sDef);                                                                                        // MakerGen.cs:220
                                Designation.Write(sDef);                                                                                    // MakerGen.cs:220
                                Contains.Write(sDef);                                                                                       // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Contains_Elements Elements                                                                              // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Contains_Elements();                                                           // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Contains_Elements elements;                                                                                    // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Contains()                                                                                              // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "ValueSet.expansion.contains",                                                                       // MakerGen.cs:428
                                ElementId = "ValueSet.expansion.contains"                                                                   // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 37. ValueSet.expansion.identifier
                    public ElementDefinitionInfo Identifier;                                                                                // MakerGen.cs:216
                    // 38. ValueSet.expansion.timestamp
                    public ElementDefinitionInfo Timestamp;                                                                                 // MakerGen.cs:216
                    // 39. ValueSet.expansion.total
                    public ElementDefinitionInfo Total;                                                                                     // MakerGen.cs:216
                    // 40. ValueSet.expansion.offset
                    public ElementDefinitionInfo Offset;                                                                                    // MakerGen.cs:216
                    // 41. ValueSet.expansion.parameter
                    public ElementDefinitionInfo Parameter;                                                                                 // MakerGen.cs:216
                    // 44. ValueSet.expansion.contains
                    public ElementDefinitionInfo Contains;                                                                                  // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Expansion_Elements()                                                                                        // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 37. ValueSet.expansion.identifier
                            this.Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Identifier",                                                                                        // MakerGen.cs:235
                                Path= "ValueSet.expansion.identifier",                                                                      // MakerGen.cs:236
                                Id = "ValueSet.expansion.identifier",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 38. ValueSet.expansion.timestamp
                            this.Timestamp = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Timestamp",                                                                                         // MakerGen.cs:235
                                Path= "ValueSet.expansion.timestamp",                                                                       // MakerGen.cs:236
                                Id = "ValueSet.expansion.timestamp",                                                                        // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 39. ValueSet.expansion.total
                            this.Total = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Total",                                                                                             // MakerGen.cs:235
                                Path= "ValueSet.expansion.total",                                                                           // MakerGen.cs:236
                                Id = "ValueSet.expansion.total",                                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 40. ValueSet.expansion.offset
                            this.Offset = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Offset",                                                                                            // MakerGen.cs:235
                                Path= "ValueSet.expansion.offset",                                                                          // MakerGen.cs:236
                                Id = "ValueSet.expansion.offset",                                                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 41. ValueSet.expansion.parameter
                            this.Parameter = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Parameter",                                                                                         // MakerGen.cs:235
                                Path= "ValueSet.expansion.parameter",                                                                       // MakerGen.cs:236
                                Id = "ValueSet.expansion.parameter",                                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Parameter                                                                                      // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 44. ValueSet.expansion.contains
                            this.Contains = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Contains",                                                                                          // MakerGen.cs:235
                                Path= "ValueSet.expansion.contains",                                                                        // MakerGen.cs:236
                                Id = "ValueSet.expansion.contains",                                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Contains                                                                                       // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Identifier.Write(sDef);                                                                                             // MakerGen.cs:220
                        Timestamp.Write(sDef);                                                                                              // MakerGen.cs:220
                        Total.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Offset.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Parameter.Write(sDef);                                                                                              // MakerGen.cs:220
                        Contains.Write(sDef);                                                                                               // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Expansion_Elements Elements                                                                                     // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Expansion_Elements();                                                                  // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Expansion_Elements elements;                                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Expansion()                                                                                                     // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "ValueSet.expansion",                                                                                        // MakerGen.cs:428
                        ElementId = "ValueSet.expansion"                                                                                    // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. ValueSet.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:216
            // 2. ValueSet.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 3. ValueSet.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:216
            // 4. ValueSet.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 5. ValueSet.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:216
            // 6. ValueSet.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 7. ValueSet.experimental
            public ElementDefinitionInfo Experimental;                                                                                      // MakerGen.cs:216
            // 8. ValueSet.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:216
            // 9. ValueSet.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:216
            // 10. ValueSet.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:216
            // 11. ValueSet.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 12. ValueSet.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:216
            // 13. ValueSet.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:216
            // 14. ValueSet.immutable
            public ElementDefinitionInfo Immutable;                                                                                         // MakerGen.cs:216
            // 15. ValueSet.purpose
            public ElementDefinitionInfo Purpose;                                                                                           // MakerGen.cs:216
            // 16. ValueSet.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:216
            // 17. ValueSet.compose
            public ElementDefinitionInfo Compose;                                                                                           // MakerGen.cs:216
            // 36. ValueSet.expansion
            public ElementDefinitionInfo Expansion;                                                                                         // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public ValueSet_Elements()                                                                                                      // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. ValueSet.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Url",                                                                                                       // MakerGen.cs:235
                        Path= "ValueSet.url",                                                                                               // MakerGen.cs:236
                        Id = "ValueSet.url",                                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 2. ValueSet.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "ValueSet.identifier",                                                                                        // MakerGen.cs:236
                        Id = "ValueSet.identifier",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. ValueSet.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Version",                                                                                                   // MakerGen.cs:235
                        Path= "ValueSet.version",                                                                                           // MakerGen.cs:236
                        Id = "ValueSet.version",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 4. ValueSet.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "ValueSet.name",                                                                                              // MakerGen.cs:236
                        Id = "ValueSet.name",                                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 5. ValueSet.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Title",                                                                                                     // MakerGen.cs:235
                        Path= "ValueSet.title",                                                                                             // MakerGen.cs:236
                        Id = "ValueSet.title",                                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 6. ValueSet.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "ValueSet.status",                                                                                            // MakerGen.cs:236
                        Id = "ValueSet.status",                                                                                             // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 7. ValueSet.experimental
                    this.Experimental = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Experimental",                                                                                              // MakerGen.cs:235
                        Path= "ValueSet.experimental",                                                                                      // MakerGen.cs:236
                        Id = "ValueSet.experimental",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 8. ValueSet.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Date",                                                                                                      // MakerGen.cs:235
                        Path= "ValueSet.date",                                                                                              // MakerGen.cs:236
                        Id = "ValueSet.date",                                                                                               // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 9. ValueSet.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Publisher",                                                                                                 // MakerGen.cs:235
                        Path= "ValueSet.publisher",                                                                                         // MakerGen.cs:236
                        Id = "ValueSet.publisher",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. ValueSet.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Contact",                                                                                                   // MakerGen.cs:235
                        Path= "ValueSet.contact",                                                                                           // MakerGen.cs:236
                        Id = "ValueSet.contact",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 11. ValueSet.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "ValueSet.description",                                                                                       // MakerGen.cs:236
                        Id = "ValueSet.description",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. ValueSet.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "UseContext",                                                                                                // MakerGen.cs:235
                        Path= "ValueSet.useContext",                                                                                        // MakerGen.cs:236
                        Id = "ValueSet.useContext",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.UsageContext                                                                  // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 13. ValueSet.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:235
                        Path= "ValueSet.jurisdiction",                                                                                      // MakerGen.cs:236
                        Id = "ValueSet.jurisdiction",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 14. ValueSet.immutable
                    this.Immutable = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Immutable",                                                                                                 // MakerGen.cs:235
                        Path= "ValueSet.immutable",                                                                                         // MakerGen.cs:236
                        Id = "ValueSet.immutable",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 15. ValueSet.purpose
                    this.Purpose = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Purpose",                                                                                                   // MakerGen.cs:235
                        Path= "ValueSet.purpose",                                                                                           // MakerGen.cs:236
                        Id = "ValueSet.purpose",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 16. ValueSet.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Copyright",                                                                                                 // MakerGen.cs:235
                        Path= "ValueSet.copyright",                                                                                         // MakerGen.cs:236
                        Id = "ValueSet.copyright",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 17. ValueSet.compose
                    this.Compose = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Compose",                                                                                                   // MakerGen.cs:235
                        Path= "ValueSet.compose",                                                                                           // MakerGen.cs:236
                        Id = "ValueSet.compose",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Compose                                                                                                // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 36. ValueSet.expansion
                    this.Expansion = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Expansion",                                                                                                 // MakerGen.cs:235
                        Path= "ValueSet.expansion",                                                                                         // MakerGen.cs:236
                        Id = "ValueSet.expansion",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Expansion                                                                                              // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Url.Write(sDef);                                                                                                            // MakerGen.cs:220
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Version.Write(sDef);                                                                                                        // MakerGen.cs:220
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Title.Write(sDef);                                                                                                          // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Experimental.Write(sDef);                                                                                                   // MakerGen.cs:220
                Date.Write(sDef);                                                                                                           // MakerGen.cs:220
                Publisher.Write(sDef);                                                                                                      // MakerGen.cs:220
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:220
                Description.Write(sDef);                                                                                                    // MakerGen.cs:220
                UseContext.Write(sDef);                                                                                                     // MakerGen.cs:220
                Jurisdiction.Write(sDef);                                                                                                   // MakerGen.cs:220
                Immutable.Write(sDef);                                                                                                      // MakerGen.cs:220
                Purpose.Write(sDef);                                                                                                        // MakerGen.cs:220
                Copyright.Write(sDef);                                                                                                      // MakerGen.cs:220
                Compose.Write(sDef);                                                                                                        // MakerGen.cs:220
                Expansion.Write(sDef);                                                                                                      // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public ValueSet_Elements Elements                                                                                                   // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new ValueSet_Elements();                                                                                // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        ValueSet_Elements elements;                                                                                                         // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public ValueSet()                                                                                                                   // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "ValueSet";                                                                                                         // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ValueSet";                                                                  // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "ValueSet",                                                                                                          // MakerGen.cs:428
                ElementId = "ValueSet"                                                                                                      // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
