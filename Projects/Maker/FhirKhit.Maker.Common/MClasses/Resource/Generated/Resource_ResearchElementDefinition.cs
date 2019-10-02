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
      "id": "ResearchElementDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/ResearchElementDefinition",
      "version": "4.0.0",
      "name": "ResearchElementDefinition",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Decision Support)",
      "description": "The ResearchElementDefinition resource describes a \"PICO\" element that knowledge (evidence, assertion, recommendation) is about.",
      "purpose": "Need to be able to define and reuse the definition of individual elements of a research question.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ResearchElementDefinition",
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
            "id": "ResearchElementDefinition",
            "path": "ResearchElementDefinition",
            "short": "A population, intervention, or exposure definition",
            "definition": "The ResearchElementDefinition resource describes a \"PICO\" element that knowledge (evidence, assertion, recommendation) is about.",
            "comment": "PICO stands for Population (the population within which exposures are being compared), Intervention (the conditional state or exposure state being described for its effect on outcomes), Comparison (the alternative conditional state or alternative exposure state being compared against), and Outcome (the result or effect of the intervention in the population).",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ResearchElementDefinition.url",
            "path": "ResearchElementDefinition.url",
            "short": "Canonical identifier for this research element definition, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this research element definition when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this research element definition is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the research element definition is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the research element definition to be referenced by a single globally unique identifier.",
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
            "id": "ResearchElementDefinition.identifier",
            "path": "ResearchElementDefinition.identifier",
            "short": "Additional identifier for the research element definition",
            "definition": "A formal identifier that is used to identify this research element definition when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this research element definition outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "ResearchElementDefinition.version",
            "path": "ResearchElementDefinition.version",
            "short": "Business version of the research element definition",
            "definition": "The identifier that is used to identify this version of the research element definition when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the research element definition author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence. To provide a version consistent with the Decision Support Service specification, use the format Major.Minor.Revision (e.g. 1.0.0). For more information on versioning knowledge assets, refer to the Decision Support Service specification. Note that a version is required for non-experimental active artifacts.",
            "comment": "There may be different research element definition instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the research element definition with the format [url]|[version].",
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
            "id": "ResearchElementDefinition.name",
            "path": "ResearchElementDefinition.name",
            "short": "Name for this research element definition (computer friendly)",
            "definition": "A natural language name identifying the research element definition. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "ResearchElementDefinition.title",
            "path": "ResearchElementDefinition.title",
            "short": "Name for this research element definition (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the research element definition.",
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
            "id": "ResearchElementDefinition.shortTitle",
            "path": "ResearchElementDefinition.shortTitle",
            "short": "Title for use in informal contexts",
            "definition": "The short title provides an alternate title for use in informal descriptive contexts where the full, formal title is not necessary.",
            "requirements": "Need to be able to reference the content by a short description, but still provide a longer, more formal title for the content.",
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
            "id": "ResearchElementDefinition.subtitle",
            "path": "ResearchElementDefinition.subtitle",
            "short": "Subordinate title of the ResearchElementDefinition",
            "definition": "An explanatory or alternate title for the ResearchElementDefinition giving additional information about its content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.status",
            "path": "ResearchElementDefinition.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this research element definition. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of research element definitions that are appropriate for use versus not.",
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
            "id": "ResearchElementDefinition.experimental",
            "path": "ResearchElementDefinition.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this research element definition is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of research element definitions that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level research element definition.",
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
            "id": "ResearchElementDefinition.subject[x]",
            "path": "ResearchElementDefinition.subject[x]",
            "short": "E.g. Patient, Practitioner, RelatedPerson, Organization, Location, Device",
            "definition": "The intended subjects for the ResearchElementDefinition. If this element is not provided, a Patient subject is assumed, but the subject of the ResearchElementDefinition can be anything.",
            "comment": "The subject of the ResearchElementDefinition is critical in interpreting the criteria definitions, as the logic in the ResearchElementDefinitions is evaluated with respect to a particular subject. This corresponds roughly to the notion of a Compartment in that it limits what content is available based on its relationship to the subject. In CQL, this corresponds to the context declaration.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ],
            "meaningWhenMissing": "Patient",
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "SubjectType"
                }
              ],
              "strength": "extensible",
              "description": "The possible types of subjects for a measure (E.g. Patient, Practitioner, Organization, Location, etc.).",
              "valueSet": "http://hl7.org/fhir/ValueSet/subject-type"
            }
          },
          {
            "id": "ResearchElementDefinition.date",
            "path": "ResearchElementDefinition.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the research element definition was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the research element definition changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the research element definition. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "ResearchElementDefinition.publisher",
            "path": "ResearchElementDefinition.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the research element definition.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the research element definition is the organization or individual primarily responsible for the maintenance and upkeep of the research element definition. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the research element definition. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the research element definition.  May also allow for contact.",
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
            "id": "ResearchElementDefinition.contact",
            "path": "ResearchElementDefinition.contact",
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
            "id": "ResearchElementDefinition.description",
            "path": "ResearchElementDefinition.description",
            "short": "Natural language description of the research element definition",
            "definition": "A free text natural language description of the research element definition from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the research element definition was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the research element definition as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the research element definition is presumed to be the predominant language in the place the research element definition was created).",
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
            "id": "ResearchElementDefinition.comment",
            "path": "ResearchElementDefinition.comment",
            "short": "Used for footnotes or explanatory notes",
            "definition": "A human-readable string to clarify or explain concepts about the resource.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.useContext",
            "path": "ResearchElementDefinition.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate research element definition instances.",
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
            "id": "ResearchElementDefinition.jurisdiction",
            "path": "ResearchElementDefinition.jurisdiction",
            "short": "Intended jurisdiction for research element definition (if applicable)",
            "definition": "A legal or geographic region in which the research element definition is intended to be used.",
            "comment": "It may be possible for the research element definition to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "ResearchElementDefinition.purpose",
            "path": "ResearchElementDefinition.purpose",
            "short": "Why this research element definition is defined",
            "definition": "Explanation of why this research element definition is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the research element definition. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this research element definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.usage",
            "path": "ResearchElementDefinition.usage",
            "short": "Describes the clinical usage of the ResearchElementDefinition",
            "definition": "A detailed description, from a clinical perspective, of how the ResearchElementDefinition is used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.copyright",
            "path": "ResearchElementDefinition.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the research element definition and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the research element definition.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the research element definition and/or its content.",
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
            "id": "ResearchElementDefinition.approvalDate",
            "path": "ResearchElementDefinition.approvalDate",
            "short": "When the research element definition was approved by publisher",
            "definition": "The date on which the resource content was approved by the publisher. Approval happens once when the content is officially approved for usage.",
            "comment": "The 'date' element may be more recent than the approval date because of minor changes or editorial corrections.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.lastReviewDate",
            "path": "ResearchElementDefinition.lastReviewDate",
            "short": "When the research element definition was last reviewed",
            "definition": "The date on which the resource content was last reviewed. Review happens periodically after approval but does not change the original approval date.",
            "comment": "If specified, this date follows the original approval date.",
            "requirements": "Gives a sense of how \"current\" the content is.  Resources that have not been reviewed in a long time may have a risk of being less appropriate/relevant.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.effectivePeriod",
            "path": "ResearchElementDefinition.effectivePeriod",
            "short": "When the research element definition is expected to be used",
            "definition": "The period during which the research element definition content was or is planned to be in active use.",
            "comment": "The effective period for a research element definition  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.",
            "requirements": "Allows establishing a transition before a resource comes into effect and also allows for a sunsetting  process when new versions of the research element definition are or are expected to be used instead.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Period"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchElementDefinition.topic",
            "path": "ResearchElementDefinition.topic",
            "short": "The category of the ResearchElementDefinition, such as Education, Treatment, Assessment, etc.",
            "definition": "Descriptive topics related to the content of the ResearchElementDefinition. Topics provide a high-level categorization grouping types of ResearchElementDefinitions that can be useful for filtering and searching.",
            "requirements": "Repositories must be able to determine how to categorize the ResearchElementDefinition so that it can be found by topical searches.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "DefinitionTopic"
                }
              ],
              "strength": "example",
              "description": "High-level categorization of the definition, used for searching, sorting, and filtering.",
              "valueSet": "http://hl7.org/fhir/ValueSet/definition-topic"
            }
          },
          {
            "id": "ResearchElementDefinition.author",
            "path": "ResearchElementDefinition.author",
            "short": "Who authored the content",
            "definition": "An individiual or organization primarily involved in the creation and maintenance of the content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactDetail"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.editor",
            "path": "ResearchElementDefinition.editor",
            "short": "Who edited the content",
            "definition": "An individual or organization primarily responsible for internal coherence of the content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactDetail"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.reviewer",
            "path": "ResearchElementDefinition.reviewer",
            "short": "Who reviewed the content",
            "definition": "An individual or organization primarily responsible for review of some aspect of the content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactDetail"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.endorser",
            "path": "ResearchElementDefinition.endorser",
            "short": "Who endorsed the content",
            "definition": "An individual or organization responsible for officially endorsing the content for use in some setting.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "ContactDetail"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.relatedArtifact",
            "path": "ResearchElementDefinition.relatedArtifact",
            "short": "Additional documentation, citations, etc.",
            "definition": "Related artifacts such as additional documentation, justification, or bibliographic references.",
            "comment": "Each related artifact is either an attachment, or a reference to another resource, but not both.",
            "requirements": "ResearchElementDefinitions must be able to provide enough information for consumers of the content (and/or interventions or results produced by the content) to be able to determine and understand the justification for and evidence in support of the content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "RelatedArtifact"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.library",
            "path": "ResearchElementDefinition.library",
            "short": "Logic used by the ResearchElementDefinition",
            "definition": "A reference to a Library resource containing the formal logic used by the ResearchElementDefinition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Library"
                ]
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.type",
            "path": "ResearchElementDefinition.type",
            "short": "population | exposure | outcome",
            "definition": "The type of research element, a population, an exposure, or an outcome.",
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
                  "valueString": "ResearchElementType"
                }
              ],
              "strength": "required",
              "description": "The possible types of research elements (E.g. Population, Exposure, Outcome).",
              "valueSet": "http://hl7.org/fhir/ValueSet/research-element-type|4.0.0"
            }
          },
          {
            "id": "ResearchElementDefinition.variableType",
            "path": "ResearchElementDefinition.variableType",
            "short": "dichotomous | continuous | descriptive",
            "definition": "The type of the outcome (e.g. Dichotomous, Continuous, or Descriptive).",
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
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "VariableType"
                }
              ],
              "strength": "required",
              "description": "The possible types of variables for exposures or outcomes (E.g. Dichotomous, Continuous, Descriptive).",
              "valueSet": "http://hl7.org/fhir/ValueSet/variable-type|4.0.0"
            }
          },
          {
            "id": "ResearchElementDefinition.characteristic",
            "path": "ResearchElementDefinition.characteristic",
            "short": "What defines the members of the research element",
            "definition": "A characteristic that defines the members of the research element. Multiple characteristics are applied with \"and\" semantics.",
            "comment": "Characteristics can be defined flexibly to accommodate different use cases for membership criteria, ranging from simple codes, all the way to using an expression language to express the criteria.",
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
            "id": "ResearchElementDefinition.characteristic.definition[x]",
            "path": "ResearchElementDefinition.characteristic.definition[x]",
            "short": "What code or expression defines members?",
            "definition": "Define members of the research element using Codes (such as condition, medication, or observation), Expressions ( using an expression language such as FHIRPath or CQL) or DataRequirements (such as Diabetes diagnosis onset in the last year).",
            "requirements": "Need to be able to define members in simple codes when the membership aligns well with terminology, with common criteria such as observations in a value set or lab tests within a year, or with expression language to support criteria that do not fit in the above.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              },
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ValueSet"
                ]
              },
              {
                "code": "Expression"
              },
              {
                "code": "DataRequirement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchElementDefinition.characteristic.usageContext",
            "path": "ResearchElementDefinition.characteristic.usageContext",
            "short": "What code/value pairs define members?",
            "definition": "Use UsageContext to define the members of the population, such as Age Ranges, Genders, Settings.",
            "requirements": "Need to be able to define members more structurally when more information can be communicated such as age range.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "UsageContext"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.characteristic.exclude",
            "path": "ResearchElementDefinition.characteristic.exclude",
            "short": "Whether the characteristic includes or excludes members",
            "definition": "When true, members with this characteristic are excluded from the element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "False"
          },
          {
            "id": "ResearchElementDefinition.characteristic.unitOfMeasure",
            "path": "ResearchElementDefinition.characteristic.unitOfMeasure",
            "short": "What unit is the outcome described in?",
            "definition": "Specifies the UCUM unit for the outcome.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "UCUMUnits"
                }
              ],
              "strength": "required",
              "description": "Unified Code for Units of Measure (UCUM).",
              "valueSet": "http://hl7.org/fhir/ValueSet/ucum-units|4.0.0"
            }
          },
          {
            "id": "ResearchElementDefinition.characteristic.studyEffectiveDescription",
            "path": "ResearchElementDefinition.characteristic.studyEffectiveDescription",
            "short": "What time period does the study cover",
            "definition": "A narrative description of the time period the study covers.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.characteristic.studyEffective[x]",
            "path": "ResearchElementDefinition.characteristic.studyEffective[x]",
            "short": "What time period does the study cover",
            "definition": "Indicates what effective period the study covers.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              },
              {
                "code": "Duration"
              },
              {
                "code": "Timing"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.characteristic.studyEffectiveTimeFromStart",
            "path": "ResearchElementDefinition.characteristic.studyEffectiveTimeFromStart",
            "short": "Observation time from study start",
            "definition": "Indicates duration from the study initiation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.characteristic.studyEffectiveGroupMeasure",
            "path": "ResearchElementDefinition.characteristic.studyEffectiveGroupMeasure",
            "short": "mean | median | mean-of-mean | mean-of-median | median-of-mean | median-of-median",
            "definition": "Indicates how elements are aggregated within the study effective period.",
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
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "GroupMeasure"
                }
              ],
              "strength": "required",
              "description": "Possible group measure aggregates (E.g. Mean, Median).",
              "valueSet": "http://hl7.org/fhir/ValueSet/group-measure|4.0.0"
            }
          },
          {
            "id": "ResearchElementDefinition.characteristic.participantEffectiveDescription",
            "path": "ResearchElementDefinition.characteristic.participantEffectiveDescription",
            "short": "What time period do participants cover",
            "definition": "A narrative description of the time period the study covers.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.characteristic.participantEffective[x]",
            "path": "ResearchElementDefinition.characteristic.participantEffective[x]",
            "short": "What time period do participants cover",
            "definition": "Indicates what effective period the study covers.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              },
              {
                "code": "Duration"
              },
              {
                "code": "Timing"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.characteristic.participantEffectiveTimeFromStart",
            "path": "ResearchElementDefinition.characteristic.participantEffectiveTimeFromStart",
            "short": "Observation time from study start",
            "definition": "Indicates duration from the participant's study entry.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ]
          },
          {
            "id": "ResearchElementDefinition.characteristic.participantEffectiveGroupMeasure",
            "path": "ResearchElementDefinition.characteristic.participantEffectiveGroupMeasure",
            "short": "mean | median | mean-of-mean | mean-of-median | median-of-mean | median-of-median",
            "definition": "Indicates how elements are aggregated within the study effective period.",
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
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "GroupMeasure"
                }
              ],
              "strength": "required",
              "description": "Possible group measure aggregates (E.g. Mean, Median).",
              "valueSet": "http://hl7.org/fhir/ValueSet/group-measure|4.0.0"
            }
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'ResearchElementDefinition'
    /// </summary>
    // 0. ResearchElementDefinition
    public partial class Resource_ResearchElementDefinition : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 33. ResearchElementDefinition.characteristic
        public partial class Type_Characteristic : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 34. ResearchElementDefinition.characteristic.definition[x]
            public ElementDefinitionInfo Element_Definition;
            // 35. ResearchElementDefinition.characteristic.usageContext
            public ElementDefinitionInfo Element_UsageContext;
            // 36. ResearchElementDefinition.characteristic.exclude
            public ElementDefinitionInfo Element_Exclude;
            // 37. ResearchElementDefinition.characteristic.unitOfMeasure
            public ElementDefinitionInfo Element_UnitOfMeasure;
            // 38. ResearchElementDefinition.characteristic.studyEffectiveDescription
            public ElementDefinitionInfo Element_StudyEffectiveDescription;
            // 39. ResearchElementDefinition.characteristic.studyEffective[x]
            public ElementDefinitionInfo Element_StudyEffective;
            // 40. ResearchElementDefinition.characteristic.studyEffectiveTimeFromStart
            public ElementDefinitionInfo Element_StudyEffectiveTimeFromStart;
            // 41. ResearchElementDefinition.characteristic.studyEffectiveGroupMeasure
            public ElementDefinitionInfo Element_StudyEffectiveGroupMeasure;
            // 42. ResearchElementDefinition.characteristic.participantEffectiveDescription
            public ElementDefinitionInfo Element_ParticipantEffectiveDescription;
            // 43. ResearchElementDefinition.characteristic.participantEffective[x]
            public ElementDefinitionInfo Element_ParticipantEffective;
            // 44. ResearchElementDefinition.characteristic.participantEffectiveTimeFromStart
            public ElementDefinitionInfo Element_ParticipantEffectiveTimeFromStart;
            // 45. ResearchElementDefinition.characteristic.participantEffectiveGroupMeasure
            public ElementDefinitionInfo Element_ParticipantEffectiveGroupMeasure;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ResearchElementDefinition.characteristic",
                    ElementId = "ResearchElementDefinition.characteristic"
                });
                Element_Definition.Write(sDef);
                Element_UsageContext.Write(sDef);
                Element_Exclude.Write(sDef);
                Element_UnitOfMeasure.Write(sDef);
                Element_StudyEffectiveDescription.Write(sDef);
                Element_StudyEffective.Write(sDef);
                Element_StudyEffectiveTimeFromStart.Write(sDef);
                Element_StudyEffectiveGroupMeasure.Write(sDef);
                Element_ParticipantEffectiveDescription.Write(sDef);
                Element_ParticipantEffective.Write(sDef);
                Element_ParticipantEffectiveTimeFromStart.Write(sDef);
                Element_ParticipantEffectiveGroupMeasure.Write(sDef);
            }
            
            public Type_Characteristic()
            {
                {
                    // 34. ResearchElementDefinition.characteristic.definition[x]
                    this.Element_Definition = new ElementDefinitionInfo
                    {
                        Name = "Element_Definition",
                        Path= "ResearchElementDefinition.characteristic.definition[x]",
                        Id = "ResearchElementDefinition.characteristic.definition[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/ValueSet"
                                }
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Expression
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_DataRequirement
                            {
                            }
                        }
                    };
                }
                {
                    // 35. ResearchElementDefinition.characteristic.usageContext
                    this.Element_UsageContext = new ElementDefinitionInfo
                    {
                        Name = "Element_UsageContext",
                        Path= "ResearchElementDefinition.characteristic.usageContext",
                        Id = "ResearchElementDefinition.characteristic.usageContext",
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
                    // 36. ResearchElementDefinition.characteristic.exclude
                    this.Element_Exclude = new ElementDefinitionInfo
                    {
                        Name = "Element_Exclude",
                        Path= "ResearchElementDefinition.characteristic.exclude",
                        Id = "ResearchElementDefinition.characteristic.exclude",
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
                    // 37. ResearchElementDefinition.characteristic.unitOfMeasure
                    this.Element_UnitOfMeasure = new ElementDefinitionInfo
                    {
                        Name = "Element_UnitOfMeasure",
                        Path= "ResearchElementDefinition.characteristic.unitOfMeasure",
                        Id = "ResearchElementDefinition.characteristic.unitOfMeasure",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            }
                        }
                    };
                }
                {
                    // 38. ResearchElementDefinition.characteristic.studyEffectiveDescription
                    this.Element_StudyEffectiveDescription = new ElementDefinitionInfo
                    {
                        Name = "Element_StudyEffectiveDescription",
                        Path= "ResearchElementDefinition.characteristic.studyEffectiveDescription",
                        Id = "ResearchElementDefinition.characteristic.studyEffectiveDescription",
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
                    // 39. ResearchElementDefinition.characteristic.studyEffective[x]
                    this.Element_StudyEffective = new ElementDefinitionInfo
                    {
                        Name = "Element_StudyEffective",
                        Path= "ResearchElementDefinition.characteristic.studyEffective[x]",
                        Id = "ResearchElementDefinition.characteristic.studyEffective[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Timing
                            {
                            }
                        }
                    };
                }
                {
                    // 40. ResearchElementDefinition.characteristic.studyEffectiveTimeFromStart
                    this.Element_StudyEffectiveTimeFromStart = new ElementDefinitionInfo
                    {
                        Name = "Element_StudyEffectiveTimeFromStart",
                        Path= "ResearchElementDefinition.characteristic.studyEffectiveTimeFromStart",
                        Id = "ResearchElementDefinition.characteristic.studyEffectiveTimeFromStart",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            }
                        }
                    };
                }
                {
                    // 41. ResearchElementDefinition.characteristic.studyEffectiveGroupMeasure
                    this.Element_StudyEffectiveGroupMeasure = new ElementDefinitionInfo
                    {
                        Name = "Element_StudyEffectiveGroupMeasure",
                        Path= "ResearchElementDefinition.characteristic.studyEffectiveGroupMeasure",
                        Id = "ResearchElementDefinition.characteristic.studyEffectiveGroupMeasure",
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
                    // 42. ResearchElementDefinition.characteristic.participantEffectiveDescription
                    this.Element_ParticipantEffectiveDescription = new ElementDefinitionInfo
                    {
                        Name = "Element_ParticipantEffectiveDescription",
                        Path= "ResearchElementDefinition.characteristic.participantEffectiveDescription",
                        Id = "ResearchElementDefinition.characteristic.participantEffectiveDescription",
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
                    // 43. ResearchElementDefinition.characteristic.participantEffective[x]
                    this.Element_ParticipantEffective = new ElementDefinitionInfo
                    {
                        Name = "Element_ParticipantEffective",
                        Path= "ResearchElementDefinition.characteristic.participantEffective[x]",
                        Id = "ResearchElementDefinition.characteristic.participantEffective[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Timing
                            {
                            }
                        }
                    };
                }
                {
                    // 44. ResearchElementDefinition.characteristic.participantEffectiveTimeFromStart
                    this.Element_ParticipantEffectiveTimeFromStart = new ElementDefinitionInfo
                    {
                        Name = "Element_ParticipantEffectiveTimeFromStart",
                        Path= "ResearchElementDefinition.characteristic.participantEffectiveTimeFromStart",
                        Id = "ResearchElementDefinition.characteristic.participantEffectiveTimeFromStart",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            }
                        }
                    };
                }
                {
                    // 45. ResearchElementDefinition.characteristic.participantEffectiveGroupMeasure
                    this.Element_ParticipantEffectiveGroupMeasure = new ElementDefinitionInfo
                    {
                        Name = "Element_ParticipantEffectiveGroupMeasure",
                        Path= "ResearchElementDefinition.characteristic.participantEffectiveGroupMeasure",
                        Id = "ResearchElementDefinition.characteristic.participantEffectiveGroupMeasure",
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
        // 1. ResearchElementDefinition.url
        public ElementDefinitionInfo Element_Url;
        // 2. ResearchElementDefinition.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. ResearchElementDefinition.version
        public ElementDefinitionInfo Element_Version;
        // 4. ResearchElementDefinition.name
        public ElementDefinitionInfo Element_Name;
        // 5. ResearchElementDefinition.title
        public ElementDefinitionInfo Element_Title;
        // 6. ResearchElementDefinition.shortTitle
        public ElementDefinitionInfo Element_ShortTitle;
        // 7. ResearchElementDefinition.subtitle
        public ElementDefinitionInfo Element_Subtitle;
        // 8. ResearchElementDefinition.status
        public ElementDefinitionInfo Element_Status;
        // 9. ResearchElementDefinition.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 10. ResearchElementDefinition.subject[x]
        public ElementDefinitionInfo Element_Subject;
        // 11. ResearchElementDefinition.date
        public ElementDefinitionInfo Element_Date;
        // 12. ResearchElementDefinition.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 13. ResearchElementDefinition.contact
        public ElementDefinitionInfo Element_Contact;
        // 14. ResearchElementDefinition.description
        public ElementDefinitionInfo Element_Description;
        // 15. ResearchElementDefinition.comment
        public ElementDefinitionInfo Element_Comment;
        // 16. ResearchElementDefinition.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 17. ResearchElementDefinition.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 18. ResearchElementDefinition.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 19. ResearchElementDefinition.usage
        public ElementDefinitionInfo Element_Usage;
        // 20. ResearchElementDefinition.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 21. ResearchElementDefinition.approvalDate
        public ElementDefinitionInfo Element_ApprovalDate;
        // 22. ResearchElementDefinition.lastReviewDate
        public ElementDefinitionInfo Element_LastReviewDate;
        // 23. ResearchElementDefinition.effectivePeriod
        public ElementDefinitionInfo Element_EffectivePeriod;
        // 24. ResearchElementDefinition.topic
        public ElementDefinitionInfo Element_Topic;
        // 25. ResearchElementDefinition.author
        public ElementDefinitionInfo Element_Author;
        // 26. ResearchElementDefinition.editor
        public ElementDefinitionInfo Element_Editor;
        // 27. ResearchElementDefinition.reviewer
        public ElementDefinitionInfo Element_Reviewer;
        // 28. ResearchElementDefinition.endorser
        public ElementDefinitionInfo Element_Endorser;
        // 29. ResearchElementDefinition.relatedArtifact
        public ElementDefinitionInfo Element_RelatedArtifact;
        // 30. ResearchElementDefinition.library
        public ElementDefinitionInfo Element_Library;
        // 31. ResearchElementDefinition.type
        public ElementDefinitionInfo Element_Type;
        // 32. ResearchElementDefinition.variableType
        public ElementDefinitionInfo Element_VariableType;
        // 33. ResearchElementDefinition.characteristic
        public ElementDefinitionInfo Element_Characteristic;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ResearchElementDefinition",
                ElementId = "ResearchElementDefinition"
            });
            Element_Url.Write(sDef);
            Element_Identifier.Write(sDef);
            Element_Version.Write(sDef);
            Element_Name.Write(sDef);
            Element_Title.Write(sDef);
            Element_ShortTitle.Write(sDef);
            Element_Subtitle.Write(sDef);
            Element_Status.Write(sDef);
            Element_Experimental.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Date.Write(sDef);
            Element_Publisher.Write(sDef);
            Element_Contact.Write(sDef);
            Element_Description.Write(sDef);
            Element_Comment.Write(sDef);
            Element_UseContext.Write(sDef);
            Element_Jurisdiction.Write(sDef);
            Element_Purpose.Write(sDef);
            Element_Usage.Write(sDef);
            Element_Copyright.Write(sDef);
            Element_ApprovalDate.Write(sDef);
            Element_LastReviewDate.Write(sDef);
            Element_EffectivePeriod.Write(sDef);
            Element_Topic.Write(sDef);
            Element_Author.Write(sDef);
            Element_Editor.Write(sDef);
            Element_Reviewer.Write(sDef);
            Element_Endorser.Write(sDef);
            Element_RelatedArtifact.Write(sDef);
            Element_Library.Write(sDef);
            Element_Type.Write(sDef);
            Element_VariableType.Write(sDef);
            Element_Characteristic.Write(sDef);
        }
        
        public Resource_ResearchElementDefinition()
        {
            {
                // 1. ResearchElementDefinition.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "ResearchElementDefinition.url",
                    Id = "ResearchElementDefinition.url",
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
                // 2. ResearchElementDefinition.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ResearchElementDefinition.identifier",
                    Id = "ResearchElementDefinition.identifier",
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
                // 3. ResearchElementDefinition.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "ResearchElementDefinition.version",
                    Id = "ResearchElementDefinition.version",
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
                // 4. ResearchElementDefinition.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "ResearchElementDefinition.name",
                    Id = "ResearchElementDefinition.name",
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
                // 5. ResearchElementDefinition.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "ResearchElementDefinition.title",
                    Id = "ResearchElementDefinition.title",
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
                // 6. ResearchElementDefinition.shortTitle
                this.Element_ShortTitle = new ElementDefinitionInfo
                {
                    Name = "Element_ShortTitle",
                    Path= "ResearchElementDefinition.shortTitle",
                    Id = "ResearchElementDefinition.shortTitle",
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
                // 7. ResearchElementDefinition.subtitle
                this.Element_Subtitle = new ElementDefinitionInfo
                {
                    Name = "Element_Subtitle",
                    Path= "ResearchElementDefinition.subtitle",
                    Id = "ResearchElementDefinition.subtitle",
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
                // 8. ResearchElementDefinition.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ResearchElementDefinition.status",
                    Id = "ResearchElementDefinition.status",
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
                // 9. ResearchElementDefinition.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "ResearchElementDefinition.experimental",
                    Id = "ResearchElementDefinition.experimental",
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
                // 10. ResearchElementDefinition.subject[x]
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "ResearchElementDefinition.subject[x]",
                    Id = "ResearchElementDefinition.subject[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Group"
                            }
                        }
                    }
                };
            }
            {
                // 11. ResearchElementDefinition.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "ResearchElementDefinition.date",
                    Id = "ResearchElementDefinition.date",
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
                // 12. ResearchElementDefinition.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "ResearchElementDefinition.publisher",
                    Id = "ResearchElementDefinition.publisher",
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
                // 13. ResearchElementDefinition.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "ResearchElementDefinition.contact",
                    Id = "ResearchElementDefinition.contact",
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
                // 14. ResearchElementDefinition.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "ResearchElementDefinition.description",
                    Id = "ResearchElementDefinition.description",
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
                // 15. ResearchElementDefinition.comment
                this.Element_Comment = new ElementDefinitionInfo
                {
                    Name = "Element_Comment",
                    Path= "ResearchElementDefinition.comment",
                    Id = "ResearchElementDefinition.comment",
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
                // 16. ResearchElementDefinition.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "ResearchElementDefinition.useContext",
                    Id = "ResearchElementDefinition.useContext",
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
                // 17. ResearchElementDefinition.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "ResearchElementDefinition.jurisdiction",
                    Id = "ResearchElementDefinition.jurisdiction",
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
                // 18. ResearchElementDefinition.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "ResearchElementDefinition.purpose",
                    Id = "ResearchElementDefinition.purpose",
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
                // 19. ResearchElementDefinition.usage
                this.Element_Usage = new ElementDefinitionInfo
                {
                    Name = "Element_Usage",
                    Path= "ResearchElementDefinition.usage",
                    Id = "ResearchElementDefinition.usage",
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
                // 20. ResearchElementDefinition.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "ResearchElementDefinition.copyright",
                    Id = "ResearchElementDefinition.copyright",
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
                // 21. ResearchElementDefinition.approvalDate
                this.Element_ApprovalDate = new ElementDefinitionInfo
                {
                    Name = "Element_ApprovalDate",
                    Path= "ResearchElementDefinition.approvalDate",
                    Id = "ResearchElementDefinition.approvalDate",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date
                        {
                        }
                    }
                };
            }
            {
                // 22. ResearchElementDefinition.lastReviewDate
                this.Element_LastReviewDate = new ElementDefinitionInfo
                {
                    Name = "Element_LastReviewDate",
                    Path= "ResearchElementDefinition.lastReviewDate",
                    Id = "ResearchElementDefinition.lastReviewDate",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date
                        {
                        }
                    }
                };
            }
            {
                // 23. ResearchElementDefinition.effectivePeriod
                this.Element_EffectivePeriod = new ElementDefinitionInfo
                {
                    Name = "Element_EffectivePeriod",
                    Path= "ResearchElementDefinition.effectivePeriod",
                    Id = "ResearchElementDefinition.effectivePeriod",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        }
                    }
                };
            }
            {
                // 24. ResearchElementDefinition.topic
                this.Element_Topic = new ElementDefinitionInfo
                {
                    Name = "Element_Topic",
                    Path= "ResearchElementDefinition.topic",
                    Id = "ResearchElementDefinition.topic",
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
                // 25. ResearchElementDefinition.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "ResearchElementDefinition.author",
                    Id = "ResearchElementDefinition.author",
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
                // 26. ResearchElementDefinition.editor
                this.Element_Editor = new ElementDefinitionInfo
                {
                    Name = "Element_Editor",
                    Path= "ResearchElementDefinition.editor",
                    Id = "ResearchElementDefinition.editor",
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
                // 27. ResearchElementDefinition.reviewer
                this.Element_Reviewer = new ElementDefinitionInfo
                {
                    Name = "Element_Reviewer",
                    Path= "ResearchElementDefinition.reviewer",
                    Id = "ResearchElementDefinition.reviewer",
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
                // 28. ResearchElementDefinition.endorser
                this.Element_Endorser = new ElementDefinitionInfo
                {
                    Name = "Element_Endorser",
                    Path= "ResearchElementDefinition.endorser",
                    Id = "ResearchElementDefinition.endorser",
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
                // 29. ResearchElementDefinition.relatedArtifact
                this.Element_RelatedArtifact = new ElementDefinitionInfo
                {
                    Name = "Element_RelatedArtifact",
                    Path= "ResearchElementDefinition.relatedArtifact",
                    Id = "ResearchElementDefinition.relatedArtifact",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_RelatedArtifact
                        {
                        }
                    }
                };
            }
            {
                // 30. ResearchElementDefinition.library
                this.Element_Library = new ElementDefinitionInfo
                {
                    Name = "Element_Library",
                    Path= "ResearchElementDefinition.library",
                    Id = "ResearchElementDefinition.library",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Library"
                            }
                        }
                    }
                };
            }
            {
                // 31. ResearchElementDefinition.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "ResearchElementDefinition.type",
                    Id = "ResearchElementDefinition.type",
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
                // 32. ResearchElementDefinition.variableType
                this.Element_VariableType = new ElementDefinitionInfo
                {
                    Name = "Element_VariableType",
                    Path= "ResearchElementDefinition.variableType",
                    Id = "ResearchElementDefinition.variableType",
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
                // 33. ResearchElementDefinition.characteristic
                this.Element_Characteristic = new ElementDefinitionInfo
                {
                    Name = "Element_Characteristic",
                    Path= "ResearchElementDefinition.characteristic",
                    Id = "ResearchElementDefinition.characteristic",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Characteristic
                        {
                        }
                    }
                };
            }
            this.Name = "ResearchElementDefinition";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ResearchElementDefinition";
        }
    }
}
