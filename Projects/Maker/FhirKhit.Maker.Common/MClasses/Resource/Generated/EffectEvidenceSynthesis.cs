using System;                                                                                                                               // MakerGen.cs:462
using System.Diagnostics;                                                                                                                   // MakerGen.cs:463
using System.IO;                                                                                                                            // MakerGen.cs:464
using System.Linq;                                                                                                                          // MakerGen.cs:465
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:466
                                                                                                                                            // MakerGen.cs:467
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:468
{                                                                                                                                           // MakerGen.cs:469
    #region Json                                                                                                                            // MakerGen.cs:470
    #if NEVER                                                                                                                               // MakerGen.cs:471
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
    #endregion                                                                                                                              // MakerGen.cs:474
    /// <summary>
    /// Fhir resource 'EffectEvidenceSynthesis'
    /// </summary>
    // 0. EffectEvidenceSynthesis
    public class EffectEvidenceSynthesis : FhirKhit.Maker.Common.Resource.ResourceBase                                                      // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        public class EffectEvidenceSynthesis_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:386
        {                                                                                                                                   // MakerGen.cs:387
            // 30. EffectEvidenceSynthesis.sampleSize
            public class Type_SampleSize : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_SampleSize_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                         // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 31. EffectEvidenceSynthesis.sampleSize.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:216
                    // 32. EffectEvidenceSynthesis.sampleSize.numberOfStudies
                    public ElementDefinitionInfo NumberOfStudies;                                                                           // MakerGen.cs:216
                    // 33. EffectEvidenceSynthesis.sampleSize.numberOfParticipants
                    public ElementDefinitionInfo NumberOfParticipants;                                                                      // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_SampleSize_Elements()                                                                                       // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 31. EffectEvidenceSynthesis.sampleSize.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Description",                                                                                       // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.sampleSize.description",                                                     // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.sampleSize.description",                                                      // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 32. EffectEvidenceSynthesis.sampleSize.numberOfStudies
                            this.NumberOfStudies = new ElementDefinitionInfo                                                                // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "NumberOfStudies",                                                                                   // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.sampleSize.numberOfStudies",                                                 // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.sampleSize.numberOfStudies",                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 33. EffectEvidenceSynthesis.sampleSize.numberOfParticipants
                            this.NumberOfParticipants = new ElementDefinitionInfo                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "NumberOfParticipants",                                                                              // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.sampleSize.numberOfParticipants",                                            // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.sampleSize.numberOfParticipants",                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Description.Write(sDef);                                                                                            // MakerGen.cs:220
                        NumberOfStudies.Write(sDef);                                                                                        // MakerGen.cs:220
                        NumberOfParticipants.Write(sDef);                                                                                   // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_SampleSize_Elements Elements                                                                                    // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_SampleSize_Elements();                                                                 // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_SampleSize_Elements elements;                                                                                          // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_SampleSize()                                                                                                    // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "EffectEvidenceSynthesis.sampleSize",                                                                        // MakerGen.cs:428
                        ElementId = "EffectEvidenceSynthesis.sampleSize"                                                                    // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 34. EffectEvidenceSynthesis.resultsByExposure
            public class Type_ResultsByExposure : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_ResultsByExposure_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 35. EffectEvidenceSynthesis.resultsByExposure.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:216
                    // 36. EffectEvidenceSynthesis.resultsByExposure.exposureState
                    public ElementDefinitionInfo ExposureState;                                                                             // MakerGen.cs:216
                    // 37. EffectEvidenceSynthesis.resultsByExposure.variantState
                    public ElementDefinitionInfo VariantState;                                                                              // MakerGen.cs:216
                    // 38. EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis
                    public ElementDefinitionInfo RiskEvidenceSynthesis;                                                                     // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_ResultsByExposure_Elements()                                                                                // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 35. EffectEvidenceSynthesis.resultsByExposure.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Description",                                                                                       // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.resultsByExposure.description",                                              // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.resultsByExposure.description",                                               // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 36. EffectEvidenceSynthesis.resultsByExposure.exposureState
                            this.ExposureState = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "ExposureState",                                                                                     // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.resultsByExposure.exposureState",                                            // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.resultsByExposure.exposureState",                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 37. EffectEvidenceSynthesis.resultsByExposure.variantState
                            this.VariantState = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "VariantState",                                                                                      // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.resultsByExposure.variantState",                                             // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.resultsByExposure.variantState",                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 38. EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis
                            this.RiskEvidenceSynthesis = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "RiskEvidenceSynthesis",                                                                             // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis",                                    // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis",                                     // MakerGen.cs:237
                                Min = 1,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:346
                                    {                                                                                                       // MakerGen.cs:347
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:349
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/RiskEvidenceSynthesis"                                 // MakerGen.cs:349
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:350
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Description.Write(sDef);                                                                                            // MakerGen.cs:220
                        ExposureState.Write(sDef);                                                                                          // MakerGen.cs:220
                        VariantState.Write(sDef);                                                                                           // MakerGen.cs:220
                        RiskEvidenceSynthesis.Write(sDef);                                                                                  // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_ResultsByExposure_Elements Elements                                                                             // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_ResultsByExposure_Elements();                                                          // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_ResultsByExposure_Elements elements;                                                                                   // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_ResultsByExposure()                                                                                             // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "EffectEvidenceSynthesis.resultsByExposure",                                                                 // MakerGen.cs:428
                        ElementId = "EffectEvidenceSynthesis.resultsByExposure"                                                             // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 39. EffectEvidenceSynthesis.effectEstimate
            public class Type_EffectEstimate : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_EffectEstimate_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 45. EffectEvidenceSynthesis.effectEstimate.precisionEstimate
                    public class Type_PrecisionEstimate : FhirKhit.Maker.Common.Complex.ComplexBase                                         // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_PrecisionEstimate_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                          // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 46. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:216
                            // 47. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level
                            public ElementDefinitionInfo Level;                                                                             // MakerGen.cs:216
                            // 48. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from
                            public ElementDefinitionInfo From;                                                                              // MakerGen.cs:216
                            // 49. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to
                            public ElementDefinitionInfo To;                                                                                // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_PrecisionEstimate_Elements()                                                                        // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 46. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Type",                                                                                      // MakerGen.cs:235
                                        Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type",                              // MakerGen.cs:236
                                        Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type",                               // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 47. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level
                                    this.Level = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Level",                                                                                     // MakerGen.cs:235
                                        Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level",                             // MakerGen.cs:236
                                        Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level",                              // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 48. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from
                                    this.From = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "From",                                                                                      // MakerGen.cs:235
                                        Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from",                              // MakerGen.cs:236
                                        Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from",                               // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 49. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to
                                    this.To = new ElementDefinitionInfo                                                                     // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "To",                                                                                        // MakerGen.cs:235
                                        Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to",                                // MakerGen.cs:236
                                        Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to",                                 // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:300
                                            {                                                                                               // MakerGen.cs:301
                                            }                                                                                               // MakerGen.cs:304
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Type.Write(sDef);                                                                                           // MakerGen.cs:220
                                Level.Write(sDef);                                                                                          // MakerGen.cs:220
                                From.Write(sDef);                                                                                           // MakerGen.cs:220
                                To.Write(sDef);                                                                                             // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_PrecisionEstimate_Elements Elements                                                                     // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_PrecisionEstimate_Elements();                                                  // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_PrecisionEstimate_Elements elements;                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_PrecisionEstimate()                                                                                     // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate",                                          // MakerGen.cs:428
                                ElementId = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate"                                      // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 40. EffectEvidenceSynthesis.effectEstimate.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:216
                    // 41. EffectEvidenceSynthesis.effectEstimate.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:216
                    // 42. EffectEvidenceSynthesis.effectEstimate.variantState
                    public ElementDefinitionInfo VariantState;                                                                              // MakerGen.cs:216
                    // 43. EffectEvidenceSynthesis.effectEstimate.value
                    public ElementDefinitionInfo Value;                                                                                     // MakerGen.cs:216
                    // 44. EffectEvidenceSynthesis.effectEstimate.unitOfMeasure
                    public ElementDefinitionInfo UnitOfMeasure;                                                                             // MakerGen.cs:216
                    // 45. EffectEvidenceSynthesis.effectEstimate.precisionEstimate
                    public ElementDefinitionInfo PrecisionEstimate;                                                                         // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_EffectEstimate_Elements()                                                                                   // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 40. EffectEvidenceSynthesis.effectEstimate.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Description",                                                                                       // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.effectEstimate.description",                                                 // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.effectEstimate.description",                                                  // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 41. EffectEvidenceSynthesis.effectEstimate.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Type",                                                                                              // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.effectEstimate.type",                                                        // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.effectEstimate.type",                                                         // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 42. EffectEvidenceSynthesis.effectEstimate.variantState
                            this.VariantState = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "VariantState",                                                                                      // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.effectEstimate.variantState",                                                // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.effectEstimate.variantState",                                                 // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 43. EffectEvidenceSynthesis.effectEstimate.value
                            this.Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Value",                                                                                             // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.effectEstimate.value",                                                       // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.effectEstimate.value",                                                        // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Primitive.Decimal                                                             // MakerGen.cs:300
                                    {                                                                                                       // MakerGen.cs:301
                                    }                                                                                                       // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 44. EffectEvidenceSynthesis.effectEstimate.unitOfMeasure
                            this.UnitOfMeasure = new ElementDefinitionInfo                                                                  // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "UnitOfMeasure",                                                                                     // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.effectEstimate.unitOfMeasure",                                               // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.effectEstimate.unitOfMeasure",                                                // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = 1,                                                                                                    // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 45. EffectEvidenceSynthesis.effectEstimate.precisionEstimate
                            this.PrecisionEstimate = new ElementDefinitionInfo                                                              // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "PrecisionEstimate",                                                                                 // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate",                                           // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate",                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_PrecisionEstimate                                                                              // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Description.Write(sDef);                                                                                            // MakerGen.cs:220
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:220
                        VariantState.Write(sDef);                                                                                           // MakerGen.cs:220
                        Value.Write(sDef);                                                                                                  // MakerGen.cs:220
                        UnitOfMeasure.Write(sDef);                                                                                          // MakerGen.cs:220
                        PrecisionEstimate.Write(sDef);                                                                                      // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_EffectEstimate_Elements Elements                                                                                // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_EffectEstimate_Elements();                                                             // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_EffectEstimate_Elements elements;                                                                                      // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_EffectEstimate()                                                                                                // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "EffectEvidenceSynthesis.effectEstimate",                                                                    // MakerGen.cs:428
                        ElementId = "EffectEvidenceSynthesis.effectEstimate"                                                                // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 50. EffectEvidenceSynthesis.certainty
            public class Type_Certainty : FhirKhit.Maker.Common.Complex.ComplexBase                                                         // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                public class Type_Certainty_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                          // MakerGen.cs:386
                {                                                                                                                           // MakerGen.cs:387
                    // 53. EffectEvidenceSynthesis.certainty.certaintySubcomponent
                    public class Type_CertaintySubcomponent : FhirKhit.Maker.Common.Complex.ComplexBase                                     // MakerGen.cs:384
                    {                                                                                                                       // MakerGen.cs:385
                        public class Type_CertaintySubcomponent_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                      // MakerGen.cs:386
                        {                                                                                                                   // MakerGen.cs:387
                            // 54. EffectEvidenceSynthesis.certainty.certaintySubcomponent.type
                            public ElementDefinitionInfo Type;                                                                              // MakerGen.cs:216
                            // 55. EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating
                            public ElementDefinitionInfo Rating;                                                                            // MakerGen.cs:216
                            // 56. EffectEvidenceSynthesis.certainty.certaintySubcomponent.note
                            public ElementDefinitionInfo Note;                                                                              // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                            public Type_CertaintySubcomponent_Elements()                                                                    // MakerGen.cs:392
                            {                                                                                                               // MakerGen.cs:393
                                {                                                                                                           // MakerGen.cs:231
                                    // 54. EffectEvidenceSynthesis.certainty.certaintySubcomponent.type
                                    this.Type = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Type",                                                                                      // MakerGen.cs:235
                                        Path= "EffectEvidenceSynthesis.certainty.certaintySubcomponent.type",                               // MakerGen.cs:236
                                        Id = "EffectEvidenceSynthesis.certainty.certaintySubcomponent.type",                                // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = 1,                                                                                            // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 55. EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating
                                    this.Rating = new ElementDefinitionInfo                                                                 // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Rating",                                                                                    // MakerGen.cs:235
                                        Path= "EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating",                             // MakerGen.cs:236
                                        Id = "EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating",                              // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                               // MakerGen.cs:315
                                            {                                                                                               // MakerGen.cs:316
                                            }                                                                                               // MakerGen.cs:319
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                                {                                                                                                           // MakerGen.cs:231
                                    // 56. EffectEvidenceSynthesis.certainty.certaintySubcomponent.note
                                    this.Note = new ElementDefinitionInfo                                                                   // MakerGen.cs:233
                                    {                                                                                                       // MakerGen.cs:234
                                        Name = "Note",                                                                                      // MakerGen.cs:235
                                        Path= "EffectEvidenceSynthesis.certainty.certaintySubcomponent.note",                               // MakerGen.cs:236
                                        Id = "EffectEvidenceSynthesis.certainty.certaintySubcomponent.note",                                // MakerGen.cs:237
                                        Min = 0,                                                                                            // MakerGen.cs:238
                                        Max = -1,                                                                                           // MakerGen.cs:239
                                        Types = new BaseType[]                                                                              // MakerGen.cs:240
                                        {                                                                                                   // MakerGen.cs:241
                                            new FhirKhit.Maker.Common.Complex.Annotation                                                    // MakerGen.cs:358
                                            {                                                                                               // MakerGen.cs:359
                                            }                                                                                               // MakerGen.cs:360
                                        }                                                                                                   // MakerGen.cs:243
                                    };                                                                                                      // MakerGen.cs:244
                                }                                                                                                           // MakerGen.cs:245
                            }                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:398
                            {                                                                                                               // MakerGen.cs:399
                                base.Write(sDef);                                                                                           // MakerGen.cs:400
                                Type.Write(sDef);                                                                                           // MakerGen.cs:220
                                Rating.Write(sDef);                                                                                         // MakerGen.cs:220
                                Note.Write(sDef);                                                                                           // MakerGen.cs:220
                            }                                                                                                               // MakerGen.cs:402
                        }                                                                                                                   // MakerGen.cs:404
                        public Type_CertaintySubcomponent_Elements Elements                                                                 // MakerGen.cs:406
                        {                                                                                                                   // MakerGen.cs:407
                            get                                                                                                             // MakerGen.cs:408
                            {                                                                                                               // MakerGen.cs:409
                                if (this.elements == null)                                                                                  // MakerGen.cs:410
                                    this.elements = new Type_CertaintySubcomponent_Elements();                                              // MakerGen.cs:411
                                return this.elements;                                                                                       // MakerGen.cs:412
                            }                                                                                                               // MakerGen.cs:413
                        }                                                                                                                   // MakerGen.cs:414
                        Type_CertaintySubcomponent_Elements elements;                                                                       // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                        public Type_CertaintySubcomponent()                                                                                 // MakerGen.cs:418
                        {                                                                                                                   // MakerGen.cs:419
                        }                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:424
                        {                                                                                                                   // MakerGen.cs:425
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:426
                            {                                                                                                               // MakerGen.cs:427
                                Path = "EffectEvidenceSynthesis.certainty.certaintySubcomponent",                                           // MakerGen.cs:428
                                ElementId = "EffectEvidenceSynthesis.certainty.certaintySubcomponent"                                       // MakerGen.cs:429
                            });                                                                                                             // MakerGen.cs:430
                            if (this.elements != null)                                                                                      // MakerGen.cs:431
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:432
                        }                                                                                                                   // MakerGen.cs:433
                    }                                                                                                                       // MakerGen.cs:434
                    // 51. EffectEvidenceSynthesis.certainty.rating
                    public ElementDefinitionInfo Rating;                                                                                    // MakerGen.cs:216
                    // 52. EffectEvidenceSynthesis.certainty.note
                    public ElementDefinitionInfo Note;                                                                                      // MakerGen.cs:216
                    // 53. EffectEvidenceSynthesis.certainty.certaintySubcomponent
                    public ElementDefinitionInfo CertaintySubcomponent;                                                                     // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
                    public Type_Certainty_Elements()                                                                                        // MakerGen.cs:392
                    {                                                                                                                       // MakerGen.cs:393
                        {                                                                                                                   // MakerGen.cs:231
                            // 51. EffectEvidenceSynthesis.certainty.rating
                            this.Rating = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Rating",                                                                                            // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.certainty.rating",                                                           // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.certainty.rating",                                                            // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:315
                                    {                                                                                                       // MakerGen.cs:316
                                    }                                                                                                       // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 52. EffectEvidenceSynthesis.certainty.note
                            this.Note = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "Note",                                                                                              // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.certainty.note",                                                             // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.certainty.note",                                                              // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new FhirKhit.Maker.Common.Complex.Annotation                                                            // MakerGen.cs:358
                                    {                                                                                                       // MakerGen.cs:359
                                    }                                                                                                       // MakerGen.cs:360
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:231
                            // 53. EffectEvidenceSynthesis.certainty.certaintySubcomponent
                            this.CertaintySubcomponent = new ElementDefinitionInfo                                                          // MakerGen.cs:233
                            {                                                                                                               // MakerGen.cs:234
                                Name = "CertaintySubcomponent",                                                                             // MakerGen.cs:235
                                Path= "EffectEvidenceSynthesis.certainty.certaintySubcomponent",                                            // MakerGen.cs:236
                                Id = "EffectEvidenceSynthesis.certainty.certaintySubcomponent",                                             // MakerGen.cs:237
                                Min = 0,                                                                                                    // MakerGen.cs:238
                                Max = -1,                                                                                                   // MakerGen.cs:239
                                Types = new BaseType[]                                                                                      // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:241
                                    new Type_CertaintySubcomponent                                                                          // MakerGen.cs:259
                                    {                                                                                                       // MakerGen.cs:260
                                    }                                                                                                       // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:243
                            };                                                                                                              // MakerGen.cs:244
                        }                                                                                                                   // MakerGen.cs:245
                    }                                                                                                                       // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:398
                    {                                                                                                                       // MakerGen.cs:399
                        base.Write(sDef);                                                                                                   // MakerGen.cs:400
                        Rating.Write(sDef);                                                                                                 // MakerGen.cs:220
                        Note.Write(sDef);                                                                                                   // MakerGen.cs:220
                        CertaintySubcomponent.Write(sDef);                                                                                  // MakerGen.cs:220
                    }                                                                                                                       // MakerGen.cs:402
                }                                                                                                                           // MakerGen.cs:404
                public Type_Certainty_Elements Elements                                                                                     // MakerGen.cs:406
                {                                                                                                                           // MakerGen.cs:407
                    get                                                                                                                     // MakerGen.cs:408
                    {                                                                                                                       // MakerGen.cs:409
                        if (this.elements == null)                                                                                          // MakerGen.cs:410
                            this.elements = new Type_Certainty_Elements();                                                                  // MakerGen.cs:411
                        return this.elements;                                                                                               // MakerGen.cs:412
                    }                                                                                                                       // MakerGen.cs:413
                }                                                                                                                           // MakerGen.cs:414
                Type_Certainty_Elements elements;                                                                                           // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
                public Type_Certainty()                                                                                                     // MakerGen.cs:418
                {                                                                                                                           // MakerGen.cs:419
                }                                                                                                                           // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:424
                {                                                                                                                           // MakerGen.cs:425
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:426
                    {                                                                                                                       // MakerGen.cs:427
                        Path = "EffectEvidenceSynthesis.certainty",                                                                         // MakerGen.cs:428
                        ElementId = "EffectEvidenceSynthesis.certainty"                                                                     // MakerGen.cs:429
                    });                                                                                                                     // MakerGen.cs:430
                    if (this.elements != null)                                                                                              // MakerGen.cs:431
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:432
                }                                                                                                                           // MakerGen.cs:433
            }                                                                                                                               // MakerGen.cs:434
            // 1. EffectEvidenceSynthesis.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:216
            // 2. EffectEvidenceSynthesis.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:216
            // 3. EffectEvidenceSynthesis.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:216
            // 4. EffectEvidenceSynthesis.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:216
            // 5. EffectEvidenceSynthesis.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:216
            // 6. EffectEvidenceSynthesis.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:216
            // 7. EffectEvidenceSynthesis.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:216
            // 8. EffectEvidenceSynthesis.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:216
            // 9. EffectEvidenceSynthesis.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:216
            // 10. EffectEvidenceSynthesis.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:216
            // 11. EffectEvidenceSynthesis.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:216
            // 12. EffectEvidenceSynthesis.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:216
            // 13. EffectEvidenceSynthesis.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:216
            // 14. EffectEvidenceSynthesis.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:216
            // 15. EffectEvidenceSynthesis.approvalDate
            public ElementDefinitionInfo ApprovalDate;                                                                                      // MakerGen.cs:216
            // 16. EffectEvidenceSynthesis.lastReviewDate
            public ElementDefinitionInfo LastReviewDate;                                                                                    // MakerGen.cs:216
            // 17. EffectEvidenceSynthesis.effectivePeriod
            public ElementDefinitionInfo EffectivePeriod;                                                                                   // MakerGen.cs:216
            // 18. EffectEvidenceSynthesis.topic
            public ElementDefinitionInfo Topic;                                                                                             // MakerGen.cs:216
            // 19. EffectEvidenceSynthesis.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:216
            // 20. EffectEvidenceSynthesis.editor
            public ElementDefinitionInfo Editor;                                                                                            // MakerGen.cs:216
            // 21. EffectEvidenceSynthesis.reviewer
            public ElementDefinitionInfo Reviewer;                                                                                          // MakerGen.cs:216
            // 22. EffectEvidenceSynthesis.endorser
            public ElementDefinitionInfo Endorser;                                                                                          // MakerGen.cs:216
            // 23. EffectEvidenceSynthesis.relatedArtifact
            public ElementDefinitionInfo RelatedArtifact;                                                                                   // MakerGen.cs:216
            // 24. EffectEvidenceSynthesis.synthesisType
            public ElementDefinitionInfo SynthesisType;                                                                                     // MakerGen.cs:216
            // 25. EffectEvidenceSynthesis.studyType
            public ElementDefinitionInfo StudyType;                                                                                         // MakerGen.cs:216
            // 26. EffectEvidenceSynthesis.population
            public ElementDefinitionInfo Population;                                                                                        // MakerGen.cs:216
            // 27. EffectEvidenceSynthesis.exposure
            public ElementDefinitionInfo Exposure;                                                                                          // MakerGen.cs:216
            // 28. EffectEvidenceSynthesis.exposureAlternative
            public ElementDefinitionInfo ExposureAlternative;                                                                               // MakerGen.cs:216
            // 29. EffectEvidenceSynthesis.outcome
            public ElementDefinitionInfo Outcome;                                                                                           // MakerGen.cs:216
            // 30. EffectEvidenceSynthesis.sampleSize
            public ElementDefinitionInfo SampleSize;                                                                                        // MakerGen.cs:216
            // 34. EffectEvidenceSynthesis.resultsByExposure
            public ElementDefinitionInfo ResultsByExposure;                                                                                 // MakerGen.cs:216
            // 39. EffectEvidenceSynthesis.effectEstimate
            public ElementDefinitionInfo EffectEstimate;                                                                                    // MakerGen.cs:216
            // 50. EffectEvidenceSynthesis.certainty
            public ElementDefinitionInfo Certainty;                                                                                         // MakerGen.cs:216
                                                                                                                                            // MakerGen.cs:391
            public EffectEvidenceSynthesis_Elements()                                                                                       // MakerGen.cs:392
            {                                                                                                                               // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:231
                    // 1. EffectEvidenceSynthesis.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Url",                                                                                                       // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.url",                                                                                // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.url",                                                                                 // MakerGen.cs:237
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
                    // 2. EffectEvidenceSynthesis.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Identifier",                                                                                                // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.identifier",                                                                         // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.identifier",                                                                          // MakerGen.cs:237
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
                    // 3. EffectEvidenceSynthesis.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Version",                                                                                                   // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.version",                                                                            // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.version",                                                                             // MakerGen.cs:237
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
                    // 4. EffectEvidenceSynthesis.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Name",                                                                                                      // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.name",                                                                               // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.name",                                                                                // MakerGen.cs:237
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
                    // 5. EffectEvidenceSynthesis.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Title",                                                                                                     // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.title",                                                                              // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.title",                                                                               // MakerGen.cs:237
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
                    // 6. EffectEvidenceSynthesis.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Status",                                                                                                    // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.status",                                                                             // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.status",                                                                              // MakerGen.cs:237
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
                    // 7. EffectEvidenceSynthesis.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Date",                                                                                                      // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.date",                                                                               // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.date",                                                                                // MakerGen.cs:237
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
                    // 8. EffectEvidenceSynthesis.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Publisher",                                                                                                 // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.publisher",                                                                          // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.publisher",                                                                           // MakerGen.cs:237
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
                    // 9. EffectEvidenceSynthesis.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Contact",                                                                                                   // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.contact",                                                                            // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.contact",                                                                             // MakerGen.cs:237
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
                    // 10. EffectEvidenceSynthesis.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Description",                                                                                               // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.description",                                                                        // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.description",                                                                         // MakerGen.cs:237
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
                    // 11. EffectEvidenceSynthesis.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Note",                                                                                                      // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.note",                                                                               // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.note",                                                                                // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 12. EffectEvidenceSynthesis.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "UseContext",                                                                                                // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.useContext",                                                                         // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.useContext",                                                                          // MakerGen.cs:237
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
                    // 13. EffectEvidenceSynthesis.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.jurisdiction",                                                                       // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.jurisdiction",                                                                        // MakerGen.cs:237
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
                    // 14. EffectEvidenceSynthesis.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Copyright",                                                                                                 // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.copyright",                                                                          // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.copyright",                                                                           // MakerGen.cs:237
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
                    // 15. EffectEvidenceSynthesis.approvalDate
                    this.ApprovalDate = new ElementDefinitionInfo                                                                           // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ApprovalDate",                                                                                              // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.approvalDate",                                                                       // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.approvalDate",                                                                        // MakerGen.cs:237
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
                    // 16. EffectEvidenceSynthesis.lastReviewDate
                    this.LastReviewDate = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "LastReviewDate",                                                                                            // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.lastReviewDate",                                                                     // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.lastReviewDate",                                                                      // MakerGen.cs:237
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
                    // 17. EffectEvidenceSynthesis.effectivePeriod
                    this.EffectivePeriod = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "EffectivePeriod",                                                                                           // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.effectivePeriod",                                                                    // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.effectivePeriod",                                                                     // MakerGen.cs:237
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
                    // 18. EffectEvidenceSynthesis.topic
                    this.Topic = new ElementDefinitionInfo                                                                                  // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Topic",                                                                                                     // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.topic",                                                                              // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.topic",                                                                               // MakerGen.cs:237
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
                    // 19. EffectEvidenceSynthesis.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Author",                                                                                                    // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.author",                                                                             // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.author",                                                                              // MakerGen.cs:237
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
                    // 20. EffectEvidenceSynthesis.editor
                    this.Editor = new ElementDefinitionInfo                                                                                 // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Editor",                                                                                                    // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.editor",                                                                             // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.editor",                                                                              // MakerGen.cs:237
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
                    // 21. EffectEvidenceSynthesis.reviewer
                    this.Reviewer = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Reviewer",                                                                                                  // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.reviewer",                                                                           // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.reviewer",                                                                            // MakerGen.cs:237
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
                    // 22. EffectEvidenceSynthesis.endorser
                    this.Endorser = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Endorser",                                                                                                  // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.endorser",                                                                           // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.endorser",                                                                            // MakerGen.cs:237
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
                    // 23. EffectEvidenceSynthesis.relatedArtifact
                    this.RelatedArtifact = new ElementDefinitionInfo                                                                        // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "RelatedArtifact",                                                                                           // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.relatedArtifact",                                                                    // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.relatedArtifact",                                                                     // MakerGen.cs:237
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
                    // 24. EffectEvidenceSynthesis.synthesisType
                    this.SynthesisType = new ElementDefinitionInfo                                                                          // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SynthesisType",                                                                                             // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.synthesisType",                                                                      // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.synthesisType",                                                                       // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 25. EffectEvidenceSynthesis.studyType
                    this.StudyType = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "StudyType",                                                                                                 // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.studyType",                                                                          // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.studyType",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:315
                            {                                                                                                               // MakerGen.cs:316
                            }                                                                                                               // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 26. EffectEvidenceSynthesis.population
                    this.Population = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Population",                                                                                                // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.population",                                                                         // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.population",                                                                          // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 27. EffectEvidenceSynthesis.exposure
                    this.Exposure = new ElementDefinitionInfo                                                                               // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Exposure",                                                                                                  // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.exposure",                                                                           // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.exposure",                                                                            // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 28. EffectEvidenceSynthesis.exposureAlternative
                    this.ExposureAlternative = new ElementDefinitionInfo                                                                    // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ExposureAlternative",                                                                                       // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.exposureAlternative",                                                                // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.exposureAlternative",                                                                 // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 29. EffectEvidenceSynthesis.outcome
                    this.Outcome = new ElementDefinitionInfo                                                                                // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Outcome",                                                                                                   // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.outcome",                                                                            // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.outcome",                                                                             // MakerGen.cs:237
                        Min = 1,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:346
                            {                                                                                                               // MakerGen.cs:347
                                TargetProfile = new String[]                                                                                // MakerGen.cs:349
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                              // MakerGen.cs:349
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:350
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 30. EffectEvidenceSynthesis.sampleSize
                    this.SampleSize = new ElementDefinitionInfo                                                                             // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "SampleSize",                                                                                                // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.sampleSize",                                                                         // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.sampleSize",                                                                          // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = 1,                                                                                                            // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_SampleSize                                                                                             // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 34. EffectEvidenceSynthesis.resultsByExposure
                    this.ResultsByExposure = new ElementDefinitionInfo                                                                      // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "ResultsByExposure",                                                                                         // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.resultsByExposure",                                                                  // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.resultsByExposure",                                                                   // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_ResultsByExposure                                                                                      // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 39. EffectEvidenceSynthesis.effectEstimate
                    this.EffectEstimate = new ElementDefinitionInfo                                                                         // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "EffectEstimate",                                                                                            // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.effectEstimate",                                                                     // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.effectEstimate",                                                                      // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_EffectEstimate                                                                                         // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:231
                    // 50. EffectEvidenceSynthesis.certainty
                    this.Certainty = new ElementDefinitionInfo                                                                              // MakerGen.cs:233
                    {                                                                                                                       // MakerGen.cs:234
                        Name = "Certainty",                                                                                                 // MakerGen.cs:235
                        Path= "EffectEvidenceSynthesis.certainty",                                                                          // MakerGen.cs:236
                        Id = "EffectEvidenceSynthesis.certainty",                                                                           // MakerGen.cs:237
                        Min = 0,                                                                                                            // MakerGen.cs:238
                        Max = -1,                                                                                                           // MakerGen.cs:239
                        Types = new BaseType[]                                                                                              // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:241
                            new Type_Certainty                                                                                              // MakerGen.cs:259
                            {                                                                                                               // MakerGen.cs:260
                            }                                                                                                               // MakerGen.cs:261
                        }                                                                                                                   // MakerGen.cs:243
                    };                                                                                                                      // MakerGen.cs:244
                }                                                                                                                           // MakerGen.cs:245
            }                                                                                                                               // MakerGen.cs:395
                                                                                                                                            // MakerGen.cs:397
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:398
            {                                                                                                                               // MakerGen.cs:399
                base.Write(sDef);                                                                                                           // MakerGen.cs:400
                Url.Write(sDef);                                                                                                            // MakerGen.cs:220
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:220
                Version.Write(sDef);                                                                                                        // MakerGen.cs:220
                Name.Write(sDef);                                                                                                           // MakerGen.cs:220
                Title.Write(sDef);                                                                                                          // MakerGen.cs:220
                Status.Write(sDef);                                                                                                         // MakerGen.cs:220
                Date.Write(sDef);                                                                                                           // MakerGen.cs:220
                Publisher.Write(sDef);                                                                                                      // MakerGen.cs:220
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:220
                Description.Write(sDef);                                                                                                    // MakerGen.cs:220
                Note.Write(sDef);                                                                                                           // MakerGen.cs:220
                UseContext.Write(sDef);                                                                                                     // MakerGen.cs:220
                Jurisdiction.Write(sDef);                                                                                                   // MakerGen.cs:220
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
                SynthesisType.Write(sDef);                                                                                                  // MakerGen.cs:220
                StudyType.Write(sDef);                                                                                                      // MakerGen.cs:220
                Population.Write(sDef);                                                                                                     // MakerGen.cs:220
                Exposure.Write(sDef);                                                                                                       // MakerGen.cs:220
                ExposureAlternative.Write(sDef);                                                                                            // MakerGen.cs:220
                Outcome.Write(sDef);                                                                                                        // MakerGen.cs:220
                SampleSize.Write(sDef);                                                                                                     // MakerGen.cs:220
                ResultsByExposure.Write(sDef);                                                                                              // MakerGen.cs:220
                EffectEstimate.Write(sDef);                                                                                                 // MakerGen.cs:220
                Certainty.Write(sDef);                                                                                                      // MakerGen.cs:220
            }                                                                                                                               // MakerGen.cs:402
        }                                                                                                                                   // MakerGen.cs:404
        public EffectEvidenceSynthesis_Elements Elements                                                                                    // MakerGen.cs:406
        {                                                                                                                                   // MakerGen.cs:407
            get                                                                                                                             // MakerGen.cs:408
            {                                                                                                                               // MakerGen.cs:409
                if (this.elements == null)                                                                                                  // MakerGen.cs:410
                    this.elements = new EffectEvidenceSynthesis_Elements();                                                                 // MakerGen.cs:411
                return this.elements;                                                                                                       // MakerGen.cs:412
            }                                                                                                                               // MakerGen.cs:413
        }                                                                                                                                   // MakerGen.cs:414
        EffectEvidenceSynthesis_Elements elements;                                                                                          // MakerGen.cs:415
                                                                                                                                            // MakerGen.cs:417
        public EffectEvidenceSynthesis()                                                                                                    // MakerGen.cs:418
        {                                                                                                                                   // MakerGen.cs:419
            this.Name = "EffectEvidenceSynthesis";                                                                                          // MakerGen.cs:492
            this.Uri = "http://hl7.org/fhir/StructureDefinition/EffectEvidenceSynthesis";                                                   // MakerGen.cs:493
        }                                                                                                                                   // MakerGen.cs:421
                                                                                                                                            // MakerGen.cs:423
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:424
        {                                                                                                                                   // MakerGen.cs:425
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:426
            {                                                                                                                               // MakerGen.cs:427
                Path = "EffectEvidenceSynthesis",                                                                                           // MakerGen.cs:428
                ElementId = "EffectEvidenceSynthesis"                                                                                       // MakerGen.cs:429
            });                                                                                                                             // MakerGen.cs:430
            if (this.elements != null)                                                                                                      // MakerGen.cs:431
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:432
        }                                                                                                                                   // MakerGen.cs:433
    }                                                                                                                                       // MakerGen.cs:434
}                                                                                                                                           // MakerGen.cs:479
