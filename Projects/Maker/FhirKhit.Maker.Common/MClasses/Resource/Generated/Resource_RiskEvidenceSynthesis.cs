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
      "id": "RiskEvidenceSynthesis",
      "url": "http://hl7.org/fhir/StructureDefinition/RiskEvidenceSynthesis",
      "version": "4.0.0",
      "name": "RiskEvidenceSynthesis",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Decision Support)",
      "description": "The RiskEvidenceSynthesis resource describes the likelihood of an outcome in a population plus exposure state where the risk estimate is derived from a combination of research studies.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "RiskEvidenceSynthesis",
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
            "id": "RiskEvidenceSynthesis",
            "path": "RiskEvidenceSynthesis",
            "short": "A quantified estimate of risk based on a body of evidence",
            "definition": "The RiskEvidenceSynthesis resource describes the likelihood of an outcome in a population plus exposure state where the risk estimate is derived from a combination of research studies.",
            "min": 0,
            "max": "*"
          },
          {
            "id": "RiskEvidenceSynthesis.url",
            "path": "RiskEvidenceSynthesis.url",
            "short": "Canonical identifier for this risk evidence synthesis, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this risk evidence synthesis when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this risk evidence synthesis is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the risk evidence synthesis is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the risk evidence synthesis to be referenced by a single globally unique identifier.",
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
            "id": "RiskEvidenceSynthesis.identifier",
            "path": "RiskEvidenceSynthesis.identifier",
            "short": "Additional identifier for the risk evidence synthesis",
            "definition": "A formal identifier that is used to identify this risk evidence synthesis when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this risk evidence synthesis outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "RiskEvidenceSynthesis.version",
            "path": "RiskEvidenceSynthesis.version",
            "short": "Business version of the risk evidence synthesis",
            "definition": "The identifier that is used to identify this version of the risk evidence synthesis when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the risk evidence synthesis author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different risk evidence synthesis instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the risk evidence synthesis with the format [url]|[version].",
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
            "id": "RiskEvidenceSynthesis.name",
            "path": "RiskEvidenceSynthesis.name",
            "short": "Name for this risk evidence synthesis (computer friendly)",
            "definition": "A natural language name identifying the risk evidence synthesis. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "RiskEvidenceSynthesis.title",
            "path": "RiskEvidenceSynthesis.title",
            "short": "Name for this risk evidence synthesis (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the risk evidence synthesis.",
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
            "id": "RiskEvidenceSynthesis.status",
            "path": "RiskEvidenceSynthesis.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this risk evidence synthesis. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of risk evidence synthesiss that are appropriate for use versus not.",
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
            "id": "RiskEvidenceSynthesis.date",
            "path": "RiskEvidenceSynthesis.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the risk evidence synthesis was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the risk evidence synthesis changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the risk evidence synthesis. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "RiskEvidenceSynthesis.publisher",
            "path": "RiskEvidenceSynthesis.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the risk evidence synthesis.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the risk evidence synthesis is the organization or individual primarily responsible for the maintenance and upkeep of the risk evidence synthesis. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the risk evidence synthesis. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the risk evidence synthesis.  May also allow for contact.",
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
            "id": "RiskEvidenceSynthesis.contact",
            "path": "RiskEvidenceSynthesis.contact",
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
            "id": "RiskEvidenceSynthesis.description",
            "path": "RiskEvidenceSynthesis.description",
            "short": "Natural language description of the risk evidence synthesis",
            "definition": "A free text natural language description of the risk evidence synthesis from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the risk evidence synthesis was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the risk evidence synthesis as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the risk evidence synthesis is presumed to be the predominant language in the place the risk evidence synthesis was created).",
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
            "id": "RiskEvidenceSynthesis.note",
            "path": "RiskEvidenceSynthesis.note",
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
            "id": "RiskEvidenceSynthesis.useContext",
            "path": "RiskEvidenceSynthesis.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate risk evidence synthesis instances.",
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
            "id": "RiskEvidenceSynthesis.jurisdiction",
            "path": "RiskEvidenceSynthesis.jurisdiction",
            "short": "Intended jurisdiction for risk evidence synthesis (if applicable)",
            "definition": "A legal or geographic region in which the risk evidence synthesis is intended to be used.",
            "comment": "It may be possible for the risk evidence synthesis to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "RiskEvidenceSynthesis.copyright",
            "path": "RiskEvidenceSynthesis.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the risk evidence synthesis and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the risk evidence synthesis.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the risk evidence synthesis and/or its content.",
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
            "id": "RiskEvidenceSynthesis.approvalDate",
            "path": "RiskEvidenceSynthesis.approvalDate",
            "short": "When the risk evidence synthesis was approved by publisher",
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
            "id": "RiskEvidenceSynthesis.lastReviewDate",
            "path": "RiskEvidenceSynthesis.lastReviewDate",
            "short": "When the risk evidence synthesis was last reviewed",
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
            "id": "RiskEvidenceSynthesis.effectivePeriod",
            "path": "RiskEvidenceSynthesis.effectivePeriod",
            "short": "When the risk evidence synthesis is expected to be used",
            "definition": "The period during which the risk evidence synthesis content was or is planned to be in active use.",
            "comment": "The effective period for a risk evidence synthesis  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.",
            "requirements": "Allows establishing a transition before a resource comes into effect and also allows for a sunsetting  process when new versions of the risk evidence synthesis are or are expected to be used instead.",
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
            "id": "RiskEvidenceSynthesis.topic",
            "path": "RiskEvidenceSynthesis.topic",
            "short": "The category of the EffectEvidenceSynthesis, such as Education, Treatment, Assessment, etc.",
            "definition": "Descriptive topics related to the content of the RiskEvidenceSynthesis. Topics provide a high-level categorization grouping types of EffectEvidenceSynthesiss that can be useful for filtering and searching.",
            "requirements": "Repositories must be able to determine how to categorize the RiskEvidenceSynthesis so that it can be found by topical searches.",
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
            "id": "RiskEvidenceSynthesis.author",
            "path": "RiskEvidenceSynthesis.author",
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
            "id": "RiskEvidenceSynthesis.editor",
            "path": "RiskEvidenceSynthesis.editor",
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
            "id": "RiskEvidenceSynthesis.reviewer",
            "path": "RiskEvidenceSynthesis.reviewer",
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
            "id": "RiskEvidenceSynthesis.endorser",
            "path": "RiskEvidenceSynthesis.endorser",
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
            "id": "RiskEvidenceSynthesis.relatedArtifact",
            "path": "RiskEvidenceSynthesis.relatedArtifact",
            "short": "Additional documentation, citations, etc.",
            "definition": "Related artifacts such as additional documentation, justification, or bibliographic references.",
            "comment": "Each related artifact is either an attachment, or a reference to another resource, but not both.",
            "requirements": "RiskEvidenceSynthesiss must be able to provide enough information for consumers of the content (and/or interventions or results produced by the content) to be able to determine and understand the justification for and evidence in support of the content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "RelatedArtifact"
              }
            ]
          },
          {
            "id": "RiskEvidenceSynthesis.synthesisType",
            "path": "RiskEvidenceSynthesis.synthesisType",
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
            "id": "RiskEvidenceSynthesis.studyType",
            "path": "RiskEvidenceSynthesis.studyType",
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
            "id": "RiskEvidenceSynthesis.population",
            "path": "RiskEvidenceSynthesis.population",
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
            "id": "RiskEvidenceSynthesis.exposure",
            "path": "RiskEvidenceSynthesis.exposure",
            "short": "What exposure?",
            "definition": "A reference to a EvidenceVariable resource that defines the exposure for the research.",
            "min": 0,
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
            "id": "RiskEvidenceSynthesis.outcome",
            "path": "RiskEvidenceSynthesis.outcome",
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
            "id": "RiskEvidenceSynthesis.sampleSize",
            "path": "RiskEvidenceSynthesis.sampleSize",
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
            "id": "RiskEvidenceSynthesis.sampleSize.description",
            "path": "RiskEvidenceSynthesis.sampleSize.description",
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
            "id": "RiskEvidenceSynthesis.sampleSize.numberOfStudies",
            "path": "RiskEvidenceSynthesis.sampleSize.numberOfStudies",
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
            "id": "RiskEvidenceSynthesis.sampleSize.numberOfParticipants",
            "path": "RiskEvidenceSynthesis.sampleSize.numberOfParticipants",
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
            "id": "RiskEvidenceSynthesis.riskEstimate",
            "path": "RiskEvidenceSynthesis.riskEstimate",
            "short": "What was the estimated risk",
            "definition": "The estimated risk of the outcome.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RiskEvidenceSynthesis.riskEstimate.description",
            "path": "RiskEvidenceSynthesis.riskEstimate.description",
            "short": "Description of risk estimate",
            "definition": "Human-readable summary of risk estimate.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "RiskEvidenceSynthesis.riskEstimate.type",
            "path": "RiskEvidenceSynthesis.riskEstimate.type",
            "short": "Type of risk estimate",
            "definition": "Examples include proportion and mean.",
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
                  "valueString": "RiskEstimateType"
                }
              ],
              "strength": "extensible",
              "description": "Whether the risk estimate is dichotomous, continuous or qualitative and the specific type of risk estimate (eg proportion or median).",
              "valueSet": "http://hl7.org/fhir/ValueSet/risk-estimate-type"
            }
          },
          {
            "id": "RiskEvidenceSynthesis.riskEstimate.value",
            "path": "RiskEvidenceSynthesis.riskEstimate.value",
            "short": "Point estimate",
            "definition": "The point estimate of the risk estimate.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "decimal"
              }
            ]
          },
          {
            "id": "RiskEvidenceSynthesis.riskEstimate.unitOfMeasure",
            "path": "RiskEvidenceSynthesis.riskEstimate.unitOfMeasure",
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
            "id": "RiskEvidenceSynthesis.riskEstimate.denominatorCount",
            "path": "RiskEvidenceSynthesis.riskEstimate.denominatorCount",
            "short": "Sample size for group measured",
            "definition": "The sample size for the group that was measured for this risk estimate.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "RiskEvidenceSynthesis.riskEstimate.numeratorCount",
            "path": "RiskEvidenceSynthesis.riskEstimate.numeratorCount",
            "short": "Number with the outcome",
            "definition": "The number of group members with the outcome of interest.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ]
          },
          {
            "id": "RiskEvidenceSynthesis.riskEstimate.precisionEstimate",
            "path": "RiskEvidenceSynthesis.riskEstimate.precisionEstimate",
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
            "id": "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.type",
            "path": "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.type",
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
            "id": "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.level",
            "path": "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.level",
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
            "id": "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.from",
            "path": "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.from",
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
            "id": "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.to",
            "path": "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.to",
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
            "id": "RiskEvidenceSynthesis.certainty",
            "path": "RiskEvidenceSynthesis.certainty",
            "short": "How certain is the risk",
            "definition": "A description of the certainty of the risk estimate.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "RiskEvidenceSynthesis.certainty.rating",
            "path": "RiskEvidenceSynthesis.certainty.rating",
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
            "id": "RiskEvidenceSynthesis.certainty.note",
            "path": "RiskEvidenceSynthesis.certainty.note",
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
            "id": "RiskEvidenceSynthesis.certainty.certaintySubcomponent",
            "path": "RiskEvidenceSynthesis.certainty.certaintySubcomponent",
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
            "id": "RiskEvidenceSynthesis.certainty.certaintySubcomponent.type",
            "path": "RiskEvidenceSynthesis.certainty.certaintySubcomponent.type",
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
            "id": "RiskEvidenceSynthesis.certainty.certaintySubcomponent.rating",
            "path": "RiskEvidenceSynthesis.certainty.certaintySubcomponent.rating",
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
            "id": "RiskEvidenceSynthesis.certainty.certaintySubcomponent.note",
            "path": "RiskEvidenceSynthesis.certainty.certaintySubcomponent.note",
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
    /// Fhir resource 'RiskEvidenceSynthesis'
    /// </summary>
    // 0. RiskEvidenceSynthesis
    public partial class Resource_RiskEvidenceSynthesis : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 29. RiskEvidenceSynthesis.sampleSize
        public partial class Type_SampleSize : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 30. RiskEvidenceSynthesis.sampleSize.description
            public ElementDefinitionInfo Element_Description;
            // 31. RiskEvidenceSynthesis.sampleSize.numberOfStudies
            public ElementDefinitionInfo Element_NumberOfStudies;
            // 32. RiskEvidenceSynthesis.sampleSize.numberOfParticipants
            public ElementDefinitionInfo Element_NumberOfParticipants;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "RiskEvidenceSynthesis.sampleSize",
                    ElementId = "RiskEvidenceSynthesis.sampleSize"
                });
                Element_Description.Write(sDef);
                Element_NumberOfStudies.Write(sDef);
                Element_NumberOfParticipants.Write(sDef);
            }
            
            public Type_SampleSize()
            {
                {
                    // 30. RiskEvidenceSynthesis.sampleSize.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "RiskEvidenceSynthesis.sampleSize.description",
                        Id = "RiskEvidenceSynthesis.sampleSize.description",
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
                    // 31. RiskEvidenceSynthesis.sampleSize.numberOfStudies
                    this.Element_NumberOfStudies = new ElementDefinitionInfo
                    {
                        Name = "Element_NumberOfStudies",
                        Path= "RiskEvidenceSynthesis.sampleSize.numberOfStudies",
                        Id = "RiskEvidenceSynthesis.sampleSize.numberOfStudies",
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
                    // 32. RiskEvidenceSynthesis.sampleSize.numberOfParticipants
                    this.Element_NumberOfParticipants = new ElementDefinitionInfo
                    {
                        Name = "Element_NumberOfParticipants",
                        Path= "RiskEvidenceSynthesis.sampleSize.numberOfParticipants",
                        Id = "RiskEvidenceSynthesis.sampleSize.numberOfParticipants",
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
        // 33. RiskEvidenceSynthesis.riskEstimate
        public partial class Type_RiskEstimate : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 40. RiskEvidenceSynthesis.riskEstimate.precisionEstimate
            public partial class Type_PrecisionEstimate : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 41. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.type
                public ElementDefinitionInfo Element_Type;
                // 42. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.level
                public ElementDefinitionInfo Element_Level;
                // 43. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.from
                public ElementDefinitionInfo Element_From;
                // 44. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.to
                public ElementDefinitionInfo Element_To;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate",
                        ElementId = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate"
                    });
                    Element_Type.Write(sDef);
                    Element_Level.Write(sDef);
                    Element_From.Write(sDef);
                    Element_To.Write(sDef);
                }
                
                public Type_PrecisionEstimate()
                {
                    {
                        // 41. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.type",
                            Id = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.type",
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
                        // 42. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.level
                        this.Element_Level = new ElementDefinitionInfo
                        {
                            Name = "Element_Level",
                            Path= "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.level",
                            Id = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.level",
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
                        // 43. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.from
                        this.Element_From = new ElementDefinitionInfo
                        {
                            Name = "Element_From",
                            Path= "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.from",
                            Id = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.from",
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
                        // 44. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.to
                        this.Element_To = new ElementDefinitionInfo
                        {
                            Name = "Element_To",
                            Path= "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.to",
                            Id = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.to",
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
            // 34. RiskEvidenceSynthesis.riskEstimate.description
            public ElementDefinitionInfo Element_Description;
            // 35. RiskEvidenceSynthesis.riskEstimate.type
            public ElementDefinitionInfo Element_Type;
            // 36. RiskEvidenceSynthesis.riskEstimate.value
            public ElementDefinitionInfo Element_Value;
            // 37. RiskEvidenceSynthesis.riskEstimate.unitOfMeasure
            public ElementDefinitionInfo Element_UnitOfMeasure;
            // 38. RiskEvidenceSynthesis.riskEstimate.denominatorCount
            public ElementDefinitionInfo Element_DenominatorCount;
            // 39. RiskEvidenceSynthesis.riskEstimate.numeratorCount
            public ElementDefinitionInfo Element_NumeratorCount;
            // 40. RiskEvidenceSynthesis.riskEstimate.precisionEstimate
            public ElementDefinitionInfo Element_PrecisionEstimate;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "RiskEvidenceSynthesis.riskEstimate",
                    ElementId = "RiskEvidenceSynthesis.riskEstimate"
                });
                Element_Description.Write(sDef);
                Element_Type.Write(sDef);
                Element_Value.Write(sDef);
                Element_UnitOfMeasure.Write(sDef);
                Element_DenominatorCount.Write(sDef);
                Element_NumeratorCount.Write(sDef);
                Element_PrecisionEstimate.Write(sDef);
            }
            
            public Type_RiskEstimate()
            {
                {
                    // 34. RiskEvidenceSynthesis.riskEstimate.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "RiskEvidenceSynthesis.riskEstimate.description",
                        Id = "RiskEvidenceSynthesis.riskEstimate.description",
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
                    // 35. RiskEvidenceSynthesis.riskEstimate.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "RiskEvidenceSynthesis.riskEstimate.type",
                        Id = "RiskEvidenceSynthesis.riskEstimate.type",
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
                    // 36. RiskEvidenceSynthesis.riskEstimate.value
                    this.Element_Value = new ElementDefinitionInfo
                    {
                        Name = "Element_Value",
                        Path= "RiskEvidenceSynthesis.riskEstimate.value",
                        Id = "RiskEvidenceSynthesis.riskEstimate.value",
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
                    // 37. RiskEvidenceSynthesis.riskEstimate.unitOfMeasure
                    this.Element_UnitOfMeasure = new ElementDefinitionInfo
                    {
                        Name = "Element_UnitOfMeasure",
                        Path= "RiskEvidenceSynthesis.riskEstimate.unitOfMeasure",
                        Id = "RiskEvidenceSynthesis.riskEstimate.unitOfMeasure",
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
                    // 38. RiskEvidenceSynthesis.riskEstimate.denominatorCount
                    this.Element_DenominatorCount = new ElementDefinitionInfo
                    {
                        Name = "Element_DenominatorCount",
                        Path= "RiskEvidenceSynthesis.riskEstimate.denominatorCount",
                        Id = "RiskEvidenceSynthesis.riskEstimate.denominatorCount",
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
                    // 39. RiskEvidenceSynthesis.riskEstimate.numeratorCount
                    this.Element_NumeratorCount = new ElementDefinitionInfo
                    {
                        Name = "Element_NumeratorCount",
                        Path= "RiskEvidenceSynthesis.riskEstimate.numeratorCount",
                        Id = "RiskEvidenceSynthesis.riskEstimate.numeratorCount",
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
                    // 40. RiskEvidenceSynthesis.riskEstimate.precisionEstimate
                    this.Element_PrecisionEstimate = new ElementDefinitionInfo
                    {
                        Name = "Element_PrecisionEstimate",
                        Path= "RiskEvidenceSynthesis.riskEstimate.precisionEstimate",
                        Id = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate",
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
        // 45. RiskEvidenceSynthesis.certainty
        public partial class Type_Certainty : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 48. RiskEvidenceSynthesis.certainty.certaintySubcomponent
            public partial class Type_CertaintySubcomponent : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 49. RiskEvidenceSynthesis.certainty.certaintySubcomponent.type
                public ElementDefinitionInfo Element_Type;
                // 50. RiskEvidenceSynthesis.certainty.certaintySubcomponent.rating
                public ElementDefinitionInfo Element_Rating;
                // 51. RiskEvidenceSynthesis.certainty.certaintySubcomponent.note
                public ElementDefinitionInfo Element_Note;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "RiskEvidenceSynthesis.certainty.certaintySubcomponent",
                        ElementId = "RiskEvidenceSynthesis.certainty.certaintySubcomponent"
                    });
                    Element_Type.Write(sDef);
                    Element_Rating.Write(sDef);
                    Element_Note.Write(sDef);
                }
                
                public Type_CertaintySubcomponent()
                {
                    {
                        // 49. RiskEvidenceSynthesis.certainty.certaintySubcomponent.type
                        this.Element_Type = new ElementDefinitionInfo
                        {
                            Name = "Element_Type",
                            Path= "RiskEvidenceSynthesis.certainty.certaintySubcomponent.type",
                            Id = "RiskEvidenceSynthesis.certainty.certaintySubcomponent.type",
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
                        // 50. RiskEvidenceSynthesis.certainty.certaintySubcomponent.rating
                        this.Element_Rating = new ElementDefinitionInfo
                        {
                            Name = "Element_Rating",
                            Path= "RiskEvidenceSynthesis.certainty.certaintySubcomponent.rating",
                            Id = "RiskEvidenceSynthesis.certainty.certaintySubcomponent.rating",
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
                        // 51. RiskEvidenceSynthesis.certainty.certaintySubcomponent.note
                        this.Element_Note = new ElementDefinitionInfo
                        {
                            Name = "Element_Note",
                            Path= "RiskEvidenceSynthesis.certainty.certaintySubcomponent.note",
                            Id = "RiskEvidenceSynthesis.certainty.certaintySubcomponent.note",
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
            // 46. RiskEvidenceSynthesis.certainty.rating
            public ElementDefinitionInfo Element_Rating;
            // 47. RiskEvidenceSynthesis.certainty.note
            public ElementDefinitionInfo Element_Note;
            // 48. RiskEvidenceSynthesis.certainty.certaintySubcomponent
            public ElementDefinitionInfo Element_CertaintySubcomponent;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "RiskEvidenceSynthesis.certainty",
                    ElementId = "RiskEvidenceSynthesis.certainty"
                });
                Element_Rating.Write(sDef);
                Element_Note.Write(sDef);
                Element_CertaintySubcomponent.Write(sDef);
            }
            
            public Type_Certainty()
            {
                {
                    // 46. RiskEvidenceSynthesis.certainty.rating
                    this.Element_Rating = new ElementDefinitionInfo
                    {
                        Name = "Element_Rating",
                        Path= "RiskEvidenceSynthesis.certainty.rating",
                        Id = "RiskEvidenceSynthesis.certainty.rating",
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
                    // 47. RiskEvidenceSynthesis.certainty.note
                    this.Element_Note = new ElementDefinitionInfo
                    {
                        Name = "Element_Note",
                        Path= "RiskEvidenceSynthesis.certainty.note",
                        Id = "RiskEvidenceSynthesis.certainty.note",
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
                    // 48. RiskEvidenceSynthesis.certainty.certaintySubcomponent
                    this.Element_CertaintySubcomponent = new ElementDefinitionInfo
                    {
                        Name = "Element_CertaintySubcomponent",
                        Path= "RiskEvidenceSynthesis.certainty.certaintySubcomponent",
                        Id = "RiskEvidenceSynthesis.certainty.certaintySubcomponent",
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
        // 1. RiskEvidenceSynthesis.url
        public ElementDefinitionInfo Element_Url;
        // 2. RiskEvidenceSynthesis.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. RiskEvidenceSynthesis.version
        public ElementDefinitionInfo Element_Version;
        // 4. RiskEvidenceSynthesis.name
        public ElementDefinitionInfo Element_Name;
        // 5. RiskEvidenceSynthesis.title
        public ElementDefinitionInfo Element_Title;
        // 6. RiskEvidenceSynthesis.status
        public ElementDefinitionInfo Element_Status;
        // 7. RiskEvidenceSynthesis.date
        public ElementDefinitionInfo Element_Date;
        // 8. RiskEvidenceSynthesis.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 9. RiskEvidenceSynthesis.contact
        public ElementDefinitionInfo Element_Contact;
        // 10. RiskEvidenceSynthesis.description
        public ElementDefinitionInfo Element_Description;
        // 11. RiskEvidenceSynthesis.note
        public ElementDefinitionInfo Element_Note;
        // 12. RiskEvidenceSynthesis.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 13. RiskEvidenceSynthesis.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 14. RiskEvidenceSynthesis.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 15. RiskEvidenceSynthesis.approvalDate
        public ElementDefinitionInfo Element_ApprovalDate;
        // 16. RiskEvidenceSynthesis.lastReviewDate
        public ElementDefinitionInfo Element_LastReviewDate;
        // 17. RiskEvidenceSynthesis.effectivePeriod
        public ElementDefinitionInfo Element_EffectivePeriod;
        // 18. RiskEvidenceSynthesis.topic
        public ElementDefinitionInfo Element_Topic;
        // 19. RiskEvidenceSynthesis.author
        public ElementDefinitionInfo Element_Author;
        // 20. RiskEvidenceSynthesis.editor
        public ElementDefinitionInfo Element_Editor;
        // 21. RiskEvidenceSynthesis.reviewer
        public ElementDefinitionInfo Element_Reviewer;
        // 22. RiskEvidenceSynthesis.endorser
        public ElementDefinitionInfo Element_Endorser;
        // 23. RiskEvidenceSynthesis.relatedArtifact
        public ElementDefinitionInfo Element_RelatedArtifact;
        // 24. RiskEvidenceSynthesis.synthesisType
        public ElementDefinitionInfo Element_SynthesisType;
        // 25. RiskEvidenceSynthesis.studyType
        public ElementDefinitionInfo Element_StudyType;
        // 26. RiskEvidenceSynthesis.population
        public ElementDefinitionInfo Element_Population;
        // 27. RiskEvidenceSynthesis.exposure
        public ElementDefinitionInfo Element_Exposure;
        // 28. RiskEvidenceSynthesis.outcome
        public ElementDefinitionInfo Element_Outcome;
        // 29. RiskEvidenceSynthesis.sampleSize
        public ElementDefinitionInfo Element_SampleSize;
        // 33. RiskEvidenceSynthesis.riskEstimate
        public ElementDefinitionInfo Element_RiskEstimate;
        // 45. RiskEvidenceSynthesis.certainty
        public ElementDefinitionInfo Element_Certainty;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "RiskEvidenceSynthesis",
                ElementId = "RiskEvidenceSynthesis"
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
            Element_Outcome.Write(sDef);
            Element_SampleSize.Write(sDef);
            Element_RiskEstimate.Write(sDef);
            Element_Certainty.Write(sDef);
        }
        
        public Resource_RiskEvidenceSynthesis()
        {
            {
                // 1. RiskEvidenceSynthesis.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "RiskEvidenceSynthesis.url",
                    Id = "RiskEvidenceSynthesis.url",
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
                // 2. RiskEvidenceSynthesis.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "RiskEvidenceSynthesis.identifier",
                    Id = "RiskEvidenceSynthesis.identifier",
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
                // 3. RiskEvidenceSynthesis.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "RiskEvidenceSynthesis.version",
                    Id = "RiskEvidenceSynthesis.version",
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
                // 4. RiskEvidenceSynthesis.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "RiskEvidenceSynthesis.name",
                    Id = "RiskEvidenceSynthesis.name",
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
                // 5. RiskEvidenceSynthesis.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "RiskEvidenceSynthesis.title",
                    Id = "RiskEvidenceSynthesis.title",
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
                // 6. RiskEvidenceSynthesis.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "RiskEvidenceSynthesis.status",
                    Id = "RiskEvidenceSynthesis.status",
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
                // 7. RiskEvidenceSynthesis.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "RiskEvidenceSynthesis.date",
                    Id = "RiskEvidenceSynthesis.date",
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
                // 8. RiskEvidenceSynthesis.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "RiskEvidenceSynthesis.publisher",
                    Id = "RiskEvidenceSynthesis.publisher",
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
                // 9. RiskEvidenceSynthesis.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "RiskEvidenceSynthesis.contact",
                    Id = "RiskEvidenceSynthesis.contact",
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
                // 10. RiskEvidenceSynthesis.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "RiskEvidenceSynthesis.description",
                    Id = "RiskEvidenceSynthesis.description",
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
                // 11. RiskEvidenceSynthesis.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "RiskEvidenceSynthesis.note",
                    Id = "RiskEvidenceSynthesis.note",
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
                // 12. RiskEvidenceSynthesis.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "RiskEvidenceSynthesis.useContext",
                    Id = "RiskEvidenceSynthesis.useContext",
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
                // 13. RiskEvidenceSynthesis.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "RiskEvidenceSynthesis.jurisdiction",
                    Id = "RiskEvidenceSynthesis.jurisdiction",
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
                // 14. RiskEvidenceSynthesis.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "RiskEvidenceSynthesis.copyright",
                    Id = "RiskEvidenceSynthesis.copyright",
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
                // 15. RiskEvidenceSynthesis.approvalDate
                this.Element_ApprovalDate = new ElementDefinitionInfo
                {
                    Name = "Element_ApprovalDate",
                    Path= "RiskEvidenceSynthesis.approvalDate",
                    Id = "RiskEvidenceSynthesis.approvalDate",
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
                // 16. RiskEvidenceSynthesis.lastReviewDate
                this.Element_LastReviewDate = new ElementDefinitionInfo
                {
                    Name = "Element_LastReviewDate",
                    Path= "RiskEvidenceSynthesis.lastReviewDate",
                    Id = "RiskEvidenceSynthesis.lastReviewDate",
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
                // 17. RiskEvidenceSynthesis.effectivePeriod
                this.Element_EffectivePeriod = new ElementDefinitionInfo
                {
                    Name = "Element_EffectivePeriod",
                    Path= "RiskEvidenceSynthesis.effectivePeriod",
                    Id = "RiskEvidenceSynthesis.effectivePeriod",
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
                // 18. RiskEvidenceSynthesis.topic
                this.Element_Topic = new ElementDefinitionInfo
                {
                    Name = "Element_Topic",
                    Path= "RiskEvidenceSynthesis.topic",
                    Id = "RiskEvidenceSynthesis.topic",
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
                // 19. RiskEvidenceSynthesis.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "RiskEvidenceSynthesis.author",
                    Id = "RiskEvidenceSynthesis.author",
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
                // 20. RiskEvidenceSynthesis.editor
                this.Element_Editor = new ElementDefinitionInfo
                {
                    Name = "Element_Editor",
                    Path= "RiskEvidenceSynthesis.editor",
                    Id = "RiskEvidenceSynthesis.editor",
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
                // 21. RiskEvidenceSynthesis.reviewer
                this.Element_Reviewer = new ElementDefinitionInfo
                {
                    Name = "Element_Reviewer",
                    Path= "RiskEvidenceSynthesis.reviewer",
                    Id = "RiskEvidenceSynthesis.reviewer",
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
                // 22. RiskEvidenceSynthesis.endorser
                this.Element_Endorser = new ElementDefinitionInfo
                {
                    Name = "Element_Endorser",
                    Path= "RiskEvidenceSynthesis.endorser",
                    Id = "RiskEvidenceSynthesis.endorser",
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
                // 23. RiskEvidenceSynthesis.relatedArtifact
                this.Element_RelatedArtifact = new ElementDefinitionInfo
                {
                    Name = "Element_RelatedArtifact",
                    Path= "RiskEvidenceSynthesis.relatedArtifact",
                    Id = "RiskEvidenceSynthesis.relatedArtifact",
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
                // 24. RiskEvidenceSynthesis.synthesisType
                this.Element_SynthesisType = new ElementDefinitionInfo
                {
                    Name = "Element_SynthesisType",
                    Path= "RiskEvidenceSynthesis.synthesisType",
                    Id = "RiskEvidenceSynthesis.synthesisType",
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
                // 25. RiskEvidenceSynthesis.studyType
                this.Element_StudyType = new ElementDefinitionInfo
                {
                    Name = "Element_StudyType",
                    Path= "RiskEvidenceSynthesis.studyType",
                    Id = "RiskEvidenceSynthesis.studyType",
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
                // 26. RiskEvidenceSynthesis.population
                this.Element_Population = new ElementDefinitionInfo
                {
                    Name = "Element_Population",
                    Path= "RiskEvidenceSynthesis.population",
                    Id = "RiskEvidenceSynthesis.population",
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
                // 27. RiskEvidenceSynthesis.exposure
                this.Element_Exposure = new ElementDefinitionInfo
                {
                    Name = "Element_Exposure",
                    Path= "RiskEvidenceSynthesis.exposure",
                    Id = "RiskEvidenceSynthesis.exposure",
                    Min = 0,
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
                // 28. RiskEvidenceSynthesis.outcome
                this.Element_Outcome = new ElementDefinitionInfo
                {
                    Name = "Element_Outcome",
                    Path= "RiskEvidenceSynthesis.outcome",
                    Id = "RiskEvidenceSynthesis.outcome",
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
                // 29. RiskEvidenceSynthesis.sampleSize
                this.Element_SampleSize = new ElementDefinitionInfo
                {
                    Name = "Element_SampleSize",
                    Path= "RiskEvidenceSynthesis.sampleSize",
                    Id = "RiskEvidenceSynthesis.sampleSize",
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
                // 33. RiskEvidenceSynthesis.riskEstimate
                this.Element_RiskEstimate = new ElementDefinitionInfo
                {
                    Name = "Element_RiskEstimate",
                    Path= "RiskEvidenceSynthesis.riskEstimate",
                    Id = "RiskEvidenceSynthesis.riskEstimate",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new Type_RiskEstimate
                        {
                        }
                    }
                };
            }
            {
                // 45. RiskEvidenceSynthesis.certainty
                this.Element_Certainty = new ElementDefinitionInfo
                {
                    Name = "Element_Certainty",
                    Path= "RiskEvidenceSynthesis.certainty",
                    Id = "RiskEvidenceSynthesis.certainty",
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
            this.Name = "RiskEvidenceSynthesis";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/RiskEvidenceSynthesis";
        }
    }
}
