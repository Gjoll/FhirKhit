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
      "id": "StructureMap",
      "url": "http://hl7.org/fhir/StructureDefinition/StructureMap",
      "version": "4.0.0",
      "name": "StructureMap",
      "status": "draft",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A Map of relationships between 2 structures that can be used to transform data.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "StructureMap",
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
            "id": "StructureMap",
            "path": "StructureMap",
            "short": "A Map of relationships between 2 structures that can be used to transform data",
            "definition": "A Map of relationships between 2 structures that can be used to transform data.",
            "alias": [
              "Template",
              "Profile"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "StructureMap.url",
            "path": "StructureMap.url",
            "short": "Canonical identifier for this structure map, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this structure map when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this structure map is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the structure map is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the structure map to be referenced by a single globally unique identifier.",
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
            "id": "StructureMap.identifier",
            "path": "StructureMap.identifier",
            "short": "Additional identifier for the structure map",
            "definition": "A formal identifier that is used to identify this structure map when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this structure map outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "StructureMap.version",
            "path": "StructureMap.version",
            "short": "Business version of the structure map",
            "definition": "The identifier that is used to identify this version of the structure map when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the structure map author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different structure map instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the structure map with the format [url]|[version].",
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
            "id": "StructureMap.name",
            "path": "StructureMap.name",
            "short": "Name for this structure map (computer friendly)",
            "definition": "A natural language name identifying the structure map. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "StructureMap.title",
            "path": "StructureMap.title",
            "short": "Name for this structure map (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the structure map.",
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
            "id": "StructureMap.status",
            "path": "StructureMap.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this structure map. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of structure maps that are appropriate for use versus not.",
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
            "id": "StructureMap.experimental",
            "path": "StructureMap.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this structure map is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of structure maps that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level structure map.",
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
            "id": "StructureMap.date",
            "path": "StructureMap.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the structure map was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the structure map changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the structure map. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "StructureMap.publisher",
            "path": "StructureMap.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the structure map.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the structure map is the organization or individual primarily responsible for the maintenance and upkeep of the structure map. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the structure map. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the structure map.  May also allow for contact.",
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
            "id": "StructureMap.contact",
            "path": "StructureMap.contact",
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
            "id": "StructureMap.description",
            "path": "StructureMap.description",
            "short": "Natural language description of the structure map",
            "definition": "A free text natural language description of the structure map from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the structure map was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the structure map as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the structure map is presumed to be the predominant language in the place the structure map was created).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "StructureMap.useContext",
            "path": "StructureMap.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate structure map instances.",
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
            "id": "StructureMap.jurisdiction",
            "path": "StructureMap.jurisdiction",
            "short": "Intended jurisdiction for structure map (if applicable)",
            "definition": "A legal or geographic region in which the structure map is intended to be used.",
            "comment": "It may be possible for the structure map to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "StructureMap.purpose",
            "path": "StructureMap.purpose",
            "short": "Why this structure map is defined",
            "definition": "Explanation of why this structure map is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the structure map. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this structure map.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "StructureMap.copyright",
            "path": "StructureMap.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the structure map and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the structure map.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the structure map and/or its content.",
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
            "id": "StructureMap.structure",
            "path": "StructureMap.structure",
            "short": "Structure Definition used by this map",
            "definition": "A structure definition used by this map. The structure definition may describe instances that are converted, or the instances that are produced.",
            "comment": "It is not necessary for a structure map to identify any dependent structures, though not listing them may restrict its usefulness.",
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
            "id": "StructureMap.structure.url",
            "path": "StructureMap.structure.url",
            "short": "Canonical reference to structure definition",
            "definition": "The canonical reference to the structure.",
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
            "id": "StructureMap.structure.mode",
            "path": "StructureMap.structure.mode",
            "short": "source | queried | target | produced",
            "definition": "How the referenced structure is used in this mapping.",
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
                  "valueString": "StructureMapModelMode"
                }
              ],
              "strength": "required",
              "description": "How the referenced structure is used in this mapping.",
              "valueSet": "http://hl7.org/fhir/ValueSet/map-model-mode|4.0.0"
            }
          },
          {
            "id": "StructureMap.structure.alias",
            "path": "StructureMap.structure.alias",
            "short": "Name for type in this map",
            "definition": "The name used for this type in the map.",
            "comment": "This is needed if both types have the same name (e.g. version conversion).",
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
            "id": "StructureMap.structure.documentation",
            "path": "StructureMap.structure.documentation",
            "short": "Documentation on use of structure",
            "definition": "Documentation that describes how the structure is used in the mapping.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "StructureMap.import",
            "path": "StructureMap.import",
            "short": "Other maps used by this map (canonical URLs)",
            "definition": "Other maps used by this map (canonical URLs).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureMap"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "StructureMap.group",
            "path": "StructureMap.group",
            "short": "Named sections for reader convenience",
            "definition": "Organizes the mapping into manageable chunks for human review/ease of maintenance.",
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
            "id": "StructureMap.group.name",
            "path": "StructureMap.group.name",
            "short": "Human-readable label",
            "definition": "A unique name for the group for the convenience of human readers.",
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
            "id": "StructureMap.group.extends",
            "path": "StructureMap.group.extends",
            "short": "Another group that this group adds rules to",
            "definition": "Another group that this group adds rules to.",
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
            "id": "StructureMap.group.typeMode",
            "path": "StructureMap.group.typeMode",
            "short": "none | types | type-and-types",
            "definition": "If this is the default rule set to apply for the source type or this combination of types.",
            "comment": "Not applicable if the underlying model is untyped. There can only be one default mapping for any particular type combination.",
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
                  "valueString": "StructureMapGroupTypeMode"
                }
              ],
              "strength": "required",
              "description": "If this is the default rule set to apply for the source type, or this combination of types.",
              "valueSet": "http://hl7.org/fhir/ValueSet/map-group-type-mode|4.0.0"
            }
          },
          {
            "id": "StructureMap.group.documentation",
            "path": "StructureMap.group.documentation",
            "short": "Additional description/explanation for group",
            "definition": "Additional supporting documentation that explains the purpose of the group and the types of mappings within it.",
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
            "id": "StructureMap.group.input",
            "path": "StructureMap.group.input",
            "short": "Named instance provided when invoking the map",
            "definition": "A name assigned to an instance of data. The instance must be provided when the mapping is invoked.",
            "comment": "If no inputs are named, then the entry mappings are type based.",
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
            "id": "StructureMap.group.input.name",
            "path": "StructureMap.group.input.name",
            "short": "Name for this instance of data",
            "definition": "Name for this instance of data.",
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
            "id": "StructureMap.group.input.type",
            "path": "StructureMap.group.input.type",
            "short": "Type for this instance of data",
            "definition": "Type for this instance of data.",
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
            "id": "StructureMap.group.input.mode",
            "path": "StructureMap.group.input.mode",
            "short": "source | target",
            "definition": "Mode for this instance of data.",
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
                  "valueString": "StructureMapInputMode"
                }
              ],
              "strength": "required",
              "description": "Mode for this instance of data.",
              "valueSet": "http://hl7.org/fhir/ValueSet/map-input-mode|4.0.0"
            }
          },
          {
            "id": "StructureMap.group.input.documentation",
            "path": "StructureMap.group.input.documentation",
            "short": "Documentation for this instance of data",
            "definition": "Documentation for this instance of data.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "StructureMap.group.rule",
            "path": "StructureMap.group.rule",
            "short": "Transform Rule from source to target",
            "definition": "Transform Rule from source to target.",
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
            "id": "StructureMap.group.rule.name",
            "path": "StructureMap.group.rule.name",
            "short": "Name of the rule for internal references",
            "definition": "Name of the rule for internal references.",
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
            "id": "StructureMap.group.rule.source",
            "path": "StructureMap.group.rule.source",
            "short": "Source inputs to the mapping",
            "definition": "Source inputs to the mapping.",
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
            "id": "StructureMap.group.rule.source.context",
            "path": "StructureMap.group.rule.source.context",
            "short": "Type or variable this rule applies to",
            "definition": "Type or variable this rule applies to.",
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
            "id": "StructureMap.group.rule.source.min",
            "path": "StructureMap.group.rule.source.min",
            "short": "Specified minimum cardinality",
            "definition": "Specified minimum cardinality for the element. This is optional; if present, it acts an implicit check on the input content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ],
            "isSummary": true
          },
          {
            "id": "StructureMap.group.rule.source.max",
            "path": "StructureMap.group.rule.source.max",
            "short": "Specified maximum cardinality (number or *)",
            "definition": "Specified maximum cardinality for the element - a number or a \"*\". This is optional; if present, it acts an implicit check on the input content (* just serves as documentation; it's the default value).",
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
            "id": "StructureMap.group.rule.source.type",
            "path": "StructureMap.group.rule.source.type",
            "short": "Rule only applies if source has this type",
            "definition": "Specified type for the element. This works as a condition on the mapping - use for polymorphic elements.",
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
            "id": "StructureMap.group.rule.source.defaultValue[x]",
            "path": "StructureMap.group.rule.source.defaultValue[x]",
            "short": "Default value if no value exists",
            "definition": "A value to use if there is no existing value in the source object.",
            "comment": "If there's a default value on an item that can repeat, it will only be used once.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "base64Binary"
              },
              {
                "code": "boolean"
              },
              {
                "code": "canonical"
              },
              {
                "code": "code"
              },
              {
                "code": "date"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "decimal"
              },
              {
                "code": "id"
              },
              {
                "code": "instant"
              },
              {
                "code": "integer"
              },
              {
                "code": "markdown"
              },
              {
                "code": "oid"
              },
              {
                "code": "positiveInt"
              },
              {
                "code": "string"
              },
              {
                "code": "time"
              },
              {
                "code": "unsignedInt"
              },
              {
                "code": "uri"
              },
              {
                "code": "url"
              },
              {
                "code": "uuid"
              },
              {
                "code": "Address"
              },
              {
                "code": "Age"
              },
              {
                "code": "Annotation"
              },
              {
                "code": "Attachment"
              },
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Coding"
              },
              {
                "code": "ContactPoint"
              },
              {
                "code": "Count"
              },
              {
                "code": "Distance"
              },
              {
                "code": "Duration"
              },
              {
                "code": "HumanName"
              },
              {
                "code": "Identifier"
              },
              {
                "code": "Money"
              },
              {
                "code": "Period"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "Ratio"
              },
              {
                "code": "Reference"
              },
              {
                "code": "SampledData"
              },
              {
                "code": "Signature"
              },
              {
                "code": "Timing"
              },
              {
                "code": "ContactDetail"
              },
              {
                "code": "Contributor"
              },
              {
                "code": "DataRequirement"
              },
              {
                "code": "Expression"
              },
              {
                "code": "ParameterDefinition"
              },
              {
                "code": "RelatedArtifact"
              },
              {
                "code": "TriggerDefinition"
              },
              {
                "code": "UsageContext"
              },
              {
                "code": "Dosage"
              }
            ],
            "isSummary": true
          },
          {
            "id": "StructureMap.group.rule.source.element",
            "path": "StructureMap.group.rule.source.element",
            "short": "Optional field for this source",
            "definition": "Optional field for this source.",
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
            "id": "StructureMap.group.rule.source.listMode",
            "path": "StructureMap.group.rule.source.listMode",
            "short": "first | not_first | last | not_last | only_one",
            "definition": "How to handle the list mode for this element.",
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
                  "valueString": "StructureMapSourceListMode"
                }
              ],
              "strength": "required",
              "description": "If field is a list, how to manage the source.",
              "valueSet": "http://hl7.org/fhir/ValueSet/map-source-list-mode|4.0.0"
            }
          },
          {
            "id": "StructureMap.group.rule.source.variable",
            "path": "StructureMap.group.rule.source.variable",
            "short": "Named context for field, if a field is specified",
            "definition": "Named context for field, if a field is specified.",
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
            "id": "StructureMap.group.rule.source.condition",
            "path": "StructureMap.group.rule.source.condition",
            "short": "FHIRPath expression  - must be true or the rule does not apply",
            "definition": "FHIRPath expression  - must be true or the rule does not apply.",
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
            "id": "StructureMap.group.rule.source.check",
            "path": "StructureMap.group.rule.source.check",
            "short": "FHIRPath expression  - must be true or the mapping engine throws an error instead of completing",
            "definition": "FHIRPath expression  - must be true or the mapping engine throws an error instead of completing.",
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
            "id": "StructureMap.group.rule.source.logMessage",
            "path": "StructureMap.group.rule.source.logMessage",
            "short": "Message to put in log if source exists (FHIRPath)",
            "definition": "A FHIRPath expression which specifies a message to put in the transform log when content matching the source rule is found.",
            "comment": "This is typically used for recording that something Is not transformed to the target for some reason.",
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
            "id": "StructureMap.group.rule.target",
            "path": "StructureMap.group.rule.target",
            "short": "Content to create because of this mapping rule",
            "definition": "Content to create because of this mapping rule.",
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
            "id": "StructureMap.group.rule.target.context",
            "path": "StructureMap.group.rule.target.context",
            "short": "Type or variable this rule applies to",
            "definition": "Type or variable this rule applies to.",
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
            "id": "StructureMap.group.rule.target.contextType",
            "path": "StructureMap.group.rule.target.contextType",
            "short": "type | variable",
            "definition": "How to interpret the context.",
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
                  "valueString": "StructureMapContextType"
                }
              ],
              "strength": "required",
              "description": "How to interpret the context.",
              "valueSet": "http://hl7.org/fhir/ValueSet/map-context-type|4.0.0"
            }
          },
          {
            "id": "StructureMap.group.rule.target.element",
            "path": "StructureMap.group.rule.target.element",
            "short": "Field to create in the context",
            "definition": "Field to create in the context.",
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
            "id": "StructureMap.group.rule.target.variable",
            "path": "StructureMap.group.rule.target.variable",
            "short": "Named context for field, if desired, and a field is specified",
            "definition": "Named context for field, if desired, and a field is specified.",
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
            "id": "StructureMap.group.rule.target.listMode",
            "path": "StructureMap.group.rule.target.listMode",
            "short": "first | share | last | collate",
            "definition": "If field is a list, how to manage the list.",
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
                  "valueString": "StructureMapTargetListMode"
                }
              ],
              "strength": "required",
              "description": "If field is a list, how to manage the production.",
              "valueSet": "http://hl7.org/fhir/ValueSet/map-target-list-mode|4.0.0"
            }
          },
          {
            "id": "StructureMap.group.rule.target.listRuleId",
            "path": "StructureMap.group.rule.target.listRuleId",
            "short": "Internal rule reference for shared list items",
            "definition": "Internal rule reference for shared list items.",
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
            "id": "StructureMap.group.rule.target.transform",
            "path": "StructureMap.group.rule.target.transform",
            "short": "create | copy +",
            "definition": "How the data is copied / created.",
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
                  "valueString": "StructureMapTransform"
                }
              ],
              "strength": "required",
              "description": "How data is copied/created.",
              "valueSet": "http://hl7.org/fhir/ValueSet/map-transform|4.0.0"
            }
          },
          {
            "id": "StructureMap.group.rule.target.parameter",
            "path": "StructureMap.group.rule.target.parameter",
            "short": "Parameters to the transform",
            "definition": "Parameters to the transform.",
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
            "id": "StructureMap.group.rule.target.parameter.value[x]",
            "path": "StructureMap.group.rule.target.parameter.value[x]",
            "short": "Parameter value - variable or literal",
            "definition": "Parameter value - variable or literal.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "id"
              },
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
              }
            ],
            "isSummary": true
          },
          {
            "id": "StructureMap.group.rule.rule",
            "path": "StructureMap.group.rule.rule",
            "short": "Rules contained in this rule",
            "definition": "Rules contained in this rule.",
            "min": 0,
            "max": "*",
            "contentReference": "#StructureMap.group.rule",
            "isSummary": true
          },
          {
            "id": "StructureMap.group.rule.dependent",
            "path": "StructureMap.group.rule.dependent",
            "short": "Which other rules to apply in the context of this rule",
            "definition": "Which other rules to apply in the context of this rule.",
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
            "id": "StructureMap.group.rule.dependent.name",
            "path": "StructureMap.group.rule.dependent.name",
            "short": "Name of a rule or group to apply",
            "definition": "Name of a rule or group to apply.",
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
            "id": "StructureMap.group.rule.dependent.variable",
            "path": "StructureMap.group.rule.dependent.variable",
            "short": "Variable to pass to the rule or group",
            "definition": "Variable to pass to the rule or group.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "StructureMap.group.rule.documentation",
            "path": "StructureMap.group.rule.documentation",
            "short": "Documentation for this instance of data",
            "definition": "Documentation for this instance of data.",
            "min": 0,
            "max": "1",
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
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'StructureMap'
    /// </summary>
    // 0. StructureMap
    public class StructureMap : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class StructureMap_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 16. StructureMap.structure
            public class Type_Structure : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Structure_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 17. StructureMap.structure.url
                    public ElementDefinitionInfo Url;                                                                                       // MakerGen.cs:216
                    // 18. StructureMap.structure.mode
                    public ElementDefinitionInfo Mode;                                                                                      // MakerGen.cs:216
                    // 19. StructureMap.structure.alias
                    public ElementDefinitionInfo Alias;                                                                                     // MakerGen.cs:216
                    // 20. StructureMap.structure.documentation
                    public ElementDefinitionInfo Documentation;                                                                             // MakerGen.cs:216
                    public Type_Structure_Elements()                                                                                        // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 17. StructureMap.structure.url
                            this.Url = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Url",                                                                                               // MakerGen.cs:235
                                Path= "StructureMap.structure.url",                                                                         // MakerGen.cs:236
                                Id = "StructureMap.structure.url",                                                                          // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Canonical                                                           // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:303
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                   // MakerGen.cs:303
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 18. StructureMap.structure.mode
                            this.Mode = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Mode",                                                                                              // MakerGen.cs:235
                                Path= "StructureMap.structure.mode",                                                                        // MakerGen.cs:236
                                Id = "StructureMap.structure.mode",                                                                         // MakerGen.cs:237
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
                            // 19. StructureMap.structure.alias
                            this.Alias = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Alias",                                                                                             // MakerGen.cs:235
                                Path= "StructureMap.structure.alias",                                                                       // MakerGen.cs:236
                                Id = "StructureMap.structure.alias",                                                                        // MakerGen.cs:237
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
                            // 20. StructureMap.structure.documentation
                            this.Documentation = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Documentation",                                                                                     // MakerGen.cs:235
                                Path= "StructureMap.structure.documentation",                                                               // MakerGen.cs:236
                                Id = "StructureMap.structure.documentation",                                                                // MakerGen.cs:237
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
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Url.Write(sDef);                                                                                                    // MakerGen.cs:220
                        Mode.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Alias.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Documentation.Write(sDef);                                                                                          // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Structure_Elements Elements { get; }                                                                            // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Structure()                                                                                                     // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Structure_Elements();                                                                          // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 22. StructureMap.group
            public class Type_Group : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                public class Type_Group_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:386
                    // 27. StructureMap.group.input
                    public class Type_Input : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Input_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                      // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 28. StructureMap.group.input.name
                            public ElementDefinitionInfo Name;                                                                              // MakerGen.cs:216
                            // 29. StructureMap.group.input.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:216
                            // 30. StructureMap.group.input.mode
                            public ElementDefinitionInfo Mode;                                                                              // MakerGen.cs:216
                            // 31. StructureMap.group.input.documentation
                            public ElementDefinitionInfo Documentation;                                                                     // MakerGen.cs:216
                            public Type_Input_Elements()                                                                                    // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 28. StructureMap.group.input.name
                                    this.Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Name",                                                                                      // MakerGen.cs:235
                                        Path= "StructureMap.group.input.name",                                                              // MakerGen.cs:236
                                        Id = "StructureMap.group.input.name",                                                               // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Id                                                          // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 29. StructureMap.group.input.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Type",                                                                                      // MakerGen.cs:235
                                        Path= "StructureMap.group.input.type",                                                              // MakerGen.cs:236
                                        Id = "StructureMap.group.input.type",                                                               // MakerGen.cs:237
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
                                    // 30. StructureMap.group.input.mode
                                    this.Mode = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Mode",                                                                                      // MakerGen.cs:235
                                        Path= "StructureMap.group.input.mode",                                                              // MakerGen.cs:236
                                        Id = "StructureMap.group.input.mode",                                                               // MakerGen.cs:237
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
                                    // 31. StructureMap.group.input.documentation
                                    this.Documentation = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Documentation",                                                                             // MakerGen.cs:235
                                        Path= "StructureMap.group.input.documentation",                                                     // MakerGen.cs:236
                                        Id = "StructureMap.group.input.documentation",                                                      // MakerGen.cs:237
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
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Name.Write(sDef);                                                                                           // MakerGen.cs:220
                                Type.Write(sDef);                                                                                           // MakerGen.cs:220
                                Mode.Write(sDef);                                                                                           // MakerGen.cs:220
                                Documentation.Write(sDef);                                                                                  // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Input_Elements Elements { get; }                                                                        // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Input()                                                                                                 // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Input_Elements();                                                                      // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 32. StructureMap.group.rule
                    public class Type_Rule : FhirKhit.Maker.Common.Complex.ComplexBase                                                      // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        public class Type_Rule_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                       // MakerGen.cs:385
                        {                                                                                                                   // MakerGen.cs:386
                            // 34. StructureMap.group.rule.source
                            public class Type_Source : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_Source_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                             // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 35. StructureMap.group.rule.source.context
                                    public ElementDefinitionInfo Context;                                                                   // MakerGen.cs:216
                                    // 36. StructureMap.group.rule.source.min
                                    public ElementDefinitionInfo Min;                                                                       // MakerGen.cs:216
                                    // 37. StructureMap.group.rule.source.max
                                    public ElementDefinitionInfo Max;                                                                       // MakerGen.cs:216
                                    // 38. StructureMap.group.rule.source.type
                                    public ElementDefinitionInfo Type;                                                                      // MakerGen.cs:216
                                    // 39. StructureMap.group.rule.source.defaultValue[x]
                                    public ElementDefinitionInfo DefaultValue;                                                              // MakerGen.cs:216
                                    // 40. StructureMap.group.rule.source.element
                                    public ElementDefinitionInfo Element;                                                                   // MakerGen.cs:216
                                    // 41. StructureMap.group.rule.source.listMode
                                    public ElementDefinitionInfo ListMode;                                                                  // MakerGen.cs:216
                                    // 42. StructureMap.group.rule.source.variable
                                    public ElementDefinitionInfo Variable;                                                                  // MakerGen.cs:216
                                    // 43. StructureMap.group.rule.source.condition
                                    public ElementDefinitionInfo Condition;                                                                 // MakerGen.cs:216
                                    // 44. StructureMap.group.rule.source.check
                                    public ElementDefinitionInfo Check;                                                                     // MakerGen.cs:216
                                    // 45. StructureMap.group.rule.source.logMessage
                                    public ElementDefinitionInfo LogMessage;                                                                // MakerGen.cs:216
                                    public Type_Source_Elements()                                                                           // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 35. StructureMap.group.rule.source.context
                                            this.Context = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Context",                                                                           // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.source.context",                                             // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.source.context",                                              // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Id                                                  // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 36. StructureMap.group.rule.source.min
                                            this.Min = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Min",                                                                               // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.source.min",                                                 // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.source.min",                                                  // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Integer                                             // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 37. StructureMap.group.rule.source.max
                                            this.Max = new ElementDefinitionInfo                                                            // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Max",                                                                               // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.source.max",                                                 // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.source.max",                                                  // MakerGen.cs:237
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
                                            // 38. StructureMap.group.rule.source.type
                                            this.Type = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Type",                                                                              // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.source.type",                                                // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.source.type",                                                 // MakerGen.cs:237
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
                                            // 39. StructureMap.group.rule.source.defaultValue[x]
                                            this.DefaultValue = new ElementDefinitionInfo                                                   // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "DefaultValue",                                                                      // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.source.defaultValue[x]",                                     // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.source.defaultValue[x]",                                      // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Base64Binary                                        // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Boolean                                             // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Canonical                                           // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Code                                                // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Date                                                // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.DateTime                                            // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Decimal                                             // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Id                                                  // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Instant                                             // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Integer                                             // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Markdown                                            // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Oid                                                 // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                         // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Time                                                // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.UnsignedInt                                         // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Uri                                                 // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Url                                                 // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Primitive.Uuid                                                // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    },                                                                                      // MakerGen.cs:304
                                                    new FhirKhit.Maker.Common.Complex.Address                                               // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Age                                                   // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Annotation                                            // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Attachment                                            // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                       // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    },                                                                                      // MakerGen.cs:319
                                                    new FhirKhit.Maker.Common.Complex.Coding                                                // MakerGen.cs:315
                                                    {                                                                                       // MakerGen.cs:316
                                                    },                                                                                      // MakerGen.cs:319
                                                    new FhirKhit.Maker.Common.Complex.ContactPoint                                          // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Count                                                 // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Distance                                              // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Duration                                              // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.HumanName                                             // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Identifier                                            // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Money                                                 // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Period                                                // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Quantity                                              // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Range                                                 // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Ratio                                                 // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Reference                                             // MakerGen.cs:346
                                                    {                                                                                       // MakerGen.cs:347
                                                    },                                                                                      // MakerGen.cs:350
                                                    new FhirKhit.Maker.Common.Complex.SampledData                                           // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Signature                                             // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Timing                                                // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.ContactDetail                                         // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Contributor                                           // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.DataRequirement                                       // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Expression                                            // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.ParameterDefinition                                   // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.RelatedArtifact                                       // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.TriggerDefinition                                     // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.UsageContext                                          // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    },                                                                                      // MakerGen.cs:360
                                                    new FhirKhit.Maker.Common.Complex.Dosage                                                // MakerGen.cs:358
                                                    {                                                                                       // MakerGen.cs:359
                                                    }                                                                                       // MakerGen.cs:360
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 40. StructureMap.group.rule.source.element
                                            this.Element = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Element",                                                                           // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.source.element",                                             // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.source.element",                                              // MakerGen.cs:237
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
                                            // 41. StructureMap.group.rule.source.listMode
                                            this.ListMode = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "ListMode",                                                                          // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.source.listMode",                                            // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.source.listMode",                                             // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
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
                                            // 42. StructureMap.group.rule.source.variable
                                            this.Variable = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Variable",                                                                          // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.source.variable",                                            // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.source.variable",                                             // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Id                                                  // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 43. StructureMap.group.rule.source.condition
                                            this.Condition = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Condition",                                                                         // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.source.condition",                                           // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.source.condition",                                            // MakerGen.cs:237
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
                                            // 44. StructureMap.group.rule.source.check
                                            this.Check = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Check",                                                                             // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.source.check",                                               // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.source.check",                                                // MakerGen.cs:237
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
                                            // 45. StructureMap.group.rule.source.logMessage
                                            this.LogMessage = new ElementDefinitionInfo                                                     // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "LogMessage",                                                                        // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.source.logMessage",                                          // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.source.logMessage",                                           // MakerGen.cs:237
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
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Context.Write(sDef);                                                                                // MakerGen.cs:220
                                        Min.Write(sDef);                                                                                    // MakerGen.cs:220
                                        Max.Write(sDef);                                                                                    // MakerGen.cs:220
                                        Type.Write(sDef);                                                                                   // MakerGen.cs:220
                                        DefaultValue.Write(sDef);                                                                           // MakerGen.cs:220
                                        Element.Write(sDef);                                                                                // MakerGen.cs:220
                                        ListMode.Write(sDef);                                                                               // MakerGen.cs:220
                                        Variable.Write(sDef);                                                                               // MakerGen.cs:220
                                        Condition.Write(sDef);                                                                              // MakerGen.cs:220
                                        Check.Write(sDef);                                                                                  // MakerGen.cs:220
                                        LogMessage.Write(sDef);                                                                             // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_Source_Elements Elements { get; }                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_Source()                                                                                        // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_Source_Elements();                                                             // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 46. StructureMap.group.rule.target
                            public class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_Target_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                             // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 54. StructureMap.group.rule.target.parameter
                                    public class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase                                 // MakerGen.cs:383
                                    {                                                                                                       // MakerGen.cs:384
                                        public class Type_Parameter_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                  // MakerGen.cs:385
                                        {                                                                                                   // MakerGen.cs:386
                                            // 55. StructureMap.group.rule.target.parameter.value[x]
                                            public ElementDefinitionInfo Value;                                                             // MakerGen.cs:216
                                            public Type_Parameter_Elements()                                                                // MakerGen.cs:407
                                            {                                                                                               // MakerGen.cs:408
                                                {                                                                                           // MakerGen.cs:231
                                                    // 55. StructureMap.group.rule.target.parameter.value[x]
                                                    this.Value = new ElementDefinitionInfo                                                  // MakerGen.cs:233
                                                    {                                                                                       // MakerGen.cs:234
                                                        Name = "Value",                                                                     // MakerGen.cs:235
                                                        Path= "StructureMap.group.rule.target.parameter.value[x]",                          // MakerGen.cs:236
                                                        Id = "StructureMap.group.rule.target.parameter.value[x]",                           // MakerGen.cs:237
                                                        Min = 1,                                                                            // MakerGen.cs:238
                                                        Max = 1,                                                                            // MakerGen.cs:239
                                                        Types = new BaseType[]                                                              // MakerGen.cs:240
                                                        {                                                                                   // MakerGen.cs:241
                                                            new FhirKhit.Maker.Common.Primitive.Id                                          // MakerGen.cs:300
                                                            {                                                                               // MakerGen.cs:301
                                                            },                                                                              // MakerGen.cs:304
                                                            new FhirKhit.Maker.Common.Primitive.String                                      // MakerGen.cs:300
                                                            {                                                                               // MakerGen.cs:301
                                                            },                                                                              // MakerGen.cs:304
                                                            new FhirKhit.Maker.Common.Primitive.Boolean                                     // MakerGen.cs:300
                                                            {                                                                               // MakerGen.cs:301
                                                            },                                                                              // MakerGen.cs:304
                                                            new FhirKhit.Maker.Common.Primitive.Integer                                     // MakerGen.cs:300
                                                            {                                                                               // MakerGen.cs:301
                                                            },                                                                              // MakerGen.cs:304
                                                            new FhirKhit.Maker.Common.Primitive.Decimal                                     // MakerGen.cs:300
                                                            {                                                                               // MakerGen.cs:301
                                                            }                                                                               // MakerGen.cs:304
                                                        }                                                                                   // MakerGen.cs:243
                                                    };                                                                                      // MakerGen.cs:244
                                                }                                                                                           // MakerGen.cs:245
                                            }                                                                                               // MakerGen.cs:427
                                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                             // MakerGen.cs:412
                                            {                                                                                               // MakerGen.cs:413
                                                base.Write(sDef);                                                                           // MakerGen.cs:414
                                                Value.Write(sDef);                                                                          // MakerGen.cs:220
                                            }                                                                                               // MakerGen.cs:431
                                        }                                                                                                   // MakerGen.cs:391
                                        public Type_Parameter_Elements Elements { get; }                                                    // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                        public Type_Parameter()                                                                             // MakerGen.cs:394
                                        {                                                                                                   // MakerGen.cs:395
                                            this.Elements = new Type_Parameter_Elements();                                                  // MakerGen.cs:396
                                        }                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                 // MakerGen.cs:399
                                        {                                                                                                   // MakerGen.cs:400
                                            this.Elements.Write(sDef);                                                                      // MakerGen.cs:401
                                        }                                                                                                   // MakerGen.cs:402
                                    }                                                                                                       // MakerGen.cs:403
                                    // 47. StructureMap.group.rule.target.context
                                    public ElementDefinitionInfo Context;                                                                   // MakerGen.cs:216
                                    // 48. StructureMap.group.rule.target.contextType
                                    public ElementDefinitionInfo ContextType;                                                               // MakerGen.cs:216
                                    // 49. StructureMap.group.rule.target.element
                                    public ElementDefinitionInfo Element;                                                                   // MakerGen.cs:216
                                    // 50. StructureMap.group.rule.target.variable
                                    public ElementDefinitionInfo Variable;                                                                  // MakerGen.cs:216
                                    // 51. StructureMap.group.rule.target.listMode
                                    public ElementDefinitionInfo ListMode;                                                                  // MakerGen.cs:216
                                    // 52. StructureMap.group.rule.target.listRuleId
                                    public ElementDefinitionInfo ListRuleId;                                                                // MakerGen.cs:216
                                    // 53. StructureMap.group.rule.target.transform
                                    public ElementDefinitionInfo Transform;                                                                 // MakerGen.cs:216
                                    // 54. StructureMap.group.rule.target.parameter
                                    public ElementDefinitionInfo Parameter;                                                                 // MakerGen.cs:216
                                    public Type_Target_Elements()                                                                           // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 47. StructureMap.group.rule.target.context
                                            this.Context = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Context",                                                                           // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.target.context",                                             // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.target.context",                                              // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Id                                                  // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 48. StructureMap.group.rule.target.contextType
                                            this.ContextType = new ElementDefinitionInfo                                                    // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "ContextType",                                                                       // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.target.contextType",                                         // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.target.contextType",                                          // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
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
                                            // 49. StructureMap.group.rule.target.element
                                            this.Element = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Element",                                                                           // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.target.element",                                             // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.target.element",                                              // MakerGen.cs:237
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
                                            // 50. StructureMap.group.rule.target.variable
                                            this.Variable = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Variable",                                                                          // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.target.variable",                                            // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.target.variable",                                             // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Id                                                  // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 51. StructureMap.group.rule.target.listMode
                                            this.ListMode = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "ListMode",                                                                          // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.target.listMode",                                            // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.target.listMode",                                             // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Code                                                // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 52. StructureMap.group.rule.target.listRuleId
                                            this.ListRuleId = new ElementDefinitionInfo                                                     // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "ListRuleId",                                                                        // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.target.listRuleId",                                          // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.target.listRuleId",                                           // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Id                                                  // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 53. StructureMap.group.rule.target.transform
                                            this.Transform = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Transform",                                                                         // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.target.transform",                                           // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.target.transform",                                            // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
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
                                            // 54. StructureMap.group.rule.target.parameter
                                            this.Parameter = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Parameter",                                                                         // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.target.parameter",                                           // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.target.parameter",                                            // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new Type_Parameter                                                                      // MakerGen.cs:259
                                                    {                                                                                       // MakerGen.cs:260
                                                    }                                                                                       // MakerGen.cs:261
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Context.Write(sDef);                                                                                // MakerGen.cs:220
                                        ContextType.Write(sDef);                                                                            // MakerGen.cs:220
                                        Element.Write(sDef);                                                                                // MakerGen.cs:220
                                        Variable.Write(sDef);                                                                               // MakerGen.cs:220
                                        ListMode.Write(sDef);                                                                               // MakerGen.cs:220
                                        ListRuleId.Write(sDef);                                                                             // MakerGen.cs:220
                                        Transform.Write(sDef);                                                                              // MakerGen.cs:220
                                        Parameter.Write(sDef);                                                                              // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_Target_Elements Elements { get; }                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_Target()                                                                                        // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_Target_Elements();                                                             // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 57. StructureMap.group.rule.dependent
                            public class Type_Dependent : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:383
                            {                                                                                                               // MakerGen.cs:384
                                public class Type_Dependent_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                          // MakerGen.cs:385
                                {                                                                                                           // MakerGen.cs:386
                                    // 58. StructureMap.group.rule.dependent.name
                                    public ElementDefinitionInfo Name;                                                                      // MakerGen.cs:216
                                    // 59. StructureMap.group.rule.dependent.variable
                                    public ElementDefinitionInfo Variable;                                                                  // MakerGen.cs:216
                                    public Type_Dependent_Elements()                                                                        // MakerGen.cs:407
                                    {                                                                                                       // MakerGen.cs:408
                                        {                                                                                                   // MakerGen.cs:231
                                            // 58. StructureMap.group.rule.dependent.name
                                            this.Name = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Name",                                                                              // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.dependent.name",                                             // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.dependent.name",                                              // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = 1,                                                                                    // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.Id                                                  // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 59. StructureMap.group.rule.dependent.variable
                                            this.Variable = new ElementDefinitionInfo                                                       // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Variable",                                                                          // MakerGen.cs:235
                                                Path= "StructureMap.group.rule.dependent.variable",                                         // MakerGen.cs:236
                                                Id = "StructureMap.group.rule.dependent.variable",                                          // MakerGen.cs:237
                                                Min = 1,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new FhirKhit.Maker.Common.Primitive.String                                              // MakerGen.cs:300
                                                    {                                                                                       // MakerGen.cs:301
                                                    }                                                                                       // MakerGen.cs:304
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                    }                                                                                                       // MakerGen.cs:427
                                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                     // MakerGen.cs:412
                                    {                                                                                                       // MakerGen.cs:413
                                        base.Write(sDef);                                                                                   // MakerGen.cs:414
                                        Name.Write(sDef);                                                                                   // MakerGen.cs:220
                                        Variable.Write(sDef);                                                                               // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:431
                                }                                                                                                           // MakerGen.cs:391
                                public Type_Dependent_Elements Elements { get; }                                                            // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                                public Type_Dependent()                                                                                     // MakerGen.cs:394
                                {                                                                                                           // MakerGen.cs:395
                                    this.Elements = new Type_Dependent_Elements();                                                          // MakerGen.cs:396
                                }                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:399
                                {                                                                                                           // MakerGen.cs:400
                                    this.Elements.Write(sDef);                                                                              // MakerGen.cs:401
                                }                                                                                                           // MakerGen.cs:402
                            }                                                                                                               // MakerGen.cs:403
                            // 33. StructureMap.group.rule.name
                            public ElementDefinitionInfo Name;                                                                              // MakerGen.cs:216
                            // 34. StructureMap.group.rule.source
                            public ElementDefinitionInfo Source;                                                                            // MakerGen.cs:216
                            // 46. StructureMap.group.rule.target
                            public ElementDefinitionInfo Target;                                                                            // MakerGen.cs:216
                            // 56. StructureMap.group.rule.rule
                            public ElementDefinitionInfo Rule;                                                                              // MakerGen.cs:216
                            // 57. StructureMap.group.rule.dependent
                            public ElementDefinitionInfo Dependent;                                                                         // MakerGen.cs:216
                            // 60. StructureMap.group.rule.documentation
                            public ElementDefinitionInfo Documentation;                                                                     // MakerGen.cs:216
                            public Type_Rule_Elements()                                                                                     // MakerGen.cs:407
                            {                                                                                                               // MakerGen.cs:408
                                {                                                                                                           // MakerGen.cs:231
                                    // 33. StructureMap.group.rule.name
                                    this.Name = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Name",                                                                                      // MakerGen.cs:235
                                        Path= "StructureMap.group.rule.name",                                                               // MakerGen.cs:236
                                        Id = "StructureMap.group.rule.name",                                                                // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Id                                                          // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 34. StructureMap.group.rule.source
                                    this.Source = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Source",                                                                                    // MakerGen.cs:235
                                        Path= "StructureMap.group.rule.source",                                                             // MakerGen.cs:236
                                        Id = "StructureMap.group.rule.source",                                                              // MakerGen.cs:237
                                        Min = 1,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Source                                                                                 // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 46. StructureMap.group.rule.target
                                    this.Target = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Target",                                                                                    // MakerGen.cs:235
                                        Path= "StructureMap.group.rule.target",                                                             // MakerGen.cs:236
                                        Id = "StructureMap.group.rule.target",                                                              // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Target                                                                                 // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 56. StructureMap.group.rule.rule
                                    this.Rule = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Rule",                                                                                      // MakerGen.cs:235
                                        Path= "StructureMap.group.rule.rule",                                                               // MakerGen.cs:236
                                        Id = "StructureMap.group.rule.rule",                                                                // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 57. StructureMap.group.rule.dependent
                                    this.Dependent = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Dependent",                                                                                 // MakerGen.cs:235
                                        Path= "StructureMap.group.rule.dependent",                                                          // MakerGen.cs:236
                                        Id = "StructureMap.group.rule.dependent",                                                           // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new Type_Dependent                                                                              // MakerGen.cs:259
                                            {                                                                                               // MakerGen.cs:260
                                            }                                                                                               // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 60. StructureMap.group.rule.documentation
                                    this.Documentation = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Documentation",                                                                             // MakerGen.cs:235
                                        Path= "StructureMap.group.rule.documentation",                                                      // MakerGen.cs:236
                                        Id = "StructureMap.group.rule.documentation",                                                       // MakerGen.cs:237
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
                            }                                                                                                               // MakerGen.cs:427
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:412
                            {                                                                                                               // MakerGen.cs:413
                                base.Write(sDef);                                                                                           // MakerGen.cs:414
                                Name.Write(sDef);                                                                                           // MakerGen.cs:220
                                Source.Write(sDef);                                                                                         // MakerGen.cs:220
                                Target.Write(sDef);                                                                                         // MakerGen.cs:220
                                Rule.Write(sDef);                                                                                           // MakerGen.cs:220
                                Dependent.Write(sDef);                                                                                      // MakerGen.cs:220
                                Documentation.Write(sDef);                                                                                  // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:431
                        }                                                                                                                   // MakerGen.cs:391
                        public Type_Rule_Elements Elements { get; }                                                                         // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                        public Type_Rule()                                                                                                  // MakerGen.cs:394
                        {                                                                                                                   // MakerGen.cs:395
                            this.Elements = new Type_Rule_Elements();                                                                       // MakerGen.cs:396
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:399
                        {                                                                                                                   // MakerGen.cs:400
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:401
                        }                                                                                                                   // MakerGen.cs:402
                    }                                                                                                                       // MakerGen.cs:403
                    // 23. StructureMap.group.name
                    public ElementDefinitionInfo Name;                                                                                      // MakerGen.cs:216
                    // 24. StructureMap.group.extends
                    public ElementDefinitionInfo Extends;                                                                                   // MakerGen.cs:216
                    // 25. StructureMap.group.typeMode
                    public ElementDefinitionInfo TypeMode;                                                                                  // MakerGen.cs:216
                    // 26. StructureMap.group.documentation
                    public ElementDefinitionInfo Documentation;                                                                             // MakerGen.cs:216
                    // 27. StructureMap.group.input
                    public ElementDefinitionInfo Input;                                                                                     // MakerGen.cs:216
                    // 32. StructureMap.group.rule
                    public ElementDefinitionInfo Rule;                                                                                      // MakerGen.cs:216
                    public Type_Group_Elements()                                                                                            // MakerGen.cs:407
                    {                                                                                                                       // MakerGen.cs:408
                        {                                                                                                                   // MakerGen.cs:231
                            // 23. StructureMap.group.name
                            this.Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Name",                                                                                              // MakerGen.cs:235
                                Path= "StructureMap.group.name",                                                                            // MakerGen.cs:236
                                Id = "StructureMap.group.name",                                                                             // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 24. StructureMap.group.extends
                            this.Extends = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Extends",                                                                                           // MakerGen.cs:235
                                Path= "StructureMap.group.extends",                                                                         // MakerGen.cs:236
                                Id = "StructureMap.group.extends",                                                                          // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 25. StructureMap.group.typeMode
                            this.TypeMode = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "TypeMode",                                                                                          // MakerGen.cs:235
                                Path= "StructureMap.group.typeMode",                                                                        // MakerGen.cs:236
                                Id = "StructureMap.group.typeMode",                                                                         // MakerGen.cs:237
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
                            // 26. StructureMap.group.documentation
                            this.Documentation = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Documentation",                                                                                     // MakerGen.cs:235
                                Path= "StructureMap.group.documentation",                                                                   // MakerGen.cs:236
                                Id = "StructureMap.group.documentation",                                                                    // MakerGen.cs:237
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
                            // 27. StructureMap.group.input
                            this.Input = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Input",                                                                                             // MakerGen.cs:235
                                Path= "StructureMap.group.input",                                                                           // MakerGen.cs:236
                                Id = "StructureMap.group.input",                                                                            // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Input                                                                                          // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 32. StructureMap.group.rule
                            this.Rule = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Rule",                                                                                              // MakerGen.cs:235
                                Path= "StructureMap.group.rule",                                                                            // MakerGen.cs:236
                                Id = "StructureMap.group.rule",                                                                             // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Rule                                                                                           // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:427
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:412
                    {                                                                                                                       // MakerGen.cs:413
                        base.Write(sDef);                                                                                                   // MakerGen.cs:414
                        Name.Write(sDef);                                                                                                   // MakerGen.cs:220
                        Extends.Write(sDef);                                                                                                // MakerGen.cs:220
                        TypeMode.Write(sDef);                                                                                               // MakerGen.cs:220
                        Documentation.Write(sDef);                                                                                          // MakerGen.cs:220
                        Input.Write(sDef);                                                                                                  // MakerGen.cs:220
                        Rule.Write(sDef);                                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:431
                }                                                                                                                           // MakerGen.cs:391
                public Type_Group_Elements Elements { get; }                                                                                // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
                public Type_Group()                                                                                                         // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:395
                    this.Elements = new Type_Group_Elements();                                                                              // MakerGen.cs:396
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:399
                {                                                                                                                           // MakerGen.cs:400
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:401
                }                                                                                                                           // MakerGen.cs:402
            }                                                                                                                               // MakerGen.cs:403
            // 1. StructureMap.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:216
            // 2. StructureMap.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 3. StructureMap.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:216
            // 4. StructureMap.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 5. StructureMap.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:216
            // 6. StructureMap.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 7. StructureMap.experimental
            public ElementDefinitionInfo Experimental;                                                                                      // MakerGen.cs:216
            // 8. StructureMap.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:216
            // 9. StructureMap.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:216
            // 10. StructureMap.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:216
            // 11. StructureMap.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 12. StructureMap.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:216
            // 13. StructureMap.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:216
            // 14. StructureMap.purpose
            public ElementDefinitionInfo Purpose;                                                                                           // MakerGen.cs:216
            // 15. StructureMap.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:216
            // 16. StructureMap.structure
            public ElementDefinitionInfo Structure;                                                                                         // MakerGen.cs:216
            // 21. StructureMap.import
            public ElementDefinitionInfo Import;                                                                                            // MakerGen.cs:216
            // 22. StructureMap.group
            public ElementDefinitionInfo Group;                                                                                             // MakerGen.cs:216
            public StructureMap_Elements()                                                                                                  // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. StructureMap.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Url",                                                                                                       // MakerGen.cs:235
                        Path= "StructureMap.url",                                                                                           // MakerGen.cs:236
                        Id = "StructureMap.url",                                                                                            // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
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
                    // 2. StructureMap.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "StructureMap.identifier",                                                                                    // MakerGen.cs:236
                        Id = "StructureMap.identifier",                                                                                     // MakerGen.cs:237
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
                    // 3. StructureMap.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Version",                                                                                                   // MakerGen.cs:235
                        Path= "StructureMap.version",                                                                                       // MakerGen.cs:236
                        Id = "StructureMap.version",                                                                                        // MakerGen.cs:237
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
                    // 4. StructureMap.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "StructureMap.name",                                                                                          // MakerGen.cs:236
                        Id = "StructureMap.name",                                                                                           // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
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
                    // 5. StructureMap.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Title",                                                                                                     // MakerGen.cs:235
                        Path= "StructureMap.title",                                                                                         // MakerGen.cs:236
                        Id = "StructureMap.title",                                                                                          // MakerGen.cs:237
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
                    // 6. StructureMap.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "StructureMap.status",                                                                                        // MakerGen.cs:236
                        Id = "StructureMap.status",                                                                                         // MakerGen.cs:237
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
                    // 7. StructureMap.experimental
                    this.Experimental = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Experimental",                                                                                              // MakerGen.cs:235
                        Path= "StructureMap.experimental",                                                                                  // MakerGen.cs:236
                        Id = "StructureMap.experimental",                                                                                   // MakerGen.cs:237
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
                    // 8. StructureMap.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Date",                                                                                                      // MakerGen.cs:235
                        Path= "StructureMap.date",                                                                                          // MakerGen.cs:236
                        Id = "StructureMap.date",                                                                                           // MakerGen.cs:237
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
                    // 9. StructureMap.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Publisher",                                                                                                 // MakerGen.cs:235
                        Path= "StructureMap.publisher",                                                                                     // MakerGen.cs:236
                        Id = "StructureMap.publisher",                                                                                      // MakerGen.cs:237
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
                    // 10. StructureMap.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Contact",                                                                                                   // MakerGen.cs:235
                        Path= "StructureMap.contact",                                                                                       // MakerGen.cs:236
                        Id = "StructureMap.contact",                                                                                        // MakerGen.cs:237
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
                    // 11. StructureMap.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "StructureMap.description",                                                                                   // MakerGen.cs:236
                        Id = "StructureMap.description",                                                                                    // MakerGen.cs:237
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
                    // 12. StructureMap.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "UseContext",                                                                                                // MakerGen.cs:235
                        Path= "StructureMap.useContext",                                                                                    // MakerGen.cs:236
                        Id = "StructureMap.useContext",                                                                                     // MakerGen.cs:237
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
                    // 13. StructureMap.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:235
                        Path= "StructureMap.jurisdiction",                                                                                  // MakerGen.cs:236
                        Id = "StructureMap.jurisdiction",                                                                                   // MakerGen.cs:237
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
                    // 14. StructureMap.purpose
                    this.Purpose = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Purpose",                                                                                                   // MakerGen.cs:235
                        Path= "StructureMap.purpose",                                                                                       // MakerGen.cs:236
                        Id = "StructureMap.purpose",                                                                                        // MakerGen.cs:237
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
                    // 15. StructureMap.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Copyright",                                                                                                 // MakerGen.cs:235
                        Path= "StructureMap.copyright",                                                                                     // MakerGen.cs:236
                        Id = "StructureMap.copyright",                                                                                      // MakerGen.cs:237
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
                    // 16. StructureMap.structure
                    this.Structure = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Structure",                                                                                                 // MakerGen.cs:235
                        Path= "StructureMap.structure",                                                                                     // MakerGen.cs:236
                        Id = "StructureMap.structure",                                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Structure                                                                                              // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 21. StructureMap.import
                    this.Import = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Import",                                                                                                    // MakerGen.cs:235
                        Path= "StructureMap.import",                                                                                        // MakerGen.cs:236
                        Id = "StructureMap.import",                                                                                         // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                                TargetProfile = new String[]                                                                                // MakerGen.cs:303
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/StructureMap"                                                  // MakerGen.cs:303
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 22. StructureMap.group
                    this.Group = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Group",                                                                                                     // MakerGen.cs:235
                        Path= "StructureMap.group",                                                                                         // MakerGen.cs:236
                        Id = "StructureMap.group",                                                                                          // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Group                                                                                                  // MakerGen.cs:259
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
                Structure.Write(sDef);                                                                                                      // MakerGen.cs:220
                Import.Write(sDef);                                                                                                         // MakerGen.cs:220
                Group.Write(sDef);                                                                                                          // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public StructureMap_Elements Elements { get; }                                                                                      // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public StructureMap()                                                                                                               // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new StructureMap_Elements();                                                                                    // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
