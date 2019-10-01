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
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'ConceptMap'
    /// </summary>
    // 0. ConceptMap
    public class ConceptMap : FhirKhit.Maker.Common.Resource.ResourceBase                                                                   // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class ConceptMap_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                      // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 18. ConceptMap.group
            public class Type_Group : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Group_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                              // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 23. ConceptMap.group.element
                    public class Type_Element : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Element_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 26. ConceptMap.group.element.target
                            public class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase                                            // MakerGen.cs:384
                            {                                                                                                               // MakerGen.cs:385
                                public class Type_Target_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                             // MakerGen.cs:386
                                {                                                                                                           // MakerGen.cs:387
                                    // 31. ConceptMap.group.element.target.dependsOn
                                    public class Type_DependsOn : FhirKhit.Maker.Common.Complex.ComplexBase                                 // MakerGen.cs:384
                                    {                                                                                                       // MakerGen.cs:385
                                        public class Type_DependsOn_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                  // MakerGen.cs:386
                                        {                                                                                                   // MakerGen.cs:387
                                            // 32. ConceptMap.group.element.target.dependsOn.property
                                            public ElementDefinitionInfo Property;                                                          // MakerGen.cs:216
                                            // 33. ConceptMap.group.element.target.dependsOn.system
                                            public ElementDefinitionInfo System;                                                            // MakerGen.cs:216
                                            // 34. ConceptMap.group.element.target.dependsOn.value
                                            public ElementDefinitionInfo Value;                                                             // MakerGen.cs:216
                                            // 35. ConceptMap.group.element.target.dependsOn.display
                                            public ElementDefinitionInfo Display;                                                           // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                                            public Type_DependsOn_Elements()                                                                // MakerGen.cs:392
                                            {                                                                                               // MakerGen.cs:393
                                                {                                                                                           // MakerGen.cs:231
                                                    // 32. ConceptMap.group.element.target.dependsOn.property
                                                    this.Property = new ElementDefinitionInfo                                               // MakerGen.cs:233
                                                    {                                                                                       // MakerGen.cs:234
                                                        Name = "Property",                                                                  // MakerGen.cs:235
                                                        Path= "ConceptMap.group.element.target.dependsOn.property",                         // MakerGen.cs:236
                                                        Id = "ConceptMap.group.element.target.dependsOn.property",                          // MakerGen.cs:237
                                                        Min = 1,                                                                            // MakerGen.cs:238
                                                        Max = 1,                                                                            // MakerGen.cs:239
                                                        Types = new BaseType[]                                                              // MakerGen.cs:240
                                                        {                                                                                   // MakerGen.cs:241
                                                            new FhirKhit.Maker.Common.Primitive.Uri                                         // MakerGen.cs:300
                                                            {                                                                               // MakerGen.cs:301
                                                            }                                                                               // MakerGen.cs:304
                                                        }                                                                                   // MakerGen.cs:243
                                                    };                                                                                      // MakerGen.cs:244
                                                }                                                                                           // MakerGen.cs:245
                                                {                                                                                           // MakerGen.cs:231
                                                    // 33. ConceptMap.group.element.target.dependsOn.system
                                                    this.System = new ElementDefinitionInfo                                                 // MakerGen.cs:233
                                                    {                                                                                       // MakerGen.cs:234
                                                        Name = "System",                                                                    // MakerGen.cs:235
                                                        Path= "ConceptMap.group.element.target.dependsOn.system",                           // MakerGen.cs:236
                                                        Id = "ConceptMap.group.element.target.dependsOn.system",                            // MakerGen.cs:237
                                                        Min = 0,                                                                            // MakerGen.cs:238
                                                        Max = 1,                                                                            // MakerGen.cs:239
                                                        Types = new BaseType[]                                                              // MakerGen.cs:240
                                                        {                                                                                   // MakerGen.cs:241
                                                            new FhirKhit.Maker.Common.Primitive.Canonical                                   // MakerGen.cs:300
                                                            {                                                                               // MakerGen.cs:301
                                                                TargetProfile = new String[]                                                // MakerGen.cs:303
                                                                {                                                                           // CodeEditorExtensions.cs:28
                                                                    "http://hl7.org/fhir/StructureDefinition/CodeSystem"                    // MakerGen.cs:303
                                                                }                                                                           // CodeEditorExtensions.cs:34
                                                            }                                                                               // MakerGen.cs:304
                                                        }                                                                                   // MakerGen.cs:243
                                                    };                                                                                      // MakerGen.cs:244
                                                }                                                                                           // MakerGen.cs:245
                                                {                                                                                           // MakerGen.cs:231
                                                    // 34. ConceptMap.group.element.target.dependsOn.value
                                                    this.Value = new ElementDefinitionInfo                                                  // MakerGen.cs:233
                                                    {                                                                                       // MakerGen.cs:234
                                                        Name = "Value",                                                                     // MakerGen.cs:235
                                                        Path= "ConceptMap.group.element.target.dependsOn.value",                            // MakerGen.cs:236
                                                        Id = "ConceptMap.group.element.target.dependsOn.value",                             // MakerGen.cs:237
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
                                                {                                                                                           // MakerGen.cs:231
                                                    // 35. ConceptMap.group.element.target.dependsOn.display
                                                    this.Display = new ElementDefinitionInfo                                                // MakerGen.cs:233
                                                    {                                                                                       // MakerGen.cs:234
                                                        Name = "Display",                                                                   // MakerGen.cs:235
                                                        Path= "ConceptMap.group.element.target.dependsOn.display",                          // MakerGen.cs:236
                                                        Id = "ConceptMap.group.element.target.dependsOn.display",                           // MakerGen.cs:237
                                                        Min = 0,                                                                            // MakerGen.cs:238
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
                                                Property.Write(sDef);                                                                       // MakerGen.cs:220
                                                System.Write(sDef);                                                                         // MakerGen.cs:220
                                                Value.Write(sDef);                                                                          // MakerGen.cs:220
                                                Display.Write(sDef);                                                                        // MakerGen.cs:220
                                            }                                                                                               // MakerGen.cs:402
                                        }                                                                                                   // MakerGen.cs:404
                                        public Type_DependsOn_Elements Elements                                                             // MakerGen.cs:406
                                        {                                                                                                   // MakerGen.cs:407
                                            get                                                                                             // MakerGen.cs:408
                                            {                                                                                               // MakerGen.cs:409
                                                if (this.elements == null)                                                                  // MakerGen.cs:410
                                                    this.elements = new Type_DependsOn_Elements();                                          // MakerGen.cs:411
                                                return this.elements;                                                                       // MakerGen.cs:412
                                            }                                                                                               // MakerGen.cs:413
                                        }                                                                                                   // MakerGen.cs:414
                                        Type_DependsOn_Elements elements;                                                                   // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                                        public Type_DependsOn()                                                                             // MakerGen.cs:418
                                        {                                                                                                   // MakerGen.cs:419
                                        }                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                 // MakerGen.cs:424
                                        {                                                                                                   // MakerGen.cs:425
                                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                              // MakerGen.cs:426
                                            {                                                                                               // MakerGen.cs:427
                                                Path = "ConceptMap.group.element.target.dependsOn",                                         // MakerGen.cs:428
                                                ElementId = "ConceptMap.group.element.target.dependsOn"                                     // MakerGen.cs:429
                                            });                                                                                             // MakerGen.cs:430
                                            if (this.elements != null)                                                                      // MakerGen.cs:431
                                                this.elements.Write(sDef);                                                                  // MakerGen.cs:432
                                        }                                                                                                   // MakerGen.cs:433
                                    }                                                                                                       // MakerGen.cs:434
                                    // 27. ConceptMap.group.element.target.code
                                    public ElementDefinitionInfo Code;                                                                      // MakerGen.cs:216
                                    // 28. ConceptMap.group.element.target.display
                                    public ElementDefinitionInfo Display;                                                                   // MakerGen.cs:216
                                    // 29. ConceptMap.group.element.target.equivalence
                                    public ElementDefinitionInfo Equivalence;                                                               // MakerGen.cs:216
                                    // 30. ConceptMap.group.element.target.comment
                                    public ElementDefinitionInfo Comment;                                                                   // MakerGen.cs:216
                                    // 31. ConceptMap.group.element.target.dependsOn
                                    public ElementDefinitionInfo DependsOn;                                                                 // MakerGen.cs:216
                                    // 36. ConceptMap.group.element.target.product
                                    public ElementDefinitionInfo Product;                                                                   // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                                    public Type_Target_Elements()                                                                           // MakerGen.cs:392
                                    {                                                                                                       // MakerGen.cs:393
                                        {                                                                                                   // MakerGen.cs:231
                                            // 27. ConceptMap.group.element.target.code
                                            this.Code = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Code",                                                                              // MakerGen.cs:235
                                                Path= "ConceptMap.group.element.target.code",                                               // MakerGen.cs:236
                                                Id = "ConceptMap.group.element.target.code",                                                // MakerGen.cs:237
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
                                            // 28. ConceptMap.group.element.target.display
                                            this.Display = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Display",                                                                           // MakerGen.cs:235
                                                Path= "ConceptMap.group.element.target.display",                                            // MakerGen.cs:236
                                                Id = "ConceptMap.group.element.target.display",                                             // MakerGen.cs:237
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
                                            // 29. ConceptMap.group.element.target.equivalence
                                            this.Equivalence = new ElementDefinitionInfo                                                    // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Equivalence",                                                                       // MakerGen.cs:235
                                                Path= "ConceptMap.group.element.target.equivalence",                                        // MakerGen.cs:236
                                                Id = "ConceptMap.group.element.target.equivalence",                                         // MakerGen.cs:237
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
                                            // 30. ConceptMap.group.element.target.comment
                                            this.Comment = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Comment",                                                                           // MakerGen.cs:235
                                                Path= "ConceptMap.group.element.target.comment",                                            // MakerGen.cs:236
                                                Id = "ConceptMap.group.element.target.comment",                                             // MakerGen.cs:237
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
                                            // 31. ConceptMap.group.element.target.dependsOn
                                            this.DependsOn = new ElementDefinitionInfo                                                      // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "DependsOn",                                                                         // MakerGen.cs:235
                                                Path= "ConceptMap.group.element.target.dependsOn",                                          // MakerGen.cs:236
                                                Id = "ConceptMap.group.element.target.dependsOn",                                           // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
                                                    new Type_DependsOn                                                                      // MakerGen.cs:259
                                                    {                                                                                       // MakerGen.cs:260
                                                    }                                                                                       // MakerGen.cs:261
                                                }                                                                                           // MakerGen.cs:243
                                            };                                                                                              // MakerGen.cs:244
                                        }                                                                                                   // MakerGen.cs:245
                                        {                                                                                                   // MakerGen.cs:231
                                            // 36. ConceptMap.group.element.target.product
                                            this.Product = new ElementDefinitionInfo                                                        // MakerGen.cs:233
                                            {                                                                                               // MakerGen.cs:234
                                                Name = "Product",                                                                           // MakerGen.cs:235
                                                Path= "ConceptMap.group.element.target.product",                                            // MakerGen.cs:236
                                                Id = "ConceptMap.group.element.target.product",                                             // MakerGen.cs:237
                                                Min = 0,                                                                                    // MakerGen.cs:238
                                                Max = -1,                                                                                   // MakerGen.cs:239
                                                Types = new BaseType[]                                                                      // MakerGen.cs:240
                                                {                                                                                           // MakerGen.cs:241
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
                                        Equivalence.Write(sDef);                                                                            // MakerGen.cs:220
                                        Comment.Write(sDef);                                                                                // MakerGen.cs:220
                                        DependsOn.Write(sDef);                                                                              // MakerGen.cs:220
                                        Product.Write(sDef);                                                                                // MakerGen.cs:220
                                    }                                                                                                       // MakerGen.cs:402
                                }                                                                                                           // MakerGen.cs:404
                                public Type_Target_Elements Elements                                                                        // MakerGen.cs:406
                                {                                                                                                           // MakerGen.cs:407
                                    get                                                                                                     // MakerGen.cs:408
                                    {                                                                                                       // MakerGen.cs:409
                                        if (this.elements == null)                                                                          // MakerGen.cs:410
                                            this.elements = new Type_Target_Elements();                                                     // MakerGen.cs:411
                                        return this.elements;                                                                               // MakerGen.cs:412
                                    }                                                                                                       // MakerGen.cs:413
                                }                                                                                                           // MakerGen.cs:414
                                Type_Target_Elements elements;                                                                              // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                                public Type_Target()                                                                                        // MakerGen.cs:418
                                {                                                                                                           // MakerGen.cs:419
                                }                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                         // MakerGen.cs:424
                                {                                                                                                           // MakerGen.cs:425
                                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                      // MakerGen.cs:426
                                    {                                                                                                       // MakerGen.cs:427
                                        Path = "ConceptMap.group.element.target",                                                           // MakerGen.cs:428
                                        ElementId = "ConceptMap.group.element.target"                                                       // MakerGen.cs:429
                                    });                                                                                                     // MakerGen.cs:430
                                    if (this.elements != null)                                                                              // MakerGen.cs:431
                                        this.elements.Write(sDef);                                                                          // MakerGen.cs:432
                                }                                                                                                           // MakerGen.cs:433
                            }                                                                                                               // MakerGen.cs:434
                            // 24. ConceptMap.group.element.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:216
                            // 25. ConceptMap.group.element.display
                            public ElementDefinitionInfo Display;                                                                           // MakerGen.cs:216
                            // 26. ConceptMap.group.element.target
                            public ElementDefinitionInfo Target;                                                                            // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Element_Elements()                                                                                  // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 24. ConceptMap.group.element.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Code",                                                                                      // MakerGen.cs:235
                                        Path= "ConceptMap.group.element.code",                                                              // MakerGen.cs:236
                                        Id = "ConceptMap.group.element.code",                                                               // MakerGen.cs:237
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
                                    // 25. ConceptMap.group.element.display
                                    this.Display = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Display",                                                                                   // MakerGen.cs:235
                                        Path= "ConceptMap.group.element.display",                                                           // MakerGen.cs:236
                                        Id = "ConceptMap.group.element.display",                                                            // MakerGen.cs:237
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
                                    // 26. ConceptMap.group.element.target
                                    this.Target = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Target",                                                                                    // MakerGen.cs:235
                                        Path= "ConceptMap.group.element.target",                                                            // MakerGen.cs:236
                                        Id = "ConceptMap.group.element.target",                                                             // MakerGen.cs:237
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
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Code.Write(sDef);                                                                                           // MakerGen.cs:220
                                Display.Write(sDef);                                                                                        // MakerGen.cs:220
                                Target.Write(sDef);                                                                                         // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Element_Elements Elements                                                                               // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Element_Elements();                                                            // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Element_Elements elements;                                                                                     // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Element()                                                                                               // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "ConceptMap.group.element",                                                                          // MakerGen.cs:428
                                ElementId = "ConceptMap.group.element"                                                                      // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 37. ConceptMap.group.unmapped
                    public class Type_Unmapped : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_Unmapped_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                   // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 38. ConceptMap.group.unmapped.mode
                            public ElementDefinitionInfo Mode;                                                                              // MakerGen.cs:216
                            // 39. ConceptMap.group.unmapped.code
                            public ElementDefinitionInfo Code;                                                                              // MakerGen.cs:216
                            // 40. ConceptMap.group.unmapped.display
                            public ElementDefinitionInfo Display;                                                                           // MakerGen.cs:216
                            // 41. ConceptMap.group.unmapped.url
                            public ElementDefinitionInfo Url;                                                                               // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_Unmapped_Elements()                                                                                 // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 38. ConceptMap.group.unmapped.mode
                                    this.Mode = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Mode",                                                                                      // MakerGen.cs:235
                                        Path= "ConceptMap.group.unmapped.mode",                                                             // MakerGen.cs:236
                                        Id = "ConceptMap.group.unmapped.mode",                                                              // MakerGen.cs:237
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
                                    // 39. ConceptMap.group.unmapped.code
                                    this.Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Code",                                                                                      // MakerGen.cs:235
                                        Path= "ConceptMap.group.unmapped.code",                                                             // MakerGen.cs:236
                                        Id = "ConceptMap.group.unmapped.code",                                                              // MakerGen.cs:237
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
                                    // 40. ConceptMap.group.unmapped.display
                                    this.Display = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Display",                                                                                   // MakerGen.cs:235
                                        Path= "ConceptMap.group.unmapped.display",                                                          // MakerGen.cs:236
                                        Id = "ConceptMap.group.unmapped.display",                                                           // MakerGen.cs:237
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
                                    // 41. ConceptMap.group.unmapped.url
                                    this.Url = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Url",                                                                                       // MakerGen.cs:235
                                        Path= "ConceptMap.group.unmapped.url",                                                              // MakerGen.cs:236
                                        Id = "ConceptMap.group.unmapped.url",                                                               // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Canonical                                                   // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                                TargetProfile = new String[]                                                                // MakerGen.cs:303
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/ConceptMap"                                    // MakerGen.cs:303
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
                                Mode.Write(sDef);                                                                                           // MakerGen.cs:220
                                Code.Write(sDef);                                                                                           // MakerGen.cs:220
                                Display.Write(sDef);                                                                                        // MakerGen.cs:220
                                Url.Write(sDef);                                                                                            // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_Unmapped_Elements Elements                                                                              // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_Unmapped_Elements();                                                           // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_Unmapped_Elements elements;                                                                                    // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_Unmapped()                                                                                              // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "ConceptMap.group.unmapped",                                                                         // MakerGen.cs:428
                                ElementId = "ConceptMap.group.unmapped"                                                                     // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 19. ConceptMap.group.source
                    public ElementDefinitionInfo Source;                                                                                    // MakerGen.cs:216
                    // 20. ConceptMap.group.sourceVersion
                    public ElementDefinitionInfo SourceVersion;                                                                             // MakerGen.cs:216
                    // 21. ConceptMap.group.target
                    public ElementDefinitionInfo Target;                                                                                    // MakerGen.cs:216
                    // 22. ConceptMap.group.targetVersion
                    public ElementDefinitionInfo TargetVersion;                                                                             // MakerGen.cs:216
                    // 23. ConceptMap.group.element
                    public ElementDefinitionInfo Element;                                                                                   // MakerGen.cs:216
                    // 37. ConceptMap.group.unmapped
                    public ElementDefinitionInfo Unmapped;                                                                                  // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Group_Elements()                                                                                            // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 19. ConceptMap.group.source
                            this.Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Source",                                                                                            // MakerGen.cs:235
                                Path= "ConceptMap.group.source",                                                                            // MakerGen.cs:236
                                Id = "ConceptMap.group.source",                                                                             // MakerGen.cs:237
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
                            // 20. ConceptMap.group.sourceVersion
                            this.SourceVersion = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "SourceVersion",                                                                                     // MakerGen.cs:235
                                Path= "ConceptMap.group.sourceVersion",                                                                     // MakerGen.cs:236
                                Id = "ConceptMap.group.sourceVersion",                                                                      // MakerGen.cs:237
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
                            // 21. ConceptMap.group.target
                            this.Target = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Target",                                                                                            // MakerGen.cs:235
                                Path= "ConceptMap.group.target",                                                                            // MakerGen.cs:236
                                Id = "ConceptMap.group.target",                                                                             // MakerGen.cs:237
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
                            // 22. ConceptMap.group.targetVersion
                            this.TargetVersion = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "TargetVersion",                                                                                     // MakerGen.cs:235
                                Path= "ConceptMap.group.targetVersion",                                                                     // MakerGen.cs:236
                                Id = "ConceptMap.group.targetVersion",                                                                      // MakerGen.cs:237
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
                            // 23. ConceptMap.group.element
                            this.Element = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Element",                                                                                           // MakerGen.cs:235
                                Path= "ConceptMap.group.element",                                                                           // MakerGen.cs:236
                                Id = "ConceptMap.group.element",                                                                            // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Element                                                                                        // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 37. ConceptMap.group.unmapped
                            this.Unmapped = new ElementDefinitionInfo                                                                       // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Unmapped",                                                                                          // MakerGen.cs:235
                                Path= "ConceptMap.group.unmapped",                                                                          // MakerGen.cs:236
                                Id = "ConceptMap.group.unmapped",                                                                           // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_Unmapped                                                                                       // MakerGen.cs:259
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
                        Source.Write(sDef);                                                                                                 // MakerGen.cs:220
                        SourceVersion.Write(sDef);                                                                                          // MakerGen.cs:220
                        Target.Write(sDef);                                                                                                 // MakerGen.cs:220
                        TargetVersion.Write(sDef);                                                                                          // MakerGen.cs:220
                        Element.Write(sDef);                                                                                                // MakerGen.cs:220
                        Unmapped.Write(sDef);                                                                                               // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Group_Elements Elements                                                                                         // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Group_Elements();                                                                      // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Group_Elements elements;                                                                                               // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Group()                                                                                                         // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "ConceptMap.group",                                                                                          // MakerGen.cs:428
                        ElementId = "ConceptMap.group"                                                                                      // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. ConceptMap.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:216
            // 2. ConceptMap.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 3. ConceptMap.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:216
            // 4. ConceptMap.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 5. ConceptMap.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:216
            // 6. ConceptMap.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 7. ConceptMap.experimental
            public ElementDefinitionInfo Experimental;                                                                                      // MakerGen.cs:216
            // 8. ConceptMap.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:216
            // 9. ConceptMap.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:216
            // 10. ConceptMap.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:216
            // 11. ConceptMap.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 12. ConceptMap.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:216
            // 13. ConceptMap.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:216
            // 14. ConceptMap.purpose
            public ElementDefinitionInfo Purpose;                                                                                           // MakerGen.cs:216
            // 15. ConceptMap.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:216
            // 16. ConceptMap.source[x]
            public ElementDefinitionInfo Source;                                                                                            // MakerGen.cs:216
            // 17. ConceptMap.target[x]
            public ElementDefinitionInfo Target;                                                                                            // MakerGen.cs:216
            // 18. ConceptMap.group
            public ElementDefinitionInfo Group;                                                                                             // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public ConceptMap_Elements()                                                                                                    // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. ConceptMap.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Url",                                                                                                       // MakerGen.cs:235
                        Path= "ConceptMap.url",                                                                                             // MakerGen.cs:236
                        Id = "ConceptMap.url",                                                                                              // MakerGen.cs:237
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
                    // 2. ConceptMap.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "ConceptMap.identifier",                                                                                      // MakerGen.cs:236
                        Id = "ConceptMap.identifier",                                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. ConceptMap.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Version",                                                                                                   // MakerGen.cs:235
                        Path= "ConceptMap.version",                                                                                         // MakerGen.cs:236
                        Id = "ConceptMap.version",                                                                                          // MakerGen.cs:237
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
                    // 4. ConceptMap.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "ConceptMap.name",                                                                                            // MakerGen.cs:236
                        Id = "ConceptMap.name",                                                                                             // MakerGen.cs:237
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
                    // 5. ConceptMap.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Title",                                                                                                     // MakerGen.cs:235
                        Path= "ConceptMap.title",                                                                                           // MakerGen.cs:236
                        Id = "ConceptMap.title",                                                                                            // MakerGen.cs:237
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
                    // 6. ConceptMap.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "ConceptMap.status",                                                                                          // MakerGen.cs:236
                        Id = "ConceptMap.status",                                                                                           // MakerGen.cs:237
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
                    // 7. ConceptMap.experimental
                    this.Experimental = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Experimental",                                                                                              // MakerGen.cs:235
                        Path= "ConceptMap.experimental",                                                                                    // MakerGen.cs:236
                        Id = "ConceptMap.experimental",                                                                                     // MakerGen.cs:237
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
                    // 8. ConceptMap.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Date",                                                                                                      // MakerGen.cs:235
                        Path= "ConceptMap.date",                                                                                            // MakerGen.cs:236
                        Id = "ConceptMap.date",                                                                                             // MakerGen.cs:237
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
                    // 9. ConceptMap.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Publisher",                                                                                                 // MakerGen.cs:235
                        Path= "ConceptMap.publisher",                                                                                       // MakerGen.cs:236
                        Id = "ConceptMap.publisher",                                                                                        // MakerGen.cs:237
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
                    // 10. ConceptMap.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Contact",                                                                                                   // MakerGen.cs:235
                        Path= "ConceptMap.contact",                                                                                         // MakerGen.cs:236
                        Id = "ConceptMap.contact",                                                                                          // MakerGen.cs:237
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
                    // 11. ConceptMap.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "ConceptMap.description",                                                                                     // MakerGen.cs:236
                        Id = "ConceptMap.description",                                                                                      // MakerGen.cs:237
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
                    // 12. ConceptMap.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "UseContext",                                                                                                // MakerGen.cs:235
                        Path= "ConceptMap.useContext",                                                                                      // MakerGen.cs:236
                        Id = "ConceptMap.useContext",                                                                                       // MakerGen.cs:237
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
                    // 13. ConceptMap.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:235
                        Path= "ConceptMap.jurisdiction",                                                                                    // MakerGen.cs:236
                        Id = "ConceptMap.jurisdiction",                                                                                     // MakerGen.cs:237
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
                    // 14. ConceptMap.purpose
                    this.Purpose = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Purpose",                                                                                                   // MakerGen.cs:235
                        Path= "ConceptMap.purpose",                                                                                         // MakerGen.cs:236
                        Id = "ConceptMap.purpose",                                                                                          // MakerGen.cs:237
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
                    // 15. ConceptMap.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Copyright",                                                                                                 // MakerGen.cs:235
                        Path= "ConceptMap.copyright",                                                                                       // MakerGen.cs:236
                        Id = "ConceptMap.copyright",                                                                                        // MakerGen.cs:237
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
                    // 16. ConceptMap.source[x]
                    this.Source = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Source",                                                                                                    // MakerGen.cs:235
                        Path= "ConceptMap.source[x]",                                                                                       // MakerGen.cs:236
                        Id = "ConceptMap.source[x]",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
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
                    // 17. ConceptMap.target[x]
                    this.Target = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Target",                                                                                                    // MakerGen.cs:235
                        Path= "ConceptMap.target[x]",                                                                                       // MakerGen.cs:236
                        Id = "ConceptMap.target[x]",                                                                                        // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            },                                                                                                              // MakerGen.cs:304
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
                    // 18. ConceptMap.group
                    this.Group = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Group",                                                                                                     // MakerGen.cs:235
                        Path= "ConceptMap.group",                                                                                           // MakerGen.cs:236
                        Id = "ConceptMap.group",                                                                                            // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Group                                                                                                  // MakerGen.cs:259
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
                Purpose.Write(sDef);                                                                                                        // MakerGen.cs:220
                Copyright.Write(sDef);                                                                                                      // MakerGen.cs:220
                Source.Write(sDef);                                                                                                         // MakerGen.cs:220
                Target.Write(sDef);                                                                                                         // MakerGen.cs:220
                Group.Write(sDef);                                                                                                          // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public ConceptMap_Elements Elements                                                                                                 // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new ConceptMap_Elements();                                                                              // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        ConceptMap_Elements elements;                                                                                                       // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public ConceptMap()                                                                                                                 // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "ConceptMap";                                                                                                       // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ConceptMap";                                                                // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "ConceptMap",                                                                                                        // MakerGen.cs:428
                ElementId = "ConceptMap"                                                                                                    // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
