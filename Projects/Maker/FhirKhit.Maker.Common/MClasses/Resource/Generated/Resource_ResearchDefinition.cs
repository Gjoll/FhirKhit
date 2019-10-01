using System;                                                                                                                               // MakerGen.cs:454
using System.Diagnostics;                                                                                                                   // MakerGen.cs:455
using System.IO;                                                                                                                            // MakerGen.cs:456
using System.Linq;                                                                                                                          // MakerGen.cs:457
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:458
                                                                                                                                            // MakerGen.cs:459
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:460
{                                                                                                                                           // MakerGen.cs:461
    #region Json                                                                                                                            // MakerGen.cs:462
    #if NEVER                                                                                                                               // MakerGen.cs:463
    {
      "resourceType": "StructureDefinition",
      "id": "ResearchDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/ResearchDefinition",
      "version": "4.0.0",
      "name": "ResearchDefinition",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Decision Support)",
      "description": "The ResearchDefinition resource describes the conditional state (population and any exposures being compared within the population) and outcome (if specified) that the knowledge (evidence, assertion, recommendation) is about.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "ResearchDefinition",
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
            "id": "ResearchDefinition",
            "path": "ResearchDefinition",
            "short": "A research context or question",
            "definition": "The ResearchDefinition resource describes the conditional state (population and any exposures being compared within the population) and outcome (if specified) that the knowledge (evidence, assertion, recommendation) is about.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "ResearchDefinition.url",
            "path": "ResearchDefinition.url",
            "short": "Canonical identifier for this research definition, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this research definition when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this research definition is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the research definition is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the research definition to be referenced by a single globally unique identifier.",
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
            "id": "ResearchDefinition.identifier",
            "path": "ResearchDefinition.identifier",
            "short": "Additional identifier for the research definition",
            "definition": "A formal identifier that is used to identify this research definition when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this research definition outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "ResearchDefinition.version",
            "path": "ResearchDefinition.version",
            "short": "Business version of the research definition",
            "definition": "The identifier that is used to identify this version of the research definition when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the research definition author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence. To provide a version consistent with the Decision Support Service specification, use the format Major.Minor.Revision (e.g. 1.0.0). For more information on versioning knowledge assets, refer to the Decision Support Service specification. Note that a version is required for non-experimental active artifacts.",
            "comment": "There may be different research definition instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the research definition with the format [url]|[version].",
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
            "id": "ResearchDefinition.name",
            "path": "ResearchDefinition.name",
            "short": "Name for this research definition (computer friendly)",
            "definition": "A natural language name identifying the research definition. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "ResearchDefinition.title",
            "path": "ResearchDefinition.title",
            "short": "Name for this research definition (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the research definition.",
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
            "id": "ResearchDefinition.shortTitle",
            "path": "ResearchDefinition.shortTitle",
            "short": "Title for use in informal contexts",
            "definition": "The short title provides an alternate title for use in informal descriptive contexts where the full, formal title is not necessary.",
            "requirements": "Need to be able to reference the content by a short description, but still provide a longer, more formal title for the content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchDefinition.subtitle",
            "path": "ResearchDefinition.subtitle",
            "short": "Subordinate title of the ResearchDefinition",
            "definition": "An explanatory or alternate title for the ResearchDefinition giving additional information about its content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchDefinition.status",
            "path": "ResearchDefinition.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this research definition. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of research definitions that are appropriate for use versus not.",
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
            "id": "ResearchDefinition.experimental",
            "path": "ResearchDefinition.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this research definition is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of research definitions that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level research definition.",
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
            "id": "ResearchDefinition.subject[x]",
            "path": "ResearchDefinition.subject[x]",
            "short": "E.g. Patient, Practitioner, RelatedPerson, Organization, Location, Device",
            "definition": "The intended subjects for the ResearchDefinition. If this element is not provided, a Patient subject is assumed, but the subject of the ResearchDefinition can be anything.",
            "comment": "The subject of the ResearchDefinition is critical in interpreting the criteria definitions, as the logic in the ResearchDefinitions is evaluated with respect to a particular subject. This corresponds roughly to the notion of a Compartment in that it limits what content is available based on its relationship to the subject. In CQL, this corresponds to the context declaration.",
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
              "description": "The possible types of subjects for the research (E.g. Patient, Practitioner, Organization, Location, etc.).",
              "valueSet": "http://hl7.org/fhir/ValueSet/subject-type"
            }
          },
          {
            "id": "ResearchDefinition.date",
            "path": "ResearchDefinition.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the research definition was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the research definition changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the research definition. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "ResearchDefinition.publisher",
            "path": "ResearchDefinition.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the research definition.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the research definition is the organization or individual primarily responsible for the maintenance and upkeep of the research definition. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the research definition. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the research definition.  May also allow for contact.",
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
            "id": "ResearchDefinition.contact",
            "path": "ResearchDefinition.contact",
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
            "id": "ResearchDefinition.description",
            "path": "ResearchDefinition.description",
            "short": "Natural language description of the research definition",
            "definition": "A free text natural language description of the research definition from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the research definition was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the research definition as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the research definition is presumed to be the predominant language in the place the research definition was created).",
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
            "id": "ResearchDefinition.comment",
            "path": "ResearchDefinition.comment",
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
            "id": "ResearchDefinition.useContext",
            "path": "ResearchDefinition.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate research definition instances.",
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
            "id": "ResearchDefinition.jurisdiction",
            "path": "ResearchDefinition.jurisdiction",
            "short": "Intended jurisdiction for research definition (if applicable)",
            "definition": "A legal or geographic region in which the research definition is intended to be used.",
            "comment": "It may be possible for the research definition to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "ResearchDefinition.purpose",
            "path": "ResearchDefinition.purpose",
            "short": "Why this research definition is defined",
            "definition": "Explanation of why this research definition is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the research definition. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this research definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "ResearchDefinition.usage",
            "path": "ResearchDefinition.usage",
            "short": "Describes the clinical usage of the ResearchDefinition",
            "definition": "A detailed description, from a clinical perspective, of how the ResearchDefinition is used.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "ResearchDefinition.copyright",
            "path": "ResearchDefinition.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the research definition and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the research definition.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the research definition and/or its content.",
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
            "id": "ResearchDefinition.approvalDate",
            "path": "ResearchDefinition.approvalDate",
            "short": "When the research definition was approved by publisher",
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
            "id": "ResearchDefinition.lastReviewDate",
            "path": "ResearchDefinition.lastReviewDate",
            "short": "When the research definition was last reviewed",
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
            "id": "ResearchDefinition.effectivePeriod",
            "path": "ResearchDefinition.effectivePeriod",
            "short": "When the research definition is expected to be used",
            "definition": "The period during which the research definition content was or is planned to be in active use.",
            "comment": "The effective period for a research definition  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.",
            "requirements": "Allows establishing a transition before a resource comes into effect and also allows for a sunsetting  process when new versions of the research definition are or are expected to be used instead.",
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
            "id": "ResearchDefinition.topic",
            "path": "ResearchDefinition.topic",
            "short": "The category of the ResearchDefinition, such as Education, Treatment, Assessment, etc.",
            "definition": "Descriptive topics related to the content of the ResearchDefinition. Topics provide a high-level categorization grouping types of ResearchDefinitions that can be useful for filtering and searching.",
            "requirements": "Repositories must be able to determine how to categorize the ResearchDefinition so that it can be found by topical searches.",
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
            "id": "ResearchDefinition.author",
            "path": "ResearchDefinition.author",
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
            "id": "ResearchDefinition.editor",
            "path": "ResearchDefinition.editor",
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
            "id": "ResearchDefinition.reviewer",
            "path": "ResearchDefinition.reviewer",
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
            "id": "ResearchDefinition.endorser",
            "path": "ResearchDefinition.endorser",
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
            "id": "ResearchDefinition.relatedArtifact",
            "path": "ResearchDefinition.relatedArtifact",
            "short": "Additional documentation, citations, etc.",
            "definition": "Related artifacts such as additional documentation, justification, or bibliographic references.",
            "comment": "Each related artifact is either an attachment, or a reference to another resource, but not both.",
            "requirements": "ResearchDefinitions must be able to provide enough information for consumers of the content (and/or interventions or results produced by the content) to be able to determine and understand the justification for and evidence in support of the content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "RelatedArtifact"
              }
            ]
          },
          {
            "id": "ResearchDefinition.library",
            "path": "ResearchDefinition.library",
            "short": "Logic used by the ResearchDefinition",
            "definition": "A reference to a Library resource containing the formal logic used by the ResearchDefinition.",
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
            "id": "ResearchDefinition.population",
            "path": "ResearchDefinition.population",
            "short": "What population?",
            "definition": "A reference to a ResearchElementDefinition resource that defines the population for the research.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ResearchElementDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchDefinition.exposure",
            "path": "ResearchDefinition.exposure",
            "short": "What exposure?",
            "definition": "A reference to a ResearchElementDefinition resource that defines the exposure for the research.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ResearchElementDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchDefinition.exposureAlternative",
            "path": "ResearchDefinition.exposureAlternative",
            "short": "What alternative exposure state?",
            "definition": "A reference to a ResearchElementDefinition resource that defines the exposureAlternative for the research.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ResearchElementDefinition"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "ResearchDefinition.outcome",
            "path": "ResearchDefinition.outcome",
            "short": "What outcome?",
            "definition": "A reference to a ResearchElementDefinition resomece that defines the outcome for the research.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ResearchElementDefinition"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:466
    /// <summary>
    /// Fhir resource 'ResearchDefinition'
    /// </summary>
    // 0. ResearchDefinition
    public class Resource_ResearchDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                                  // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        public class Resource_ResearchDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:378
        {                                                                                                                                   // MakerGen.cs:379
            // 1. ResearchDefinition.url
            public ElementDefinitionInfo Element_Url;                                                                                       // MakerGen.cs:211
            // 2. ResearchDefinition.identifier
            public ElementDefinitionInfo Element_Identifier;                                                                                // MakerGen.cs:211
            // 3. ResearchDefinition.version
            public ElementDefinitionInfo Element_Version;                                                                                   // MakerGen.cs:211
            // 4. ResearchDefinition.name
            public ElementDefinitionInfo Element_Name;                                                                                      // MakerGen.cs:211
            // 5. ResearchDefinition.title
            public ElementDefinitionInfo Element_Title;                                                                                     // MakerGen.cs:211
            // 6. ResearchDefinition.shortTitle
            public ElementDefinitionInfo Element_ShortTitle;                                                                                // MakerGen.cs:211
            // 7. ResearchDefinition.subtitle
            public ElementDefinitionInfo Element_Subtitle;                                                                                  // MakerGen.cs:211
            // 8. ResearchDefinition.status
            public ElementDefinitionInfo Element_Status;                                                                                    // MakerGen.cs:211
            // 9. ResearchDefinition.experimental
            public ElementDefinitionInfo Element_Experimental;                                                                              // MakerGen.cs:211
            // 10. ResearchDefinition.subject[x]
            public ElementDefinitionInfo Element_Subject;                                                                                   // MakerGen.cs:211
            // 11. ResearchDefinition.date
            public ElementDefinitionInfo Element_Date;                                                                                      // MakerGen.cs:211
            // 12. ResearchDefinition.publisher
            public ElementDefinitionInfo Element_Publisher;                                                                                 // MakerGen.cs:211
            // 13. ResearchDefinition.contact
            public ElementDefinitionInfo Element_Contact;                                                                                   // MakerGen.cs:211
            // 14. ResearchDefinition.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:211
            // 15. ResearchDefinition.comment
            public ElementDefinitionInfo Element_Comment;                                                                                   // MakerGen.cs:211
            // 16. ResearchDefinition.useContext
            public ElementDefinitionInfo Element_UseContext;                                                                                // MakerGen.cs:211
            // 17. ResearchDefinition.jurisdiction
            public ElementDefinitionInfo Element_Jurisdiction;                                                                              // MakerGen.cs:211
            // 18. ResearchDefinition.purpose
            public ElementDefinitionInfo Element_Purpose;                                                                                   // MakerGen.cs:211
            // 19. ResearchDefinition.usage
            public ElementDefinitionInfo Element_Usage;                                                                                     // MakerGen.cs:211
            // 20. ResearchDefinition.copyright
            public ElementDefinitionInfo Element_Copyright;                                                                                 // MakerGen.cs:211
            // 21. ResearchDefinition.approvalDate
            public ElementDefinitionInfo Element_ApprovalDate;                                                                              // MakerGen.cs:211
            // 22. ResearchDefinition.lastReviewDate
            public ElementDefinitionInfo Element_LastReviewDate;                                                                            // MakerGen.cs:211
            // 23. ResearchDefinition.effectivePeriod
            public ElementDefinitionInfo Element_EffectivePeriod;                                                                           // MakerGen.cs:211
            // 24. ResearchDefinition.topic
            public ElementDefinitionInfo Element_Topic;                                                                                     // MakerGen.cs:211
            // 25. ResearchDefinition.author
            public ElementDefinitionInfo Element_Author;                                                                                    // MakerGen.cs:211
            // 26. ResearchDefinition.editor
            public ElementDefinitionInfo Element_Editor;                                                                                    // MakerGen.cs:211
            // 27. ResearchDefinition.reviewer
            public ElementDefinitionInfo Element_Reviewer;                                                                                  // MakerGen.cs:211
            // 28. ResearchDefinition.endorser
            public ElementDefinitionInfo Element_Endorser;                                                                                  // MakerGen.cs:211
            // 29. ResearchDefinition.relatedArtifact
            public ElementDefinitionInfo Element_RelatedArtifact;                                                                           // MakerGen.cs:211
            // 30. ResearchDefinition.library
            public ElementDefinitionInfo Element_Library;                                                                                   // MakerGen.cs:211
            // 31. ResearchDefinition.population
            public ElementDefinitionInfo Element_Population;                                                                                // MakerGen.cs:211
            // 32. ResearchDefinition.exposure
            public ElementDefinitionInfo Element_Exposure;                                                                                  // MakerGen.cs:211
            // 33. ResearchDefinition.exposureAlternative
            public ElementDefinitionInfo Element_ExposureAlternative;                                                                       // MakerGen.cs:211
            // 34. ResearchDefinition.outcome
            public ElementDefinitionInfo Element_Outcome;                                                                                   // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:383
            public Resource_ResearchDefinition_Elements()                                                                                   // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                {                                                                                                                           // MakerGen.cs:226
                    // 1. ResearchDefinition.url
                    this.Element_Url = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Url",                                                                                               // MakerGen.cs:230
                        Path= "ResearchDefinition.url",                                                                                     // MakerGen.cs:231
                        Id = "ResearchDefinition.url",                                                                                      // MakerGen.cs:232
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
                    // 2. ResearchDefinition.identifier
                    this.Element_Identifier = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Identifier",                                                                                        // MakerGen.cs:230
                        Path= "ResearchDefinition.identifier",                                                                              // MakerGen.cs:231
                        Id = "ResearchDefinition.identifier",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Identifier                                                               // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. ResearchDefinition.version
                    this.Element_Version = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Version",                                                                                           // MakerGen.cs:230
                        Path= "ResearchDefinition.version",                                                                                 // MakerGen.cs:231
                        Id = "ResearchDefinition.version",                                                                                  // MakerGen.cs:232
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
                    // 4. ResearchDefinition.name
                    this.Element_Name = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Name",                                                                                              // MakerGen.cs:230
                        Path= "ResearchDefinition.name",                                                                                    // MakerGen.cs:231
                        Id = "ResearchDefinition.name",                                                                                     // MakerGen.cs:232
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
                    // 5. ResearchDefinition.title
                    this.Element_Title = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Title",                                                                                             // MakerGen.cs:230
                        Path= "ResearchDefinition.title",                                                                                   // MakerGen.cs:231
                        Id = "ResearchDefinition.title",                                                                                    // MakerGen.cs:232
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
                    // 6. ResearchDefinition.shortTitle
                    this.Element_ShortTitle = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ShortTitle",                                                                                        // MakerGen.cs:230
                        Path= "ResearchDefinition.shortTitle",                                                                              // MakerGen.cs:231
                        Id = "ResearchDefinition.shortTitle",                                                                               // MakerGen.cs:232
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
                    // 7. ResearchDefinition.subtitle
                    this.Element_Subtitle = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Subtitle",                                                                                          // MakerGen.cs:230
                        Path= "ResearchDefinition.subtitle",                                                                                // MakerGen.cs:231
                        Id = "ResearchDefinition.subtitle",                                                                                 // MakerGen.cs:232
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
                    // 8. ResearchDefinition.status
                    this.Element_Status = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Status",                                                                                            // MakerGen.cs:230
                        Path= "ResearchDefinition.status",                                                                                  // MakerGen.cs:231
                        Id = "ResearchDefinition.status",                                                                                   // MakerGen.cs:232
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
                    // 9. ResearchDefinition.experimental
                    this.Element_Experimental = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Experimental",                                                                                      // MakerGen.cs:230
                        Path= "ResearchDefinition.experimental",                                                                            // MakerGen.cs:231
                        Id = "ResearchDefinition.experimental",                                                                             // MakerGen.cs:232
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
                    // 10. ResearchDefinition.subject[x]
                    this.Element_Subject = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Subject",                                                                                           // MakerGen.cs:230
                        Path= "ResearchDefinition.subject[x]",                                                                              // MakerGen.cs:231
                        Id = "ResearchDefinition.subject[x]",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            },                                                                                                              // MakerGen.cs:314
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. ResearchDefinition.date
                    this.Element_Date = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Date",                                                                                              // MakerGen.cs:230
                        Path= "ResearchDefinition.date",                                                                                    // MakerGen.cs:231
                        Id = "ResearchDefinition.date",                                                                                     // MakerGen.cs:232
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
                    // 12. ResearchDefinition.publisher
                    this.Element_Publisher = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Publisher",                                                                                         // MakerGen.cs:230
                        Path= "ResearchDefinition.publisher",                                                                               // MakerGen.cs:231
                        Id = "ResearchDefinition.publisher",                                                                                // MakerGen.cs:232
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
                    // 13. ResearchDefinition.contact
                    this.Element_Contact = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Contact",                                                                                           // MakerGen.cs:230
                        Path= "ResearchDefinition.contact",                                                                                 // MakerGen.cs:231
                        Id = "ResearchDefinition.contact",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                            // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. ResearchDefinition.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Description",                                                                                       // MakerGen.cs:230
                        Path= "ResearchDefinition.description",                                                                             // MakerGen.cs:231
                        Id = "ResearchDefinition.description",                                                                              // MakerGen.cs:232
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
                    // 15. ResearchDefinition.comment
                    this.Element_Comment = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Comment",                                                                                           // MakerGen.cs:230
                        Path= "ResearchDefinition.comment",                                                                                 // MakerGen.cs:231
                        Id = "ResearchDefinition.comment",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. ResearchDefinition.useContext
                    this.Element_UseContext = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_UseContext",                                                                                        // MakerGen.cs:230
                        Path= "ResearchDefinition.useContext",                                                                              // MakerGen.cs:231
                        Id = "ResearchDefinition.useContext",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_UsageContext                                                             // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 17. ResearchDefinition.jurisdiction
                    this.Element_Jurisdiction = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Jurisdiction",                                                                                      // MakerGen.cs:230
                        Path= "ResearchDefinition.jurisdiction",                                                                            // MakerGen.cs:231
                        Id = "ResearchDefinition.jurisdiction",                                                                             // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 18. ResearchDefinition.purpose
                    this.Element_Purpose = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Purpose",                                                                                           // MakerGen.cs:230
                        Path= "ResearchDefinition.purpose",                                                                                 // MakerGen.cs:231
                        Id = "ResearchDefinition.purpose",                                                                                  // MakerGen.cs:232
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
                    // 19. ResearchDefinition.usage
                    this.Element_Usage = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Usage",                                                                                             // MakerGen.cs:230
                        Path= "ResearchDefinition.usage",                                                                                   // MakerGen.cs:231
                        Id = "ResearchDefinition.usage",                                                                                    // MakerGen.cs:232
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
                    // 20. ResearchDefinition.copyright
                    this.Element_Copyright = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Copyright",                                                                                         // MakerGen.cs:230
                        Path= "ResearchDefinition.copyright",                                                                               // MakerGen.cs:231
                        Id = "ResearchDefinition.copyright",                                                                                // MakerGen.cs:232
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
                    // 21. ResearchDefinition.approvalDate
                    this.Element_ApprovalDate = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ApprovalDate",                                                                                      // MakerGen.cs:230
                        Path= "ResearchDefinition.approvalDate",                                                                            // MakerGen.cs:231
                        Id = "ResearchDefinition.approvalDate",                                                                             // MakerGen.cs:232
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
                    // 22. ResearchDefinition.lastReviewDate
                    this.Element_LastReviewDate = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_LastReviewDate",                                                                                    // MakerGen.cs:230
                        Path= "ResearchDefinition.lastReviewDate",                                                                          // MakerGen.cs:231
                        Id = "ResearchDefinition.lastReviewDate",                                                                           // MakerGen.cs:232
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
                    // 23. ResearchDefinition.effectivePeriod
                    this.Element_EffectivePeriod = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_EffectivePeriod",                                                                                   // MakerGen.cs:230
                        Path= "ResearchDefinition.effectivePeriod",                                                                         // MakerGen.cs:231
                        Id = "ResearchDefinition.effectivePeriod",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Period                                                                   // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 24. ResearchDefinition.topic
                    this.Element_Topic = new ElementDefinitionInfo                                                                          // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Topic",                                                                                             // MakerGen.cs:230
                        Path= "ResearchDefinition.topic",                                                                                   // MakerGen.cs:231
                        Id = "ResearchDefinition.topic",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 25. ResearchDefinition.author
                    this.Element_Author = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Author",                                                                                            // MakerGen.cs:230
                        Path= "ResearchDefinition.author",                                                                                  // MakerGen.cs:231
                        Id = "ResearchDefinition.author",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                            // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 26. ResearchDefinition.editor
                    this.Element_Editor = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Editor",                                                                                            // MakerGen.cs:230
                        Path= "ResearchDefinition.editor",                                                                                  // MakerGen.cs:231
                        Id = "ResearchDefinition.editor",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                            // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 27. ResearchDefinition.reviewer
                    this.Element_Reviewer = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Reviewer",                                                                                          // MakerGen.cs:230
                        Path= "ResearchDefinition.reviewer",                                                                                // MakerGen.cs:231
                        Id = "ResearchDefinition.reviewer",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                            // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 28. ResearchDefinition.endorser
                    this.Element_Endorser = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Endorser",                                                                                          // MakerGen.cs:230
                        Path= "ResearchDefinition.endorser",                                                                                // MakerGen.cs:231
                        Id = "ResearchDefinition.endorser",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                            // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 29. ResearchDefinition.relatedArtifact
                    this.Element_RelatedArtifact = new ElementDefinitionInfo                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_RelatedArtifact",                                                                                   // MakerGen.cs:230
                        Path= "ResearchDefinition.relatedArtifact",                                                                         // MakerGen.cs:231
                        Id = "ResearchDefinition.relatedArtifact",                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_RelatedArtifact                                                          // MakerGen.cs:350
                            {                                                                                                               // MakerGen.cs:351
                            }                                                                                                               // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 30. ResearchDefinition.library
                    this.Element_Library = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Library",                                                                                           // MakerGen.cs:230
                        Path= "ResearchDefinition.library",                                                                                 // MakerGen.cs:231
                        Id = "ResearchDefinition.library",                                                                                  // MakerGen.cs:232
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
                    // 31. ResearchDefinition.population
                    this.Element_Population = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Population",                                                                                        // MakerGen.cs:230
                        Path= "ResearchDefinition.population",                                                                              // MakerGen.cs:231
                        Id = "ResearchDefinition.population",                                                                               // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ResearchElementDefinition"                                     // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 32. ResearchDefinition.exposure
                    this.Element_Exposure = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Exposure",                                                                                          // MakerGen.cs:230
                        Path= "ResearchDefinition.exposure",                                                                                // MakerGen.cs:231
                        Id = "ResearchDefinition.exposure",                                                                                 // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ResearchElementDefinition"                                     // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 33. ResearchDefinition.exposureAlternative
                    this.Element_ExposureAlternative = new ElementDefinitionInfo                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_ExposureAlternative",                                                                               // MakerGen.cs:230
                        Path= "ResearchDefinition.exposureAlternative",                                                                     // MakerGen.cs:231
                        Id = "ResearchDefinition.exposureAlternative",                                                                      // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ResearchElementDefinition"                                     // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 34. ResearchDefinition.outcome
                    this.Element_Outcome = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Element_Outcome",                                                                                           // MakerGen.cs:230
                        Path= "ResearchDefinition.outcome",                                                                                 // MakerGen.cs:231
                        Id = "ResearchDefinition.outcome",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:338
                            {                                                                                                               // MakerGen.cs:339
                                TargetProfile = new String[]                                                                                // MakerGen.cs:341
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/ResearchElementDefinition"                                     // MakerGen.cs:341
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:342
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:387
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                Element_Url.Write(sDef);                                                                                                    // MakerGen.cs:215
                Element_Identifier.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Version.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Name.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Title.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_ShortTitle.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Subtitle.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Status.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Experimental.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_Subject.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Date.Write(sDef);                                                                                                   // MakerGen.cs:215
                Element_Publisher.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_Contact.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:215
                Element_Comment.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_UseContext.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Jurisdiction.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_Purpose.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Usage.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Copyright.Write(sDef);                                                                                              // MakerGen.cs:215
                Element_ApprovalDate.Write(sDef);                                                                                           // MakerGen.cs:215
                Element_LastReviewDate.Write(sDef);                                                                                         // MakerGen.cs:215
                Element_EffectivePeriod.Write(sDef);                                                                                        // MakerGen.cs:215
                Element_Topic.Write(sDef);                                                                                                  // MakerGen.cs:215
                Element_Author.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Editor.Write(sDef);                                                                                                 // MakerGen.cs:215
                Element_Reviewer.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_Endorser.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_RelatedArtifact.Write(sDef);                                                                                        // MakerGen.cs:215
                Element_Library.Write(sDef);                                                                                                // MakerGen.cs:215
                Element_Population.Write(sDef);                                                                                             // MakerGen.cs:215
                Element_Exposure.Write(sDef);                                                                                               // MakerGen.cs:215
                Element_ExposureAlternative.Write(sDef);                                                                                    // MakerGen.cs:215
                Element_Outcome.Write(sDef);                                                                                                // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:394
        }                                                                                                                                   // MakerGen.cs:396
        public Resource_ResearchDefinition_Elements Elements                                                                                // MakerGen.cs:398
        {                                                                                                                                   // MakerGen.cs:399
            get                                                                                                                             // MakerGen.cs:400
            {                                                                                                                               // MakerGen.cs:401
                if (this.elements == null)                                                                                                  // MakerGen.cs:402
                    this.elements = new Resource_ResearchDefinition_Elements();                                                             // MakerGen.cs:403
                return this.elements;                                                                                                       // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:406
        Resource_ResearchDefinition_Elements elements;                                                                                      // MakerGen.cs:407
                                                                                                                                            // MakerGen.cs:409
        public Resource_ResearchDefinition()                                                                                                // MakerGen.cs:410
        {                                                                                                                                   // MakerGen.cs:411
            this.Name = "ResearchDefinition";                                                                                               // MakerGen.cs:484
            this.Uri = "http://hl7.org/fhir/StructureDefinition/ResearchDefinition";                                                        // MakerGen.cs:485
        }                                                                                                                                   // MakerGen.cs:413
                                                                                                                                            // MakerGen.cs:415
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:416
        {                                                                                                                                   // MakerGen.cs:417
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:418
            {                                                                                                                               // MakerGen.cs:419
                Path = "ResearchDefinition",                                                                                                // MakerGen.cs:420
                ElementId = "ResearchDefinition"                                                                                            // MakerGen.cs:421
            });                                                                                                                             // MakerGen.cs:422
            if (this.elements != null)                                                                                                      // MakerGen.cs:423
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:424
        }                                                                                                                                   // MakerGen.cs:425
    }                                                                                                                                       // MakerGen.cs:426
}                                                                                                                                           // MakerGen.cs:471
