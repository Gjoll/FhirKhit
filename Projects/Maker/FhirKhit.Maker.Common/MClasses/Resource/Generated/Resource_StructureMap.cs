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
    #endregion
    /// <summary>
    /// Fhir resource 'StructureMap'
    /// </summary>
    // 0. StructureMap
    public partial class Resource_StructureMap : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 16. StructureMap.structure
        public partial class Type_Structure : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 17. StructureMap.structure.url
            public ElementDefinitionInfo Element_Url;
            // 18. StructureMap.structure.mode
            public ElementDefinitionInfo Element_Mode;
            // 19. StructureMap.structure.alias
            public ElementDefinitionInfo Element_Alias;
            // 20. StructureMap.structure.documentation
            public ElementDefinitionInfo Element_Documentation;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "StructureMap.structure",
                    ElementId = "StructureMap.structure"
                });
                Element_Url.Write(sDef);
                Element_Mode.Write(sDef);
                Element_Alias.Write(sDef);
                Element_Documentation.Write(sDef);
            }
            
            public Type_Structure()
            {
                {
                    // 17. StructureMap.structure.url
                    this.Element_Url = new ElementDefinitionInfo
                    {
                        Name = "Element_Url",
                        Path= "StructureMap.structure.url",
                        Id = "StructureMap.structure.url",
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
                {
                    // 18. StructureMap.structure.mode
                    this.Element_Mode = new ElementDefinitionInfo
                    {
                        Name = "Element_Mode",
                        Path= "StructureMap.structure.mode",
                        Id = "StructureMap.structure.mode",
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
                    // 19. StructureMap.structure.alias
                    this.Element_Alias = new ElementDefinitionInfo
                    {
                        Name = "Element_Alias",
                        Path= "StructureMap.structure.alias",
                        Id = "StructureMap.structure.alias",
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
                    // 20. StructureMap.structure.documentation
                    this.Element_Documentation = new ElementDefinitionInfo
                    {
                        Name = "Element_Documentation",
                        Path= "StructureMap.structure.documentation",
                        Id = "StructureMap.structure.documentation",
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
        // 22. StructureMap.group
        public partial class Type_Group : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 27. StructureMap.group.input
            public partial class Type_Input : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 28. StructureMap.group.input.name
                public ElementDefinitionInfo Element_Name;
                // 29. StructureMap.group.input.type
                public ElementDefinitionInfo Element_Type;
                // 30. StructureMap.group.input.mode
                public ElementDefinitionInfo Element_Mode;
                // 31. StructureMap.group.input.documentation
                public ElementDefinitionInfo Element_Documentation;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "StructureMap.group.input",
                        ElementId = "StructureMap.group.input"
                    });
                    Element_Name.Write(sDef);
                    Element_Type.Write(sDef);
                    Element_Mode.Write(sDef);
                    Element_Documentation.Write(sDef);
                }
                
                public Type_Input()
                {
                    {
                        // 28. StructureMap.group.input.name
                        this.Element_Name = new ElementDefinitionInfo
                        {
                            Name = "Element_Name",
                            Path= "StructureMap.group.input.name",
                            Id = "StructureMap.group.input.name",
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
                        // 29. StructureMap.group.input.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "StructureMap.group.input.type",
                            Id = "StructureMap.group.input.type",
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
                        // 30. StructureMap.group.input.mode
                        this.Element_Mode = new ElementDefinitionInfo
                        {
                            Name = "Element_Mode",
                            Path= "StructureMap.group.input.mode",
                            Id = "StructureMap.group.input.mode",
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
                        // 31. StructureMap.group.input.documentation
                        this.Element_Documentation = new ElementDefinitionInfo
                        {
                            Name = "Element_Documentation",
                            Path= "StructureMap.group.input.documentation",
                            Id = "StructureMap.group.input.documentation",
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
            // 32. StructureMap.group.rule
            public partial class Type_Rule : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 34. StructureMap.group.rule.source
                public partial class Type_Source : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 35. StructureMap.group.rule.source.context
                    public ElementDefinitionInfo Element_Context;
                    // 36. StructureMap.group.rule.source.min
                    public ElementDefinitionInfo Element_Min;
                    // 37. StructureMap.group.rule.source.max
                    public ElementDefinitionInfo Element_Max;
                    // 38. StructureMap.group.rule.source.type
                    public ElementDefinitionInfo Element_Type;
                    // 39. StructureMap.group.rule.source.defaultValue[x]
                    public ElementDefinitionInfo Element_DefaultValue;
                    // 40. StructureMap.group.rule.source.element
                    public ElementDefinitionInfo Element_Element;
                    // 41. StructureMap.group.rule.source.listMode
                    public ElementDefinitionInfo Element_ListMode;
                    // 42. StructureMap.group.rule.source.variable
                    public ElementDefinitionInfo Element_Variable;
                    // 43. StructureMap.group.rule.source.condition
                    public ElementDefinitionInfo Element_Condition;
                    // 44. StructureMap.group.rule.source.check
                    public ElementDefinitionInfo Element_Check;
                    // 45. StructureMap.group.rule.source.logMessage
                    public ElementDefinitionInfo Element_LogMessage;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "StructureMap.group.rule.source",
                            ElementId = "StructureMap.group.rule.source"
                        });
                        Element_Context.Write(sDef);
                        Element_Min.Write(sDef);
                        Element_Max.Write(sDef);
                        Element_Type.Write(sDef);
                        Element_DefaultValue.Write(sDef);
                        Element_Element.Write(sDef);
                        Element_ListMode.Write(sDef);
                        Element_Variable.Write(sDef);
                        Element_Condition.Write(sDef);
                        Element_Check.Write(sDef);
                        Element_LogMessage.Write(sDef);
                    }
                    
                    public Type_Source()
                    {
                        {
                            // 35. StructureMap.group.rule.source.context
                            this.Element_Context = new ElementDefinitionInfo
                            {
                                Name = "Element_Context",
                                Path= "StructureMap.group.rule.source.context",
                                Id = "StructureMap.group.rule.source.context",
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
                            // 36. StructureMap.group.rule.source.min
                            this.Element_Min = new ElementDefinitionInfo
                            {
                                Name = "Element_Min",
                                Path= "StructureMap.group.rule.source.min",
                                Id = "StructureMap.group.rule.source.min",
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
                            // 37. StructureMap.group.rule.source.max
                            this.Element_Max = new ElementDefinitionInfo
                            {
                                Name = "Element_Max",
                                Path= "StructureMap.group.rule.source.max",
                                Id = "StructureMap.group.rule.source.max",
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
                            // 38. StructureMap.group.rule.source.type
                            this.Element_Type = new ElementDefinitionInfo
                            {
                                Name = "Element_Type",
                                Path= "StructureMap.group.rule.source.type",
                                Id = "StructureMap.group.rule.source.type",
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
                            // 39. StructureMap.group.rule.source.defaultValue[x]
                            this.Element_DefaultValue = new ElementDefinitionInfo
                            {
                                Name = "Element_DefaultValue",
                                Path= "StructureMap.group.rule.source.defaultValue[x]",
                                Id = "StructureMap.group.rule.source.defaultValue[x]",
                                Min = 0,
                                Max = 1,
                                Types = new BaseType[]
                                {
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Base64Binary
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Code
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Date
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Id
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Instant
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Markdown
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Oid
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Time
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Url
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Uuid
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Address
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Age
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Annotation
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Attachment
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Coding
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_ContactPoint
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Count
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Distance
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Duration
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_HumanName
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Identifier
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Money
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Period
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Quantity
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Range
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Ratio
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Reference
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_SampledData
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Signature
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Timing
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_ContactDetail
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Contributor
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_DataRequirement
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Expression
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_ParameterDefinition
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_RelatedArtifact
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_TriggerDefinition
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_UsageContext
                                    {
                                    },
                                    new FhirKhit.Maker.Common.Complex.Type_Dosage
                                    {
                                    }
                                }
                            };
                        }
                        {
                            // 40. StructureMap.group.rule.source.element
                            this.Element_Element = new ElementDefinitionInfo
                            {
                                Name = "Element_Element",
                                Path= "StructureMap.group.rule.source.element",
                                Id = "StructureMap.group.rule.source.element",
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
                            // 41. StructureMap.group.rule.source.listMode
                            this.Element_ListMode = new ElementDefinitionInfo
                            {
                                Name = "Element_ListMode",
                                Path= "StructureMap.group.rule.source.listMode",
                                Id = "StructureMap.group.rule.source.listMode",
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
                            // 42. StructureMap.group.rule.source.variable
                            this.Element_Variable = new ElementDefinitionInfo
                            {
                                Name = "Element_Variable",
                                Path= "StructureMap.group.rule.source.variable",
                                Id = "StructureMap.group.rule.source.variable",
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
                            // 43. StructureMap.group.rule.source.condition
                            this.Element_Condition = new ElementDefinitionInfo
                            {
                                Name = "Element_Condition",
                                Path= "StructureMap.group.rule.source.condition",
                                Id = "StructureMap.group.rule.source.condition",
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
                            // 44. StructureMap.group.rule.source.check
                            this.Element_Check = new ElementDefinitionInfo
                            {
                                Name = "Element_Check",
                                Path= "StructureMap.group.rule.source.check",
                                Id = "StructureMap.group.rule.source.check",
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
                            // 45. StructureMap.group.rule.source.logMessage
                            this.Element_LogMessage = new ElementDefinitionInfo
                            {
                                Name = "Element_LogMessage",
                                Path= "StructureMap.group.rule.source.logMessage",
                                Id = "StructureMap.group.rule.source.logMessage",
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
                // 46. StructureMap.group.rule.target
                public partial class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 54. StructureMap.group.rule.target.parameter
                    public partial class Type_Parameter : FhirKhit.Maker.Common.Complex.ComplexBase
                    {
                        // 55. StructureMap.group.rule.target.parameter.value[x]
                        public ElementDefinitionInfo Element_Value;
                        
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                        {
                            base.Write(sDef);
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                            {
                                Path = "StructureMap.group.rule.target.parameter",
                                ElementId = "StructureMap.group.rule.target.parameter"
                            });
                            Element_Value.Write(sDef);
                        }
                        
                        public Type_Parameter()
                        {
                            {
                                // 55. StructureMap.group.rule.target.parameter.value[x]
                                this.Element_Value = new ElementDefinitionInfo
                                {
                                    Name = "Element_Value",
                                    Path= "StructureMap.group.rule.target.parameter.value[x]",
                                    Id = "StructureMap.group.rule.target.parameter.value[x]",
                                    Min = 1,
                                    Max = 1,
                                    Types = new BaseType[]
                                    {
                                        new FhirKhit.Maker.Common.Primitive.Primitive_Id
                                        {
                                        },
                                        new FhirKhit.Maker.Common.Primitive.Primitive_String
                                        {
                                        },
                                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                                        {
                                        },
                                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer
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
                    // 47. StructureMap.group.rule.target.context
                    public ElementDefinitionInfo Element_Context;
                    // 48. StructureMap.group.rule.target.contextType
                    public ElementDefinitionInfo Element_ContextType;
                    // 49. StructureMap.group.rule.target.element
                    public ElementDefinitionInfo Element_Element;
                    // 50. StructureMap.group.rule.target.variable
                    public ElementDefinitionInfo Element_Variable;
                    // 51. StructureMap.group.rule.target.listMode
                    public ElementDefinitionInfo Element_ListMode;
                    // 52. StructureMap.group.rule.target.listRuleId
                    public ElementDefinitionInfo Element_ListRuleId;
                    // 53. StructureMap.group.rule.target.transform
                    public ElementDefinitionInfo Element_Transform;
                    // 54. StructureMap.group.rule.target.parameter
                    public ElementDefinitionInfo Element_Parameter;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "StructureMap.group.rule.target",
                            ElementId = "StructureMap.group.rule.target"
                        });
                        Element_Context.Write(sDef);
                        Element_ContextType.Write(sDef);
                        Element_Element.Write(sDef);
                        Element_Variable.Write(sDef);
                        Element_ListMode.Write(sDef);
                        Element_ListRuleId.Write(sDef);
                        Element_Transform.Write(sDef);
                        Element_Parameter.Write(sDef);
                    }
                    
                    public Type_Target()
                    {
                        {
                            // 47. StructureMap.group.rule.target.context
                            this.Element_Context = new ElementDefinitionInfo
                            {
                                Name = "Element_Context",
                                Path= "StructureMap.group.rule.target.context",
                                Id = "StructureMap.group.rule.target.context",
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
                            // 48. StructureMap.group.rule.target.contextType
                            this.Element_ContextType = new ElementDefinitionInfo
                            {
                                Name = "Element_ContextType",
                                Path= "StructureMap.group.rule.target.contextType",
                                Id = "StructureMap.group.rule.target.contextType",
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
                            // 49. StructureMap.group.rule.target.element
                            this.Element_Element = new ElementDefinitionInfo
                            {
                                Name = "Element_Element",
                                Path= "StructureMap.group.rule.target.element",
                                Id = "StructureMap.group.rule.target.element",
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
                            // 50. StructureMap.group.rule.target.variable
                            this.Element_Variable = new ElementDefinitionInfo
                            {
                                Name = "Element_Variable",
                                Path= "StructureMap.group.rule.target.variable",
                                Id = "StructureMap.group.rule.target.variable",
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
                            // 51. StructureMap.group.rule.target.listMode
                            this.Element_ListMode = new ElementDefinitionInfo
                            {
                                Name = "Element_ListMode",
                                Path= "StructureMap.group.rule.target.listMode",
                                Id = "StructureMap.group.rule.target.listMode",
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
                            // 52. StructureMap.group.rule.target.listRuleId
                            this.Element_ListRuleId = new ElementDefinitionInfo
                            {
                                Name = "Element_ListRuleId",
                                Path= "StructureMap.group.rule.target.listRuleId",
                                Id = "StructureMap.group.rule.target.listRuleId",
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
                            // 53. StructureMap.group.rule.target.transform
                            this.Element_Transform = new ElementDefinitionInfo
                            {
                                Name = "Element_Transform",
                                Path= "StructureMap.group.rule.target.transform",
                                Id = "StructureMap.group.rule.target.transform",
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
                            // 54. StructureMap.group.rule.target.parameter
                            this.Element_Parameter = new ElementDefinitionInfo
                            {
                                Name = "Element_Parameter",
                                Path= "StructureMap.group.rule.target.parameter",
                                Id = "StructureMap.group.rule.target.parameter",
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
                    }
                }
                // 57. StructureMap.group.rule.dependent
                public partial class Type_Dependent : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 58. StructureMap.group.rule.dependent.name
                    public ElementDefinitionInfo Element_Name;
                    // 59. StructureMap.group.rule.dependent.variable
                    public ElementDefinitionInfo Element_Variable;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "StructureMap.group.rule.dependent",
                            ElementId = "StructureMap.group.rule.dependent"
                        });
                        Element_Name.Write(sDef);
                        Element_Variable.Write(sDef);
                    }
                    
                    public Type_Dependent()
                    {
                        {
                            // 58. StructureMap.group.rule.dependent.name
                            this.Element_Name = new ElementDefinitionInfo
                            {
                                Name = "Element_Name",
                                Path= "StructureMap.group.rule.dependent.name",
                                Id = "StructureMap.group.rule.dependent.name",
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
                            // 59. StructureMap.group.rule.dependent.variable
                            this.Element_Variable = new ElementDefinitionInfo
                            {
                                Name = "Element_Variable",
                                Path= "StructureMap.group.rule.dependent.variable",
                                Id = "StructureMap.group.rule.dependent.variable",
                                Min = 1,
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
                // 33. StructureMap.group.rule.name
                public ElementDefinitionInfo Element_Name;
                // 34. StructureMap.group.rule.source
                public ElementDefinitionInfo Element_Source;
                // 46. StructureMap.group.rule.target
                public ElementDefinitionInfo Element_Target;
                // 56. StructureMap.group.rule.rule
                public ElementDefinitionInfo Element_Rule;
                // 57. StructureMap.group.rule.dependent
                public ElementDefinitionInfo Element_Dependent;
                // 60. StructureMap.group.rule.documentation
                public ElementDefinitionInfo Element_Documentation;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "StructureMap.group.rule",
                        ElementId = "StructureMap.group.rule"
                    });
                    Element_Name.Write(sDef);
                    Element_Source.Write(sDef);
                    Element_Target.Write(sDef);
                    Element_Rule.Write(sDef);
                    Element_Dependent.Write(sDef);
                    Element_Documentation.Write(sDef);
                }
                
                public Type_Rule()
                {
                    {
                        // 33. StructureMap.group.rule.name
                        this.Element_Name = new ElementDefinitionInfo
                        {
                            Name = "Element_Name",
                            Path= "StructureMap.group.rule.name",
                            Id = "StructureMap.group.rule.name",
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
                        // 34. StructureMap.group.rule.source
                        this.Element_Source = new ElementDefinitionInfo
                        {
                            Name = "Element_Source",
                            Path= "StructureMap.group.rule.source",
                            Id = "StructureMap.group.rule.source",
                            Min = 1,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Source
                                {
                                }
                            }
                        };
                    }
                    {
                        // 46. StructureMap.group.rule.target
                        this.Element_Target = new ElementDefinitionInfo
                        {
                            Name = "Element_Target",
                            Path= "StructureMap.group.rule.target",
                            Id = "StructureMap.group.rule.target",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Target
                                {
                                }
                            }
                        };
                    }
                    {
                        // 56. StructureMap.group.rule.rule
                        this.Element_Rule = new ElementDefinitionInfo
                        {
                            Name = "Element_Rule",
                            Path= "StructureMap.group.rule.rule",
                            Id = "StructureMap.group.rule.rule",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                    {
                        // 57. StructureMap.group.rule.dependent
                        this.Element_Dependent = new ElementDefinitionInfo
                        {
                            Name = "Element_Dependent",
                            Path= "StructureMap.group.rule.dependent",
                            Id = "StructureMap.group.rule.dependent",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new Type_Dependent
                                {
                                }
                            }
                        };
                    }
                    {
                        // 60. StructureMap.group.rule.documentation
                        this.Element_Documentation = new ElementDefinitionInfo
                        {
                            Name = "Element_Documentation",
                            Path= "StructureMap.group.rule.documentation",
                            Id = "StructureMap.group.rule.documentation",
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
            // 23. StructureMap.group.name
            public ElementDefinitionInfo Element_Name;
            // 24. StructureMap.group.extends
            public ElementDefinitionInfo Element_Extends;
            // 25. StructureMap.group.typeMode
            public ElementDefinitionInfo Element_TypeMode;
            // 26. StructureMap.group.documentation
            public ElementDefinitionInfo Element_Documentation;
            // 27. StructureMap.group.input
            public ElementDefinitionInfo Element_Input;
            // 32. StructureMap.group.rule
            public ElementDefinitionInfo Element_Rule;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "StructureMap.group",
                    ElementId = "StructureMap.group"
                });
                Element_Name.Write(sDef);
                Element_Extends.Write(sDef);
                Element_TypeMode.Write(sDef);
                Element_Documentation.Write(sDef);
                Element_Input.Write(sDef);
                Element_Rule.Write(sDef);
            }
            
            public Type_Group()
            {
                {
                    // 23. StructureMap.group.name
                    this.Element_Name = new ElementDefinitionInfo
                    {
                        Name = "Element_Name",
                        Path= "StructureMap.group.name",
                        Id = "StructureMap.group.name",
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
                    // 24. StructureMap.group.extends
                    this.Element_Extends = new ElementDefinitionInfo
                    {
                        Name = "Element_Extends",
                        Path= "StructureMap.group.extends",
                        Id = "StructureMap.group.extends",
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
                    // 25. StructureMap.group.typeMode
                    this.Element_TypeMode = new ElementDefinitionInfo
                    {
                        Name = "Element_TypeMode",
                        Path= "StructureMap.group.typeMode",
                        Id = "StructureMap.group.typeMode",
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
                    // 26. StructureMap.group.documentation
                    this.Element_Documentation = new ElementDefinitionInfo
                    {
                        Name = "Element_Documentation",
                        Path= "StructureMap.group.documentation",
                        Id = "StructureMap.group.documentation",
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
                    // 27. StructureMap.group.input
                    this.Element_Input = new ElementDefinitionInfo
                    {
                        Name = "Element_Input",
                        Path= "StructureMap.group.input",
                        Id = "StructureMap.group.input",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Input
                            {
                            }
                        }
                    };
                }
                {
                    // 32. StructureMap.group.rule
                    this.Element_Rule = new ElementDefinitionInfo
                    {
                        Name = "Element_Rule",
                        Path= "StructureMap.group.rule",
                        Id = "StructureMap.group.rule",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Rule
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. StructureMap.url
        public ElementDefinitionInfo Element_Url;
        // 2. StructureMap.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. StructureMap.version
        public ElementDefinitionInfo Element_Version;
        // 4. StructureMap.name
        public ElementDefinitionInfo Element_Name;
        // 5. StructureMap.title
        public ElementDefinitionInfo Element_Title;
        // 6. StructureMap.status
        public ElementDefinitionInfo Element_Status;
        // 7. StructureMap.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 8. StructureMap.date
        public ElementDefinitionInfo Element_Date;
        // 9. StructureMap.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 10. StructureMap.contact
        public ElementDefinitionInfo Element_Contact;
        // 11. StructureMap.description
        public ElementDefinitionInfo Element_Description;
        // 12. StructureMap.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 13. StructureMap.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 14. StructureMap.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 15. StructureMap.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 16. StructureMap.structure
        public ElementDefinitionInfo Element_Structure;
        // 21. StructureMap.import
        public ElementDefinitionInfo Element_Import;
        // 22. StructureMap.group
        public ElementDefinitionInfo Element_Group;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "StructureMap",
                ElementId = "StructureMap"
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
            Element_Structure.Write(sDef);
            Element_Import.Write(sDef);
            Element_Group.Write(sDef);
        }
        
        public Resource_StructureMap()
        {
            {
                // 1. StructureMap.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "StructureMap.url",
                    Id = "StructureMap.url",
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
                // 2. StructureMap.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "StructureMap.identifier",
                    Id = "StructureMap.identifier",
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
                // 3. StructureMap.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "StructureMap.version",
                    Id = "StructureMap.version",
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
                // 4. StructureMap.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "StructureMap.name",
                    Id = "StructureMap.name",
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
                // 5. StructureMap.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "StructureMap.title",
                    Id = "StructureMap.title",
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
                // 6. StructureMap.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "StructureMap.status",
                    Id = "StructureMap.status",
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
                // 7. StructureMap.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "StructureMap.experimental",
                    Id = "StructureMap.experimental",
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
                // 8. StructureMap.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "StructureMap.date",
                    Id = "StructureMap.date",
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
                // 9. StructureMap.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "StructureMap.publisher",
                    Id = "StructureMap.publisher",
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
                // 10. StructureMap.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "StructureMap.contact",
                    Id = "StructureMap.contact",
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
                // 11. StructureMap.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "StructureMap.description",
                    Id = "StructureMap.description",
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
                // 12. StructureMap.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "StructureMap.useContext",
                    Id = "StructureMap.useContext",
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
                // 13. StructureMap.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "StructureMap.jurisdiction",
                    Id = "StructureMap.jurisdiction",
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
                // 14. StructureMap.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "StructureMap.purpose",
                    Id = "StructureMap.purpose",
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
                // 15. StructureMap.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "StructureMap.copyright",
                    Id = "StructureMap.copyright",
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
                // 16. StructureMap.structure
                this.Element_Structure = new ElementDefinitionInfo
                {
                    Name = "Element_Structure",
                    Path= "StructureMap.structure",
                    Id = "StructureMap.structure",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Structure
                        {
                        }
                    }
                };
            }
            {
                // 21. StructureMap.import
                this.Element_Import = new ElementDefinitionInfo
                {
                    Name = "Element_Import",
                    Path= "StructureMap.import",
                    Id = "StructureMap.import",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/StructureMap"
                            }
                        }
                    }
                };
            }
            {
                // 22. StructureMap.group
                this.Element_Group = new ElementDefinitionInfo
                {
                    Name = "Element_Group",
                    Path= "StructureMap.group",
                    Id = "StructureMap.group",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Group
                        {
                        }
                    }
                };
            }
            this.Name = "StructureMap";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/StructureMap";
        }
    }
}
