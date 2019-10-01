using System;                                                                                                                               // MakerGen.cs:428
using System.Diagnostics;                                                                                                                   // MakerGen.cs:429
using System.IO;                                                                                                                            // MakerGen.cs:430
using System.Linq;                                                                                                                          // MakerGen.cs:431
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:432
                                                                                                                                            // MakerGen.cs:433
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:434
{                                                                                                                                           // MakerGen.cs:435
    #region Json                                                                                                                            // MakerGen.cs:436
    #if NEVER                                                                                                                               // MakerGen.cs:437
    {
      "resourceType": "StructureDefinition",
      "id": "EffectEvidenceSynthesis",
      "url": "http://hl7.org/fhir/StructureDefinition/EffectEvidenceSynthesis",
      "version": "4.0.0",
      "name": "EffectEvidenceSynthesis",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Decision Support)",
      "description": "The EffectEvidenceSynthesis resource describes the difference in an outcome between exposures states in a population where the effect estimate is derived from a combination of research studies.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "EffectEvidenceSynthesis",
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
            "id": "EffectEvidenceSynthesis",
            "path": "EffectEvidenceSynthesis",
            "short": "A quantified estimate of effect based on a body of evidence",
            "definition": "The EffectEvidenceSynthesis resource describes the difference in an outcome between exposures states in a population where the effect estimate is derived from a combination of research studies.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "EffectEvidenceSynthesis.url",
            "path": "EffectEvidenceSynthesis.url",
            "short": "Canonical identifier for this effect evidence synthesis, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this effect evidence synthesis when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this effect evidence synthesis is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the effect evidence synthesis is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the effect evidence synthesis to be referenced by a single globally unique identifier.",
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
            "id": "EffectEvidenceSynthesis.identifier",
            "path": "EffectEvidenceSynthesis.identifier",
            "short": "Additional identifier for the effect evidence synthesis",
            "definition": "A formal identifier that is used to identify this effect evidence synthesis when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this effect evidence synthesis outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "EffectEvidenceSynthesis.version",
            "path": "EffectEvidenceSynthesis.version",
            "short": "Business version of the effect evidence synthesis",
            "definition": "The identifier that is used to identify this version of the effect evidence synthesis when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the effect evidence synthesis author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different effect evidence synthesis instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the effect evidence synthesis with the format [url]|[version].",
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
            "id": "EffectEvidenceSynthesis.name",
            "path": "EffectEvidenceSynthesis.name",
            "short": "Name for this effect evidence synthesis (computer friendly)",
            "definition": "A natural language name identifying the effect evidence synthesis. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "EffectEvidenceSynthesis.title",
            "path": "EffectEvidenceSynthesis.title",
            "short": "Name for this effect evidence synthesis (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the effect evidence synthesis.",
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
            "id": "EffectEvidenceSynthesis.status",
            "path": "EffectEvidenceSynthesis.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this effect evidence synthesis. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of effect evidence synthesiss that are appropriate for use versus not.",
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
            "id": "EffectEvidenceSynthesis.date",
            "path": "EffectEvidenceSynthesis.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the effect evidence synthesis was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the effect evidence synthesis changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the effect evidence synthesis. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "EffectEvidenceSynthesis.publisher",
            "path": "EffectEvidenceSynthesis.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the effect evidence synthesis.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the effect evidence synthesis is the organization or individual primarily responsible for the maintenance and upkeep of the effect evidence synthesis. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the effect evidence synthesis. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the effect evidence synthesis.  May also allow for contact.",
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
            "id": "EffectEvidenceSynthesis.contact",
            "path": "EffectEvidenceSynthesis.contact",
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
            "id": "EffectEvidenceSynthesis.description",
            "path": "EffectEvidenceSynthesis.description",
            "short": "Natural language description of the effect evidence synthesis",
            "definition": "A free text natural language description of the effect evidence synthesis from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the effect evidence synthesis was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the effect evidence synthesis as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the effect evidence synthesis is presumed to be the predominant language in the place the effect evidence synthesis was created).",
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
            "id": "EffectEvidenceSynthesis.note",
            "path": "EffectEvidenceSynthesis.note",
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
            "id": "EffectEvidenceSynthesis.useContext",
            "path": "EffectEvidenceSynthesis.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate effect evidence synthesis instances.",
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
            "id": "EffectEvidenceSynthesis.jurisdiction",
            "path": "EffectEvidenceSynthesis.jurisdiction",
            "short": "Intended jurisdiction for effect evidence synthesis (if applicable)",
            "definition": "A legal or geographic region in which the effect evidence synthesis is intended to be used.",
            "comment": "It may be possible for the effect evidence synthesis to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "EffectEvidenceSynthesis.copyright",
            "path": "EffectEvidenceSynthesis.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the effect evidence synthesis and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the effect evidence synthesis.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the effect evidence synthesis and/or its content.",
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
            "id": "EffectEvidenceSynthesis.approvalDate",
            "path": "EffectEvidenceSynthesis.approvalDate",
            "short": "When the effect evidence synthesis was approved by publisher",
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
            "id": "EffectEvidenceSynthesis.lastReviewDate",
            "path": "EffectEvidenceSynthesis.lastReviewDate",
            "short": "When the effect evidence synthesis was last reviewed",
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
            "id": "EffectEvidenceSynthesis.effectivePeriod",
            "path": "EffectEvidenceSynthesis.effectivePeriod",
            "short": "When the effect evidence synthesis is expected to be used",
            "definition": "The period during which the effect evidence synthesis content was or is planned to be in active use.",
            "comment": "The effective period for a effect evidence synthesis  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.",
            "requirements": "Allows establishing a transition before a resource comes into effect and also allows for a sunsetting  process when new versions of the effect evidence synthesis are or are expected to be used instead.",
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
            "id": "EffectEvidenceSynthesis.topic",
            "path": "EffectEvidenceSynthesis.topic",
            "short": "The category of the EffectEvidenceSynthesis, such as Education, Treatment, Assessment, etc.",
            "definition": "Descriptive topics related to the content of the EffectEvidenceSynthesis. Topics provide a high-level categorization grouping types of EffectEvidenceSynthesiss that can be useful for filtering and searching.",
            "requirements": "Repositories must be able to determine how to categorize the EffectEvidenceSynthesis so that it can be found by topical searches.",
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
            "id": "EffectEvidenceSynthesis.author",
            "path": "EffectEvidenceSynthesis.author",
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
            "id": "EffectEvidenceSynthesis.editor",
            "path": "EffectEvidenceSynthesis.editor",
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
            "id": "EffectEvidenceSynthesis.reviewer",
            "path": "EffectEvidenceSynthesis.reviewer",
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
            "id": "EffectEvidenceSynthesis.endorser",
            "path": "EffectEvidenceSynthesis.endorser",
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
            "id": "EffectEvidenceSynthesis.relatedArtifact",
            "path": "EffectEvidenceSynthesis.relatedArtifact",
            "short": "Additional documentation, citations, etc.",
            "definition": "Related artifacts such as additional documentation, justification, or bibliographic references.",
            "comment": "Each related artifact is either an attachment, or a reference to another resource, but not both.",
            "requirements": "EffectEvidenceSynthesiss must be able to provide enough information for consumers of the content (and/or interventions or results produced by the content) to be able to determine and understand the justification for and evidence in support of the content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "RelatedArtifact"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.synthesisType",
            "path": "EffectEvidenceSynthesis.synthesisType",
            "short": "Type of synthesis",
            "definition": "Type of synthesis eg meta-analysis.",
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
                  "valueString": "SynthesisType"
                }
              ],
              "strength": "extensible",
              "description": "Types of combining results from a body of evidence (eg. summary data meta-analysis).",
              "valueSet": "http://hl7.org/fhir/ValueSet/synthesis-type"
            }
          },
          {
            "id": "EffectEvidenceSynthesis.studyType",
            "path": "EffectEvidenceSynthesis.studyType",
            "short": "Type of study",
            "definition": "Type of study eg randomized trial.",
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
                  "valueString": "StudyType"
                }
              ],
              "strength": "extensible",
              "description": "Types of research studies (types of research methods).",
              "valueSet": "http://hl7.org/fhir/ValueSet/study-type"
            }
          },
          {
            "id": "EffectEvidenceSynthesis.population",
            "path": "EffectEvidenceSynthesis.population",
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
            "id": "EffectEvidenceSynthesis.exposure",
            "path": "EffectEvidenceSynthesis.exposure",
            "short": "What exposure?",
            "definition": "A reference to a EvidenceVariable resource that defines the exposure for the research.",
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
            "id": "EffectEvidenceSynthesis.exposureAlternative",
            "path": "EffectEvidenceSynthesis.exposureAlternative",
            "short": "What comparison exposure?",
            "definition": "A reference to a EvidenceVariable resource that defines the comparison exposure for the research.",
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
            "id": "EffectEvidenceSynthesis.outcome",
            "path": "EffectEvidenceSynthesis.outcome",
            "short": "What outcome?",
            "definition": "A reference to a EvidenceVariable resomece that defines the outcome for the research.",
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
            "id": "EffectEvidenceSynthesis.sampleSize",
            "path": "EffectEvidenceSynthesis.sampleSize",
            "short": "What sample size was involved?",
            "definition": "A description of the size of the sample involved in the synthesis.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.sampleSize.description",
            "path": "EffectEvidenceSynthesis.sampleSize.description",
            "short": "Description of sample size",
            "definition": "Human-readable summary of sample size.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.sampleSize.numberOfStudies",
            "path": "EffectEvidenceSynthesis.sampleSize.numberOfStudies",
            "short": "How many studies?",
            "definition": "Number of studies included in this evidence synthesis.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.sampleSize.numberOfParticipants",
            "path": "EffectEvidenceSynthesis.sampleSize.numberOfParticipants",
            "short": "How many participants?",
            "definition": "Number of participants included in this evidence synthesis.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.resultsByExposure",
            "path": "EffectEvidenceSynthesis.resultsByExposure",
            "short": "What was the result per exposure?",
            "definition": "A description of the results for each exposure considered in the effect estimate.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.resultsByExposure.description",
            "path": "EffectEvidenceSynthesis.resultsByExposure.description",
            "short": "Description of results by exposure",
            "definition": "Human-readable summary of results by exposure state.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.resultsByExposure.exposureState",
            "path": "EffectEvidenceSynthesis.resultsByExposure.exposureState",
            "short": "exposure | exposure-alternative",
            "definition": "Whether these results are for the exposure state or alternative exposure state.",
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
                  "valueString": "ExposureState"
                }
              ],
              "strength": "required",
              "description": "Whether the results by exposure is describing the results for the primary exposure of interest (exposure) or the alternative state (exposureAlternative).",
              "valueSet": "http://hl7.org/fhir/ValueSet/exposure-state|4.0.0"
            }
          },
          {
            "id": "EffectEvidenceSynthesis.resultsByExposure.variantState",
            "path": "EffectEvidenceSynthesis.resultsByExposure.variantState",
            "short": "Variant exposure states",
            "definition": "Used to define variant exposure states such as low-risk state.",
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
                  "valueString": "EvidenceVariantState"
                }
              ],
              "strength": "extensible",
              "description": "Used for results by exposure in variant states such as low-risk, medium-risk and high-risk states.",
              "valueSet": "http://hl7.org/fhir/ValueSet/evidence-variant-state"
            }
          },
          {
            "id": "EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis",
            "path": "EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis",
            "short": "Risk evidence synthesis",
            "definition": "Reference to a RiskEvidenceSynthesis resource.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/RiskEvidenceSynthesis"
                ]
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.effectEstimate",
            "path": "EffectEvidenceSynthesis.effectEstimate",
            "short": "What was the estimated effect",
            "definition": "The estimated effect of the exposure variant.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "EffectEvidenceSynthesis.effectEstimate.description",
            "path": "EffectEvidenceSynthesis.effectEstimate.description",
            "short": "Description of effect estimate",
            "definition": "Human-readable summary of effect estimate.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.effectEstimate.type",
            "path": "EffectEvidenceSynthesis.effectEstimate.type",
            "short": "Type of efffect estimate",
            "definition": "Examples include relative risk and mean difference.",
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
                  "valueString": "EffectEstimateType"
                }
              ],
              "strength": "extensible",
              "description": "Whether the effect estimate is an absolute effect estimate (absolute difference) or a relative effect estimate (relative difference), and the specific type of effect estimate (eg relative risk or median difference).",
              "valueSet": "http://hl7.org/fhir/ValueSet/effect-estimate-type"
            }
          },
          {
            "id": "EffectEvidenceSynthesis.effectEstimate.variantState",
            "path": "EffectEvidenceSynthesis.effectEstimate.variantState",
            "short": "Variant exposure states",
            "definition": "Used to define variant exposure states such as low-risk state.",
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
                  "valueString": "EvidenceVariantState"
                }
              ],
              "strength": "extensible",
              "description": "Used for results by exposure in variant states such as low-risk, medium-risk and high-risk states.",
              "valueSet": "http://hl7.org/fhir/ValueSet/evidence-variant-state"
            }
          },
          {
            "id": "EffectEvidenceSynthesis.effectEstimate.value",
            "path": "EffectEvidenceSynthesis.effectEstimate.value",
            "short": "Point estimate",
            "definition": "The point estimate of the effect estimate.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.effectEstimate.unitOfMeasure",
            "path": "EffectEvidenceSynthesis.effectEstimate.unitOfMeasure",
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
            "id": "EffectEvidenceSynthesis.effectEstimate.precisionEstimate",
            "path": "EffectEvidenceSynthesis.effectEstimate.precisionEstimate",
            "short": "How precise the estimate is",
            "definition": "A description of the precision of the estimate for the effect.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type",
            "path": "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type",
            "short": "Type of precision estimate",
            "definition": "Examples include confidence interval and interquartile range.",
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
                  "valueString": "PrecisionEstimateType"
                }
              ],
              "strength": "extensible",
              "description": "Method of reporting variability of estimates, such as confidence intervals, interquartile range or standard deviation.",
              "valueSet": "http://hl7.org/fhir/ValueSet/precision-estimate-type"
            }
          },
          {
            "id": "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level",
            "path": "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level",
            "short": "Level of confidence interval",
            "definition": "Use 95 for a 95% confidence interval.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from",
            "path": "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from",
            "short": "Lower bound",
            "definition": "Lower bound of confidence interval.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to",
            "path": "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to",
            "short": "Upper bound",
            "definition": "Upper bound of confidence interval.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.certainty",
            "path": "EffectEvidenceSynthesis.certainty",
            "short": "How certain is the effect",
            "definition": "A description of the certainty of the effect estimate.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.certainty.rating",
            "path": "EffectEvidenceSynthesis.certainty.rating",
            "short": "Certainty rating",
            "definition": "A rating of the certainty of the effect estimate.",
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
                  "valueString": "QualityOfEvidenceRating"
                }
              ],
              "strength": "extensible",
              "description": "The quality of the evidence described. The code system used specifies the quality scale used to grade this evidence source while the code specifies the actual quality score (represented as a coded value) associated with the evidence.",
              "valueSet": "http://hl7.org/fhir/ValueSet/evidence-quality"
            }
          },
          {
            "id": "EffectEvidenceSynthesis.certainty.note",
            "path": "EffectEvidenceSynthesis.certainty.note",
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
            "id": "EffectEvidenceSynthesis.certainty.certaintySubcomponent",
            "path": "EffectEvidenceSynthesis.certainty.certaintySubcomponent",
            "short": "A component that contributes to the overall certainty",
            "definition": "A description of a component of the overall certainty.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "EffectEvidenceSynthesis.certainty.certaintySubcomponent.type",
            "path": "EffectEvidenceSynthesis.certainty.certaintySubcomponent.type",
            "short": "Type of subcomponent of certainty rating",
            "definition": "Type of subcomponent of certainty rating.",
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
                  "valueString": "CertaintySubcomponentType"
                }
              ],
              "strength": "extensible",
              "description": "The subcomponent classification of quality of evidence rating systems.",
              "valueSet": "http://hl7.org/fhir/ValueSet/certainty-subcomponent-type"
            }
          },
          {
            "id": "EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating",
            "path": "EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating",
            "short": "Subcomponent certainty rating",
            "definition": "A rating of a subcomponent of rating certainty.",
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
                  "valueString": "CertaintySubcomponentRating"
                }
              ],
              "strength": "extensible",
              "description": "The quality rating of the subcomponent of a quality of evidence rating.",
              "valueSet": "http://hl7.org/fhir/ValueSet/certainty-subcomponent-rating"
            }
          },
          {
            "id": "EffectEvidenceSynthesis.certainty.certaintySubcomponent.note",
            "path": "EffectEvidenceSynthesis.certainty.certaintySubcomponent.note",
            "short": "Used for footnotes or explanatory notes",
            "definition": "A human-readable string to clarify or explain concepts about the resource.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:440
    /// <summary>
    /// Fhir resource 'EffectEvidenceSynthesis'
    /// </summary>
    // 0. EffectEvidenceSynthesis
    public class Resource_EffectEvidenceSynthesis : FhirKhit.Maker.Common.Resource.ResourceBase                                             // MakerGen.cs:376
    {                                                                                                                                       // MakerGen.cs:377
        // 30. EffectEvidenceSynthesis.sampleSize
        public class Type_SampleSize : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 31. EffectEvidenceSynthesis.sampleSize.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:212
            // 32. EffectEvidenceSynthesis.sampleSize.numberOfStudies
            public ElementDefinitionInfo Element_NumberOfStudies;                                                                           // MakerGen.cs:212
            // 33. EffectEvidenceSynthesis.sampleSize.numberOfParticipants
            public ElementDefinitionInfo Element_NumberOfParticipants;                                                                      // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "EffectEvidenceSynthesis.sampleSize",                                                                            // MakerGen.cs:388
                    ElementId = "EffectEvidenceSynthesis.sampleSize"                                                                        // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_NumberOfStudies.Write(sDef);                                                                                        // MakerGen.cs:216
                Element_NumberOfParticipants.Write(sDef);                                                                                   // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_SampleSize()                                                                                                        // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 31. EffectEvidenceSynthesis.sampleSize.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Description",                                                                                       // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.sampleSize.description",                                                             // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.sampleSize.description",                                                              // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 32. EffectEvidenceSynthesis.sampleSize.numberOfStudies
                    this.Element_NumberOfStudies = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_NumberOfStudies",                                                                                   // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.sampleSize.numberOfStudies",                                                         // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.sampleSize.numberOfStudies",                                                          // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 33. EffectEvidenceSynthesis.sampleSize.numberOfParticipants
                    this.Element_NumberOfParticipants = new ElementDefinitionInfo                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_NumberOfParticipants",                                                                              // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.sampleSize.numberOfParticipants",                                                    // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.sampleSize.numberOfParticipants",                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 34. EffectEvidenceSynthesis.resultsByExposure
        public class Type_ResultsByExposure : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 35. EffectEvidenceSynthesis.resultsByExposure.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:212
            // 36. EffectEvidenceSynthesis.resultsByExposure.exposureState
            public ElementDefinitionInfo Element_ExposureState;                                                                             // MakerGen.cs:212
            // 37. EffectEvidenceSynthesis.resultsByExposure.variantState
            public ElementDefinitionInfo Element_VariantState;                                                                              // MakerGen.cs:212
            // 38. EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis
            public ElementDefinitionInfo Element_RiskEvidenceSynthesis;                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "EffectEvidenceSynthesis.resultsByExposure",                                                                     // MakerGen.cs:388
                    ElementId = "EffectEvidenceSynthesis.resultsByExposure"                                                                 // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_ExposureState.Write(sDef);                                                                                          // MakerGen.cs:216
                Element_VariantState.Write(sDef);                                                                                           // MakerGen.cs:216
                Element_RiskEvidenceSynthesis.Write(sDef);                                                                                  // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_ResultsByExposure()                                                                                                 // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 35. EffectEvidenceSynthesis.resultsByExposure.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Description",                                                                                       // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.resultsByExposure.description",                                                      // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.resultsByExposure.description",                                                       // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 36. EffectEvidenceSynthesis.resultsByExposure.exposureState
                    this.Element_ExposureState = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_ExposureState",                                                                                     // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.resultsByExposure.exposureState",                                                    // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.resultsByExposure.exposureState",                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                              // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 37. EffectEvidenceSynthesis.resultsByExposure.variantState
                    this.Element_VariantState = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_VariantState",                                                                                      // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.resultsByExposure.variantState",                                                     // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.resultsByExposure.variantState",                                                      // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 38. EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis
                    this.Element_RiskEvidenceSynthesis = new ElementDefinitionInfo                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_RiskEvidenceSynthesis",                                                                             // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis",                                            // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis",                                             // MakerGen.cs:233
                        Min = 1,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Reference                                                                // MakerGen.cs:339
                            {                                                                                                               // MakerGen.cs:340
                                TargetProfile = new String[]                                                                                // MakerGen.cs:342
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/RiskEvidenceSynthesis"                                         // MakerGen.cs:342
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:343
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 39. EffectEvidenceSynthesis.effectEstimate
        public class Type_EffectEstimate : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 45. EffectEvidenceSynthesis.effectEstimate.precisionEstimate
            public class Type_PrecisionEstimate : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 46. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:212
                // 47. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level
                public ElementDefinitionInfo Element_Level;                                                                                 // MakerGen.cs:212
                // 48. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from
                public ElementDefinitionInfo Element_From;                                                                                  // MakerGen.cs:212
                // 49. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to
                public ElementDefinitionInfo Element_To;                                                                                    // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate",                                                  // MakerGen.cs:388
                        ElementId = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate"                                              // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_Level.Write(sDef);                                                                                              // MakerGen.cs:216
                    Element_From.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_To.Write(sDef);                                                                                                 // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_PrecisionEstimate()                                                                                             // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 46. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Type",                                                                                          // MakerGen.cs:231
                            Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type",                                          // MakerGen.cs:232
                            Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type",                                           // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 47. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level
                        this.Element_Level = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Level",                                                                                         // MakerGen.cs:231
                            Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level",                                         // MakerGen.cs:232
                            Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level",                                          // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                       // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 48. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from
                        this.Element_From = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_From",                                                                                          // MakerGen.cs:231
                            Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from",                                          // MakerGen.cs:232
                            Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from",                                           // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                       // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 49. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to
                        this.Element_To = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_To",                                                                                            // MakerGen.cs:231
                            Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to",                                            // MakerGen.cs:232
                            Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to",                                             // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                       // MakerGen.cs:296
                                {                                                                                                           // MakerGen.cs:297
                                }                                                                                                           // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 40. EffectEvidenceSynthesis.effectEstimate.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:212
            // 41. EffectEvidenceSynthesis.effectEstimate.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:212
            // 42. EffectEvidenceSynthesis.effectEstimate.variantState
            public ElementDefinitionInfo Element_VariantState;                                                                              // MakerGen.cs:212
            // 43. EffectEvidenceSynthesis.effectEstimate.value
            public ElementDefinitionInfo Element_Value;                                                                                     // MakerGen.cs:212
            // 44. EffectEvidenceSynthesis.effectEstimate.unitOfMeasure
            public ElementDefinitionInfo Element_UnitOfMeasure;                                                                             // MakerGen.cs:212
            // 45. EffectEvidenceSynthesis.effectEstimate.precisionEstimate
            public ElementDefinitionInfo Element_PrecisionEstimate;                                                                         // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "EffectEvidenceSynthesis.effectEstimate",                                                                        // MakerGen.cs:388
                    ElementId = "EffectEvidenceSynthesis.effectEstimate"                                                                    // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:216
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_VariantState.Write(sDef);                                                                                           // MakerGen.cs:216
                Element_Value.Write(sDef);                                                                                                  // MakerGen.cs:216
                Element_UnitOfMeasure.Write(sDef);                                                                                          // MakerGen.cs:216
                Element_PrecisionEstimate.Write(sDef);                                                                                      // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_EffectEstimate()                                                                                                    // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 40. EffectEvidenceSynthesis.effectEstimate.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Description",                                                                                       // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.effectEstimate.description",                                                         // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.effectEstimate.description",                                                          // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 41. EffectEvidenceSynthesis.effectEstimate.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Type",                                                                                              // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.effectEstimate.type",                                                                // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.effectEstimate.type",                                                                 // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 42. EffectEvidenceSynthesis.effectEstimate.variantState
                    this.Element_VariantState = new ElementDefinitionInfo                                                                   // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_VariantState",                                                                                      // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.effectEstimate.variantState",                                                        // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.effectEstimate.variantState",                                                         // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 43. EffectEvidenceSynthesis.effectEstimate.value
                    this.Element_Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Value",                                                                                             // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.effectEstimate.value",                                                               // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.effectEstimate.value",                                                                // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:296
                            {                                                                                                               // MakerGen.cs:297
                            }                                                                                                               // MakerGen.cs:300
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 44. EffectEvidenceSynthesis.effectEstimate.unitOfMeasure
                    this.Element_UnitOfMeasure = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_UnitOfMeasure",                                                                                     // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.effectEstimate.unitOfMeasure",                                                       // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.effectEstimate.unitOfMeasure",                                                        // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = 1,                                                                                                            // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 45. EffectEvidenceSynthesis.effectEstimate.precisionEstimate
                    this.Element_PrecisionEstimate = new ElementDefinitionInfo                                                              // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_PrecisionEstimate",                                                                                 // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate",                                                   // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate",                                                    // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_PrecisionEstimate                                                                                      // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 50. EffectEvidenceSynthesis.certainty
        public class Type_Certainty : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:376
        {                                                                                                                                   // MakerGen.cs:377
            // 53. EffectEvidenceSynthesis.certainty.certaintySubcomponent
            public class Type_CertaintySubcomponent : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:376
            {                                                                                                                               // MakerGen.cs:377
                // 54. EffectEvidenceSynthesis.certainty.certaintySubcomponent.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:212
                // 55. EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating
                public ElementDefinitionInfo Element_Rating;                                                                                // MakerGen.cs:212
                // 56. EffectEvidenceSynthesis.certainty.certaintySubcomponent.note
                public ElementDefinitionInfo Element_Note;                                                                                  // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:383
                {                                                                                                                           // MakerGen.cs:384
                    base.Write(sDef);                                                                                                       // MakerGen.cs:385
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:386
                    {                                                                                                                       // MakerGen.cs:387
                        Path = "EffectEvidenceSynthesis.certainty.certaintySubcomponent",                                                   // MakerGen.cs:388
                        ElementId = "EffectEvidenceSynthesis.certainty.certaintySubcomponent"                                               // MakerGen.cs:389
                    });                                                                                                                     // MakerGen.cs:390
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:216
                    Element_Rating.Write(sDef);                                                                                             // MakerGen.cs:216
                    Element_Note.Write(sDef);                                                                                               // MakerGen.cs:216
                }                                                                                                                           // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
                public Type_CertaintySubcomponent()                                                                                         // MakerGen.cs:395
                {                                                                                                                           // MakerGen.cs:396
                    {                                                                                                                       // MakerGen.cs:227
                        // 54. EffectEvidenceSynthesis.certainty.certaintySubcomponent.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Type",                                                                                          // MakerGen.cs:231
                            Path= "EffectEvidenceSynthesis.certainty.certaintySubcomponent.type",                                           // MakerGen.cs:232
                            Id = "EffectEvidenceSynthesis.certainty.certaintySubcomponent.type",                                            // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = 1,                                                                                                        // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 55. EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating
                        this.Element_Rating = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Rating",                                                                                        // MakerGen.cs:231
                            Path= "EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating",                                         // MakerGen.cs:232
                            Id = "EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating",                                          // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = -1,                                                                                                       // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:311
                                {                                                                                                           // MakerGen.cs:312
                                }                                                                                                           // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                    {                                                                                                                       // MakerGen.cs:227
                        // 56. EffectEvidenceSynthesis.certainty.certaintySubcomponent.note
                        this.Element_Note = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                        {                                                                                                                   // MakerGen.cs:230
                            Name = "Element_Note",                                                                                          // MakerGen.cs:231
                            Path= "EffectEvidenceSynthesis.certainty.certaintySubcomponent.note",                                           // MakerGen.cs:232
                            Id = "EffectEvidenceSynthesis.certainty.certaintySubcomponent.note",                                            // MakerGen.cs:233
                            Min = 0,                                                                                                        // MakerGen.cs:234
                            Max = -1,                                                                                                       // MakerGen.cs:235
                            Types = new BaseType[]                                                                                          // MakerGen.cs:236
                            {                                                                                                               // MakerGen.cs:237
                                new FhirKhit.Maker.Common.Complex.Type_Annotation                                                           // MakerGen.cs:351
                                {                                                                                                           // MakerGen.cs:352
                                }                                                                                                           // MakerGen.cs:353
                            }                                                                                                               // MakerGen.cs:239
                        };                                                                                                                  // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:241
                }                                                                                                                           // MakerGen.cs:398
            }                                                                                                                               // MakerGen.cs:400
            // 51. EffectEvidenceSynthesis.certainty.rating
            public ElementDefinitionInfo Element_Rating;                                                                                    // MakerGen.cs:212
            // 52. EffectEvidenceSynthesis.certainty.note
            public ElementDefinitionInfo Element_Note;                                                                                      // MakerGen.cs:212
            // 53. EffectEvidenceSynthesis.certainty.certaintySubcomponent
            public ElementDefinitionInfo Element_CertaintySubcomponent;                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                base.Write(sDef);                                                                                                           // MakerGen.cs:385
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    Path = "EffectEvidenceSynthesis.certainty",                                                                             // MakerGen.cs:388
                    ElementId = "EffectEvidenceSynthesis.certainty"                                                                         // MakerGen.cs:389
                });                                                                                                                         // MakerGen.cs:390
                Element_Rating.Write(sDef);                                                                                                 // MakerGen.cs:216
                Element_Note.Write(sDef);                                                                                                   // MakerGen.cs:216
                Element_CertaintySubcomponent.Write(sDef);                                                                                  // MakerGen.cs:216
            }                                                                                                                               // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
            public Type_Certainty()                                                                                                         // MakerGen.cs:395
            {                                                                                                                               // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:227
                    // 51. EffectEvidenceSynthesis.certainty.rating
                    this.Element_Rating = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Rating",                                                                                            // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.certainty.rating",                                                                   // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.certainty.rating",                                                                    // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:311
                            {                                                                                                               // MakerGen.cs:312
                            }                                                                                                               // MakerGen.cs:315
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 52. EffectEvidenceSynthesis.certainty.note
                    this.Element_Note = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_Note",                                                                                              // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.certainty.note",                                                                     // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.certainty.note",                                                                      // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new FhirKhit.Maker.Common.Complex.Type_Annotation                                                               // MakerGen.cs:351
                            {                                                                                                               // MakerGen.cs:352
                            }                                                                                                               // MakerGen.cs:353
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
                {                                                                                                                           // MakerGen.cs:227
                    // 53. EffectEvidenceSynthesis.certainty.certaintySubcomponent
                    this.Element_CertaintySubcomponent = new ElementDefinitionInfo                                                          // MakerGen.cs:229
                    {                                                                                                                       // MakerGen.cs:230
                        Name = "Element_CertaintySubcomponent",                                                                             // MakerGen.cs:231
                        Path= "EffectEvidenceSynthesis.certainty.certaintySubcomponent",                                                    // MakerGen.cs:232
                        Id = "EffectEvidenceSynthesis.certainty.certaintySubcomponent",                                                     // MakerGen.cs:233
                        Min = 0,                                                                                                            // MakerGen.cs:234
                        Max = -1,                                                                                                           // MakerGen.cs:235
                        Types = new BaseType[]                                                                                              // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            new Type_CertaintySubcomponent                                                                                  // MakerGen.cs:255
                            {                                                                                                               // MakerGen.cs:256
                            }                                                                                                               // MakerGen.cs:257
                        }                                                                                                                   // MakerGen.cs:239
                    };                                                                                                                      // MakerGen.cs:240
                }                                                                                                                           // MakerGen.cs:241
            }                                                                                                                               // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:400
        // 1. EffectEvidenceSynthesis.url
        public ElementDefinitionInfo Element_Url;                                                                                           // MakerGen.cs:212
        // 2. EffectEvidenceSynthesis.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:212
        // 3. EffectEvidenceSynthesis.version
        public ElementDefinitionInfo Element_Version;                                                                                       // MakerGen.cs:212
        // 4. EffectEvidenceSynthesis.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:212
        // 5. EffectEvidenceSynthesis.title
        public ElementDefinitionInfo Element_Title;                                                                                         // MakerGen.cs:212
        // 6. EffectEvidenceSynthesis.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:212
        // 7. EffectEvidenceSynthesis.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:212
        // 8. EffectEvidenceSynthesis.publisher
        public ElementDefinitionInfo Element_Publisher;                                                                                     // MakerGen.cs:212
        // 9. EffectEvidenceSynthesis.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:212
        // 10. EffectEvidenceSynthesis.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:212
        // 11. EffectEvidenceSynthesis.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:212
        // 12. EffectEvidenceSynthesis.useContext
        public ElementDefinitionInfo Element_UseContext;                                                                                    // MakerGen.cs:212
        // 13. EffectEvidenceSynthesis.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;                                                                                  // MakerGen.cs:212
        // 14. EffectEvidenceSynthesis.copyright
        public ElementDefinitionInfo Element_Copyright;                                                                                     // MakerGen.cs:212
        // 15. EffectEvidenceSynthesis.approvalDate
        public ElementDefinitionInfo Element_ApprovalDate;                                                                                  // MakerGen.cs:212
        // 16. EffectEvidenceSynthesis.lastReviewDate
        public ElementDefinitionInfo Element_LastReviewDate;                                                                                // MakerGen.cs:212
        // 17. EffectEvidenceSynthesis.effectivePeriod
        public ElementDefinitionInfo Element_EffectivePeriod;                                                                               // MakerGen.cs:212
        // 18. EffectEvidenceSynthesis.topic
        public ElementDefinitionInfo Element_Topic;                                                                                         // MakerGen.cs:212
        // 19. EffectEvidenceSynthesis.author
        public ElementDefinitionInfo Element_Author;                                                                                        // MakerGen.cs:212
        // 20. EffectEvidenceSynthesis.editor
        public ElementDefinitionInfo Element_Editor;                                                                                        // MakerGen.cs:212
        // 21. EffectEvidenceSynthesis.reviewer
        public ElementDefinitionInfo Element_Reviewer;                                                                                      // MakerGen.cs:212
        // 22. EffectEvidenceSynthesis.endorser
        public ElementDefinitionInfo Element_Endorser;                                                                                      // MakerGen.cs:212
        // 23. EffectEvidenceSynthesis.relatedArtifact
        public ElementDefinitionInfo Element_RelatedArtifact;                                                                               // MakerGen.cs:212
        // 24. EffectEvidenceSynthesis.synthesisType
        public ElementDefinitionInfo Element_SynthesisType;                                                                                 // MakerGen.cs:212
        // 25. EffectEvidenceSynthesis.studyType
        public ElementDefinitionInfo Element_StudyType;                                                                                     // MakerGen.cs:212
        // 26. EffectEvidenceSynthesis.population
        public ElementDefinitionInfo Element_Population;                                                                                    // MakerGen.cs:212
        // 27. EffectEvidenceSynthesis.exposure
        public ElementDefinitionInfo Element_Exposure;                                                                                      // MakerGen.cs:212
        // 28. EffectEvidenceSynthesis.exposureAlternative
        public ElementDefinitionInfo Element_ExposureAlternative;                                                                           // MakerGen.cs:212
        // 29. EffectEvidenceSynthesis.outcome
        public ElementDefinitionInfo Element_Outcome;                                                                                       // MakerGen.cs:212
        // 30. EffectEvidenceSynthesis.sampleSize
        public ElementDefinitionInfo Element_SampleSize;                                                                                    // MakerGen.cs:212
        // 34. EffectEvidenceSynthesis.resultsByExposure
        public ElementDefinitionInfo Element_ResultsByExposure;                                                                             // MakerGen.cs:212
        // 39. EffectEvidenceSynthesis.effectEstimate
        public ElementDefinitionInfo Element_EffectEstimate;                                                                                // MakerGen.cs:212
        // 50. EffectEvidenceSynthesis.certainty
        public ElementDefinitionInfo Element_Certainty;                                                                                     // MakerGen.cs:212
                                                                                                                                            // MakerGen.cs:382
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            base.Write(sDef);                                                                                                               // MakerGen.cs:385
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:386
            {                                                                                                                               // MakerGen.cs:387
                Path = "EffectEvidenceSynthesis",                                                                                           // MakerGen.cs:388
                ElementId = "EffectEvidenceSynthesis"                                                                                       // MakerGen.cs:389
            });                                                                                                                             // MakerGen.cs:390
            Element_Url.Write(sDef);                                                                                                        // MakerGen.cs:216
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Version.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Title.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Date.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_Publisher.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Contact.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_Description.Write(sDef);                                                                                                // MakerGen.cs:216
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:216
            Element_UseContext.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Jurisdiction.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_Copyright.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_ApprovalDate.Write(sDef);                                                                                               // MakerGen.cs:216
            Element_LastReviewDate.Write(sDef);                                                                                             // MakerGen.cs:216
            Element_EffectivePeriod.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_Topic.Write(sDef);                                                                                                      // MakerGen.cs:216
            Element_Author.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Editor.Write(sDef);                                                                                                     // MakerGen.cs:216
            Element_Reviewer.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_Endorser.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_RelatedArtifact.Write(sDef);                                                                                            // MakerGen.cs:216
            Element_SynthesisType.Write(sDef);                                                                                              // MakerGen.cs:216
            Element_StudyType.Write(sDef);                                                                                                  // MakerGen.cs:216
            Element_Population.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_Exposure.Write(sDef);                                                                                                   // MakerGen.cs:216
            Element_ExposureAlternative.Write(sDef);                                                                                        // MakerGen.cs:216
            Element_Outcome.Write(sDef);                                                                                                    // MakerGen.cs:216
            Element_SampleSize.Write(sDef);                                                                                                 // MakerGen.cs:216
            Element_ResultsByExposure.Write(sDef);                                                                                          // MakerGen.cs:216
            Element_EffectEstimate.Write(sDef);                                                                                             // MakerGen.cs:216
            Element_Certainty.Write(sDef);                                                                                                  // MakerGen.cs:216
        }                                                                                                                                   // MakerGen.cs:392
                                                                                                                                            // MakerGen.cs:394
        public Resource_EffectEvidenceSynthesis()                                                                                           // MakerGen.cs:395
        {                                                                                                                                   // MakerGen.cs:396
            {                                                                                                                               // MakerGen.cs:227
                // 1. EffectEvidenceSynthesis.url
                this.Element_Url = new ElementDefinitionInfo                                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.url",                                                                                    // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.url",                                                                                     // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 2. EffectEvidenceSynthesis.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.identifier",                                                                             // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.identifier",                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 3. EffectEvidenceSynthesis.version
                this.Element_Version = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Version",                                                                                               // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.version",                                                                                // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.version",                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 4. EffectEvidenceSynthesis.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.name",                                                                                   // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.name",                                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 5. EffectEvidenceSynthesis.title
                this.Element_Title = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Title",                                                                                                 // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.title",                                                                                  // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.title",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 6. EffectEvidenceSynthesis.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Status",                                                                                                // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.status",                                                                                 // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.status",                                                                                  // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 7. EffectEvidenceSynthesis.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.date",                                                                                   // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.date",                                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 8. EffectEvidenceSynthesis.publisher
                this.Element_Publisher = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.publisher",                                                                              // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.publisher",                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 9. EffectEvidenceSynthesis.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.contact",                                                                                // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.contact",                                                                                 // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 10. EffectEvidenceSynthesis.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Description",                                                                                           // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.description",                                                                            // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.description",                                                                             // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 11. EffectEvidenceSynthesis.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.note",                                                                                   // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.note",                                                                                    // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 12. EffectEvidenceSynthesis.useContext
                this.Element_UseContext = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.useContext",                                                                             // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.useContext",                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_UsageContext                                                                 // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 13. EffectEvidenceSynthesis.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.jurisdiction",                                                                           // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.jurisdiction",                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 14. EffectEvidenceSynthesis.copyright
                this.Element_Copyright = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Copyright",                                                                                             // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.copyright",                                                                              // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.copyright",                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 15. EffectEvidenceSynthesis.approvalDate
                this.Element_ApprovalDate = new ElementDefinitionInfo                                                                       // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ApprovalDate",                                                                                          // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.approvalDate",                                                                           // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.approvalDate",                                                                            // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 16. EffectEvidenceSynthesis.lastReviewDate
                this.Element_LastReviewDate = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_LastReviewDate",                                                                                        // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.lastReviewDate",                                                                         // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.lastReviewDate",                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                                  // MakerGen.cs:296
                        {                                                                                                                   // MakerGen.cs:297
                        }                                                                                                                   // MakerGen.cs:300
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 17. EffectEvidenceSynthesis.effectivePeriod
                this.Element_EffectivePeriod = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_EffectivePeriod",                                                                                       // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.effectivePeriod",                                                                        // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.effectivePeriod",                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 18. EffectEvidenceSynthesis.topic
                this.Element_Topic = new ElementDefinitionInfo                                                                              // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Topic",                                                                                                 // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.topic",                                                                                  // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.topic",                                                                                   // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 19. EffectEvidenceSynthesis.author
                this.Element_Author = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Author",                                                                                                // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.author",                                                                                 // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.author",                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 20. EffectEvidenceSynthesis.editor
                this.Element_Editor = new ElementDefinitionInfo                                                                             // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Editor",                                                                                                // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.editor",                                                                                 // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.editor",                                                                                  // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 21. EffectEvidenceSynthesis.reviewer
                this.Element_Reviewer = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Reviewer",                                                                                              // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.reviewer",                                                                               // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.reviewer",                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 22. EffectEvidenceSynthesis.endorser
                this.Element_Endorser = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Endorser",                                                                                              // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.endorser",                                                                               // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.endorser",                                                                                // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 23. EffectEvidenceSynthesis.relatedArtifact
                this.Element_RelatedArtifact = new ElementDefinitionInfo                                                                    // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_RelatedArtifact",                                                                                       // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.relatedArtifact",                                                                        // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.relatedArtifact",                                                                         // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_RelatedArtifact                                                              // MakerGen.cs:351
                        {                                                                                                                   // MakerGen.cs:352
                        }                                                                                                                   // MakerGen.cs:353
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 24. EffectEvidenceSynthesis.synthesisType
                this.Element_SynthesisType = new ElementDefinitionInfo                                                                      // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_SynthesisType",                                                                                         // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.synthesisType",                                                                          // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.synthesisType",                                                                           // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 25. EffectEvidenceSynthesis.studyType
                this.Element_StudyType = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_StudyType",                                                                                             // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.studyType",                                                                              // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.studyType",                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:311
                        {                                                                                                                   // MakerGen.cs:312
                        }                                                                                                                   // MakerGen.cs:315
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 26. EffectEvidenceSynthesis.population
                this.Element_Population = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Population",                                                                                            // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.population",                                                                             // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.population",                                                                              // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                                  // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 27. EffectEvidenceSynthesis.exposure
                this.Element_Exposure = new ElementDefinitionInfo                                                                           // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Exposure",                                                                                              // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.exposure",                                                                               // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.exposure",                                                                                // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                                  // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 28. EffectEvidenceSynthesis.exposureAlternative
                this.Element_ExposureAlternative = new ElementDefinitionInfo                                                                // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ExposureAlternative",                                                                                   // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.exposureAlternative",                                                                    // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.exposureAlternative",                                                                     // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                                  // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 29. EffectEvidenceSynthesis.outcome
                this.Element_Outcome = new ElementDefinitionInfo                                                                            // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Outcome",                                                                                               // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.outcome",                                                                                // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.outcome",                                                                                 // MakerGen.cs:233
                    Min = 1,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:339
                        {                                                                                                                   // MakerGen.cs:340
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:342
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                                  // MakerGen.cs:342
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:343
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 30. EffectEvidenceSynthesis.sampleSize
                this.Element_SampleSize = new ElementDefinitionInfo                                                                         // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_SampleSize",                                                                                            // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.sampleSize",                                                                             // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.sampleSize",                                                                              // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = 1,                                                                                                                // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_SampleSize                                                                                                 // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 34. EffectEvidenceSynthesis.resultsByExposure
                this.Element_ResultsByExposure = new ElementDefinitionInfo                                                                  // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_ResultsByExposure",                                                                                     // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.resultsByExposure",                                                                      // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.resultsByExposure",                                                                       // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_ResultsByExposure                                                                                          // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 39. EffectEvidenceSynthesis.effectEstimate
                this.Element_EffectEstimate = new ElementDefinitionInfo                                                                     // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_EffectEstimate",                                                                                        // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.effectEstimate",                                                                         // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.effectEstimate",                                                                          // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_EffectEstimate                                                                                             // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            {                                                                                                                               // MakerGen.cs:227
                // 50. EffectEvidenceSynthesis.certainty
                this.Element_Certainty = new ElementDefinitionInfo                                                                          // MakerGen.cs:229
                {                                                                                                                           // MakerGen.cs:230
                    Name = "Element_Certainty",                                                                                             // MakerGen.cs:231
                    Path= "EffectEvidenceSynthesis.certainty",                                                                              // MakerGen.cs:232
                    Id = "EffectEvidenceSynthesis.certainty",                                                                               // MakerGen.cs:233
                    Min = 0,                                                                                                                // MakerGen.cs:234
                    Max = -1,                                                                                                               // MakerGen.cs:235
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        new Type_Certainty                                                                                                  // MakerGen.cs:255
                        {                                                                                                                   // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:257
                    }                                                                                                                       // MakerGen.cs:239
                };                                                                                                                          // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:241
            this.Name = "EffectEvidenceSynthesis";                                                                                          // MakerGen.cs:458
            this.Uri = "http://hl7.org/fhir/StructureDefinition/EffectEvidenceSynthesis";                                                   // MakerGen.cs:459
        }                                                                                                                                   // MakerGen.cs:398
    }                                                                                                                                       // MakerGen.cs:400
}                                                                                                                                           // MakerGen.cs:445
