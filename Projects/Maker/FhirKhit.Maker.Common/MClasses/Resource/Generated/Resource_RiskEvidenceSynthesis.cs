using System;                                                                                                                               // MakerGen.cs:435
using System.Diagnostics;                                                                                                                   // MakerGen.cs:436
using System.IO;                                                                                                                            // MakerGen.cs:437
using System.Linq;                                                                                                                          // MakerGen.cs:438
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:439
                                                                                                                                            // MakerGen.cs:440
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:441
{                                                                                                                                           // MakerGen.cs:442
    #region Json                                                                                                                            // MakerGen.cs:443
    #if NEVER                                                                                                                               // MakerGen.cs:444
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
    #endregion                                                                                                                              // MakerGen.cs:447
    /// <summary>
    /// Fhir resource 'RiskEvidenceSynthesis'
    /// </summary>
    // 0. RiskEvidenceSynthesis
    public class Resource_RiskEvidenceSynthesis : FhirKhit.Maker.Common.Resource.Resource_DomainResource                                    // MakerGen.cs:383
    {                                                                                                                                       // MakerGen.cs:384
        // 29. RiskEvidenceSynthesis.sampleSize
        public class Type_SampleSize : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 30. RiskEvidenceSynthesis.sampleSize.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:219
            // 31. RiskEvidenceSynthesis.sampleSize.numberOfStudies
            public ElementDefinitionInfo Element_NumberOfStudies;                                                                           // MakerGen.cs:219
            // 32. RiskEvidenceSynthesis.sampleSize.numberOfParticipants
            public ElementDefinitionInfo Element_NumberOfParticipants;                                                                      // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "RiskEvidenceSynthesis.sampleSize",                                                                              // MakerGen.cs:395
                    ElementId = "RiskEvidenceSynthesis.sampleSize"                                                                          // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_NumberOfStudies.Write(sDef);                                                                                        // MakerGen.cs:223
                Element_NumberOfParticipants.Write(sDef);                                                                                   // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_SampleSize()                                                                                                        // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 30. RiskEvidenceSynthesis.sampleSize.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Description",                                                                                       // MakerGen.cs:238
                        Path= "RiskEvidenceSynthesis.sampleSize.description",                                                               // MakerGen.cs:239
                        Id = "RiskEvidenceSynthesis.sampleSize.description",                                                                // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 31. RiskEvidenceSynthesis.sampleSize.numberOfStudies
                    this.Element_NumberOfStudies = new ElementDefinitionInfo                                                                // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_NumberOfStudies",                                                                                   // MakerGen.cs:238
                        Path= "RiskEvidenceSynthesis.sampleSize.numberOfStudies",                                                           // MakerGen.cs:239
                        Id = "RiskEvidenceSynthesis.sampleSize.numberOfStudies",                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 32. RiskEvidenceSynthesis.sampleSize.numberOfParticipants
                    this.Element_NumberOfParticipants = new ElementDefinitionInfo                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_NumberOfParticipants",                                                                              // MakerGen.cs:238
                        Path= "RiskEvidenceSynthesis.sampleSize.numberOfParticipants",                                                      // MakerGen.cs:239
                        Id = "RiskEvidenceSynthesis.sampleSize.numberOfParticipants",                                                       // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 33. RiskEvidenceSynthesis.riskEstimate
        public class Type_RiskEstimate : FhirKhit.Maker.Common.Complex.ComplexBase                                                          // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 40. RiskEvidenceSynthesis.riskEstimate.precisionEstimate
            public class Type_PrecisionEstimate : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 41. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:219
                // 42. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.level
                public ElementDefinitionInfo Element_Level;                                                                                 // MakerGen.cs:219
                // 43. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.from
                public ElementDefinitionInfo Element_From;                                                                                  // MakerGen.cs:219
                // 44. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.to
                public ElementDefinitionInfo Element_To;                                                                                    // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate",                                                      // MakerGen.cs:395
                        ElementId = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate"                                                  // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:223
                    Element_Level.Write(sDef);                                                                                              // MakerGen.cs:223
                    Element_From.Write(sDef);                                                                                               // MakerGen.cs:223
                    Element_To.Write(sDef);                                                                                                 // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_PrecisionEstimate()                                                                                             // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 41. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Type",                                                                                          // MakerGen.cs:238
                            Path= "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.type",                                              // MakerGen.cs:239
                            Id = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.type",                                               // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 42. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.level
                        this.Element_Level = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Level",                                                                                         // MakerGen.cs:238
                            Path= "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.level",                                             // MakerGen.cs:239
                            Id = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.level",                                              // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 43. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.from
                        this.Element_From = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_From",                                                                                          // MakerGen.cs:238
                            Path= "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.from",                                              // MakerGen.cs:239
                            Id = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.from",                                               // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 44. RiskEvidenceSynthesis.riskEstimate.precisionEstimate.to
                        this.Element_To = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_To",                                                                                            // MakerGen.cs:238
                            Path= "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.to",                                                // MakerGen.cs:239
                            Id = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate.to",                                                 // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                       // MakerGen.cs:303
                                {                                                                                                           // MakerGen.cs:304
                                }                                                                                                           // MakerGen.cs:307
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 34. RiskEvidenceSynthesis.riskEstimate.description
            public ElementDefinitionInfo Element_Description;                                                                               // MakerGen.cs:219
            // 35. RiskEvidenceSynthesis.riskEstimate.type
            public ElementDefinitionInfo Element_Type;                                                                                      // MakerGen.cs:219
            // 36. RiskEvidenceSynthesis.riskEstimate.value
            public ElementDefinitionInfo Element_Value;                                                                                     // MakerGen.cs:219
            // 37. RiskEvidenceSynthesis.riskEstimate.unitOfMeasure
            public ElementDefinitionInfo Element_UnitOfMeasure;                                                                             // MakerGen.cs:219
            // 38. RiskEvidenceSynthesis.riskEstimate.denominatorCount
            public ElementDefinitionInfo Element_DenominatorCount;                                                                          // MakerGen.cs:219
            // 39. RiskEvidenceSynthesis.riskEstimate.numeratorCount
            public ElementDefinitionInfo Element_NumeratorCount;                                                                            // MakerGen.cs:219
            // 40. RiskEvidenceSynthesis.riskEstimate.precisionEstimate
            public ElementDefinitionInfo Element_PrecisionEstimate;                                                                         // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "RiskEvidenceSynthesis.riskEstimate",                                                                            // MakerGen.cs:395
                    ElementId = "RiskEvidenceSynthesis.riskEstimate"                                                                        // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Description.Write(sDef);                                                                                            // MakerGen.cs:223
                Element_Type.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_Value.Write(sDef);                                                                                                  // MakerGen.cs:223
                Element_UnitOfMeasure.Write(sDef);                                                                                          // MakerGen.cs:223
                Element_DenominatorCount.Write(sDef);                                                                                       // MakerGen.cs:223
                Element_NumeratorCount.Write(sDef);                                                                                         // MakerGen.cs:223
                Element_PrecisionEstimate.Write(sDef);                                                                                      // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_RiskEstimate()                                                                                                      // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 34. RiskEvidenceSynthesis.riskEstimate.description
                    this.Element_Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Description",                                                                                       // MakerGen.cs:238
                        Path= "RiskEvidenceSynthesis.riskEstimate.description",                                                             // MakerGen.cs:239
                        Id = "RiskEvidenceSynthesis.riskEstimate.description",                                                              // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_String                                                            // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 35. RiskEvidenceSynthesis.riskEstimate.type
                    this.Element_Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Type",                                                                                              // MakerGen.cs:238
                        Path= "RiskEvidenceSynthesis.riskEstimate.type",                                                                    // MakerGen.cs:239
                        Id = "RiskEvidenceSynthesis.riskEstimate.type",                                                                     // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 36. RiskEvidenceSynthesis.riskEstimate.value
                    this.Element_Value = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Value",                                                                                             // MakerGen.cs:238
                        Path= "RiskEvidenceSynthesis.riskEstimate.value",                                                                   // MakerGen.cs:239
                        Id = "RiskEvidenceSynthesis.riskEstimate.value",                                                                    // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Decimal                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 37. RiskEvidenceSynthesis.riskEstimate.unitOfMeasure
                    this.Element_UnitOfMeasure = new ElementDefinitionInfo                                                                  // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_UnitOfMeasure",                                                                                     // MakerGen.cs:238
                        Path= "RiskEvidenceSynthesis.riskEstimate.unitOfMeasure",                                                           // MakerGen.cs:239
                        Id = "RiskEvidenceSynthesis.riskEstimate.unitOfMeasure",                                                            // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 38. RiskEvidenceSynthesis.riskEstimate.denominatorCount
                    this.Element_DenominatorCount = new ElementDefinitionInfo                                                               // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_DenominatorCount",                                                                                  // MakerGen.cs:238
                        Path= "RiskEvidenceSynthesis.riskEstimate.denominatorCount",                                                        // MakerGen.cs:239
                        Id = "RiskEvidenceSynthesis.riskEstimate.denominatorCount",                                                         // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 39. RiskEvidenceSynthesis.riskEstimate.numeratorCount
                    this.Element_NumeratorCount = new ElementDefinitionInfo                                                                 // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_NumeratorCount",                                                                                    // MakerGen.cs:238
                        Path= "RiskEvidenceSynthesis.riskEstimate.numeratorCount",                                                          // MakerGen.cs:239
                        Id = "RiskEvidenceSynthesis.riskEstimate.numeratorCount",                                                           // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = 1,                                                                                                            // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Primitive.Primitive_Integer                                                           // MakerGen.cs:303
                            {                                                                                                               // MakerGen.cs:304
                            }                                                                                                               // MakerGen.cs:307
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 40. RiskEvidenceSynthesis.riskEstimate.precisionEstimate
                    this.Element_PrecisionEstimate = new ElementDefinitionInfo                                                              // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_PrecisionEstimate",                                                                                 // MakerGen.cs:238
                        Path= "RiskEvidenceSynthesis.riskEstimate.precisionEstimate",                                                       // MakerGen.cs:239
                        Id = "RiskEvidenceSynthesis.riskEstimate.precisionEstimate",                                                        // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_PrecisionEstimate                                                                                      // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 45. RiskEvidenceSynthesis.certainty
        public class Type_Certainty : FhirKhit.Maker.Common.Complex.ComplexBase                                                             // MakerGen.cs:383
        {                                                                                                                                   // MakerGen.cs:384
            // 48. RiskEvidenceSynthesis.certainty.certaintySubcomponent
            public class Type_CertaintySubcomponent : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:383
            {                                                                                                                               // MakerGen.cs:384
                // 49. RiskEvidenceSynthesis.certainty.certaintySubcomponent.type
                public ElementDefinitionInfo Element_Type;                                                                                  // MakerGen.cs:219
                // 50. RiskEvidenceSynthesis.certainty.certaintySubcomponent.rating
                public ElementDefinitionInfo Element_Rating;                                                                                // MakerGen.cs:219
                // 51. RiskEvidenceSynthesis.certainty.certaintySubcomponent.note
                public ElementDefinitionInfo Element_Note;                                                                                  // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:390
                {                                                                                                                           // MakerGen.cs:391
                    base.Write(sDef);                                                                                                       // MakerGen.cs:392
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        Path = "RiskEvidenceSynthesis.certainty.certaintySubcomponent",                                                     // MakerGen.cs:395
                        ElementId = "RiskEvidenceSynthesis.certainty.certaintySubcomponent"                                                 // MakerGen.cs:396
                    });                                                                                                                     // MakerGen.cs:397
                    Element_Type.Write(sDef);                                                                                               // MakerGen.cs:223
                    Element_Rating.Write(sDef);                                                                                             // MakerGen.cs:223
                    Element_Note.Write(sDef);                                                                                               // MakerGen.cs:223
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
                public Type_CertaintySubcomponent()                                                                                         // MakerGen.cs:402
                {                                                                                                                           // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:234
                        // 49. RiskEvidenceSynthesis.certainty.certaintySubcomponent.type
                        this.Element_Type = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Type",                                                                                          // MakerGen.cs:238
                            Path= "RiskEvidenceSynthesis.certainty.certaintySubcomponent.type",                                             // MakerGen.cs:239
                            Id = "RiskEvidenceSynthesis.certainty.certaintySubcomponent.type",                                              // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = 1,                                                                                                        // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 50. RiskEvidenceSynthesis.certainty.certaintySubcomponent.rating
                        this.Element_Rating = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Rating",                                                                                        // MakerGen.cs:238
                            Path= "RiskEvidenceSynthesis.certainty.certaintySubcomponent.rating",                                           // MakerGen.cs:239
                            Id = "RiskEvidenceSynthesis.certainty.certaintySubcomponent.rating",                                            // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                      // MakerGen.cs:318
                                {                                                                                                           // MakerGen.cs:319
                                }                                                                                                           // MakerGen.cs:322
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                    {                                                                                                                       // MakerGen.cs:234
                        // 51. RiskEvidenceSynthesis.certainty.certaintySubcomponent.note
                        this.Element_Note = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                        {                                                                                                                   // MakerGen.cs:237
                            Name = "Element_Note",                                                                                          // MakerGen.cs:238
                            Path= "RiskEvidenceSynthesis.certainty.certaintySubcomponent.note",                                             // MakerGen.cs:239
                            Id = "RiskEvidenceSynthesis.certainty.certaintySubcomponent.note",                                              // MakerGen.cs:240
                            Min = 0,                                                                                                        // MakerGen.cs:241
                            Max = -1,                                                                                                       // MakerGen.cs:242
                            Types = new BaseType[]                                                                                          // MakerGen.cs:243
                            {                                                                                                               // MakerGen.cs:244
                                new FhirKhit.Maker.Common.Complex.Type_Annotation                                                           // MakerGen.cs:358
                                {                                                                                                           // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:360
                            }                                                                                                               // MakerGen.cs:246
                        };                                                                                                                  // MakerGen.cs:247
                    }                                                                                                                       // MakerGen.cs:248
                }                                                                                                                           // MakerGen.cs:405
            }                                                                                                                               // MakerGen.cs:407
            // 46. RiskEvidenceSynthesis.certainty.rating
            public ElementDefinitionInfo Element_Rating;                                                                                    // MakerGen.cs:219
            // 47. RiskEvidenceSynthesis.certainty.note
            public ElementDefinitionInfo Element_Note;                                                                                      // MakerGen.cs:219
            // 48. RiskEvidenceSynthesis.certainty.certaintySubcomponent
            public ElementDefinitionInfo Element_CertaintySubcomponent;                                                                     // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:390
            {                                                                                                                               // MakerGen.cs:391
                base.Write(sDef);                                                                                                           // MakerGen.cs:392
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                          // MakerGen.cs:393
                {                                                                                                                           // MakerGen.cs:394
                    Path = "RiskEvidenceSynthesis.certainty",                                                                               // MakerGen.cs:395
                    ElementId = "RiskEvidenceSynthesis.certainty"                                                                           // MakerGen.cs:396
                });                                                                                                                         // MakerGen.cs:397
                Element_Rating.Write(sDef);                                                                                                 // MakerGen.cs:223
                Element_Note.Write(sDef);                                                                                                   // MakerGen.cs:223
                Element_CertaintySubcomponent.Write(sDef);                                                                                  // MakerGen.cs:223
            }                                                                                                                               // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
            public Type_Certainty()                                                                                                         // MakerGen.cs:402
            {                                                                                                                               // MakerGen.cs:403
                {                                                                                                                           // MakerGen.cs:234
                    // 46. RiskEvidenceSynthesis.certainty.rating
                    this.Element_Rating = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Rating",                                                                                            // MakerGen.cs:238
                        Path= "RiskEvidenceSynthesis.certainty.rating",                                                                     // MakerGen.cs:239
                        Id = "RiskEvidenceSynthesis.certainty.rating",                                                                      // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                          // MakerGen.cs:318
                            {                                                                                                               // MakerGen.cs:319
                            }                                                                                                               // MakerGen.cs:322
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 47. RiskEvidenceSynthesis.certainty.note
                    this.Element_Note = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_Note",                                                                                              // MakerGen.cs:238
                        Path= "RiskEvidenceSynthesis.certainty.note",                                                                       // MakerGen.cs:239
                        Id = "RiskEvidenceSynthesis.certainty.note",                                                                        // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new FhirKhit.Maker.Common.Complex.Type_Annotation                                                               // MakerGen.cs:358
                            {                                                                                                               // MakerGen.cs:359
                            }                                                                                                               // MakerGen.cs:360
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
                {                                                                                                                           // MakerGen.cs:234
                    // 48. RiskEvidenceSynthesis.certainty.certaintySubcomponent
                    this.Element_CertaintySubcomponent = new ElementDefinitionInfo                                                          // MakerGen.cs:236
                    {                                                                                                                       // MakerGen.cs:237
                        Name = "Element_CertaintySubcomponent",                                                                             // MakerGen.cs:238
                        Path= "RiskEvidenceSynthesis.certainty.certaintySubcomponent",                                                      // MakerGen.cs:239
                        Id = "RiskEvidenceSynthesis.certainty.certaintySubcomponent",                                                       // MakerGen.cs:240
                        Min = 0,                                                                                                            // MakerGen.cs:241
                        Max = -1,                                                                                                           // MakerGen.cs:242
                        Types = new BaseType[]                                                                                              // MakerGen.cs:243
                        {                                                                                                                   // MakerGen.cs:244
                            new Type_CertaintySubcomponent                                                                                  // MakerGen.cs:262
                            {                                                                                                               // MakerGen.cs:263
                            }                                                                                                               // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:246
                    };                                                                                                                      // MakerGen.cs:247
                }                                                                                                                           // MakerGen.cs:248
            }                                                                                                                               // MakerGen.cs:405
        }                                                                                                                                   // MakerGen.cs:407
        // 1. RiskEvidenceSynthesis.url
        public ElementDefinitionInfo Element_Url;                                                                                           // MakerGen.cs:219
        // 2. RiskEvidenceSynthesis.identifier
        public ElementDefinitionInfo Element_Identifier;                                                                                    // MakerGen.cs:219
        // 3. RiskEvidenceSynthesis.version
        public ElementDefinitionInfo Element_Version;                                                                                       // MakerGen.cs:219
        // 4. RiskEvidenceSynthesis.name
        public ElementDefinitionInfo Element_Name;                                                                                          // MakerGen.cs:219
        // 5. RiskEvidenceSynthesis.title
        public ElementDefinitionInfo Element_Title;                                                                                         // MakerGen.cs:219
        // 6. RiskEvidenceSynthesis.status
        public ElementDefinitionInfo Element_Status;                                                                                        // MakerGen.cs:219
        // 7. RiskEvidenceSynthesis.date
        public ElementDefinitionInfo Element_Date;                                                                                          // MakerGen.cs:219
        // 8. RiskEvidenceSynthesis.publisher
        public ElementDefinitionInfo Element_Publisher;                                                                                     // MakerGen.cs:219
        // 9. RiskEvidenceSynthesis.contact
        public ElementDefinitionInfo Element_Contact;                                                                                       // MakerGen.cs:219
        // 10. RiskEvidenceSynthesis.description
        public ElementDefinitionInfo Element_Description;                                                                                   // MakerGen.cs:219
        // 11. RiskEvidenceSynthesis.note
        public ElementDefinitionInfo Element_Note;                                                                                          // MakerGen.cs:219
        // 12. RiskEvidenceSynthesis.useContext
        public ElementDefinitionInfo Element_UseContext;                                                                                    // MakerGen.cs:219
        // 13. RiskEvidenceSynthesis.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;                                                                                  // MakerGen.cs:219
        // 14. RiskEvidenceSynthesis.copyright
        public ElementDefinitionInfo Element_Copyright;                                                                                     // MakerGen.cs:219
        // 15. RiskEvidenceSynthesis.approvalDate
        public ElementDefinitionInfo Element_ApprovalDate;                                                                                  // MakerGen.cs:219
        // 16. RiskEvidenceSynthesis.lastReviewDate
        public ElementDefinitionInfo Element_LastReviewDate;                                                                                // MakerGen.cs:219
        // 17. RiskEvidenceSynthesis.effectivePeriod
        public ElementDefinitionInfo Element_EffectivePeriod;                                                                               // MakerGen.cs:219
        // 18. RiskEvidenceSynthesis.topic
        public ElementDefinitionInfo Element_Topic;                                                                                         // MakerGen.cs:219
        // 19. RiskEvidenceSynthesis.author
        public ElementDefinitionInfo Element_Author;                                                                                        // MakerGen.cs:219
        // 20. RiskEvidenceSynthesis.editor
        public ElementDefinitionInfo Element_Editor;                                                                                        // MakerGen.cs:219
        // 21. RiskEvidenceSynthesis.reviewer
        public ElementDefinitionInfo Element_Reviewer;                                                                                      // MakerGen.cs:219
        // 22. RiskEvidenceSynthesis.endorser
        public ElementDefinitionInfo Element_Endorser;                                                                                      // MakerGen.cs:219
        // 23. RiskEvidenceSynthesis.relatedArtifact
        public ElementDefinitionInfo Element_RelatedArtifact;                                                                               // MakerGen.cs:219
        // 24. RiskEvidenceSynthesis.synthesisType
        public ElementDefinitionInfo Element_SynthesisType;                                                                                 // MakerGen.cs:219
        // 25. RiskEvidenceSynthesis.studyType
        public ElementDefinitionInfo Element_StudyType;                                                                                     // MakerGen.cs:219
        // 26. RiskEvidenceSynthesis.population
        public ElementDefinitionInfo Element_Population;                                                                                    // MakerGen.cs:219
        // 27. RiskEvidenceSynthesis.exposure
        public ElementDefinitionInfo Element_Exposure;                                                                                      // MakerGen.cs:219
        // 28. RiskEvidenceSynthesis.outcome
        public ElementDefinitionInfo Element_Outcome;                                                                                       // MakerGen.cs:219
        // 29. RiskEvidenceSynthesis.sampleSize
        public ElementDefinitionInfo Element_SampleSize;                                                                                    // MakerGen.cs:219
        // 33. RiskEvidenceSynthesis.riskEstimate
        public ElementDefinitionInfo Element_RiskEstimate;                                                                                  // MakerGen.cs:219
        // 45. RiskEvidenceSynthesis.certainty
        public ElementDefinitionInfo Element_Certainty;                                                                                     // MakerGen.cs:219
                                                                                                                                            // MakerGen.cs:389
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:390
        {                                                                                                                                   // MakerGen.cs:391
            base.Write(sDef);                                                                                                               // MakerGen.cs:392
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                Path = "RiskEvidenceSynthesis",                                                                                             // MakerGen.cs:395
                ElementId = "RiskEvidenceSynthesis"                                                                                         // MakerGen.cs:396
            });                                                                                                                             // MakerGen.cs:397
            Element_Url.Write(sDef);                                                                                                        // MakerGen.cs:223
            Element_Identifier.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Version.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Name.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Title.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Status.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Date.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_Publisher.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Contact.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_Description.Write(sDef);                                                                                                // MakerGen.cs:223
            Element_Note.Write(sDef);                                                                                                       // MakerGen.cs:223
            Element_UseContext.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Jurisdiction.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Copyright.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_ApprovalDate.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_LastReviewDate.Write(sDef);                                                                                             // MakerGen.cs:223
            Element_EffectivePeriod.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_Topic.Write(sDef);                                                                                                      // MakerGen.cs:223
            Element_Author.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Editor.Write(sDef);                                                                                                     // MakerGen.cs:223
            Element_Reviewer.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Endorser.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_RelatedArtifact.Write(sDef);                                                                                            // MakerGen.cs:223
            Element_SynthesisType.Write(sDef);                                                                                              // MakerGen.cs:223
            Element_StudyType.Write(sDef);                                                                                                  // MakerGen.cs:223
            Element_Population.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_Exposure.Write(sDef);                                                                                                   // MakerGen.cs:223
            Element_Outcome.Write(sDef);                                                                                                    // MakerGen.cs:223
            Element_SampleSize.Write(sDef);                                                                                                 // MakerGen.cs:223
            Element_RiskEstimate.Write(sDef);                                                                                               // MakerGen.cs:223
            Element_Certainty.Write(sDef);                                                                                                  // MakerGen.cs:223
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:401
        public Resource_RiskEvidenceSynthesis()                                                                                             // MakerGen.cs:402
        {                                                                                                                                   // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:234
                // 1. RiskEvidenceSynthesis.url
                this.Element_Url = new ElementDefinitionInfo                                                                                // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Url",                                                                                                   // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.url",                                                                                      // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.url",                                                                                       // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri                                                                   // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 2. RiskEvidenceSynthesis.identifier
                this.Element_Identifier = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Identifier",                                                                                            // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.identifier",                                                                               // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.identifier",                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Identifier                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 3. RiskEvidenceSynthesis.version
                this.Element_Version = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Version",                                                                                               // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.version",                                                                                  // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.version",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 4. RiskEvidenceSynthesis.name
                this.Element_Name = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Name",                                                                                                  // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.name",                                                                                     // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.name",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 5. RiskEvidenceSynthesis.title
                this.Element_Title = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Title",                                                                                                 // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.title",                                                                                    // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.title",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 6. RiskEvidenceSynthesis.status
                this.Element_Status = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Status",                                                                                                // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.status",                                                                                   // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.status",                                                                                    // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 7. RiskEvidenceSynthesis.date
                this.Element_Date = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Date",                                                                                                  // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.date",                                                                                     // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.date",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_DateTime                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 8. RiskEvidenceSynthesis.publisher
                this.Element_Publisher = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Publisher",                                                                                             // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.publisher",                                                                                // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.publisher",                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_String                                                                // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 9. RiskEvidenceSynthesis.contact
                this.Element_Contact = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Contact",                                                                                               // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.contact",                                                                                  // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.contact",                                                                                   // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 10. RiskEvidenceSynthesis.description
                this.Element_Description = new ElementDefinitionInfo                                                                        // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Description",                                                                                           // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.description",                                                                              // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.description",                                                                               // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 11. RiskEvidenceSynthesis.note
                this.Element_Note = new ElementDefinitionInfo                                                                               // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Note",                                                                                                  // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.note",                                                                                     // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.note",                                                                                      // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Annotation                                                                   // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 12. RiskEvidenceSynthesis.useContext
                this.Element_UseContext = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_UseContext",                                                                                            // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.useContext",                                                                               // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.useContext",                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_UsageContext                                                                 // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 13. RiskEvidenceSynthesis.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Jurisdiction",                                                                                          // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.jurisdiction",                                                                             // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.jurisdiction",                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 14. RiskEvidenceSynthesis.copyright
                this.Element_Copyright = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Copyright",                                                                                             // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.copyright",                                                                                // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.copyright",                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Markdown                                                              // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 15. RiskEvidenceSynthesis.approvalDate
                this.Element_ApprovalDate = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_ApprovalDate",                                                                                          // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.approvalDate",                                                                             // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.approvalDate",                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 16. RiskEvidenceSynthesis.lastReviewDate
                this.Element_LastReviewDate = new ElementDefinitionInfo                                                                     // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_LastReviewDate",                                                                                        // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.lastReviewDate",                                                                           // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.lastReviewDate",                                                                            // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Primitive.Primitive_Date                                                                  // MakerGen.cs:303
                        {                                                                                                                   // MakerGen.cs:304
                        }                                                                                                                   // MakerGen.cs:307
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 17. RiskEvidenceSynthesis.effectivePeriod
                this.Element_EffectivePeriod = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_EffectivePeriod",                                                                                       // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.effectivePeriod",                                                                          // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.effectivePeriod",                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Period                                                                       // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 18. RiskEvidenceSynthesis.topic
                this.Element_Topic = new ElementDefinitionInfo                                                                              // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Topic",                                                                                                 // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.topic",                                                                                    // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.topic",                                                                                     // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 19. RiskEvidenceSynthesis.author
                this.Element_Author = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Author",                                                                                                // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.author",                                                                                   // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.author",                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 20. RiskEvidenceSynthesis.editor
                this.Element_Editor = new ElementDefinitionInfo                                                                             // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Editor",                                                                                                // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.editor",                                                                                   // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.editor",                                                                                    // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 21. RiskEvidenceSynthesis.reviewer
                this.Element_Reviewer = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Reviewer",                                                                                              // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.reviewer",                                                                                 // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.reviewer",                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 22. RiskEvidenceSynthesis.endorser
                this.Element_Endorser = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Endorser",                                                                                              // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.endorser",                                                                                 // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.endorser",                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_ContactDetail                                                                // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 23. RiskEvidenceSynthesis.relatedArtifact
                this.Element_RelatedArtifact = new ElementDefinitionInfo                                                                    // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_RelatedArtifact",                                                                                       // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.relatedArtifact",                                                                          // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.relatedArtifact",                                                                           // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_RelatedArtifact                                                              // MakerGen.cs:358
                        {                                                                                                                   // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:360
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 24. RiskEvidenceSynthesis.synthesisType
                this.Element_SynthesisType = new ElementDefinitionInfo                                                                      // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_SynthesisType",                                                                                         // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.synthesisType",                                                                            // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.synthesisType",                                                                             // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 25. RiskEvidenceSynthesis.studyType
                this.Element_StudyType = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_StudyType",                                                                                             // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.studyType",                                                                                // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.studyType",                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_CodeableConcept                                                              // MakerGen.cs:318
                        {                                                                                                                   // MakerGen.cs:319
                        }                                                                                                                   // MakerGen.cs:322
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 26. RiskEvidenceSynthesis.population
                this.Element_Population = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Population",                                                                                            // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.population",                                                                               // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.population",                                                                                // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                                  // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 27. RiskEvidenceSynthesis.exposure
                this.Element_Exposure = new ElementDefinitionInfo                                                                           // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Exposure",                                                                                              // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.exposure",                                                                                 // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.exposure",                                                                                  // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                                  // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 28. RiskEvidenceSynthesis.outcome
                this.Element_Outcome = new ElementDefinitionInfo                                                                            // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Outcome",                                                                                               // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.outcome",                                                                                  // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.outcome",                                                                                   // MakerGen.cs:240
                    Min = 1,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new FhirKhit.Maker.Common.Complex.Type_Reference                                                                    // MakerGen.cs:346
                        {                                                                                                                   // MakerGen.cs:347
                            TargetProfile = new String[]                                                                                    // MakerGen.cs:349
                            {                                                                                                               // CodeEditorExtensions.cs:28
                                "http://hl7.org/fhir/StructureDefinition/EvidenceVariable"                                                  // MakerGen.cs:349
                            }                                                                                                               // CodeEditorExtensions.cs:34
                        }                                                                                                                   // MakerGen.cs:350
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 29. RiskEvidenceSynthesis.sampleSize
                this.Element_SampleSize = new ElementDefinitionInfo                                                                         // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_SampleSize",                                                                                            // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.sampleSize",                                                                               // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.sampleSize",                                                                                // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_SampleSize                                                                                                 // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 33. RiskEvidenceSynthesis.riskEstimate
                this.Element_RiskEstimate = new ElementDefinitionInfo                                                                       // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_RiskEstimate",                                                                                          // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.riskEstimate",                                                                             // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.riskEstimate",                                                                              // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = 1,                                                                                                                // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_RiskEstimate                                                                                               // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            {                                                                                                                               // MakerGen.cs:234
                // 45. RiskEvidenceSynthesis.certainty
                this.Element_Certainty = new ElementDefinitionInfo                                                                          // MakerGen.cs:236
                {                                                                                                                           // MakerGen.cs:237
                    Name = "Element_Certainty",                                                                                             // MakerGen.cs:238
                    Path= "RiskEvidenceSynthesis.certainty",                                                                                // MakerGen.cs:239
                    Id = "RiskEvidenceSynthesis.certainty",                                                                                 // MakerGen.cs:240
                    Min = 0,                                                                                                                // MakerGen.cs:241
                    Max = -1,                                                                                                               // MakerGen.cs:242
                    Types = new BaseType[]                                                                                                  // MakerGen.cs:243
                    {                                                                                                                       // MakerGen.cs:244
                        new Type_Certainty                                                                                                  // MakerGen.cs:262
                        {                                                                                                                   // MakerGen.cs:263
                        }                                                                                                                   // MakerGen.cs:264
                    }                                                                                                                       // MakerGen.cs:246
                };                                                                                                                          // MakerGen.cs:247
            }                                                                                                                               // MakerGen.cs:248
            this.Name = "RiskEvidenceSynthesis";                                                                                            // MakerGen.cs:471
            this.Uri = "http://hl7.org/fhir/StructureDefinition/RiskEvidenceSynthesis";                                                     // MakerGen.cs:472
        }                                                                                                                                   // MakerGen.cs:405
    }                                                                                                                                       // MakerGen.cs:407
}                                                                                                                                           // MakerGen.cs:452
