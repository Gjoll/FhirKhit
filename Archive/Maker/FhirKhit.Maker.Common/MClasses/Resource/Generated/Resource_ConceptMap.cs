using System;                                                                                                                               // MakerGen.cs:432
using System.Diagnostics;                                                                                                                   // MakerGen.cs:433
using System.IO;                                                                                                                            // MakerGen.cs:434
using System.Linq;                                                                                                                          // MakerGen.cs:435
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:436
                                                                                                                                            // MakerGen.cs:437
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:438
{                                                                                                                                           // MakerGen.cs:439
    #region Json                                                                                                                            // MakerGen.cs:440
    #if NEVER                                                                                                                               // MakerGen.cs:441
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
    #endregion                                                                                                                              // MakerGen.cs:444
    /// <summary>
    /// Fhir resource 'ConceptMap'
    /// </summary>
    // 0. ConceptMap
    public partial class Resource_ConceptMap : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                       // MakerGen.cs:381
    {                                                                                                                                       // MakerGen.cs:382
        // 18. ConceptMap.group
        public partial class Type_Group : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 23. ConceptMap.group.element
            public partial class Type_Element : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 26. ConceptMap.group.element.target
                public partial class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 31. ConceptMap.group.element.target.dependsOn
                    public partial class Type_DependsOn : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:381
                    {                                                                                                                       // MakerGen.cs:382
                        // 32. ConceptMap.group.element.target.dependsOn.property
                        public ElementDefinitionInfo Element_Property;                                                                      // MakerGen.cs:217
                        // 33. ConceptMap.group.element.target.dependsOn.system
                        public ElementDefinitionInfo Element_System;                                                                        // MakerGen.cs:217
                        // 34. ConceptMap.group.element.target.dependsOn.value
                        public ElementDefinitionInfo Element_Value;                                                                         // MakerGen.cs:217
                        // 35. ConceptMap.group.element.target.dependsOn.display
                        public ElementDefinitionInfo Element_Display;                                                                       // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:389
                            base.Write(sDef);                                                                                               // MakerGen.cs:390
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:391
                            {                                                                                                               // MakerGen.cs:392
                                Path = "ConceptMap.group.element.target.dependsOn",                                                         // MakerGen.cs:393
                                ElementId = "ConceptMap.group.element.target.dependsOn"                                                     // MakerGen.cs:394
                            });                                                                                                             // MakerGen.cs:395
                            Element_Property.Write(sDef);                                                                                   // MakerGen.cs:221
                            Element_System.Write(sDef);                                                                                     // MakerGen.cs:221
                            Element_Value.Write(sDef);                                                                                      // MakerGen.cs:221
                            Element_Display.Write(sDef);                                                                                    // MakerGen.cs:221
                        }                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                        public Type_DependsOn()                                                                                             // MakerGen.cs:400
                        {                                                                                                                   // MakerGen.cs:401
                            {                                                                                                               // MakerGen.cs:232
                                // 32. ConceptMap.group.element.target.dependsOn.property
                                this.Element_Property = new ElementDefinitionInfo                                                           // MakerGen.cs:234
                                {                                                                                                           // MakerGen.cs:235
                                    Name = "Element_Property",                                                                              // MakerGen.cs:236
                                    Path= "ConceptMap.group.element.target.dependsOn.property",                                             // MakerGen.cs:237
                                    Id = "ConceptMap.group.element.target.dependsOn.property",                                              // MakerGen.cs:238
                                    Min = 1,                                                                                                // MakerGen.cs:239
                                    Max = 1,                                                                                                // MakerGen.cs:240
                                    Types = new BaseType[]                                                                                  // MakerGen.cs:241
                                    {                                                                                                       // MakerGen.cs:242
                                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                   // MakerGen.cs:301
                                        {                                                                                                   // MakerGen.cs:302
                                        }                                                                                                   // MakerGen.cs:305
                                    }                                                                                                       // MakerGen.cs:244
                                };                                                                                                          // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:246
                            {                                                                                                               // MakerGen.cs:232
                                // 33. ConceptMap.group.element.target.dependsOn.system
                                this.Element_System = new ElementDefinitionInfo                                                             // MakerGen.cs:234
                                {                                                                                                           // MakerGen.cs:235
                                    Name = "Element_System",                                                                                // MakerGen.cs:236
                                    Path= "ConceptMap.group.element.target.dependsOn.system",                                               // MakerGen.cs:237
                                    Id = "ConceptMap.group.element.target.dependsOn.system",                                                // MakerGen.cs:238
                                    Min = 0,                                                                                                // MakerGen.cs:239
                                    Max = 1,                                                                                                // MakerGen.cs:240
                                    Types = new BaseType[]                                                                                  // MakerGen.cs:241
                                    {                                                                                                       // MakerGen.cs:242
                                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                             // MakerGen.cs:301
                                        {                                                                                                   // MakerGen.cs:302
                                            TargetProfile = new String[]                                                                    // MakerGen.cs:304
                                            {                                                                                               // CodeEditorExtensions.cs:28
                                                "http://hl7.org/fhir/StructureDefinition/CodeSystem"                                        // MakerGen.cs:304
                                            }                                                                                               // CodeEditorExtensions.cs:34
                                        }                                                                                                   // MakerGen.cs:305
                                    }                                                                                                       // MakerGen.cs:244
                                };                                                                                                          // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:246
                            {                                                                                                               // MakerGen.cs:232
                                // 34. ConceptMap.group.element.target.dependsOn.value
                                this.Element_Value = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                                {                                                                                                           // MakerGen.cs:235
                                    Name = "Element_Value",                                                                                 // MakerGen.cs:236
                                    Path= "ConceptMap.group.element.target.dependsOn.value",                                                // MakerGen.cs:237
                                    Id = "ConceptMap.group.element.target.dependsOn.value",                                                 // MakerGen.cs:238
                                    Min = 1,                                                                                                // MakerGen.cs:239
                                    Max = 1,                                                                                                // MakerGen.cs:240
                                    Types = new BaseType[]                                                                                  // MakerGen.cs:241
                                    {                                                                                                       // MakerGen.cs:242
                                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                // MakerGen.cs:301
                                        {                                                                                                   // MakerGen.cs:302
                                        }                                                                                                   // MakerGen.cs:305
                                    }                                                                                                       // MakerGen.cs:244
                                };                                                                                                          // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:246
                            {                                                                                                               // MakerGen.cs:232
                                // 35. ConceptMap.group.element.target.dependsOn.display
                                this.Element_Display = new ElementDefinitionInfo                                                            // MakerGen.cs:234
                                {                                                                                                           // MakerGen.cs:235
                                    Name = "Element_Display",                                                                               // MakerGen.cs:236
                                    Path= "ConceptMap.group.element.target.dependsOn.display",                                              // MakerGen.cs:237
                                    Id = "ConceptMap.group.element.target.dependsOn.display",                                               // MakerGen.cs:238
                                    Min = 0,                                                                                                // MakerGen.cs:239
                                    Max = 1,                                                                                                // MakerGen.cs:240
                                    Types = new BaseType[]                                                                                  // MakerGen.cs:241
                                    {                                                                                                       // MakerGen.cs:242
                                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                // MakerGen.cs:301
                                        {                                                                                                   // MakerGen.cs:302
                                        }                                                                                                   // MakerGen.cs:305
                                    }                                                                                                       // MakerGen.cs:244
                                };                                                                                                          // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:246
                        }                                                                                                                   // MakerGen.cs:403
                    }                                                                                                                       // MakerGen.cs:405
                    // 27. ConceptMap.group.element.target.code
                    public ElementDefinitionInfo Element_Code;                                                                              // MakerGen.cs:217
                    // 28. ConceptMap.group.element.target.display
                    public ElementDefinitionInfo Element_Display;                                                                           // MakerGen.cs:217
                    // 29. ConceptMap.group.element.target.equivalence
                    public ElementDefinitionInfo Element_Equivalence;                                                                       // MakerGen.cs:217
                    // 30. ConceptMap.group.element.target.comment
                    public ElementDefinitionInfo Element_Comment;                                                                           // MakerGen.cs:217
                    // 31. ConceptMap.group.element.target.dependsOn
                    public ElementDefinitionInfo Element_DependsOn;                                                                         // MakerGen.cs:217
                    // 36. ConceptMap.group.element.target.product
                    public ElementDefinitionInfo Element_Product;                                                                           // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:388
                    {                                                                                                                       // MakerGen.cs:389
                        base.Write(sDef);                                                                                                   // MakerGen.cs:390
                        sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                  // MakerGen.cs:391
                        {                                                                                                                   // MakerGen.cs:392
                            Path = "ConceptMap.group.element.target",                                                                       // MakerGen.cs:393
                            ElementId = "ConceptMap.group.element.target"                                                                   // MakerGen.cs:394
                        });                                                                                                                 // MakerGen.cs:395
                        Element_Code.Write(sDef);                                                                                           // MakerGen.cs:221
                        Element_Display.Write(sDef);                                                                                        // MakerGen.cs:221
                        Element_Equivalence.Write(sDef);                                                                                    // MakerGen.cs:221
                        Element_Comment.Write(sDef);                                                                                        // MakerGen.cs:221
                        Element_DependsOn.Write(sDef);                                                                                      // MakerGen.cs:221
                        Element_Product.Write(sDef);                                                                                        // MakerGen.cs:221
                    }                                                                                                                       // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                    public Type_Target()                                                                                                    // MakerGen.cs:400
                    {                                                                                                                       // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:232
                            // 27. ConceptMap.group.element.target.code
                            this.Element_Code = new ElementDefinitionInfo                                                                   // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Code",                                                                                      // MakerGen.cs:236
                                Path= "ConceptMap.group.element.target.code",                                                               // MakerGen.cs:237
                                Id = "ConceptMap.group.element.target.code",                                                                // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                      // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 28. ConceptMap.group.element.target.display
                            this.Element_Display = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Display",                                                                                   // MakerGen.cs:236
                                Path= "ConceptMap.group.element.target.display",                                                            // MakerGen.cs:237
                                Id = "ConceptMap.group.element.target.display",                                                             // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 29. ConceptMap.group.element.target.equivalence
                            this.Element_Equivalence = new ElementDefinitionInfo                                                            // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Equivalence",                                                                               // MakerGen.cs:236
                                Path= "ConceptMap.group.element.target.equivalence",                                                        // MakerGen.cs:237
                                Id = "ConceptMap.group.element.target.equivalence",                                                         // MakerGen.cs:238
                                Min = 1,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                      // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 30. ConceptMap.group.element.target.comment
                            this.Element_Comment = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Comment",                                                                                   // MakerGen.cs:236
                                Path= "ConceptMap.group.element.target.comment",                                                            // MakerGen.cs:237
                                Id = "ConceptMap.group.element.target.comment",                                                             // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = 1,                                                                                                    // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new FhirKhit.Maker.Common.Primitive.Primitive_String                                                    // MakerGen.cs:301
                                    {                                                                                                       // MakerGen.cs:302
                                    }                                                                                                       // MakerGen.cs:305
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 31. ConceptMap.group.element.target.dependsOn
                            this.Element_DependsOn = new ElementDefinitionInfo                                                              // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_DependsOn",                                                                                 // MakerGen.cs:236
                                Path= "ConceptMap.group.element.target.dependsOn",                                                          // MakerGen.cs:237
                                Id = "ConceptMap.group.element.target.dependsOn",                                                           // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = -1,                                                                                                   // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                    new Type_DependsOn                                                                                      // MakerGen.cs:260
                                    {                                                                                                       // MakerGen.cs:261
                                    }                                                                                                       // MakerGen.cs:262
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                        {                                                                                                                   // MakerGen.cs:232
                            // 36. ConceptMap.group.element.target.product
                            this.Element_Product = new ElementDefinitionInfo                                                                // MakerGen.cs:234
                            {                                                                                                               // MakerGen.cs:235
                                Name = "Element_Product",                                                                                   // MakerGen.cs:236
                                Path= "ConceptMap.group.element.target.product",                                                            // MakerGen.cs:237
                                Id = "ConceptMap.group.element.target.product",                                                             // MakerGen.cs:238
                                Min = 0,                                                                                                    // MakerGen.cs:239
                                Max = -1,                                                                                                   // MakerGen.cs:240
                                Types = new BaseType[]                                                                                      // MakerGen.cs:241
                                {                                                                                                           // MakerGen.cs:242
                                }                                                                                                           // MakerGen.cs:244
                            };                                                                                                              // MakerGen.cs:245
                        }                                                                                                                   // MakerGen.cs:246
                    }                                                                                                                       // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:405
                // 24. ConceptMap.group.element.code
                public ElementDefinitionInfo Element_Code;                                                                                  // MakerGen.cs:217
                // 25. ConceptMap.group.element.display
                public ElementDefinitionInfo Element_Display;                                                                               // MakerGen.cs:217
                // 26. ConceptMap.group.element.target
                public ElementDefinitionInfo Element_Target;                                                                                // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "ConceptMap.group.element",                                                                                  // MakerGen.cs:393
                        ElementId = "ConceptMap.group.element"                                                                              // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Code.Write(sDef);                                                                                               // MakerGen.cs:221
                    Element_Display.Write(sDef);                                                                                            // MakerGen.cs:221
                    Element_Target.Write(sDef);                                                                                             // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_Element()                                                                                                       // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 24. ConceptMap.group.element.code
                        this.Element_Code = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Code",                                                                                          // MakerGen.cs:236
                            Path= "ConceptMap.group.element.code",                                                                          // MakerGen.cs:237
                            Id = "ConceptMap.group.element.code",                                                                           // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 25. ConceptMap.group.element.display
                        this.Element_Display = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Display",                                                                                       // MakerGen.cs:236
                            Path= "ConceptMap.group.element.display",                                                                       // MakerGen.cs:237
                            Id = "ConceptMap.group.element.display",                                                                        // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 26. ConceptMap.group.element.target
                        this.Element_Target = new ElementDefinitionInfo                                                                     // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Target",                                                                                        // MakerGen.cs:236
                            Path= "ConceptMap.group.element.target",                                                                        // MakerGen.cs:237
                            Id = "ConceptMap.group.element.target",                                                                         // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = -1,                                                                                                       // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new Type_Target                                                                                             // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:262
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 37. ConceptMap.group.unmapped
            public partial class Type_Unmapped : FhirKhit.Maker.Common.Complex.ComplexBase                                                  // MakerGen.cs:381
            {                                                                                                                               // MakerGen.cs:382
                // 38. ConceptMap.group.unmapped.mode
                public ElementDefinitionInfo Element_Mode;                                                                                  // MakerGen.cs:217
                // 39. ConceptMap.group.unmapped.code
                public ElementDefinitionInfo Element_Code;                                                                                  // MakerGen.cs:217
                // 40. ConceptMap.group.unmapped.display
                public ElementDefinitionInfo Element_Display;                                                                               // MakerGen.cs:217
                // 41. ConceptMap.group.unmapped.url
                public ElementDefinitionInfo Element_Url;                                                                                   // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:389
                    base.Write(sDef);                                                                                                       // MakerGen.cs:390
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:391
                    {                                                                                                                       // MakerGen.cs:392
                        Path = "ConceptMap.group.unmapped",                                                                                 // MakerGen.cs:393
                        ElementId = "ConceptMap.group.unmapped"                                                                             // MakerGen.cs:394
                    });                                                                                                                     // MakerGen.cs:395
                    Element_Mode.Write(sDef);                                                                                               // MakerGen.cs:221
                    Element_Code.Write(sDef);                                                                                               // MakerGen.cs:221
                    Element_Display.Write(sDef);                                                                                            // MakerGen.cs:221
                    Element_Url.Write(sDef);                                                                                                // MakerGen.cs:221
                }                                                                                                                           // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
                public Type_Unmapped()                                                                                                      // MakerGen.cs:400
                {                                                                                                                           // MakerGen.cs:401
                    {                                                                                                                       // MakerGen.cs:232
                        // 38. ConceptMap.group.unmapped.mode
                        this.Element_Mode = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Mode",                                                                                          // MakerGen.cs:236
                            Path= "ConceptMap.group.unmapped.mode",                                                                         // MakerGen.cs:237
                            Id = "ConceptMap.group.unmapped.mode",                                                                          // MakerGen.cs:238
                            Min = 1,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 39. ConceptMap.group.unmapped.code
                        this.Element_Code = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Code",                                                                                          // MakerGen.cs:236
                            Path= "ConceptMap.group.unmapped.code",                                                                         // MakerGen.cs:237
                            Id = "ConceptMap.group.unmapped.code",                                                                          // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                          // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 40. ConceptMap.group.unmapped.display
                        this.Element_Display = new ElementDefinitionInfo                                                                    // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Display",                                                                                       // MakerGen.cs:236
                            Path= "ConceptMap.group.unmapped.display",                                                                      // MakerGen.cs:237
                            Id = "ConceptMap.group.unmapped.display",                                                                       // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_String                                                        // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                    {                                                                                                                       // MakerGen.cs:232
                        // 41. ConceptMap.group.unmapped.url
                        this.Element_Url = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                        {                                                                                                                   // MakerGen.cs:235
                            Name = "Element_Url",                                                                                           // MakerGen.cs:236
                            Path= "ConceptMap.group.unmapped.url",                                                                          // MakerGen.cs:237
                            Id = "ConceptMap.group.unmapped.url",                                                                           // MakerGen.cs:238
                            Min = 0,                                                                                                        // MakerGen.cs:239
                            Max = 1,                                                                                                        // MakerGen.cs:240
                            Types = new BaseType[]                                                                                          // MakerGen.cs:241
                            {                                                                                                               // MakerGen.cs:242
                                new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                     // MakerGen.cs:301
                                {                                                                                                           // MakerGen.cs:302
                                    TargetProfile = new String[]                                                                            // MakerGen.cs:304
                                    {                                                                                                       // CodeEditorExtensions.cs:28
                                        "http://hl7.org/fhir/StructureDefinition/ConceptMap"                                                // MakerGen.cs:304
                                    }                                                                                                       // CodeEditorExtensions.cs:34
                                }                                                                                                           // MakerGen.cs:305
                            }                                                                                                               // MakerGen.cs:244
                        };                                                                                                                  // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:246
                }                                                                                                                           // MakerGen.cs:403
            }                                                                                                                               // MakerGen.cs:405
            // 19. ConceptMap.group.source
            public ElementDefinitionInfo Element_Source;                                                                                    // MakerGen.cs:217
            // 20. ConceptMap.group.sourceVersion
            public ElementDefinitionInfo Element_SourceVersion;                                                                             // MakerGen.cs:217
            // 21. ConceptMap.group.target
            public ElementDefinitionInfo Element_Target;                                                                                    // MakerGen.cs:217
            // 22. ConceptMap.group.targetVersion
            public ElementDefinitionInfo Element_TargetVersion;                                                                             // MakerGen.cs:217
            // 23. ConceptMap.group.element
            public ElementDefinitionInfo Element_Element;                                                                                   // MakerGen.cs:217
            // 37. ConceptMap.group.unmapped
            public ElementDefinitionInfo Element_Unmapped;                                                                                  // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:388
            {                                                                                                                               // MakerGen.cs:389
                base.Write(sDef);                                                                                                           // MakerGen.cs:390
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:391
                {                                                                                                                           // MakerGen.cs:392
                    Path = "ConceptMap.group",                                                                                              // MakerGen.cs:393
                    ElementId = "ConceptMap.group"                                                                                          // MakerGen.cs:394
                });                                                                                                                         // MakerGen.cs:395
                Element_Source.Write(sDef);                                                                                                 // MakerGen.cs:221
                Element_SourceVersion.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_Target.Write(sDef);                                                                                                 // MakerGen.cs:221
                Element_TargetVersion.Write(sDef);                                                                                          // MakerGen.cs:221
                Element_Element.Write(sDef);                                                                                                // MakerGen.cs:221
                Element_Unmapped.Write(sDef);                                                                                               // MakerGen.cs:221
            }                                                                                                                               // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
            public Type_Group()                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:232
                    // 19. ConceptMap.group.source
                    this.Element_Source = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Source",                                                                                            // MakerGen.cs:236
                        Path= "ConceptMap.group.source",                                                                                    // MakerGen.cs:237
                        Id = "ConceptMap.group.source",                                                                                     // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                               // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 20. ConceptMap.group.sourceVersion
                    this.Element_SourceVersion = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_SourceVersion",                                                                                     // MakerGen.cs:236
                        Path= "ConceptMap.group.sourceVersion",                                                                             // MakerGen.cs:237
                        Id = "ConceptMap.group.sourceVersion",                                                                              // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 21. ConceptMap.group.target
                    this.Element_Target = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Target",                                                                                            // MakerGen.cs:236
                        Path= "ConceptMap.group.target",                                                                                    // MakerGen.cs:237
                        Id = "ConceptMap.group.target",                                                                                     // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                               // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 22. ConceptMap.group.targetVersion
                    this.Element_TargetVersion = new ElementDefinitionInfo                                                                  // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_TargetVersion",                                                                                     // MakerGen.cs:236
                        Path= "ConceptMap.group.targetVersion",                                                                             // MakerGen.cs:237
                        Id = "ConceptMap.group.targetVersion",                                                                              // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:301
                            {                                                                                                               // MakerGen.cs:302
                            }                                                                                                               // MakerGen.cs:305
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 23. ConceptMap.group.element
                    this.Element_Element = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Element",                                                                                           // MakerGen.cs:236
                        Path= "ConceptMap.group.element",                                                                                   // MakerGen.cs:237
                        Id = "ConceptMap.group.element",                                                                                    // MakerGen.cs:238
                        Min = 1,                                                                                                            // MakerGen.cs:239
                        Max = -1,                                                                                                           // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_Element                                                                                                // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
                {                                                                                                                           // MakerGen.cs:232
                    // 37. ConceptMap.group.unmapped
                    this.Element_Unmapped = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                    {                                                                                                                       // MakerGen.cs:235
                        Name = "Element_Unmapped",                                                                                          // MakerGen.cs:236
                        Path= "ConceptMap.group.unmapped",                                                                                  // MakerGen.cs:237
                        Id = "ConceptMap.group.unmapped",                                                                                   // MakerGen.cs:238
                        Min = 0,                                                                                                            // MakerGen.cs:239
                        Max = 1,                                                                                                            // MakerGen.cs:240
                        Types = new BaseType[]                                                                                              // MakerGen.cs:241
                        {                                                                                                                   // MakerGen.cs:242
                            new Type_Unmapped                                                                                               // MakerGen.cs:260
                            {                                                                                                               // MakerGen.cs:261
                            }                                                                                                               // MakerGen.cs:262
                        }                                                                                                                   // MakerGen.cs:244
                    };                                                                                                                      // MakerGen.cs:245
                }                                                                                                                           // MakerGen.cs:246
            }                                                                                                                               // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:405
        // 1. ConceptMap.url
        public ElementDefinitionInfo Element_Url;                                                                                           // MakerGen.cs:217
        // 2. ConceptMap.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:217
        // 3. ConceptMap.version
        public ElementDefinitionInfo Element_Version;                                                                                       // MakerGen.cs:217
        // 4. ConceptMap.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:217
        // 5. ConceptMap.title
        public ElementDefinitionInfo Element_Title;                                                                                         // MakerGen.cs:217
        // 6. ConceptMap.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:217
        // 7. ConceptMap.experimental
        public ElementDefinitionInfo Element_Experimental;                                                                                  // MakerGen.cs:217
        // 8. ConceptMap.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:217
        // 9. ConceptMap.publisher
        public ElementDefinitionInfo Element_Publisher;                                                                                     // MakerGen.cs:217
        // 10. ConceptMap.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:217
        // 11. ConceptMap.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:217
        // 12. ConceptMap.useContext
        public ElementDefinitionInfo Element_UseContext;                                                                                    // MakerGen.cs:217
        // 13. ConceptMap.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;                                                                                  // MakerGen.cs:217
        // 14. ConceptMap.purpose
        public ElementDefinitionInfo Element_Purpose;                                                                                       // MakerGen.cs:217
        // 15. ConceptMap.copyright
        public ElementDefinitionInfo Element_Copyright;                                                                                     // MakerGen.cs:217
        // 16. ConceptMap.source[x]
        public ElementDefinitionInfo Element_Source;                                                                                        // MakerGen.cs:217
        // 17. ConceptMap.target[x]
        public ElementDefinitionInfo Element_Target;                                                                                        // MakerGen.cs:217
        // 18. ConceptMap.group
        public ElementDefinitionInfo Element_Group;                                                                                         // MakerGen.cs:217
                                                                                                                                            // MakerGen.cs:387
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:388
        {                                                                                                                                   // MakerGen.cs:389
            base.Write(sDef);                                                                                                               // MakerGen.cs:390
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:391
            {                                                                                                                               // MakerGen.cs:392
                Path = "ConceptMap",                                                                                                        // MakerGen.cs:393
                ElementId = "ConceptMap"                                                                                                    // MakerGen.cs:394
            });                                                                                                                             // MakerGen.cs:395
            Element_Url.Write(sDef);                                                                                                        // MakerGen.cs:221
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Version.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Title.Write(sDef);                                                                                                      // MakerGen.cs:221
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Experimental.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_Date.Write(sDef);                                                                                                       // MakerGen.cs:221
            Element_Publisher.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Contact.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Description.Write(sDef);                                                                                                // MakerGen.cs:221
            Element_UseContext.Write(sDef);                                                                                                 // MakerGen.cs:221
            Element_Jurisdiction.Write(sDef);                                                                                               // MakerGen.cs:221
            Element_Purpose.Write(sDef);                                                                                                    // MakerGen.cs:221
            Element_Copyright.Write(sDef);                                                                                                  // MakerGen.cs:221
            Element_Source.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Target.Write(sDef);                                                                                                     // MakerGen.cs:221
            Element_Group.Write(sDef);                                                                                                      // MakerGen.cs:221
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:399
        public Resource_ConceptMap()                                                                                                        // MakerGen.cs:400
        {                                                                                                                                   // MakerGen.cs:401
            {                                                                                                                               // MakerGen.cs:232
                // 1. ConceptMap.url
                this.Element_Url = new ElementDefinitionInfo                                                                                // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:236
                    Path= "ConceptMap.url",                                                                                                 // MakerGen.cs:237
                    Id = "ConceptMap.url",                                                                                                  // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 2. ConceptMap.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:236
                    Path= "ConceptMap.identifier",                                                                                          // MakerGen.cs:237
                    Id = "ConceptMap.identifier",                                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 3. ConceptMap.version
                this.Element_Version = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Version",                                                                                               // MakerGen.cs:236
                    Path= "ConceptMap.version",                                                                                             // MakerGen.cs:237
                    Id = "ConceptMap.version",                                                                                              // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 4. ConceptMap.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:236
                    Path= "ConceptMap.name",                                                                                                // MakerGen.cs:237
                    Id = "ConceptMap.name",                                                                                                 // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 5. ConceptMap.title
                this.Element_Title = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Title",                                                                                                 // MakerGen.cs:236
                    Path= "ConceptMap.title",                                                                                               // MakerGen.cs:237
                    Id = "ConceptMap.title",                                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 6. ConceptMap.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Status",                                                                                                // MakerGen.cs:236
                    Path= "ConceptMap.status",                                                                                              // MakerGen.cs:237
                    Id = "ConceptMap.status",                                                                                               // MakerGen.cs:238
                    Min = 1,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 7. ConceptMap.experimental
                this.Element_Experimental = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Experimental",                                                                                          // MakerGen.cs:236
                    Path= "ConceptMap.experimental",                                                                                        // MakerGen.cs:237
                    Id = "ConceptMap.experimental",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Boolean                                                               // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 8. ConceptMap.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:236
                    Path= "ConceptMap.date",                                                                                                // MakerGen.cs:237
                    Id = "ConceptMap.date",                                                                                                 // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 9. ConceptMap.publisher
                this.Element_Publisher = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:236
                    Path= "ConceptMap.publisher",                                                                                           // MakerGen.cs:237
                    Id = "ConceptMap.publisher",                                                                                            // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 10. ConceptMap.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:236
                    Path= "ConceptMap.contact",                                                                                             // MakerGen.cs:237
                    Id = "ConceptMap.contact",                                                                                              // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 11. ConceptMap.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Description",                                                                                           // MakerGen.cs:236
                    Path= "ConceptMap.description",                                                                                         // MakerGen.cs:237
                    Id = "ConceptMap.description",                                                                                          // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 12. ConceptMap.useContext
                this.Element_UseContext = new ElementDefinitionInfo                                                                         // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:236
                    Path= "ConceptMap.useContext",                                                                                          // MakerGen.cs:237
                    Id = "ConceptMap.useContext",                                                                                           // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_UsageContext                                                                 // MakerGen.cs:356
                        {                                                                                                                   // MakerGen.cs:357
                        }                                                                                                                   // MakerGen.cs:358
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 13. ConceptMap.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo                                                                       // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:236
                    Path= "ConceptMap.jurisdiction",                                                                                        // MakerGen.cs:237
                    Id = "ConceptMap.jurisdiction",                                                                                         // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:316
                        {                                                                                                                   // MakerGen.cs:317
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 14. ConceptMap.purpose
                this.Element_Purpose = new ElementDefinitionInfo                                                                            // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Purpose",                                                                                               // MakerGen.cs:236
                    Path= "ConceptMap.purpose",                                                                                             // MakerGen.cs:237
                    Id = "ConceptMap.purpose",                                                                                              // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 15. ConceptMap.copyright
                this.Element_Copyright = new ElementDefinitionInfo                                                                          // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Copyright",                                                                                             // MakerGen.cs:236
                    Path= "ConceptMap.copyright",                                                                                           // MakerGen.cs:237
                    Id = "ConceptMap.copyright",                                                                                            // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 16. ConceptMap.source[x]
                this.Element_Source = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Source",                                                                                                // MakerGen.cs:236
                    Path= "ConceptMap.source[x]",                                                                                           // MakerGen.cs:237
                    Id = "ConceptMap.source[x]",                                                                                            // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:304
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                          // MakerGen.cs:304
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 17. ConceptMap.target[x]
                this.Element_Target = new ElementDefinitionInfo                                                                             // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Target",                                                                                                // MakerGen.cs:236
                    Path= "ConceptMap.target[x]",                                                                                           // MakerGen.cs:237
                    Id = "ConceptMap.target[x]",                                                                                            // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = 1,                                                                                                                // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                        },                                                                                                                  // MakerGen.cs:305
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical                                                             // MakerGen.cs:301
                        {                                                                                                                   // MakerGen.cs:302
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:304
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/ValueSet"                                                          // MakerGen.cs:304
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:305
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            {                                                                                                                               // MakerGen.cs:232
                // 18. ConceptMap.group
                this.Element_Group = new ElementDefinitionInfo                                                                              // MakerGen.cs:234
                {                                                                                                                           // MakerGen.cs:235
                    Name = "Element_Group",                                                                                                 // MakerGen.cs:236
                    Path= "ConceptMap.group",                                                                                               // MakerGen.cs:237
                    Id = "ConceptMap.group",                                                                                                // MakerGen.cs:238
                    Min = 0,                                                                                                                // MakerGen.cs:239
                    Max = -1,                                                                                                               // MakerGen.cs:240
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:242
                        new Type_Group                                                                                                      // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:262
                    }                                                                                                                       // MakerGen.cs:244
                };                                                                                                                          // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:246
            this.Name = "ConceptMap";                                                                                                       // MakerGen.cs:468
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ConceptMap";                                                                // MakerGen.cs:469
        }                                                                                                                                   // MakerGen.cs:403
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:449
