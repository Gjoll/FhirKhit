using System;                                                                                                                               // MakerGen.cs:391
using System.Diagnostics;                                                                                                                   // MakerGen.cs:392
using System.IO;                                                                                                                            // MakerGen.cs:393
using System.Linq;                                                                                                                          // MakerGen.cs:394
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:396
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:397
{                                                                                                                                           // MakerGen.cs:398
    #region Json                                                                                                                            // MakerGen.cs:399
    #if NEVER                                                                                                                               // MakerGen.cs:400
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
    #endregion                                                                                                                              // MakerGen.cs:403
    /// <summary>
    /// Fhir resource 'Evidence'
    /// </summary>
    // 0. Evidence
    public class Evidence : FhirKhit.Maker.Common.Resource.ResourceBase                                                                     // MakerGen.cs:352
    {                                                                                                                                       // MakerGen.cs:353
        // 1. Evidence.url
        public MakerElementInstance Element_Url;                                                                                            // MakerGen.cs:232
        // 2. Evidence.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 3. Evidence.version
        public MakerElementInstance Element_Version;                                                                                        // MakerGen.cs:232
        // 4. Evidence.name
        public MakerElementInstance Element_Name;                                                                                           // MakerGen.cs:232
        // 5. Evidence.title
        public MakerElementInstance Element_Title;                                                                                          // MakerGen.cs:232
        // 6. Evidence.shortTitle
        public MakerElementInstance Element_ShortTitle;                                                                                     // MakerGen.cs:232
        // 7. Evidence.subtitle
        public MakerElementInstance Element_Subtitle;                                                                                       // MakerGen.cs:232
        // 8. Evidence.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 9. Evidence.date
        public MakerElementInstance Element_Date;                                                                                           // MakerGen.cs:232
        // 10. Evidence.publisher
        public MakerElementInstance Element_Publisher;                                                                                      // MakerGen.cs:232
        // 11. Evidence.contact
        public MakerElementInstance Element_Contact;                                                                                        // MakerGen.cs:232
        // 12. Evidence.description
        public MakerElementInstance Element_Description;                                                                                    // MakerGen.cs:232
        // 13. Evidence.note
        public MakerElementInstance Element_Note;                                                                                           // MakerGen.cs:232
        // 14. Evidence.useContext
        public MakerElementInstance Element_UseContext;                                                                                     // MakerGen.cs:232
        // 15. Evidence.jurisdiction
        public MakerElementInstance Element_Jurisdiction;                                                                                   // MakerGen.cs:232
        // 16. Evidence.copyright
        public MakerElementInstance Element_Copyright;                                                                                      // MakerGen.cs:232
        // 17. Evidence.approvalDate
        public MakerElementInstance Element_ApprovalDate;                                                                                   // MakerGen.cs:232
        // 18. Evidence.lastReviewDate
        public MakerElementInstance Element_LastReviewDate;                                                                                 // MakerGen.cs:232
        // 19. Evidence.effectivePeriod
        public MakerElementInstance Element_EffectivePeriod;                                                                                // MakerGen.cs:232
        // 20. Evidence.topic
        public MakerElementInstance Element_Topic;                                                                                          // MakerGen.cs:232
        // 21. Evidence.author
        public MakerElementInstance Element_Author;                                                                                         // MakerGen.cs:232
        // 22. Evidence.editor
        public MakerElementInstance Element_Editor;                                                                                         // MakerGen.cs:232
        // 23. Evidence.reviewer
        public MakerElementInstance Element_Reviewer;                                                                                       // MakerGen.cs:232
        // 24. Evidence.endorser
        public MakerElementInstance Element_Endorser;                                                                                       // MakerGen.cs:232
        // 25. Evidence.relatedArtifact
        public MakerElementInstance Element_RelatedArtifact;                                                                                // MakerGen.cs:232
        // 26. Evidence.exposureBackground
        public MakerElementInstance Element_ExposureBackground;                                                                             // MakerGen.cs:232
        // 27. Evidence.exposureVariant
        public MakerElementInstance Element_ExposureVariant;                                                                                // MakerGen.cs:232
        // 28. Evidence.outcome
        public MakerElementInstance Element_Outcome;                                                                                        // MakerGen.cs:232
        public Evidence()                                                                                                                   // MakerGen.cs:361
        {                                                                                                                                   // MakerGen.cs:362
            {                                                                                                                               // MakerGen.cs:243
                // 1. Evidence.url
                this.Element_Url = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Uri()                                                                           // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 2. Evidence.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 3. Evidence.version
                this.Element_Version = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Version",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 4. Evidence.name
                this.Element_Name = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 5. Evidence.title
                this.Element_Title = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Title",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 6. Evidence.shortTitle
                this.Element_ShortTitle = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ShortTitle",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 7. Evidence.subtitle
                this.Element_Subtitle = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Subtitle",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 8. Evidence.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 9. Evidence.date
                this.Element_Date = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 10. Evidence.publisher
                this.Element_Publisher = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String()                                                                        // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 11. Evidence.contact
                this.Element_Contact = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 12. Evidence.description
                this.Element_Description = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Description",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 13. Evidence.note
                this.Element_Note = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 14. Evidence.useContext
                this.Element_UseContext = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 15. Evidence.jurisdiction
                this.Element_Jurisdiction = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 16. Evidence.copyright
                this.Element_Copyright = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Copyright",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown()                                                                      // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 17. Evidence.approvalDate
                this.Element_ApprovalDate = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ApprovalDate",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Date()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 18. Evidence.lastReviewDate
                this.Element_LastReviewDate = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_LastReviewDate",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Date()                                                                          // MakerGen.cs:286
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 19. Evidence.effectivePeriod
                this.Element_EffectivePeriod = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_EffectivePeriod",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 20. Evidence.topic
                this.Element_Topic = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Topic",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept()                                                                 // MakerGen.cs:292
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 21. Evidence.author
                this.Element_Author = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Author",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 22. Evidence.editor
                this.Element_Editor = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Editor",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 23. Evidence.reviewer
                this.Element_Reviewer = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Reviewer",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 24. Evidence.endorser
                this.Element_Endorser = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Endorser",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 25. Evidence.relatedArtifact
                this.Element_RelatedArtifact = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_RelatedArtifact",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 26. Evidence.exposureBackground
                this.Element_ExposureBackground = new MakerElementInstance                                                                  // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ExposureBackground",                                                                                    // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 27. Evidence.exposureVariant
                this.Element_ExposureVariant = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ExposureVariant",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
            {                                                                                                                               // MakerGen.cs:243
                // 28. Evidence.outcome
                this.Element_Outcome = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Outcome",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBase_Type[]                                                                                            // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:334
        }                                                                                                                                   // MakerGen.cs:373
    }                                                                                                                                       // MakerGen.cs:357
}                                                                                                                                           // MakerGen.cs:408
