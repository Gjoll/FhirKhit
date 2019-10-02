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
    #endregion
    /// <summary>
    /// Fhir resource 'CodeSystem'
    /// </summary>
    // 0. CodeSystem
    public partial class Resource_CodeSystem : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 24. CodeSystem.filter
        public partial class Type_Filter : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 25. CodeSystem.filter.code
            public ElementDefinitionInfo Element_Code;
            // 26. CodeSystem.filter.description
            public ElementDefinitionInfo Element_Description;
            // 27. CodeSystem.filter.operator
            public ElementDefinitionInfo Element_Operator;
            // 28. CodeSystem.filter.value
            public ElementDefinitionInfo Element_Value;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "CodeSystem.filter",
                    ElementId = "CodeSystem.filter"
                });
                Element_Code.Write(sDef);
                Element_Description.Write(sDef);
                Element_Operator.Write(sDef);
                Element_Value.Write(sDef);
            }
            
            public Type_Filter()
            {
                {
                    // 25. CodeSystem.filter.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "CodeSystem.filter.code",
                        Id = "CodeSystem.filter.code",
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
                    // 26. CodeSystem.filter.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "CodeSystem.filter.description",
                        Id = "CodeSystem.filter.description",
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
                    // 27. CodeSystem.filter.operator
                    this.Element_Operator = new ElementDefinitionInfo
                    {
                        Name = "Element_Operator",
                        Path= "CodeSystem.filter.operator",
                        Id = "CodeSystem.filter.operator",
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
                    // 28. CodeSystem.filter.value
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "CodeSystem.filter.value",
                        Id = "CodeSystem.filter.value",
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
        // 29. CodeSystem.property
        public partial class Type_Property : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 30. CodeSystem.property.code
            public ElementDefinitionInfo Element_Code;
            // 31. CodeSystem.property.uri
            public ElementDefinitionInfo Element_Uri;
            // 32. CodeSystem.property.description
            public ElementDefinitionInfo Element_Description;
            // 33. CodeSystem.property.type
            public ElementDefinitionInfo Element_Type;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "CodeSystem.property",
                    ElementId = "CodeSystem.property"
                });
                Element_Code.Write(sDef);
                Element_Uri.Write(sDef);
                Element_Description.Write(sDef);
                Element_Type.Write(sDef);
            }
            
            public Type_Property()
            {
                {
                    // 30. CodeSystem.property.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "CodeSystem.property.code",
                        Id = "CodeSystem.property.code",
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
                    // 31. CodeSystem.property.uri
                    this.Element_Uri = new ElementDefinitionInfo
                    {
                        Name = "Element_Uri",
                        Path= "CodeSystem.property.uri",
                        Id = "CodeSystem.property.uri",
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
                    // 32. CodeSystem.property.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "CodeSystem.property.description",
                        Id = "CodeSystem.property.description",
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
                    // 33. CodeSystem.property.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "CodeSystem.property.type",
                        Id = "CodeSystem.property.type",
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
            }
        }
        // 34. CodeSystem.concept
        public partial class Type_Concept : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 38. CodeSystem.concept.designation
            public partial class Type_Designation : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 39. CodeSystem.concept.designation.language
                public ElementDefinitionInfo Element_Language;
                // 40. CodeSystem.concept.designation.use
                public ElementDefinitionInfo Element_Use;
                // 41. CodeSystem.concept.designation.value
                public ElementDefinitionInfo Element_Value;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "CodeSystem.concept.designation",
                        ElementId = "CodeSystem.concept.designation"
                    });
                    Element_Language.Write(sDef);
                    Element_Use.Write(sDef);
                    Element_Value.Write(sDef);
                }
                
                public Type_Designation()
                {
                    {
                        // 39. CodeSystem.concept.designation.language
                        this.Element_Language = new ElementDefinitionInfo
                        {
                            Name = "Element_Language",
                            Path= "CodeSystem.concept.designation.language",
                            Id = "CodeSystem.concept.designation.language",
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
                        // 40. CodeSystem.concept.designation.use
                        this.Element_Use = new ElementDefinitionInfo
                        {
                            Name = "Element_Use",
                            Path= "CodeSystem.concept.designation.use",
                            Id = "CodeSystem.concept.designation.use",
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
                        // 41. CodeSystem.concept.designation.value
                        this.Element_Value = new ElementDefinitionInfo
                        {
                            Name = "Element_Value",
                            Path= "CodeSystem.concept.designation.value",
                            Id = "CodeSystem.concept.designation.value",
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
            // 42. CodeSystem.concept.property
            public partial class Type_Property : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 43. CodeSystem.concept.property.code
                public ElementDefinitionInfo Element_Code;
                // 44. CodeSystem.concept.property.value[x]
                public ElementDefinitionInfo Element_Value;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "CodeSystem.concept.property",
                        ElementId = "CodeSystem.concept.property"
                    });
                    Element_Code.Write(sDef);
                    Element_Value.Write(sDef);
                }
                
                public Type_Property()
                {
                    {
                        // 43. CodeSystem.concept.property.code
                        this.Element_Code = new ElementDefinitionInfo
                        {
                            Name = "Element_Code",
                            Path= "CodeSystem.concept.property.code",
                            Id = "CodeSystem.concept.property.code",
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
                        // 44. CodeSystem.concept.property.value[x]
                        this.Element_Value = new ElementDefinitionInfo
                        {
                            Name = "Element_Value",
                            Path= "CodeSystem.concept.property.value[x]",
                            Id = "CodeSystem.concept.property.value[x]",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Coding
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 35. CodeSystem.concept.code
            public ElementDefinitionInfo Element_Code;
            // 36. CodeSystem.concept.display
            public ElementDefinitionInfo Element_Display;
            // 37. CodeSystem.concept.definition
            public ElementDefinitionInfo Element_Definition;
            // 38. CodeSystem.concept.designation
            public ElementDefinitionInfo Element_Designation;
            // 42. CodeSystem.concept.property
            public ElementDefinitionInfo Element_Property;
            // 45. CodeSystem.concept.concept
            public ElementDefinitionInfo Element_Concept;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "CodeSystem.concept",
                    ElementId = "CodeSystem.concept"
                });
                Element_Code.Write(sDef);
                Element_Display.Write(sDef);
                Element_Definition.Write(sDef);
                Element_Designation.Write(sDef);
                Element_Property.Write(sDef);
                Element_Concept.Write(sDef);
            }
            
            public Type_Concept()
            {
                {
                    // 35. CodeSystem.concept.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "CodeSystem.concept.code",
                        Id = "CodeSystem.concept.code",
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
                    // 36. CodeSystem.concept.display
                    this.Element_Display = new ElementDefinitionInfo
                    {
                        Name = "Element_Display",
                        Path= "CodeSystem.concept.display",
                        Id = "CodeSystem.concept.display",
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
                    // 37. CodeSystem.concept.definition
                    this.Element_Definition = new ElementDefinitionInfo
                    {
                        Name = "Element_Definition",
                        Path= "CodeSystem.concept.definition",
                        Id = "CodeSystem.concept.definition",
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
                    // 38. CodeSystem.concept.designation
                    this.Element_Designation = new ElementDefinitionInfo
                    {
                        Name = "Element_Designation",
                        Path= "CodeSystem.concept.designation",
                        Id = "CodeSystem.concept.designation",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Designation
                            {
                            }
                        }
                    };
                }
                {
                    // 42. CodeSystem.concept.property
                    this.Element_Property = new ElementDefinitionInfo
                    {
                        Name = "Element_Property",
                        Path= "CodeSystem.concept.property",
                        Id = "CodeSystem.concept.property",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Property
                            {
                            }
                        }
                    };
                }
                {
                    // 45. CodeSystem.concept.concept
                    this.Element_Concept = new ElementDefinitionInfo
                    {
                        Name = "Element_Concept",
                        Path= "CodeSystem.concept.concept",
                        Id = "CodeSystem.concept.concept",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
            }
        }
        // 1. CodeSystem.url
        public ElementDefinitionInfo Element_Url;
        // 2. CodeSystem.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. CodeSystem.version
        public ElementDefinitionInfo Element_Version;
        // 4. CodeSystem.name
        public ElementDefinitionInfo Element_Name;
        // 5. CodeSystem.title
        public ElementDefinitionInfo Element_Title;
        // 6. CodeSystem.status
        public ElementDefinitionInfo Element_Status;
        // 7. CodeSystem.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 8. CodeSystem.date
        public ElementDefinitionInfo Element_Date;
        // 9. CodeSystem.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 10. CodeSystem.contact
        public ElementDefinitionInfo Element_Contact;
        // 11. CodeSystem.description
        public ElementDefinitionInfo Element_Description;
        // 12. CodeSystem.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 13. CodeSystem.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 14. CodeSystem.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 15. CodeSystem.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 16. CodeSystem.caseSensitive
        public ElementDefinitionInfo Element_CaseSensitive;
        // 17. CodeSystem.valueSet
        public ElementDefinitionInfo Element_ValueSet;
        // 18. CodeSystem.hierarchyMeaning
        public ElementDefinitionInfo Element_HierarchyMeaning;
        // 19. CodeSystem.compositional
        public ElementDefinitionInfo Element_Compositional;
        // 20. CodeSystem.versionNeeded
        public ElementDefinitionInfo Element_VersionNeeded;
        // 21. CodeSystem.content
        public ElementDefinitionInfo Element_Content;
        // 22. CodeSystem.supplements
        public ElementDefinitionInfo Element_Supplements;
        // 23. CodeSystem.count
        public ElementDefinitionInfo Element_Count;
        // 24. CodeSystem.filter
        public ElementDefinitionInfo Element_Filter;
        // 29. CodeSystem.property
        public ElementDefinitionInfo Element_Property;
        // 34. CodeSystem.concept
        public ElementDefinitionInfo Element_Concept;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "CodeSystem",
                ElementId = "CodeSystem"
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
            Element_CaseSensitive.Write(sDef);
            Element_ValueSet.Write(sDef);
            Element_HierarchyMeaning.Write(sDef);
            Element_Compositional.Write(sDef);
            Element_VersionNeeded.Write(sDef);
            Element_Content.Write(sDef);
            Element_Supplements.Write(sDef);
            Element_Count.Write(sDef);
            Element_Filter.Write(sDef);
            Element_Property.Write(sDef);
            Element_Concept.Write(sDef);
        }
        
        public Resource_CodeSystem()
        {
            {
                // 1. CodeSystem.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "CodeSystem.url",
                    Id = "CodeSystem.url",
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
                // 2. CodeSystem.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "CodeSystem.identifier",
                    Id = "CodeSystem.identifier",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 3. CodeSystem.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "CodeSystem.version",
                    Id = "CodeSystem.version",
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
                // 4. CodeSystem.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "CodeSystem.name",
                    Id = "CodeSystem.name",
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
                // 5. CodeSystem.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "CodeSystem.title",
                    Id = "CodeSystem.title",
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
                // 6. CodeSystem.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "CodeSystem.status",
                    Id = "CodeSystem.status",
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
                // 7. CodeSystem.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "CodeSystem.experimental",
                    Id = "CodeSystem.experimental",
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
                // 8. CodeSystem.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "CodeSystem.date",
                    Id = "CodeSystem.date",
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
                // 9. CodeSystem.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "CodeSystem.publisher",
                    Id = "CodeSystem.publisher",
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
                // 10. CodeSystem.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "CodeSystem.contact",
                    Id = "CodeSystem.contact",
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
                // 11. CodeSystem.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "CodeSystem.description",
                    Id = "CodeSystem.description",
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
                // 12. CodeSystem.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "CodeSystem.useContext",
                    Id = "CodeSystem.useContext",
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
                // 13. CodeSystem.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "CodeSystem.jurisdiction",
                    Id = "CodeSystem.jurisdiction",
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
                // 14. CodeSystem.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "CodeSystem.purpose",
                    Id = "CodeSystem.purpose",
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
                // 15. CodeSystem.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "CodeSystem.copyright",
                    Id = "CodeSystem.copyright",
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
                // 16. CodeSystem.caseSensitive
                this.Element_CaseSensitive = new ElementDefinitionInfo
                {
                    Name = "Element_CaseSensitive",
                    Path= "CodeSystem.caseSensitive",
                    Id = "CodeSystem.caseSensitive",
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
                // 17. CodeSystem.valueSet
                this.Element_ValueSet = new ElementDefinitionInfo
                {
                    Name = "Element_ValueSet",
                    Path= "CodeSystem.valueSet",
                    Id = "CodeSystem.valueSet",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ValueSet"
                            }
                        }
                    }
                };
            }
            {
                // 18. CodeSystem.hierarchyMeaning
                this.Element_HierarchyMeaning = new ElementDefinitionInfo
                {
                    Name = "Element_HierarchyMeaning",
                    Path= "CodeSystem.hierarchyMeaning",
                    Id = "CodeSystem.hierarchyMeaning",
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
                // 19. CodeSystem.compositional
                this.Element_Compositional = new ElementDefinitionInfo
                {
                    Name = "Element_Compositional",
                    Path= "CodeSystem.compositional",
                    Id = "CodeSystem.compositional",
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
                // 20. CodeSystem.versionNeeded
                this.Element_VersionNeeded = new ElementDefinitionInfo
                {
                    Name = "Element_VersionNeeded",
                    Path= "CodeSystem.versionNeeded",
                    Id = "CodeSystem.versionNeeded",
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
                // 21. CodeSystem.content
                this.Element_Content = new ElementDefinitionInfo
                {
                    Name = "Element_Content",
                    Path= "CodeSystem.content",
                    Id = "CodeSystem.content",
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
                // 22. CodeSystem.supplements
                this.Element_Supplements = new ElementDefinitionInfo
                {
                    Name = "Element_Supplements",
                    Path= "CodeSystem.supplements",
                    Id = "CodeSystem.supplements",
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
                // 23. CodeSystem.count
                this.Element_Count = new ElementDefinitionInfo
                {
                    Name = "Element_Count",
                    Path= "CodeSystem.count",
                    Id = "CodeSystem.count",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                        {
                        }
                    }
                };
            }
            {
                // 24. CodeSystem.filter
                this.Element_Filter = new ElementDefinitionInfo
                {
                    Name = "Element_Filter",
                    Path= "CodeSystem.filter",
                    Id = "CodeSystem.filter",
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
                // 29. CodeSystem.property
                this.Element_Property = new ElementDefinitionInfo
                {
                    Name = "Element_Property",
                    Path= "CodeSystem.property",
                    Id = "CodeSystem.property",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Property
                        {
                        }
                    }
                };
            }
            {
                // 34. CodeSystem.concept
                this.Element_Concept = new ElementDefinitionInfo
                {
                    Name = "Element_Concept",
                    Path= "CodeSystem.concept",
                    Id = "CodeSystem.concept",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Concept
                        {
                        }
                    }
                };
            }
            this.Name = "CodeSystem";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/CodeSystem";
        }
    }
}
