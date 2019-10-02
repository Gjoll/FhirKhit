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
      "id": "ActivityDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/ActivityDefinition",
      "version": "4.0.0",
      "name": "ActivityDefinition",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Decision Support)",
      "description": "This resource allows for the definition of some activity to be performed, independent of a particular patient, practitioner, or other performance context.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ActivityDefinition",
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
            "id": "ActivityDefinition",
            "path": "ActivityDefinition",
            "short": "The definition of a specific activity to be taken, independent of any particular patient or context",
            "definition": "This resource allows for the definition of some activity to be performed, independent of a particular patient, practitioner, or other performance context.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ActivityDefinition.url",
            "path": "ActivityDefinition.url",
            "short": "Canonical identifier for this activity definition, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this activity definition when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this activity definition is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the activity definition is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the activity definition to be referenced by a single globally unique identifier.",
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
            "id": "ActivityDefinition.identifier",
            "path": "ActivityDefinition.identifier",
            "short": "Additional identifier for the activity definition",
            "definition": "A formal identifier that is used to identify this activity definition when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this activity definition outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "ActivityDefinition.version",
            "path": "ActivityDefinition.version",
            "short": "Business version of the activity definition",
            "definition": "The identifier that is used to identify this version of the activity definition when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the activity definition author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence. To provide a version consistent with the Decision Support Service specification, use the format Major.Minor.Revision (e.g. 1.0.0). For more information on versioning knowledge assets, refer to the Decision Support Service specification. Note that a version is required for non-experimental active assets.",
            "comment": "There may be different activity definition instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the activity definition with the format [url]|[version].",
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
            "id": "ActivityDefinition.name",
            "path": "ActivityDefinition.name",
            "short": "Name for this activity definition (computer friendly)",
            "definition": "A natural language name identifying the activity definition. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "ActivityDefinition.title",
            "path": "ActivityDefinition.title",
            "short": "Name for this activity definition (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the activity definition.",
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
            "id": "ActivityDefinition.subtitle",
            "path": "ActivityDefinition.subtitle",
            "short": "Subordinate title of the activity definition",
            "definition": "An explanatory or alternate title for the activity definition giving additional information about its content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ActivityDefinition.status",
            "path": "ActivityDefinition.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this activity definition. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of activity definitions that are appropriate for use versus not.",
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
            "id": "ActivityDefinition.experimental",
            "path": "ActivityDefinition.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this activity definition is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of activity definitions that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level activity definition.",
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
            "id": "ActivityDefinition.subject[x]",
            "path": "ActivityDefinition.subject[x]",
            "short": "Type of individual the activity definition is intended for",
            "definition": "A code or group definition that describes the intended subject of the activity being defined.",
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
              "description": "The possible types of subjects for an activity (E.g. Patient, Practitioner, Organization, Location, etc.).",
              "valueSet": "http://hl7.org/fhir/ValueSet/subject-type"
            }
          },
          {
            "id": "ActivityDefinition.date",
            "path": "ActivityDefinition.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the activity definition was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the activity definition changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the activity definition. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "ActivityDefinition.publisher",
            "path": "ActivityDefinition.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the activity definition.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the activity definition is the organization or individual primarily responsible for the maintenance and upkeep of the activity definition. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the activity definition. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the activity definition.  May also allow for contact.",
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
            "id": "ActivityDefinition.contact",
            "path": "ActivityDefinition.contact",
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
            "id": "ActivityDefinition.description",
            "path": "ActivityDefinition.description",
            "short": "Natural language description of the activity definition",
            "definition": "A free text natural language description of the activity definition from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the activity definition was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the activity definition as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the activity definition is presumed to be the predominant language in the place the activity definition was created).",
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
            "id": "ActivityDefinition.useContext",
            "path": "ActivityDefinition.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate activity definition instances.",
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
            "id": "ActivityDefinition.jurisdiction",
            "path": "ActivityDefinition.jurisdiction",
            "short": "Intended jurisdiction for activity definition (if applicable)",
            "definition": "A legal or geographic region in which the activity definition is intended to be used.",
            "comment": "It may be possible for the activity definition to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "ActivityDefinition.purpose",
            "path": "ActivityDefinition.purpose",
            "short": "Why this activity definition is defined",
            "definition": "Explanation of why this activity definition is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the activity definition. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this activity definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ActivityDefinition.usage",
            "path": "ActivityDefinition.usage",
            "short": "Describes the clinical usage of the activity definition",
            "definition": "A detailed description of how the activity definition is used from a clinical perspective.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ActivityDefinition.copyright",
            "path": "ActivityDefinition.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the activity definition and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the activity definition.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the activity definition and/or its content.",
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
            "id": "ActivityDefinition.approvalDate",
            "path": "ActivityDefinition.approvalDate",
            "short": "When the activity definition was approved by publisher",
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
            "id": "ActivityDefinition.lastReviewDate",
            "path": "ActivityDefinition.lastReviewDate",
            "short": "When the activity definition was last reviewed",
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
            "id": "ActivityDefinition.effectivePeriod",
            "path": "ActivityDefinition.effectivePeriod",
            "short": "When the activity definition is expected to be used",
            "definition": "The period during which the activity definition content was or is planned to be in active use.",
            "comment": "The effective period for a activity definition  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.",
            "requirements": "Allows establishing a transition before a resource comes into effect and also allows for a sunsetting  process when new versions of the activity definition are or are expected to be used instead.",
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
            "id": "ActivityDefinition.topic",
            "path": "ActivityDefinition.topic",
            "short": "E.g. Education, Treatment, Assessment, etc.",
            "definition": "Descriptive topics related to the content of the activity. Topics provide a high-level categorization of the activity that can be useful for filtering and searching.",
            "requirements": "Repositories must be able to determine how to categorize the activity definition so that it can be found by topical searches.",
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
            "id": "ActivityDefinition.author",
            "path": "ActivityDefinition.author",
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
            "id": "ActivityDefinition.editor",
            "path": "ActivityDefinition.editor",
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
            "id": "ActivityDefinition.reviewer",
            "path": "ActivityDefinition.reviewer",
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
            "id": "ActivityDefinition.endorser",
            "path": "ActivityDefinition.endorser",
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
            "id": "ActivityDefinition.relatedArtifact",
            "path": "ActivityDefinition.relatedArtifact",
            "short": "Additional documentation, citations, etc.",
            "definition": "Related artifacts such as additional documentation, justification, or bibliographic references.",
            "comment": "Each related artifact is either an attachment, or a reference to another resource, but not both.",
            "requirements": "Activity definitions must be able to provide enough information for consumers of the content (and/or interventions or results produced by the content) to be able to determine and understand the justification for and evidence in support of the content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "RelatedArtifact"
              }
            ]
          },
          {
            "id": "ActivityDefinition.library",
            "path": "ActivityDefinition.library",
            "short": "Logic used by the activity definition",
            "definition": "A reference to a Library resource containing any formal logic used by the activity definition.",
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
            "id": "ActivityDefinition.kind",
            "path": "ActivityDefinition.kind",
            "short": "Kind of resource",
            "definition": "A description of the kind of resource the activity definition is representing. For example, a MedicationRequest, a ServiceRequest, or a CommunicationRequest. Typically, but not always, this is a Request resource.",
            "comment": "May determine what types of extensions are permitted.",
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
                  "valueString": "ActivityDefinitionKind"
                }
              ],
              "strength": "required",
              "description": "The kind of activity the definition is describing.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-resource-types|4.0.0"
            }
          },
          {
            "id": "ActivityDefinition.profile",
            "path": "ActivityDefinition.profile",
            "short": "What profile the resource needs to conform to",
            "definition": "A profile to which the target of the activity definition is expected to conform.",
            "requirements": "Allows profiles to be used to describe the types of activities that can be performed within a workflow, protocol, or order set.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/StructureDefinition"
                ]
              }
            ]
          },
          {
            "id": "ActivityDefinition.code",
            "path": "ActivityDefinition.code",
            "short": "Detail type of activity",
            "definition": "Detailed description of the type of activity; e.g. What lab test, what procedure, what kind of encounter.",
            "comment": "Tends to be less relevant for activities involving particular products.",
            "requirements": "Allows matching performed to planned as well as validation against protocols.",
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
                  "valueString": "ActivityDefinitionType"
                }
              ],
              "strength": "example",
              "description": "Detailed type of the activity; e.g. CBC.",
              "valueSet": "http://hl7.org/fhir/ValueSet/procedure-code"
            }
          },
          {
            "id": "ActivityDefinition.intent",
            "path": "ActivityDefinition.intent",
            "short": "proposal | plan | order",
            "definition": "Indicates the level of authority/intentionality associated with the activity and where the request should fit into the workflow chain.",
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
                  "valueString": "RequestIntent"
                }
              ],
              "strength": "required",
              "description": "Codes indicating the degree of authority/intentionality associated with a request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-intent|4.0.0"
            }
          },
          {
            "id": "ActivityDefinition.priority",
            "path": "ActivityDefinition.priority",
            "short": "routine | urgent | asap | stat",
            "definition": "Indicates how quickly the activity  should be addressed with respect to other requests.",
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
            "id": "ActivityDefinition.doNotPerform",
            "path": "ActivityDefinition.doNotPerform",
            "short": "True if the activity should not be performed",
            "definition": "Set this to true if the definition is to indicate that a particular activity should NOT be performed. If true, this element should be interpreted to reinforce a negative coding. For example NPO as a code with a doNotPerform of true would still indicate to NOT perform the action.",
            "comment": "This element is not intended to be used to communicate a decision support response to cancel an order in progress. That should be done with the \"remove\" type of a PlanDefinition or RequestGroup.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "isModifier": true,
            "isModifierReason": "If true this element negates the specified action. For Example,  instead of a request for a procedure, it is a request for the procedure to not occur.",
            "isSummary": true
          },
          {
            "id": "ActivityDefinition.timing[x]",
            "path": "ActivityDefinition.timing[x]",
            "short": "When activity is to occur",
            "definition": "The period, timing or frequency upon which the described activity is to occur.",
            "requirements": "Allows prompting for activities and detection of missed planned activities.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Timing"
              },
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
                "code": "Range"
              },
              {
                "code": "Duration"
              }
            ]
          },
          {
            "id": "ActivityDefinition.location",
            "path": "ActivityDefinition.location",
            "short": "Where it should happen",
            "definition": "Identifies the facility where the activity will occur; e.g. home, hospital, specific clinic, etc.",
            "comment": "May reference a specific clinical location or may just identify a type of location.",
            "requirements": "Helps in planning of activity.",
            "alias": [
              "facility"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Location"
                ]
              }
            ]
          },
          {
            "id": "ActivityDefinition.participant",
            "path": "ActivityDefinition.participant",
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
            "id": "ActivityDefinition.participant.type",
            "path": "ActivityDefinition.participant.type",
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
                  "valueString": "ActivityParticipantType"
                }
              ],
              "strength": "required",
              "description": "The type of participant in the activity.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-participant-type|4.0.0"
            }
          },
          {
            "id": "ActivityDefinition.participant.role",
            "path": "ActivityDefinition.participant.role",
            "short": "E.g. Nurse, Surgeon, Parent, etc.",
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
                  "valueString": "ActivityParticipantRole"
                }
              ],
              "strength": "example",
              "description": "Defines roles played by participants for the action.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-participant-role"
            }
          },
          {
            "id": "ActivityDefinition.product[x]",
            "path": "ActivityDefinition.product[x]",
            "short": "What's administered/supplied",
            "definition": "Identifies the food, drug or other product being consumed or supplied in the activity.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Medication",
                  "http://hl7.org/fhir/StructureDefinition/Substance"
                ]
              },
              {
                "code": "CodeableConcept"
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "ActivityProduct"
                }
              ],
              "strength": "example",
              "description": "Code describing the type of substance or medication.",
              "valueSet": "http://hl7.org/fhir/ValueSet/medication-codes"
            }
          },
          {
            "id": "ActivityDefinition.quantity",
            "path": "ActivityDefinition.quantity",
            "short": "How much is administered/consumed/supplied",
            "definition": "Identifies the quantity expected to be consumed at once (per dose, per meal, etc.).",
            "alias": [
              "dose"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Quantity",
                "profile": [
                  "http://hl7.org/fhir/StructureDefinition/SimpleQuantity"
                ]
              }
            ]
          },
          {
            "id": "ActivityDefinition.dosage",
            "path": "ActivityDefinition.dosage",
            "short": "Detailed dosage instructions",
            "definition": "Provides detailed dosage instructions in the same way that they are described for MedicationRequest resources.",
            "comment": "If a dosage instruction is used, the definition should not specify timing or quantity.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Dosage"
              }
            ]
          },
          {
            "id": "ActivityDefinition.bodySite",
            "path": "ActivityDefinition.bodySite",
            "short": "What part of body to perform on",
            "definition": "Indicates the sites on the subject's body where the procedure should be performed (I.e. the target sites).",
            "comment": "Only used if not implicit in the code found in ServiceRequest.type.",
            "requirements": "Knowing where the procedure is made is important for tracking if multiple sites are possible.",
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
                  "valueString": "BodySite"
                }
              ],
              "strength": "example",
              "description": "A code that identifies the anatomical location.",
              "valueSet": "http://hl7.org/fhir/ValueSet/body-site"
            }
          },
          {
            "id": "ActivityDefinition.specimenRequirement",
            "path": "ActivityDefinition.specimenRequirement",
            "short": "What specimens are required to perform this action",
            "definition": "Defines specimen requirements for the action to be performed, such as required specimens for a lab test.",
            "requirements": "Needed to represent lab order definitions.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/SpecimenDefinition"
                ]
              }
            ]
          },
          {
            "id": "ActivityDefinition.observationRequirement",
            "path": "ActivityDefinition.observationRequirement",
            "short": "What observations are required to perform this action",
            "definition": "Defines observation requirements for the action to be performed, such as body weight or surface area.",
            "requirements": "Needed to represent observation definitions.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ObservationDefinition"
                ]
              }
            ]
          },
          {
            "id": "ActivityDefinition.observationResultRequirement",
            "path": "ActivityDefinition.observationResultRequirement",
            "short": "What observations must be produced by this action",
            "definition": "Defines the observations that are expected to be produced by the action.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ObservationDefinition"
                ]
              }
            ]
          },
          {
            "id": "ActivityDefinition.transform",
            "path": "ActivityDefinition.transform",
            "short": "Transform to apply the template",
            "definition": "A reference to a StructureMap resource that defines a transform that can be executed to produce the intent resource using the ActivityDefinition instance as the input.",
            "comment": "Note that if both a transform and dynamic values are specified, the dynamic values will be applied to the result of the transform.",
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
            "id": "ActivityDefinition.dynamicValue",
            "path": "ActivityDefinition.dynamicValue",
            "short": "Dynamic aspects of the definition",
            "definition": "Dynamic values that will be evaluated to produce values for elements of the resulting resource. For example, if the dosage of a medication must be computed based on the patient's weight, a dynamic value would be used to specify an expression that calculated the weight, and the path on the request resource that would contain the result.",
            "comment": "Dynamic values are applied in the order in which they are defined in the ActivityDefinition. Note that if both a transform and dynamic values are specified, the dynamic values will be applied to the result of the transform.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "ActivityDefinition.dynamicValue.path",
            "path": "ActivityDefinition.dynamicValue.path",
            "short": "The path to the element to be set dynamically",
            "definition": "The path to the element to be customized. This is the path on the resource that will hold the result of the calculation defined by the expression. The specified path SHALL be a FHIRPath resolveable on the specified target type of the ActivityDefinition, and SHALL consist only of identifiers, constant indexers, and a restricted subset of functions. The path is allowed to contain qualifiers (.) to traverse sub-elements, as well as indexers ([x]) to traverse multiple-cardinality sub-elements (see the [Simple FHIRPath Profile](fhirpath.html#simple) for full details).",
            "comment": "The path attribute contains a [Simple FHIRPath Subset](fhirpath.html#simple) that allows path traversal, but not calculation.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ActivityDefinition.dynamicValue.expression",
            "path": "ActivityDefinition.dynamicValue.expression",
            "short": "An expression that provides the dynamic value for the customization",
            "definition": "An expression specifying the value of the customized element.",
            "comment": "The expression may be inlined, or may be a reference to a named expression within a logic library referenced by the library element.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Expression"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'ActivityDefinition'
    /// </summary>
    // 0. ActivityDefinition
    public class Resource_ActivityDefinition : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 37. ActivityDefinition.participant
        public class Type_Participant : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 38. ActivityDefinition.participant.type
            public ElementDefinitionInfo Element_Type;
            // 39. ActivityDefinition.participant.role
            public ElementDefinitionInfo Element_Role;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ActivityDefinition.participant",
                    ElementId = "ActivityDefinition.participant"
                });
                Element_Type.Write(sDef);
                Element_Role.Write(sDef);
            }
            
            public Type_Participant()
            {
                {
                    // 38. ActivityDefinition.participant.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "ActivityDefinition.participant.type",
                        Id = "ActivityDefinition.participant.type",
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
                    // 39. ActivityDefinition.participant.role
                    this.Element_Role = new ElementDefinitionInfo
                    {
                        Name = "Element_Role",
                        Path= "ActivityDefinition.participant.role",
                        Id = "ActivityDefinition.participant.role",
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
        // 48. ActivityDefinition.dynamicValue
        public class Type_DynamicValue : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 49. ActivityDefinition.dynamicValue.path
            public ElementDefinitionInfo Element_Path;
            // 50. ActivityDefinition.dynamicValue.expression
            public ElementDefinitionInfo Element_Expression;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "ActivityDefinition.dynamicValue",
                    ElementId = "ActivityDefinition.dynamicValue"
                });
                Element_Path.Write(sDef);
                Element_Expression.Write(sDef);
            }
            
            public Type_DynamicValue()
            {
                {
                    // 49. ActivityDefinition.dynamicValue.path
                    this.Element_Path = new ElementDefinitionInfo
                    {
                        Name = "Element_Path",
                        Path= "ActivityDefinition.dynamicValue.path",
                        Id = "ActivityDefinition.dynamicValue.path",
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
                    // 50. ActivityDefinition.dynamicValue.expression
                    this.Element_Expression = new ElementDefinitionInfo
                    {
                        Name = "Element_Expression",
                        Path= "ActivityDefinition.dynamicValue.expression",
                        Id = "ActivityDefinition.dynamicValue.expression",
                        Min = 1,
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
        // 1. ActivityDefinition.url
        public ElementDefinitionInfo Element_Url;
        // 2. ActivityDefinition.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. ActivityDefinition.version
        public ElementDefinitionInfo Element_Version;
        // 4. ActivityDefinition.name
        public ElementDefinitionInfo Element_Name;
        // 5. ActivityDefinition.title
        public ElementDefinitionInfo Element_Title;
        // 6. ActivityDefinition.subtitle
        public ElementDefinitionInfo Element_Subtitle;
        // 7. ActivityDefinition.status
        public ElementDefinitionInfo Element_Status;
        // 8. ActivityDefinition.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 9. ActivityDefinition.subject[x]
        public ElementDefinitionInfo Element_Subject;
        // 10. ActivityDefinition.date
        public ElementDefinitionInfo Element_Date;
        // 11. ActivityDefinition.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 12. ActivityDefinition.contact
        public ElementDefinitionInfo Element_Contact;
        // 13. ActivityDefinition.description
        public ElementDefinitionInfo Element_Description;
        // 14. ActivityDefinition.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 15. ActivityDefinition.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 16. ActivityDefinition.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 17. ActivityDefinition.usage
        public ElementDefinitionInfo Element_Usage;
        // 18. ActivityDefinition.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 19. ActivityDefinition.approvalDate
        public ElementDefinitionInfo Element_ApprovalDate;
        // 20. ActivityDefinition.lastReviewDate
        public ElementDefinitionInfo Element_LastReviewDate;
        // 21. ActivityDefinition.effectivePeriod
        public ElementDefinitionInfo Element_EffectivePeriod;
        // 22. ActivityDefinition.topic
        public ElementDefinitionInfo Element_Topic;
        // 23. ActivityDefinition.author
        public ElementDefinitionInfo Element_Author;
        // 24. ActivityDefinition.editor
        public ElementDefinitionInfo Element_Editor;
        // 25. ActivityDefinition.reviewer
        public ElementDefinitionInfo Element_Reviewer;
        // 26. ActivityDefinition.endorser
        public ElementDefinitionInfo Element_Endorser;
        // 27. ActivityDefinition.relatedArtifact
        public ElementDefinitionInfo Element_RelatedArtifact;
        // 28. ActivityDefinition.library
        public ElementDefinitionInfo Element_Library;
        // 29. ActivityDefinition.kind
        public ElementDefinitionInfo Element_Kind;
        // 30. ActivityDefinition.profile
        public ElementDefinitionInfo Element_Profile;
        // 31. ActivityDefinition.code
        public ElementDefinitionInfo Element_Code;
        // 32. ActivityDefinition.intent
        public ElementDefinitionInfo Element_Intent;
        // 33. ActivityDefinition.priority
        public ElementDefinitionInfo Element_Priority;
        // 34. ActivityDefinition.doNotPerform
        public ElementDefinitionInfo Element_DoNotPerform;
        // 35. ActivityDefinition.timing[x]
        public ElementDefinitionInfo Element_Timing;
        // 36. ActivityDefinition.location
        public ElementDefinitionInfo Element_Location;
        // 37. ActivityDefinition.participant
        public ElementDefinitionInfo Element_Participant;
        // 40. ActivityDefinition.product[x]
        public ElementDefinitionInfo Element_Product;
        // 41. ActivityDefinition.quantity
        public ElementDefinitionInfo Element_Quantity;
        // 42. ActivityDefinition.dosage
        public ElementDefinitionInfo Element_Dosage;
        // 43. ActivityDefinition.bodySite
        public ElementDefinitionInfo Element_BodySite;
        // 44. ActivityDefinition.specimenRequirement
        public ElementDefinitionInfo Element_SpecimenRequirement;
        // 45. ActivityDefinition.observationRequirement
        public ElementDefinitionInfo Element_ObservationRequirement;
        // 46. ActivityDefinition.observationResultRequirement
        public ElementDefinitionInfo Element_ObservationResultRequirement;
        // 47. ActivityDefinition.transform
        public ElementDefinitionInfo Element_Transform;
        // 48. ActivityDefinition.dynamicValue
        public ElementDefinitionInfo Element_DynamicValue;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "ActivityDefinition",
                ElementId = "ActivityDefinition"
            });
            Element_Url.Write(sDef);
            Element_Identifier.Write(sDef);
            Element_Version.Write(sDef);
            Element_Name.Write(sDef);
            Element_Title.Write(sDef);
            Element_Subtitle.Write(sDef);
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
            Element_Kind.Write(sDef);
            Element_Profile.Write(sDef);
            Element_Code.Write(sDef);
            Element_Intent.Write(sDef);
            Element_Priority.Write(sDef);
            Element_DoNotPerform.Write(sDef);
            Element_Timing.Write(sDef);
            Element_Location.Write(sDef);
            Element_Participant.Write(sDef);
            Element_Product.Write(sDef);
            Element_Quantity.Write(sDef);
            Element_Dosage.Write(sDef);
            Element_BodySite.Write(sDef);
            Element_SpecimenRequirement.Write(sDef);
            Element_ObservationRequirement.Write(sDef);
            Element_ObservationResultRequirement.Write(sDef);
            Element_Transform.Write(sDef);
            Element_DynamicValue.Write(sDef);
        }
        
        public Resource_ActivityDefinition()
        {
            {
                // 1. ActivityDefinition.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "ActivityDefinition.url",
                    Id = "ActivityDefinition.url",
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
                // 2. ActivityDefinition.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "ActivityDefinition.identifier",
                    Id = "ActivityDefinition.identifier",
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
                // 3. ActivityDefinition.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "ActivityDefinition.version",
                    Id = "ActivityDefinition.version",
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
                // 4. ActivityDefinition.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "ActivityDefinition.name",
                    Id = "ActivityDefinition.name",
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
                // 5. ActivityDefinition.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "ActivityDefinition.title",
                    Id = "ActivityDefinition.title",
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
                // 6. ActivityDefinition.subtitle
                this.Element_Subtitle = new ElementDefinitionInfo
                {
                    Name = "Element_Subtitle",
                    Path= "ActivityDefinition.subtitle",
                    Id = "ActivityDefinition.subtitle",
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
                // 7. ActivityDefinition.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "ActivityDefinition.status",
                    Id = "ActivityDefinition.status",
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
                // 8. ActivityDefinition.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "ActivityDefinition.experimental",
                    Id = "ActivityDefinition.experimental",
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
                // 9. ActivityDefinition.subject[x]
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "ActivityDefinition.subject[x]",
                    Id = "ActivityDefinition.subject[x]",
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
                // 10. ActivityDefinition.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "ActivityDefinition.date",
                    Id = "ActivityDefinition.date",
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
                // 11. ActivityDefinition.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "ActivityDefinition.publisher",
                    Id = "ActivityDefinition.publisher",
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
                // 12. ActivityDefinition.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "ActivityDefinition.contact",
                    Id = "ActivityDefinition.contact",
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
                // 13. ActivityDefinition.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "ActivityDefinition.description",
                    Id = "ActivityDefinition.description",
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
                // 14. ActivityDefinition.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "ActivityDefinition.useContext",
                    Id = "ActivityDefinition.useContext",
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
                // 15. ActivityDefinition.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "ActivityDefinition.jurisdiction",
                    Id = "ActivityDefinition.jurisdiction",
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
                // 16. ActivityDefinition.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "ActivityDefinition.purpose",
                    Id = "ActivityDefinition.purpose",
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
                // 17. ActivityDefinition.usage
                this.Element_Usage = new ElementDefinitionInfo
                {
                    Name = "Element_Usage",
                    Path= "ActivityDefinition.usage",
                    Id = "ActivityDefinition.usage",
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
                // 18. ActivityDefinition.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "ActivityDefinition.copyright",
                    Id = "ActivityDefinition.copyright",
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
                // 19. ActivityDefinition.approvalDate
                this.Element_ApprovalDate = new ElementDefinitionInfo
                {
                    Name = "Element_ApprovalDate",
                    Path= "ActivityDefinition.approvalDate",
                    Id = "ActivityDefinition.approvalDate",
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
                // 20. ActivityDefinition.lastReviewDate
                this.Element_LastReviewDate = new ElementDefinitionInfo
                {
                    Name = "Element_LastReviewDate",
                    Path= "ActivityDefinition.lastReviewDate",
                    Id = "ActivityDefinition.lastReviewDate",
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
                // 21. ActivityDefinition.effectivePeriod
                this.Element_EffectivePeriod = new ElementDefinitionInfo
                {
                    Name = "Element_EffectivePeriod",
                    Path= "ActivityDefinition.effectivePeriod",
                    Id = "ActivityDefinition.effectivePeriod",
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
                // 22. ActivityDefinition.topic
                this.Element_Topic = new ElementDefinitionInfo
                {
                    Name = "Element_Topic",
                    Path= "ActivityDefinition.topic",
                    Id = "ActivityDefinition.topic",
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
                // 23. ActivityDefinition.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "ActivityDefinition.author",
                    Id = "ActivityDefinition.author",
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
                // 24. ActivityDefinition.editor
                this.Element_Editor = new ElementDefinitionInfo
                {
                    Name = "Element_Editor",
                    Path= "ActivityDefinition.editor",
                    Id = "ActivityDefinition.editor",
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
                // 25. ActivityDefinition.reviewer
                this.Element_Reviewer = new ElementDefinitionInfo
                {
                    Name = "Element_Reviewer",
                    Path= "ActivityDefinition.reviewer",
                    Id = "ActivityDefinition.reviewer",
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
                // 26. ActivityDefinition.endorser
                this.Element_Endorser = new ElementDefinitionInfo
                {
                    Name = "Element_Endorser",
                    Path= "ActivityDefinition.endorser",
                    Id = "ActivityDefinition.endorser",
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
                // 27. ActivityDefinition.relatedArtifact
                this.Element_RelatedArtifact = new ElementDefinitionInfo
                {
                    Name = "Element_RelatedArtifact",
                    Path= "ActivityDefinition.relatedArtifact",
                    Id = "ActivityDefinition.relatedArtifact",
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
                // 28. ActivityDefinition.library
                this.Element_Library = new ElementDefinitionInfo
                {
                    Name = "Element_Library",
                    Path= "ActivityDefinition.library",
                    Id = "ActivityDefinition.library",
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
                // 29. ActivityDefinition.kind
                this.Element_Kind = new ElementDefinitionInfo
                {
                    Name = "Element_Kind",
                    Path= "ActivityDefinition.kind",
                    Id = "ActivityDefinition.kind",
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
                // 30. ActivityDefinition.profile
                this.Element_Profile = new ElementDefinitionInfo
                {
                    Name = "Element_Profile",
                    Path= "ActivityDefinition.profile",
                    Id = "ActivityDefinition.profile",
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
            {
                // 31. ActivityDefinition.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "ActivityDefinition.code",
                    Id = "ActivityDefinition.code",
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
                // 32. ActivityDefinition.intent
                this.Element_Intent = new ElementDefinitionInfo
                {
                    Name = "Element_Intent",
                    Path= "ActivityDefinition.intent",
                    Id = "ActivityDefinition.intent",
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
                // 33. ActivityDefinition.priority
                this.Element_Priority = new ElementDefinitionInfo
                {
                    Name = "Element_Priority",
                    Path= "ActivityDefinition.priority",
                    Id = "ActivityDefinition.priority",
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
                // 34. ActivityDefinition.doNotPerform
                this.Element_DoNotPerform = new ElementDefinitionInfo
                {
                    Name = "Element_DoNotPerform",
                    Path= "ActivityDefinition.doNotPerform",
                    Id = "ActivityDefinition.doNotPerform",
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
                // 35. ActivityDefinition.timing[x]
                this.Element_Timing = new ElementDefinitionInfo
                {
                    Name = "Element_Timing",
                    Path= "ActivityDefinition.timing[x]",
                    Id = "ActivityDefinition.timing[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Timing
                        {
                        },
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Age
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Period
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Range
                        {
                        },
                        new FhirKhit.Maker.Common.Complex.Type_Duration
                        {
                        }
                    }
                };
            }
            {
                // 36. ActivityDefinition.location
                this.Element_Location = new ElementDefinitionInfo
                {
                    Name = "Element_Location",
                    Path= "ActivityDefinition.location",
                    Id = "ActivityDefinition.location",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Location"
                            }
                        }
                    }
                };
            }
            {
                // 37. ActivityDefinition.participant
                this.Element_Participant = new ElementDefinitionInfo
                {
                    Name = "Element_Participant",
                    Path= "ActivityDefinition.participant",
                    Id = "ActivityDefinition.participant",
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
                // 40. ActivityDefinition.product[x]
                this.Element_Product = new ElementDefinitionInfo
                {
                    Name = "Element_Product",
                    Path= "ActivityDefinition.product[x]",
                    Id = "ActivityDefinition.product[x]",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Medication",
                                "http://hl7.org/fhir/StructureDefinition/Substance"
                            }
                        },
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                        {
                        }
                    }
                };
            }
            {
                // 41. ActivityDefinition.quantity
                this.Element_Quantity = new ElementDefinitionInfo
                {
                    Name = "Element_Quantity",
                    Path= "ActivityDefinition.quantity",
                    Id = "ActivityDefinition.quantity",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Quantity
                        {
                        }
                    }
                };
            }
            {
                // 42. ActivityDefinition.dosage
                this.Element_Dosage = new ElementDefinitionInfo
                {
                    Name = "Element_Dosage",
                    Path= "ActivityDefinition.dosage",
                    Id = "ActivityDefinition.dosage",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Dosage
                        {
                        }
                    }
                };
            }
            {
                // 43. ActivityDefinition.bodySite
                this.Element_BodySite = new ElementDefinitionInfo
                {
                    Name = "Element_BodySite",
                    Path= "ActivityDefinition.bodySite",
                    Id = "ActivityDefinition.bodySite",
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
                // 44. ActivityDefinition.specimenRequirement
                this.Element_SpecimenRequirement = new ElementDefinitionInfo
                {
                    Name = "Element_SpecimenRequirement",
                    Path= "ActivityDefinition.specimenRequirement",
                    Id = "ActivityDefinition.specimenRequirement",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/SpecimenDefinition"
                            }
                        }
                    }
                };
            }
            {
                // 45. ActivityDefinition.observationRequirement
                this.Element_ObservationRequirement = new ElementDefinitionInfo
                {
                    Name = "Element_ObservationRequirement",
                    Path= "ActivityDefinition.observationRequirement",
                    Id = "ActivityDefinition.observationRequirement",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ObservationDefinition"
                            }
                        }
                    }
                };
            }
            {
                // 46. ActivityDefinition.observationResultRequirement
                this.Element_ObservationResultRequirement = new ElementDefinitionInfo
                {
                    Name = "Element_ObservationResultRequirement",
                    Path= "ActivityDefinition.observationResultRequirement",
                    Id = "ActivityDefinition.observationResultRequirement",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/ObservationDefinition"
                            }
                        }
                    }
                };
            }
            {
                // 47. ActivityDefinition.transform
                this.Element_Transform = new ElementDefinitionInfo
                {
                    Name = "Element_Transform",
                    Path= "ActivityDefinition.transform",
                    Id = "ActivityDefinition.transform",
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
                // 48. ActivityDefinition.dynamicValue
                this.Element_DynamicValue = new ElementDefinitionInfo
                {
                    Name = "Element_DynamicValue",
                    Path= "ActivityDefinition.dynamicValue",
                    Id = "ActivityDefinition.dynamicValue",
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
            this.Name = "ActivityDefinition";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ActivityDefinition";
        }
    }
}
