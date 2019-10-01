using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
    {
      "resourceType": "StructureDefinition",
      "id": "CodeSystem",
      "url": "http://hl7.org/fhir/StructureDefinition/CodeSystem",
      "version": "4.0.0",
      "name": "CodeSystem",
      "status": "active",
      "publisher": "Health Level Seven International (Vocabulary)",
      "description": "The CodeSystem resource is used to declare the existence of and describe a code system or code system supplement and its key properties, and optionally define a part or all of its content.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "CodeSystem",
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
            "id": "CodeSystem",
            "path": "CodeSystem",
            "short": "Declares the existence of and describes a code system or code system supplement",
            "definition": "The CodeSystem resource is used to declare the existence of and describe a code system or code system supplement and its key properties, and optionally define a part or all of its content.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "CodeSystem.url",
            "path": "CodeSystem.url",
            "short": "Canonical identifier for this code system, represented as a URI (globally unique) (Coding.system)",
            "definition": "An absolute URI that is used to identify this code system when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this code system is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the code system is stored on different servers. This is used in [Coding](datatypes.html#Coding).system.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the code system to be referenced by a single globally unique identifier.",
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
            "id": "CodeSystem.identifier",
            "path": "CodeSystem.identifier",
            "short": "Additional identifier for the code system (business identifier)",
            "definition": "A formal identifier that is used to identify this code system when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this code system outside of FHIR, where it is not possible to use the logical URI.  Note that HL7 defines at least three identifiers for many of its code systems - the FHIR canonical URL, the OID and the V2 Table 0396 mnemonic code.",
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
            "id": "CodeSystem.version",
            "path": "CodeSystem.version",
            "short": "Business version of the code system (Coding.version)",
            "definition": "The identifier that is used to identify this version of the code system when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the code system author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence. This is used in [Coding](datatypes.html#Coding).version.",
            "comment": "There may be different code system instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the code system with the format [url]|[version].",
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
            "id": "CodeSystem.name",
            "path": "CodeSystem.name",
            "short": "Name for this code system (computer friendly)",
            "definition": "A natural language name identifying the code system. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "CodeSystem.title",
            "path": "CodeSystem.title",
            "short": "Name for this code system (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the code system.",
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
            "id": "CodeSystem.status",
            "path": "CodeSystem.status",
            "short": "draft | active | retired | unknown",
            "definition": "The date (and optionally time) when the code system resource was created or revised.",
            "comment": "Allows filtering of code systems that are appropriate for use versus not.",
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
            "id": "CodeSystem.experimental",
            "path": "CodeSystem.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this code system is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of code systems that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level code system.",
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
            "id": "CodeSystem.date",
            "path": "CodeSystem.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the code system was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the code system changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the code system. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "CodeSystem.publisher",
            "path": "CodeSystem.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the code system.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the code system is the organization or individual primarily responsible for the maintenance and upkeep of the code system. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the code system. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the code system.  May also allow for contact.",
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
            "id": "CodeSystem.contact",
            "path": "CodeSystem.contact",
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
            "id": "CodeSystem.description",
            "path": "CodeSystem.description",
            "short": "Natural language description of the code system",
            "definition": "A free text natural language description of the code system from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the code system was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the code system as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the code system is presumed to be the predominant language in the place the code system was created).",
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
            "id": "CodeSystem.useContext",
            "path": "CodeSystem.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate code system instances.",
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
            "id": "CodeSystem.jurisdiction",
            "path": "CodeSystem.jurisdiction",
            "short": "Intended jurisdiction for code system (if applicable)",
            "definition": "A legal or geographic region in which the code system is intended to be used.",
            "comment": "It may be possible for the code system to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "CodeSystem.purpose",
            "path": "CodeSystem.purpose",
            "short": "Why this code system is defined",
            "definition": "Explanation of why this code system is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the code system. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this code system.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "CodeSystem.copyright",
            "path": "CodeSystem.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the code system and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the code system.",
            "comment": "... Sometimes, the copyright differs between the code system and the codes that are included. The copyright statement should clearly differentiate between these when required.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the code system and/or its content.",
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
            "id": "CodeSystem.caseSensitive",
            "path": "CodeSystem.caseSensitive",
            "short": "If code comparison is case sensitive",
            "definition": "If code comparison is case sensitive when codes within this system are compared to each other.",
            "comment": "If this value is missing, then it is not specified whether a code system is case sensitive or not. When the rule is not known, Postel's law should be followed: produce codes with the correct case, and accept codes in any case. This element is primarily provided to support validation software.",
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
            "id": "CodeSystem.valueSet",
            "path": "CodeSystem.valueSet",
            "short": "Canonical reference to the value set with entire code system",
            "definition": "Canonical reference to the value set that contains the entire code system.",
            "comment": "The definition of the value set SHALL include all codes from this code system and only codes from this code system, and it SHALL be immutable.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ValueSet"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CodeSystem.hierarchyMeaning",
            "path": "CodeSystem.hierarchyMeaning",
            "short": "grouped-by | is-a | part-of | classified-with",
            "definition": "The meaning of the hierarchy of concepts as represented in this resource.",
            "comment": "Note that other representations might have a different hierarchy or none at all, and represent the information using properties.",
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
                  "valueString": "CodeSystemHierarchyMeaning"
                }
              ],
              "strength": "required",
              "description": "The meaning of the hierarchy of concepts in a code system.",
              "valueSet": "http://hl7.org/fhir/ValueSet/codesystem-hierarchy-meaning|4.0.0"
            }
          },
          {
            "id": "CodeSystem.compositional",
            "path": "CodeSystem.compositional",
            "short": "If code system defines a compositional grammar",
            "definition": "The code system defines a compositional (post-coordination) grammar.",
            "comment": "Note that the code system resource does not define what the compositional grammar is, only whether or not there is one.",
            "alias": [
              "grammar"
            ],
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
            "id": "CodeSystem.versionNeeded",
            "path": "CodeSystem.versionNeeded",
            "short": "If definitions are not stable",
            "definition": "This flag is used to signify that the code system does not commit to concept permanence across versions. If true, a version must be specified when referencing this code system.",
            "comment": "Best practice is that code systems do not redefine concepts, or that if concepts are redefined, a new code system definition is created. But this is not always possible, so some code systems may be defined as 'versionNeeded'.\n\nMost code systems occasionally refine the displays defined for concepts between versions. Contexts in which the concept display values are validated may require that the version be specified for some code systems irrespective of the value of this property.",
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
            "id": "CodeSystem.content",
            "path": "CodeSystem.content",
            "short": "not-present | example | fragment | complete | supplement",
            "definition": "The extent of the content of the code system (the concepts and codes it defines) are represented in this resource instance.",
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
                  "valueString": "CodeSystemContentMode"
                }
              ],
              "strength": "required",
              "description": "The extent of the content of the code system (the concepts and codes it defines) are represented in a code system resource.",
              "valueSet": "http://hl7.org/fhir/ValueSet/codesystem-content-mode|4.0.0"
            }
          },
          {
            "id": "CodeSystem.supplements",
            "path": "CodeSystem.supplements",
            "short": "Canonical URL of Code System this adds designations and properties to",
            "definition": "The canonical URL of the code system that this code system supplement is adding designations and properties to.",
            "comment": "The most common use of a code system supplement is to add additional language support.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CodeSystem"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "CodeSystem.count",
            "path": "CodeSystem.count",
            "short": "Total concepts in the code system",
            "definition": "The total number of concepts defined by the code system. Where the code system has a compositional grammar, the basis of this count is defined by the system steward.",
            "comment": "The count of concepts defined in this resource cannot be more than this value but may be less for several reasons - see the content element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "CodeSystem.filter",
            "path": "CodeSystem.filter",
            "short": "Filter that can be used in a value set",
            "definition": "A filter that can be used in a value set compose statement when selecting concepts using a filter.",
            "comment": "Note that filters defined in code systems usually require custom code on the part of any terminology engine that will make them available for use in value set filters. For this reason, they are generally only seen in high value published terminologies.",
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
            "id": "CodeSystem.filter.code",
            "path": "CodeSystem.filter.code",
            "short": "Code that identifies the filter",
            "definition": "The code that identifies this filter when it is used as a filter in [ValueSet](valueset.html#).compose.include.filter.",
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
            "id": "CodeSystem.filter.description",
            "path": "CodeSystem.filter.description",
            "short": "How or why the filter is used",
            "definition": "A description of how or why the filter is used.",
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
            "id": "CodeSystem.filter.operator",
            "path": "CodeSystem.filter.operator",
            "short": "Operators that can be used with filter",
            "definition": "A list of operators that can be used with the filter.",
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
                  "valueString": "FilterOperator"
                }
              ],
              "strength": "required",
              "description": "The kind of operation to perform as a part of a property based filter.",
              "valueSet": "http://hl7.org/fhir/ValueSet/filter-operator|4.0.0"
            }
          },
          {
            "id": "CodeSystem.filter.value",
            "path": "CodeSystem.filter.value",
            "short": "What to use for the value",
            "definition": "A description of what the value for the filter should be.",
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
            "id": "CodeSystem.property",
            "path": "CodeSystem.property",
            "short": "Additional information supplied about each concept",
            "definition": "A property defines an additional slot through which additional information can be provided about a concept.",
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
            "id": "CodeSystem.property.code",
            "path": "CodeSystem.property.code",
            "short": "Identifies the property on the concepts, and when referred to in operations",
            "definition": "A code that is used to identify the property. The code is used internally (in CodeSystem.concept.property.code) and also externally, such as in property filters.",
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
            "id": "CodeSystem.property.uri",
            "path": "CodeSystem.property.uri",
            "short": "Formal identifier for the property",
            "definition": "Reference to the formal meaning of the property. One possible source of meaning is the [Concept Properties](codesystem-concept-properties.html) code system.",
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
            "id": "CodeSystem.property.description",
            "path": "CodeSystem.property.description",
            "short": "Why the property is defined, and/or what it conveys",
            "definition": "A description of the property- why it is defined, and how its value might be used.",
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
            "id": "CodeSystem.property.type",
            "path": "CodeSystem.property.type",
            "short": "code | Coding | string | integer | boolean | dateTime | decimal",
            "definition": "The type of the property value. Properties of type \"code\" contain a code defined by the code system (e.g. a reference to another defined concept).",
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
                  "valueString": "PropertyType"
                }
              ],
              "strength": "required",
              "description": "The type of a property value.",
              "valueSet": "http://hl7.org/fhir/ValueSet/concept-property-type|4.0.0"
            }
          },
          {
            "id": "CodeSystem.concept",
            "path": "CodeSystem.concept",
            "short": "Concepts in the code system",
            "definition": "Concepts that are in the code system. The concept definitions are inherently hierarchical, but the definitions must be consulted to determine what the meanings of the hierarchical relationships are.",
            "comment": "If this is empty, it means that the code system resource does not represent the content of the code system.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CodeSystem.concept.code",
            "path": "CodeSystem.concept.code",
            "short": "Code that identifies concept",
            "definition": "A code - a text symbol - that uniquely identifies the concept within the code system.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ]
          },
          {
            "id": "CodeSystem.concept.display",
            "path": "CodeSystem.concept.display",
            "short": "Text to display to the user",
            "definition": "A human readable string that is the recommended default way to present this concept to a user.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "CodeSystem.concept.definition",
            "path": "CodeSystem.concept.definition",
            "short": "Formal definition",
            "definition": "The formal definition of the concept. The code system resource does not make formal definitions required, because of the prevalence of legacy systems. However, they are highly recommended, as without them there is no formal meaning associated with the concept.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "CodeSystem.concept.designation",
            "path": "CodeSystem.concept.designation",
            "short": "Additional representations for the concept",
            "definition": "Additional representations for the concept - other languages, aliases, specialized purposes, used for particular purposes, etc.",
            "comment": "Concepts have both a ```display``` and an array of ```designation```. The display is equivalent to a special designation with an implied ```designation.use``` of \"primary code\" and a language equal to the [Resource Language](resource.html#language).",
            "requirements": "Many concept definition systems support multiple representations, in multiple languages, and for multiple purposes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CodeSystem.concept.designation.language",
            "path": "CodeSystem.concept.designation.language",
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
            "id": "CodeSystem.concept.designation.use",
            "path": "CodeSystem.concept.designation.use",
            "short": "Details how this designation would be used",
            "definition": "A code that details how this designation would be used.",
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
            "id": "CodeSystem.concept.designation.value",
            "path": "CodeSystem.concept.designation.value",
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
            "id": "CodeSystem.concept.property",
            "path": "CodeSystem.concept.property",
            "short": "Property value for the concept",
            "definition": "A property value for this concept.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "CodeSystem.concept.property.code",
            "path": "CodeSystem.concept.property.code",
            "short": "Reference to CodeSystem.property.code",
            "definition": "A code that is a reference to CodeSystem.property.code.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ]
          },
          {
            "id": "CodeSystem.concept.property.value[x]",
            "path": "CodeSystem.concept.property.value[x]",
            "short": "Value of the property for this concept",
            "definition": "The value of this property.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              },
              {
                "code": "Coding"
              },
              {
                "code": "string"
              },
              {
                "code": "integer"
              },
              {
                "code": "boolean"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "CodeSystem.concept.concept",
            "path": "CodeSystem.concept.concept",
            "short": "Child Concepts (is-a/contains/categorizes)",
            "definition": "Defines children of a concept to produce a hierarchy of concepts. The nature of the relationships is variable (is-a/contains/categorizes) - see hierarchyMeaning.",
            "min": 0,
            "max": "*",
            "contentReference": "#CodeSystem.concept"
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'CodeSystem'
    /// </summary>
    // 0. CodeSystem
    public class CodeSystem : FhirKhit.Maker.Common.Resource.ResourceBase                                                                   // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class CodeSystem_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                      // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 24. CodeSystem.filter
            public class Type_Filter : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Filter_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 25. CodeSystem.filter.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 26. CodeSystem.filter.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:216
                    // 27. CodeSystem.filter.operator
                    public ElementDefinitionInfo Operator;                                                                                  // MakerGen.cs:216
                    // 28. CodeSystem.filter.value
                    public ElementDefinitionInfo Value;                                                                                     // MakerGen.cs:216
                    public Type_Filter_Elements()                                                                                           // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 25. CodeSystem.filter.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "CodeSystem.filter.code",                                                                             // MakerGen.cs:236
                                Id = "CodeSystem.filter.code",                                                                              // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 26. CodeSystem.filter.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Description",                                                                                       // MakerGen.cs:235
                                Path= "CodeSystem.filter.description",                                                                      // MakerGen.cs:236
                                Id = "CodeSystem.filter.description",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 27. CodeSystem.filter.operator
                            this.Operator = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Operator",                                                                                          // MakerGen.cs:235
                                Path= "CodeSystem.filter.operator",                                                                         // MakerGen.cs:236
                                Id = "CodeSystem.filter.operator",                                                                          // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 28. CodeSystem.filter.value
                            this.Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Value",                                                                                             // MakerGen.cs:235
                                Path= "CodeSystem.filter.value",                                                                            // MakerGen.cs:236
                                Id = "CodeSystem.filter.value",                                                                             // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Description.Write(sDef);                                                                                            // MakerGen.cs:220
                        Operator.Write(sDef);                                                                                               // MakerGen.cs:220
                        Value.Write(sDef);                                                                                                  // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Filter_Elements Elements { get; }                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Filter()                                                                                                        // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Filter_Elements();                                                                             // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 29. CodeSystem.property
            public class Type_Property : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Property_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 30. CodeSystem.property.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 31. CodeSystem.property.uri
                    public ElementDefinitionInfo Uri;                                                                                       // MakerGen.cs:216
                    // 32. CodeSystem.property.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:216
                    // 33. CodeSystem.property.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    public Type_Property_Elements()                                                                                         // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 30. CodeSystem.property.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "CodeSystem.property.code",                                                                           // MakerGen.cs:236
                                Id = "CodeSystem.property.code",                                                                            // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 31. CodeSystem.property.uri
                            this.Uri = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Uri",                                                                                               // MakerGen.cs:235
                                Path= "CodeSystem.property.uri",                                                                            // MakerGen.cs:236
                                Id = "CodeSystem.property.uri",                                                                             // MakerGen.cs:237
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
                            // 32. CodeSystem.property.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Description",                                                                                       // MakerGen.cs:235
                                Path= "CodeSystem.property.description",                                                                    // MakerGen.cs:236
                                Id = "CodeSystem.property.description",                                                                     // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 33. CodeSystem.property.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "CodeSystem.property.type",                                                                           // MakerGen.cs:236
                                Id = "CodeSystem.property.type",                                                                            // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Uri.Write(sDef);                                                                                                    // MakerGen.cs:220
                        Description.Write(sDef);                                                                                            // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Property_Elements Elements { get; }                                                                             // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Property()                                                                                                      // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Property_Elements();                                                                           // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 34. CodeSystem.concept
            public class Type_Concept : FhirKhit.Maker.Common.Complex.ComplexBase                                                           // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Concept_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                            // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 38. CodeSystem.concept.designation
                    public class Type_Designation : FhirKhit.Maker.Common.Complex.ComplexBase                                               // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Designation_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 39. CodeSystem.concept.designation.language
                            public ElementDefinitionInfo Language;                                                                          // MakerGen.cs:216
                            // 40. CodeSystem.concept.designation.use
                            public ElementDefinitionInfo Use;                                                                               // MakerGen.cs:216
                            // 41. CodeSystem.concept.designation.value
                            public ElementDefinitionInfo Value;                                                                             // MakerGen.cs:216
                            public Type_Designation_Elements()                                                                              // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 39. CodeSystem.concept.designation.language
                                    this.Language = new ElementDefinitionInfo                                                               // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Language",                                                                                  // MakerGen.cs:235
                                        Path= "CodeSystem.concept.designation.language",                                                    // MakerGen.cs:236
                                        Id = "CodeSystem.concept.designation.language",                                                     // MakerGen.cs:237
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
                                    // 40. CodeSystem.concept.designation.use
                                    this.Use = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Use",                                                                                       // MakerGen.cs:235
                                        Path= "CodeSystem.concept.designation.use",                                                         // MakerGen.cs:236
                                        Id = "CodeSystem.concept.designation.use",                                                          // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Coding                                                        // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 41. CodeSystem.concept.designation.value
                                    this.Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Value",                                                                                     // MakerGen.cs:235
                                        Path= "CodeSystem.concept.designation.value",                                                       // MakerGen.cs:236
                                        Id = "CodeSystem.concept.designation.value",                                                        // MakerGen.cs:237
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
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Language.Write(sDef);                                                                                       // MakerGen.cs:220
                                Use.Write(sDef);                                                                                            // MakerGen.cs:220
                                Value.Write(sDef);                                                                                          // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Designation_Elements Elements { get; }                                                                  // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Designation()                                                                                           // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Designation_Elements();                                                                // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 42. CodeSystem.concept.property
                    public class Type_Property : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Property_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 43. CodeSystem.concept.property.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:216
                            // 44. CodeSystem.concept.property.value[x]
                            public ElementDefinitionInfo Value;                                                                             // MakerGen.cs:216
                            public Type_Property_Elements()                                                                                 // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 43. CodeSystem.concept.property.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Code",                                                                                      // MakerGen.cs:235
                                        Path= "CodeSystem.concept.property.code",                                                           // MakerGen.cs:236
                                        Id = "CodeSystem.concept.property.code",                                                            // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
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
                                    // 44. CodeSystem.concept.property.value[x]
                                    this.Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Value",                                                                                     // MakerGen.cs:235
                                        Path= "CodeSystem.concept.property.value[x]",                                                       // MakerGen.cs:236
                                        Id = "CodeSystem.concept.property.value[x]",                                                        // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            },                                                                                              // MakerGen.cs:304
                                            new FhirKhit.Maker.Common.Complex.Coding                                                        // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            },                                                                                              // MakerGen.cs:319
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            },                                                                                              // MakerGen.cs:304
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            },                                                                                              // MakerGen.cs:304
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            },                                                                                              // MakerGen.cs:304
                                            new FhirKhit.Maker.Common.Primitive.DateTime                                                    // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            },                                                                                              // MakerGen.cs:304
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Code.Write(sDef);                                                                                           // MakerGen.cs:220
                                Value.Write(sDef);                                                                                          // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Property_Elements Elements { get; }                                                                     // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Property()                                                                                              // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Property_Elements();                                                                   // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 35. CodeSystem.concept.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:216
                    // 36. CodeSystem.concept.display
                    public ElementDefinitionInfo Display;                                                                                   // MakerGen.cs:216
                    // 37. CodeSystem.concept.definition
                    public ElementDefinitionInfo Definition;                                                                                // MakerGen.cs:216
                    // 38. CodeSystem.concept.designation
                    public ElementDefinitionInfo Designation;                                                                               // MakerGen.cs:216
                    // 42. CodeSystem.concept.property
                    public ElementDefinitionInfo Property;                                                                                  // MakerGen.cs:216
                    // 45. CodeSystem.concept.concept
                    public ElementDefinitionInfo Concept;                                                                                   // MakerGen.cs:216
                    public Type_Concept_Elements()                                                                                          // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 35. CodeSystem.concept.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Code",                                                                                              // MakerGen.cs:235
                                Path= "CodeSystem.concept.code",                                                                            // MakerGen.cs:236
                                Id = "CodeSystem.concept.code",                                                                             // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 36. CodeSystem.concept.display
                            this.Display = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Display",                                                                                           // MakerGen.cs:235
                                Path= "CodeSystem.concept.display",                                                                         // MakerGen.cs:236
                                Id = "CodeSystem.concept.display",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 37. CodeSystem.concept.definition
                            this.Definition = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Definition",                                                                                        // MakerGen.cs:235
                                Path= "CodeSystem.concept.definition",                                                                      // MakerGen.cs:236
                                Id = "CodeSystem.concept.definition",                                                                       // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 38. CodeSystem.concept.designation
                            this.Designation = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Designation",                                                                                       // MakerGen.cs:235
                                Path= "CodeSystem.concept.designation",                                                                     // MakerGen.cs:236
                                Id = "CodeSystem.concept.designation",                                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Designation                                                                                    // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 42. CodeSystem.concept.property
                            this.Property = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Property",                                                                                          // MakerGen.cs:235
                                Path= "CodeSystem.concept.property",                                                                        // MakerGen.cs:236
                                Id = "CodeSystem.concept.property",                                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Property                                                                                       // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 45. CodeSystem.concept.concept
                            this.Concept = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Concept",                                                                                           // MakerGen.cs:235
                                Path= "CodeSystem.concept.concept",                                                                         // MakerGen.cs:236
                                Id = "CodeSystem.concept.concept",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Display.Write(sDef);                                                                                                // MakerGen.cs:220
                        Definition.Write(sDef);                                                                                             // MakerGen.cs:220
                        Designation.Write(sDef);                                                                                            // MakerGen.cs:220
                        Property.Write(sDef);                                                                                               // MakerGen.cs:220
                        Concept.Write(sDef);                                                                                                // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Concept_Elements Elements { get; }                                                                              // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Concept()                                                                                                       // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Concept_Elements();                                                                            // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. CodeSystem.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:216
            // 2. CodeSystem.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 3. CodeSystem.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:216
            // 4. CodeSystem.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 5. CodeSystem.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:216
            // 6. CodeSystem.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 7. CodeSystem.experimental
            public ElementDefinitionInfo Experimental;                                                                                      // MakerGen.cs:216
            // 8. CodeSystem.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:216
            // 9. CodeSystem.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:216
            // 10. CodeSystem.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:216
            // 11. CodeSystem.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 12. CodeSystem.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:216
            // 13. CodeSystem.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:216
            // 14. CodeSystem.purpose
            public ElementDefinitionInfo Purpose;                                                                                           // MakerGen.cs:216
            // 15. CodeSystem.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:216
            // 16. CodeSystem.caseSensitive
            public ElementDefinitionInfo CaseSensitive;                                                                                     // MakerGen.cs:216
            // 17. CodeSystem.valueSet
            public ElementDefinitionInfo ValueSet;                                                                                          // MakerGen.cs:216
            // 18. CodeSystem.hierarchyMeaning
            public ElementDefinitionInfo HierarchyMeaning;                                                                                  // MakerGen.cs:216
            // 19. CodeSystem.compositional
            public ElementDefinitionInfo Compositional;                                                                                     // MakerGen.cs:216
            // 20. CodeSystem.versionNeeded
            public ElementDefinitionInfo VersionNeeded;                                                                                     // MakerGen.cs:216
            // 21. CodeSystem.content
            public ElementDefinitionInfo Content;                                                                                           // MakerGen.cs:216
            // 22. CodeSystem.supplements
            public ElementDefinitionInfo Supplements;                                                                                       // MakerGen.cs:216
            // 23. CodeSystem.count
            public ElementDefinitionInfo Count;                                                                                             // MakerGen.cs:216
            // 24. CodeSystem.filter
            public ElementDefinitionInfo Filter;                                                                                            // MakerGen.cs:216
            // 29. CodeSystem.property
            public ElementDefinitionInfo Property;                                                                                          // MakerGen.cs:216
            // 34. CodeSystem.concept
            public ElementDefinitionInfo Concept;                                                                                           // MakerGen.cs:216
            public CodeSystem_Elements()                                                                                                    // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. CodeSystem.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Url",                                                                                                       // MakerGen.cs:235
                        Path= "CodeSystem.url",                                                                                             // MakerGen.cs:236
                        Id = "CodeSystem.url",                                                                                              // MakerGen.cs:237
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
                    // 2. CodeSystem.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "CodeSystem.identifier",                                                                                      // MakerGen.cs:236
                        Id = "CodeSystem.identifier",                                                                                       // MakerGen.cs:237
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
                    // 3. CodeSystem.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Version",                                                                                                   // MakerGen.cs:235
                        Path= "CodeSystem.version",                                                                                         // MakerGen.cs:236
                        Id = "CodeSystem.version",                                                                                          // MakerGen.cs:237
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
                    // 4. CodeSystem.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "CodeSystem.name",                                                                                            // MakerGen.cs:236
                        Id = "CodeSystem.name",                                                                                             // MakerGen.cs:237
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
                    // 5. CodeSystem.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Title",                                                                                                     // MakerGen.cs:235
                        Path= "CodeSystem.title",                                                                                           // MakerGen.cs:236
                        Id = "CodeSystem.title",                                                                                            // MakerGen.cs:237
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
                    // 6. CodeSystem.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "CodeSystem.status",                                                                                          // MakerGen.cs:236
                        Id = "CodeSystem.status",                                                                                           // MakerGen.cs:237
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
                    // 7. CodeSystem.experimental
                    this.Experimental = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Experimental",                                                                                              // MakerGen.cs:235
                        Path= "CodeSystem.experimental",                                                                                    // MakerGen.cs:236
                        Id = "CodeSystem.experimental",                                                                                     // MakerGen.cs:237
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
                    // 8. CodeSystem.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Date",                                                                                                      // MakerGen.cs:235
                        Path= "CodeSystem.date",                                                                                            // MakerGen.cs:236
                        Id = "CodeSystem.date",                                                                                             // MakerGen.cs:237
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
                    // 9. CodeSystem.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Publisher",                                                                                                 // MakerGen.cs:235
                        Path= "CodeSystem.publisher",                                                                                       // MakerGen.cs:236
                        Id = "CodeSystem.publisher",                                                                                        // MakerGen.cs:237
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
                    // 10. CodeSystem.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Contact",                                                                                                   // MakerGen.cs:235
                        Path= "CodeSystem.contact",                                                                                         // MakerGen.cs:236
                        Id = "CodeSystem.contact",                                                                                          // MakerGen.cs:237
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
                    // 11. CodeSystem.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "CodeSystem.description",                                                                                     // MakerGen.cs:236
                        Id = "CodeSystem.description",                                                                                      // MakerGen.cs:237
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
                    // 12. CodeSystem.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "UseContext",                                                                                                // MakerGen.cs:235
                        Path= "CodeSystem.useContext",                                                                                      // MakerGen.cs:236
                        Id = "CodeSystem.useContext",                                                                                       // MakerGen.cs:237
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
                    // 13. CodeSystem.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:235
                        Path= "CodeSystem.jurisdiction",                                                                                    // MakerGen.cs:236
                        Id = "CodeSystem.jurisdiction",                                                                                     // MakerGen.cs:237
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
                    // 14. CodeSystem.purpose
                    this.Purpose = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Purpose",                                                                                                   // MakerGen.cs:235
                        Path= "CodeSystem.purpose",                                                                                         // MakerGen.cs:236
                        Id = "CodeSystem.purpose",                                                                                          // MakerGen.cs:237
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
                    // 15. CodeSystem.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Copyright",                                                                                                 // MakerGen.cs:235
                        Path= "CodeSystem.copyright",                                                                                       // MakerGen.cs:236
                        Id = "CodeSystem.copyright",                                                                                        // MakerGen.cs:237
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
                    // 16. CodeSystem.caseSensitive
                    this.CaseSensitive = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "CaseSensitive",                                                                                             // MakerGen.cs:235
                        Path= "CodeSystem.caseSensitive",                                                                                   // MakerGen.cs:236
                        Id = "CodeSystem.caseSensitive",                                                                                    // MakerGen.cs:237
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
                    // 17. CodeSystem.valueSet
                    this.ValueSet = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ValueSet",                                                                                                  // MakerGen.cs:235
                        Path= "CodeSystem.valueSet",                                                                                        // MakerGen.cs:236
                        Id = "CodeSystem.valueSet",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                                TargetProfile = new String[]                                                                                // MakerGen.cs:303
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                      // MakerGen.cs:303
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 18. CodeSystem.hierarchyMeaning
                    this.HierarchyMeaning = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "HierarchyMeaning",                                                                                          // MakerGen.cs:235
                        Path= "CodeSystem.hierarchyMeaning",                                                                                // MakerGen.cs:236
                        Id = "CodeSystem.hierarchyMeaning",                                                                                 // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
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
                    // 19. CodeSystem.compositional
                    this.Compositional = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Compositional",                                                                                             // MakerGen.cs:235
                        Path= "CodeSystem.compositional",                                                                                   // MakerGen.cs:236
                        Id = "CodeSystem.compositional",                                                                                    // MakerGen.cs:237
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
                    // 20. CodeSystem.versionNeeded
                    this.VersionNeeded = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "VersionNeeded",                                                                                             // MakerGen.cs:235
                        Path= "CodeSystem.versionNeeded",                                                                                   // MakerGen.cs:236
                        Id = "CodeSystem.versionNeeded",                                                                                    // MakerGen.cs:237
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
                    // 21. CodeSystem.content
                    this.Content = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Content",                                                                                                   // MakerGen.cs:235
                        Path= "CodeSystem.content",                                                                                         // MakerGen.cs:236
                        Id = "CodeSystem.content",                                                                                          // MakerGen.cs:237
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
                    // 22. CodeSystem.supplements
                    this.Supplements = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Supplements",                                                                                               // MakerGen.cs:235
                        Path= "CodeSystem.supplements",                                                                                     // MakerGen.cs:236
                        Id = "CodeSystem.supplements",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                                TargetProfile = new String[]                                                                                // MakerGen.cs:303
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CodeSystem"                                                    // MakerGen.cs:303
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 23. CodeSystem.count
                    this.Count = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Count",                                                                                                     // MakerGen.cs:235
                        Path= "CodeSystem.count",                                                                                           // MakerGen.cs:236
                        Id = "CodeSystem.count",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                                 // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 24. CodeSystem.filter
                    this.Filter = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Filter",                                                                                                    // MakerGen.cs:235
                        Path= "CodeSystem.filter",                                                                                          // MakerGen.cs:236
                        Id = "CodeSystem.filter",                                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Filter                                                                                                 // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 29. CodeSystem.property
                    this.Property = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Property",                                                                                                  // MakerGen.cs:235
                        Path= "CodeSystem.property",                                                                                        // MakerGen.cs:236
                        Id = "CodeSystem.property",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Property                                                                                               // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 34. CodeSystem.concept
                    this.Concept = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Concept",                                                                                                   // MakerGen.cs:235
                        Path= "CodeSystem.concept",                                                                                         // MakerGen.cs:236
                        Id = "CodeSystem.concept",                                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Concept                                                                                                // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
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
                Purpose.Write(sDef);                                                                                                        // MakerGen.cs:220
                Copyright.Write(sDef);                                                                                                      // MakerGen.cs:220
                CaseSensitive.Write(sDef);                                                                                                  // MakerGen.cs:220
                ValueSet.Write(sDef);                                                                                                       // MakerGen.cs:220
                HierarchyMeaning.Write(sDef);                                                                                               // MakerGen.cs:220
                Compositional.Write(sDef);                                                                                                  // MakerGen.cs:220
                VersionNeeded.Write(sDef);                                                                                                  // MakerGen.cs:220
                Content.Write(sDef);                                                                                                        // MakerGen.cs:220
                Supplements.Write(sDef);                                                                                                    // MakerGen.cs:220
                Count.Write(sDef);                                                                                                          // MakerGen.cs:220
                Filter.Write(sDef);                                                                                                         // MakerGen.cs:220
                Property.Write(sDef);                                                                                                       // MakerGen.cs:220
                Concept.Write(sDef);                                                                                                        // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public CodeSystem_Elements Elements { get; }                                                                                        // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public CodeSystem()                                                                                                                 // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new CodeSystem_Elements();                                                                                      // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
