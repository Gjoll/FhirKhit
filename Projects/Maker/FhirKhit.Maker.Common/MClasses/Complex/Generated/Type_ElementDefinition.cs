using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Hl7.Fhir.Model;

namespace FhirKhit.Maker.Common.Complex
{
    #region Json
    #if NEVER
    {
      "resourceType": "StructureDefinition",
      "id": "ElementDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/ElementDefinition",
      "version": "4.0.0",
      "name": "ElementDefinition",
      "status": "active",
      "publisher": "HL7 FHIR Standard",
      "description": "Base StructureDefinition for ElementDefinition Type: Captures constraints on each element within the resource, profile, or extension.",
      "fhirVersion": "4.0.0",
      "kind": "complex-type",
      "abstract": false,
      "type": "ElementDefinition",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/BackboneElement",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "ElementDefinition",
            "path": "ElementDefinition",
            "short": "Definition of an element in a resource or extension",
            "definition": "Captures constraints on each element within the resource, profile, or extension.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ElementDefinition.path",
            "path": "ElementDefinition.path",
            "short": "Path of the element in the hierarchy of elements",
            "definition": "The path identifies the element and is expressed as a \".\"-separated list of ancestor elements, beginning with the name of the resource or extension.",
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
            "id": "ElementDefinition.representation",
            "path": "ElementDefinition.representation",
            "short": "xmlAttr | xmlText | typeAttr | cdaText | xhtml",
            "definition": "Codes that define how this element is represented in instances, when the deviation varies from the normal case.",
            "comment": "In resources, this is rarely used except for special cases where the representation deviates from the normal, and can only be done in the base standard (and profiles must reproduce what the base standard does). This element is used quite commonly in Logical models when the logical models represent a specific serialization format (e.g. CDA, v2 etc.).",
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
                  "valueString": "PropertyRepresentation"
                }
              ],
              "strength": "required",
              "description": "How a property is represented when serialized.",
              "valueSet": "http://hl7.org/fhir/ValueSet/property-representation|4.0.0"
            }
          },
          {
            "id": "ElementDefinition.sliceName",
            "path": "ElementDefinition.sliceName",
            "short": "Name for this particular element (in a set of slices)",
            "definition": "The name of this element definition slice, when slicing is working. The name must be a token with no dots or spaces. This is a unique name referring to a specific set of constraints applied to this element, used to provide a name to different slices of the same element.",
            "comment": "The name SHALL be unique within the structure within the context of the constrained resource element.  (Though to avoid confusion, uniqueness across all elements is recommended.).",
            "requirements": "May also be used for code generation purposes.",
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
            "id": "ElementDefinition.sliceIsConstraining",
            "path": "ElementDefinition.sliceIsConstraining",
            "short": "If this slice definition constrains an inherited slice definition (or not)",
            "definition": "If true, indicates that this slice definition is constraining a slice definition with the same name in an inherited profile. If false, the slice is not overriding any slice in an inherited profile. If missing, the slice might or might not be overriding a slice in an inherited profile, depending on the sliceName.",
            "comment": "If set to true, an ancestor profile SHALL have a slicing definition with this name.  If set to false, no ancestor profile is permitted to have a slicing definition with this name.",
            "requirements": "Allows detection of a situation where an ancestor profile adds or removes slicing with the same name where that might impact the child profile.",
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
            "id": "ElementDefinition.label",
            "path": "ElementDefinition.label",
            "short": "Name for element to display with or prompt for element",
            "definition": "A single preferred label which is the text to display beside the element indicating its meaning or to use to prompt for the element in a user display or form.",
            "comment": "See also the extension (http://hl7.org/fhir/StructureDefinition/elementdefinition-question)[extension-elementdefinition-question.html].",
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
            "id": "ElementDefinition.code",
            "path": "ElementDefinition.code",
            "short": "Corresponding codes in terminologies",
            "definition": "A code that has the same meaning as the element in a particular terminology.",
            "comment": "The concept SHALL be properly aligned with the data element definition and other constraints, as defined in the code system, including relationships, of any code listed here.  Where multiple codes exist in a terminology that could correspond to the data element, the most granular code(s) should be selected, so long as they are not more restrictive than the data element itself. The mappings may be used to provide more or less granular or structured equivalences in the code system.",
            "requirements": "Links the meaning of an element to an external terminology, and is very useful for searching and indexing.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ElementDefinitionCode"
                }
              ],
              "strength": "example",
              "description": "Codes that indicate the meaning of a data element.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-codes"
            }
          },
          {
            "id": "ElementDefinition.slicing",
            "path": "ElementDefinition.slicing",
            "short": "This element is sliced - slices follow",
            "definition": "Indicates that the element is sliced into a set of alternative definitions (i.e. in a structure definition, there are multiple different constraints on a single element in the base resource). Slicing can be used in any resource that has cardinality ..* on the base resource, or any resource with a choice of types. The set of slices is any elements that come after this in the element sequence that have the same path, until a shorter path occurs (the shorter path terminates the set).",
            "comment": "The first element in the sequence, the one that carries the slicing, is the definition that applies to all the slices. This is based on the unconstrained element, but can apply any constraints as appropriate. This may include the common constraints on the children of the element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Element"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.slicing.discriminator",
            "path": "ElementDefinition.slicing.discriminator",
            "short": "Element values that are used to distinguish the slices",
            "definition": "Designates which child elements are used to discriminate between the slices when processing an instance. If one or more discriminators are provided, the value of the child elements in the instance data SHALL completely distinguish which slice the element in the resource matches based on the allowed values for those elements in each of the slices.",
            "comment": "If there is no discriminator, the content is hard to process, so this should be avoided.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Element"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.slicing.discriminator.type",
            "path": "ElementDefinition.slicing.discriminator.type",
            "short": "value | exists | pattern | type | profile",
            "definition": "How the element value is interpreted when discrimination is evaluated.",
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
                  "valueString": "DiscriminatorType"
                }
              ],
              "strength": "required",
              "description": "How an element value is interpreted when discrimination is evaluated.",
              "valueSet": "http://hl7.org/fhir/ValueSet/discriminator-type|4.0.0"
            }
          },
          {
            "id": "ElementDefinition.slicing.discriminator.path",
            "path": "ElementDefinition.slicing.discriminator.path",
            "short": "Path to element value",
            "definition": "A FHIRPath expression, using [the simple subset of FHIRPath](fhirpath.html#simple), that is used to identify the element on which discrimination is based.",
            "comment": "The only FHIRPath functions that are allowed are as(type), resolve(), and extension(url).",
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
            "id": "ElementDefinition.slicing.description",
            "path": "ElementDefinition.slicing.description",
            "short": "Text description of how slicing works (or not)",
            "definition": "A human-readable text description of how the slicing works. If there is no discriminator, this is required to be present to provide whatever information is possible about how the slices can be differentiated.",
            "comment": "If it's really not possible to differentiate them, the design should be re-evaluated to make the content usable.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "eld-1"
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.slicing.ordered",
            "path": "ElementDefinition.slicing.ordered",
            "short": "If elements must be in same order as slices",
            "definition": "If the matching elements have to occur in the same order as defined in the profile.",
            "comment": "Order should only be required when it is a pressing concern for presentation. Profile authors should consider making the order a feature of the rules about the narrative, not the rules about the data - requiring ordered data makes the profile much less re-usable.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "Order is not required unless specified",
            "isSummary": true
          },
          {
            "id": "ElementDefinition.slicing.rules",
            "path": "ElementDefinition.slicing.rules",
            "short": "closed | open | openAtEnd",
            "definition": "Whether additional slices are allowed or not. When the slices are ordered, profile authors can also say that additional slices are only allowed at the end.",
            "comment": "Allowing additional elements makes for a much for flexible template - it's open for use in wider contexts, but also means that the content of the resource is not closed, and applications have to decide how to handle content not described by the profile.",
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
                  "valueString": "SlicingRules"
                }
              ],
              "strength": "required",
              "description": "How slices are interpreted when evaluating an instance.",
              "valueSet": "http://hl7.org/fhir/ValueSet/resource-slicing-rules|4.0.0"
            }
          },
          {
            "id": "ElementDefinition.short",
            "path": "ElementDefinition.short",
            "short": "Concise definition for space-constrained presentation",
            "definition": "A concise description of what this element means (e.g. for use in autogenerated summaries).",
            "comment": "It is easy for a different short definition to change the meaning of an element and this can have nasty downstream consequences. Please be careful when providing short definitions in a profile.",
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
            "id": "ElementDefinition.definition",
            "path": "ElementDefinition.definition",
            "short": "Full formal definition as narrative text",
            "definition": "Provides a complete explanation of the meaning of the data element for human readability.  For the case of elements derived from existing elements (e.g. constraints), the definition SHALL be consistent with the base definition, but convey the meaning of the element in the particular context of use of the resource. (Note: The text you are reading is specified in ElementDefinition.definition).",
            "comment": "It is easy for a different definition to change the meaning of an element and this can have nasty downstream consequences. Please be careful when providing definitions in a profile.",
            "requirements": "To allow a user to state the usage of an element in a particular context.",
            "alias": [
              "Description"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.comment",
            "path": "ElementDefinition.comment",
            "short": "Comments about the use of this element",
            "definition": "Explanatory notes and implementation guidance about the data element, including notes about how to use the data properly, exceptions to proper use, etc. (Note: The text you are reading is specified in ElementDefinition.comment).",
            "comment": "If it is possible to capture usage rules using constraints, that mechanism should be used in preference to this element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.requirements",
            "path": "ElementDefinition.requirements",
            "short": "Why this resource has been created",
            "definition": "This element is for traceability of why the element was created and why the constraints exist as they do. This may be used to point to source materials or specifications that drove the structure of this element.",
            "comment": "This element does not describe the usage of the element (that's done in comments), rather it's for traceability of *why* the element is either needed or why the constraints exist as they do.  This may be used to point to source materials or specifications that drove the structure of this data element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.alias",
            "path": "ElementDefinition.alias",
            "short": "Other names",
            "definition": "Identifies additional names by which this element might also be known.",
            "requirements": "Allows for better easier recognition of the element by multiple communities, including international communities.",
            "alias": [
              "synonym",
              "other name"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.min",
            "path": "ElementDefinition.min",
            "short": "Minimum Cardinality",
            "definition": "The minimum number of times this element SHALL appear in the instance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ],
            "condition": [
              "eld-2"
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.max",
            "path": "ElementDefinition.max",
            "short": "Maximum Cardinality (a number or *)",
            "definition": "The maximum number of times this element is permitted to appear in the instance.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "condition": [
              "eld-3",
              "eld-2"
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.base",
            "path": "ElementDefinition.base",
            "short": "Base definition information for tools",
            "definition": "Information about the base definition of the element, provided to make it unnecessary for tools to trace the deviation of the element through the derived and related profiles. When the element definition is not the original definition of an element - i.g. either in a constraint on another type, or for elements from a super type in a snap shot - then the information in provided in the element definition may be different to the base definition. On the original definition of the element, it will be same.",
            "comment": "The base information does not carry any information that could not be determined from the path and related profiles, but making this determination requires both that the related profiles are available, and that the algorithm to determine them be available. For tooling simplicity, the base information must always be populated in element definitions in snap shots, even if it is the same.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Element"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.base.path",
            "path": "ElementDefinition.base.path",
            "short": "Path that identifies the base element",
            "definition": "The Path that identifies the base element - this matches the ElementDefinition.path for that element. Across FHIR, there is only one base definition of any element - that is, an element definition on a [StructureDefinition](structuredefinition.html#) without a StructureDefinition.base.",
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
            "id": "ElementDefinition.base.min",
            "path": "ElementDefinition.base.min",
            "short": "Min cardinality of the base element",
            "definition": "Minimum cardinality of the base element identified by the path.",
            "comment": "This is provided for consistency with max, and may affect code generation of mandatory elements of the base resource are generated differently (some reference implementations have done this).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "unsignedInt"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.base.max",
            "path": "ElementDefinition.base.max",
            "short": "Max cardinality of the base element",
            "definition": "Maximum cardinality of the base element identified by the path.",
            "comment": "This is provided to code generation, since the serialization representation in JSON differs depending on whether the base element has max > 1. Also, some forms of code generation may differ.",
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
            "id": "ElementDefinition.contentReference",
            "path": "ElementDefinition.contentReference",
            "short": "Reference to definition of content for the element",
            "definition": "Identifies an element defined elsewhere in the definition whose content rules should be applied to the current element. ContentReferences bring across all the rules that are in the ElementDefinition for the element, including definitions, cardinality constraints, bindings, invariants etc.",
            "comment": "ContentReferences can only be defined in specializations, not constrained types, and they cannot be changed and always reference the non-constrained definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "condition": [
              "eld-5"
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.type",
            "path": "ElementDefinition.type",
            "short": "Data type and Profile for this element",
            "definition": "The data type or resource that the value of this element is permitted to be.",
            "comment": "The Type of the element can be left blank in a differential constraint, in which case the type is inherited from the resource. Abstract types are not permitted to appear as a type when multiple types are listed.  (I.e. Abstract types cannot be part of a choice).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Element"
              }
            ],
            "condition": [
              "eld-13"
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.type.code",
            "path": "ElementDefinition.type.code",
            "short": "Data type or Resource (reference to definition)",
            "definition": "URL of Data type or Resource that is a(or the) type used for this element. References are URLs that are relative to http://hl7.org/fhir/StructureDefinition e.g. \"string\" is a reference to http://hl7.org/fhir/StructureDefinition/string. Absolute URLs are only allowed in logical models.",
            "comment": "If the element is a reference to another resource, this element contains \"Reference\", and the targetProfile element defines what resources can be referenced. The targetProfile may be a reference to the general definition of a resource (e.g. http://hl7.org/fhir/StructureDefinition/Patient).",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "FHIRDefinedTypeExt"
                }
              ],
              "strength": "extensible",
              "description": "Either a resource or a data type, including logical model types.",
              "valueSet": "http://hl7.org/fhir/ValueSet/defined-types"
            }
          },
          {
            "id": "ElementDefinition.type.profile",
            "path": "ElementDefinition.type.profile",
            "short": "Profiles (StructureDefinition or IG) - one must apply",
            "definition": "Identifies a profile structure or implementation Guide that applies to the datatype this element refers to. If any profiles are specified, then the content must conform to at least one of them. The URL can be a local reference - to a contained StructureDefinition, or a reference to another StructureDefinition or Implementation Guide by a canonical URL. When an implementation guide is specified, the type SHALL conform to at least one profile defined in the implementation guide.",
            "comment": "It is possible to profile  backbone element (e.g. part of a resource), using the [profile-element](extension-elementdefinition-profile-element.html) extension.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureDefinition",
                  "http://hl7.org/fhir/StructureDefinition/ImplementationGuide"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.type.targetProfile",
            "path": "ElementDefinition.type.targetProfile",
            "short": "Profile (StructureDefinition or IG) on the Reference/canonical target - one must apply",
            "definition": "Used when the type is \"Reference\" or \"canonical\", and identifies a profile structure or implementation Guide that applies to the target of the reference this element refers to. If any profiles are specified, then the content must conform to at least one of them. The URL can be a local reference - to a contained StructureDefinition, or a reference to another StructureDefinition or Implementation Guide by a canonical URL. When an implementation guide is specified, the target resource SHALL conform to at least one profile defined in the implementation guide.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureDefinition",
                  "http://hl7.org/fhir/StructureDefinition/ImplementationGuide"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.type.aggregation",
            "path": "ElementDefinition.type.aggregation",
            "short": "contained | referenced | bundled - how aggregated",
            "definition": "If the type is a reference to another resource, how the resource is or can be aggregated - is it a contained resource, or a reference, and if the context is a bundle, is it included in the bundle.",
            "comment": "See [Aggregation Rules](elementdefinition.html#aggregation) for further clarification.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "code"
              }
            ],
            "condition": [
              "eld-4"
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "AggregationMode"
                }
              ],
              "strength": "required",
              "description": "How resource references can be aggregated.",
              "valueSet": "http://hl7.org/fhir/ValueSet/resource-aggregation-mode|4.0.0"
            }
          },
          {
            "id": "ElementDefinition.type.versioning",
            "path": "ElementDefinition.type.versioning",
            "short": "either | independent | specific",
            "definition": "Whether this reference needs to be version specific or version independent, or whether either can be used.",
            "comment": "The base specification never makes a rule as to which form is allowed, but implementation guides may do this. See [Aggregation Rules](elementdefinition.html#aggregation) for further clarification.",
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
                  "valueString": "ReferenceVersionRules"
                }
              ],
              "strength": "required",
              "description": "Whether a reference needs to be version specific or version independent, or whether either can be used.",
              "valueSet": "http://hl7.org/fhir/ValueSet/reference-version-rules|4.0.0"
            }
          },
          {
            "id": "ElementDefinition.defaultValue[x]",
            "path": "ElementDefinition.defaultValue[x]",
            "short": "Specified value if missing from instance",
            "definition": "The value that should be used if there is no value stated in the instance (e.g. 'if not otherwise specified, the abstract is false').",
            "comment": "Specifying a default value means that the property can never been unknown - it must always have a value. Further, the default value can never be changed, or changed in constraints on content models. Defining default values creates many difficulties in implementation (e.g. when is a value missing?). For these reasons, default values are (and should be) used extremely sparingly. \n\nNo default values are ever defined in the FHIR specification, nor can they be defined in constraints (\"profiles\") on data types or resources. This element only exists so that default values may be defined in logical models.",
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
            "condition": [
              "eld-15"
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.meaningWhenMissing",
            "path": "ElementDefinition.meaningWhenMissing",
            "short": "Implicit meaning when this element is missing",
            "definition": "The Implicit meaning that is to be understood when this element is missing (e.g. 'when this element is missing, the period is ongoing').",
            "comment": "Implicit meanings for missing values can only be specified on a resource, data type, or extension definition, and never in a profile that applies to one of these. An implicit meaning for a missing value can never be changed, and specifying one has the consequence that constraining its use in profiles eliminates use cases as possibilities, not merely moving them out of scope.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ],
            "condition": [
              "eld-15"
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.orderMeaning",
            "path": "ElementDefinition.orderMeaning",
            "short": "What the order of the elements means",
            "definition": "If present, indicates that the order of the repeating element has meaning and describes what that meaning is.  If absent, it means that the order of the element has no meaning.",
            "comment": "This element can only be asserted on repeating elements and can only be introduced when defining resources or data types.  It can be further refined profiled elements but if absent in the base type, a profile cannot assert meaning.",
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
            "id": "ElementDefinition.fixed[x]",
            "path": "ElementDefinition.fixed[x]",
            "short": "Value must be exactly this",
            "definition": "Specifies a value that SHALL be exactly the value  for this element in the instance. For purposes of comparison, non-significant whitespace is ignored, and all values must be an exact match (case and accent sensitive). Missing elements/attributes must also be missing.",
            "comment": "This is not recommended for Coding and CodeableConcept since these often have highly contextual properties such as version or display.",
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
            "condition": [
              "eld-5",
              "eld-6",
              "eld-8"
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.pattern[x]",
            "path": "ElementDefinition.pattern[x]",
            "short": "Value must have at least these property values",
            "definition": "Specifies a value that the value in the instance SHALL follow - that is, any value in the pattern must be found in the instance. Other additional values may be found too. This is effectively constraint by example.  \n\nWhen pattern[x] is used to constrain a primitive, it means that the value provided in the pattern[x] must match the instance value exactly.\n\nWhen pattern[x] is used to constrain an array, it means that each element provided in the pattern[x] array must (recursively) match at least one element from the instance array.\n\nWhen pattern[x] is used to constrain a complex object, it means that each property in the pattern must be present in the complex object, and its value must recursively match -- i.e.,\n\n1. If primitive: it must match exactly the pattern value\n2. If a complex object: it must match (recursively) the pattern value\n3. If an array: it must match (recursively) the pattern value.",
            "comment": "Mostly used for fixing values of CodeableConcept. In general, pattern[x] is not intended for use with primitive types, where is has the same meaning as fixed[x].",
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
            "condition": [
              "eld-5",
              "eld-7",
              "eld-8"
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.example",
            "path": "ElementDefinition.example",
            "short": "Example value (as defined for type)",
            "definition": "A sample value for this element demonstrating the type of information that would typically be found in the element.",
            "comment": "Examples will most commonly be present for data where it's not implicitly obvious from either the data type or value set what the values might be.  (I.e. Example values for dates or quantities would generally be unnecessary.)  If the example value is fully populated, the publication tool can generate an instance automatically.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Element"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.example.label",
            "path": "ElementDefinition.example.label",
            "short": "Describes the purpose of this example",
            "definition": "Describes the purpose of this example amoung the set of examples.",
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
            "id": "ElementDefinition.example.value[x]",
            "path": "ElementDefinition.example.value[x]",
            "short": "Value of Example (one of allowed types)",
            "definition": "The actual value for the element, which must be one of the types allowed for this element.",
            "min": 1,
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
            "id": "ElementDefinition.minValue[x]",
            "path": "ElementDefinition.minValue[x]",
            "short": "Minimum Allowed Value (for some types)",
            "definition": "The minimum allowed value for the element. The value is inclusive. This is allowed for the types date, dateTime, instant, time, decimal, integer, and Quantity.",
            "comment": "Except for date/date/instant, the type of the minValue[x] SHALL be the same as the specified type of the element. For the date/dateTime/instant values, the type of minValue[x] SHALL be either the same, or a [Duration](datatypes.html#Duration) which specifies a relative time limit to the current time. The duration value is positive, and is subtracted from the current clock to determine the minimum allowable value.   A minimum value for a Quantity is interpreted as an canonical minimum - e.g. you cannot provide 100mg if the minimum value is 10g.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "instant"
              },
              {
                "code": "time"
              },
              {
                "code": "decimal"
              },
              {
                "code": "integer"
              },
              {
                "code": "positiveInt"
              },
              {
                "code": "unsignedInt"
              },
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.maxValue[x]",
            "path": "ElementDefinition.maxValue[x]",
            "short": "Maximum Allowed Value (for some types)",
            "definition": "The maximum allowed value for the element. The value is inclusive. This is allowed for the types date, dateTime, instant, time, decimal, integer, and Quantity.",
            "comment": "Except for date/date/instant, the type of the maxValue[x] SHALL be the same as the specified type of the element. For the date/dateTime/instant values, the type of maxValue[x] SHALL be either the same, or a [Duration](datatypes.html#Duration) which specifies a relative time limit to the current time. The duration value is positive, and is added to the current clock to determine the maximum allowable value.   A maximum value for a Quantity is interpreted as an canonical maximum - e.g. you cannot provide 10g if the maximum value is 50mg.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "instant"
              },
              {
                "code": "time"
              },
              {
                "code": "decimal"
              },
              {
                "code": "integer"
              },
              {
                "code": "positiveInt"
              },
              {
                "code": "unsignedInt"
              },
              {
                "code": "Quantity"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.maxLength",
            "path": "ElementDefinition.maxLength",
            "short": "Max length for strings",
            "definition": "Indicates the maximum length in characters that is permitted to be present in conformant instances and which is expected to be supported by conformant consumers that support the element.",
            "comment": "Receivers are not required to reject instances that exceed the maximum length.  The full length could be stored.  In some cases, data might be truncated, though truncation should be undertaken with care and an understanding of the consequences of doing so. If not specified, there is no conformance expectation for length support.",
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
            "id": "ElementDefinition.condition",
            "path": "ElementDefinition.condition",
            "short": "Reference to invariant about presence",
            "definition": "A reference to an invariant that may make additional statements about the cardinality or value in the instance.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "id"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.constraint",
            "path": "ElementDefinition.constraint",
            "short": "Condition that must evaluate to true",
            "definition": "Formal constraints such as co-occurrence and other constraints that can be computationally evaluated within the context of the instance.",
            "comment": "Constraints should be declared on the \"context\" element - the lowest element in the hierarchy that is common to all nodes referenced by the constraint.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Element"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.constraint.key",
            "path": "ElementDefinition.constraint.key",
            "short": "Target of 'condition' reference above",
            "definition": "Allows identification of which elements have their cardinalities impacted by the constraint.  Will not be referenced for constraints that do not affect cardinality.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ],
            "condition": [
              "eld-14"
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.constraint.requirements",
            "path": "ElementDefinition.constraint.requirements",
            "short": "Why this constraint is necessary or appropriate",
            "definition": "Description of why this constraint is necessary or appropriate.",
            "comment": "To be used if the reason for the constraint might not be intuitive to all implementers.",
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
            "id": "ElementDefinition.constraint.severity",
            "path": "ElementDefinition.constraint.severity",
            "short": "error | warning",
            "definition": "Identifies the impact constraint violation has on the conformance of the instance.",
            "comment": "This allows constraints to be asserted as \"shall\" (error) and \"should\" (warning).",
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
                  "valueString": "ConstraintSeverity"
                }
              ],
              "strength": "required",
              "description": "SHALL applications comply with this constraint?",
              "valueSet": "http://hl7.org/fhir/ValueSet/constraint-severity|4.0.0"
            }
          },
          {
            "id": "ElementDefinition.constraint.human",
            "path": "ElementDefinition.constraint.human",
            "short": "Human description of constraint",
            "definition": "Text that can be used to describe the constraint in messages identifying that the constraint has been violated.",
            "comment": "Should be expressed in business terms as much as possible.",
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
            "id": "ElementDefinition.constraint.expression",
            "path": "ElementDefinition.constraint.expression",
            "short": "FHIRPath expression of constraint",
            "definition": "A [FHIRPath](fhirpath.html) expression of constraint that can be executed to see if this constraint is met.",
            "comment": "In the absense of an expression, the expression is likely not enforceable by validators, and might be missed by many systems.",
            "requirements": "Used by validation tooling tests of the validity of the resource.",
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
            "id": "ElementDefinition.constraint.xpath",
            "path": "ElementDefinition.constraint.xpath",
            "short": "XPath expression of constraint",
            "definition": "An XPath expression of constraint that can be executed to see if this constraint is met.",
            "comment": "Elements SHALL use \"f\" as the namespace prefix for the FHIR namespace, and \"x\" for the xhtml namespace, and SHALL NOT use any other prefixes.     Note: XPath is generally considered not useful because it does not apply to JSON and other formats and because of XSLT implementation issues, and may be removed in the future.",
            "requirements": "Used in Schematron tests of the validity of the resource.",
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
            "id": "ElementDefinition.constraint.source",
            "path": "ElementDefinition.constraint.source",
            "short": "Reference to original source of constraint",
            "definition": "A reference to the original source of the constraint, for traceability purposes.",
            "comment": "This is used when, e.g. rendering, where it is not useful to present inherited constraints when rendering the snapshot.",
            "min": 0,
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
            "id": "ElementDefinition.mustSupport",
            "path": "ElementDefinition.mustSupport",
            "short": "If the element must be supported",
            "definition": "If true, implementations that produce or consume resources SHALL provide \"support\" for the element in some meaningful way.  If false, the element may be ignored and not supported. If false, whether to populate or use the data element in any way is at the discretion of the implementation.",
            "comment": "\"Something useful\" is context dependent and impossible to describe in the base FHIR specification. For this reason, tue mustSupport flag is never set to true by the FHIR specification itself - it is only set to true in profiles.  A profile on a type can always make musSupport = true if it is false in the base type but cannot make mustSupport = false if it is true in the base type.   This is done in [Resource Profiles](profiling.html#mustsupport), where the profile labels an element as mustSupport=true. When a profile does this, it SHALL also make clear exactly what kind of \"support\" is required, as this can mean many things.    Note that an element that has the property IsModifier is not necessarily a \"key\" element (e.g. one of the important elements to make use of the resource), nor is it automatically mustSupport - however both of these things are more likely to be true for IsModifier elements than for other elements.",
            "requirements": "Allows a profile to set expectations for system capabilities beyond merely respecting cardinality constraints.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "In a base type, where the element is being defined for the first time, the element is assumed to be mustSupport = false. In a profile (a constraint on an existing type), if mustSupport is not specific in either the differentil or the snapshot, the mustSupport value is not changed fro the base definition. Not, though, that the snapshot SHOULD always populate the mustSuppot value",
            "isSummary": true
          },
          {
            "id": "ElementDefinition.isModifier",
            "path": "ElementDefinition.isModifier",
            "short": "If this modifies the meaning of other elements",
            "definition": "If true, the value of this element affects the interpretation of the element or resource that contains it, and the value of the element cannot be ignored. Typically, this is used for status, negation and qualification codes. The effect of this is that the element cannot be ignored by systems: they SHALL either recognize the element and process it, and/or a pre-determination has been made that it is not relevant to their particular system.",
            "comment": "Only the definition of an element can set IsModifier true - either the specification itself or where an extension is originally defined. Once set, it cannot be changed in derived profiles. An element/extension that has isModifier=true SHOULD also have a minimum cardinality of 1, so that there is no lack of clarity about what to do if it is missing. If it can be missing, the definition SHALL make the meaning of a missing element clear.",
            "requirements": "Allows elements to be introduced into a specification that can't safely be ignored by applications that don't recognize them.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "An element is not a modifier element unless it is explicitly specified to be one",
            "isSummary": true
          },
          {
            "id": "ElementDefinition.isModifierReason",
            "path": "ElementDefinition.isModifierReason",
            "short": "Reason that this element is marked as a modifier",
            "definition": "Explains how that element affects the interpretation of the resource or element that contains it.",
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
            "id": "ElementDefinition.isSummary",
            "path": "ElementDefinition.isSummary",
            "short": "Include when _summary = true?",
            "definition": "Whether the element should be included if a client requests a search with the parameter _summary=true.",
            "comment": "Some resources include a set of simple metadata, and some very large data. This element is used to reduce the quantity of data returned in searches. Note that servers may pre-cache summarized resources for optimal performance, so servers might not support per-profile use of the isSummary flag. When a request is made with _summary=true, serailisers only include elements marked as 'isSummary = true'. Other than Attachment.data, all data type properties are included in the summary form. In resource and data type definitions, if an element is at the root or has a parent that is 'mustSupport' and the minimum cardinality is 1 or the element is a modifier, it must be marked as isSummary=true.",
            "requirements": "Allow clients to search through large resources quickly.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "An element is not included in the summary unless it is explicitly specified to be so",
            "isSummary": true
          },
          {
            "id": "ElementDefinition.binding",
            "path": "ElementDefinition.binding",
            "short": "ValueSet details if this is coded",
            "definition": "Binds to a value set if this element is coded (code, Coding, CodeableConcept, Quantity), or the data types (string, uri).",
            "comment": "For a CodeableConcept, when no codes are allowed - only text, use a binding of strength \"required\" with a description explaining that no coded values are allowed and what sort of information to put in the \"text\" element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Element"
              }
            ],
            "condition": [
              "eld-11"
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.binding.strength",
            "path": "ElementDefinition.binding.strength",
            "short": "required | extensible | preferred | example",
            "definition": "Indicates the degree of conformance expectations associated with this binding - that is, the degree to which the provided value set must be adhered to in the instances.",
            "comment": "For further discussion, see [Using Terminologies](terminologies.html).",
            "alias": [
              "conformance",
              "extensibility"
            ],
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
                  "valueString": "BindingStrength"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "Indication of the degree of conformance expectations associated with a binding.",
              "valueSet": "http://hl7.org/fhir/ValueSet/binding-strength|4.0.0"
            }
          },
          {
            "id": "ElementDefinition.binding.description",
            "path": "ElementDefinition.binding.description",
            "short": "Human explanation of the value set",
            "definition": "Describes the intended use of this particular set of codes.",
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
            "id": "ElementDefinition.binding.valueSet",
            "path": "ElementDefinition.binding.valueSet",
            "short": "Source of value set",
            "definition": "Refers to the value set that identifies the set of codes the binding refers to.",
            "comment": "The reference may be version-specific or not (e.g. have a |[version] at the end of the canonical URL).",
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
            "condition": [
              "eld-12"
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.mapping",
            "path": "ElementDefinition.mapping",
            "short": "Map element to another set of definitions",
            "definition": "Identifies a concept from an external specification that roughly corresponds to this element.",
            "comment": "Mappings are not necessarily specific enough for safe translation.",
            "requirements": "Provides guidance to implementers familiar with or converting content from other specifications.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Element"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ElementDefinition.mapping.identity",
            "path": "ElementDefinition.mapping.identity",
            "short": "Reference to mapping declaration",
            "definition": "An internal reference to the definition of a mapping.",
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
            "id": "ElementDefinition.mapping.language",
            "path": "ElementDefinition.mapping.language",
            "short": "Computable language of mapping",
            "definition": "Identifies the computable language in which mapping.map is expressed.",
            "comment": "If omitted, then there can be no expectation of computational interpretation of the mapping.",
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
                  "valueString": "MimeType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "The mime type of an attachment. Any valid mime type is allowed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/mimetypes|4.0.0"
            }
          },
          {
            "id": "ElementDefinition.mapping.map",
            "path": "ElementDefinition.mapping.map",
            "short": "Details of the mapping",
            "definition": "Expresses what part of the target specification corresponds to this element.",
            "comment": "For most mappings, the syntax is undefined.  Syntax will be provided for mappings to the RIM.  Multiple mappings may be possible and may include constraints on other resource elements that identify when a particular mapping applies.",
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
            "id": "ElementDefinition.mapping.comment",
            "path": "ElementDefinition.mapping.comment",
            "short": "Comments about the mapping or its use",
            "definition": "Comments that provide information about the mapping or its use.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir complex 'ElementDefinition'
    /// </summary>
    // 0. ElementDefinition
    public partial class Type_ElementDefinition : FhirKhit.Maker.Common.Complex.ComplexBase
    {
        // 7. ElementDefinition.slicing
        public partial class Type_Slicing : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 8. ElementDefinition.slicing.discriminator
            public partial class Type_Discriminator : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 9. ElementDefinition.slicing.discriminator.type
                public ElementDefinitionInfo Element_Type;
                // 10. ElementDefinition.slicing.discriminator.path
                public ElementDefinitionInfo Element_Path;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "ElementDefinition.slicing.discriminator",
                        ElementId = "ElementDefinition.slicing.discriminator"
                    });
                    Element_Type.Write(sDef);
                    Element_Path.Write(sDef);
                }
                
                public Type_Discriminator()
                {
                    {
                        // 9. ElementDefinition.slicing.discriminator.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "ElementDefinition.slicing.discriminator.type",
                            Id = "ElementDefinition.slicing.discriminator.type",
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
                        // 10. ElementDefinition.slicing.discriminator.path
                        this.Element_Path = new ElementDefinitionInfo
                        {
                            Name = "Element_Path",
                            Path= "ElementDefinition.slicing.discriminator.path",
                            Id = "ElementDefinition.slicing.discriminator.path",
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
            // 8. ElementDefinition.slicing.discriminator
            public ElementDefinitionInfo Element_Discriminator;
            // 11. ElementDefinition.slicing.description
            public ElementDefinitionInfo Element_Description;
            // 12. ElementDefinition.slicing.ordered
            public ElementDefinitionInfo Element_Ordered;
            // 13. ElementDefinition.slicing.rules
            public ElementDefinitionInfo Element_Rules;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ElementDefinition.slicing",
                    ElementId = "ElementDefinition.slicing"
                });
                Element_Discriminator.Write(sDef);
                Element_Description.Write(sDef);
                Element_Ordered.Write(sDef);
                Element_Rules.Write(sDef);
            }
            
            public Type_Slicing()
            {
                {
                    // 8. ElementDefinition.slicing.discriminator
                    this.Element_Discriminator = new ElementDefinitionInfo
                    {
                        Name = "Element_Discriminator",
                        Path= "ElementDefinition.slicing.discriminator",
                        Id = "ElementDefinition.slicing.discriminator",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Discriminator
                            {
                            }
                        }
                    };
                }
                {
                    // 11. ElementDefinition.slicing.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "ElementDefinition.slicing.description",
                        Id = "ElementDefinition.slicing.description",
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
                    // 12. ElementDefinition.slicing.ordered
                    this.Element_Ordered = new ElementDefinitionInfo
                    {
                        Name = "Element_Ordered",
                        Path= "ElementDefinition.slicing.ordered",
                        Id = "ElementDefinition.slicing.ordered",
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
                    // 13. ElementDefinition.slicing.rules
                    this.Element_Rules = new ElementDefinitionInfo
                    {
                        Name = "Element_Rules",
                        Path= "ElementDefinition.slicing.rules",
                        Id = "ElementDefinition.slicing.rules",
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
        // 21. ElementDefinition.base
        public partial class Type_Base : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 22. ElementDefinition.base.path
            public ElementDefinitionInfo Element_Path;
            // 23. ElementDefinition.base.min
            public ElementDefinitionInfo Element_Min;
            // 24. ElementDefinition.base.max
            public ElementDefinitionInfo Element_Max;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ElementDefinition.base",
                    ElementId = "ElementDefinition.base"
                });
                Element_Path.Write(sDef);
                Element_Min.Write(sDef);
                Element_Max.Write(sDef);
            }
            
            public Type_Base()
            {
                {
                    // 22. ElementDefinition.base.path
                    this.Element_Path = new ElementDefinitionInfo
                    {
                        Name = "Element_Path",
                        Path= "ElementDefinition.base.path",
                        Id = "ElementDefinition.base.path",
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
                    // 23. ElementDefinition.base.min
                    this.Element_Min = new ElementDefinitionInfo
                    {
                        Name = "Element_Min",
                        Path= "ElementDefinition.base.min",
                        Id = "ElementDefinition.base.min",
                        Min = 1,
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
                    // 24. ElementDefinition.base.max
                    this.Element_Max = new ElementDefinitionInfo
                    {
                        Name = "Element_Max",
                        Path= "ElementDefinition.base.max",
                        Id = "ElementDefinition.base.max",
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
        // 26. ElementDefinition.type
        public partial class Type_Type : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 27. ElementDefinition.type.code
            public ElementDefinitionInfo Element_Code;
            // 28. ElementDefinition.type.profile
            public ElementDefinitionInfo Element_Profile;
            // 29. ElementDefinition.type.targetProfile
            public ElementDefinitionInfo Element_TargetProfile;
            // 30. ElementDefinition.type.aggregation
            public ElementDefinitionInfo Element_Aggregation;
            // 31. ElementDefinition.type.versioning
            public ElementDefinitionInfo Element_Versioning;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ElementDefinition.type",
                    ElementId = "ElementDefinition.type"
                });
                Element_Code.Write(sDef);
                Element_Profile.Write(sDef);
                Element_TargetProfile.Write(sDef);
                Element_Aggregation.Write(sDef);
                Element_Versioning.Write(sDef);
            }
            
            public Type_Type()
            {
                {
                    // 27. ElementDefinition.type.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "ElementDefinition.type.code",
                        Id = "ElementDefinition.type.code",
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
                    // 28. ElementDefinition.type.profile
                    this.Element_Profile = new ElementDefinitionInfo
                    {
                        Name = "Element_Profile",
                        Path= "ElementDefinition.type.profile",
                        Id = "ElementDefinition.type.profile",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/StructureDefinition",
                                    "http://hl7.org/fhir/StructureDefinition/ImplementationGuide"
                                }
                            }
                        }
                    };
                }
                {
                    // 29. ElementDefinition.type.targetProfile
                    this.Element_TargetProfile = new ElementDefinitionInfo
                    {
                        Name = "Element_TargetProfile",
                        Path= "ElementDefinition.type.targetProfile",
                        Id = "ElementDefinition.type.targetProfile",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/StructureDefinition",
                                    "http://hl7.org/fhir/StructureDefinition/ImplementationGuide"
                                }
                            }
                        }
                    };
                }
                {
                    // 30. ElementDefinition.type.aggregation
                    this.Element_Aggregation = new ElementDefinitionInfo
                    {
                        Name = "Element_Aggregation",
                        Path= "ElementDefinition.type.aggregation",
                        Id = "ElementDefinition.type.aggregation",
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
                    // 31. ElementDefinition.type.versioning
                    this.Element_Versioning = new ElementDefinitionInfo
                    {
                        Name = "Element_Versioning",
                        Path= "ElementDefinition.type.versioning",
                        Id = "ElementDefinition.type.versioning",
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
            }
        }
        // 37. ElementDefinition.example
        public partial class Type_Example : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 38. ElementDefinition.example.label
            public ElementDefinitionInfo Element_Label;
            // 39. ElementDefinition.example.value[x]
            public ElementDefinitionInfo Element_Value;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ElementDefinition.example",
                    ElementId = "ElementDefinition.example"
                });
                Element_Label.Write(sDef);
                Element_Value.Write(sDef);
            }
            
            public Type_Example()
            {
                {
                    // 38. ElementDefinition.example.label
                    this.Element_Label = new ElementDefinitionInfo
                    {
                        Name = "Element_Label",
                        Path= "ElementDefinition.example.label",
                        Id = "ElementDefinition.example.label",
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
                    // 39. ElementDefinition.example.value[x]
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "ElementDefinition.example.value[x]",
                        Id = "ElementDefinition.example.value[x]",
                        Min = 1,
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
            }
        }
        // 44. ElementDefinition.constraint
        public partial class Type_Constraint : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 45. ElementDefinition.constraint.key
            public ElementDefinitionInfo Element_Key;
            // 46. ElementDefinition.constraint.requirements
            public ElementDefinitionInfo Element_Requirements;
            // 47. ElementDefinition.constraint.severity
            public ElementDefinitionInfo Element_Severity;
            // 48. ElementDefinition.constraint.human
            public ElementDefinitionInfo Element_Human;
            // 49. ElementDefinition.constraint.expression
            public ElementDefinitionInfo Element_Expression;
            // 50. ElementDefinition.constraint.xpath
            public ElementDefinitionInfo Element_Xpath;
            // 51. ElementDefinition.constraint.source
            public ElementDefinitionInfo Element_Source;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ElementDefinition.constraint",
                    ElementId = "ElementDefinition.constraint"
                });
                Element_Key.Write(sDef);
                Element_Requirements.Write(sDef);
                Element_Severity.Write(sDef);
                Element_Human.Write(sDef);
                Element_Expression.Write(sDef);
                Element_Xpath.Write(sDef);
                Element_Source.Write(sDef);
            }
            
            public Type_Constraint()
            {
                {
                    // 45. ElementDefinition.constraint.key
                    this.Element_Key = new ElementDefinitionInfo
                    {
                        Name = "Element_Key",
                        Path= "ElementDefinition.constraint.key",
                        Id = "ElementDefinition.constraint.key",
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
                    // 46. ElementDefinition.constraint.requirements
                    this.Element_Requirements = new ElementDefinitionInfo
                    {
                        Name = "Element_Requirements",
                        Path= "ElementDefinition.constraint.requirements",
                        Id = "ElementDefinition.constraint.requirements",
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
                    // 47. ElementDefinition.constraint.severity
                    this.Element_Severity = new ElementDefinitionInfo
                    {
                        Name = "Element_Severity",
                        Path= "ElementDefinition.constraint.severity",
                        Id = "ElementDefinition.constraint.severity",
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
                    // 48. ElementDefinition.constraint.human
                    this.Element_Human = new ElementDefinitionInfo
                    {
                        Name = "Element_Human",
                        Path= "ElementDefinition.constraint.human",
                        Id = "ElementDefinition.constraint.human",
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
                    // 49. ElementDefinition.constraint.expression
                    this.Element_Expression = new ElementDefinitionInfo
                    {
                        Name = "Element_Expression",
                        Path= "ElementDefinition.constraint.expression",
                        Id = "ElementDefinition.constraint.expression",
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
                    // 50. ElementDefinition.constraint.xpath
                    this.Element_Xpath = new ElementDefinitionInfo
                    {
                        Name = "Element_Xpath",
                        Path= "ElementDefinition.constraint.xpath",
                        Id = "ElementDefinition.constraint.xpath",
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
                    // 51. ElementDefinition.constraint.source
                    this.Element_Source = new ElementDefinitionInfo
                    {
                        Name = "Element_Source",
                        Path= "ElementDefinition.constraint.source",
                        Id = "ElementDefinition.constraint.source",
                        Min = 0,
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
        // 56. ElementDefinition.binding
        public partial class Type_Binding : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 57. ElementDefinition.binding.strength
            public ElementDefinitionInfo Element_Strength;
            // 58. ElementDefinition.binding.description
            public ElementDefinitionInfo Element_Description;
            // 59. ElementDefinition.binding.valueSet
            public ElementDefinitionInfo Element_ValueSet;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ElementDefinition.binding",
                    ElementId = "ElementDefinition.binding"
                });
                Element_Strength.Write(sDef);
                Element_Description.Write(sDef);
                Element_ValueSet.Write(sDef);
            }
            
            public Type_Binding()
            {
                {
                    // 57. ElementDefinition.binding.strength
                    this.Element_Strength = new ElementDefinitionInfo
                    {
                        Name = "Element_Strength",
                        Path= "ElementDefinition.binding.strength",
                        Id = "ElementDefinition.binding.strength",
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
                    // 58. ElementDefinition.binding.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "ElementDefinition.binding.description",
                        Id = "ElementDefinition.binding.description",
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
                    // 59. ElementDefinition.binding.valueSet
                    this.Element_ValueSet = new ElementDefinitionInfo
                    {
                        Name = "Element_ValueSet",
                        Path= "ElementDefinition.binding.valueSet",
                        Id = "ElementDefinition.binding.valueSet",
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
            }
        }
        // 60. ElementDefinition.mapping
        public partial class Type_Mapping : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 61. ElementDefinition.mapping.identity
            public ElementDefinitionInfo Element_Identity;
            // 62. ElementDefinition.mapping.language
            public ElementDefinitionInfo Element_Language;
            // 63. ElementDefinition.mapping.map
            public ElementDefinitionInfo Element_Map;
            // 64. ElementDefinition.mapping.comment
            public ElementDefinitionInfo Element_Comment;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ElementDefinition.mapping",
                    ElementId = "ElementDefinition.mapping"
                });
                Element_Identity.Write(sDef);
                Element_Language.Write(sDef);
                Element_Map.Write(sDef);
                Element_Comment.Write(sDef);
            }
            
            public Type_Mapping()
            {
                {
                    // 61. ElementDefinition.mapping.identity
                    this.Element_Identity = new ElementDefinitionInfo
                    {
                        Name = "Element_Identity",
                        Path= "ElementDefinition.mapping.identity",
                        Id = "ElementDefinition.mapping.identity",
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
                    // 62. ElementDefinition.mapping.language
                    this.Element_Language = new ElementDefinitionInfo
                    {
                        Name = "Element_Language",
                        Path= "ElementDefinition.mapping.language",
                        Id = "ElementDefinition.mapping.language",
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
                    // 63. ElementDefinition.mapping.map
                    this.Element_Map = new ElementDefinitionInfo
                    {
                        Name = "Element_Map",
                        Path= "ElementDefinition.mapping.map",
                        Id = "ElementDefinition.mapping.map",
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
                    // 64. ElementDefinition.mapping.comment
                    this.Element_Comment = new ElementDefinitionInfo
                    {
                        Name = "Element_Comment",
                        Path= "ElementDefinition.mapping.comment",
                        Id = "ElementDefinition.mapping.comment",
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
        // 1. ElementDefinition.path
        public ElementDefinitionInfo Element_Path;
        // 2. ElementDefinition.representation
        public ElementDefinitionInfo Element_Representation;
        // 3. ElementDefinition.sliceName
        public ElementDefinitionInfo Element_SliceName;
        // 4. ElementDefinition.sliceIsConstraining
        public ElementDefinitionInfo Element_SliceIsConstraining;
        // 5. ElementDefinition.label
        public ElementDefinitionInfo Element_Label;
        // 6. ElementDefinition.code
        public ElementDefinitionInfo Element_Code;
        // 7. ElementDefinition.slicing
        public ElementDefinitionInfo Element_Slicing;
        // 14. ElementDefinition.short
        public ElementDefinitionInfo Element_Short;
        // 15. ElementDefinition.definition
        public ElementDefinitionInfo Element_Definition;
        // 16. ElementDefinition.comment
        public ElementDefinitionInfo Element_Comment;
        // 17. ElementDefinition.requirements
        public ElementDefinitionInfo Element_Requirements;
        // 18. ElementDefinition.alias
        public ElementDefinitionInfo Element_Alias;
        // 19. ElementDefinition.min
        public ElementDefinitionInfo Element_Min;
        // 20. ElementDefinition.max
        public ElementDefinitionInfo Element_Max;
        // 21. ElementDefinition.base
        public ElementDefinitionInfo Element_Base;
        // 25. ElementDefinition.contentReference
        public ElementDefinitionInfo Element_ContentReference;
        // 26. ElementDefinition.type
        public ElementDefinitionInfo Element_Type;
        // 32. ElementDefinition.defaultValue[x]
        public ElementDefinitionInfo Element_DefaultValue;
        // 33. ElementDefinition.meaningWhenMissing
        public ElementDefinitionInfo Element_MeaningWhenMissing;
        // 34. ElementDefinition.orderMeaning
        public ElementDefinitionInfo Element_OrderMeaning;
        // 35. ElementDefinition.fixed[x]
        public ElementDefinitionInfo Element_Fixed;
        // 36. ElementDefinition.pattern[x]
        public ElementDefinitionInfo Element_Pattern;
        // 37. ElementDefinition.example
        public ElementDefinitionInfo Element_Example;
        // 40. ElementDefinition.minValue[x]
        public ElementDefinitionInfo Element_MinValue;
        // 41. ElementDefinition.maxValue[x]
        public ElementDefinitionInfo Element_MaxValue;
        // 42. ElementDefinition.maxLength
        public ElementDefinitionInfo Element_MaxLength;
        // 43. ElementDefinition.condition
        public ElementDefinitionInfo Element_Condition;
        // 44. ElementDefinition.constraint
        public ElementDefinitionInfo Element_Constraint;
        // 52. ElementDefinition.mustSupport
        public ElementDefinitionInfo Element_MustSupport;
        // 53. ElementDefinition.isModifier
        public ElementDefinitionInfo Element_IsModifier;
        // 54. ElementDefinition.isModifierReason
        public ElementDefinitionInfo Element_IsModifierReason;
        // 55. ElementDefinition.isSummary
        public ElementDefinitionInfo Element_IsSummary;
        // 56. ElementDefinition.binding
        public ElementDefinitionInfo Element_Binding;
        // 60. ElementDefinition.mapping
        public ElementDefinitionInfo Element_Mapping;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ElementDefinition",
                ElementId = "ElementDefinition"
            });
            Element_Path.Write(sDef);
            Element_Representation.Write(sDef);
            Element_SliceName.Write(sDef);
            Element_SliceIsConstraining.Write(sDef);
            Element_Label.Write(sDef);
            Element_Code.Write(sDef);
            Element_Slicing.Write(sDef);
            Element_Short.Write(sDef);
            Element_Definition.Write(sDef);
            Element_Comment.Write(sDef);
            Element_Requirements.Write(sDef);
            Element_Alias.Write(sDef);
            Element_Min.Write(sDef);
            Element_Max.Write(sDef);
            Element_Base.Write(sDef);
            Element_ContentReference.Write(sDef);
            Element_Type.Write(sDef);
            Element_DefaultValue.Write(sDef);
            Element_MeaningWhenMissing.Write(sDef);
            Element_OrderMeaning.Write(sDef);
            Element_Fixed.Write(sDef);
            Element_Pattern.Write(sDef);
            Element_Example.Write(sDef);
            Element_MinValue.Write(sDef);
            Element_MaxValue.Write(sDef);
            Element_MaxLength.Write(sDef);
            Element_Condition.Write(sDef);
            Element_Constraint.Write(sDef);
            Element_MustSupport.Write(sDef);
            Element_IsModifier.Write(sDef);
            Element_IsModifierReason.Write(sDef);
            Element_IsSummary.Write(sDef);
            Element_Binding.Write(sDef);
            Element_Mapping.Write(sDef);
        }
        
        public Type_ElementDefinition()
        {
            {
                // 1. ElementDefinition.path
                this.Element_Path = new ElementDefinitionInfo
                {
                    Name = "Element_Path",
                    Path= "ElementDefinition.path",
                    Id = "ElementDefinition.path",
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
                // 2. ElementDefinition.representation
                this.Element_Representation = new ElementDefinitionInfo
                {
                    Name = "Element_Representation",
                    Path= "ElementDefinition.representation",
                    Id = "ElementDefinition.representation",
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
                // 3. ElementDefinition.sliceName
                this.Element_SliceName = new ElementDefinitionInfo
                {
                    Name = "Element_SliceName",
                    Path= "ElementDefinition.sliceName",
                    Id = "ElementDefinition.sliceName",
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
                // 4. ElementDefinition.sliceIsConstraining
                this.Element_SliceIsConstraining = new ElementDefinitionInfo
                {
                    Name = "Element_SliceIsConstraining",
                    Path= "ElementDefinition.sliceIsConstraining",
                    Id = "ElementDefinition.sliceIsConstraining",
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
                // 5. ElementDefinition.label
                this.Element_Label = new ElementDefinitionInfo
                {
                    Name = "Element_Label",
                    Path= "ElementDefinition.label",
                    Id = "ElementDefinition.label",
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
                // 6. ElementDefinition.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "ElementDefinition.code",
                    Id = "ElementDefinition.code",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Coding
                        {
                        }
                    }
                };
            }
            {
                // 7. ElementDefinition.slicing
                this.Element_Slicing = new ElementDefinitionInfo
                {
                    Name = "Element_Slicing",
                    Path= "ElementDefinition.slicing",
                    Id = "ElementDefinition.slicing",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Slicing
                        {
                        }
                    }
                };
            }
            {
                // 14. ElementDefinition.short
                this.Element_Short = new ElementDefinitionInfo
                {
                    Name = "Element_Short",
                    Path= "ElementDefinition.short",
                    Id = "ElementDefinition.short",
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
                // 15. ElementDefinition.definition
                this.Element_Definition = new ElementDefinitionInfo
                {
                    Name = "Element_Definition",
                    Path= "ElementDefinition.definition",
                    Id = "ElementDefinition.definition",
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
                // 16. ElementDefinition.comment
                this.Element_Comment = new ElementDefinitionInfo
                {
                    Name = "Element_Comment",
                    Path= "ElementDefinition.comment",
                    Id = "ElementDefinition.comment",
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
                // 17. ElementDefinition.requirements
                this.Element_Requirements = new ElementDefinitionInfo
                {
                    Name = "Element_Requirements",
                    Path= "ElementDefinition.requirements",
                    Id = "ElementDefinition.requirements",
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
                // 18. ElementDefinition.alias
                this.Element_Alias = new ElementDefinitionInfo
                {
                    Name = "Element_Alias",
                    Path= "ElementDefinition.alias",
                    Id = "ElementDefinition.alias",
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
                // 19. ElementDefinition.min
                this.Element_Min = new ElementDefinitionInfo
                {
                    Name = "Element_Min",
                    Path= "ElementDefinition.min",
                    Id = "ElementDefinition.min",
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
                // 20. ElementDefinition.max
                this.Element_Max = new ElementDefinitionInfo
                {
                    Name = "Element_Max",
                    Path= "ElementDefinition.max",
                    Id = "ElementDefinition.max",
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
                // 21. ElementDefinition.base
                this.Element_Base = new ElementDefinitionInfo
                {
                    Name = "Element_Base",
                    Path= "ElementDefinition.base",
                    Id = "ElementDefinition.base",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Base
                        {
                        }
                    }
                };
            }
            {
                // 25. ElementDefinition.contentReference
                this.Element_ContentReference = new ElementDefinitionInfo
                {
                    Name = "Element_ContentReference",
                    Path= "ElementDefinition.contentReference",
                    Id = "ElementDefinition.contentReference",
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
                // 26. ElementDefinition.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "ElementDefinition.type",
                    Id = "ElementDefinition.type",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Type
                        {
                        }
                    }
                };
            }
            {
                // 32. ElementDefinition.defaultValue[x]
                this.Element_DefaultValue = new ElementDefinitionInfo
                {
                    Name = "Element_DefaultValue",
                    Path= "ElementDefinition.defaultValue[x]",
                    Id = "ElementDefinition.defaultValue[x]",
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
                // 33. ElementDefinition.meaningWhenMissing
                this.Element_MeaningWhenMissing = new ElementDefinitionInfo
                {
                    Name = "Element_MeaningWhenMissing",
                    Path= "ElementDefinition.meaningWhenMissing",
                    Id = "ElementDefinition.meaningWhenMissing",
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
                // 34. ElementDefinition.orderMeaning
                this.Element_OrderMeaning = new ElementDefinitionInfo
                {
                    Name = "Element_OrderMeaning",
                    Path= "ElementDefinition.orderMeaning",
                    Id = "ElementDefinition.orderMeaning",
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
                // 35. ElementDefinition.fixed[x]
                this.Element_Fixed = new ElementDefinitionInfo
                {
                    Name = "Element_Fixed",
                    Path= "ElementDefinition.fixed[x]",
                    Id = "ElementDefinition.fixed[x]",
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
                // 36. ElementDefinition.pattern[x]
                this.Element_Pattern = new ElementDefinitionInfo
                {
                    Name = "Element_Pattern",
                    Path= "ElementDefinition.pattern[x]",
                    Id = "ElementDefinition.pattern[x]",
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
                // 37. ElementDefinition.example
                this.Element_Example = new ElementDefinitionInfo
                {
                    Name = "Element_Example",
                    Path= "ElementDefinition.example",
                    Id = "ElementDefinition.example",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Example
                        {
                        }
                    }
                };
            }
            {
                // 40. ElementDefinition.minValue[x]
                this.Element_MinValue = new ElementDefinitionInfo
                {
                    Name = "Element_MinValue",
                    Path= "ElementDefinition.minValue[x]",
                    Id = "ElementDefinition.minValue[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Time
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Quantity
                        {
                        }
                    }
                };
            }
            {
                // 41. ElementDefinition.maxValue[x]
                this.Element_MaxValue = new ElementDefinitionInfo
                {
                    Name = "Element_MaxValue",
                    Path= "ElementDefinition.maxValue[x]",
                    Id = "ElementDefinition.maxValue[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Instant
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Time
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_PositiveInt
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_UnsignedInt
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Quantity
                        {
                        }
                    }
                };
            }
            {
                // 42. ElementDefinition.maxLength
                this.Element_MaxLength = new ElementDefinitionInfo
                {
                    Name = "Element_MaxLength",
                    Path= "ElementDefinition.maxLength",
                    Id = "ElementDefinition.maxLength",
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
                // 43. ElementDefinition.condition
                this.Element_Condition = new ElementDefinitionInfo
                {
                    Name = "Element_Condition",
                    Path= "ElementDefinition.condition",
                    Id = "ElementDefinition.condition",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Id
                        {
                        }
                    }
                };
            }
            {
                // 44. ElementDefinition.constraint
                this.Element_Constraint = new ElementDefinitionInfo
                {
                    Name = "Element_Constraint",
                    Path= "ElementDefinition.constraint",
                    Id = "ElementDefinition.constraint",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Constraint
                        {
                        }
                    }
                };
            }
            {
                // 52. ElementDefinition.mustSupport
                this.Element_MustSupport = new ElementDefinitionInfo
                {
                    Name = "Element_MustSupport",
                    Path= "ElementDefinition.mustSupport",
                    Id = "ElementDefinition.mustSupport",
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
                // 53. ElementDefinition.isModifier
                this.Element_IsModifier = new ElementDefinitionInfo
                {
                    Name = "Element_IsModifier",
                    Path= "ElementDefinition.isModifier",
                    Id = "ElementDefinition.isModifier",
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
                // 54. ElementDefinition.isModifierReason
                this.Element_IsModifierReason = new ElementDefinitionInfo
                {
                    Name = "Element_IsModifierReason",
                    Path= "ElementDefinition.isModifierReason",
                    Id = "ElementDefinition.isModifierReason",
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
                // 55. ElementDefinition.isSummary
                this.Element_IsSummary = new ElementDefinitionInfo
                {
                    Name = "Element_IsSummary",
                    Path= "ElementDefinition.isSummary",
                    Id = "ElementDefinition.isSummary",
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
                // 56. ElementDefinition.binding
                this.Element_Binding = new ElementDefinitionInfo
                {
                    Name = "Element_Binding",
                    Path= "ElementDefinition.binding",
                    Id = "ElementDefinition.binding",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_Binding
                        {
                        }
                    }
                };
            }
            {
                // 60. ElementDefinition.mapping
                this.Element_Mapping = new ElementDefinitionInfo
                {
                    Name = "Element_Mapping",
                    Path= "ElementDefinition.mapping",
                    Id = "ElementDefinition.mapping",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Mapping
                        {
                        }
                    }
                };
            }
        }
    }
}
