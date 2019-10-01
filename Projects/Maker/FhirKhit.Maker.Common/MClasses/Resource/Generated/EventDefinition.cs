using System;                                                                                                                               // MakerGen.cs:449
using System.Diagnostics;                                                                                                                   // MakerGen.cs:450
using System.IO;                                                                                                                            // MakerGen.cs:451
using System.Linq;                                                                                                                          // MakerGen.cs:452
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:453
                                                                                                                                            // MakerGen.cs:454
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:455
{                                                                                                                                           // MakerGen.cs:456
    #region Json                                                                                                                            // MakerGen.cs:457
    #if NEVER                                                                                                                               // MakerGen.cs:458
    {
      "resourceType": "StructureDefinition",
      "id": "EventDefinition",
      "url": "http://hl7.org/fhir/StructureDefinition/EventDefinition",
      "version": "4.0.0",
      "name": "EventDefinition",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Decision Support)",
      "description": "The EventDefinition resource provides a reusable description of when a particular event can occur.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "EventDefinition",
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
            "id": "EventDefinition",
            "path": "EventDefinition",
            "short": "A description of when an event can occur",
            "definition": "The EventDefinition resource provides a reusable description of when a particular event can occur.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "EventDefinition.url",
            "path": "EventDefinition.url",
            "short": "Canonical identifier for this event definition, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this event definition when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this event definition is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the event definition is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the event definition to be referenced by a single globally unique identifier.",
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
            "id": "EventDefinition.identifier",
            "path": "EventDefinition.identifier",
            "short": "Additional identifier for the event definition",
            "definition": "A formal identifier that is used to identify this event definition when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this event definition outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "EventDefinition.version",
            "path": "EventDefinition.version",
            "short": "Business version of the event definition",
            "definition": "The identifier that is used to identify this version of the event definition when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the event definition author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different event definition instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the event definition with the format [url]|[version].",
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
            "id": "EventDefinition.name",
            "path": "EventDefinition.name",
            "short": "Name for this event definition (computer friendly)",
            "definition": "A natural language name identifying the event definition. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "EventDefinition.title",
            "path": "EventDefinition.title",
            "short": "Name for this event definition (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the event definition.",
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
            "id": "EventDefinition.subtitle",
            "path": "EventDefinition.subtitle",
            "short": "Subordinate title of the event definition",
            "definition": "An explanatory or alternate title for the event definition giving additional information about its content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "EventDefinition.status",
            "path": "EventDefinition.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this event definition. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of event definitions that are appropriate for use versus not.",
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
            "id": "EventDefinition.experimental",
            "path": "EventDefinition.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this event definition is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of event definitions that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level event definition.",
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
            "id": "EventDefinition.subject[x]",
            "path": "EventDefinition.subject[x]",
            "short": "Type of individual the event definition is focused on",
            "definition": "A code or group definition that describes the intended subject of the event definition.",
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
              "description": "The possible types of subjects for an event (E.g. Patient, Practitioner, Organization, Location, etc.).",
              "valueSet": "http://hl7.org/fhir/ValueSet/subject-type"
            }
          },
          {
            "id": "EventDefinition.date",
            "path": "EventDefinition.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the event definition was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the event definition changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the event definition. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "EventDefinition.publisher",
            "path": "EventDefinition.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the event definition.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the event definition is the organization or individual primarily responsible for the maintenance and upkeep of the event definition. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the event definition. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the event definition.  May also allow for contact.",
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
            "id": "EventDefinition.contact",
            "path": "EventDefinition.contact",
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
            "id": "EventDefinition.description",
            "path": "EventDefinition.description",
            "short": "Natural language description of the event definition",
            "definition": "A free text natural language description of the event definition from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the event definition was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the event definition as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the event definition is presumed to be the predominant language in the place the event definition was created).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "EventDefinition.useContext",
            "path": "EventDefinition.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate event definition instances.",
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
            "id": "EventDefinition.jurisdiction",
            "path": "EventDefinition.jurisdiction",
            "short": "Intended jurisdiction for event definition (if applicable)",
            "definition": "A legal or geographic region in which the event definition is intended to be used.",
            "comment": "It may be possible for the event definition to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "EventDefinition.purpose",
            "path": "EventDefinition.purpose",
            "short": "Why this event definition is defined",
            "definition": "Explanation of why this event definition is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the event definition. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this event definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "EventDefinition.usage",
            "path": "EventDefinition.usage",
            "short": "Describes the clinical usage of the event definition",
            "definition": "A detailed description of how the event definition is used from a clinical perspective.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "EventDefinition.copyright",
            "path": "EventDefinition.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the event definition and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the event definition.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the event definition and/or its content.",
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
            "id": "EventDefinition.approvalDate",
            "path": "EventDefinition.approvalDate",
            "short": "When the event definition was approved by publisher",
            "definition": "The date on which the resource content was approved by the publisher. Approval happens once when the content is officially approved for usage.",
            "comment": "The 'date' element may be more recent than the approval date because of minor changes or editorial corrections.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ],
            "isSummary": true
          },
          {
            "id": "EventDefinition.lastReviewDate",
            "path": "EventDefinition.lastReviewDate",
            "short": "When the event definition was last reviewed",
            "definition": "The date on which the resource content was last reviewed. Review happens periodically after approval but does not change the original approval date.",
            "comment": "If specified, this date follows the original approval date.",
            "requirements": "Gives a sense of how \"current\" the content is.  Resources that have not been reviewed in a long time may have a risk of being less appropriate/relevant.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "date"
              }
            ],
            "isSummary": true
          },
          {
            "id": "EventDefinition.effectivePeriod",
            "path": "EventDefinition.effectivePeriod",
            "short": "When the event definition is expected to be used",
            "definition": "The period during which the event definition content was or is planned to be in active use.",
            "comment": "The effective period for a event definition  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.",
            "requirements": "Allows establishing a transition before a resource comes into effect and also allows for a sunsetting  process when new versions of the event definition are or are expected to be used instead.",
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
            "id": "EventDefinition.topic",
            "path": "EventDefinition.topic",
            "short": "E.g. Education, Treatment, Assessment, etc.",
            "definition": "Descriptive topics related to the module. Topics provide a high-level categorization of the module that can be useful for filtering and searching.",
            "requirements": "Repositories must be able to determine how to categorize the module so that it can be found by topical searches.",
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
            "id": "EventDefinition.author",
            "path": "EventDefinition.author",
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
            "id": "EventDefinition.editor",
            "path": "EventDefinition.editor",
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
            "id": "EventDefinition.reviewer",
            "path": "EventDefinition.reviewer",
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
            "id": "EventDefinition.endorser",
            "path": "EventDefinition.endorser",
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
            "id": "EventDefinition.relatedArtifact",
            "path": "EventDefinition.relatedArtifact",
            "short": "Additional documentation, citations, etc.",
            "definition": "Related resources such as additional documentation, justification, or bibliographic references.",
            "comment": "Each related resource is either an attachment, or a reference to another resource, but not both.",
            "requirements": "Modules must be able to provide enough information for consumers of the content (and/or interventions or results produced by the content) to be able to determine and understand the justification for and evidence in support of the content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "RelatedArtifact"
              }
            ]
          },
          {
            "id": "EventDefinition.trigger",
            "path": "EventDefinition.trigger",
            "short": "\"when\" the event occurs (multiple = 'or')",
            "definition": "The trigger element defines when the event occurs. If more than one trigger condition is specified, the event fires whenever any one of the trigger conditions is met.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "TriggerDefinition"
              }
            ],
            "isSummary": true
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:461
    /// <summary>
    /// Fhir resource 'EventDefinition'
    /// </summary>
    // 0. EventDefinition
    public class EventDefinition : FhirKhit.Maker.Common.Resource.ResourceBase                                                              // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        public class EventDefinition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                 // MakerGen.cs:385
        {                                                                                                                                   // MakerGen.cs:386
            // 1. EventDefinition.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:216
            // 2. EventDefinition.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 3. EventDefinition.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:216
            // 4. EventDefinition.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 5. EventDefinition.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:216
            // 6. EventDefinition.subtitle
            public ElementDefinitionInfo Subtitle;                                                                                          // MakerGen.cs:216
            // 7. EventDefinition.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 8. EventDefinition.experimental
            public ElementDefinitionInfo Experimental;                                                                                      // MakerGen.cs:216
            // 9. EventDefinition.subject[x]
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:216
            // 10. EventDefinition.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:216
            // 11. EventDefinition.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:216
            // 12. EventDefinition.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:216
            // 13. EventDefinition.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 14. EventDefinition.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:216
            // 15. EventDefinition.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:216
            // 16. EventDefinition.purpose
            public ElementDefinitionInfo Purpose;                                                                                           // MakerGen.cs:216
            // 17. EventDefinition.usage
            public ElementDefinitionInfo Usage;                                                                                             // MakerGen.cs:216
            // 18. EventDefinition.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:216
            // 19. EventDefinition.approvalDate
            public ElementDefinitionInfo ApprovalDate;                                                                                      // MakerGen.cs:216
            // 20. EventDefinition.lastReviewDate
            public ElementDefinitionInfo LastReviewDate;                                                                                    // MakerGen.cs:216
            // 21. EventDefinition.effectivePeriod
            public ElementDefinitionInfo EffectivePeriod;                                                                                   // MakerGen.cs:216
            // 22. EventDefinition.topic
            public ElementDefinitionInfo Topic;                                                                                             // MakerGen.cs:216
            // 23. EventDefinition.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:216
            // 24. EventDefinition.editor
            public ElementDefinitionInfo Editor;                                                                                            // MakerGen.cs:216
            // 25. EventDefinition.reviewer
            public ElementDefinitionInfo Reviewer;                                                                                          // MakerGen.cs:216
            // 26. EventDefinition.endorser
            public ElementDefinitionInfo Endorser;                                                                                          // MakerGen.cs:216
            // 27. EventDefinition.relatedArtifact
            public ElementDefinitionInfo RelatedArtifact;                                                                                   // MakerGen.cs:216
            // 28. EventDefinition.trigger
            public ElementDefinitionInfo Trigger;                                                                                           // MakerGen.cs:216
            public EventDefinition_Elements()                                                                                               // MakerGen.cs:407
            {                                                                                                                               // MakerGen.cs:408
                {                                                                                                                           // MakerGen.cs:231
                    // 1. EventDefinition.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Url",                                                                                                       // MakerGen.cs:235
                        Path= "EventDefinition.url",                                                                                        // MakerGen.cs:236
                        Id = "EventDefinition.url",                                                                                         // MakerGen.cs:237
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
                    // 2. EventDefinition.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "EventDefinition.identifier",                                                                                 // MakerGen.cs:236
                        Id = "EventDefinition.identifier",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 3. EventDefinition.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Version",                                                                                                   // MakerGen.cs:235
                        Path= "EventDefinition.version",                                                                                    // MakerGen.cs:236
                        Id = "EventDefinition.version",                                                                                     // MakerGen.cs:237
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
                    // 4. EventDefinition.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "EventDefinition.name",                                                                                       // MakerGen.cs:236
                        Id = "EventDefinition.name",                                                                                        // MakerGen.cs:237
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
                    // 5. EventDefinition.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Title",                                                                                                     // MakerGen.cs:235
                        Path= "EventDefinition.title",                                                                                      // MakerGen.cs:236
                        Id = "EventDefinition.title",                                                                                       // MakerGen.cs:237
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
                    // 6. EventDefinition.subtitle
                    this.Subtitle = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subtitle",                                                                                                  // MakerGen.cs:235
                        Path= "EventDefinition.subtitle",                                                                                   // MakerGen.cs:236
                        Id = "EventDefinition.subtitle",                                                                                    // MakerGen.cs:237
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
                    // 7. EventDefinition.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "EventDefinition.status",                                                                                     // MakerGen.cs:236
                        Id = "EventDefinition.status",                                                                                      // MakerGen.cs:237
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
                    // 8. EventDefinition.experimental
                    this.Experimental = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Experimental",                                                                                              // MakerGen.cs:235
                        Path= "EventDefinition.experimental",                                                                               // MakerGen.cs:236
                        Id = "EventDefinition.experimental",                                                                                // MakerGen.cs:237
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
                    // 9. EventDefinition.subject[x]
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Subject",                                                                                                   // MakerGen.cs:235
                        Path= "EventDefinition.subject[x]",                                                                                 // MakerGen.cs:236
                        Id = "EventDefinition.subject[x]",                                                                                  // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            },                                                                                                              // MakerGen.cs:319
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 10. EventDefinition.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Date",                                                                                                      // MakerGen.cs:235
                        Path= "EventDefinition.date",                                                                                       // MakerGen.cs:236
                        Id = "EventDefinition.date",                                                                                        // MakerGen.cs:237
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
                    // 11. EventDefinition.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Publisher",                                                                                                 // MakerGen.cs:235
                        Path= "EventDefinition.publisher",                                                                                  // MakerGen.cs:236
                        Id = "EventDefinition.publisher",                                                                                   // MakerGen.cs:237
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
                    // 12. EventDefinition.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Contact",                                                                                                   // MakerGen.cs:235
                        Path= "EventDefinition.contact",                                                                                    // MakerGen.cs:236
                        Id = "EventDefinition.contact",                                                                                     // MakerGen.cs:237
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
                    // 13. EventDefinition.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "EventDefinition.description",                                                                                // MakerGen.cs:236
                        Id = "EventDefinition.description",                                                                                 // MakerGen.cs:237
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
                    // 14. EventDefinition.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "UseContext",                                                                                                // MakerGen.cs:235
                        Path= "EventDefinition.useContext",                                                                                 // MakerGen.cs:236
                        Id = "EventDefinition.useContext",                                                                                  // MakerGen.cs:237
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
                    // 15. EventDefinition.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:235
                        Path= "EventDefinition.jurisdiction",                                                                               // MakerGen.cs:236
                        Id = "EventDefinition.jurisdiction",                                                                                // MakerGen.cs:237
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
                    // 16. EventDefinition.purpose
                    this.Purpose = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Purpose",                                                                                                   // MakerGen.cs:235
                        Path= "EventDefinition.purpose",                                                                                    // MakerGen.cs:236
                        Id = "EventDefinition.purpose",                                                                                     // MakerGen.cs:237
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
                    // 17. EventDefinition.usage
                    this.Usage = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Usage",                                                                                                     // MakerGen.cs:235
                        Path= "EventDefinition.usage",                                                                                      // MakerGen.cs:236
                        Id = "EventDefinition.usage",                                                                                       // MakerGen.cs:237
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
                    // 18. EventDefinition.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Copyright",                                                                                                 // MakerGen.cs:235
                        Path= "EventDefinition.copyright",                                                                                  // MakerGen.cs:236
                        Id = "EventDefinition.copyright",                                                                                   // MakerGen.cs:237
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
                    // 19. EventDefinition.approvalDate
                    this.ApprovalDate = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ApprovalDate",                                                                                              // MakerGen.cs:235
                        Path= "EventDefinition.approvalDate",                                                                               // MakerGen.cs:236
                        Id = "EventDefinition.approvalDate",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 20. EventDefinition.lastReviewDate
                    this.LastReviewDate = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "LastReviewDate",                                                                                            // MakerGen.cs:235
                        Path= "EventDefinition.lastReviewDate",                                                                             // MakerGen.cs:236
                        Id = "EventDefinition.lastReviewDate",                                                                              // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:300
                            {                                                                                                               // MakerGen.cs:301
                            }                                                                                                               // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 21. EventDefinition.effectivePeriod
                    this.EffectivePeriod = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "EffectivePeriod",                                                                                           // MakerGen.cs:235
                        Path= "EventDefinition.effectivePeriod",                                                                            // MakerGen.cs:236
                        Id = "EventDefinition.effectivePeriod",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 22. EventDefinition.topic
                    this.Topic = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Topic",                                                                                                     // MakerGen.cs:235
                        Path= "EventDefinition.topic",                                                                                      // MakerGen.cs:236
                        Id = "EventDefinition.topic",                                                                                       // MakerGen.cs:237
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
                    // 23. EventDefinition.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Author",                                                                                                    // MakerGen.cs:235
                        Path= "EventDefinition.author",                                                                                     // MakerGen.cs:236
                        Id = "EventDefinition.author",                                                                                      // MakerGen.cs:237
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
                    // 24. EventDefinition.editor
                    this.Editor = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Editor",                                                                                                    // MakerGen.cs:235
                        Path= "EventDefinition.editor",                                                                                     // MakerGen.cs:236
                        Id = "EventDefinition.editor",                                                                                      // MakerGen.cs:237
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
                    // 25. EventDefinition.reviewer
                    this.Reviewer = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Reviewer",                                                                                                  // MakerGen.cs:235
                        Path= "EventDefinition.reviewer",                                                                                   // MakerGen.cs:236
                        Id = "EventDefinition.reviewer",                                                                                    // MakerGen.cs:237
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
                    // 26. EventDefinition.endorser
                    this.Endorser = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Endorser",                                                                                                  // MakerGen.cs:235
                        Path= "EventDefinition.endorser",                                                                                   // MakerGen.cs:236
                        Id = "EventDefinition.endorser",                                                                                    // MakerGen.cs:237
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
                    // 27. EventDefinition.relatedArtifact
                    this.RelatedArtifact = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "RelatedArtifact",                                                                                           // MakerGen.cs:235
                        Path= "EventDefinition.relatedArtifact",                                                                            // MakerGen.cs:236
                        Id = "EventDefinition.relatedArtifact",                                                                             // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.RelatedArtifact                                                               // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 28. EventDefinition.trigger
                    this.Trigger = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Trigger",                                                                                                   // MakerGen.cs:235
                        Path= "EventDefinition.trigger",                                                                                    // MakerGen.cs:236
                        Id = "EventDefinition.trigger",                                                                                     // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.TriggerDefinition                                                             // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:427
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:412
            {                                                                                                                               // MakerGen.cs:413
                base.Write(sDef);                                                                                                           // MakerGen.cs:414
                Url.Write(sDef);                                                                                                            // MakerGen.cs:220
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Version.Write(sDef);                                                                                                        // MakerGen.cs:220
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Title.Write(sDef);                                                                                                          // MakerGen.cs:220
                Subtitle.Write(sDef);                                                                                                       // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Experimental.Write(sDef);                                                                                                   // MakerGen.cs:220
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:220
                Date.Write(sDef);                                                                                                           // MakerGen.cs:220
                Publisher.Write(sDef);                                                                                                      // MakerGen.cs:220
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:220
                Description.Write(sDef);                                                                                                    // MakerGen.cs:220
                UseContext.Write(sDef);                                                                                                     // MakerGen.cs:220
                Jurisdiction.Write(sDef);                                                                                                   // MakerGen.cs:220
                Purpose.Write(sDef);                                                                                                        // MakerGen.cs:220
                Usage.Write(sDef);                                                                                                          // MakerGen.cs:220
                Copyright.Write(sDef);                                                                                                      // MakerGen.cs:220
                ApprovalDate.Write(sDef);                                                                                                   // MakerGen.cs:220
                LastReviewDate.Write(sDef);                                                                                                 // MakerGen.cs:220
                EffectivePeriod.Write(sDef);                                                                                                // MakerGen.cs:220
                Topic.Write(sDef);                                                                                                          // MakerGen.cs:220
                Author.Write(sDef);                                                                                                         // MakerGen.cs:220
                Editor.Write(sDef);                                                                                                         // MakerGen.cs:220
                Reviewer.Write(sDef);                                                                                                       // MakerGen.cs:220
                Endorser.Write(sDef);                                                                                                       // MakerGen.cs:220
                RelatedArtifact.Write(sDef);                                                                                                // MakerGen.cs:220
                Trigger.Write(sDef);                                                                                                        // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:431
        }                                                                                                                                   // MakerGen.cs:391
        public EventDefinition_Elements Elements { get; }                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:393
        public EventDefinition()                                                                                                            // MakerGen.cs:394
        {                                                                                                                                   // MakerGen.cs:395
            this.Elements = new EventDefinition_Elements();                                                                                 // MakerGen.cs:396
        }                                                                                                                                   // MakerGen.cs:397
                                                                                                                                            // MakerGen.cs:398
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:399
        {                                                                                                                                   // MakerGen.cs:400
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:401
        }                                                                                                                                   // MakerGen.cs:402
    }                                                                                                                                       // MakerGen.cs:403
}                                                                                                                                           // MakerGen.cs:466
