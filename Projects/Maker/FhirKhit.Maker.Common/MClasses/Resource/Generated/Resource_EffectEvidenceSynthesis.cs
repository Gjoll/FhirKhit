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
    #endregion
    /// <summary>
    /// Fhir resource 'EffectEvidenceSynthesis'
    /// </summary>
    // 0. EffectEvidenceSynthesis
    public class Resource_EffectEvidenceSynthesis : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 30. EffectEvidenceSynthesis.sampleSize
        public class Type_SampleSize : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 31. EffectEvidenceSynthesis.sampleSize.description
            public ElementDefinitionInfo Element_Description;
            // 32. EffectEvidenceSynthesis.sampleSize.numberOfStudies
            public ElementDefinitionInfo Element_NumberOfStudies;
            // 33. EffectEvidenceSynthesis.sampleSize.numberOfParticipants
            public ElementDefinitionInfo Element_NumberOfParticipants;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "EffectEvidenceSynthesis.sampleSize",
                    ElementId = "EffectEvidenceSynthesis.sampleSize"
                });
                Element_Description.Write(sDef);
                Element_NumberOfStudies.Write(sDef);
                Element_NumberOfParticipants.Write(sDef);
            }
            
            public Type_SampleSize()
            {
                {
                    // 31. EffectEvidenceSynthesis.sampleSize.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "EffectEvidenceSynthesis.sampleSize.description",
                        Id = "EffectEvidenceSynthesis.sampleSize.description",
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
                    // 32. EffectEvidenceSynthesis.sampleSize.numberOfStudies
                    this.Element_NumberOfStudies = new ElementDefinitionInfo
                    {
                        Name = "Element_NumberOfStudies",
                        Path= "EffectEvidenceSynthesis.sampleSize.numberOfStudies",
                        Id = "EffectEvidenceSynthesis.sampleSize.numberOfStudies",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                            {
                            }
                        }
                    };
                }
                {
                    // 33. EffectEvidenceSynthesis.sampleSize.numberOfParticipants
                    this.Element_NumberOfParticipants = new ElementDefinitionInfo
                    {
                        Name = "Element_NumberOfParticipants",
                        Path= "EffectEvidenceSynthesis.sampleSize.numberOfParticipants",
                        Id = "EffectEvidenceSynthesis.sampleSize.numberOfParticipants",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                            {
                            }
                        }
                    };
                }
            }
        }
        // 34. EffectEvidenceSynthesis.resultsByExposure
        public class Type_ResultsByExposure : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 35. EffectEvidenceSynthesis.resultsByExposure.description
            public ElementDefinitionInfo Element_Description;
            // 36. EffectEvidenceSynthesis.resultsByExposure.exposureState
            public ElementDefinitionInfo Element_ExposureState;
            // 37. EffectEvidenceSynthesis.resultsByExposure.variantState
            public ElementDefinitionInfo Element_VariantState;
            // 38. EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis
            public ElementDefinitionInfo Element_RiskEvidenceSynthesis;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "EffectEvidenceSynthesis.resultsByExposure",
                    ElementId = "EffectEvidenceSynthesis.resultsByExposure"
                });
                Element_Description.Write(sDef);
                Element_ExposureState.Write(sDef);
                Element_VariantState.Write(sDef);
                Element_RiskEvidenceSynthesis.Write(sDef);
            }
            
            public Type_ResultsByExposure()
            {
                {
                    // 35. EffectEvidenceSynthesis.resultsByExposure.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "EffectEvidenceSynthesis.resultsByExposure.description",
                        Id = "EffectEvidenceSynthesis.resultsByExposure.description",
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
                    // 36. EffectEvidenceSynthesis.resultsByExposure.exposureState
                    this.Element_ExposureState = new ElementDefinitionInfo
                    {
                        Name = "Element_ExposureState",
                        Path= "EffectEvidenceSynthesis.resultsByExposure.exposureState",
                        Id = "EffectEvidenceSynthesis.resultsByExposure.exposureState",
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
                    // 37. EffectEvidenceSynthesis.resultsByExposure.variantState
                    this.Element_VariantState = new ElementDefinitionInfo
                    {
                        Name = "Element_VariantState",
                        Path= "EffectEvidenceSynthesis.resultsByExposure.variantState",
                        Id = "EffectEvidenceSynthesis.resultsByExposure.variantState",
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
                    // 38. EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis
                    this.Element_RiskEvidenceSynthesis = new ElementDefinitionInfo
                    {
                        Name = "Element_RiskEvidenceSynthesis",
                        Path= "EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis",
                        Id = "EffectEvidenceSynthesis.resultsByExposure.riskEvidenceSynthesis",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/RiskEvidenceSynthesis"
                                }
                            }
                        }
                    };
                }
            }
        }
        // 39. EffectEvidenceSynthesis.effectEstimate
        public class Type_EffectEstimate : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 45. EffectEvidenceSynthesis.effectEstimate.precisionEstimate
            public class Type_PrecisionEstimate : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 46. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type
                public ElementDefinitionInfo Element_Type;
                // 47. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level
                public ElementDefinitionInfo Element_Level;
                // 48. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from
                public ElementDefinitionInfo Element_From;
                // 49. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to
                public ElementDefinitionInfo Element_To;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate",
                        ElementId = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate"
                    });
                    Element_Type.Write(sDef);
                    Element_Level.Write(sDef);
                    Element_From.Write(sDef);
                    Element_To.Write(sDef);
                }
                
                public Type_PrecisionEstimate()
                {
                    {
                        // 46. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type",
                            Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.type",
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
                        // 47. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level
                        this.Element_Level = new ElementDefinitionInfo
                        {
                            Name = "Element_Level",
                            Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level",
                            Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.level",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                {
                                }
                            }
                        };
                    }
                    {
                        // 48. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from
                        this.Element_From = new ElementDefinitionInfo
                        {
                            Name = "Element_From",
                            Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from",
                            Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.from",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                {
                                }
                            }
                        };
                    }
                    {
                        // 49. EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to
                        this.Element_To = new ElementDefinitionInfo
                        {
                            Name = "Element_To",
                            Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to",
                            Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate.to",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 40. EffectEvidenceSynthesis.effectEstimate.description
            public ElementDefinitionInfo Element_Description;
            // 41. EffectEvidenceSynthesis.effectEstimate.type
            public ElementDefinitionInfo Element_Type;
            // 42. EffectEvidenceSynthesis.effectEstimate.variantState
            public ElementDefinitionInfo Element_VariantState;
            // 43. EffectEvidenceSynthesis.effectEstimate.value
            public ElementDefinitionInfo Element_Value;
            // 44. EffectEvidenceSynthesis.effectEstimate.unitOfMeasure
            public ElementDefinitionInfo Element_UnitOfMeasure;
            // 45. EffectEvidenceSynthesis.effectEstimate.precisionEstimate
            public ElementDefinitionInfo Element_PrecisionEstimate;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "EffectEvidenceSynthesis.effectEstimate",
                    ElementId = "EffectEvidenceSynthesis.effectEstimate"
                });
                Element_Description.Write(sDef);
                Element_Type.Write(sDef);
                Element_VariantState.Write(sDef);
                Element_Value.Write(sDef);
                Element_UnitOfMeasure.Write(sDef);
                Element_PrecisionEstimate.Write(sDef);
            }
            
            public Type_EffectEstimate()
            {
                {
                    // 40. EffectEvidenceSynthesis.effectEstimate.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "EffectEvidenceSynthesis.effectEstimate.description",
                        Id = "EffectEvidenceSynthesis.effectEstimate.description",
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
                    // 41. EffectEvidenceSynthesis.effectEstimate.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "EffectEvidenceSynthesis.effectEstimate.type",
                        Id = "EffectEvidenceSynthesis.effectEstimate.type",
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
                    // 42. EffectEvidenceSynthesis.effectEstimate.variantState
                    this.Element_VariantState = new ElementDefinitionInfo
                    {
                        Name = "Element_VariantState",
                        Path= "EffectEvidenceSynthesis.effectEstimate.variantState",
                        Id = "EffectEvidenceSynthesis.effectEstimate.variantState",
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
                    // 43. EffectEvidenceSynthesis.effectEstimate.value
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "EffectEvidenceSynthesis.effectEstimate.value",
                        Id = "EffectEvidenceSynthesis.effectEstimate.value",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                            {
                            }
                        }
                    };
                }
                {
                    // 44. EffectEvidenceSynthesis.effectEstimate.unitOfMeasure
                    this.Element_UnitOfMeasure = new ElementDefinitionInfo
                    {
                        Name = "Element_UnitOfMeasure",
                        Path= "EffectEvidenceSynthesis.effectEstimate.unitOfMeasure",
                        Id = "EffectEvidenceSynthesis.effectEstimate.unitOfMeasure",
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
                    // 45. EffectEvidenceSynthesis.effectEstimate.precisionEstimate
                    this.Element_PrecisionEstimate = new ElementDefinitionInfo
                    {
                        Name = "Element_PrecisionEstimate",
                        Path= "EffectEvidenceSynthesis.effectEstimate.precisionEstimate",
                        Id = "EffectEvidenceSynthesis.effectEstimate.precisionEstimate",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_PrecisionEstimate
                            {
                            }
                        }
                    };
                }
            }
        }
        // 50. EffectEvidenceSynthesis.certainty
        public class Type_Certainty : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 53. EffectEvidenceSynthesis.certainty.certaintySubcomponent
            public class Type_CertaintySubcomponent : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 54. EffectEvidenceSynthesis.certainty.certaintySubcomponent.type
                public ElementDefinitionInfo Element_Type;
                // 55. EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating
                public ElementDefinitionInfo Element_Rating;
                // 56. EffectEvidenceSynthesis.certainty.certaintySubcomponent.note
                public ElementDefinitionInfo Element_Note;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "EffectEvidenceSynthesis.certainty.certaintySubcomponent",
                        ElementId = "EffectEvidenceSynthesis.certainty.certaintySubcomponent"
                    });
                    Element_Type.Write(sDef);
                    Element_Rating.Write(sDef);
                    Element_Note.Write(sDef);
                }
                
                public Type_CertaintySubcomponent()
                {
                    {
                        // 54. EffectEvidenceSynthesis.certainty.certaintySubcomponent.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "EffectEvidenceSynthesis.certainty.certaintySubcomponent.type",
                            Id = "EffectEvidenceSynthesis.certainty.certaintySubcomponent.type",
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
                        // 55. EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating
                        this.Element_Rating = new ElementDefinitionInfo
                        {
                            Name = "Element_Rating",
                            Path= "EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating",
                            Id = "EffectEvidenceSynthesis.certainty.certaintySubcomponent.rating",
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
                        // 56. EffectEvidenceSynthesis.certainty.certaintySubcomponent.note
                        this.Element_Note = new ElementDefinitionInfo
                        {
                            Name = "Element_Note",
                            Path= "EffectEvidenceSynthesis.certainty.certaintySubcomponent.note",
                            Id = "EffectEvidenceSynthesis.certainty.certaintySubcomponent.note",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Annotation
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 51. EffectEvidenceSynthesis.certainty.rating
            public ElementDefinitionInfo Element_Rating;
            // 52. EffectEvidenceSynthesis.certainty.note
            public ElementDefinitionInfo Element_Note;
            // 53. EffectEvidenceSynthesis.certainty.certaintySubcomponent
            public ElementDefinitionInfo Element_CertaintySubcomponent;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "EffectEvidenceSynthesis.certainty",
                    ElementId = "EffectEvidenceSynthesis.certainty"
                });
                Element_Rating.Write(sDef);
                Element_Note.Write(sDef);
                Element_CertaintySubcomponent.Write(sDef);
            }
            
            public Type_Certainty()
            {
                {
                    // 51. EffectEvidenceSynthesis.certainty.rating
                    this.Element_Rating = new ElementDefinitionInfo
                    {
                        Name = "Element_Rating",
                        Path= "EffectEvidenceSynthesis.certainty.rating",
                        Id = "EffectEvidenceSynthesis.certainty.rating",
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
                    // 52. EffectEvidenceSynthesis.certainty.note
                    this.Element_Note = new ElementDefinitionInfo
                    {
                        Name = "Element_Note",
                        Path= "EffectEvidenceSynthesis.certainty.note",
                        Id = "EffectEvidenceSynthesis.certainty.note",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Annotation
                            {
                            }
                        }
                    };
                }
                {
                    // 53. EffectEvidenceSynthesis.certainty.certaintySubcomponent
                    this.Element_CertaintySubcomponent = new ElementDefinitionInfo
                    {
                        Name = "Element_CertaintySubcomponent",
                        Path= "EffectEvidenceSynthesis.certainty.certaintySubcomponent",
                        Id = "EffectEvidenceSynthesis.certainty.certaintySubcomponent",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_CertaintySubcomponent
                            {
                            }
                        }
                    };
                }
            }
        }
        // 1. EffectEvidenceSynthesis.url
        public ElementDefinitionInfo Element_Url;
        // 2. EffectEvidenceSynthesis.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. EffectEvidenceSynthesis.version
        public ElementDefinitionInfo Element_Version;
        // 4. EffectEvidenceSynthesis.name
        public ElementDefinitionInfo Element_Name;
        // 5. EffectEvidenceSynthesis.title
        public ElementDefinitionInfo Element_Title;
        // 6. EffectEvidenceSynthesis.status
        public ElementDefinitionInfo Element_Status;
        // 7. EffectEvidenceSynthesis.date
        public ElementDefinitionInfo Element_Date;
        // 8. EffectEvidenceSynthesis.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 9. EffectEvidenceSynthesis.contact
        public ElementDefinitionInfo Element_Contact;
        // 10. EffectEvidenceSynthesis.description
        public ElementDefinitionInfo Element_Description;
        // 11. EffectEvidenceSynthesis.note
        public ElementDefinitionInfo Element_Note;
        // 12. EffectEvidenceSynthesis.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 13. EffectEvidenceSynthesis.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 14. EffectEvidenceSynthesis.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 15. EffectEvidenceSynthesis.approvalDate
        public ElementDefinitionInfo Element_ApprovalDate;
        // 16. EffectEvidenceSynthesis.lastReviewDate
        public ElementDefinitionInfo Element_LastReviewDate;
        // 17. EffectEvidenceSynthesis.effectivePeriod
        public ElementDefinitionInfo Element_EffectivePeriod;
        // 18. EffectEvidenceSynthesis.topic
        public ElementDefinitionInfo Element_Topic;
        // 19. EffectEvidenceSynthesis.author
        public ElementDefinitionInfo Element_Author;
        // 20. EffectEvidenceSynthesis.editor
        public ElementDefinitionInfo Element_Editor;
        // 21. EffectEvidenceSynthesis.reviewer
        public ElementDefinitionInfo Element_Reviewer;
        // 22. EffectEvidenceSynthesis.endorser
        public ElementDefinitionInfo Element_Endorser;
        // 23. EffectEvidenceSynthesis.relatedArtifact
        public ElementDefinitionInfo Element_RelatedArtifact;
        // 24. EffectEvidenceSynthesis.synthesisType
        public ElementDefinitionInfo Element_SynthesisType;
        // 25. EffectEvidenceSynthesis.studyType
        public ElementDefinitionInfo Element_StudyType;
        // 26. EffectEvidenceSynthesis.population
        public ElementDefinitionInfo Element_Population;
        // 27. EffectEvidenceSynthesis.exposure
        public ElementDefinitionInfo Element_Exposure;
        // 28. EffectEvidenceSynthesis.exposureAlternative
        public ElementDefinitionInfo Element_ExposureAlternative;
        // 29. EffectEvidenceSynthesis.outcome
        public ElementDefinitionInfo Element_Outcome;
        // 30. EffectEvidenceSynthesis.sampleSize
        public ElementDefinitionInfo Element_SampleSize;
        // 34. EffectEvidenceSynthesis.resultsByExposure
        public ElementDefinitionInfo Element_ResultsByExposure;
        // 39. EffectEvidenceSynthesis.effectEstimate
        public ElementDefinitionInfo Element_EffectEstimate;
        // 50. EffectEvidenceSynthesis.certainty
        public ElementDefinitionInfo Element_Certainty;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "EffectEvidenceSynthesis",
                ElementId = "EffectEvidenceSynthesis"
            });
            Element_Url.Write(sDef);
            Element_Identifier.Write(sDef);
            Element_Version.Write(sDef);
            Element_Name.Write(sDef);
            Element_Title.Write(sDef);
            Element_Status.Write(sDef);
            Element_Date.Write(sDef);
            Element_Publisher.Write(sDef);
            Element_Contact.Write(sDef);
            Element_Description.Write(sDef);
            Element_Note.Write(sDef);
            Element_UseContext.Write(sDef);
            Element_Jurisdiction.Write(sDef);
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
            Element_SynthesisType.Write(sDef);
            Element_StudyType.Write(sDef);
            Element_Population.Write(sDef);
            Element_Exposure.Write(sDef);
            Element_ExposureAlternative.Write(sDef);
            Element_Outcome.Write(sDef);
            Element_SampleSize.Write(sDef);
            Element_ResultsByExposure.Write(sDef);
            Element_EffectEstimate.Write(sDef);
            Element_Certainty.Write(sDef);
        }
        
        public Resource_EffectEvidenceSynthesis()
        {
            {
                // 1. EffectEvidenceSynthesis.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "EffectEvidenceSynthesis.url",
                    Id = "EffectEvidenceSynthesis.url",
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
                // 2. EffectEvidenceSynthesis.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "EffectEvidenceSynthesis.identifier",
                    Id = "EffectEvidenceSynthesis.identifier",
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
                // 3. EffectEvidenceSynthesis.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "EffectEvidenceSynthesis.version",
                    Id = "EffectEvidenceSynthesis.version",
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
                // 4. EffectEvidenceSynthesis.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "EffectEvidenceSynthesis.name",
                    Id = "EffectEvidenceSynthesis.name",
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
                // 5. EffectEvidenceSynthesis.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "EffectEvidenceSynthesis.title",
                    Id = "EffectEvidenceSynthesis.title",
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
                // 6. EffectEvidenceSynthesis.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "EffectEvidenceSynthesis.status",
                    Id = "EffectEvidenceSynthesis.status",
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
                // 7. EffectEvidenceSynthesis.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "EffectEvidenceSynthesis.date",
                    Id = "EffectEvidenceSynthesis.date",
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
                // 8. EffectEvidenceSynthesis.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "EffectEvidenceSynthesis.publisher",
                    Id = "EffectEvidenceSynthesis.publisher",
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
                // 9. EffectEvidenceSynthesis.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "EffectEvidenceSynthesis.contact",
                    Id = "EffectEvidenceSynthesis.contact",
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
                // 10. EffectEvidenceSynthesis.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "EffectEvidenceSynthesis.description",
                    Id = "EffectEvidenceSynthesis.description",
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
                // 11. EffectEvidenceSynthesis.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "EffectEvidenceSynthesis.note",
                    Id = "EffectEvidenceSynthesis.note",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Annotation
                        {
                        }
                    }
                };
            }
            {
                // 12. EffectEvidenceSynthesis.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "EffectEvidenceSynthesis.useContext",
                    Id = "EffectEvidenceSynthesis.useContext",
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
                // 13. EffectEvidenceSynthesis.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "EffectEvidenceSynthesis.jurisdiction",
                    Id = "EffectEvidenceSynthesis.jurisdiction",
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
                // 14. EffectEvidenceSynthesis.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "EffectEvidenceSynthesis.copyright",
                    Id = "EffectEvidenceSynthesis.copyright",
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
                // 15. EffectEvidenceSynthesis.approvalDate
                this.Element_ApprovalDate = new ElementDefinitionInfo
                {
                    Name = "Element_ApprovalDate",
                    Path= "EffectEvidenceSynthesis.approvalDate",
                    Id = "EffectEvidenceSynthesis.approvalDate",
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
                // 16. EffectEvidenceSynthesis.lastReviewDate
                this.Element_LastReviewDate = new ElementDefinitionInfo
                {
                    Name = "Element_LastReviewDate",
                    Path= "EffectEvidenceSynthesis.lastReviewDate",
                    Id = "EffectEvidenceSynthesis.lastReviewDate",
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
                // 17. EffectEvidenceSynthesis.effectivePeriod
                this.Element_EffectivePeriod = new ElementDefinitionInfo
                {
                    Name = "Element_EffectivePeriod",
                    Path= "EffectEvidenceSynthesis.effectivePeriod",
                    Id = "EffectEvidenceSynthesis.effectivePeriod",
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
                // 18. EffectEvidenceSynthesis.topic
                this.Element_Topic = new ElementDefinitionInfo
                {
                    Name = "Element_Topic",
                    Path= "EffectEvidenceSynthesis.topic",
                    Id = "EffectEvidenceSynthesis.topic",
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
                // 19. EffectEvidenceSynthesis.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "EffectEvidenceSynthesis.author",
                    Id = "EffectEvidenceSynthesis.author",
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
                // 20. EffectEvidenceSynthesis.editor
                this.Element_Editor = new ElementDefinitionInfo
                {
                    Name = "Element_Editor",
                    Path= "EffectEvidenceSynthesis.editor",
                    Id = "EffectEvidenceSynthesis.editor",
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
                // 21. EffectEvidenceSynthesis.reviewer
                this.Element_Reviewer = new ElementDefinitionInfo
                {
                    Name = "Element_Reviewer",
                    Path= "EffectEvidenceSynthesis.reviewer",
                    Id = "EffectEvidenceSynthesis.reviewer",
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
                // 22. EffectEvidenceSynthesis.endorser
                this.Element_Endorser = new ElementDefinitionInfo
                {
                    Name = "Element_Endorser",
                    Path= "EffectEvidenceSynthesis.endorser",
                    Id = "EffectEvidenceSynthesis.endorser",
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
                // 23. EffectEvidenceSynthesis.relatedArtifact
                this.Element_RelatedArtifact = new ElementDefinitionInfo
                {
                    Name = "Element_RelatedArtifact",
                    Path= "EffectEvidenceSynthesis.relatedArtifact",
                    Id = "EffectEvidenceSynthesis.relatedArtifact",
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
                // 24. EffectEvidenceSynthesis.synthesisType
                this.Element_SynthesisType = new ElementDefinitionInfo
                {
                    Name = "Element_SynthesisType",
                    Path= "EffectEvidenceSynthesis.synthesisType",
                    Id = "EffectEvidenceSynthesis.synthesisType",
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
                // 25. EffectEvidenceSynthesis.studyType
                this.Element_StudyType = new ElementDefinitionInfo
                {
                    Name = "Element_StudyType",
                    Path= "EffectEvidenceSynthesis.studyType",
                    Id = "EffectEvidenceSynthesis.studyType",
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
                // 26. EffectEvidenceSynthesis.population
                this.Element_Population = new ElementDefinitionInfo
                {
                    Name = "Element_Population",
                    Path= "EffectEvidenceSynthesis.population",
                    Id = "EffectEvidenceSynthesis.population",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"
                            }
                        }
                    }
                };
            }
            {
                // 27. EffectEvidenceSynthesis.exposure
                this.Element_Exposure = new ElementDefinitionInfo
                {
                    Name = "Element_Exposure",
                    Path= "EffectEvidenceSynthesis.exposure",
                    Id = "EffectEvidenceSynthesis.exposure",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"
                            }
                        }
                    }
                };
            }
            {
                // 28. EffectEvidenceSynthesis.exposureAlternative
                this.Element_ExposureAlternative = new ElementDefinitionInfo
                {
                    Name = "Element_ExposureAlternative",
                    Path= "EffectEvidenceSynthesis.exposureAlternative",
                    Id = "EffectEvidenceSynthesis.exposureAlternative",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"
                            }
                        }
                    }
                };
            }
            {
                // 29. EffectEvidenceSynthesis.outcome
                this.Element_Outcome = new ElementDefinitionInfo
                {
                    Name = "Element_Outcome",
                    Path= "EffectEvidenceSynthesis.outcome",
                    Id = "EffectEvidenceSynthesis.outcome",
                    Min = 1,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"
                            }
                        }
                    }
                };
            }
            {
                // 30. EffectEvidenceSynthesis.sampleSize
                this.Element_SampleSize = new ElementDefinitionInfo
                {
                    Name = "Element_SampleSize",
                    Path= "EffectEvidenceSynthesis.sampleSize",
                    Id = "EffectEvidenceSynthesis.sampleSize",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_SampleSize
                        {
                        }
                    }
                };
            }
            {
                // 34. EffectEvidenceSynthesis.resultsByExposure
                this.Element_ResultsByExposure = new ElementDefinitionInfo
                {
                    Name = "Element_ResultsByExposure",
                    Path= "EffectEvidenceSynthesis.resultsByExposure",
                    Id = "EffectEvidenceSynthesis.resultsByExposure",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_ResultsByExposure
                        {
                        }
                    }
                };
            }
            {
                // 39. EffectEvidenceSynthesis.effectEstimate
                this.Element_EffectEstimate = new ElementDefinitionInfo
                {
                    Name = "Element_EffectEstimate",
                    Path= "EffectEvidenceSynthesis.effectEstimate",
                    Id = "EffectEvidenceSynthesis.effectEstimate",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_EffectEstimate
                        {
                        }
                    }
                };
            }
            {
                // 50. EffectEvidenceSynthesis.certainty
                this.Element_Certainty = new ElementDefinitionInfo
                {
                    Name = "Element_Certainty",
                    Path= "EffectEvidenceSynthesis.certainty",
                    Id = "EffectEvidenceSynthesis.certainty",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Certainty
                        {
                        }
                    }
                };
            }
            this.Name = "EffectEvidenceSynthesis";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/EffectEvidenceSynthesis";
        }
    }
}
