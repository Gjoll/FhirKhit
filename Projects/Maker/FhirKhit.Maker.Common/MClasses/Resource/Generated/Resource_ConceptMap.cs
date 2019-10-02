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
      "id": "ConceptMap",
      "url": "http://hl7.org/fhir/StructureDefinition/ConceptMap",
      "version": "4.0.0",
      "name": "ConceptMap",
      "status": "draft",
      "publisher": "Health Level Seven International (Vocabulary)",
      "description": "A statement of relationships from one set of concepts to one or more other concepts - either concepts in code systems, or data element/data element concepts, or classes in class models.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ConceptMap",
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
            "id": "ConceptMap",
            "path": "ConceptMap",
            "short": "A map from one set of concepts to one or more other concepts",
            "definition": "A statement of relationships from one set of concepts to one or more other concepts - either concepts in code systems, or data element/data element concepts, or classes in class models.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ConceptMap.url",
            "path": "ConceptMap.url",
            "short": "Canonical identifier for this concept map, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this concept map when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this concept map is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the concept map is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the concept map to be referenced by a single globally unique identifier.",
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
            "id": "ConceptMap.identifier",
            "path": "ConceptMap.identifier",
            "short": "Additional identifier for the concept map",
            "definition": "A formal identifier that is used to identify this concept map when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this concept map outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "ConceptMap.version",
            "path": "ConceptMap.version",
            "short": "Business version of the concept map",
            "definition": "The identifier that is used to identify this version of the concept map when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the concept map author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different concept map instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the concept map with the format [url]|[version].",
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
            "id": "ConceptMap.name",
            "path": "ConceptMap.name",
            "short": "Name for this concept map (computer friendly)",
            "definition": "A natural language name identifying the concept map. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "ConceptMap.title",
            "path": "ConceptMap.title",
            "short": "Name for this concept map (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the concept map.",
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
            "id": "ConceptMap.status",
            "path": "ConceptMap.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this concept map. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of concept maps that are appropriate for use versus not.",
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
            "id": "ConceptMap.experimental",
            "path": "ConceptMap.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this concept map is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of concept maps that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level concept map.",
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
            "id": "ConceptMap.date",
            "path": "ConceptMap.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the concept map was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the concept map changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the concept map. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "ConceptMap.publisher",
            "path": "ConceptMap.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the concept map.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the concept map is the organization or individual primarily responsible for the maintenance and upkeep of the concept map. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the concept map. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the concept map.  May also allow for contact.",
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
            "id": "ConceptMap.contact",
            "path": "ConceptMap.contact",
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
            "id": "ConceptMap.description",
            "path": "ConceptMap.description",
            "short": "Natural language description of the concept map",
            "definition": "A free text natural language description of the concept map from a consumer's perspective.",
            "comment": "The description is not intended to describe the semantics of the concept map. The description should capture its intended use, which is needed for ensuring integrity for its use in models across future changes.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ConceptMap.useContext",
            "path": "ConceptMap.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate concept map instances.",
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
            "id": "ConceptMap.jurisdiction",
            "path": "ConceptMap.jurisdiction",
            "short": "Intended jurisdiction for concept map (if applicable)",
            "definition": "A legal or geographic region in which the concept map is intended to be used.",
            "comment": "It may be possible for the concept map to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "ConceptMap.purpose",
            "path": "ConceptMap.purpose",
            "short": "Why this concept map is defined",
            "definition": "Explanation of why this concept map is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the concept map. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this concept map.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ConceptMap.copyright",
            "path": "ConceptMap.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the concept map and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the concept map.",
            "comment": "Frequently the copyright differs between the concept map and codes that are included. The copyright statement should clearly differentiate between these when required.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the concept map and/or its content.",
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
            "id": "ConceptMap.source[x]",
            "path": "ConceptMap.source[x]",
            "short": "The source value set that contains the concepts that are being mapped",
            "definition": "Identifier for the source value set that contains the concepts that are being mapped and provides context for the mappings.",
            "comment": "Should be a version specific reference. URIs SHOULD be absolute. If there is no source or target value set, there is no specified context for the map (not recommended).  The source value set may select codes from either an explicit (standard or local) or implicit code system.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              },
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
            "id": "ConceptMap.target[x]",
            "path": "ConceptMap.target[x]",
            "short": "The target value set which provides context for the mappings",
            "definition": "The target value set provides context for the mappings. Note that the mapping is made between concepts, not between value sets, but the value set provides important context about how the concept mapping choices are made.",
            "comment": "Should be a version specific reference. URIs SHOULD be absolute. If there is no source or target value set, the is no specified context for the map.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              },
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
            "id": "ConceptMap.group",
            "path": "ConceptMap.group",
            "short": "Same source and target systems",
            "definition": "A group of mappings that all have the same source and target system.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ConceptMap.group.source",
            "path": "ConceptMap.group.source",
            "short": "Source system where concepts to be mapped are defined",
            "definition": "An absolute URI that identifies the source system where the concepts to be mapped are defined.",
            "comment": "This is not needed if the source value set is specified and it contains concepts from only a single system.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "ConceptMap.group.sourceVersion",
            "path": "ConceptMap.group.sourceVersion",
            "short": "Specific version of the  code system",
            "definition": "The specific version of the code system, as determined by the code system authority.",
            "comment": "The specification of a particular code system version may be required for code systems which lack concept permanence.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ConceptMap.group.target",
            "path": "ConceptMap.group.target",
            "short": "Target system that the concepts are to be mapped to",
            "definition": "An absolute URI that identifies the target system that the concepts will be mapped to.",
            "comment": "This is not needed if the target value set is specified and it contains concepts from only a single system. The group target may also be omitted if all of the target element equivalence values are 'unmatched'.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "ConceptMap.group.targetVersion",
            "path": "ConceptMap.group.targetVersion",
            "short": "Specific version of the  code system",
            "definition": "The specific version of the code system, as determined by the code system authority.",
            "comment": "The specification of a particular code system version may be required for code systems which lack concept permanence.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ConceptMap.group.element",
            "path": "ConceptMap.group.element",
            "short": "Mappings for a concept from the source set",
            "definition": "Mappings for an individual concept in the source to one or more concepts in the target.",
            "comment": "Generally, the ideal is that there would only be one mapping for each concept in the source value set, but a given concept may be mapped multiple times with different comments or dependencies.",
            "alias": [
              "code",
              "concept",
              "item"
            ],
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ConceptMap.group.element.code",
            "path": "ConceptMap.group.element.code",
            "short": "Identifies element being mapped",
            "definition": "Identity (code or path) or the element/item being mapped.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ]
          },
          {
            "id": "ConceptMap.group.element.display",
            "path": "ConceptMap.group.element.display",
            "short": "Display for the code",
            "definition": "The display for the code. The display is only provided to help editors when editing the concept map.",
            "comment": "The display is ignored when processing the map.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ConceptMap.group.element.target",
            "path": "ConceptMap.group.element.target",
            "short": "Concept in target system for element",
            "definition": "A concept from the target value set that this concept maps to.",
            "comment": "Ideally there would only be one map, with equal or equivalent mapping. But multiple maps are allowed for several narrower options, or to assert that other concepts are unmatched.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ConceptMap.group.element.target.code",
            "path": "ConceptMap.group.element.target.code",
            "short": "Code that identifies the target element",
            "definition": "Identity (code or path) or the element/item that the map refers to.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ]
          },
          {
            "id": "ConceptMap.group.element.target.display",
            "path": "ConceptMap.group.element.target.display",
            "short": "Display for the code",
            "definition": "The display for the code. The display is only provided to help editors when editing the concept map.",
            "comment": "The display is ignored when processing the map.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ConceptMap.group.element.target.equivalence",
            "path": "ConceptMap.group.element.target.equivalence",
            "short": "relatedto | equivalent | equal | wider | subsumes | narrower | specializes | inexact | unmatched | disjoint",
            "definition": "The equivalence between the source and target concepts (counting for the dependencies and products). The equivalence is read from target to source (e.g. the target is 'wider' than the source).",
            "comment": "This element is labeled as a modifier because it may indicate that a target does not apply.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "Some of the values mean that there is no mapping from the source to the target, particularly 'disjoint', and the mapping cannot be interpreted without knowing this value as it could mean the elements are equivalent, totally mismatched or anything in between",
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ConceptMapEquivalence"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The degree of equivalence between concepts.",
              "valueSet": "http://hl7.org/fhir/ValueSet/concept-map-equivalence|4.0.0"
            }
          },
          {
            "id": "ConceptMap.group.element.target.comment",
            "path": "ConceptMap.group.element.target.comment",
            "short": "Description of status/issues in mapping",
            "definition": "A description of status/issues in mapping that conveys additional information not represented in  the structured data.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "cmd-1"
            ]
          },
          {
            "id": "ConceptMap.group.element.target.dependsOn",
            "path": "ConceptMap.group.element.target.dependsOn",
            "short": "Other elements required for this mapping (from context)",
            "definition": "A set of additional dependencies for this mapping to hold. This mapping is only applicable if the specified element can be resolved, and it has the specified value.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ConceptMap.group.element.target.dependsOn.property",
            "path": "ConceptMap.group.element.target.dependsOn.property",
            "short": "Reference to property mapping depends on",
            "definition": "A reference to an element that holds a coded value that corresponds to a code system property. The idea is that the information model carries an element somewhere that is labeled to correspond with a code system property.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "ConceptMap.group.element.target.dependsOn.system",
            "path": "ConceptMap.group.element.target.dependsOn.system",
            "short": "Code System (if necessary)",
            "definition": "An absolute URI that identifies the code system of the dependency code (if the source/dependency is a value set that crosses code systems).",
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
            "meaningWhenMissing": "The code is in the source (dependsOn) or target (product) system"
          },
          {
            "id": "ConceptMap.group.element.target.dependsOn.value",
            "path": "ConceptMap.group.element.target.dependsOn.value",
            "short": "Value of the referenced element",
            "definition": "Identity (code or path) or the element/item/ValueSet/text that the map depends on / refers to.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ConceptMap.group.element.target.dependsOn.display",
            "path": "ConceptMap.group.element.target.dependsOn.display",
            "short": "Display for the code (if value is a code)",
            "definition": "The display for the code. The display is only provided to help editors when editing the concept map.",
            "comment": "The display is ignored when processing the map.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ConceptMap.group.element.target.product",
            "path": "ConceptMap.group.element.target.product",
            "short": "Other concepts that this mapping also produces",
            "definition": "A set of additional outcomes from this mapping to other elements. To properly execute this mapping, the specified element must be mapped to some data element or source that is in context. The mapping may still be useful without a place for the additional data elements, but the equivalence cannot be relied on.",
            "min": 0,
            "max": "*",
            "contentReference": "#ConceptMap.group.element.target.dependsOn"
          },
          {
            "id": "ConceptMap.group.unmapped",
            "path": "ConceptMap.group.unmapped",
            "short": "What to do when there is no mapping for the source concept",
            "definition": "What to do when there is no mapping for the source concept. \"Unmapped\" does not include codes that are unmatched, and the unmapped element is ignored in a code is specified to have equivalence = unmatched.",
            "comment": "This only applies if the source code has a system value that matches the system defined for the group.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ConceptMap.group.unmapped.mode",
            "path": "ConceptMap.group.unmapped.mode",
            "short": "provided | fixed | other-map",
            "definition": "Defines which action to take if there is no match for the source concept in the target system designated for the group. One of 3 actions are possible: use the unmapped code (this is useful when doing a mapping between versions, and only a few codes have changed), use a fixed code (a default code), or alternatively, a reference to a different concept map can be provided (by canonical URL).",
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
                  "valueString": "ConceptMapGroupUnmappedMode"
                }
              ],
              "strength": "required",
              "description": "Defines which action to take if there is no match in the group.",
              "valueSet": "http://hl7.org/fhir/ValueSet/conceptmap-unmapped-mode|4.0.0"
            }
          },
          {
            "id": "ConceptMap.group.unmapped.code",
            "path": "ConceptMap.group.unmapped.code",
            "short": "Fixed code when mode = fixed",
            "definition": "The fixed code to use when the mode = 'fixed'  - all unmapped codes are mapped to a single fixed code.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ]
          },
          {
            "id": "ConceptMap.group.unmapped.display",
            "path": "ConceptMap.group.unmapped.display",
            "short": "Display for the code",
            "definition": "The display for the code. The display is only provided to help editors when editing the concept map.",
            "comment": "The display is ignored when processing the map.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ConceptMap.group.unmapped.url",
            "path": "ConceptMap.group.unmapped.url",
            "short": "canonical reference to an additional ConceptMap to use for mapping if the source concept is unmapped",
            "definition": "The canonical reference to an additional ConceptMap resource instance to use for mapping if this ConceptMap resource contains no matching mapping for the source concept.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ConceptMap"
                ]
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'ConceptMap'
    /// </summary>
    // 0. ConceptMap
    public partial class Resource_ConceptMap : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 18. ConceptMap.group
        public partial class Type_Group : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 23. ConceptMap.group.element
            public partial class Type_Element : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 26. ConceptMap.group.element.target
                public partial class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase
                {
                    // 31. ConceptMap.group.element.target.dependsOn
                    public partial class Type_DependsOn : FhirKhit.Maker.Common.Complex.ComplexBase
                    {
                        // 32. ConceptMap.group.element.target.dependsOn.property
                        public ElementDefinitionInfo Element_Property;
                        // 33. ConceptMap.group.element.target.dependsOn.system
                        public ElementDefinitionInfo Element_System;
                        // 34. ConceptMap.group.element.target.dependsOn.value
                        public ElementDefinitionInfo Element_Value;
                        // 35. ConceptMap.group.element.target.dependsOn.display
                        public ElementDefinitionInfo Element_Display;
                        
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                        {
                            base.Write(sDef);
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                            {
                                Path = "ConceptMap.group.element.target.dependsOn",
                                ElementId = "ConceptMap.group.element.target.dependsOn"
                            });
                            Element_Property.Write(sDef);
                            Element_System.Write(sDef);
                            Element_Value.Write(sDef);
                            Element_Display.Write(sDef);
                        }
                        
                        public Type_DependsOn()
                        {
                            {
                                // 32. ConceptMap.group.element.target.dependsOn.property
                                this.Element_Property = new ElementDefinitionInfo
                                {
                                    Name = "Element_Property",
                                    Path= "ConceptMap.group.element.target.dependsOn.property",
                                    Id = "ConceptMap.group.element.target.dependsOn.property",
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
                                // 33. ConceptMap.group.element.target.dependsOn.system
                                this.Element_System = new ElementDefinitionInfo
                                {
                                    Name = "Element_System",
                                    Path= "ConceptMap.group.element.target.dependsOn.system",
                                    Id = "ConceptMap.group.element.target.dependsOn.system",
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
                                // 34. ConceptMap.group.element.target.dependsOn.value
                                this.Element_Value = new ElementDefinitionInfo
                                {
                                    Name = "Element_Value",
                                    Path= "ConceptMap.group.element.target.dependsOn.value",
                                    Id = "ConceptMap.group.element.target.dependsOn.value",
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
                                // 35. ConceptMap.group.element.target.dependsOn.display
                                this.Element_Display = new ElementDefinitionInfo
                                {
                                    Name = "Element_Display",
                                    Path= "ConceptMap.group.element.target.dependsOn.display",
                                    Id = "ConceptMap.group.element.target.dependsOn.display",
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
                    // 27. ConceptMap.group.element.target.code
                    public ElementDefinitionInfo Element_Code;
                    // 28. ConceptMap.group.element.target.display
                    public ElementDefinitionInfo Element_Display;
                    // 29. ConceptMap.group.element.target.equivalence
                    public ElementDefinitionInfo Element_Equivalence;
                    // 30. ConceptMap.group.element.target.comment
                    public ElementDefinitionInfo Element_Comment;
                    // 31. ConceptMap.group.element.target.dependsOn
                    public ElementDefinitionInfo Element_DependsOn;
                    // 36. ConceptMap.group.element.target.product
                    public ElementDefinitionInfo Element_Product;
                    
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                    {
                        base.Write(sDef);
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                        {
                            Path = "ConceptMap.group.element.target",
                            ElementId = "ConceptMap.group.element.target"
                        });
                        Element_Code.Write(sDef);
                        Element_Display.Write(sDef);
                        Element_Equivalence.Write(sDef);
                        Element_Comment.Write(sDef);
                        Element_DependsOn.Write(sDef);
                        Element_Product.Write(sDef);
                    }
                    
                    public Type_Target()
                    {
                        {
                            // 27. ConceptMap.group.element.target.code
                            this.Element_Code = new ElementDefinitionInfo
                            {
                                Name = "Element_Code",
                                Path= "ConceptMap.group.element.target.code",
                                Id = "ConceptMap.group.element.target.code",
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
                            // 28. ConceptMap.group.element.target.display
                            this.Element_Display = new ElementDefinitionInfo
                            {
                                Name = "Element_Display",
                                Path= "ConceptMap.group.element.target.display",
                                Id = "ConceptMap.group.element.target.display",
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
                            // 29. ConceptMap.group.element.target.equivalence
                            this.Element_Equivalence = new ElementDefinitionInfo
                            {
                                Name = "Element_Equivalence",
                                Path= "ConceptMap.group.element.target.equivalence",
                                Id = "ConceptMap.group.element.target.equivalence",
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
                            // 30. ConceptMap.group.element.target.comment
                            this.Element_Comment = new ElementDefinitionInfo
                            {
                                Name = "Element_Comment",
                                Path= "ConceptMap.group.element.target.comment",
                                Id = "ConceptMap.group.element.target.comment",
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
                            // 31. ConceptMap.group.element.target.dependsOn
                            this.Element_DependsOn = new ElementDefinitionInfo
                            {
                                Name = "Element_DependsOn",
                                Path= "ConceptMap.group.element.target.dependsOn",
                                Id = "ConceptMap.group.element.target.dependsOn",
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
                            // 36. ConceptMap.group.element.target.product
                            this.Element_Product = new ElementDefinitionInfo
                            {
                                Name = "Element_Product",
                                Path= "ConceptMap.group.element.target.product",
                                Id = "ConceptMap.group.element.target.product",
                                Min = 0,
                                Max = -1,
                                Types = new BaseType[]
                                {
                                }
                            };
                        }
                    }
                }
                // 24. ConceptMap.group.element.code
                public ElementDefinitionInfo Element_Code;
                // 25. ConceptMap.group.element.display
                public ElementDefinitionInfo Element_Display;
                // 26. ConceptMap.group.element.target
                public ElementDefinitionInfo Element_Target;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ConceptMap.group.element",
                        ElementId = "ConceptMap.group.element"
                    });
                    Element_Code.Write(sDef);
                    Element_Display.Write(sDef);
                    Element_Target.Write(sDef);
                }
                
                public Type_Element()
                {
                    {
                        // 24. ConceptMap.group.element.code
                        this.Element_Code = new ElementDefinitionInfo
                        {
                            Name = "Element_Code",
                            Path= "ConceptMap.group.element.code",
                            Id = "ConceptMap.group.element.code",
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
                        // 25. ConceptMap.group.element.display
                        this.Element_Display = new ElementDefinitionInfo
                        {
                            Name = "Element_Display",
                            Path= "ConceptMap.group.element.display",
                            Id = "ConceptMap.group.element.display",
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
                        // 26. ConceptMap.group.element.target
                        this.Element_Target = new ElementDefinitionInfo
                        {
                            Name = "Element_Target",
                            Path= "ConceptMap.group.element.target",
                            Id = "ConceptMap.group.element.target",
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
                }
            }
            // 37. ConceptMap.group.unmapped
            public partial class Type_Unmapped : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 38. ConceptMap.group.unmapped.mode
                public ElementDefinitionInfo Element_Mode;
                // 39. ConceptMap.group.unmapped.code
                public ElementDefinitionInfo Element_Code;
                // 40. ConceptMap.group.unmapped.display
                public ElementDefinitionInfo Element_Display;
                // 41. ConceptMap.group.unmapped.url
                public ElementDefinitionInfo Element_Url;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ConceptMap.group.unmapped",
                        ElementId = "ConceptMap.group.unmapped"
                    });
                    Element_Mode.Write(sDef);
                    Element_Code.Write(sDef);
                    Element_Display.Write(sDef);
                    Element_Url.Write(sDef);
                }
                
                public Type_Unmapped()
                {
                    {
                        // 38. ConceptMap.group.unmapped.mode
                        this.Element_Mode = new ElementDefinitionInfo
                        {
                            Name = "Element_Mode",
                            Path= "ConceptMap.group.unmapped.mode",
                            Id = "ConceptMap.group.unmapped.mode",
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
                        // 39. ConceptMap.group.unmapped.code
                        this.Element_Code = new ElementDefinitionInfo
                        {
                            Name = "Element_Code",
                            Path= "ConceptMap.group.unmapped.code",
                            Id = "ConceptMap.group.unmapped.code",
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
                        // 40. ConceptMap.group.unmapped.display
                        this.Element_Display = new ElementDefinitionInfo
                        {
                            Name = "Element_Display",
                            Path= "ConceptMap.group.unmapped.display",
                            Id = "ConceptMap.group.unmapped.display",
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
                        // 41. ConceptMap.group.unmapped.url
                        this.Element_Url = new ElementDefinitionInfo
                        {
                            Name = "Element_Url",
                            Path= "ConceptMap.group.unmapped.url",
                            Id = "ConceptMap.group.unmapped.url",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                                {
                                    TargetProfile = new String[]
                                    {
                                        "http://hl7.org/fhir/StructureDefinition/ConceptMap"
                                    }
                                }
                            }
                        };
                    }
                }
            }
            // 19. ConceptMap.group.source
            public ElementDefinitionInfo Element_Source;
            // 20. ConceptMap.group.sourceVersion
            public ElementDefinitionInfo Element_SourceVersion;
            // 21. ConceptMap.group.target
            public ElementDefinitionInfo Element_Target;
            // 22. ConceptMap.group.targetVersion
            public ElementDefinitionInfo Element_TargetVersion;
            // 23. ConceptMap.group.element
            public ElementDefinitionInfo Element_Element;
            // 37. ConceptMap.group.unmapped
            public ElementDefinitionInfo Element_Unmapped;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ConceptMap.group",
                    ElementId = "ConceptMap.group"
                });
                Element_Source.Write(sDef);
                Element_SourceVersion.Write(sDef);
                Element_Target.Write(sDef);
                Element_TargetVersion.Write(sDef);
                Element_Element.Write(sDef);
                Element_Unmapped.Write(sDef);
            }
            
            public Type_Group()
            {
                {
                    // 19. ConceptMap.group.source
                    this.Element_Source = new ElementDefinitionInfo
                    {
                        Name = "Element_Source",
                        Path= "ConceptMap.group.source",
                        Id = "ConceptMap.group.source",
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
                    // 20. ConceptMap.group.sourceVersion
                    this.Element_SourceVersion = new ElementDefinitionInfo
                    {
                        Name = "Element_SourceVersion",
                        Path= "ConceptMap.group.sourceVersion",
                        Id = "ConceptMap.group.sourceVersion",
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
                    // 21. ConceptMap.group.target
                    this.Element_Target = new ElementDefinitionInfo
                    {
                        Name = "Element_Target",
                        Path= "ConceptMap.group.target",
                        Id = "ConceptMap.group.target",
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
                    // 22. ConceptMap.group.targetVersion
                    this.Element_TargetVersion = new ElementDefinitionInfo
                    {
                        Name = "Element_TargetVersion",
                        Path= "ConceptMap.group.targetVersion",
                        Id = "ConceptMap.group.targetVersion",
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
                    // 23. ConceptMap.group.element
                    this.Element_Element = new ElementDefinitionInfo
                    {
                        Name = "Element_Element",
                        Path= "ConceptMap.group.element",
                        Id = "ConceptMap.group.element",
                        Min = 1,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Element
                            {
                            }
                        }
                    };
                }
                {
                    // 37. ConceptMap.group.unmapped
                    this.Element_Unmapped = new ElementDefinitionInfo
                    {
                        Name = "Element_Unmapped",
                        Path= "ConceptMap.group.unmapped",
                        Id = "ConceptMap.group.unmapped",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new Type_Unmapped
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. ConceptMap.url
        public ElementDefinitionInfo Element_Url;
        // 2. ConceptMap.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. ConceptMap.version
        public ElementDefinitionInfo Element_Version;
        // 4. ConceptMap.name
        public ElementDefinitionInfo Element_Name;
        // 5. ConceptMap.title
        public ElementDefinitionInfo Element_Title;
        // 6. ConceptMap.status
        public ElementDefinitionInfo Element_Status;
        // 7. ConceptMap.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 8. ConceptMap.date
        public ElementDefinitionInfo Element_Date;
        // 9. ConceptMap.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 10. ConceptMap.contact
        public ElementDefinitionInfo Element_Contact;
        // 11. ConceptMap.description
        public ElementDefinitionInfo Element_Description;
        // 12. ConceptMap.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 13. ConceptMap.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 14. ConceptMap.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 15. ConceptMap.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 16. ConceptMap.source[x]
        public ElementDefinitionInfo Element_Source;
        // 17. ConceptMap.target[x]
        public ElementDefinitionInfo Element_Target;
        // 18. ConceptMap.group
        public ElementDefinitionInfo Element_Group;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ConceptMap",
                ElementId = "ConceptMap"
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
            Element_Source.Write(sDef);
            Element_Target.Write(sDef);
            Element_Group.Write(sDef);
        }
        
        public Resource_ConceptMap()
        {
            {
                // 1. ConceptMap.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "ConceptMap.url",
                    Id = "ConceptMap.url",
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
                // 2. ConceptMap.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ConceptMap.identifier",
                    Id = "ConceptMap.identifier",
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
                // 3. ConceptMap.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "ConceptMap.version",
                    Id = "ConceptMap.version",
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
                // 4. ConceptMap.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "ConceptMap.name",
                    Id = "ConceptMap.name",
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
                // 5. ConceptMap.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "ConceptMap.title",
                    Id = "ConceptMap.title",
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
                // 6. ConceptMap.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ConceptMap.status",
                    Id = "ConceptMap.status",
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
                // 7. ConceptMap.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "ConceptMap.experimental",
                    Id = "ConceptMap.experimental",
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
                // 8. ConceptMap.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "ConceptMap.date",
                    Id = "ConceptMap.date",
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
                // 9. ConceptMap.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "ConceptMap.publisher",
                    Id = "ConceptMap.publisher",
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
                // 10. ConceptMap.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "ConceptMap.contact",
                    Id = "ConceptMap.contact",
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
                // 11. ConceptMap.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "ConceptMap.description",
                    Id = "ConceptMap.description",
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
                // 12. ConceptMap.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "ConceptMap.useContext",
                    Id = "ConceptMap.useContext",
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
                // 13. ConceptMap.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "ConceptMap.jurisdiction",
                    Id = "ConceptMap.jurisdiction",
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
                // 14. ConceptMap.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "ConceptMap.purpose",
                    Id = "ConceptMap.purpose",
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
                // 15. ConceptMap.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "ConceptMap.copyright",
                    Id = "ConceptMap.copyright",
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
                // 16. ConceptMap.source[x]
                this.Element_Source = new ElementDefinitionInfo
                {
                    Name = "Element_Source",
                    Path= "ConceptMap.source[x]",
                    Id = "ConceptMap.source[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        },
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
                // 17. ConceptMap.target[x]
                this.Element_Target = new ElementDefinitionInfo
                {
                    Name = "Element_Target",
                    Path= "ConceptMap.target[x]",
                    Id = "ConceptMap.target[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        },
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
                // 18. ConceptMap.group
                this.Element_Group = new ElementDefinitionInfo
                {
                    Name = "Element_Group",
                    Path= "ConceptMap.group",
                    Id = "ConceptMap.group",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Group
                        {
                        }
                    }
                };
            }
            this.Name = "ConceptMap";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ConceptMap";
        }
    }
}
