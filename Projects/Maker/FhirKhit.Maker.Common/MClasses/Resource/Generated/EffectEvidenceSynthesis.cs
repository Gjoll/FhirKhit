using System;                                                                                                                               // MakerGen.cs:423
using System.Diagnostics;                                                                                                                   // MakerGen.cs:424
using System.IO;                                                                                                                            // MakerGen.cs:425
using System.Linq;                                                                                                                          // MakerGen.cs:426
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:427
                                                                                                                                            // MakerGen.cs:428
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:429
{                                                                                                                                           // MakerGen.cs:430
    #region Json                                                                                                                            // MakerGen.cs:431
    #if NEVER                                                                                                                               // MakerGen.cs:432
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
    #endregion                                                                                                                              // MakerGen.cs:435
    /// <summary>
    /// Fhir resource 'EffectEvidenceSynthesis'
    /// </summary>
    // 0. EffectEvidenceSynthesis
    public class EffectEvidenceSynthesis : FhirKhit.Maker.Common.Resource.ResourceBase                                                      // MakerGen.cs:384
    {                                                                                                                                       // MakerGen.cs:385
        // 30. EffectEvidenceSynthesis.sampleSize
        public class Type_SampleSize : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:384
        {                                                                                                                                   // MakerGen.cs:385
            // 31. EffectEvidenceSynthesis.sampleSize.description
            public MakerElementInstance Element_Description;                                                                                // MakerGen.cs:232
            // 32. EffectEvidenceSynthesis.sampleSize.numberOfStudies
            public MakerElementInstance Element_NumberOfStudies;                                                                            // MakerGen.cs:232
            // 33. EffectEvidenceSynthesis.sampleSize.numberOfParticipants
            public MakerElementInstance Element_NumberOfParticipants;                                                                       // MakerGen.cs:232
            public Type_SampleSize()                                                                                                        // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:243
                    // 31. EffectEvidenceSynthesis.sampleSize.description
                    this.Element_Description = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Description",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 32. EffectEvidenceSynthesis.sampleSize.numberOfStudies
                    this.Element_NumberOfStudies = new MakerElementInstance                                                                 // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_NumberOfStudies",                                                                                   // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 33. EffectEvidenceSynthesis.sampleSize.numberOfParticipants
                    this.Element_NumberOfParticipants = new MakerElementInstance                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_NumberOfParticipants",                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Integer                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:389
        // 34. EffectEvidenceSynthesis.resultsByExposure
        public class Type_ResultsByExposure : FhirKhit.Maker.Common.Complex.ComplexBase                                                     // MakerGen.cs:384
        {                                                                                                                                   // MakerGen.cs:385
            // 35. EffectEvidenceSynthesis.resultsByExposure.description
            public MakerElementInstance Element_Description;                                                                                // MakerGen.cs:232
            // 36. EffectEvidenceSynthesis.resultsByExposure.exposureState
            public MakerElementInstance Element_ExposureState;                                                                              // MakerGen.cs:232
            // 37. EffectEvidenceSynthesis.resultsByExposure.variantState
            public MakerElementInstance Element_VariantState;                                                                               // MakerGen.cs:232
            // 38. EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis
            public MakerElementInstance Element_RiskEvidenceSynthesis;                                                                      // MakerGen.cs:232
            public Type_ResultsByExposure()                                                                                                 // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:243
                    // 35. EffectEvidenceSynthesis.resultsByExposure.description
                    this.Element_Description = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Description",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 36. EffectEvidenceSynthesis.resultsByExposure.exposureState
                    this.Element_ExposureState = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_ExposureState",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 37. EffectEvidenceSynthesis.resultsByExposure.variantState
                    this.Element_VariantState = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_VariantState",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 38. EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis
                    this.Element_RiskEvidenceSynthesis = new MakerElementInstance                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_RiskEvidenceSynthesis",                                                                             // MakerGen.cs:247
                        Min = 1,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:320
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:389
        // 39. EffectEvidenceSynthesis.effectEstimate
        public class Type_EffectEstimate : FhirKhit.Maker.Common.Complex.ComplexBase                                                        // MakerGen.cs:384
        {                                                                                                                                   // MakerGen.cs:385
            // 45. EffectEvidenceSynthesis.effectEstimate.precisionEstimate
            public class Type_PrecisionEstimate : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                // 46. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type
                public MakerElementInstance Element_Type;                                                                                   // MakerGen.cs:232
                // 47. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level
                public MakerElementInstance Element_Level;                                                                                  // MakerGen.cs:232
                // 48. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from
                public MakerElementInstance Element_From;                                                                                   // MakerGen.cs:232
                // 49. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to
                public MakerElementInstance Element_To;                                                                                     // MakerGen.cs:232
                public Type_PrecisionEstimate()                                                                                             // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    {                                                                                                                       // MakerGen.cs:243
                        // 46. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type
                        this.Element_Type = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Type",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:297
                                {                                                                                                           // MakerGen.cs:298
                                }                                                                                                           // MakerGen.cs:299
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                    {                                                                                                                       // MakerGen.cs:243
                        // 47. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level
                        this.Element_Level = new MakerElementInstance                                                                       // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Level",                                                                                         // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Decimal                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                    {                                                                                                                       // MakerGen.cs:243
                        // 48. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from
                        this.Element_From = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_From",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Decimal                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                    {                                                                                                                       // MakerGen.cs:243
                        // 49. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to
                        this.Element_To = new MakerElementInstance                                                                          // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_To",                                                                                            // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Primitive.Decimal                                                                 // MakerGen.cs:287
                                {                                                                                                           // MakerGen.cs:288
                                }                                                                                                           // MakerGen.cs:289
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:389
            // 40. EffectEvidenceSynthesis.effectEstimate.description
            public MakerElementInstance Element_Description;                                                                                // MakerGen.cs:232
            // 41. EffectEvidenceSynthesis.effectEstimate.type
            public MakerElementInstance Element_Type;                                                                                       // MakerGen.cs:232
            // 42. EffectEvidenceSynthesis.effectEstimate.variantState
            public MakerElementInstance Element_VariantState;                                                                               // MakerGen.cs:232
            // 43. EffectEvidenceSynthesis.effectEstimate.value
            public MakerElementInstance Element_Value;                                                                                      // MakerGen.cs:232
            // 44. EffectEvidenceSynthesis.effectEstimate.unitOfMeasure
            public MakerElementInstance Element_UnitOfMeasure;                                                                              // MakerGen.cs:232
            public Type_EffectEstimate()                                                                                                    // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:243
                    // 40. EffectEvidenceSynthesis.effectEstimate.description
                    this.Element_Description = new MakerElementInstance                                                                     // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Description",                                                                                       // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 41. EffectEvidenceSynthesis.effectEstimate.type
                    this.Element_Type = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Type",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 42. EffectEvidenceSynthesis.effectEstimate.variantState
                    this.Element_VariantState = new MakerElementInstance                                                                    // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_VariantState",                                                                                      // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 43. EffectEvidenceSynthesis.effectEstimate.value
                    this.Element_Value = new MakerElementInstance                                                                           // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Value",                                                                                             // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Primitive.Decimal                                                                     // MakerGen.cs:287
                            {                                                                                                               // MakerGen.cs:288
                            }                                                                                                               // MakerGen.cs:289
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 44. EffectEvidenceSynthesis.effectEstimate.unitOfMeasure
                    this.Element_UnitOfMeasure = new MakerElementInstance                                                                   // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_UnitOfMeasure",                                                                                     // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = 1,                                                                                                            // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:389
        // 50. EffectEvidenceSynthesis.certainty
        public class Type_Certainty : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:384
        {                                                                                                                                   // MakerGen.cs:385
            // 53. EffectEvidenceSynthesis.certainty.certaintySubcomponent
            public class Type_CertaintySubcomponent : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:384
            {                                                                                                                               // MakerGen.cs:385
                // 54. EffectEvidenceSynthesis.certainty.certaintySubcomponent.type
                public MakerElementInstance Element_Type;                                                                                   // MakerGen.cs:232
                // 55. EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating
                public MakerElementInstance Element_Rating;                                                                                 // MakerGen.cs:232
                // 56. EffectEvidenceSynthesis.certainty.certaintySubcomponent.note
                public MakerElementInstance Element_Note;                                                                                   // MakerGen.cs:232
                public Type_CertaintySubcomponent()                                                                                         // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    {                                                                                                                       // MakerGen.cs:243
                        // 54. EffectEvidenceSynthesis.certainty.certaintySubcomponent.type
                        this.Element_Type = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Type",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = 1,                                                                                                        // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:297
                                {                                                                                                           // MakerGen.cs:298
                                }                                                                                                           // MakerGen.cs:299
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                    {                                                                                                                       // MakerGen.cs:243
                        // 55. EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating
                        this.Element_Rating = new MakerElementInstance                                                                      // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Rating",                                                                                        // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.CodeableConcept                                                           // MakerGen.cs:297
                                {                                                                                                           // MakerGen.cs:298
                                }                                                                                                           // MakerGen.cs:299
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                    {                                                                                                                       // MakerGen.cs:243
                        // 56. EffectEvidenceSynthesis.certainty.certaintySubcomponent.note
                        this.Element_Note = new MakerElementInstance                                                                        // MakerGen.cs:245
                        {                                                                                                                   // MakerGen.cs:246
                            Name = "Element_Note",                                                                                          // MakerGen.cs:247
                            Min = 0,                                                                                                        // MakerGen.cs:248
                            Max = -1,                                                                                                       // MakerGen.cs:249
                            Types = new MakerBaseType[]                                                                                     // MakerGen.cs:250
                            {                                                                                                               // MakerGen.cs:251
                                new FhirKhit.Maker.Common.Complex.Annotation                                                                // MakerGen.cs:343
                                {                                                                                                           // MakerGen.cs:344
                                }                                                                                                           // MakerGen.cs:345
                            }                                                                                                               // MakerGen.cs:253
                        };                                                                                                                  // MakerGen.cs:254
                    }                                                                                                                       // MakerGen.cs:366
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:389
            // 51. EffectEvidenceSynthesis.certainty.rating
            public MakerElementInstance Element_Rating;                                                                                     // MakerGen.cs:232
            // 52. EffectEvidenceSynthesis.certainty.note
            public MakerElementInstance Element_Note;                                                                                       // MakerGen.cs:232
            public Type_Certainty()                                                                                                         // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                {                                                                                                                           // MakerGen.cs:243
                    // 51. EffectEvidenceSynthesis.certainty.rating
                    this.Element_Rating = new MakerElementInstance                                                                          // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Rating",                                                                                            // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:297
                            {                                                                                                               // MakerGen.cs:298
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:243
                    // 52. EffectEvidenceSynthesis.certainty.note
                    this.Element_Note = new MakerElementInstance                                                                            // MakerGen.cs:245
                    {                                                                                                                       // MakerGen.cs:246
                        Name = "Element_Note",                                                                                              // MakerGen.cs:247
                        Min = 0,                                                                                                            // MakerGen.cs:248
                        Max = -1,                                                                                                           // MakerGen.cs:249
                        Types = new MakerBaseType[]                                                                                         // MakerGen.cs:250
                        {                                                                                                                   // MakerGen.cs:251
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:343
                            {                                                                                                               // MakerGen.cs:344
                            }                                                                                                               // MakerGen.cs:345
                        }                                                                                                                   // MakerGen.cs:253
                    };                                                                                                                      // MakerGen.cs:254
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:389
        // 1. EffectEvidenceSynthesis.url
        public MakerElementInstance Element_Url;                                                                                            // MakerGen.cs:232
        // 2. EffectEvidenceSynthesis.identifier
        public MakerElementInstance Element_Identifier;                                                                                     // MakerGen.cs:232
        // 3. EffectEvidenceSynthesis.version
        public MakerElementInstance Element_Version;                                                                                        // MakerGen.cs:232
        // 4. EffectEvidenceSynthesis.name
        public MakerElementInstance Element_Name;                                                                                           // MakerGen.cs:232
        // 5. EffectEvidenceSynthesis.title
        public MakerElementInstance Element_Title;                                                                                          // MakerGen.cs:232
        // 6. EffectEvidenceSynthesis.status
        public MakerElementInstance Element_Status;                                                                                         // MakerGen.cs:232
        // 7. EffectEvidenceSynthesis.date
        public MakerElementInstance Element_Date;                                                                                           // MakerGen.cs:232
        // 8. EffectEvidenceSynthesis.publisher
        public MakerElementInstance Element_Publisher;                                                                                      // MakerGen.cs:232
        // 9. EffectEvidenceSynthesis.contact
        public MakerElementInstance Element_Contact;                                                                                        // MakerGen.cs:232
        // 10. EffectEvidenceSynthesis.description
        public MakerElementInstance Element_Description;                                                                                    // MakerGen.cs:232
        // 11. EffectEvidenceSynthesis.note
        public MakerElementInstance Element_Note;                                                                                           // MakerGen.cs:232
        // 12. EffectEvidenceSynthesis.useContext
        public MakerElementInstance Element_UseContext;                                                                                     // MakerGen.cs:232
        // 13. EffectEvidenceSynthesis.jurisdiction
        public MakerElementInstance Element_Jurisdiction;                                                                                   // MakerGen.cs:232
        // 14. EffectEvidenceSynthesis.copyright
        public MakerElementInstance Element_Copyright;                                                                                      // MakerGen.cs:232
        // 15. EffectEvidenceSynthesis.approvalDate
        public MakerElementInstance Element_ApprovalDate;                                                                                   // MakerGen.cs:232
        // 16. EffectEvidenceSynthesis.lastReviewDate
        public MakerElementInstance Element_LastReviewDate;                                                                                 // MakerGen.cs:232
        // 17. EffectEvidenceSynthesis.effectivePeriod
        public MakerElementInstance Element_EffectivePeriod;                                                                                // MakerGen.cs:232
        // 18. EffectEvidenceSynthesis.topic
        public MakerElementInstance Element_Topic;                                                                                          // MakerGen.cs:232
        // 19. EffectEvidenceSynthesis.author
        public MakerElementInstance Element_Author;                                                                                         // MakerGen.cs:232
        // 20. EffectEvidenceSynthesis.editor
        public MakerElementInstance Element_Editor;                                                                                         // MakerGen.cs:232
        // 21. EffectEvidenceSynthesis.reviewer
        public MakerElementInstance Element_Reviewer;                                                                                       // MakerGen.cs:232
        // 22. EffectEvidenceSynthesis.endorser
        public MakerElementInstance Element_Endorser;                                                                                       // MakerGen.cs:232
        // 23. EffectEvidenceSynthesis.relatedArtifact
        public MakerElementInstance Element_RelatedArtifact;                                                                                // MakerGen.cs:232
        // 24. EffectEvidenceSynthesis.synthesisType
        public MakerElementInstance Element_SynthesisType;                                                                                  // MakerGen.cs:232
        // 25. EffectEvidenceSynthesis.studyType
        public MakerElementInstance Element_StudyType;                                                                                      // MakerGen.cs:232
        // 26. EffectEvidenceSynthesis.population
        public MakerElementInstance Element_Population;                                                                                     // MakerGen.cs:232
        // 27. EffectEvidenceSynthesis.exposure
        public MakerElementInstance Element_Exposure;                                                                                       // MakerGen.cs:232
        // 28. EffectEvidenceSynthesis.exposureAlternative
        public MakerElementInstance Element_ExposureAlternative;                                                                            // MakerGen.cs:232
        // 29. EffectEvidenceSynthesis.outcome
        public MakerElementInstance Element_Outcome;                                                                                        // MakerGen.cs:232
        public EffectEvidenceSynthesis()                                                                                                    // MakerGen.cs:393
        {                                                                                                                                   // MakerGen.cs:394
            {                                                                                                                               // MakerGen.cs:243
                // 1. EffectEvidenceSynthesis.url
                this.Element_Url = new MakerElementInstance                                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Uri                                                                             // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 2. EffectEvidenceSynthesis.identifier
                this.Element_Identifier = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Identifier                                                                        // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 3. EffectEvidenceSynthesis.version
                this.Element_Version = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Version",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 4. EffectEvidenceSynthesis.name
                this.Element_Name = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 5. EffectEvidenceSynthesis.title
                this.Element_Title = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Title",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 6. EffectEvidenceSynthesis.status
                this.Element_Status = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Status",                                                                                                // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Code                                                                            // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 7. EffectEvidenceSynthesis.date
                this.Element_Date = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.DateTime                                                                        // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 8. EffectEvidenceSynthesis.publisher
                this.Element_Publisher = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.String                                                                          // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 9. EffectEvidenceSynthesis.contact
                this.Element_Contact = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.ContactDetail                                                                     // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 10. EffectEvidenceSynthesis.description
                this.Element_Description = new MakerElementInstance                                                                         // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Description",                                                                                           // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown                                                                        // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 11. EffectEvidenceSynthesis.note
                this.Element_Note = new MakerElementInstance                                                                                // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Annotation                                                                        // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 12. EffectEvidenceSynthesis.useContext
                this.Element_UseContext = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.UsageContext                                                                      // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 13. EffectEvidenceSynthesis.jurisdiction
                this.Element_Jurisdiction = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 14. EffectEvidenceSynthesis.copyright
                this.Element_Copyright = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Copyright",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Markdown                                                                        // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 15. EffectEvidenceSynthesis.approvalDate
                this.Element_ApprovalDate = new MakerElementInstance                                                                        // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ApprovalDate",                                                                                          // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Date                                                                            // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 16. EffectEvidenceSynthesis.lastReviewDate
                this.Element_LastReviewDate = new MakerElementInstance                                                                      // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_LastReviewDate",                                                                                        // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Primitive.Date                                                                            // MakerGen.cs:287
                        {                                                                                                                   // MakerGen.cs:288
                        }                                                                                                                   // MakerGen.cs:289
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 17. EffectEvidenceSynthesis.effectivePeriod
                this.Element_EffectivePeriod = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_EffectivePeriod",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Period                                                                            // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 18. EffectEvidenceSynthesis.topic
                this.Element_Topic = new MakerElementInstance                                                                               // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Topic",                                                                                                 // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 19. EffectEvidenceSynthesis.author
                this.Element_Author = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Author",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.ContactDetail                                                                     // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 20. EffectEvidenceSynthesis.editor
                this.Element_Editor = new MakerElementInstance                                                                              // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Editor",                                                                                                // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.ContactDetail                                                                     // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 21. EffectEvidenceSynthesis.reviewer
                this.Element_Reviewer = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Reviewer",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.ContactDetail                                                                     // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 22. EffectEvidenceSynthesis.endorser
                this.Element_Endorser = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Endorser",                                                                                              // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.ContactDetail                                                                     // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 23. EffectEvidenceSynthesis.relatedArtifact
                this.Element_RelatedArtifact = new MakerElementInstance                                                                     // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_RelatedArtifact",                                                                                       // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = -1,                                                                                                               // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.RelatedArtifact                                                                   // MakerGen.cs:343
                        {                                                                                                                   // MakerGen.cs:344
                        }                                                                                                                   // MakerGen.cs:345
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 24. EffectEvidenceSynthesis.synthesisType
                this.Element_SynthesisType = new MakerElementInstance                                                                       // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_SynthesisType",                                                                                         // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 25. EffectEvidenceSynthesis.studyType
                this.Element_StudyType = new MakerElementInstance                                                                           // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_StudyType",                                                                                             // MakerGen.cs:247
                    Min = 0,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.CodeableConcept                                                                   // MakerGen.cs:297
                        {                                                                                                                   // MakerGen.cs:298
                        }                                                                                                                   // MakerGen.cs:299
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 26. EffectEvidenceSynthesis.population
                this.Element_Population = new MakerElementInstance                                                                          // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Population",                                                                                            // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 27. EffectEvidenceSynthesis.exposure
                this.Element_Exposure = new MakerElementInstance                                                                            // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Exposure",                                                                                              // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 28. EffectEvidenceSynthesis.exposureAlternative
                this.Element_ExposureAlternative = new MakerElementInstance                                                                 // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_ExposureAlternative",                                                                                   // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
            {                                                                                                                               // MakerGen.cs:243
                // 29. EffectEvidenceSynthesis.outcome
                this.Element_Outcome = new MakerElementInstance                                                                             // MakerGen.cs:245
                {                                                                                                                           // MakerGen.cs:246
                    Name = "Element_Outcome",                                                                                               // MakerGen.cs:247
                    Min = 1,                                                                                                                // MakerGen.cs:248
                    Max = 1,                                                                                                                // MakerGen.cs:249
                    Types = new MakerBaseType[]                                                                                             // MakerGen.cs:250
                    {                                                                                                                       // MakerGen.cs:251
                        new FhirKhit.Maker.Common.Complex.Reference                                                                         // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:320
                    }                                                                                                                       // MakerGen.cs:253
                };                                                                                                                          // MakerGen.cs:254
            }                                                                                                                               // MakerGen.cs:366
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:389
}                                                                                                                                           // MakerGen.cs:440
