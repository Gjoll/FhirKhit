using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
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
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'PlanDefinition'
    /// </summary>
    // 0. PlanDefinition
    public class PlanDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                                               // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class PlanDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                  // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 30. PlanDefinition.goal
            public class Type_Goal : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Goal_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 37. PlanDefinition.goal.target
                    public class Type_Target : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Target_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 38. PlanDefinition.goal.target.measure
                            public ElementDefinitionInfo Measure;                                                                           // MakerGen.cs:211
                            // 39. PlanDefinition.goal.target.detail[x]
                            public ElementDefinitionInfo Detail;                                                                            // MakerGen.cs:211
                            // 40. PlanDefinition.goal.target.due
                            public ElementDefinitionInfo Due;                                                                               // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Target_Elements()                                                                                   // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 38. PlanDefinition.goal.target.measure
                                    this.Measure = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Measure",                                                                                   // MakerGen.cs:230
                                        Path= "PlanDefinition.goal.target.measure",                                                         // MakerGen.cs:231
                                        Id = "PlanDefinition.goal.target.measure",                                                          // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 39. PlanDefinition.goal.target.detail[x]
                                    this.Detail = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Detail",                                                                                    // MakerGen.cs:230
                                        Path= "PlanDefinition.goal.target.detail[x]",                                                       // MakerGen.cs:231
                                        Id = "PlanDefinition.goal.target.detail[x]",                                                        // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            },                                                                                              // MakerGen.cs:355
                                            new FhirKhit.Maker.Common.Complex.Range                                                         // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            },                                                                                              // MakerGen.cs:355
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 40. PlanDefinition.goal.target.due
                                    this.Due = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Due",                                                                                       // MakerGen.cs:230
                                        Path= "PlanDefinition.goal.target.due",                                                             // MakerGen.cs:231
                                        Id = "PlanDefinition.goal.target.due",                                                              // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Duration                                                      // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Measure.Write(sDef);                                                                                        // MakerGen.cs:215
                                Detail.Write(sDef);                                                                                         // MakerGen.cs:215
                                Due.Write(sDef);                                                                                            // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Target_Elements Elements                                                                                // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Target_Elements();                                                             // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Target_Elements elements;                                                                                      // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Target()                                                                                                // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "PlanDefinition.goal.target",                                                                        // MakerGen.cs:423
                                ElementId = "PlanDefinition.goal.target"                                                                    // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 31. PlanDefinition.goal.category
                    public ElementDefinitionInfo Category;                                                                                  // MakerGen.cs:211
                    // 32. PlanDefinition.goal.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:211
                    // 33. PlanDefinition.goal.priority
                    public ElementDefinitionInfo Priority;                                                                                  // MakerGen.cs:211
                    // 34. PlanDefinition.goal.start
                    public ElementDefinitionInfo Start;                                                                                     // MakerGen.cs:211
                    // 35. PlanDefinition.goal.addresses
                    public ElementDefinitionInfo Addresses;                                                                                 // MakerGen.cs:211
                    // 36. PlanDefinition.goal.documentation
                    public ElementDefinitionInfo Documentation;                                                                             // MakerGen.cs:211
                    // 37. PlanDefinition.goal.target
                    public ElementDefinitionInfo Target;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Goal_Elements()                                                                                             // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 31. PlanDefinition.goal.category
                            this.Category = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Category",                                                                                          // MakerGen.cs:230
                                Path= "PlanDefinition.goal.category",                                                                       // MakerGen.cs:231
                                Id = "PlanDefinition.goal.category",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 32. PlanDefinition.goal.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Description",                                                                                       // MakerGen.cs:230
                                Path= "PlanDefinition.goal.description",                                                                    // MakerGen.cs:231
                                Id = "PlanDefinition.goal.description",                                                                     // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 33. PlanDefinition.goal.priority
                            this.Priority = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Priority",                                                                                          // MakerGen.cs:230
                                Path= "PlanDefinition.goal.priority",                                                                       // MakerGen.cs:231
                                Id = "PlanDefinition.goal.priority",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 34. PlanDefinition.goal.start
                            this.Start = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Start",                                                                                             // MakerGen.cs:230
                                Path= "PlanDefinition.goal.start",                                                                          // MakerGen.cs:231
                                Id = "PlanDefinition.goal.start",                                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 35. PlanDefinition.goal.addresses
                            this.Addresses = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Addresses",                                                                                         // MakerGen.cs:230
                                Path= "PlanDefinition.goal.addresses",                                                                      // MakerGen.cs:231
                                Id = "PlanDefinition.goal.addresses",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 36. PlanDefinition.goal.documentation
                            this.Documentation = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Documentation",                                                                                     // MakerGen.cs:230
                                Path= "PlanDefinition.goal.documentation",                                                                  // MakerGen.cs:231
                                Id = "PlanDefinition.goal.documentation",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.RelatedArtifact                                                       // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 37. PlanDefinition.goal.target
                            this.Target = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Target",                                                                                            // MakerGen.cs:230
                                Path= "PlanDefinition.goal.target",                                                                         // MakerGen.cs:231
                                Id = "PlanDefinition.goal.target",                                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Target                                                                                         // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Category.Write(sDef);                                                                                               // MakerGen.cs:215
                        Description.Write(sDef);                                                                                            // MakerGen.cs:215
                        Priority.Write(sDef);                                                                                               // MakerGen.cs:215
                        Start.Write(sDef);                                                                                                  // MakerGen.cs:215
                        Addresses.Write(sDef);                                                                                              // MakerGen.cs:215
                        Documentation.Write(sDef);                                                                                          // MakerGen.cs:215
                        Target.Write(sDef);                                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Goal_Elements Elements                                                                                          // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Goal_Elements();                                                                       // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Goal_Elements elements;                                                                                                // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Goal()                                                                                                          // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "PlanDefinition.goal",                                                                                       // MakerGen.cs:423
                        ElementId = "PlanDefinition.goal"                                                                                   // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 41. PlanDefinition.action
            public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Action_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 53. PlanDefinition.action.condition
                    public class Type_Condition : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Condition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 54. PlanDefinition.action.condition.kind
                            public ElementDefinitionInfo Kind;                                                                              // MakerGen.cs:211
                            // 55. PlanDefinition.action.condition.expression
                            public ElementDefinitionInfo Expression;                                                                        // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Condition_Elements()                                                                                // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 54. PlanDefinition.action.condition.kind
                                    this.Kind = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Kind",                                                                                      // MakerGen.cs:230
                                        Path= "PlanDefinition.action.condition.kind",                                                       // MakerGen.cs:231
                                        Id = "PlanDefinition.action.condition.kind",                                                        // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 55. PlanDefinition.action.condition.expression
                                    this.Expression = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Expression",                                                                                // MakerGen.cs:230
                                        Path= "PlanDefinition.action.condition.expression",                                                 // MakerGen.cs:231
                                        Id = "PlanDefinition.action.condition.expression",                                                  // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Expression                                                    // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Kind.Write(sDef);                                                                                           // MakerGen.cs:215
                                Expression.Write(sDef);                                                                                     // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Condition_Elements Elements                                                                             // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Condition_Elements();                                                          // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Condition_Elements elements;                                                                                   // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Condition()                                                                                             // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "PlanDefinition.action.condition",                                                                   // MakerGen.cs:423
                                ElementId = "PlanDefinition.action.condition"                                                               // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 58. PlanDefinition.action.relatedAction
                    public class Type_RelatedAction : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_RelatedAction_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                              // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 59. PlanDefinition.action.relatedAction.actionId
                            public ElementDefinitionInfo ActionId;                                                                          // MakerGen.cs:211
                            // 60. PlanDefinition.action.relatedAction.relationship
                            public ElementDefinitionInfo Relationship;                                                                      // MakerGen.cs:211
                            // 61. PlanDefinition.action.relatedAction.offset[x]
                            public ElementDefinitionInfo Offset;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_RelatedAction_Elements()                                                                            // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 59. PlanDefinition.action.relatedAction.actionId
                                    this.ActionId = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "ActionId",                                                                                  // MakerGen.cs:230
                                        Path= "PlanDefinition.action.relatedAction.actionId",                                               // MakerGen.cs:231
                                        Id = "PlanDefinition.action.relatedAction.actionId",                                                // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Id                                                          // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 60. PlanDefinition.action.relatedAction.relationship
                                    this.Relationship = new ElementDefinitionInfo                                                           // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Relationship",                                                                              // MakerGen.cs:230
                                        Path= "PlanDefinition.action.relatedAction.relationship",                                           // MakerGen.cs:231
                                        Id = "PlanDefinition.action.relatedAction.relationship",                                            // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 61. PlanDefinition.action.relatedAction.offset[x]
                                    this.Offset = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Offset",                                                                                    // MakerGen.cs:230
                                        Path= "PlanDefinition.action.relatedAction.offset[x]",                                              // MakerGen.cs:231
                                        Id = "PlanDefinition.action.relatedAction.offset[x]",                                               // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Duration                                                      // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            },                                                                                              // MakerGen.cs:355
                                            new FhirKhit.Maker.Common.Complex.Range                                                         // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                ActionId.Write(sDef);                                                                                       // MakerGen.cs:215
                                Relationship.Write(sDef);                                                                                   // MakerGen.cs:215
                                Offset.Write(sDef);                                                                                         // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_RelatedAction_Elements Elements                                                                         // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_RelatedAction_Elements();                                                      // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_RelatedAction_Elements elements;                                                                               // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_RelatedAction()                                                                                         // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "PlanDefinition.action.relatedAction",                                                               // MakerGen.cs:423
                                ElementId = "PlanDefinition.action.relatedAction"                                                           // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 63. PlanDefinition.action.participant
                    public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase                                               // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Participant_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 64. PlanDefinition.action.participant.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:211
                            // 65. PlanDefinition.action.participant.role
                            public ElementDefinitionInfo Role;                                                                              // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Participant_Elements()                                                                              // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 64. PlanDefinition.action.participant.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Type",                                                                                      // MakerGen.cs:230
                                        Path= "PlanDefinition.action.participant.type",                                                     // MakerGen.cs:231
                                        Id = "PlanDefinition.action.participant.type",                                                      // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 65. PlanDefinition.action.participant.role
                                    this.Role = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Role",                                                                                      // MakerGen.cs:230
                                        Path= "PlanDefinition.action.participant.role",                                                     // MakerGen.cs:231
                                        Id = "PlanDefinition.action.participant.role",                                                      // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            }                                                                                               // MakerGen.cs:314
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Type.Write(sDef);                                                                                           // MakerGen.cs:215
                                Role.Write(sDef);                                                                                           // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Participant_Elements Elements                                                                           // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Participant_Elements();                                                        // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Participant_Elements elements;                                                                                 // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Participant()                                                                                           // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "PlanDefinition.action.participant",                                                                 // MakerGen.cs:423
                                ElementId = "PlanDefinition.action.participant"                                                             // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 74. PlanDefinition.action.dynamicValue
                    public class Type_DynamicValue : FhirKhit.Maker.Common.Complex.ComplexBase                                              // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_DynamicValue_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                               // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 75. PlanDefinition.action.dynamicValue.path
                            public ElementDefinitionInfo Path;                                                                              // MakerGen.cs:211
                            // 76. PlanDefinition.action.dynamicValue.expression
                            public ElementDefinitionInfo Expression;                                                                        // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_DynamicValue_Elements()                                                                             // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 75. PlanDefinition.action.dynamicValue.path
                                    this.Path = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Path",                                                                                      // MakerGen.cs:230
                                        Path= "PlanDefinition.action.dynamicValue.path",                                                    // MakerGen.cs:231
                                        Id = "PlanDefinition.action.dynamicValue.path",                                                     // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 76. PlanDefinition.action.dynamicValue.expression
                                    this.Expression = new ElementDefinitionInfo                                                             // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Expression",                                                                                // MakerGen.cs:230
                                        Path= "PlanDefinition.action.dynamicValue.expression",                                              // MakerGen.cs:231
                                        Id = "PlanDefinition.action.dynamicValue.expression",                                               // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Complex.Expression                                                    // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            }                                                                                               // MakerGen.cs:355
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Path.Write(sDef);                                                                                           // MakerGen.cs:215
                                Expression.Write(sDef);                                                                                     // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_DynamicValue_Elements Elements                                                                          // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_DynamicValue_Elements();                                                       // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_DynamicValue_Elements elements;                                                                                // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_DynamicValue()                                                                                          // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "PlanDefinition.action.dynamicValue",                                                                // MakerGen.cs:423
                                ElementId = "PlanDefinition.action.dynamicValue"                                                            // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 42. PlanDefinition.action.prefix
                    public ElementDefinitionInfo Prefix;                                                                                    // MakerGen.cs:211
                    // 43. PlanDefinition.action.title
                    public ElementDefinitionInfo Title;                                                                                     // MakerGen.cs:211
                    // 44. PlanDefinition.action.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:211
                    // 45. PlanDefinition.action.textEquivalent
                    public ElementDefinitionInfo TextEquivalent;                                                                            // MakerGen.cs:211
                    // 46. PlanDefinition.action.priority
                    public ElementDefinitionInfo Priority;                                                                                  // MakerGen.cs:211
                    // 47. PlanDefinition.action.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:211
                    // 48. PlanDefinition.action.reason
                    public ElementDefinitionInfo Reason;                                                                                    // MakerGen.cs:211
                    // 49. PlanDefinition.action.documentation
                    public ElementDefinitionInfo Documentation;                                                                             // MakerGen.cs:211
                    // 50. PlanDefinition.action.goalId
                    public ElementDefinitionInfo GoalId;                                                                                    // MakerGen.cs:211
                    // 51. PlanDefinition.action.subject[x]
                    public ElementDefinitionInfo Subject;                                                                                   // MakerGen.cs:211
                    // 52. PlanDefinition.action.trigger
                    public ElementDefinitionInfo Trigger;                                                                                   // MakerGen.cs:211
                    // 53. PlanDefinition.action.condition
                    public ElementDefinitionInfo Condition;                                                                                 // MakerGen.cs:211
                    // 56. PlanDefinition.action.input
                    public ElementDefinitionInfo Input;                                                                                     // MakerGen.cs:211
                    // 57. PlanDefinition.action.output
                    public ElementDefinitionInfo Output;                                                                                    // MakerGen.cs:211
                    // 58. PlanDefinition.action.relatedAction
                    public ElementDefinitionInfo RelatedAction;                                                                             // MakerGen.cs:211
                    // 62. PlanDefinition.action.timing[x]
                    public ElementDefinitionInfo Timing;                                                                                    // MakerGen.cs:211
                    // 63. PlanDefinition.action.participant
                    public ElementDefinitionInfo Participant;                                                                               // MakerGen.cs:211
                    // 66. PlanDefinition.action.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:211
                    // 67. PlanDefinition.action.groupingBehavior
                    public ElementDefinitionInfo GroupingBehavior;                                                                          // MakerGen.cs:211
                    // 68. PlanDefinition.action.selectionBehavior
                    public ElementDefinitionInfo SelectionBehavior;                                                                         // MakerGen.cs:211
                    // 69. PlanDefinition.action.requiredBehavior
                    public ElementDefinitionInfo RequiredBehavior;                                                                          // MakerGen.cs:211
                    // 70. PlanDefinition.action.precheckBehavior
                    public ElementDefinitionInfo PrecheckBehavior;                                                                          // MakerGen.cs:211
                    // 71. PlanDefinition.action.cardinalityBehavior
                    public ElementDefinitionInfo CardinalityBehavior;                                                                       // MakerGen.cs:211
                    // 72. PlanDefinition.action.definition[x]
                    public ElementDefinitionInfo Definition;                                                                                // MakerGen.cs:211
                    // 73. PlanDefinition.action.transform
                    public ElementDefinitionInfo Transform;                                                                                 // MakerGen.cs:211
                    // 74. PlanDefinition.action.dynamicValue
                    public ElementDefinitionInfo DynamicValue;                                                                              // MakerGen.cs:211
                    // 77. PlanDefinition.action.action
                    public ElementDefinitionInfo Action;                                                                                    // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Action_Elements()                                                                                           // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 42. PlanDefinition.action.prefix
                            this.Prefix = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Prefix",                                                                                            // MakerGen.cs:230
                                Path= "PlanDefinition.action.prefix",                                                                       // MakerGen.cs:231
                                Id = "PlanDefinition.action.prefix",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 43. PlanDefinition.action.title
                            this.Title = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Title",                                                                                             // MakerGen.cs:230
                                Path= "PlanDefinition.action.title",                                                                        // MakerGen.cs:231
                                Id = "PlanDefinition.action.title",                                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 44. PlanDefinition.action.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Description",                                                                                       // MakerGen.cs:230
                                Path= "PlanDefinition.action.description",                                                                  // MakerGen.cs:231
                                Id = "PlanDefinition.action.description",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 45. PlanDefinition.action.textEquivalent
                            this.TextEquivalent = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "TextEquivalent",                                                                                    // MakerGen.cs:230
                                Path= "PlanDefinition.action.textEquivalent",                                                               // MakerGen.cs:231
                                Id = "PlanDefinition.action.textEquivalent",                                                                // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 46. PlanDefinition.action.priority
                            this.Priority = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Priority",                                                                                          // MakerGen.cs:230
                                Path= "PlanDefinition.action.priority",                                                                     // MakerGen.cs:231
                                Id = "PlanDefinition.action.priority",                                                                      // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 47. PlanDefinition.action.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Code",                                                                                              // MakerGen.cs:230
                                Path= "PlanDefinition.action.code",                                                                         // MakerGen.cs:231
                                Id = "PlanDefinition.action.code",                                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 48. PlanDefinition.action.reason
                            this.Reason = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Reason",                                                                                            // MakerGen.cs:230
                                Path= "PlanDefinition.action.reason",                                                                       // MakerGen.cs:231
                                Id = "PlanDefinition.action.reason",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 49. PlanDefinition.action.documentation
                            this.Documentation = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Documentation",                                                                                     // MakerGen.cs:230
                                Path= "PlanDefinition.action.documentation",                                                                // MakerGen.cs:231
                                Id = "PlanDefinition.action.documentation",                                                                 // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.RelatedArtifact                                                       // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 50. PlanDefinition.action.goalId
                            this.GoalId = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "GoalId",                                                                                            // MakerGen.cs:230
                                Path= "PlanDefinition.action.goalId",                                                                       // MakerGen.cs:231
                                Id = "PlanDefinition.action.goalId",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Id                                                                  // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 51. PlanDefinition.action.subject[x]
                            this.Subject = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Subject",                                                                                           // MakerGen.cs:230
                                Path= "PlanDefinition.action.subject[x]",                                                                   // MakerGen.cs:231
                                Id = "PlanDefinition.action.subject[x]",                                                                    // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    },                                                                                                      // MakerGen.cs:314
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:341
                                    {                                                                                                       // MakerGen.cs:342
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:344
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Group"                                                 // MakerGen.cs:344
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:345
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 52. PlanDefinition.action.trigger
                            this.Trigger = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Trigger",                                                                                           // MakerGen.cs:230
                                Path= "PlanDefinition.action.trigger",                                                                      // MakerGen.cs:231
                                Id = "PlanDefinition.action.trigger",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.TriggerDefinition                                                     // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 53. PlanDefinition.action.condition
                            this.Condition = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Condition",                                                                                         // MakerGen.cs:230
                                Path= "PlanDefinition.action.condition",                                                                    // MakerGen.cs:231
                                Id = "PlanDefinition.action.condition",                                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Condition                                                                                      // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 56. PlanDefinition.action.input
                            this.Input = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Input",                                                                                             // MakerGen.cs:230
                                Path= "PlanDefinition.action.input",                                                                        // MakerGen.cs:231
                                Id = "PlanDefinition.action.input",                                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.DataRequirement                                                       // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 57. PlanDefinition.action.output
                            this.Output = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Output",                                                                                            // MakerGen.cs:230
                                Path= "PlanDefinition.action.output",                                                                       // MakerGen.cs:231
                                Id = "PlanDefinition.action.output",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.DataRequirement                                                       // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 58. PlanDefinition.action.relatedAction
                            this.RelatedAction = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "RelatedAction",                                                                                     // MakerGen.cs:230
                                Path= "PlanDefinition.action.relatedAction",                                                                // MakerGen.cs:231
                                Id = "PlanDefinition.action.relatedAction",                                                                 // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_RelatedAction                                                                                  // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 62. PlanDefinition.action.timing[x]
                            this.Timing = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Timing",                                                                                            // MakerGen.cs:230
                                Path= "PlanDefinition.action.timing[x]",                                                                    // MakerGen.cs:231
                                Id = "PlanDefinition.action.timing[x]",                                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Complex.Age                                                                   // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    },                                                                                                      // MakerGen.cs:355
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    },                                                                                                      // MakerGen.cs:355
                                    new FhirKhit.Maker.Common.Complex.Duration                                                              // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    },                                                                                                      // MakerGen.cs:355
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    },                                                                                                      // MakerGen.cs:355
                                    new FhirKhit.Maker.Common.Complex.Timing                                                                // MakerGen.cs:353
                                    {                                                                                                       // MakerGen.cs:354
                                    }                                                                                                       // MakerGen.cs:355
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 63. PlanDefinition.action.participant
                            this.Participant = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Participant",                                                                                       // MakerGen.cs:230
                                Path= "PlanDefinition.action.participant",                                                                  // MakerGen.cs:231
                                Id = "PlanDefinition.action.participant",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Participant                                                                                    // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 66. PlanDefinition.action.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Type",                                                                                              // MakerGen.cs:230
                                Path= "PlanDefinition.action.type",                                                                         // MakerGen.cs:231
                                Id = "PlanDefinition.action.type",                                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 67. PlanDefinition.action.groupingBehavior
                            this.GroupingBehavior = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "GroupingBehavior",                                                                                  // MakerGen.cs:230
                                Path= "PlanDefinition.action.groupingBehavior",                                                             // MakerGen.cs:231
                                Id = "PlanDefinition.action.groupingBehavior",                                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 68. PlanDefinition.action.selectionBehavior
                            this.SelectionBehavior = new ElementDefinitionInfo                                                              // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "SelectionBehavior",                                                                                 // MakerGen.cs:230
                                Path= "PlanDefinition.action.selectionBehavior",                                                            // MakerGen.cs:231
                                Id = "PlanDefinition.action.selectionBehavior",                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 69. PlanDefinition.action.requiredBehavior
                            this.RequiredBehavior = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "RequiredBehavior",                                                                                  // MakerGen.cs:230
                                Path= "PlanDefinition.action.requiredBehavior",                                                             // MakerGen.cs:231
                                Id = "PlanDefinition.action.requiredBehavior",                                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 70. PlanDefinition.action.precheckBehavior
                            this.PrecheckBehavior = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "PrecheckBehavior",                                                                                  // MakerGen.cs:230
                                Path= "PlanDefinition.action.precheckBehavior",                                                             // MakerGen.cs:231
                                Id = "PlanDefinition.action.precheckBehavior",                                                              // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 71. PlanDefinition.action.cardinalityBehavior
                            this.CardinalityBehavior = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "CardinalityBehavior",                                                                               // MakerGen.cs:230
                                Path= "PlanDefinition.action.cardinalityBehavior",                                                          // MakerGen.cs:231
                                Id = "PlanDefinition.action.cardinalityBehavior",                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 72. PlanDefinition.action.definition[x]
                            this.Definition = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Definition",                                                                                        // MakerGen.cs:230
                                Path= "PlanDefinition.action.definition[x]",                                                                // MakerGen.cs:231
                                Id = "PlanDefinition.action.definition[x]",                                                                 // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Canonical                                                           // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:298
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",                                   // MakerGen.cs:298
                                            "http://hl7.org/fhir/StructureDefinition/PlanDefinition",                                       // MakerGen.cs:298
                                            "http://hl7.org/fhir/StructureDefinition/Questionnaire"                                         // MakerGen.cs:298
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    },                                                                                                      // MakerGen.cs:299
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 73. PlanDefinition.action.transform
                            this.Transform = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Transform",                                                                                         // MakerGen.cs:230
                                Path= "PlanDefinition.action.transform",                                                                    // MakerGen.cs:231
                                Id = "PlanDefinition.action.transform",                                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Canonical                                                           // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:298
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/StructureMap"                                          // MakerGen.cs:298
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 74. PlanDefinition.action.dynamicValue
                            this.DynamicValue = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "DynamicValue",                                                                                      // MakerGen.cs:230
                                Path= "PlanDefinition.action.dynamicValue",                                                                 // MakerGen.cs:231
                                Id = "PlanDefinition.action.dynamicValue",                                                                  // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_DynamicValue                                                                                   // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 77. PlanDefinition.action.action
                            this.Action = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Action",                                                                                            // MakerGen.cs:230
                                Path= "PlanDefinition.action.action",                                                                       // MakerGen.cs:231
                                Id = "PlanDefinition.action.action",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        Prefix.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Title.Write(sDef);                                                                                                  // MakerGen.cs:215
                        Description.Write(sDef);                                                                                            // MakerGen.cs:215
                        TextEquivalent.Write(sDef);                                                                                         // MakerGen.cs:215
                        Priority.Write(sDef);                                                                                               // MakerGen.cs:215
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Reason.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Documentation.Write(sDef);                                                                                          // MakerGen.cs:215
                        GoalId.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Subject.Write(sDef);                                                                                                // MakerGen.cs:215
                        Trigger.Write(sDef);                                                                                                // MakerGen.cs:215
                        Condition.Write(sDef);                                                                                              // MakerGen.cs:215
                        Input.Write(sDef);                                                                                                  // MakerGen.cs:215
                        Output.Write(sDef);                                                                                                 // MakerGen.cs:215
                        RelatedAction.Write(sDef);                                                                                          // MakerGen.cs:215
                        Timing.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Participant.Write(sDef);                                                                                            // MakerGen.cs:215
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                        GroupingBehavior.Write(sDef);                                                                                       // MakerGen.cs:215
                        SelectionBehavior.Write(sDef);                                                                                      // MakerGen.cs:215
                        RequiredBehavior.Write(sDef);                                                                                       // MakerGen.cs:215
                        PrecheckBehavior.Write(sDef);                                                                                       // MakerGen.cs:215
                        CardinalityBehavior.Write(sDef);                                                                                    // MakerGen.cs:215
                        Definition.Write(sDef);                                                                                             // MakerGen.cs:215
                        Transform.Write(sDef);                                                                                              // MakerGen.cs:215
                        DynamicValue.Write(sDef);                                                                                           // MakerGen.cs:215
                        Action.Write(sDef);                                                                                                 // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Action_Elements Elements                                                                                        // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Action_Elements();                                                                     // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Action_Elements elements;                                                                                              // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Action()                                                                                                        // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "PlanDefinition.action",                                                                                     // MakerGen.cs:423
                        ElementId = "PlanDefinition.action"                                                                                 // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. PlanDefinition.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:211
            // 2. PlanDefinition.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 3. PlanDefinition.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:211
            // 4. PlanDefinition.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:211
            // 5. PlanDefinition.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:211
            // 6. PlanDefinition.subtitle
            public ElementDefinitionInfo Subtitle;                                                                                          // MakerGen.cs:211
            // 7. PlanDefinition.type
            public ElementDefinitionInfo Type;                                                                                              // MakerGen.cs:211
            // 8. PlanDefinition.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 9. PlanDefinition.experimental
            public ElementDefinitionInfo Experimental;                                                                                      // MakerGen.cs:211
            // 10. PlanDefinition.subject[x]
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:211
            // 11. PlanDefinition.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:211
            // 12. PlanDefinition.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:211
            // 13. PlanDefinition.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:211
            // 14. PlanDefinition.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:211
            // 15. PlanDefinition.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:211
            // 16. PlanDefinition.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:211
            // 17. PlanDefinition.purpose
            public ElementDefinitionInfo Purpose;                                                                                           // MakerGen.cs:211
            // 18. PlanDefinition.usage
            public ElementDefinitionInfo Usage;                                                                                             // MakerGen.cs:211
            // 19. PlanDefinition.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:211
            // 20. PlanDefinition.approvalDate
            public ElementDefinitionInfo ApprovalDate;                                                                                      // MakerGen.cs:211
            // 21. PlanDefinition.lastReviewDate
            public ElementDefinitionInfo LastReviewDate;                                                                                    // MakerGen.cs:211
            // 22. PlanDefinition.effectivePeriod
            public ElementDefinitionInfo EffectivePeriod;                                                                                   // MakerGen.cs:211
            // 23. PlanDefinition.topic
            public ElementDefinitionInfo Topic;                                                                                             // MakerGen.cs:211
            // 24. PlanDefinition.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:211
            // 25. PlanDefinition.editor
            public ElementDefinitionInfo Editor;                                                                                            // MakerGen.cs:211
            // 26. PlanDefinition.reviewer
            public ElementDefinitionInfo Reviewer;                                                                                          // MakerGen.cs:211
            // 27. PlanDefinition.endorser
            public ElementDefinitionInfo Endorser;                                                                                          // MakerGen.cs:211
            // 28. PlanDefinition.relatedArtifact
            public ElementDefinitionInfo RelatedArtifact;                                                                                   // MakerGen.cs:211
            // 29. PlanDefinition.library
            public ElementDefinitionInfo Library;                                                                                           // MakerGen.cs:211
            // 30. PlanDefinition.goal
            public ElementDefinitionInfo Goal;                                                                                              // MakerGen.cs:211
            // 41. PlanDefinition.action
            public ElementDefinitionInfo Action;                                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public PlanDefinition_Elements()                                                                                                // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. PlanDefinition.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Url",                                                                                                       // MakerGen.cs:230
                        Path= "PlanDefinition.url",                                                                                         // MakerGen.cs:231
                        Id = "PlanDefinition.url",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. PlanDefinition.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "PlanDefinition.identifier",                                                                                  // MakerGen.cs:231
                        Id = "PlanDefinition.identifier",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. PlanDefinition.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Version",                                                                                                   // MakerGen.cs:230
                        Path= "PlanDefinition.version",                                                                                     // MakerGen.cs:231
                        Id = "PlanDefinition.version",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. PlanDefinition.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Name",                                                                                                      // MakerGen.cs:230
                        Path= "PlanDefinition.name",                                                                                        // MakerGen.cs:231
                        Id = "PlanDefinition.name",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. PlanDefinition.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Title",                                                                                                     // MakerGen.cs:230
                        Path= "PlanDefinition.title",                                                                                       // MakerGen.cs:231
                        Id = "PlanDefinition.title",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. PlanDefinition.subtitle
                    this.Subtitle = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Subtitle",                                                                                                  // MakerGen.cs:230
                        Path= "PlanDefinition.subtitle",                                                                                    // MakerGen.cs:231
                        Id = "PlanDefinition.subtitle",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. PlanDefinition.type
                    this.Type = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Type",                                                                                                      // MakerGen.cs:230
                        Path= "PlanDefinition.type",                                                                                        // MakerGen.cs:231
                        Id = "PlanDefinition.type",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. PlanDefinition.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "PlanDefinition.status",                                                                                      // MakerGen.cs:231
                        Id = "PlanDefinition.status",                                                                                       // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. PlanDefinition.experimental
                    this.Experimental = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Experimental",                                                                                              // MakerGen.cs:230
                        Path= "PlanDefinition.experimental",                                                                                // MakerGen.cs:231
                        Id = "PlanDefinition.experimental",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. PlanDefinition.subject[x]
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Subject",                                                                                                   // MakerGen.cs:230
                        Path= "PlanDefinition.subject[x]",                                                                                  // MakerGen.cs:231
                        Id = "PlanDefinition.subject[x]",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            },                                                                                                              // MakerGen.cs:314
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. PlanDefinition.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Date",                                                                                                      // MakerGen.cs:230
                        Path= "PlanDefinition.date",                                                                                        // MakerGen.cs:231
                        Id = "PlanDefinition.date",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. PlanDefinition.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Publisher",                                                                                                 // MakerGen.cs:230
                        Path= "PlanDefinition.publisher",                                                                                   // MakerGen.cs:231
                        Id = "PlanDefinition.publisher",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. PlanDefinition.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Contact",                                                                                                   // MakerGen.cs:230
                        Path= "PlanDefinition.contact",                                                                                     // MakerGen.cs:231
                        Id = "PlanDefinition.contact",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. PlanDefinition.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Description",                                                                                               // MakerGen.cs:230
                        Path= "PlanDefinition.description",                                                                                 // MakerGen.cs:231
                        Id = "PlanDefinition.description",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 15. PlanDefinition.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "UseContext",                                                                                                // MakerGen.cs:230
                        Path= "PlanDefinition.useContext",                                                                                  // MakerGen.cs:231
                        Id = "PlanDefinition.useContext",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.UsageContext                                                                  // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. PlanDefinition.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:230
                        Path= "PlanDefinition.jurisdiction",                                                                                // MakerGen.cs:231
                        Id = "PlanDefinition.jurisdiction",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 17. PlanDefinition.purpose
                    this.Purpose = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Purpose",                                                                                                   // MakerGen.cs:230
                        Path= "PlanDefinition.purpose",                                                                                     // MakerGen.cs:231
                        Id = "PlanDefinition.purpose",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 18. PlanDefinition.usage
                    this.Usage = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Usage",                                                                                                     // MakerGen.cs:230
                        Path= "PlanDefinition.usage",                                                                                       // MakerGen.cs:231
                        Id = "PlanDefinition.usage",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 19. PlanDefinition.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Copyright",                                                                                                 // MakerGen.cs:230
                        Path= "PlanDefinition.copyright",                                                                                   // MakerGen.cs:231
                        Id = "PlanDefinition.copyright",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 20. PlanDefinition.approvalDate
                    this.ApprovalDate = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ApprovalDate",                                                                                              // MakerGen.cs:230
                        Path= "PlanDefinition.approvalDate",                                                                                // MakerGen.cs:231
                        Id = "PlanDefinition.approvalDate",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 21. PlanDefinition.lastReviewDate
                    this.LastReviewDate = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "LastReviewDate",                                                                                            // MakerGen.cs:230
                        Path= "PlanDefinition.lastReviewDate",                                                                              // MakerGen.cs:231
                        Id = "PlanDefinition.lastReviewDate",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 22. PlanDefinition.effectivePeriod
                    this.EffectivePeriod = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "EffectivePeriod",                                                                                           // MakerGen.cs:230
                        Path= "PlanDefinition.effectivePeriod",                                                                             // MakerGen.cs:231
                        Id = "PlanDefinition.effectivePeriod",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 23. PlanDefinition.topic
                    this.Topic = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Topic",                                                                                                     // MakerGen.cs:230
                        Path= "PlanDefinition.topic",                                                                                       // MakerGen.cs:231
                        Id = "PlanDefinition.topic",                                                                                        // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 24. PlanDefinition.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Author",                                                                                                    // MakerGen.cs:230
                        Path= "PlanDefinition.author",                                                                                      // MakerGen.cs:231
                        Id = "PlanDefinition.author",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 25. PlanDefinition.editor
                    this.Editor = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Editor",                                                                                                    // MakerGen.cs:230
                        Path= "PlanDefinition.editor",                                                                                      // MakerGen.cs:231
                        Id = "PlanDefinition.editor",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 26. PlanDefinition.reviewer
                    this.Reviewer = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Reviewer",                                                                                                  // MakerGen.cs:230
                        Path= "PlanDefinition.reviewer",                                                                                    // MakerGen.cs:231
                        Id = "PlanDefinition.reviewer",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 27. PlanDefinition.endorser
                    this.Endorser = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Endorser",                                                                                                  // MakerGen.cs:230
                        Path= "PlanDefinition.endorser",                                                                                    // MakerGen.cs:231
                        Id = "PlanDefinition.endorser",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 28. PlanDefinition.relatedArtifact
                    this.RelatedArtifact = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "RelatedArtifact",                                                                                           // MakerGen.cs:230
                        Path= "PlanDefinition.relatedArtifact",                                                                             // MakerGen.cs:231
                        Id = "PlanDefinition.relatedArtifact",                                                                              // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.RelatedArtifact                                                               // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 29. PlanDefinition.library
                    this.Library = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Library",                                                                                                   // MakerGen.cs:230
                        Path= "PlanDefinition.library",                                                                                     // MakerGen.cs:231
                        Id = "PlanDefinition.library",                                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                                TargetProfile = new String[]                                                                                // MakerGen.cs:298
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Library"                                                       // MakerGen.cs:298
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 30. PlanDefinition.goal
                    this.Goal = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Goal",                                                                                                      // MakerGen.cs:230
                        Path= "PlanDefinition.goal",                                                                                        // MakerGen.cs:231
                        Id = "PlanDefinition.goal",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Goal                                                                                                   // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 41. PlanDefinition.action
                    this.Action = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Action",                                                                                                    // MakerGen.cs:230
                        Path= "PlanDefinition.action",                                                                                      // MakerGen.cs:231
                        Id = "PlanDefinition.action",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Action                                                                                                 // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Url.Write(sDef);                                                                                                            // MakerGen.cs:215
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                Version.Write(sDef);                                                                                                        // MakerGen.cs:215
                Name.Write(sDef);                                                                                                           // MakerGen.cs:215
                Title.Write(sDef);                                                                                                          // MakerGen.cs:215
                Subtitle.Write(sDef);                                                                                                       // MakerGen.cs:215
                Type.Write(sDef);                                                                                                           // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                Experimental.Write(sDef);                                                                                                   // MakerGen.cs:215
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:215
                Date.Write(sDef);                                                                                                           // MakerGen.cs:215
                Publisher.Write(sDef);                                                                                                      // MakerGen.cs:215
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:215
                Description.Write(sDef);                                                                                                    // MakerGen.cs:215
                UseContext.Write(sDef);                                                                                                     // MakerGen.cs:215
                Jurisdiction.Write(sDef);                                                                                                   // MakerGen.cs:215
                Purpose.Write(sDef);                                                                                                        // MakerGen.cs:215
                Usage.Write(sDef);                                                                                                          // MakerGen.cs:215
                Copyright.Write(sDef);                                                                                                      // MakerGen.cs:215
                ApprovalDate.Write(sDef);                                                                                                   // MakerGen.cs:215
                LastReviewDate.Write(sDef);                                                                                                 // MakerGen.cs:215
                EffectivePeriod.Write(sDef);                                                                                                // MakerGen.cs:215
                Topic.Write(sDef);                                                                                                          // MakerGen.cs:215
                Author.Write(sDef);                                                                                                         // MakerGen.cs:215
                Editor.Write(sDef);                                                                                                         // MakerGen.cs:215
                Reviewer.Write(sDef);                                                                                                       // MakerGen.cs:215
                Endorser.Write(sDef);                                                                                                       // MakerGen.cs:215
                RelatedArtifact.Write(sDef);                                                                                                // MakerGen.cs:215
                Library.Write(sDef);                                                                                                        // MakerGen.cs:215
                Goal.Write(sDef);                                                                                                           // MakerGen.cs:215
                Action.Write(sDef);                                                                                                         // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public PlanDefinition_Elements Elements                                                                                             // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new PlanDefinition_Elements();                                                                          // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        PlanDefinition_Elements elements;                                                                                                   // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public PlanDefinition()                                                                                                             // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "PlanDefinition";                                                                                                   // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/PlanDefinition";                                                            // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "PlanDefinition",                                                                                                    // MakerGen.cs:423
                ElementId = "PlanDefinition"                                                                                                // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
