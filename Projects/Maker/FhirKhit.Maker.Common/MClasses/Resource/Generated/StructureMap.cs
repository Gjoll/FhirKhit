using System;                                                                                                                               // MakerGen.cs:413
using System.Diagnostics;                                                                                                                   // MakerGen.cs:414
using System.IO;                                                                                                                            // MakerGen.cs:415
using System.Linq;                                                                                                                          // MakerGen.cs:416
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:417
                                                                                                                                            // MakerGen.cs:418
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:419
{                                                                                                                                           // MakerGen.cs:420
    #region Json                                                                                                                            // MakerGen.cs:421
    #if NEVER                                                                                                                               // MakerGen.cs:422
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
    #endregion                                                                                                                              // MakerGen.cs:425
    /// <summary>
    /// Fhir resource 'StructureMap'
    /// </summary>
    // 0. StructureMap
    public class StructureMap : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:374
    {                                                                                                                                       // MakerGen.cs:375
        // 16. StructureMap.structure
        public class Type_Structure : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 17. StructureMap.structure.url
            public MakerElementInstance Element_Url;                                                                                        // MakerGen.cs:232
            // 18. StructureMap.structure.mode
            public MakerElementInstance Element_Mode;                                                                                       // MakerGen.cs:232
            // 19. StructureMap.structure.alias
            public MakerElementInstance Element_Alias;                                                                                      // MakerGen.cs:232
            // 20. StructureMap.structure.documentation
            public MakerElementInstance Element_Documentation;                                                                              // MakerGen.cs:232
            public Type_Structure()                                                                                                         // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 17. StructureMap.structure.url
                    this.Element_Url = new MakerElementInstance                                                                             // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Url",                                                                                               // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                                TargetProfile = new String[]                                                                                // MakerGen.cs:292
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/StructureDefinition"                                           // MakerGen.cs:292
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 18. StructureMap.structure.mode
                    this.Element_Mode = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Mode",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 19. StructureMap.structure.alias
                    this.Element_Alias = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Alias",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 20. StructureMap.structure.documentation
                    this.Element_Documentation = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Documentation",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 22. StructureMap.group
        public class Type_Group : FhirKhit.Maker.Common.Complex.ComplexBase                                                                 // MakerGen.cs:374
        {                                                                                                                                   // MakerGen.cs:375
            // 27. StructureMap.group.input
            public class Type_Input : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:374
            {                                                                                                                               // MakerGen.cs:375
                // 28. StructureMap.group.input.name
                public MakerElementInstance Element_Name;                                                                                   // MakerGen.cs:232
                // 29. StructureMap.group.input.type
                public MakerElementInstance Element_Type;                                                                                   // MakerGen.cs:232
                // 30. StructureMap.group.input.mode
                public MakerElementInstance Element_Mode;                                                                                   // MakerGen.cs:232
                // 31. StructureMap.group.input.documentation
                public MakerElementInstance Element_Documentation;                                                                          // MakerGen.cs:232
                public Type_Input()                                                                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:243
                        // 28. StructureMap.group.input.name
                        this.Element_Name = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Name",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Id                                                                      // MakerGen.cs:289
                                {                                                                                                           // MakerGen.cs:290
                                }                                                                                                           // MakerGen.cs:293
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 29. StructureMap.group.input.type
                        this.Element_Type = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Type",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:289
                                {                                                                                                           // MakerGen.cs:290
                                }                                                                                                           // MakerGen.cs:293
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 30. StructureMap.group.input.mode
                        this.Element_Mode = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Mode",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Code                                                                    // MakerGen.cs:289
                                {                                                                                                           // MakerGen.cs:290
                                }                                                                                                           // MakerGen.cs:293
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 31. StructureMap.group.input.documentation
                        this.Element_Documentation = new MakerElementInstance                                                               // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Documentation",                                                                                 // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:289
                                {                                                                                                           // MakerGen.cs:290
                                }                                                                                                           // MakerGen.cs:293
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                }                                                                                                                           // MakerGen.cs:395
            }                                                                                                                               // MakerGen.cs:379
            // 32. StructureMap.group.rule
            public class Type_Rule : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:374
            {                                                                                                                               // MakerGen.cs:375
                // 34. StructureMap.group.rule.source
                public class Type_Source : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:374
                {                                                                                                                           // MakerGen.cs:375
                    // 35. StructureMap.group.rule.source.context
                    public MakerElementInstance Element_Context;                                                                            // MakerGen.cs:232
                    // 36. StructureMap.group.rule.source.min
                    public MakerElementInstance Element_Min;                                                                                // MakerGen.cs:232
                    // 37. StructureMap.group.rule.source.max
                    public MakerElementInstance Element_Max;                                                                                // MakerGen.cs:232
                    // 38. StructureMap.group.rule.source.type
                    public MakerElementInstance Element_Type;                                                                               // MakerGen.cs:232
                    // 39. StructureMap.group.rule.source.defaultValue[x]
                    public MakerElementInstance Element_DefaultValue;                                                                       // MakerGen.cs:232
                    // 40. StructureMap.group.rule.source.element
                    public MakerElementInstance Element_Element;                                                                            // MakerGen.cs:232
                    // 41. StructureMap.group.rule.source.listMode
                    public MakerElementInstance Element_ListMode;                                                                           // MakerGen.cs:232
                    // 42. StructureMap.group.rule.source.variable
                    public MakerElementInstance Element_Variable;                                                                           // MakerGen.cs:232
                    // 43. StructureMap.group.rule.source.condition
                    public MakerElementInstance Element_Condition;                                                                          // MakerGen.cs:232
                    // 44. StructureMap.group.rule.source.check
                    public MakerElementInstance Element_Check;                                                                              // MakerGen.cs:232
                    // 45. StructureMap.group.rule.source.logMessage
                    public MakerElementInstance Element_LogMessage;                                                                         // MakerGen.cs:232
                    public Type_Source()                                                                                                    // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        {                                                                                                                   // MakerGen.cs:243
                            // 35. StructureMap.group.rule.source.context
                            this.Element_Context = new MakerElementInstance                                                                 // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Context",                                                                                   // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 36. StructureMap.group.rule.source.min
                            this.Element_Min = new MakerElementInstance                                                                     // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Min",                                                                                       // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 37. StructureMap.group.rule.source.max
                            this.Element_Max = new MakerElementInstance                                                                     // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Max",                                                                                       // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 38. StructureMap.group.rule.source.type
                            this.Element_Type = new MakerElementInstance                                                                    // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Type",                                                                                      // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 39. StructureMap.group.rule.source.defaultValue[x]
                            this.Element_DefaultValue = new MakerElementInstance                                                            // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_DefaultValue",                                                                              // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Base64Binary                                                        // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Canonical                                                           // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Date                                                                // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Instant                                                             // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Markdown                                                            // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Oid                                                                 // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.PositiveInt                                                         // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Time                                                                // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.UnsignedInt                                                         // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Url                                                                 // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Primitive.Uuid                                                                // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    },                                                                                                      // MakerGen.cs:293
                                    new FhirKhit.Maker.Common.Complex.Address                                                               // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Age                                                                   // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Annotation                                                            // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Attachment                                                            // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:304
                                    {                                                                                                       // MakerGen.cs:305
                                    },                                                                                                      // MakerGen.cs:308
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:304
                                    {                                                                                                       // MakerGen.cs:305
                                    },                                                                                                      // MakerGen.cs:308
                                    new FhirKhit.Maker.Common.Complex.ContactPoint                                                          // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Count                                                                 // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Distance                                                              // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Duration                                                              // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.HumanName                                                             // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Identifier                                                            // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Money                                                                 // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Quantity                                                              // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Ratio                                                                 // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:335
                                    {                                                                                                       // MakerGen.cs:336
                                    },                                                                                                      // MakerGen.cs:339
                                    new FhirKhit.Maker.Common.Complex.SampledData                                                           // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Signature                                                             // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Timing                                                                // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.ContactDetail                                                         // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Contributor                                                           // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.DataRequirement                                                       // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Expression                                                            // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.ParameterDefinition                                                   // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.RelatedArtifact                                                       // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.TriggerDefinition                                                     // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.UsageContext                                                          // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    },                                                                                                      // MakerGen.cs:349
                                    new FhirKhit.Maker.Common.Complex.Dosage                                                                // MakerGen.cs:347
                                    {                                                                                                       // MakerGen.cs:348
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 40. StructureMap.group.rule.source.element
                            this.Element_Element = new MakerElementInstance                                                                 // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Element",                                                                                   // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 41. StructureMap.group.rule.source.listMode
                            this.Element_ListMode = new MakerElementInstance                                                                // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_ListMode",                                                                                  // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 42. StructureMap.group.rule.source.variable
                            this.Element_Variable = new MakerElementInstance                                                                // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Variable",                                                                                  // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 43. StructureMap.group.rule.source.condition
                            this.Element_Condition = new MakerElementInstance                                                               // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Condition",                                                                                 // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 44. StructureMap.group.rule.source.check
                            this.Element_Check = new MakerElementInstance                                                                   // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Check",                                                                                     // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 45. StructureMap.group.rule.source.logMessage
                            this.Element_LogMessage = new MakerElementInstance                                                              // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_LogMessage",                                                                                // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                    }                                                                                                                       // MakerGen.cs:395
                }                                                                                                                           // MakerGen.cs:379
                // 46. StructureMap.group.rule.target
                public class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:374
                {                                                                                                                           // MakerGen.cs:375
                    // 54. StructureMap.group.rule.target.parameter
                    public class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:374
                    {                                                                                                                       // MakerGen.cs:375
                        // 55. StructureMap.group.rule.target.parameter.value[x]
                        public MakerElementInstance Element_Value;                                                                          // MakerGen.cs:232
                        public Type_Parameter()                                                                                             // MakerGen.cs:383
                        {                                                                                                                   // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:243
                                // 55. StructureMap.group.rule.target.parameter.value[x]
                                this.Element_Value = new MakerElementInstance                                                               // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:246
                                    Name = "Element_Value",                                                                                 // MakerGen.cs:247
                                    Min = 1,                                                                                                // MakerGen.cs:248
                                    Max = 1,                                                                                                // MakerGen.cs:249
                                    Types = new MakerBaseType[]                                                                             // MakerGen.cs:250
                                    {                                                                                                       // MakerGen.cs:251
                                        new FhirKhit.Maker.Common.Primitive.Id                                                              // MakerGen.cs:289
                                        {                                                                                                   // MakerGen.cs:290
                                        },                                                                                                  // MakerGen.cs:293
                                        new FhirKhit.Maker.Common.Primitive.String                                                          // MakerGen.cs:289
                                        {                                                                                                   // MakerGen.cs:290
                                        },                                                                                                  // MakerGen.cs:293
                                        new FhirKhit.Maker.Common.Primitive.Boolean                                                         // MakerGen.cs:289
                                        {                                                                                                   // MakerGen.cs:290
                                        },                                                                                                  // MakerGen.cs:293
                                        new FhirKhit.Maker.Common.Primitive.Integer                                                         // MakerGen.cs:289
                                        {                                                                                                   // MakerGen.cs:290
                                        },                                                                                                  // MakerGen.cs:293
                                        new FhirKhit.Maker.Common.Primitive.Decimal                                                         // MakerGen.cs:289
                                        {                                                                                                   // MakerGen.cs:290
                                        }                                                                                                   // MakerGen.cs:293
                                    }                                                                                                       // MakerGen.cs:253
                                };                                                                                                          // MakerGen.cs:254
                            }                                                                                                               // MakerGen.cs:356
                        }                                                                                                                   // MakerGen.cs:395
                    }                                                                                                                       // MakerGen.cs:379
                    // 47. StructureMap.group.rule.target.context
                    public MakerElementInstance Element_Context;                                                                            // MakerGen.cs:232
                    // 48. StructureMap.group.rule.target.contextType
                    public MakerElementInstance Element_ContextType;                                                                        // MakerGen.cs:232
                    // 49. StructureMap.group.rule.target.element
                    public MakerElementInstance Element_Element;                                                                            // MakerGen.cs:232
                    // 50. StructureMap.group.rule.target.variable
                    public MakerElementInstance Element_Variable;                                                                           // MakerGen.cs:232
                    // 51. StructureMap.group.rule.target.listMode
                    public MakerElementInstance Element_ListMode;                                                                           // MakerGen.cs:232
                    // 52. StructureMap.group.rule.target.listRuleId
                    public MakerElementInstance Element_ListRuleId;                                                                         // MakerGen.cs:232
                    // 53. StructureMap.group.rule.target.transform
                    public MakerElementInstance Element_Transform;                                                                          // MakerGen.cs:232
                    public Type_Target()                                                                                                    // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        {                                                                                                                   // MakerGen.cs:243
                            // 47. StructureMap.group.rule.target.context
                            this.Element_Context = new MakerElementInstance                                                                 // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Context",                                                                                   // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 48. StructureMap.group.rule.target.contextType
                            this.Element_ContextType = new MakerElementInstance                                                             // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_ContextType",                                                                               // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 49. StructureMap.group.rule.target.element
                            this.Element_Element = new MakerElementInstance                                                                 // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Element",                                                                                   // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 50. StructureMap.group.rule.target.variable
                            this.Element_Variable = new MakerElementInstance                                                                // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Variable",                                                                                  // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 51. StructureMap.group.rule.target.listMode
                            this.Element_ListMode = new MakerElementInstance                                                                // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_ListMode",                                                                                  // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 52. StructureMap.group.rule.target.listRuleId
                            this.Element_ListRuleId = new MakerElementInstance                                                              // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_ListRuleId",                                                                                // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 53. StructureMap.group.rule.target.transform
                            this.Element_Transform = new MakerElementInstance                                                               // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Transform",                                                                                 // MakerGen.cs:247
                                Min = 0,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                    }                                                                                                                       // MakerGen.cs:395
                }                                                                                                                           // MakerGen.cs:379
                // 57. StructureMap.group.rule.dependent
                public class Type_Dependent : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:374
                {                                                                                                                           // MakerGen.cs:375
                    // 58. StructureMap.group.rule.dependent.name
                    public MakerElementInstance Element_Name;                                                                               // MakerGen.cs:232
                    // 59. StructureMap.group.rule.dependent.variable
                    public MakerElementInstance Element_Variable;                                                                           // MakerGen.cs:232
                    public Type_Dependent()                                                                                                 // MakerGen.cs:383
                    {                                                                                                                       // MakerGen.cs:384
                        {                                                                                                                   // MakerGen.cs:243
                            // 58. StructureMap.group.rule.dependent.name
                            this.Element_Name = new MakerElementInstance                                                                    // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Name",                                                                                      // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = 1,                                                                                                    // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:243
                            // 59. StructureMap.group.rule.dependent.variable
                            this.Element_Variable = new MakerElementInstance                                                                // MakerGen.cs:245
                            {                                                                                                               // MakerGen.cs:246
                                Name = "Element_Variable",                                                                                  // MakerGen.cs:247
                                Min = 1,                                                                                                    // MakerGen.cs:248
                                Max = -1,                                                                                                   // MakerGen.cs:249
                                Types = new MakerBaseType[]                                                                                 // MakerGen.cs:250
                                {                                                                                                           // MakerGen.cs:251
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:289
                                    {                                                                                                       // MakerGen.cs:290
                                    }                                                                                                       // MakerGen.cs:293
                                }                                                                                                           // MakerGen.cs:253
                            };                                                                                                              // MakerGen.cs:254
                        }                                                                                                                   // MakerGen.cs:356
                    }                                                                                                                       // MakerGen.cs:395
                }                                                                                                                           // MakerGen.cs:379
                // 33. StructureMap.group.rule.name
                public MakerElementInstance Element_Name;                                                                                   // MakerGen.cs:232
                // 56. StructureMap.group.rule.rule
                public MakerElementInstance Element_Rule;                                                                                   // MakerGen.cs:232
                // 60. StructureMap.group.rule.documentation
                public MakerElementInstance Element_Documentation;                                                                          // MakerGen.cs:232
                public Type_Rule()                                                                                                          // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:243
                        // 33. StructureMap.group.rule.name
                        this.Element_Name = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Name",                                                                                          // MakerGen.cs:247
                            Min = 1,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Id                                                                      // MakerGen.cs:289
                                {                                                                                                           // MakerGen.cs:290
                                }                                                                                                           // MakerGen.cs:293
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 56. StructureMap.group.rule.rule
                        this.Element_Rule = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Rule",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                    {                                                                                                                       // MakerGen.cs:243
                        // 60. StructureMap.group.rule.documentation
                        this.Element_Documentation = new MakerElementInstance                                                               // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Documentation",                                                                                 // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.String                                                                  // MakerGen.cs:289
                                {                                                                                                           // MakerGen.cs:290
                                }                                                                                                           // MakerGen.cs:293
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:356
                }                                                                                                                           // MakerGen.cs:395
            }                                                                                                                               // MakerGen.cs:379
            // 23. StructureMap.group.name
            public MakerElementInstance Element_Name;                                                                                       // MakerGen.cs:232
            // 24. StructureMap.group.extends
            public MakerElementInstance Element_Extends;                                                                                    // MakerGen.cs:232
            // 25. StructureMap.group.typeMode
            public MakerElementInstance Element_TypeMode;                                                                                   // MakerGen.cs:232
            // 26. StructureMap.group.documentation
            public MakerElementInstance Element_Documentation;                                                                              // MakerGen.cs:232
            public Type_Group()                                                                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                {                                                                                                                           // MakerGen.cs:243
                    // 23. StructureMap.group.name
                    this.Element_Name = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Name",                                                                                              // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Id                                                                          // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 24. StructureMap.group.extends
                    this.Element_Extends = new MakerElementInstance                                                                         // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Extends",                                                                                           // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Id                                                                          // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 25. StructureMap.group.typeMode
                    this.Element_TypeMode = new MakerElementInstance                                                                        // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_TypeMode",                                                                                          // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
                {                                                                                                                           // MakerGen.cs:243
                    // 26. StructureMap.group.documentation
                    this.Element_Documentation = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Documentation",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:289
                            {                                                                                                               // MakerGen.cs:290
                            }                                                                                                               // MakerGen.cs:293
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:356
            }                                                                                                                               // MakerGen.cs:395
        }                                                                                                                                   // MakerGen.cs:379
        // 1. StructureMap.url
        public MakerElementInstance Element_Url;                                                                                            // MakerGen.cs:232
        // 2. StructureMap.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 3. StructureMap.version
        public MakerElementInstance Element_Version;                                                                                        // MakerGen.cs:232
        // 4. StructureMap.name
        public MakerElementInstance Element_Name;                                                                                           // MakerGen.cs:232
        // 5. StructureMap.title
        public MakerElementInstance Element_Title;                                                                                          // MakerGen.cs:232
        // 6. StructureMap.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 7. StructureMap.experimental
        public MakerElementInstance Element_Experimental;                                                                                   // MakerGen.cs:232
        // 8. StructureMap.date
        public MakerElementInstance Element_Date;                                                                                           // MakerGen.cs:232
        // 9. StructureMap.publisher
        public MakerElementInstance Element_Publisher;                                                                                      // MakerGen.cs:232
        // 10. StructureMap.contact
        public MakerElementInstance Element_Contact;                                                                                        // MakerGen.cs:232
        // 11. StructureMap.description
        public MakerElementInstance Element_Description;                                                                                    // MakerGen.cs:232
        // 12. StructureMap.useContext
        public MakerElementInstance Element_UseContext;                                                                                     // MakerGen.cs:232
        // 13. StructureMap.jurisdiction
        public MakerElementInstance Element_Jurisdiction;                                                                                   // MakerGen.cs:232
        // 14. StructureMap.purpose
        public MakerElementInstance Element_Purpose;                                                                                        // MakerGen.cs:232
        // 15. StructureMap.copyright
        public MakerElementInstance Element_Copyright;                                                                                      // MakerGen.cs:232
        // 21. StructureMap.import
        public MakerElementInstance Element_Import;                                                                                         // MakerGen.cs:232
        public StructureMap()                                                                                                               // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:243
                // 1. StructureMap.url
                this.Element_Url = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Uri                                                                             // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 2. StructureMap.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Identifier                                                                        // MakerGen.cs:347
                        {                                                                                                                   // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:349
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 3. StructureMap.version
                this.Element_Version = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Version",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 4. StructureMap.name
                this.Element_Name = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 5. StructureMap.title
                this.Element_Title = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Title",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 6. StructureMap.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 7. StructureMap.experimental
                this.Element_Experimental = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Experimental",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Boolean                                                                         // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 8. StructureMap.date
                this.Element_Date = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 9. StructureMap.publisher
                this.Element_Publisher = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 10. StructureMap.contact
                this.Element_Contact = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.ContactDetail                                                                     // MakerGen.cs:347
                        {                                                                                                                   // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:349
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 11. StructureMap.description
                this.Element_Description = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Description",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown                                                                        // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 12. StructureMap.useContext
                this.Element_UseContext = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.UsageContext                                                                      // MakerGen.cs:347
                        {                                                                                                                   // MakerGen.cs:348
                        }                                                                                                                   // MakerGen.cs:349
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 13. StructureMap.jurisdiction
                this.Element_Jurisdiction = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:304
                        {                                                                                                                   // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:308
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 14. StructureMap.purpose
                this.Element_Purpose = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Purpose",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown                                                                        // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 15. StructureMap.copyright
                this.Element_Copyright = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Copyright",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown                                                                        // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
            {                                                                                                                               // MakerGen.cs:243
                // 21. StructureMap.import
                this.Element_Import = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Import",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Canonical                                                                       // MakerGen.cs:289
                        {                                                                                                                   // MakerGen.cs:290
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:292
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/StructureMap"                                                      // MakerGen.cs:292
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:293
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:356
        }                                                                                                                                   // MakerGen.cs:395
    }                                                                                                                                       // MakerGen.cs:379
}                                                                                                                                           // MakerGen.cs:430
