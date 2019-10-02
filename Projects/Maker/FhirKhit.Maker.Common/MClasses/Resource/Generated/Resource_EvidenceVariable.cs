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
      "id": "EvidenceVariable",
      "url": "http://hl7.org/fhir/StructureDefinition/EvidenceVariable",
      "version": "4.0.0",
      "name": "EvidenceVariable",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Decision Support)",
      "description": "The EvidenceVariable resource describes a \"PICO\" element that knowledge (evidence, assertion, recommendation) is about.",
      "purpose": "Need to be able to define and reuse the definition of individual elements of a research question.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "EvidenceVariable",
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
            "id": "EvidenceVariable",
            "path": "EvidenceVariable",
            "short": "A population, intervention, or exposure definition",
            "definition": "The EvidenceVariable resource describes a \"PICO\" element that knowledge (evidence, assertion, recommendation) is about.",
            "comment": "PICO stands for Population (the population within which exposures are being compared), Intervention (the conditional state or exposure state being described for its effect on outcomes), Comparison (the alternative conditional state or alternative exposure state being compared against), and Outcome (the result or effect of the intervention in the population).",
            "min": 0,
            "max": "*"
          },
          {
            "id": "EvidenceVariable.url",
            "path": "EvidenceVariable.url",
            "short": "Canonical identifier for this evidence variable, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this evidence variable when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this evidence variable is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the evidence variable is stored on different servers.",
            "comment": "Can be a urn:uuid: or a urn:oid: but real http: addresses are preferred.  Multiple instances may share the same URL if they have a distinct version.\n\nThe determination of when to create a new version of a resource (same url, new version) vs. defining a new artifact is up to the author.  Considerations for making this decision are found in [Technical and Business Versions](resource.html#versions). \n\nIn some cases, the resource can no longer be found at the stated url, but the url itself cannot change. Implementations can use the [meta.source](resource.html#meta) element to indicate where the current master source of the resource can be found.",
            "requirements": "Allows the evidence variable to be referenced by a single globally unique identifier.",
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
            "id": "EvidenceVariable.identifier",
            "path": "EvidenceVariable.identifier",
            "short": "Additional identifier for the evidence variable",
            "definition": "A formal identifier that is used to identify this evidence variable when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this evidence variable outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "EvidenceVariable.version",
            "path": "EvidenceVariable.version",
            "short": "Business version of the evidence variable",
            "definition": "The identifier that is used to identify this version of the evidence variable when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the evidence variable author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence. To provide a version consistent with the Decision Support Service specification, use the format Major.Minor.Revision (e.g. 1.0.0). For more information on versioning knowledge assets, refer to the Decision Support Service specification. Note that a version is required for non-experimental active artifacts.",
            "comment": "There may be different evidence variable instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the evidence variable with the format [url]|[version].",
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
            "id": "EvidenceVariable.name",
            "path": "EvidenceVariable.name",
            "short": "Name for this evidence variable (computer friendly)",
            "definition": "A natural language name identifying the evidence variable. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "EvidenceVariable.title",
            "path": "EvidenceVariable.title",
            "short": "Name for this evidence variable (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the evidence variable.",
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
            "id": "EvidenceVariable.shortTitle",
            "path": "EvidenceVariable.shortTitle",
            "short": "Title for use in informal contexts",
            "definition": "The short title provides an alternate title for use in informal descriptive contexts where the full, formal title is not necessary.",
            "requirements": "Need to be able to reference the content by a short description, but still provide a longer, more formal title for the content.",
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
            "id": "EvidenceVariable.subtitle",
            "path": "EvidenceVariable.subtitle",
            "short": "Subordinate title of the EvidenceVariable",
            "definition": "An explanatory or alternate title for the EvidenceVariable giving additional information about its content.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "EvidenceVariable.status",
            "path": "EvidenceVariable.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this evidence variable. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of evidence variables that are appropriate for use versus not.",
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
            "id": "EvidenceVariable.date",
            "path": "EvidenceVariable.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the evidence variable was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the evidence variable changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the evidence variable. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "EvidenceVariable.publisher",
            "path": "EvidenceVariable.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the evidence variable.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the evidence variable is the organization or individual primarily responsible for the maintenance and upkeep of the evidence variable. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the evidence variable. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the evidence variable.  May also allow for contact.",
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
            "id": "EvidenceVariable.contact",
            "path": "EvidenceVariable.contact",
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
            "id": "EvidenceVariable.description",
            "path": "EvidenceVariable.description",
            "short": "Natural language description of the evidence variable",
            "definition": "A free text natural language description of the evidence variable from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the evidence variable was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the evidence variable as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the evidence variable is presumed to be the predominant language in the place the evidence variable was created).",
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
            "id": "EvidenceVariable.note",
            "path": "EvidenceVariable.note",
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
            "id": "EvidenceVariable.useContext",
            "path": "EvidenceVariable.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate evidence variable instances.",
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
            "id": "EvidenceVariable.jurisdiction",
            "path": "EvidenceVariable.jurisdiction",
            "short": "Intended jurisdiction for evidence variable (if applicable)",
            "definition": "A legal or geographic region in which the evidence variable is intended to be used.",
            "comment": "It may be possible for the evidence variable to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "EvidenceVariable.copyright",
            "path": "EvidenceVariable.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the evidence variable and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the evidence variable.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the evidence variable and/or its content.",
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
            "id": "EvidenceVariable.approvalDate",
            "path": "EvidenceVariable.approvalDate",
            "short": "When the evidence variable was approved by publisher",
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
            "id": "EvidenceVariable.lastReviewDate",
            "path": "EvidenceVariable.lastReviewDate",
            "short": "When the evidence variable was last reviewed",
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
            "id": "EvidenceVariable.effectivePeriod",
            "path": "EvidenceVariable.effectivePeriod",
            "short": "When the evidence variable is expected to be used",
            "definition": "The period during which the evidence variable content was or is planned to be in active use.",
            "comment": "The effective period for a evidence variable  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.",
            "requirements": "Allows establishing a transition before a resource comes into effect and also allows for a sunsetting  process when new versions of the evidence variable are or are expected to be used instead.",
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
            "id": "EvidenceVariable.topic",
            "path": "EvidenceVariable.topic",
            "short": "The category of the EvidenceVariable, such as Education, Treatment, Assessment, etc.",
            "definition": "Descriptive topics related to the content of the EvidenceVariable. Topics provide a high-level categorization grouping types of EvidenceVariables that can be useful for filtering and searching.",
            "requirements": "Repositories must be able to determine how to categorize the EvidenceVariable so that it can be found by topical searches.",
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
            "id": "EvidenceVariable.author",
            "path": "EvidenceVariable.author",
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
            "id": "EvidenceVariable.editor",
            "path": "EvidenceVariable.editor",
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
            "id": "EvidenceVariable.reviewer",
            "path": "EvidenceVariable.reviewer",
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
            "id": "EvidenceVariable.endorser",
            "path": "EvidenceVariable.endorser",
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
            "id": "EvidenceVariable.relatedArtifact",
            "path": "EvidenceVariable.relatedArtifact",
            "short": "Additional documentation, citations, etc.",
            "definition": "Related artifacts such as additional documentation, justification, or bibliographic references.",
            "comment": "Each related artifact is either an attachment, or a reference to another resource, but not both.",
            "requirements": "EvidenceVariables must be able to provide enough information for consumers of the content (and/or interventions or results produced by the content) to be able to determine and understand the justification for and evidence in support of the content.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "RelatedArtifact"
              }
            ]
          },
          {
            "id": "EvidenceVariable.type",
            "path": "EvidenceVariable.type",
            "short": "dichotomous | continuous | descriptive",
            "definition": "The type of evidence element, a population, an exposure, or an outcome.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "EvidenceVariableType"
                }
              ],
              "strength": "required",
              "description": "The possible types of variables for exposures or outcomes (E.g. Dichotomous, Continuous, Descriptive).",
              "valueSet": "http://hl7.org/fhir/ValueSet/variable-type|4.0.0"
            }
          },
          {
            "id": "EvidenceVariable.characteristic",
            "path": "EvidenceVariable.characteristic",
            "short": "What defines the members of the evidence element",
            "definition": "A characteristic that defines the members of the evidence element. Multiple characteristics are applied with \"and\" semantics.",
            "comment": "Characteristics can be defined flexibly to accommodate different use cases for membership criteria, ranging from simple codes, all the way to using an expression language to express the criteria.",
            "min": 1,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isSummary": true
          },
          {
            "id": "EvidenceVariable.characteristic.description",
            "path": "EvidenceVariable.characteristic.description",
            "short": "Natural language description of the characteristic",
            "definition": "A short, natural language description of the characteristic that could be used to communicate the criteria to an end-user.",
            "requirements": "Need to be able to describe characteristics in natural language so that end users can understand the criteria.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "EvidenceVariable.characteristic.definition[x]",
            "path": "EvidenceVariable.characteristic.definition[x]",
            "short": "What code or expression defines members?",
            "definition": "Define members of the evidence element using Codes (such as condition, medication, or observation), Expressions ( using an expression language such as FHIRPath or CQL) or DataRequirements (such as Diabetes diagnosis onset in the last year).",
            "requirements": "Need to be able to define members in simple codes when the membership aligns well with terminology, with common criteria such as observations in a value set or lab tests within a year, or with expression language to support criteria that do not fit in the above.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              },
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ActivityDefinition"
                ]
              },
              {
                "code": "CodeableConcept"
              },
              {
                "code": "Expression"
              },
              {
                "code": "DataRequirement"
              },
              {
                "code": "TriggerDefinition"
              }
            ],
            "isSummary": true
          },
          {
            "id": "EvidenceVariable.characteristic.usageContext",
            "path": "EvidenceVariable.characteristic.usageContext",
            "short": "What code/value pairs define members?",
            "definition": "Use UsageContext to define the members of the population, such as Age Ranges, Genders, Settings.",
            "requirements": "Need to be able to define members more structurally when more information can be communicated such as age range.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "UsageContext"
              }
            ]
          },
          {
            "id": "EvidenceVariable.characteristic.exclude",
            "path": "EvidenceVariable.characteristic.exclude",
            "short": "Whether the characteristic includes or excludes members",
            "definition": "When true, members with this characteristic are excluded from the element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "False"
          },
          {
            "id": "EvidenceVariable.characteristic.participantEffective[x]",
            "path": "EvidenceVariable.characteristic.participantEffective[x]",
            "short": "What time period do participants cover",
            "definition": "Indicates what effective period the study covers.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Period"
              },
              {
                "code": "Duration"
              },
              {
                "code": "Timing"
              }
            ]
          },
          {
            "id": "EvidenceVariable.characteristic.timeFromStart",
            "path": "EvidenceVariable.characteristic.timeFromStart",
            "short": "Observation time from study start",
            "definition": "Indicates duration from the participant's study entry.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              }
            ]
          },
          {
            "id": "EvidenceVariable.characteristic.groupMeasure",
            "path": "EvidenceVariable.characteristic.groupMeasure",
            "short": "mean | median | mean-of-mean | mean-of-median | median-of-mean | median-of-median",
            "definition": "Indicates how elements are aggregated within the study effective period.",
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
                  "valueString": "GroupMeasure"
                }
              ],
              "strength": "required",
              "description": "Possible group measure aggregates (E.g. Mean, Median).",
              "valueSet": "http://hl7.org/fhir/ValueSet/group-measure|4.0.0"
            }
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'EvidenceVariable'
    /// </summary>
    // 0. EvidenceVariable
    public partial class Resource_EvidenceVariable : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 27. EvidenceVariable.characteristic
        public partial class Type_Characteristic : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 28. EvidenceVariable.characteristic.description
            public ElementDefinitionInfo Element_Description;
            // 29. EvidenceVariable.characteristic.definition[x]
            public ElementDefinitionInfo Element_Definition;
            // 30. EvidenceVariable.characteristic.usageContext
            public ElementDefinitionInfo Element_UsageContext;
            // 31. EvidenceVariable.characteristic.exclude
            public ElementDefinitionInfo Element_Exclude;
            // 32. EvidenceVariable.characteristic.participantEffective[x]
            public ElementDefinitionInfo Element_ParticipantEffective;
            // 33. EvidenceVariable.characteristic.timeFromStart
            public ElementDefinitionInfo Element_TimeFromStart;
            // 34. EvidenceVariable.characteristic.groupMeasure
            public ElementDefinitionInfo Element_GroupMeasure;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "EvidenceVariable.characteristic",
                    ElementId = "EvidenceVariable.characteristic"
                });
                Element_Description.Write(sDef);
                Element_Definition.Write(sDef);
                Element_UsageContext.Write(sDef);
                Element_Exclude.Write(sDef);
                Element_ParticipantEffective.Write(sDef);
                Element_TimeFromStart.Write(sDef);
                Element_GroupMeasure.Write(sDef);
            }
            
            public Type_Characteristic()
            {
                {
                    // 28. EvidenceVariable.characteristic.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "EvidenceVariable.characteristic.description",
                        Id = "EvidenceVariable.characteristic.description",
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
                    // 29. EvidenceVariable.characteristic.definition[x]
                    this.Element_Definition = new ElementDefinitionInfo
                    {
                        Name = "Element_Definition",
                        Path= "EvidenceVariable.characteristic.definition[x]",
                        Id = "EvidenceVariable.characteristic.definition[x]",
                        Min = 1,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Group"
                                }
                            },
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/ActivityDefinition"
                                }
                            },
                            new FhirKhit.Maker.Common.Complex.Type_CodeableConcept
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Expression
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_DataRequirement
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_TriggerDefinition
                            {
                            }
                        }
                    };
                }
                {
                    // 30. EvidenceVariable.characteristic.usageContext
                    this.Element_UsageContext = new ElementDefinitionInfo
                    {
                        Name = "Element_UsageContext",
                        Path= "EvidenceVariable.characteristic.usageContext",
                        Id = "EvidenceVariable.characteristic.usageContext",
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
                    // 31. EvidenceVariable.characteristic.exclude
                    this.Element_Exclude = new ElementDefinitionInfo
                    {
                        Name = "Element_Exclude",
                        Path= "EvidenceVariable.characteristic.exclude",
                        Id = "EvidenceVariable.characteristic.exclude",
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
                    // 32. EvidenceVariable.characteristic.participantEffective[x]
                    this.Element_ParticipantEffective = new ElementDefinitionInfo
                    {
                        Name = "Element_ParticipantEffective",
                        Path= "EvidenceVariable.characteristic.participantEffective[x]",
                        Id = "EvidenceVariable.characteristic.participantEffective[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Timing
                            {
                            }
                        }
                    };
                }
                {
                    // 33. EvidenceVariable.characteristic.timeFromStart
                    this.Element_TimeFromStart = new ElementDefinitionInfo
                    {
                        Name = "Element_TimeFromStart",
                        Path= "EvidenceVariable.characteristic.timeFromStart",
                        Id = "EvidenceVariable.characteristic.timeFromStart",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            }
                        }
                    };
                }
                {
                    // 34. EvidenceVariable.characteristic.groupMeasure
                    this.Element_GroupMeasure = new ElementDefinitionInfo
                    {
                        Name = "Element_GroupMeasure",
                        Path= "EvidenceVariable.characteristic.groupMeasure",
                        Id = "EvidenceVariable.characteristic.groupMeasure",
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
            }
        }
        // 1. EvidenceVariable.url
        public ElementDefinitionInfo Element_Url;
        // 2. EvidenceVariable.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. EvidenceVariable.version
        public ElementDefinitionInfo Element_Version;
        // 4. EvidenceVariable.name
        public ElementDefinitionInfo Element_Name;
        // 5. EvidenceVariable.title
        public ElementDefinitionInfo Element_Title;
        // 6. EvidenceVariable.shortTitle
        public ElementDefinitionInfo Element_ShortTitle;
        // 7. EvidenceVariable.subtitle
        public ElementDefinitionInfo Element_Subtitle;
        // 8. EvidenceVariable.status
        public ElementDefinitionInfo Element_Status;
        // 9. EvidenceVariable.date
        public ElementDefinitionInfo Element_Date;
        // 10. EvidenceVariable.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 11. EvidenceVariable.contact
        public ElementDefinitionInfo Element_Contact;
        // 12. EvidenceVariable.description
        public ElementDefinitionInfo Element_Description;
        // 13. EvidenceVariable.note
        public ElementDefinitionInfo Element_Note;
        // 14. EvidenceVariable.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 15. EvidenceVariable.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 16. EvidenceVariable.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 17. EvidenceVariable.approvalDate
        public ElementDefinitionInfo Element_ApprovalDate;
        // 18. EvidenceVariable.lastReviewDate
        public ElementDefinitionInfo Element_LastReviewDate;
        // 19. EvidenceVariable.effectivePeriod
        public ElementDefinitionInfo Element_EffectivePeriod;
        // 20. EvidenceVariable.topic
        public ElementDefinitionInfo Element_Topic;
        // 21. EvidenceVariable.author
        public ElementDefinitionInfo Element_Author;
        // 22. EvidenceVariable.editor
        public ElementDefinitionInfo Element_Editor;
        // 23. EvidenceVariable.reviewer
        public ElementDefinitionInfo Element_Reviewer;
        // 24. EvidenceVariable.endorser
        public ElementDefinitionInfo Element_Endorser;
        // 25. EvidenceVariable.relatedArtifact
        public ElementDefinitionInfo Element_RelatedArtifact;
        // 26. EvidenceVariable.type
        public ElementDefinitionInfo Element_Type;
        // 27. EvidenceVariable.characteristic
        public ElementDefinitionInfo Element_Characteristic;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "EvidenceVariable",
                ElementId = "EvidenceVariable"
            });
            Element_Url.Write(sDef);
            Element_Identifier.Write(sDef);
            Element_Version.Write(sDef);
            Element_Name.Write(sDef);
            Element_Title.Write(sDef);
            Element_ShortTitle.Write(sDef);
            Element_Subtitle.Write(sDef);
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
            Element_Type.Write(sDef);
            Element_Characteristic.Write(sDef);
        }
        
        public Resource_EvidenceVariable()
        {
            {
                // 1. EvidenceVariable.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "EvidenceVariable.url",
                    Id = "EvidenceVariable.url",
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
                // 2. EvidenceVariable.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "EvidenceVariable.identifier",
                    Id = "EvidenceVariable.identifier",
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
                // 3. EvidenceVariable.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "EvidenceVariable.version",
                    Id = "EvidenceVariable.version",
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
                // 4. EvidenceVariable.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "EvidenceVariable.name",
                    Id = "EvidenceVariable.name",
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
                // 5. EvidenceVariable.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "EvidenceVariable.title",
                    Id = "EvidenceVariable.title",
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
                // 6. EvidenceVariable.shortTitle
                this.Element_ShortTitle = new ElementDefinitionInfo
                {
                    Name = "Element_ShortTitle",
                    Path= "EvidenceVariable.shortTitle",
                    Id = "EvidenceVariable.shortTitle",
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
                // 7. EvidenceVariable.subtitle
                this.Element_Subtitle = new ElementDefinitionInfo
                {
                    Name = "Element_Subtitle",
                    Path= "EvidenceVariable.subtitle",
                    Id = "EvidenceVariable.subtitle",
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
                // 8. EvidenceVariable.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "EvidenceVariable.status",
                    Id = "EvidenceVariable.status",
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
                // 9. EvidenceVariable.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "EvidenceVariable.date",
                    Id = "EvidenceVariable.date",
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
                // 10. EvidenceVariable.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "EvidenceVariable.publisher",
                    Id = "EvidenceVariable.publisher",
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
                // 11. EvidenceVariable.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "EvidenceVariable.contact",
                    Id = "EvidenceVariable.contact",
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
                // 12. EvidenceVariable.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "EvidenceVariable.description",
                    Id = "EvidenceVariable.description",
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
                // 13. EvidenceVariable.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "EvidenceVariable.note",
                    Id = "EvidenceVariable.note",
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
                // 14. EvidenceVariable.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "EvidenceVariable.useContext",
                    Id = "EvidenceVariable.useContext",
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
                // 15. EvidenceVariable.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "EvidenceVariable.jurisdiction",
                    Id = "EvidenceVariable.jurisdiction",
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
                // 16. EvidenceVariable.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "EvidenceVariable.copyright",
                    Id = "EvidenceVariable.copyright",
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
                // 17. EvidenceVariable.approvalDate
                this.Element_ApprovalDate = new ElementDefinitionInfo
                {
                    Name = "Element_ApprovalDate",
                    Path= "EvidenceVariable.approvalDate",
                    Id = "EvidenceVariable.approvalDate",
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
                // 18. EvidenceVariable.lastReviewDate
                this.Element_LastReviewDate = new ElementDefinitionInfo
                {
                    Name = "Element_LastReviewDate",
                    Path= "EvidenceVariable.lastReviewDate",
                    Id = "EvidenceVariable.lastReviewDate",
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
                // 19. EvidenceVariable.effectivePeriod
                this.Element_EffectivePeriod = new ElementDefinitionInfo
                {
                    Name = "Element_EffectivePeriod",
                    Path= "EvidenceVariable.effectivePeriod",
                    Id = "EvidenceVariable.effectivePeriod",
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
                // 20. EvidenceVariable.topic
                this.Element_Topic = new ElementDefinitionInfo
                {
                    Name = "Element_Topic",
                    Path= "EvidenceVariable.topic",
                    Id = "EvidenceVariable.topic",
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
                // 21. EvidenceVariable.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "EvidenceVariable.author",
                    Id = "EvidenceVariable.author",
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
                // 22. EvidenceVariable.editor
                this.Element_Editor = new ElementDefinitionInfo
                {
                    Name = "Element_Editor",
                    Path= "EvidenceVariable.editor",
                    Id = "EvidenceVariable.editor",
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
                // 23. EvidenceVariable.reviewer
                this.Element_Reviewer = new ElementDefinitionInfo
                {
                    Name = "Element_Reviewer",
                    Path= "EvidenceVariable.reviewer",
                    Id = "EvidenceVariable.reviewer",
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
                // 24. EvidenceVariable.endorser
                this.Element_Endorser = new ElementDefinitionInfo
                {
                    Name = "Element_Endorser",
                    Path= "EvidenceVariable.endorser",
                    Id = "EvidenceVariable.endorser",
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
                // 25. EvidenceVariable.relatedArtifact
                this.Element_RelatedArtifact = new ElementDefinitionInfo
                {
                    Name = "Element_RelatedArtifact",
                    Path= "EvidenceVariable.relatedArtifact",
                    Id = "EvidenceVariable.relatedArtifact",
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
                // 26. EvidenceVariable.type
                this.Element_Type = new ElementDefinitionInfo
                {
                    Name = "Element_Type",
                    Path= "EvidenceVariable.type",
                    Id = "EvidenceVariable.type",
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
                // 27. EvidenceVariable.characteristic
                this.Element_Characteristic = new ElementDefinitionInfo
                {
                    Name = "Element_Characteristic",
                    Path= "EvidenceVariable.characteristic",
                    Id = "EvidenceVariable.characteristic",
                    Min = 1,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Characteristic
                        {
                        }
                    }
                };
            }
            this.Name = "EvidenceVariable";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/EvidenceVariable";
        }
    }
}
