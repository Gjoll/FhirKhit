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
      "id": "Evidence",
      "url": "http://hl7.org/fhir/StructureDefinition/Evidence",
      "version": "4.0.0",
      "name": "Evidence",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Decision Support)",
      "description": "The Evidence resource describes the conditional state (population and any exposures being compared within the population) and outcome (if specified) that the knowledge (evidence, assertion, recommendation) is about.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Evidence",
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
            "id": "Evidence",
            "path": "Evidence",
            "short": "A research context or question",
            "definition": "The Evidence resource describes the conditional state (population and any exposures being compared within the population) and outcome (if specified) that the knowledge (evidence, assertion, recommendation) is about.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "Evidence.url",
            "path": "Evidence.url",
            "short": "Canonical identifier for this evidence, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this evidence when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this evidence is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the evidence is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the evidence to be referenced by a single globally unique identifier.",
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
            "id": "Evidence.identifier",
            "path": "Evidence.identifier",
            "short": "Additional identifier for the evidence",
            "definition": "A formal identifier that is used to identify this evidence when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this evidence outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "Evidence.version",
            "path": "Evidence.version",
            "short": "Business version of the evidence",
            "definition": "The identifier that is used to identify this version of the evidence when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the evidence author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence. To provide a version consistent with the Decision Support Service specification, use the format Major.Minor.Revision (e.g. 1.0.0). For more information on versioning knowledge assets, refer to the Decision Support Service specification. Note that a version is required for non-experimental active artifacts.",
            "comment": "There may be different evidence instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the evidence with the format [url]|[version].",
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
            "id": "Evidence.name",
            "path": "Evidence.name",
            "short": "Name for this evidence (computer friendly)",
            "definition": "A natural language name identifying the evidence. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "Evidence.title",
            "path": "Evidence.title",
            "short": "Name for this evidence (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the evidence.",
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
            "id": "Evidence.shortTitle",
            "path": "Evidence.shortTitle",
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
            "id": "Evidence.subtitle",
            "path": "Evidence.subtitle",
            "short": "Subordinate title of the Evidence",
            "definition": "An explanatory or alternate title for the Evidence giving additional information about its content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Evidence.status",
            "path": "Evidence.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this evidence. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of evidences that are appropriate for use versus not.",
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
            "id": "Evidence.date",
            "path": "Evidence.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the evidence was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the evidence changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the evidence. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "Evidence.publisher",
            "path": "Evidence.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the evidence.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the evidence is the organization or individual primarily responsible for the maintenance and upkeep of the evidence. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the evidence. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the evidence.  May also allow for contact.",
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
            "id": "Evidence.contact",
            "path": "Evidence.contact",
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
            "id": "Evidence.description",
            "path": "Evidence.description",
            "short": "Natural language description of the evidence",
            "definition": "A free text natural language description of the evidence from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the evidence was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the evidence as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the evidence is presumed to be the predominant language in the place the evidence was created).",
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
            "id": "Evidence.note",
            "path": "Evidence.note",
            "short": "Used for footnotes or explanatory notes",
            "definition": "A human-readable string to clarify or explain concepts about the resource.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "Evidence.useContext",
            "path": "Evidence.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate evidence instances.",
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
            "id": "Evidence.jurisdiction",
            "path": "Evidence.jurisdiction",
            "short": "Intended jurisdiction for evidence (if applicable)",
            "definition": "A legal or geographic region in which the evidence is intended to be used.",
            "comment": "It may be possible for the evidence to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "Evidence.copyright",
            "path": "Evidence.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the evidence and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the evidence.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the evidence and/or its content.",
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
            "id": "Evidence.approvalDate",
            "path": "Evidence.approvalDate",
            "short": "When the evidence was approved by publisher",
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
            "id": "Evidence.lastReviewDate",
            "path": "Evidence.lastReviewDate",
            "short": "When the evidence was last reviewed",
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
            "id": "Evidence.effectivePeriod",
            "path": "Evidence.effectivePeriod",
            "short": "When the evidence is expected to be used",
            "definition": "The period during which the evidence content was or is planned to be in active use.",
            "comment": "The effective period for a evidence  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.",
            "requirements": "Allows establishing a transition before a resource comes into effect and also allows for a sunsetting  process when new versions of the evidence are or are expected to be used instead.",
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
            "id": "Evidence.topic",
            "path": "Evidence.topic",
            "short": "The category of the Evidence, such as Education, Treatment, Assessment, etc.",
            "definition": "Descriptive topics related to the content of the Evidence. Topics provide a high-level categorization grouping types of Evidences that can be useful for filtering and searching.",
            "requirements": "Repositories must be able to determine how to categorize the Evidence so that it can be found by topical searches.",
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
            "id": "Evidence.author",
            "path": "Evidence.author",
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
            "id": "Evidence.editor",
            "path": "Evidence.editor",
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
            "id": "Evidence.reviewer",
            "path": "Evidence.reviewer",
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
            "id": "Evidence.endorser",
            "path": "Evidence.endorser",
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
            "id": "Evidence.relatedArtifact",
            "path": "Evidence.relatedArtifact",
            "short": "Additional documentation, citations, etc.",
            "definition": "Related artifacts such as additional documentation, justification, or bibliographic references.",
            "comment": "Each related artifact is either an attachment, or a reference to another resource, but not both.",
            "requirements": "Evidences must be able to provide enough information for consumers of the content (and/or interventions or results produced by the content) to be able to determine and understand the justification for and evidence in support of the content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "RelatedArtifact"
              }
            ]
          },
          {
            "id": "Evidence.exposureBackground",
            "path": "Evidence.exposureBackground",
            "short": "What population?",
            "definition": "A reference to a EvidenceVariable resource that defines the population for the research.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Evidence.exposureVariant",
            "path": "Evidence.exposureVariant",
            "short": "What exposure?",
            "definition": "A reference to a EvidenceVariable resource that defines the exposure for the research.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "Evidence.outcome",
            "path": "Evidence.outcome",
            "short": "What outcome?",
            "definition": "A reference to a EvidenceVariable resomece that defines the outcome for the research.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"
                ]
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'Evidence'
    /// </summary>
    // 0. Evidence
    public class Evidence : FhirKhit.Maker.Common.Resource.ResourceBase                                                                     // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class Evidence_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                        // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 1. Evidence.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:211
            // 2. Evidence.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 3. Evidence.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:211
            // 4. Evidence.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:211
            // 5. Evidence.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:211
            // 6. Evidence.shortTitle
            public ElementDefinitionInfo ShortTitle;                                                                                        // MakerGen.cs:211
            // 7. Evidence.subtitle
            public ElementDefinitionInfo Subtitle;                                                                                          // MakerGen.cs:211
            // 8. Evidence.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 9. Evidence.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:211
            // 10. Evidence.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:211
            // 11. Evidence.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:211
            // 12. Evidence.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:211
            // 13. Evidence.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:211
            // 14. Evidence.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:211
            // 15. Evidence.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:211
            // 16. Evidence.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:211
            // 17. Evidence.approvalDate
            public ElementDefinitionInfo ApprovalDate;                                                                                      // MakerGen.cs:211
            // 18. Evidence.lastReviewDate
            public ElementDefinitionInfo LastReviewDate;                                                                                    // MakerGen.cs:211
            // 19. Evidence.effectivePeriod
            public ElementDefinitionInfo EffectivePeriod;                                                                                   // MakerGen.cs:211
            // 20. Evidence.topic
            public ElementDefinitionInfo Topic;                                                                                             // MakerGen.cs:211
            // 21. Evidence.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:211
            // 22. Evidence.editor
            public ElementDefinitionInfo Editor;                                                                                            // MakerGen.cs:211
            // 23. Evidence.reviewer
            public ElementDefinitionInfo Reviewer;                                                                                          // MakerGen.cs:211
            // 24. Evidence.endorser
            public ElementDefinitionInfo Endorser;                                                                                          // MakerGen.cs:211
            // 25. Evidence.relatedArtifact
            public ElementDefinitionInfo RelatedArtifact;                                                                                   // MakerGen.cs:211
            // 26. Evidence.exposureBackground
            public ElementDefinitionInfo ExposureBackground;                                                                                // MakerGen.cs:211
            // 27. Evidence.exposureVariant
            public ElementDefinitionInfo ExposureVariant;                                                                                   // MakerGen.cs:211
            // 28. Evidence.outcome
            public ElementDefinitionInfo Outcome;                                                                                           // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public Evidence_Elements()                                                                                                      // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Evidence.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Url",                                                                                                       // MakerGen.cs:230
                        Path= "Evidence.url",                                                                                               // MakerGen.cs:231
                        Id = "Evidence.url",                                                                                                // MakerGen.cs:232
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
                    // 2. Evidence.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "Evidence.identifier",                                                                                        // MakerGen.cs:231
                        Id = "Evidence.identifier",                                                                                         // MakerGen.cs:232
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
                    // 3. Evidence.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Version",                                                                                                   // MakerGen.cs:230
                        Path= "Evidence.version",                                                                                           // MakerGen.cs:231
                        Id = "Evidence.version",                                                                                            // MakerGen.cs:232
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
                    // 4. Evidence.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Name",                                                                                                      // MakerGen.cs:230
                        Path= "Evidence.name",                                                                                              // MakerGen.cs:231
                        Id = "Evidence.name",                                                                                               // MakerGen.cs:232
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
                    // 5. Evidence.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Title",                                                                                                     // MakerGen.cs:230
                        Path= "Evidence.title",                                                                                             // MakerGen.cs:231
                        Id = "Evidence.title",                                                                                              // MakerGen.cs:232
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
                    // 6. Evidence.shortTitle
                    this.ShortTitle = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ShortTitle",                                                                                                // MakerGen.cs:230
                        Path= "Evidence.shortTitle",                                                                                        // MakerGen.cs:231
                        Id = "Evidence.shortTitle",                                                                                         // MakerGen.cs:232
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
                    // 7. Evidence.subtitle
                    this.Subtitle = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Subtitle",                                                                                                  // MakerGen.cs:230
                        Path= "Evidence.subtitle",                                                                                          // MakerGen.cs:231
                        Id = "Evidence.subtitle",                                                                                           // MakerGen.cs:232
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
                    // 8. Evidence.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "Evidence.status",                                                                                            // MakerGen.cs:231
                        Id = "Evidence.status",                                                                                             // MakerGen.cs:232
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
                    // 9. Evidence.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Date",                                                                                                      // MakerGen.cs:230
                        Path= "Evidence.date",                                                                                              // MakerGen.cs:231
                        Id = "Evidence.date",                                                                                               // MakerGen.cs:232
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
                    // 10. Evidence.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Publisher",                                                                                                 // MakerGen.cs:230
                        Path= "Evidence.publisher",                                                                                         // MakerGen.cs:231
                        Id = "Evidence.publisher",                                                                                          // MakerGen.cs:232
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
                    // 11. Evidence.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Contact",                                                                                                   // MakerGen.cs:230
                        Path= "Evidence.contact",                                                                                           // MakerGen.cs:231
                        Id = "Evidence.contact",                                                                                            // MakerGen.cs:232
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
                    // 12. Evidence.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Description",                                                                                               // MakerGen.cs:230
                        Path= "Evidence.description",                                                                                       // MakerGen.cs:231
                        Id = "Evidence.description",                                                                                        // MakerGen.cs:232
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
                    // 13. Evidence.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Note",                                                                                                      // MakerGen.cs:230
                        Path= "Evidence.note",                                                                                              // MakerGen.cs:231
                        Id = "Evidence.note",                                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. Evidence.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "UseContext",                                                                                                // MakerGen.cs:230
                        Path= "Evidence.useContext",                                                                                        // MakerGen.cs:231
                        Id = "Evidence.useContext",                                                                                         // MakerGen.cs:232
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
                    // 15. Evidence.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:230
                        Path= "Evidence.jurisdiction",                                                                                      // MakerGen.cs:231
                        Id = "Evidence.jurisdiction",                                                                                       // MakerGen.cs:232
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
                    // 16. Evidence.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Copyright",                                                                                                 // MakerGen.cs:230
                        Path= "Evidence.copyright",                                                                                         // MakerGen.cs:231
                        Id = "Evidence.copyright",                                                                                          // MakerGen.cs:232
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
                    // 17. Evidence.approvalDate
                    this.ApprovalDate = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ApprovalDate",                                                                                              // MakerGen.cs:230
                        Path= "Evidence.approvalDate",                                                                                      // MakerGen.cs:231
                        Id = "Evidence.approvalDate",                                                                                       // MakerGen.cs:232
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
                    // 18. Evidence.lastReviewDate
                    this.LastReviewDate = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "LastReviewDate",                                                                                            // MakerGen.cs:230
                        Path= "Evidence.lastReviewDate",                                                                                    // MakerGen.cs:231
                        Id = "Evidence.lastReviewDate",                                                                                     // MakerGen.cs:232
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
                    // 19. Evidence.effectivePeriod
                    this.EffectivePeriod = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "EffectivePeriod",                                                                                           // MakerGen.cs:230
                        Path= "Evidence.effectivePeriod",                                                                                   // MakerGen.cs:231
                        Id = "Evidence.effectivePeriod",                                                                                    // MakerGen.cs:232
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
                    // 20. Evidence.topic
                    this.Topic = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Topic",                                                                                                     // MakerGen.cs:230
                        Path= "Evidence.topic",                                                                                             // MakerGen.cs:231
                        Id = "Evidence.topic",                                                                                              // MakerGen.cs:232
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
                    // 21. Evidence.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Author",                                                                                                    // MakerGen.cs:230
                        Path= "Evidence.author",                                                                                            // MakerGen.cs:231
                        Id = "Evidence.author",                                                                                             // MakerGen.cs:232
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
                    // 22. Evidence.editor
                    this.Editor = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Editor",                                                                                                    // MakerGen.cs:230
                        Path= "Evidence.editor",                                                                                            // MakerGen.cs:231
                        Id = "Evidence.editor",                                                                                             // MakerGen.cs:232
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
                    // 23. Evidence.reviewer
                    this.Reviewer = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Reviewer",                                                                                                  // MakerGen.cs:230
                        Path= "Evidence.reviewer",                                                                                          // MakerGen.cs:231
                        Id = "Evidence.reviewer",                                                                                           // MakerGen.cs:232
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
                    // 24. Evidence.endorser
                    this.Endorser = new ElementDefinitionInfo                                                                               // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Endorser",                                                                                                  // MakerGen.cs:230
                        Path= "Evidence.endorser",                                                                                          // MakerGen.cs:231
                        Id = "Evidence.endorser",                                                                                           // MakerGen.cs:232
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
                    // 25. Evidence.relatedArtifact
                    this.RelatedArtifact = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "RelatedArtifact",                                                                                           // MakerGen.cs:230
                        Path= "Evidence.relatedArtifact",                                                                                   // MakerGen.cs:231
                        Id = "Evidence.relatedArtifact",                                                                                    // MakerGen.cs:232
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
                    // 26. Evidence.exposureBackground
                    this.ExposureBackground = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ExposureBackground",                                                                                        // MakerGen.cs:230
                        Path= "Evidence.exposureBackground",                                                                                // MakerGen.cs:231
                        Id = "Evidence.exposureBackground",                                                                                 // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                              // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 27. Evidence.exposureVariant
                    this.ExposureVariant = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ExposureVariant",                                                                                           // MakerGen.cs:230
                        Path= "Evidence.exposureVariant",                                                                                   // MakerGen.cs:231
                        Id = "Evidence.exposureVariant",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                              // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 28. Evidence.outcome
                    this.Outcome = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Outcome",                                                                                                   // MakerGen.cs:230
                        Path= "Evidence.outcome",                                                                                           // MakerGen.cs:231
                        Id = "Evidence.outcome",                                                                                            // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:341
                            {                                                                                                               // MakerGen.cs:342
                                TargetProfile = new String[]                                                                                // MakerGen.cs:344
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                              // MakerGen.cs:344
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:345
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
                ShortTitle.Write(sDef);                                                                                                     // MakerGen.cs:215
                Subtitle.Write(sDef);                                                                                                       // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                Date.Write(sDef);                                                                                                           // MakerGen.cs:215
                Publisher.Write(sDef);                                                                                                      // MakerGen.cs:215
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:215
                Description.Write(sDef);                                                                                                    // MakerGen.cs:215
                Note.Write(sDef);                                                                                                           // MakerGen.cs:215
                UseContext.Write(sDef);                                                                                                     // MakerGen.cs:215
                Jurisdiction.Write(sDef);                                                                                                   // MakerGen.cs:215
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
                ExposureBackground.Write(sDef);                                                                                             // MakerGen.cs:215
                ExposureVariant.Write(sDef);                                                                                                // MakerGen.cs:215
                Outcome.Write(sDef);                                                                                                        // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public Evidence_Elements Elements                                                                                                   // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new Evidence_Elements();                                                                                // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        Evidence_Elements elements;                                                                                                         // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public Evidence()                                                                                                                   // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "Evidence";                                                                                                         // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Evidence";                                                                  // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "Evidence",                                                                                                          // MakerGen.cs:423
                ElementId = "Evidence"                                                                                                      // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
