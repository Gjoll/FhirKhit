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
      "id": "PlanDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
      "version": "4.0.0",
      "name": "PlanDefinition",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Decision Support)",
      "description": "This resource allows for the definition of various types of plans as a sharable, consumable, and executable artifact. The resource is general enough to support the description of a broad range of clinical artifacts such as clinical decision support rules, order sets and protocols.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "PlanDefinition",
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
            "id": "PlanDefinition",
            "path": "PlanDefinition",
            "short": "The definition of a plan for a series of actions, independent of any specific patient or context",
            "definition": "This resource allows for the definition of various types of plans as a sharable, consumable, and executable artifact. The resource is general enough to support the description of a broad range of clinical artifacts such as clinical decision support rules, order sets and protocols.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "PlanDefinition.url",
            "path": "PlanDefinition.url",
            "short": "Canonical identifier for this plan definition, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this plan definition when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this plan definition is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the plan definition is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the plan definition to be referenced by a single globally unique identifier.",
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
            "id": "PlanDefinition.identifier",
            "path": "PlanDefinition.identifier",
            "short": "Additional identifier for the plan definition",
            "definition": "A formal identifier that is used to identify this plan definition when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this plan definition outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "PlanDefinition.version",
            "path": "PlanDefinition.version",
            "short": "Business version of the plan definition",
            "definition": "The identifier that is used to identify this version of the plan definition when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the plan definition author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence. To provide a version consistent with the Decision Support Service specification, use the format Major.Minor.Revision (e.g. 1.0.0). For more information on versioning knowledge assets, refer to the Decision Support Service specification. Note that a version is required for non-experimental active artifacts.",
            "comment": "There may be different plan definition instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the plan definition with the format [url]|[version].",
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
            "id": "PlanDefinition.name",
            "path": "PlanDefinition.name",
            "short": "Name for this plan definition (computer friendly)",
            "definition": "A natural language name identifying the plan definition. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "PlanDefinition.title",
            "path": "PlanDefinition.title",
            "short": "Name for this plan definition (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the plan definition.",
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
            "id": "PlanDefinition.subtitle",
            "path": "PlanDefinition.subtitle",
            "short": "Subordinate title of the plan definition",
            "definition": "An explanatory or alternate title for the plan definition giving additional information about its content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "PlanDefinition.type",
            "path": "PlanDefinition.type",
            "short": "order-set | clinical-protocol | eca-rule | workflow-definition",
            "definition": "A high-level category for the plan definition that distinguishes the kinds of systems that would be interested in the plan definition.",
            "min": 0,
            "max": "1",
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
                  "valueString": "PlanDefinitionType"
                }
              ],
              "strength": "extensible",
              "description": "The type of PlanDefinition.",
              "valueSet": "http://hl7.org/fhir/ValueSet/plan-definition-type"
            }
          },
          {
            "id": "PlanDefinition.status",
            "path": "PlanDefinition.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this plan definition. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of plan definitions that are appropriate for use versus not.",
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
            "id": "PlanDefinition.experimental",
            "path": "PlanDefinition.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this plan definition is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of plan definitions that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level plan definition.",
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
            "id": "PlanDefinition.subject[x]",
            "path": "PlanDefinition.subject[x]",
            "short": "Type of individual the plan definition is focused on",
            "definition": "A code or group definition that describes the intended subject of the plan definition.",
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
              "description": "The possible types of subjects for a plan definition (E.g. Patient, Practitioner, Organization, Location, etc.).",
              "valueSet": "http://hl7.org/fhir/ValueSet/subject-type"
            }
          },
          {
            "id": "PlanDefinition.date",
            "path": "PlanDefinition.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the plan definition was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the plan definition changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the plan definition. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "PlanDefinition.publisher",
            "path": "PlanDefinition.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the plan definition.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the plan definition is the organization or individual primarily responsible for the maintenance and upkeep of the plan definition. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the plan definition. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the plan definition.  May also allow for contact.",
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
            "id": "PlanDefinition.contact",
            "path": "PlanDefinition.contact",
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
            "id": "PlanDefinition.description",
            "path": "PlanDefinition.description",
            "short": "Natural language description of the plan definition",
            "definition": "A free text natural language description of the plan definition from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the plan definition was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the plan definition as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the plan definition is presumed to be the predominant language in the place the plan definition was created).",
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
            "id": "PlanDefinition.useContext",
            "path": "PlanDefinition.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate plan definition instances.",
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
            "id": "PlanDefinition.jurisdiction",
            "path": "PlanDefinition.jurisdiction",
            "short": "Intended jurisdiction for plan definition (if applicable)",
            "definition": "A legal or geographic region in which the plan definition is intended to be used.",
            "comment": "It may be possible for the plan definition to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "PlanDefinition.purpose",
            "path": "PlanDefinition.purpose",
            "short": "Why this plan definition is defined",
            "definition": "Explanation of why this plan definition is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the plan definition. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this plan definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "PlanDefinition.usage",
            "path": "PlanDefinition.usage",
            "short": "Describes the clinical usage of the plan",
            "definition": "A detailed description of how the plan definition is used from a clinical perspective.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "PlanDefinition.copyright",
            "path": "PlanDefinition.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the plan definition and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the plan definition.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the plan definition and/or its content.",
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
            "id": "PlanDefinition.approvalDate",
            "path": "PlanDefinition.approvalDate",
            "short": "When the plan definition was approved by publisher",
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
            "id": "PlanDefinition.lastReviewDate",
            "path": "PlanDefinition.lastReviewDate",
            "short": "When the plan definition was last reviewed",
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
            "id": "PlanDefinition.effectivePeriod",
            "path": "PlanDefinition.effectivePeriod",
            "short": "When the plan definition is expected to be used",
            "definition": "The period during which the plan definition content was or is planned to be in active use.",
            "comment": "The effective period for a plan definition  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.",
            "requirements": "Allows establishing a transition before a resource comes into effect and also allows for a sunsetting  process when new versions of the plan definition are or are expected to be used instead.",
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
            "id": "PlanDefinition.topic",
            "path": "PlanDefinition.topic",
            "short": "E.g. Education, Treatment, Assessment",
            "definition": "Descriptive topics related to the content of the plan definition. Topics provide a high-level categorization of the definition that can be useful for filtering and searching.",
            "requirements": "Repositories must be able to determine how to categorize the plan definition so that it can be found by topical searches.",
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
            "id": "PlanDefinition.author",
            "path": "PlanDefinition.author",
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
            "id": "PlanDefinition.editor",
            "path": "PlanDefinition.editor",
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
            "id": "PlanDefinition.reviewer",
            "path": "PlanDefinition.reviewer",
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
            "id": "PlanDefinition.endorser",
            "path": "PlanDefinition.endorser",
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
            "id": "PlanDefinition.relatedArtifact",
            "path": "PlanDefinition.relatedArtifact",
            "short": "Additional documentation, citations",
            "definition": "Related artifacts such as additional documentation, justification, or bibliographic references.",
            "comment": "Each related artifact is either an attachment, or a reference to another resource, but not both.",
            "requirements": "Plan definitions must be able to provide enough information for consumers of the content (and/or interventions or results produced by the content) to be able to determine and understand the justification for and evidence in support of the content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "RelatedArtifact"
              }
            ]
          },
          {
            "id": "PlanDefinition.library",
            "path": "PlanDefinition.library",
            "short": "Logic used by the plan definition",
            "definition": "A reference to a Library resource containing any formal logic used by the plan definition.",
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
            "id": "PlanDefinition.goal",
            "path": "PlanDefinition.goal",
            "short": "What the plan is trying to accomplish",
            "definition": "Goals that describe what the activities within the plan are intended to achieve. For example, weight loss, restoring an activity of daily living, obtaining herd immunity via immunization, meeting a process improvement objective, etc.",
            "requirements": "Goal information needs to be captured for order sets, protocols, and care plan definitions to better describe the objectives of the protocol activities and to guide the creation of specific goals within the derived care plans and orders.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "PlanDefinition.goal.category",
            "path": "PlanDefinition.goal.category",
            "short": "E.g. Treatment, dietary, behavioral",
            "definition": "Indicates a category the goal falls within.",
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
                  "valueString": "GoalCategory"
                }
              ],
              "strength": "example",
              "description": "Example codes for grouping goals for filtering or presentation.",
              "valueSet": "http://hl7.org/fhir/ValueSet/goal-category"
            }
          },
          {
            "id": "PlanDefinition.goal.description",
            "path": "PlanDefinition.goal.description",
            "short": "Code or text describing the goal",
            "definition": "Human-readable and/or coded description of a specific desired objective of care, such as \"control blood pressure\" or \"negotiate an obstacle course\" or \"dance with child at wedding\".",
            "comment": "If no code is available, use CodeableConcept.text.",
            "min": 1,
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
                  "valueString": "GoalDescription"
                }
              ],
              "strength": "example",
              "description": "Describes goals that can be achieved.",
              "valueSet": "http://hl7.org/fhir/ValueSet/clinical-findings"
            }
          },
          {
            "id": "PlanDefinition.goal.priority",
            "path": "PlanDefinition.goal.priority",
            "short": "high-priority | medium-priority | low-priority",
            "definition": "Identifies the expected level of importance associated with reaching/sustaining the defined goal.",
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
                  "valueString": "GoalPriority"
                }
              ],
              "strength": "preferred",
              "description": "Indicates the level of importance associated with reaching or sustaining a goal.",
              "valueSet": "http://hl7.org/fhir/ValueSet/goal-priority"
            }
          },
          {
            "id": "PlanDefinition.goal.start",
            "path": "PlanDefinition.goal.start",
            "short": "When goal pursuit begins",
            "definition": "The event after which the goal should begin being pursued.",
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
                  "valueString": "GoalStartEvent"
                }
              ],
              "strength": "example",
              "description": "Identifies the types of events that might trigger the start of a goal.",
              "valueSet": "http://hl7.org/fhir/ValueSet/goal-start-event"
            }
          },
          {
            "id": "PlanDefinition.goal.addresses",
            "path": "PlanDefinition.goal.addresses",
            "short": "What does the goal address",
            "definition": "Identifies problems, conditions, issues, or concerns the goal is intended to address.",
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
                  "valueString": "GoalAddresses"
                }
              ],
              "strength": "example",
              "description": "Identifies problems, conditions, issues, or concerns that goals may address.",
              "valueSet": "http://hl7.org/fhir/ValueSet/condition-code"
            }
          },
          {
            "id": "PlanDefinition.goal.documentation",
            "path": "PlanDefinition.goal.documentation",
            "short": "Supporting documentation for the goal",
            "definition": "Didactic or other informational resources associated with the goal that provide further supporting information about the goal. Information resources can include inline text commentary and links to web resources.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "RelatedArtifact"
              }
            ]
          },
          {
            "id": "PlanDefinition.goal.target",
            "path": "PlanDefinition.goal.target",
            "short": "Target outcome for the goal",
            "definition": "Indicates what should be done and within what timeframe.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "PlanDefinition.goal.target.measure",
            "path": "PlanDefinition.goal.target.measure",
            "short": "The parameter whose value is to be tracked",
            "definition": "The parameter whose value is to be tracked, e.g. body weight, blood pressure, or hemoglobin A1c level.",
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
                  "valueString": "GoalTargetMeasure"
                }
              ],
              "strength": "example",
              "description": "Identifies types of parameters that can be tracked to determine goal achievement.",
              "valueSet": "http://hl7.org/fhir/ValueSet/observation-codes"
            }
          },
          {
            "id": "PlanDefinition.goal.target.detail[x]",
            "path": "PlanDefinition.goal.target.detail[x]",
            "short": "The target value to be achieved",
            "definition": "The target value of the measure to be achieved to signify fulfillment of the goal, e.g. 150 pounds or 7.0%. Either the high or low or both values of the range can be specified. When a low value is missing, it indicates that the goal is achieved at any value at or below the high value. Similarly, if the high value is missing, it indicates that the goal is achieved at any value at or above the low value.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity"
              },
              {
                "code": "Range"
              },
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "PlanDefinition.goal.target.due",
            "path": "PlanDefinition.goal.target.due",
            "short": "Reach goal within",
            "definition": "Indicates the timeframe after the start of the goal in which the goal should be met.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ]
          },
          {
            "id": "PlanDefinition.action",
            "path": "PlanDefinition.action",
            "short": "Action defined by the plan",
            "definition": "An action or group of actions to be taken as part of the plan.",
            "comment": "Note that there is overlap between many of the elements defined here and the ActivityDefinition resource. When an ActivityDefinition is referenced (using the definition element), the overlapping elements in the plan override the content of the referenced ActivityDefinition unless otherwise documented in the specific elements. See the PlanDefinition resource for more detailed information.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.prefix",
            "path": "PlanDefinition.action.prefix",
            "short": "User-visible prefix for the action (e.g. 1. or A.)",
            "definition": "A user-visible prefix for the action.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.title",
            "path": "PlanDefinition.action.title",
            "short": "User-visible title",
            "definition": "The title of the action displayed to a user.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.description",
            "path": "PlanDefinition.action.description",
            "short": "Brief description of the action",
            "definition": "A brief description of the action used to provide a summary to display to the user.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.textEquivalent",
            "path": "PlanDefinition.action.textEquivalent",
            "short": "Static text equivalent of the action, used if the dynamic aspects cannot be interpreted by the receiving system",
            "definition": "A text equivalent of the action to be performed. This provides a human-interpretable description of the action when the definition is consumed by a system that might not be capable of interpreting it dynamically.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.priority",
            "path": "PlanDefinition.action.priority",
            "short": "routine | urgent | asap | stat",
            "definition": "Indicates how quickly the action should be addressed with respect to other actions.",
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
                  "valueString": "RequestPriority"
                }
              ],
              "strength": "required",
              "description": "Identifies the level of importance to be assigned to actioning the request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-priority|4.0.0"
            }
          },
          {
            "id": "PlanDefinition.action.code",
            "path": "PlanDefinition.action.code",
            "short": "Code representing the meaning of the action or sub-actions",
            "definition": "A code that provides meaning for the action or action group. For example, a section may have a LOINC code for the section of a documentation template.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.reason",
            "path": "PlanDefinition.action.reason",
            "short": "Why the action should be performed",
            "definition": "A description of why this action is necessary or appropriate.",
            "comment": "This is different than the clinical evidence documentation, it's an actual business description of the reason for performing the action.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.documentation",
            "path": "PlanDefinition.action.documentation",
            "short": "Supporting documentation for the intended performer of the action",
            "definition": "Didactic or other informational resources associated with the action that can be provided to the CDS recipient. Information resources can include inline text commentary and links to web resources.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "RelatedArtifact"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.goalId",
            "path": "PlanDefinition.action.goalId",
            "short": "What goals this action supports",
            "definition": "Identifies goals that this action supports. The reference must be to a goal element defined within this plan definition.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "id"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.subject[x]",
            "path": "PlanDefinition.action.subject[x]",
            "short": "Type of individual the action is focused on",
            "definition": "A code or group definition that describes the intended subject of the action and its children, if any.",
            "comment": "The subject of an action overrides the subject at a parent action or on the root of the PlanDefinition if specified.\n\nIn addition, because the subject needs to be resolved during realization, use of subjects in actions (or in the ActivityDefinition referenced by the action) resolves based on the set of subjects supplied in context and by type (i.e. the patient subject would resolve to a resource of type Patient).",
            "requirements": "Multiple steps in a protocol often have different groups of steps that are focused on testing different things. The subject of an action specifies the focus of the action and any child actions.",
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
              "description": "The possible types of subjects for a plan definition (E.g. Patient, Practitioner, Organization, Location, etc.).",
              "valueSet": "http://hl7.org/fhir/ValueSet/subject-type"
            }
          },
          {
            "id": "PlanDefinition.action.trigger",
            "path": "PlanDefinition.action.trigger",
            "short": "When the action should be triggered",
            "definition": "A description of when the action should be triggered.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "TriggerDefinition"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.condition",
            "path": "PlanDefinition.action.condition",
            "short": "Whether or not the action is applicable",
            "definition": "An expression that describes applicability criteria or start/stop conditions for the action.",
            "comment": "When multiple conditions of the same kind are present, the effects are combined using AND semantics, so the overall condition is true only if all the conditions are true.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.condition.kind",
            "path": "PlanDefinition.action.condition.kind",
            "short": "applicability | start | stop",
            "definition": "The kind of condition.",
            "comment": "Applicability criteria are used to determine immediate applicability when a plan definition is applied to a given context. Start and stop criteria are carried through application and used to describe enter/exit criteria for an action.",
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
                  "valueString": "ActionConditionKind"
                }
              ],
              "strength": "required",
              "description": "Defines the kinds of conditions that can appear on actions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-condition-kind|4.0.0"
            }
          },
          {
            "id": "PlanDefinition.action.condition.expression",
            "path": "PlanDefinition.action.condition.expression",
            "short": "Boolean-valued expression",
            "definition": "An expression that returns true or false, indicating whether the condition is satisfied.",
            "comment": "The expression may be inlined or may be a reference to a named expression within a logic library referenced by the library element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Expression"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.input",
            "path": "PlanDefinition.action.input",
            "short": "Input data requirements",
            "definition": "Defines input data requirements for the action.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "DataRequirement"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.output",
            "path": "PlanDefinition.action.output",
            "short": "Output data definition",
            "definition": "Defines the outputs of the action, if any.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "DataRequirement"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.relatedAction",
            "path": "PlanDefinition.action.relatedAction",
            "short": "Relationship to another action",
            "definition": "A relationship to another action such as \"before\" or \"30-60 minutes after start of\".",
            "comment": "When an action depends on multiple actions, the meaning is that all actions are dependencies, rather than that any of the actions are a dependency.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.relatedAction.actionId",
            "path": "PlanDefinition.action.relatedAction.actionId",
            "short": "What action is this related to",
            "definition": "The element id of the related action.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.relatedAction.relationship",
            "path": "PlanDefinition.action.relatedAction.relationship",
            "short": "before-start | before | before-end | concurrent-with-start | concurrent | concurrent-with-end | after-start | after | after-end",
            "definition": "The relationship of this action to the related action.",
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
                  "valueString": "ActionRelationshipType"
                }
              ],
              "strength": "required",
              "description": "Defines the types of relationships between actions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-relationship-type|4.0.0"
            }
          },
          {
            "id": "PlanDefinition.action.relatedAction.offset[x]",
            "path": "PlanDefinition.action.relatedAction.offset[x]",
            "short": "Time offset for the relationship",
            "definition": "A duration or range of durations to apply to the relationship. For example, 30-60 minutes before.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              },
              {
                "code": "Range"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.timing[x]",
            "path": "PlanDefinition.action.timing[x]",
            "short": "When the action should take place",
            "definition": "An optional value describing when the action should be performed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Age"
              },
              {
                "code": "Period"
              },
              {
                "code": "Duration"
              },
              {
                "code": "Range"
              },
              {
                "code": "Timing"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.participant",
            "path": "PlanDefinition.action.participant",
            "short": "Who should participate in the action",
            "definition": "Indicates who should participate in performing the action described.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.participant.type",
            "path": "PlanDefinition.action.participant.type",
            "short": "patient | practitioner | related-person | device",
            "definition": "The type of participant in the action.",
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
                  "valueString": "ActionParticipantType"
                }
              ],
              "strength": "required",
              "description": "The type of participant for the action.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-participant-type|4.0.0"
            }
          },
          {
            "id": "PlanDefinition.action.participant.role",
            "path": "PlanDefinition.action.participant.role",
            "short": "E.g. Nurse, Surgeon, Parent",
            "definition": "The role the participant should play in performing the described action.",
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
                  "valueString": "ActionParticipantRole"
                }
              ],
              "strength": "example",
              "description": "Defines roles played by participants for the action.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-participant-role"
            }
          },
          {
            "id": "PlanDefinition.action.type",
            "path": "PlanDefinition.action.type",
            "short": "create | update | remove | fire-event",
            "definition": "The type of action to perform (create, update, remove).",
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
                  "valueString": "ActionType"
                }
              ],
              "strength": "extensible",
              "description": "The type of action to be performed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-type"
            }
          },
          {
            "id": "PlanDefinition.action.groupingBehavior",
            "path": "PlanDefinition.action.groupingBehavior",
            "short": "visual-group | logical-group | sentence-group",
            "definition": "Defines the grouping behavior for the action and its children.",
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
                  "valueString": "ActionGroupingBehavior"
                }
              ],
              "strength": "required",
              "description": "Defines organization behavior of a group.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-grouping-behavior|4.0.0"
            }
          },
          {
            "id": "PlanDefinition.action.selectionBehavior",
            "path": "PlanDefinition.action.selectionBehavior",
            "short": "any | all | all-or-none | exactly-one | at-most-one | one-or-more",
            "definition": "Defines the selection behavior for the action and its children.",
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
                  "valueString": "ActionSelectionBehavior"
                }
              ],
              "strength": "required",
              "description": "Defines selection behavior of a group.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-selection-behavior|4.0.0"
            }
          },
          {
            "id": "PlanDefinition.action.requiredBehavior",
            "path": "PlanDefinition.action.requiredBehavior",
            "short": "must | could | must-unless-documented",
            "definition": "Defines the required behavior for the action.",
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
                  "valueString": "ActionRequiredBehavior"
                }
              ],
              "strength": "required",
              "description": "Defines expectations around whether an action or action group is required.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-required-behavior|4.0.0"
            }
          },
          {
            "id": "PlanDefinition.action.precheckBehavior",
            "path": "PlanDefinition.action.precheckBehavior",
            "short": "yes | no",
            "definition": "Defines whether the action should usually be preselected.",
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
                  "valueString": "ActionPrecheckBehavior"
                }
              ],
              "strength": "required",
              "description": "Defines selection frequency behavior for an action or group.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-precheck-behavior|4.0.0"
            }
          },
          {
            "id": "PlanDefinition.action.cardinalityBehavior",
            "path": "PlanDefinition.action.cardinalityBehavior",
            "short": "single | multiple",
            "definition": "Defines whether the action can be selected multiple times.",
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
                  "valueString": "ActionCardinalityBehavior"
                }
              ],
              "strength": "required",
              "description": "Defines behavior for an action or a group for how many times that item may be repeated.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-cardinality-behavior|4.0.0"
            }
          },
          {
            "id": "PlanDefinition.action.definition[x]",
            "path": "PlanDefinition.action.definition[x]",
            "short": "Description of the activity to be performed",
            "definition": "A reference to an ActivityDefinition that describes the action to be taken in detail, or a PlanDefinition that describes a series of actions to be taken.",
            "comment": "Note that the definition is optional, and if no definition is specified, a dynamicValue with a root ($this) path can be used to define the entire resource dynamically.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                  "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                  "http://hl7.org/fhir/StructureDefinition/Questionnaire"
                ]
              },
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.transform",
            "path": "PlanDefinition.action.transform",
            "short": "Transform to apply the template",
            "definition": "A reference to a StructureMap resource that defines a transform that can be executed to produce the intent resource using the ActivityDefinition instance as the input.",
            "comment": "Note that when a referenced ActivityDefinition also defines a transform, the transform specified here generally takes precedence. In addition, if both a transform and dynamic values are specific, the dynamic values are applied to the result of the transform.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureMap"
                ]
              }
            ]
          },
          {
            "id": "PlanDefinition.action.dynamicValue",
            "path": "PlanDefinition.action.dynamicValue",
            "short": "Dynamic aspects of the definition",
            "definition": "Customizations that should be applied to the statically defined resource. For example, if the dosage of a medication must be computed based on the patient's weight, a customization would be used to specify an expression that calculated the weight, and the path on the resource that would contain the result.",
            "comment": "Dynamic values are applied in the order in which they are defined in the PlanDefinition resource. Note that when dynamic values are also specified by a referenced ActivityDefinition, the dynamicValues from the ActivityDefinition are applied first, followed by the dynamicValues specified here. In addition, if both a transform and dynamic values are specific, the dynamic values are applied to the result of the transform.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.dynamicValue.path",
            "path": "PlanDefinition.action.dynamicValue.path",
            "short": "The path to the element to be set dynamically",
            "definition": "The path to the element to be customized. This is the path on the resource that will hold the result of the calculation defined by the expression. The specified path SHALL be a FHIRPath resolveable on the specified target type of the ActivityDefinition, and SHALL consist only of identifiers, constant indexers, and a restricted subset of functions. The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details).",
            "comment": "To specify the path to the current action being realized, the %action environment variable is available in this path. For example, to specify the description element of the target action, the path would be %action.description. The path attribute contains a [Simple FHIRPath Subset](fhirpath.html#simple) that allows path traversal, but not calculation.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.dynamicValue.expression",
            "path": "PlanDefinition.action.dynamicValue.expression",
            "short": "An expression that provides the dynamic value for the customization",
            "definition": "An expression specifying the value of the customized element.",
            "comment": "The expression may be inlined or may be a reference to a named expression within a logic library referenced by the library element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Expression"
              }
            ]
          },
          {
            "id": "PlanDefinition.action.action",
            "path": "PlanDefinition.action.action",
            "short": "A sub-action",
            "definition": "Sub actions that are contained within the action. The behavior of this action determines the functionality of the sub-actions. For example, a selection behavior of at-most-one indicates that of the sub-actions, at most one may be chosen as part of realizing the action definition.",
            "min": 0,
            "max": "*",
            "contentReference": "#PlanDefinition.action"
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'PlanDefinition'
    /// </summary>
    // 0. PlanDefinition
    public class Resource_PlanDefinition : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 30. PlanDefinition.goal
        public class Type_Goal : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 37. PlanDefinition.goal.target
            public class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 38. PlanDefinition.goal.target.measure
                public ElementDefinitionInfo Element_Measure;
                // 39. PlanDefinition.goal.target.detail[x]
                public ElementDefinitionInfo Element_Detail;
                // 40. PlanDefinition.goal.target.due
                public ElementDefinitionInfo Element_Due;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "PlanDefinition.goal.target",
                        ElementId = "PlanDefinition.goal.target"
                    });
                    Element_Measure.Write(sDef);
                    Element_Detail.Write(sDef);
                    Element_Due.Write(sDef);
                }
                
                public Type_Target()
                {
                    {
                        // 38. PlanDefinition.goal.target.measure
                        this.Element_Measure = new ElementDefinitionInfo
                        {
                            Name = "Element_Measure",
                            Path= "PlanDefinition.goal.target.measure",
                            Id = "PlanDefinition.goal.target.measure",
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
                        // 39. PlanDefinition.goal.target.detail[x]
                        this.Element_Detail = new ElementDefinitionInfo
                        {
                            Name = "Element_Detail",
                            Path= "PlanDefinition.goal.target.detail[x]",
                            Id = "PlanDefinition.goal.target.detail[x]",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Quantity
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Range
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                                {
                                }
                            }
                        };
                    }
                    {
                        // 40. PlanDefinition.goal.target.due
                        this.Element_Due = new ElementDefinitionInfo
                        {
                            Name = "Element_Due",
                            Path= "PlanDefinition.goal.target.due",
                            Id = "PlanDefinition.goal.target.due",
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
                }
            }
            // 31. PlanDefinition.goal.category
            public ElementDefinitionInfo Element_Category;
            // 32. PlanDefinition.goal.description
            public ElementDefinitionInfo Element_Description;
            // 33. PlanDefinition.goal.priority
            public ElementDefinitionInfo Element_Priority;
            // 34. PlanDefinition.goal.start
            public ElementDefinitionInfo Element_Start;
            // 35. PlanDefinition.goal.addresses
            public ElementDefinitionInfo Element_Addresses;
            // 36. PlanDefinition.goal.documentation
            public ElementDefinitionInfo Element_Documentation;
            // 37. PlanDefinition.goal.target
            public ElementDefinitionInfo Element_Target;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "PlanDefinition.goal",
                    ElementId = "PlanDefinition.goal"
                });
                Element_Category.Write(sDef);
                Element_Description.Write(sDef);
                Element_Priority.Write(sDef);
                Element_Start.Write(sDef);
                Element_Addresses.Write(sDef);
                Element_Documentation.Write(sDef);
                Element_Target.Write(sDef);
            }
            
            public Type_Goal()
            {
                {
                    // 31. PlanDefinition.goal.category
                    this.Element_Category = new ElementDefinitionInfo
                    {
                        Name = "Element_Category",
                        Path= "PlanDefinition.goal.category",
                        Id = "PlanDefinition.goal.category",
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
                    // 32. PlanDefinition.goal.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "PlanDefinition.goal.description",
                        Id = "PlanDefinition.goal.description",
                        Min = 1,
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
                    // 33. PlanDefinition.goal.priority
                    this.Element_Priority = new ElementDefinitionInfo
                    {
                        Name = "Element_Priority",
                        Path= "PlanDefinition.goal.priority",
                        Id = "PlanDefinition.goal.priority",
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
                    // 34. PlanDefinition.goal.start
                    this.Element_Start = new ElementDefinitionInfo
                    {
                        Name = "Element_Start",
                        Path= "PlanDefinition.goal.start",
                        Id = "PlanDefinition.goal.start",
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
                    // 35. PlanDefinition.goal.addresses
                    this.Element_Addresses = new ElementDefinitionInfo
                    {
                        Name = "Element_Addresses",
                        Path= "PlanDefinition.goal.addresses",
                        Id = "PlanDefinition.goal.addresses",
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
                    // 36. PlanDefinition.goal.documentation
                    this.Element_Documentation = new ElementDefinitionInfo
                    {
                        Name = "Element_Documentation",
                        Path= "PlanDefinition.goal.documentation",
                        Id = "PlanDefinition.goal.documentation",
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
                    // 37. PlanDefinition.goal.target
                    this.Element_Target = new ElementDefinitionInfo
                    {
                        Name = "Element_Target",
                        Path= "PlanDefinition.goal.target",
                        Id = "PlanDefinition.goal.target",
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
        // 41. PlanDefinition.action
        public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 53. PlanDefinition.action.condition
            public class Type_Condition : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 54. PlanDefinition.action.condition.kind
                public ElementDefinitionInfo Element_Kind;
                // 55. PlanDefinition.action.condition.expression
                public ElementDefinitionInfo Element_Expression;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "PlanDefinition.action.condition",
                        ElementId = "PlanDefinition.action.condition"
                    });
                    Element_Kind.Write(sDef);
                    Element_Expression.Write(sDef);
                }
                
                public Type_Condition()
                {
                    {
                        // 54. PlanDefinition.action.condition.kind
                        this.Element_Kind = new ElementDefinitionInfo
                        {
                            Name = "Element_Kind",
                            Path= "PlanDefinition.action.condition.kind",
                            Id = "PlanDefinition.action.condition.kind",
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
                        // 55. PlanDefinition.action.condition.expression
                        this.Element_Expression = new ElementDefinitionInfo
                        {
                            Name = "Element_Expression",
                            Path= "PlanDefinition.action.condition.expression",
                            Id = "PlanDefinition.action.condition.expression",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Expression
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 58. PlanDefinition.action.relatedAction
            public class Type_RelatedAction : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 59. PlanDefinition.action.relatedAction.actionId
                public ElementDefinitionInfo Element_ActionId;
                // 60. PlanDefinition.action.relatedAction.relationship
                public ElementDefinitionInfo Element_Relationship;
                // 61. PlanDefinition.action.relatedAction.offset[x]
                public ElementDefinitionInfo Element_Offset;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "PlanDefinition.action.relatedAction",
                        ElementId = "PlanDefinition.action.relatedAction"
                    });
                    Element_ActionId.Write(sDef);
                    Element_Relationship.Write(sDef);
                    Element_Offset.Write(sDef);
                }
                
                public Type_RelatedAction()
                {
                    {
                        // 59. PlanDefinition.action.relatedAction.actionId
                        this.Element_ActionId = new ElementDefinitionInfo
                        {
                            Name = "Element_ActionId",
                            Path= "PlanDefinition.action.relatedAction.actionId",
                            Id = "PlanDefinition.action.relatedAction.actionId",
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
                        // 60. PlanDefinition.action.relatedAction.relationship
                        this.Element_Relationship = new ElementDefinitionInfo
                        {
                            Name = "Element_Relationship",
                            Path= "PlanDefinition.action.relatedAction.relationship",
                            Id = "PlanDefinition.action.relatedAction.relationship",
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
                        // 61. PlanDefinition.action.relatedAction.offset[x]
                        this.Element_Offset = new ElementDefinitionInfo
                        {
                            Name = "Element_Offset",
                            Path= "PlanDefinition.action.relatedAction.offset[x]",
                            Id = "PlanDefinition.action.relatedAction.offset[x]",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Duration
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Range
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 63. PlanDefinition.action.participant
            public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 64. PlanDefinition.action.participant.type
                public ElementDefinitionInfo Element_Type;
                // 65. PlanDefinition.action.participant.role
                public ElementDefinitionInfo Element_Role;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "PlanDefinition.action.participant",
                        ElementId = "PlanDefinition.action.participant"
                    });
                    Element_Type.Write(sDef);
                    Element_Role.Write(sDef);
                }
                
                public Type_Participant()
                {
                    {
                        // 64. PlanDefinition.action.participant.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "PlanDefinition.action.participant.type",
                            Id = "PlanDefinition.action.participant.type",
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
                        // 65. PlanDefinition.action.participant.role
                        this.Element_Role = new ElementDefinitionInfo
                        {
                            Name = "Element_Role",
                            Path= "PlanDefinition.action.participant.role",
                            Id = "PlanDefinition.action.participant.role",
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
                }
            }
            // 74. PlanDefinition.action.dynamicValue
            public class Type_DynamicValue : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 75. PlanDefinition.action.dynamicValue.path
                public ElementDefinitionInfo Element_Path;
                // 76. PlanDefinition.action.dynamicValue.expression
                public ElementDefinitionInfo Element_Expression;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "PlanDefinition.action.dynamicValue",
                        ElementId = "PlanDefinition.action.dynamicValue"
                    });
                    Element_Path.Write(sDef);
                    Element_Expression.Write(sDef);
                }
                
                public Type_DynamicValue()
                {
                    {
                        // 75. PlanDefinition.action.dynamicValue.path
                        this.Element_Path = new ElementDefinitionInfo
                        {
                            Name = "Element_Path",
                            Path= "PlanDefinition.action.dynamicValue.path",
                            Id = "PlanDefinition.action.dynamicValue.path",
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
                        // 76. PlanDefinition.action.dynamicValue.expression
                        this.Element_Expression = new ElementDefinitionInfo
                        {
                            Name = "Element_Expression",
                            Path= "PlanDefinition.action.dynamicValue.expression",
                            Id = "PlanDefinition.action.dynamicValue.expression",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Expression
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 42. PlanDefinition.action.prefix
            public ElementDefinitionInfo Element_Prefix;
            // 43. PlanDefinition.action.title
            public ElementDefinitionInfo Element_Title;
            // 44. PlanDefinition.action.description
            public ElementDefinitionInfo Element_Description;
            // 45. PlanDefinition.action.textEquivalent
            public ElementDefinitionInfo Element_TextEquivalent;
            // 46. PlanDefinition.action.priority
            public ElementDefinitionInfo Element_Priority;
            // 47. PlanDefinition.action.code
            public ElementDefinitionInfo Element_Code;
            // 48. PlanDefinition.action.reason
            public ElementDefinitionInfo Element_Reason;
            // 49. PlanDefinition.action.documentation
            public ElementDefinitionInfo Element_Documentation;
            // 50. PlanDefinition.action.goalId
            public ElementDefinitionInfo Element_GoalId;
            // 51. PlanDefinition.action.subject[x]
            public ElementDefinitionInfo Element_Subject;
            // 52. PlanDefinition.action.trigger
            public ElementDefinitionInfo Element_Trigger;
            // 53. PlanDefinition.action.condition
            public ElementDefinitionInfo Element_Condition;
            // 56. PlanDefinition.action.input
            public ElementDefinitionInfo Element_Input;
            // 57. PlanDefinition.action.output
            public ElementDefinitionInfo Element_Output;
            // 58. PlanDefinition.action.relatedAction
            public ElementDefinitionInfo Element_RelatedAction;
            // 62. PlanDefinition.action.timing[x]
            public ElementDefinitionInfo Element_Timing;
            // 63. PlanDefinition.action.participant
            public ElementDefinitionInfo Element_Participant;
            // 66. PlanDefinition.action.type
            public ElementDefinitionInfo Element_Type;
            // 67. PlanDefinition.action.groupingBehavior
            public ElementDefinitionInfo Element_GroupingBehavior;
            // 68. PlanDefinition.action.selectionBehavior
            public ElementDefinitionInfo Element_SelectionBehavior;
            // 69. PlanDefinition.action.requiredBehavior
            public ElementDefinitionInfo Element_RequiredBehavior;
            // 70. PlanDefinition.action.precheckBehavior
            public ElementDefinitionInfo Element_PrecheckBehavior;
            // 71. PlanDefinition.action.cardinalityBehavior
            public ElementDefinitionInfo Element_CardinalityBehavior;
            // 72. PlanDefinition.action.definition[x]
            public ElementDefinitionInfo Element_Definition;
            // 73. PlanDefinition.action.transform
            public ElementDefinitionInfo Element_Transform;
            // 74. PlanDefinition.action.dynamicValue
            public ElementDefinitionInfo Element_DynamicValue;
            // 77. PlanDefinition.action.action
            public ElementDefinitionInfo Element_Action;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "PlanDefinition.action",
                    ElementId = "PlanDefinition.action"
                });
                Element_Prefix.Write(sDef);
                Element_Title.Write(sDef);
                Element_Description.Write(sDef);
                Element_TextEquivalent.Write(sDef);
                Element_Priority.Write(sDef);
                Element_Code.Write(sDef);
                Element_Reason.Write(sDef);
                Element_Documentation.Write(sDef);
                Element_GoalId.Write(sDef);
                Element_Subject.Write(sDef);
                Element_Trigger.Write(sDef);
                Element_Condition.Write(sDef);
                Element_Input.Write(sDef);
                Element_Output.Write(sDef);
                Element_RelatedAction.Write(sDef);
                Element_Timing.Write(sDef);
                Element_Participant.Write(sDef);
                Element_Type.Write(sDef);
                Element_GroupingBehavior.Write(sDef);
                Element_SelectionBehavior.Write(sDef);
                Element_RequiredBehavior.Write(sDef);
                Element_PrecheckBehavior.Write(sDef);
                Element_CardinalityBehavior.Write(sDef);
                Element_Definition.Write(sDef);
                Element_Transform.Write(sDef);
                Element_DynamicValue.Write(sDef);
                Element_Action.Write(sDef);
            }
            
            public Type_Action()
            {
                {
                    // 42. PlanDefinition.action.prefix
                    this.Element_Prefix = new ElementDefinitionInfo
                    {
                        Name = "Element_Prefix",
                        Path= "PlanDefinition.action.prefix",
                        Id = "PlanDefinition.action.prefix",
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
                    // 43. PlanDefinition.action.title
                    this.Element_Title = new ElementDefinitionInfo
                    {
                        Name = "Element_Title",
                        Path= "PlanDefinition.action.title",
                        Id = "PlanDefinition.action.title",
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
                    // 44. PlanDefinition.action.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "PlanDefinition.action.description",
                        Id = "PlanDefinition.action.description",
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
                    // 45. PlanDefinition.action.textEquivalent
                    this.Element_TextEquivalent = new ElementDefinitionInfo
                    {
                        Name = "Element_TextEquivalent",
                        Path= "PlanDefinition.action.textEquivalent",
                        Id = "PlanDefinition.action.textEquivalent",
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
                    // 46. PlanDefinition.action.priority
                    this.Element_Priority = new ElementDefinitionInfo
                    {
                        Name = "Element_Priority",
                        Path= "PlanDefinition.action.priority",
                        Id = "PlanDefinition.action.priority",
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
                    // 47. PlanDefinition.action.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "PlanDefinition.action.code",
                        Id = "PlanDefinition.action.code",
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
                    // 48. PlanDefinition.action.reason
                    this.Element_Reason = new ElementDefinitionInfo
                    {
                        Name = "Element_Reason",
                        Path= "PlanDefinition.action.reason",
                        Id = "PlanDefinition.action.reason",
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
                    // 49. PlanDefinition.action.documentation
                    this.Element_Documentation = new ElementDefinitionInfo
                    {
                        Name = "Element_Documentation",
                        Path= "PlanDefinition.action.documentation",
                        Id = "PlanDefinition.action.documentation",
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
                    // 50. PlanDefinition.action.goalId
                    this.Element_GoalId = new ElementDefinitionInfo
                    {
                        Name = "Element_GoalId",
                        Path= "PlanDefinition.action.goalId",
                        Id = "PlanDefinition.action.goalId",
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
                    // 51. PlanDefinition.action.subject[x]
                    this.Element_Subject = new ElementDefinitionInfo
                    {
                        Name = "Element_Subject",
                        Path= "PlanDefinition.action.subject[x]",
                        Id = "PlanDefinition.action.subject[x]",
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
                    // 52. PlanDefinition.action.trigger
                    this.Element_Trigger = new ElementDefinitionInfo
                    {
                        Name = "Element_Trigger",
                        Path= "PlanDefinition.action.trigger",
                        Id = "PlanDefinition.action.trigger",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_TriggerDefinition
                            {
                            }
                        }
                    };
                }
                {
                    // 53. PlanDefinition.action.condition
                    this.Element_Condition = new ElementDefinitionInfo
                    {
                        Name = "Element_Condition",
                        Path= "PlanDefinition.action.condition",
                        Id = "PlanDefinition.action.condition",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Condition
                            {
                            }
                        }
                    };
                }
                {
                    // 56. PlanDefinition.action.input
                    this.Element_Input = new ElementDefinitionInfo
                    {
                        Name = "Element_Input",
                        Path= "PlanDefinition.action.input",
                        Id = "PlanDefinition.action.input",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_DataRequirement
                            {
                            }
                        }
                    };
                }
                {
                    // 57. PlanDefinition.action.output
                    this.Element_Output = new ElementDefinitionInfo
                    {
                        Name = "Element_Output",
                        Path= "PlanDefinition.action.output",
                        Id = "PlanDefinition.action.output",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_DataRequirement
                            {
                            }
                        }
                    };
                }
                {
                    // 58. PlanDefinition.action.relatedAction
                    this.Element_RelatedAction = new ElementDefinitionInfo
                    {
                        Name = "Element_RelatedAction",
                        Path= "PlanDefinition.action.relatedAction",
                        Id = "PlanDefinition.action.relatedAction",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_RelatedAction
                            {
                            }
                        }
                    };
                }
                {
                    // 62. PlanDefinition.action.timing[x]
                    this.Element_Timing = new ElementDefinitionInfo
                    {
                        Name = "Element_Timing",
                        Path= "PlanDefinition.action.timing[x]",
                        Id = "PlanDefinition.action.timing[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Age
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Timing
                            {
                            }
                        }
                    };
                }
                {
                    // 63. PlanDefinition.action.participant
                    this.Element_Participant = new ElementDefinitionInfo
                    {
                        Name = "Element_Participant",
                        Path= "PlanDefinition.action.participant",
                        Id = "PlanDefinition.action.participant",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Participant
                            {
                            }
                        }
                    };
                }
                {
                    // 66. PlanDefinition.action.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "PlanDefinition.action.type",
                        Id = "PlanDefinition.action.type",
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
                    // 67. PlanDefinition.action.groupingBehavior
                    this.Element_GroupingBehavior = new ElementDefinitionInfo
                    {
                        Name = "Element_GroupingBehavior",
                        Path= "PlanDefinition.action.groupingBehavior",
                        Id = "PlanDefinition.action.groupingBehavior",
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
                    // 68. PlanDefinition.action.selectionBehavior
                    this.Element_SelectionBehavior = new ElementDefinitionInfo
                    {
                        Name = "Element_SelectionBehavior",
                        Path= "PlanDefinition.action.selectionBehavior",
                        Id = "PlanDefinition.action.selectionBehavior",
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
                    // 69. PlanDefinition.action.requiredBehavior
                    this.Element_RequiredBehavior = new ElementDefinitionInfo
                    {
                        Name = "Element_RequiredBehavior",
                        Path= "PlanDefinition.action.requiredBehavior",
                        Id = "PlanDefinition.action.requiredBehavior",
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
                    // 70. PlanDefinition.action.precheckBehavior
                    this.Element_PrecheckBehavior = new ElementDefinitionInfo
                    {
                        Name = "Element_PrecheckBehavior",
                        Path= "PlanDefinition.action.precheckBehavior",
                        Id = "PlanDefinition.action.precheckBehavior",
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
                    // 71. PlanDefinition.action.cardinalityBehavior
                    this.Element_CardinalityBehavior = new ElementDefinitionInfo
                    {
                        Name = "Element_CardinalityBehavior",
                        Path= "PlanDefinition.action.cardinalityBehavior",
                        Id = "PlanDefinition.action.cardinalityBehavior",
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
                    // 72. PlanDefinition.action.definition[x]
                    this.Element_Definition = new ElementDefinitionInfo
                    {
                        Name = "Element_Definition",
                        Path= "PlanDefinition.action.definition[x]",
                        Id = "PlanDefinition.action.definition[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
                                    "http://hl7.org/fhir/StructureDefinition/PlanDefinition",
                                    "http://hl7.org/fhir/StructureDefinition/Questionnaire"
                                }
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                            {
                            }
                        }
                    };
                }
                {
                    // 73. PlanDefinition.action.transform
                    this.Element_Transform = new ElementDefinitionInfo
                    {
                        Name = "Element_Transform",
                        Path= "PlanDefinition.action.transform",
                        Id = "PlanDefinition.action.transform",
                        Min = 0,
                        Max = 1,
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
                    // 74. PlanDefinition.action.dynamicValue
                    this.Element_DynamicValue = new ElementDefinitionInfo
                    {
                        Name = "Element_DynamicValue",
                        Path= "PlanDefinition.action.dynamicValue",
                        Id = "PlanDefinition.action.dynamicValue",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_DynamicValue
                            {
                            }
                        }
                    };
                }
                {
                    // 77. PlanDefinition.action.action
                    this.Element_Action = new ElementDefinitionInfo
                    {
                        Name = "Element_Action",
                        Path= "PlanDefinition.action.action",
                        Id = "PlanDefinition.action.action",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
            }
        }
        // 1. PlanDefinition.url
        public ElementDefinitionInfo Element_Url;
        // 2. PlanDefinition.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. PlanDefinition.version
        public ElementDefinitionInfo Element_Version;
        // 4. PlanDefinition.name
        public ElementDefinitionInfo Element_Name;
        // 5. PlanDefinition.title
        public ElementDefinitionInfo Element_Title;
        // 6. PlanDefinition.subtitle
        public ElementDefinitionInfo Element_Subtitle;
        // 7. PlanDefinition.type
        public ElementDefinitionInfo Element_Type;
        // 8. PlanDefinition.status
        public ElementDefinitionInfo Element_Status;
        // 9. PlanDefinition.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 10. PlanDefinition.subject[x]
        public ElementDefinitionInfo Element_Subject;
        // 11. PlanDefinition.date
        public ElementDefinitionInfo Element_Date;
        // 12. PlanDefinition.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 13. PlanDefinition.contact
        public ElementDefinitionInfo Element_Contact;
        // 14. PlanDefinition.description
        public ElementDefinitionInfo Element_Description;
        // 15. PlanDefinition.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 16. PlanDefinition.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 17. PlanDefinition.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 18. PlanDefinition.usage
        public ElementDefinitionInfo Element_Usage;
        // 19. PlanDefinition.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 20. PlanDefinition.approvalDate
        public ElementDefinitionInfo Element_ApprovalDate;
        // 21. PlanDefinition.lastReviewDate
        public ElementDefinitionInfo Element_LastReviewDate;
        // 22. PlanDefinition.effectivePeriod
        public ElementDefinitionInfo Element_EffectivePeriod;
        // 23. PlanDefinition.topic
        public ElementDefinitionInfo Element_Topic;
        // 24. PlanDefinition.author
        public ElementDefinitionInfo Element_Author;
        // 25. PlanDefinition.editor
        public ElementDefinitionInfo Element_Editor;
        // 26. PlanDefinition.reviewer
        public ElementDefinitionInfo Element_Reviewer;
        // 27. PlanDefinition.endorser
        public ElementDefinitionInfo Element_Endorser;
        // 28. PlanDefinition.relatedArtifact
        public ElementDefinitionInfo Element_RelatedArtifact;
        // 29. PlanDefinition.library
        public ElementDefinitionInfo Element_Library;
        // 30. PlanDefinition.goal
        public ElementDefinitionInfo Element_Goal;
        // 41. PlanDefinition.action
        public ElementDefinitionInfo Element_Action;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "PlanDefinition",
                ElementId = "PlanDefinition"
            });
            Element_Url.Write(sDef);
            Element_Identifier.Write(sDef);
            Element_Version.Write(sDef);
            Element_Name.Write(sDef);
            Element_Title.Write(sDef);
            Element_Subtitle.Write(sDef);
            Element_Type.Write(sDef);
            Element_Status.Write(sDef);
            Element_Experimental.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Date.Write(sDef);
            Element_Publisher.Write(sDef);
            Element_Contact.Write(sDef);
            Element_Description.Write(sDef);
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
            Element_Goal.Write(sDef);
            Element_Action.Write(sDef);
        }
        
        public Resource_PlanDefinition()
        {
            {
                // 1. PlanDefinition.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "PlanDefinition.url",
                    Id = "PlanDefinition.url",
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
                // 2. PlanDefinition.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "PlanDefinition.identifier",
                    Id = "PlanDefinition.identifier",
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
                // 3. PlanDefinition.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "PlanDefinition.version",
                    Id = "PlanDefinition.version",
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
                // 4. PlanDefinition.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "PlanDefinition.name",
                    Id = "PlanDefinition.name",
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
                // 5. PlanDefinition.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "PlanDefinition.title",
                    Id = "PlanDefinition.title",
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
                // 6. PlanDefinition.subtitle
                this.Element_Subtitle = new ElementDefinitionInfo
                {
                    Name = "Element_Subtitle",
                    Path= "PlanDefinition.subtitle",
                    Id = "PlanDefinition.subtitle",
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
                // 7. PlanDefinition.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "PlanDefinition.type",
                    Id = "PlanDefinition.type",
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
                // 8. PlanDefinition.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "PlanDefinition.status",
                    Id = "PlanDefinition.status",
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
                // 9. PlanDefinition.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "PlanDefinition.experimental",
                    Id = "PlanDefinition.experimental",
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
                // 10. PlanDefinition.subject[x]
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "PlanDefinition.subject[x]",
                    Id = "PlanDefinition.subject[x]",
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
                // 11. PlanDefinition.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "PlanDefinition.date",
                    Id = "PlanDefinition.date",
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
                // 12. PlanDefinition.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "PlanDefinition.publisher",
                    Id = "PlanDefinition.publisher",
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
                // 13. PlanDefinition.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "PlanDefinition.contact",
                    Id = "PlanDefinition.contact",
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
                // 14. PlanDefinition.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "PlanDefinition.description",
                    Id = "PlanDefinition.description",
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
                // 15. PlanDefinition.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "PlanDefinition.useContext",
                    Id = "PlanDefinition.useContext",
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
                // 16. PlanDefinition.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "PlanDefinition.jurisdiction",
                    Id = "PlanDefinition.jurisdiction",
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
                // 17. PlanDefinition.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "PlanDefinition.purpose",
                    Id = "PlanDefinition.purpose",
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
                // 18. PlanDefinition.usage
                this.Element_Usage = new ElementDefinitionInfo
                {
                    Name = "Element_Usage",
                    Path= "PlanDefinition.usage",
                    Id = "PlanDefinition.usage",
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
                // 19. PlanDefinition.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "PlanDefinition.copyright",
                    Id = "PlanDefinition.copyright",
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
                // 20. PlanDefinition.approvalDate
                this.Element_ApprovalDate = new ElementDefinitionInfo
                {
                    Name = "Element_ApprovalDate",
                    Path= "PlanDefinition.approvalDate",
                    Id = "PlanDefinition.approvalDate",
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
                // 21. PlanDefinition.lastReviewDate
                this.Element_LastReviewDate = new ElementDefinitionInfo
                {
                    Name = "Element_LastReviewDate",
                    Path= "PlanDefinition.lastReviewDate",
                    Id = "PlanDefinition.lastReviewDate",
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
                // 22. PlanDefinition.effectivePeriod
                this.Element_EffectivePeriod = new ElementDefinitionInfo
                {
                    Name = "Element_EffectivePeriod",
                    Path= "PlanDefinition.effectivePeriod",
                    Id = "PlanDefinition.effectivePeriod",
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
                // 23. PlanDefinition.topic
                this.Element_Topic = new ElementDefinitionInfo
                {
                    Name = "Element_Topic",
                    Path= "PlanDefinition.topic",
                    Id = "PlanDefinition.topic",
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
                // 24. PlanDefinition.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "PlanDefinition.author",
                    Id = "PlanDefinition.author",
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
                // 25. PlanDefinition.editor
                this.Element_Editor = new ElementDefinitionInfo
                {
                    Name = "Element_Editor",
                    Path= "PlanDefinition.editor",
                    Id = "PlanDefinition.editor",
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
                // 26. PlanDefinition.reviewer
                this.Element_Reviewer = new ElementDefinitionInfo
                {
                    Name = "Element_Reviewer",
                    Path= "PlanDefinition.reviewer",
                    Id = "PlanDefinition.reviewer",
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
                // 27. PlanDefinition.endorser
                this.Element_Endorser = new ElementDefinitionInfo
                {
                    Name = "Element_Endorser",
                    Path= "PlanDefinition.endorser",
                    Id = "PlanDefinition.endorser",
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
                // 28. PlanDefinition.relatedArtifact
                this.Element_RelatedArtifact = new ElementDefinitionInfo
                {
                    Name = "Element_RelatedArtifact",
                    Path= "PlanDefinition.relatedArtifact",
                    Id = "PlanDefinition.relatedArtifact",
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
                // 29. PlanDefinition.library
                this.Element_Library = new ElementDefinitionInfo
                {
                    Name = "Element_Library",
                    Path= "PlanDefinition.library",
                    Id = "PlanDefinition.library",
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
                // 30. PlanDefinition.goal
                this.Element_Goal = new ElementDefinitionInfo
                {
                    Name = "Element_Goal",
                    Path= "PlanDefinition.goal",
                    Id = "PlanDefinition.goal",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Goal
                        {
                        }
                    }
                };
            }
            {
                // 41. PlanDefinition.action
                this.Element_Action = new ElementDefinitionInfo
                {
                    Name = "Element_Action",
                    Path= "PlanDefinition.action",
                    Id = "PlanDefinition.action",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Action
                        {
                        }
                    }
                };
            }
            this.Name = "PlanDefinition";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/PlanDefinition";
        }
    }
}
