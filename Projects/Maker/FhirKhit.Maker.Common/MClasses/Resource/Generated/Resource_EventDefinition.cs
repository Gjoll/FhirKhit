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
    #endregion
    /// <summary>
    /// Fhir resource 'EventDefinition'
    /// </summary>
    // 0. EventDefinition
    public class Resource_EventDefinition : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 1. EventDefinition.url
        public ElementDefinitionInfo Element_Url;
        // 2. EventDefinition.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. EventDefinition.version
        public ElementDefinitionInfo Element_Version;
        // 4. EventDefinition.name
        public ElementDefinitionInfo Element_Name;
        // 5. EventDefinition.title
        public ElementDefinitionInfo Element_Title;
        // 6. EventDefinition.subtitle
        public ElementDefinitionInfo Element_Subtitle;
        // 7. EventDefinition.status
        public ElementDefinitionInfo Element_Status;
        // 8. EventDefinition.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 9. EventDefinition.subject[x]
        public ElementDefinitionInfo Element_Subject;
        // 10. EventDefinition.date
        public ElementDefinitionInfo Element_Date;
        // 11. EventDefinition.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 12. EventDefinition.contact
        public ElementDefinitionInfo Element_Contact;
        // 13. EventDefinition.description
        public ElementDefinitionInfo Element_Description;
        // 14. EventDefinition.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 15. EventDefinition.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 16. EventDefinition.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 17. EventDefinition.usage
        public ElementDefinitionInfo Element_Usage;
        // 18. EventDefinition.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 19. EventDefinition.approvalDate
        public ElementDefinitionInfo Element_ApprovalDate;
        // 20. EventDefinition.lastReviewDate
        public ElementDefinitionInfo Element_LastReviewDate;
        // 21. EventDefinition.effectivePeriod
        public ElementDefinitionInfo Element_EffectivePeriod;
        // 22. EventDefinition.topic
        public ElementDefinitionInfo Element_Topic;
        // 23. EventDefinition.author
        public ElementDefinitionInfo Element_Author;
        // 24. EventDefinition.editor
        public ElementDefinitionInfo Element_Editor;
        // 25. EventDefinition.reviewer
        public ElementDefinitionInfo Element_Reviewer;
        // 26. EventDefinition.endorser
        public ElementDefinitionInfo Element_Endorser;
        // 27. EventDefinition.relatedArtifact
        public ElementDefinitionInfo Element_RelatedArtifact;
        // 28. EventDefinition.trigger
        public ElementDefinitionInfo Element_Trigger;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "EventDefinition",
                ElementId = "EventDefinition"
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
            Element_Trigger.Write(sDef);
        }
        
        public Resource_EventDefinition()
        {
            {
                // 1. EventDefinition.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "EventDefinition.url",
                    Id = "EventDefinition.url",
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
                // 2. EventDefinition.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "EventDefinition.identifier",
                    Id = "EventDefinition.identifier",
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
                // 3. EventDefinition.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "EventDefinition.version",
                    Id = "EventDefinition.version",
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
                // 4. EventDefinition.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "EventDefinition.name",
                    Id = "EventDefinition.name",
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
                // 5. EventDefinition.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "EventDefinition.title",
                    Id = "EventDefinition.title",
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
                // 6. EventDefinition.subtitle
                this.Element_Subtitle = new ElementDefinitionInfo
                {
                    Name = "Element_Subtitle",
                    Path= "EventDefinition.subtitle",
                    Id = "EventDefinition.subtitle",
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
                // 7. EventDefinition.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "EventDefinition.status",
                    Id = "EventDefinition.status",
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
                // 8. EventDefinition.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "EventDefinition.experimental",
                    Id = "EventDefinition.experimental",
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
                // 9. EventDefinition.subject[x]
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "EventDefinition.subject[x]",
                    Id = "EventDefinition.subject[x]",
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
                // 10. EventDefinition.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "EventDefinition.date",
                    Id = "EventDefinition.date",
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
                // 11. EventDefinition.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "EventDefinition.publisher",
                    Id = "EventDefinition.publisher",
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
                // 12. EventDefinition.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "EventDefinition.contact",
                    Id = "EventDefinition.contact",
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
                // 13. EventDefinition.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "EventDefinition.description",
                    Id = "EventDefinition.description",
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
                // 14. EventDefinition.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "EventDefinition.useContext",
                    Id = "EventDefinition.useContext",
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
                // 15. EventDefinition.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "EventDefinition.jurisdiction",
                    Id = "EventDefinition.jurisdiction",
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
                // 16. EventDefinition.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "EventDefinition.purpose",
                    Id = "EventDefinition.purpose",
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
                // 17. EventDefinition.usage
                this.Element_Usage = new ElementDefinitionInfo
                {
                    Name = "Element_Usage",
                    Path= "EventDefinition.usage",
                    Id = "EventDefinition.usage",
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
                // 18. EventDefinition.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "EventDefinition.copyright",
                    Id = "EventDefinition.copyright",
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
                // 19. EventDefinition.approvalDate
                this.Element_ApprovalDate = new ElementDefinitionInfo
                {
                    Name = "Element_ApprovalDate",
                    Path= "EventDefinition.approvalDate",
                    Id = "EventDefinition.approvalDate",
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
                // 20. EventDefinition.lastReviewDate
                this.Element_LastReviewDate = new ElementDefinitionInfo
                {
                    Name = "Element_LastReviewDate",
                    Path= "EventDefinition.lastReviewDate",
                    Id = "EventDefinition.lastReviewDate",
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
                // 21. EventDefinition.effectivePeriod
                this.Element_EffectivePeriod = new ElementDefinitionInfo
                {
                    Name = "Element_EffectivePeriod",
                    Path= "EventDefinition.effectivePeriod",
                    Id = "EventDefinition.effectivePeriod",
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
                // 22. EventDefinition.topic
                this.Element_Topic = new ElementDefinitionInfo
                {
                    Name = "Element_Topic",
                    Path= "EventDefinition.topic",
                    Id = "EventDefinition.topic",
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
                // 23. EventDefinition.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "EventDefinition.author",
                    Id = "EventDefinition.author",
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
                // 24. EventDefinition.editor
                this.Element_Editor = new ElementDefinitionInfo
                {
                    Name = "Element_Editor",
                    Path= "EventDefinition.editor",
                    Id = "EventDefinition.editor",
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
                // 25. EventDefinition.reviewer
                this.Element_Reviewer = new ElementDefinitionInfo
                {
                    Name = "Element_Reviewer",
                    Path= "EventDefinition.reviewer",
                    Id = "EventDefinition.reviewer",
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
                // 26. EventDefinition.endorser
                this.Element_Endorser = new ElementDefinitionInfo
                {
                    Name = "Element_Endorser",
                    Path= "EventDefinition.endorser",
                    Id = "EventDefinition.endorser",
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
                // 27. EventDefinition.relatedArtifact
                this.Element_RelatedArtifact = new ElementDefinitionInfo
                {
                    Name = "Element_RelatedArtifact",
                    Path= "EventDefinition.relatedArtifact",
                    Id = "EventDefinition.relatedArtifact",
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
                // 28. EventDefinition.trigger
                this.Element_Trigger = new ElementDefinitionInfo
                {
                    Name = "Element_Trigger",
                    Path= "EventDefinition.trigger",
                    Id = "EventDefinition.trigger",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_TriggerDefinition
                        {
                        }
                    }
                };
            }
            this.Name = "EventDefinition";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/EventDefinition";
        }
    }
}
