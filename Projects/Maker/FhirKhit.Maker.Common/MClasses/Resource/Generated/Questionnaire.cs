using System;                                                                                                                               // MakerGen.cs:457
using System.Diagnostics;                                                                                                                   // MakerGen.cs:458
using System.IO;                                                                                                                            // MakerGen.cs:459
using System.Linq;                                                                                                                          // MakerGen.cs:460
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:461
                                                                                                                                            // MakerGen.cs:462
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:463
{                                                                                                                                           // MakerGen.cs:464
    #region Json                                                                                                                            // MakerGen.cs:465
    #if NEVER                                                                                                                               // MakerGen.cs:466
    {
      "resourceType": "StructureDefinition",
      "id": "Questionnaire",
      "url": "http://hl7.org/fhir/StructureDefinition/Questionnaire",
      "version": "4.0.0",
      "name": "Questionnaire",
      "status": "draft",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A structured set of questions intended to guide the collection of answers from end-users. Questionnaires provide detailed control over order, presentation, phraseology and grouping to allow coherent, consistent data collection.",
      "purpose": "To support structured, hierarchical registration of data gathered using digital forms and other questionnaires.  Questionnaires provide greater control over presentation and allow capture of data in a domain-independent way (i.e. capturing information that would otherwise require multiple distinct types of resources).",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "Questionnaire",
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
            "id": "Questionnaire",
            "path": "Questionnaire",
            "short": "A structured set of questions",
            "definition": "A structured set of questions intended to guide the collection of answers from end-users. Questionnaires provide detailed control over order, presentation, phraseology and grouping to allow coherent, consistent data collection.",
            "alias": [
              "Form",
              "CRF",
              "Survey"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "Questionnaire.url",
            "path": "Questionnaire.url",
            "short": "Canonical identifier for this questionnaire, represented as a URI (globally unique)",
            "definition": "An absolute URI that is used to identify this questionnaire when it is referenced in a specification, model, design or an instance; also called its canonical identifier. This SHOULD be globally unique and SHOULD be a literal address at which at which an authoritative instance of this questionnaire is (or will be) published. This URL can be the target of a canonical reference. It SHALL remain the same when the questionnaire is stored on different servers.",
            "comment": "The name of the referenced questionnaire can be conveyed using the http://hl7.org/fhir/StructureDefinition/display extension.",
            "requirements": "…  This is the id that will be used to link a QuestionnaireResponse to the Questionnaire the response is for.",
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
            "id": "Questionnaire.identifier",
            "path": "Questionnaire.identifier",
            "short": "Additional identifier for the questionnaire",
            "definition": "A formal identifier that is used to identify this questionnaire when it is represented in other formats, or referenced in a specification, model, design or an instance.",
            "comment": "Typically, this is used for identifiers that can go in an HL7 V3 II (instance identifier) data type, and can then identify this questionnaire outside of FHIR, where it is not possible to use the logical URI.",
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
            "id": "Questionnaire.version",
            "path": "Questionnaire.version",
            "short": "Business version of the questionnaire",
            "definition": "The identifier that is used to identify this version of the questionnaire when it is referenced in a specification, model, design or instance. This is an arbitrary value managed by the questionnaire author and is not expected to be globally unique. For example, it might be a timestamp (e.g. yyyymmdd) if a managed version is not available. There is also no expectation that versions can be placed in a lexicographical sequence.",
            "comment": "There may be different questionnaire instances that have the same identifier but different versions.  The version can be appended to the url in a reference to allow a reference to a particular business version of the questionnaire with the format [url]|[version].",
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
            "id": "Questionnaire.name",
            "path": "Questionnaire.name",
            "short": "Name for this questionnaire (computer friendly)",
            "definition": "A natural language name identifying the questionnaire. This name should be usable as an identifier for the module by machine processing applications such as code generation.",
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
            "id": "Questionnaire.title",
            "path": "Questionnaire.title",
            "short": "Name for this questionnaire (human friendly)",
            "definition": "A short, descriptive, user-friendly title for the questionnaire.",
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
            "id": "Questionnaire.derivedFrom",
            "path": "Questionnaire.derivedFrom",
            "short": "Instantiates protocol or definition",
            "definition": "The URL of a Questionnaire that this Questionnaire is based on.",
            "requirements": "Allows a Questionnaire to be created based on another Questionnaire.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Questionnaire"
                ]
              }
            ]
          },
          {
            "id": "Questionnaire.status",
            "path": "Questionnaire.status",
            "short": "draft | active | retired | unknown",
            "definition": "The status of this questionnaire. Enables tracking the life-cycle of the content.",
            "comment": "Allows filtering of questionnaires that are appropriate for use versus not.",
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
            "id": "Questionnaire.experimental",
            "path": "Questionnaire.experimental",
            "short": "For testing purposes, not real usage",
            "definition": "A Boolean value to indicate that this questionnaire is authored for testing purposes (or education/evaluation/marketing) and is not intended to be used for genuine usage.",
            "comment": "Allows filtering of questionnaires that are appropriate for use versus not.",
            "requirements": "Enables experimental content to be developed following the same lifecycle that would be used for a production-level questionnaire.",
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
            "id": "Questionnaire.subjectType",
            "path": "Questionnaire.subjectType",
            "short": "Resource that can be subject of QuestionnaireResponse",
            "definition": "The types of subjects that can be the subject of responses created for the questionnaire.",
            "comment": "If none are specified, then the subject is unlimited.",
            "min": 0,
            "max": "*",
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
                  "valueString": "ResourceType"
                },
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-isCommonBinding",
                  "valueBoolean": true
                }
              ],
              "strength": "required",
              "description": "One of the resource types defined as part of this version of FHIR.",
              "valueSet": "http://hl7.org/fhir/ValueSet/resource-types|4.0.0"
            }
          },
          {
            "id": "Questionnaire.date",
            "path": "Questionnaire.date",
            "short": "Date last changed",
            "definition": "The date  (and optionally time) when the questionnaire was published. The date must change when the business version changes and it must change if the status code changes. In addition, it should change when the substantive content of the questionnaire changes.",
            "comment": "Note that this is not the same as the resource last-modified-date, since the resource may be a secondary representation of the questionnaire. Additional specific dates may be added as extensions or be found by consulting Provenances associated with past versions of the resource.",
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
            "id": "Questionnaire.publisher",
            "path": "Questionnaire.publisher",
            "short": "Name of the publisher (organization or individual)",
            "definition": "The name of the organization or individual that published the questionnaire.",
            "comment": "Usually an organization but may be an individual. The publisher (or steward) of the questionnaire is the organization or individual primarily responsible for the maintenance and upkeep of the questionnaire. This is not necessarily the same individual or organization that developed and initially authored the content. The publisher is the primary point of contact for questions or issues with the questionnaire. This item SHOULD be populated unless the information is available from context.",
            "requirements": "Helps establish the \"authority/credibility\" of the questionnaire.  May also allow for contact.",
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
            "id": "Questionnaire.contact",
            "path": "Questionnaire.contact",
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
            "id": "Questionnaire.description",
            "path": "Questionnaire.description",
            "short": "Natural language description of the questionnaire",
            "definition": "A free text natural language description of the questionnaire from a consumer's perspective.",
            "comment": "This description can be used to capture details such as why the questionnaire was built, comments about misuse, instructions for clinical use and interpretation, literature references, examples from the paper world, etc. It is not a rendering of the questionnaire as conveyed in the 'text' field of the resource itself. This item SHOULD be populated unless the information is available from context (e.g. the language of the questionnaire is presumed to be the predominant language in the place the questionnaire was created).",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "Questionnaire.useContext",
            "path": "Questionnaire.useContext",
            "short": "The context that the content is intended to support",
            "definition": "The content was developed with a focus and intent of supporting the contexts that are listed. These contexts may be general categories (gender, age, ...) or may be references to specific programs (insurance plans, studies, ...) and may be used to assist with indexing and searching for appropriate questionnaire instances.",
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
            "id": "Questionnaire.jurisdiction",
            "path": "Questionnaire.jurisdiction",
            "short": "Intended jurisdiction for questionnaire (if applicable)",
            "definition": "A legal or geographic region in which the questionnaire is intended to be used.",
            "comment": "It may be possible for the questionnaire to be used in jurisdictions other than those for which it was originally designed or intended.",
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
            "id": "Questionnaire.purpose",
            "path": "Questionnaire.purpose",
            "short": "Why this questionnaire is defined",
            "definition": "Explanation of why this questionnaire is needed and why it has been designed as it has.",
            "comment": "This element does not describe the usage of the questionnaire. Instead, it provides traceability of ''why'' the resource is either needed or ''why'' it is defined as it is.  This may be used to point to source materials or specifications that drove the structure of this questionnaire.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "markdown"
              }
            ]
          },
          {
            "id": "Questionnaire.copyright",
            "path": "Questionnaire.copyright",
            "short": "Use and/or publishing restrictions",
            "definition": "A copyright statement relating to the questionnaire and/or its contents. Copyright statements are generally legal restrictions on the use and publishing of the questionnaire.",
            "requirements": "Consumers must be able to determine any legal restrictions on the use of the questionnaire and/or its content.",
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
            "id": "Questionnaire.approvalDate",
            "path": "Questionnaire.approvalDate",
            "short": "When the questionnaire was approved by publisher",
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
            "id": "Questionnaire.lastReviewDate",
            "path": "Questionnaire.lastReviewDate",
            "short": "When the questionnaire was last reviewed",
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
            "id": "Questionnaire.effectivePeriod",
            "path": "Questionnaire.effectivePeriod",
            "short": "When the questionnaire is expected to be used",
            "definition": "The period during which the questionnaire content was or is planned to be in active use.",
            "comment": "The effective period for a questionnaire  determines when the content is applicable for usage and is independent of publication and review dates. For example, a measure intended to be used for the year 2016 might be published in 2015.",
            "requirements": "Allows establishing a transition before a resource comes into effect and also allows for a sunsetting  process when new versions of the questionnaire are or are expected to be used instead.",
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
            "id": "Questionnaire.code",
            "path": "Questionnaire.code",
            "short": "Concept that represents the overall questionnaire",
            "definition": "An identifier for this question or group of questions in a particular terminology such as LOINC.",
            "requirements": "Allows linking of the complete Questionnaire resources to formal terminologies.  It's common for \"panels\" of questions to be identified by a code.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "QuestionnaireConcept"
                }
              ],
              "strength": "example",
              "description": "Codes for questionnaires, groups and individual questions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/questionnaire-questions"
            }
          },
          {
            "id": "Questionnaire.item",
            "path": "Questionnaire.item",
            "short": "Questions and sections within the Questionnaire",
            "definition": "A particular question, question grouping or display text that is part of the questionnaire.",
            "comment": "The content of the questionnaire is constructed from an ordered, hierarchical collection of items.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "que-3"
            ]
          },
          {
            "id": "Questionnaire.item.linkId",
            "path": "Questionnaire.item.linkId",
            "short": "Unique id for item in questionnaire",
            "definition": "An identifier that is unique within the Questionnaire allowing linkage to the equivalent item in a QuestionnaireResponse resource.",
            "comment": "This ''can'' be a meaningful identifier (e.g. a LOINC code) but is not intended to have any meaning.  GUIDs or sequential numbers are appropriate here.",
            "requirements": "[QuestionnaireResponse](questionnaireresponse.html#) does not require omitted items to be included and may have some items that repeat, so linkage based on position alone is not sufficient.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Questionnaire.item.definition",
            "path": "Questionnaire.item.definition",
            "short": "ElementDefinition - details for the item",
            "definition": "This element is a URI that refers to an [ElementDefinition](elementdefinition.html) that provides information about this item, including information that might otherwise be included in the instance of the Questionnaire resource. A detailed description of the construction of the URI is shown in Comments, below. If this element is present then the following element values MAY be derived from the Element Definition if the corresponding elements of this Questionnaire resource instance have no value:\n\n* code (ElementDefinition.code) \n* type (ElementDefinition.type) \n* required (ElementDefinition.min) \n* repeats (ElementDefinition.max) \n* maxLength (ElementDefinition.maxLength) \n* answerValueSet (ElementDefinition.binding)\n* options (ElementDefinition.binding).",
            "comment": "The uri refers to an ElementDefinition in a [StructureDefinition](structuredefinition.html#) and always starts with the [canonical URL](references.html#canonical) for the target resource. When referring to a StructureDefinition, a fragment identifier is used to specify the element definition by its id [Element.id](element-definitions.html#Element.id). E.g. http://hl7.org/fhir/StructureDefinition/Observation#Observation.value[x]. In the absence of a fragment identifier, the first/root element definition in the target is the matching element definition.",
            "requirements": "A common pattern is to define a set of data elements and then build multiple questionnaires for different circumstances to gather the data. This element provides traceability to the common definition and allows the content for the question to come from the underlying definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "Questionnaire.item.code",
            "path": "Questionnaire.item.code",
            "short": "Corresponding concept for this item in a terminology",
            "definition": "A terminology code that corresponds to this group or question (e.g. a code from LOINC, which defines many questions and answers).",
            "comment": "The value may come from the ElementDefinition referred to by .definition.",
            "requirements": "Allows linking of groups of questions to formal terminologies.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Coding"
              }
            ],
            "condition": [
              "que-3"
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "QuestionnaireConcept"
                }
              ],
              "strength": "example",
              "description": "Codes for questionnaires, groups and individual questions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/questionnaire-questions"
            }
          },
          {
            "id": "Questionnaire.item.prefix",
            "path": "Questionnaire.item.prefix",
            "short": "E.g. \"1(a)\", \"2.5.3\"",
            "definition": "A short label for a particular group, question or set of display text within the questionnaire used for reference by the individual completing the questionnaire.",
            "comment": "These are generally unique within a questionnaire, though this is not guaranteed. Some questionnaires may have multiple questions with the same label with logic to control which gets exposed.  Typically, these won't be used for \"display\" items, though such use is not prohibited.  Systems SHOULD NOT generate their own prefixes if prefixes are defined for any items within a Questionnaire.",
            "requirements": "Separating the label from the question text allows improved rendering.  Also, instructions will often refer to specific prefixes, so there's a need for the questionnaire design to have control over what labels are used.",
            "alias": [
              "label"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Questionnaire.item.text",
            "path": "Questionnaire.item.text",
            "short": "Primary text for the item",
            "definition": "The name of a section, the text of a question or text content for a display item.",
            "comment": "When using this element to represent the name of a section, use group type item and also make sure to limit the text element to a short string suitable for display as a section heading.  Group item instructions should be included as a display type item within the group.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Questionnaire.item.type",
            "path": "Questionnaire.item.type",
            "short": "group | display | boolean | decimal | integer | date | dateTime +",
            "definition": "The type of questionnaire item this is - whether text for display, a grouping of other items or a particular type of data to be captured (string, integer, coded choice, etc.).",
            "comment": "Additional constraints on the type of answer can be conveyed by extensions. The value may come from the ElementDefinition referred to by .definition.",
            "requirements": "Defines the format in which the user is to be prompted for the answer.",
            "min": 1,
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
                  "valueString": "QuestionnaireItemType"
                }
              ],
              "strength": "required",
              "description": "Distinguishes groups from questions and display text and indicates data type for questions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/item-type|4.0.0"
            }
          },
          {
            "id": "Questionnaire.item.enableWhen",
            "path": "Questionnaire.item.enableWhen",
            "short": "Only allow data when",
            "definition": "A constraint indicating that this item should only be enabled (displayed/allow answers to be captured) when the specified condition is true.",
            "comment": "If multiple repetitions of this extension are present, the item should be enabled when the condition for *any* of the repetitions is true.  I.e. treat \"enableWhen\"s as being joined by an \"or\" clause.  This element is a modifier because if enableWhen is present for an item, \"required\" is ignored unless one of the enableWhen conditions is met. When an item is disabled, all of its descendants are disabled, regardless of what their own enableWhen logic might evaluate to.",
            "requirements": "Allows questionnaires to adapt based on answers to other questions. E.g. If physical gender is specified as a male, no need to capture pregnancy history.  Also allows conditional display of instructions or groups of questions.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "isModifier": true,
            "isModifierReason": "If enableWhen is present and the condition evaluates to false, then the Questionnaire behaves as though the elements weren't actually present"
          },
          {
            "id": "Questionnaire.item.enableWhen.question",
            "path": "Questionnaire.item.enableWhen.question",
            "short": "Question that determines whether item is enabled",
            "definition": "The linkId for the question whose answer (or lack of answer) governs whether this item is enabled.",
            "comment": "If multiple question occurrences are present for the same question (same linkId), then this refers to the nearest question occurrence reachable by tracing first the \"ancestor\" axis and then the \"preceding\" axis and then the \"following\" axis.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "Questionnaire.item.enableWhen.operator",
            "path": "Questionnaire.item.enableWhen.operator",
            "short": "exists | = | != | > | < | >= | <=",
            "definition": "Specifies the criteria by which the question is enabled.",
            "min": 1,
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
                  "valueString": "QuestionnaireItemOperator"
                }
              ],
              "strength": "required",
              "description": "The criteria by which a question is enabled.",
              "valueSet": "http://hl7.org/fhir/ValueSet/questionnaire-enable-operator|4.0.0"
            }
          },
          {
            "id": "Questionnaire.item.enableWhen.answer[x]",
            "path": "Questionnaire.item.enableWhen.answer[x]",
            "short": "Value for question comparison based on operator",
            "definition": "A value that the referenced question is tested using the specified operator in order for the item to be enabled.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              },
              {
                "code": "decimal"
              },
              {
                "code": "integer"
              },
              {
                "code": "date"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "time"
              },
              {
                "code": "string"
              },
              {
                "code": "Coding"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "condition": [
              "que-7"
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "QuestionnaireQuestionOption3"
                }
              ],
              "strength": "example",
              "description": "Allowed values to answer questions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/questionnaire-answers"
            }
          },
          {
            "id": "Questionnaire.item.enableBehavior",
            "path": "Questionnaire.item.enableBehavior",
            "short": "all | any",
            "definition": "Controls how multiple enableWhen values are interpreted -  whether all or any must be true.",
            "comment": "This element must be specified if more than one enableWhen value is provided.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "condition": [
              "que-12"
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "EnableWhenBehavior"
                }
              ],
              "strength": "required",
              "description": "Controls how multiple enableWhen values are interpreted -  whether all or any must be true.",
              "valueSet": "http://hl7.org/fhir/ValueSet/questionnaire-enable-behavior|4.0.0"
            }
          },
          {
            "id": "Questionnaire.item.required",
            "path": "Questionnaire.item.required",
            "short": "Whether the item must be included in data results",
            "definition": "An indication, if true, that the item must be present in a \"completed\" QuestionnaireResponse.  If false, the item may be skipped when answering the questionnaire.",
            "comment": "Questionnaire.item.required only has meaning for elements that are conditionally enabled with enableWhen if the condition evaluates to true.  If an item that contains other items is marked as required, that does not automatically make the contained elements required (though required groups must contain at least one child element). The value may come from the ElementDefinition referred to by .definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "Items are generally assumed not to be required unless explicitly specified. Systems SHOULD always populate this value",
            "condition": [
              "que-6"
            ]
          },
          {
            "id": "Questionnaire.item.repeats",
            "path": "Questionnaire.item.repeats",
            "short": "Whether the item may repeat",
            "definition": "An indication, if true, that the item may occur multiple times in the response, collecting multiple answers for questions or multiple sets of answers for groups.",
            "comment": "If a question is marked as repeats=true, then multiple answers can be provided for the question in the corresponding QuestionnaireResponse.  When rendering the questionnaire, it is up to the rendering software whether to render the question text for each answer repetition (i.e. \"repeat the question\") or to simply allow entry/selection of multiple answers for the question (repeat the answers).  Which is most appropriate visually may depend on the type of answer as well as whether there are nested items.\n\nThe resulting QuestionnaireResponse will be populated the same way regardless of rendering - one 'question' item with multiple answer values.\n\n The value may come from the ElementDefinition referred to by .definition.",
            "requirements": "Items may be used to create set of (related) questions that can be repeated to give multiple answers to such a set.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "Items are generally assumed not to repeat unless explicitly specified. Systems SHOULD always populate this value",
            "condition": [
              "que-6"
            ]
          },
          {
            "id": "Questionnaire.item.readOnly",
            "path": "Questionnaire.item.readOnly",
            "short": "Don't allow human editing",
            "definition": "An indication, when true, that the value cannot be changed by a human respondent to the Questionnaire.",
            "comment": "The value of readOnly elements can be established by asserting  extensions for defaultValues, linkages that support pre-population and/or extensions that support calculation based on other answers.",
            "requirements": "Allows certain information to be phrased (and rendered) as a question and an answer, while keeping users from changing it.  May also be useful for preventing changes to pre-populated portions of a questionnaire, for calculated values, etc.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "condition": [
              "que-9"
            ]
          },
          {
            "id": "Questionnaire.item.maxLength",
            "path": "Questionnaire.item.maxLength",
            "short": "No more than this many characters",
            "definition": "The maximum number of characters that are permitted in the answer to be considered a \"valid\" QuestionnaireResponse.",
            "comment": "For base64binary, reflects the number of characters representing the encoded data, not the number of bytes of the binary data. The value may come from the ElementDefinition referred to by .definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "integer"
              }
            ],
            "condition": [
              "que-10"
            ]
          },
          {
            "id": "Questionnaire.item.answerValueSet",
            "path": "Questionnaire.item.answerValueSet",
            "short": "Valueset containing permitted answers",
            "definition": "A reference to a value set containing a list of codes representing permitted answers for a \"choice\" or \"open-choice\" question.",
            "comment": "LOINC defines many useful value sets for questionnaire responses. See [LOINC Answer Lists](loinc.html#alist). The value may come from the ElementDefinition referred to by .definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/ValueSet"
                ]
              }
            ],
            "condition": [
              "que-4",
              "que-5"
            ]
          },
          {
            "id": "Questionnaire.item.answerOption",
            "path": "Questionnaire.item.answerOption",
            "short": "Permitted answer",
            "definition": "One of the permitted answers for a \"choice\" or \"open-choice\" question.",
            "comment": "This element can be used when the value set machinery of answerValueSet is deemed too cumbersome or when there's a need to capture possible answers that are not codes.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "que-4",
              "que-5"
            ]
          },
          {
            "id": "Questionnaire.item.answerOption.value[x]",
            "path": "Questionnaire.item.answerOption.value[x]",
            "short": "Answer value",
            "definition": "A potential answer that's allowed as the answer to this question.",
            "comment": "The data type of the value must agree with the item.type.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "integer"
              },
              {
                "code": "date"
              },
              {
                "code": "time"
              },
              {
                "code": "string"
              },
              {
                "code": "Coding"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "QuestionnaireQuestionOption"
                }
              ],
              "strength": "example",
              "description": "Allowed values to answer questions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/questionnaire-answers"
            }
          },
          {
            "id": "Questionnaire.item.answerOption.initialSelected",
            "path": "Questionnaire.item.answerOption.initialSelected",
            "short": "Whether option is selected by default",
            "definition": "Indicates whether the answer value is selected when the list of possible answers is initially shown.",
            "comment": "Use this instead of initial[v] if answerValueSet is present.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              }
            ],
            "meaningWhenMissing": "Only selected items explicitly marked to be selected"
          },
          {
            "id": "Questionnaire.item.initial",
            "path": "Questionnaire.item.initial",
            "short": "Initial value(s) when item is first rendered",
            "definition": "One or more values that should be pre-populated in the answer when initially rendering the questionnaire for user input.",
            "comment": "The user is allowed to change the value and override the default (unless marked as read-only). If the user doesn't change the value, then this initial value will be persisted when the QuestionnaireResponse is initially created.  Note that initial values can influence results.  The data type of initial[x] must agree with the item.type, and only repeating items can have more then one initial value.",
            "requirements": "In some workflows, having defaults saves time.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ],
            "condition": [
              "que-8",
              "que-13"
            ]
          },
          {
            "id": "Questionnaire.item.initial.value[x]",
            "path": "Questionnaire.item.initial.value[x]",
            "short": "Actual value for initializing the question",
            "definition": "The actual value to for an initial answer.",
            "comment": "The type of the initial value must be consistent with the type of the item.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "boolean"
              },
              {
                "code": "decimal"
              },
              {
                "code": "integer"
              },
              {
                "code": "date"
              },
              {
                "code": "dateTime"
              },
              {
                "code": "time"
              },
              {
                "code": "string"
              },
              {
                "code": "uri"
              },
              {
                "code": "Attachment"
              },
              {
                "code": "Coding"
              },
              {
                "code": "Quantity"
              },
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "QuestionnaireQuestionOption2"
                }
              ],
              "strength": "example",
              "description": "Allowed values to answer questions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/questionnaire-answers"
            }
          },
          {
            "id": "Questionnaire.item.item",
            "path": "Questionnaire.item.item",
            "short": "Nested questionnaire items",
            "definition": "Text, questions and other groups to be nested beneath a question or group.",
            "comment": "There is no specified limit to the depth of nesting.  However, Questionnaire authors are encouraged to consider the impact on the user and user interface of overly deep nesting.",
            "requirements": "Reports can consist of complex nested groups.",
            "min": 0,
            "max": "*",
            "contentReference": "#Questionnaire.item",
            "condition": [
              "que-1"
            ]
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:469
    /// <summary>
    /// Fhir resource 'Questionnaire'
    /// </summary>
    // 0. Questionnaire
    public class Questionnaire : FhirKhit.Maker.Common.Resource.ResourceBase                                                                // MakerGen.cs:379
    {                                                                                                                                       // MakerGen.cs:380
        public class Questionnaire_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                   // MakerGen.cs:381
        {                                                                                                                                   // MakerGen.cs:382
            // 22. Questionnaire.item
            public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:379
            {                                                                                                                               // MakerGen.cs:380
                public class Type_Item_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:381
                {                                                                                                                           // MakerGen.cs:382
                    // 29. Questionnaire.item.enableWhen
                    public class Type_EnableWhen : FhirKhit.Maker.Common.Complex.ComplexBase                                                // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_EnableWhen_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                 // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 30. Questionnaire.item.enableWhen.question
                            public ElementDefinitionInfo Question;                                                                          // MakerGen.cs:211
                            // 31. Questionnaire.item.enableWhen.operator
                            public ElementDefinitionInfo Operator;                                                                          // MakerGen.cs:211
                            // 32. Questionnaire.item.enableWhen.answer[x]
                            public ElementDefinitionInfo Answer;                                                                            // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_EnableWhen_Elements()                                                                               // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 30. Questionnaire.item.enableWhen.question
                                    this.Question = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Question",                                                                                  // MakerGen.cs:230
                                        Path= "Questionnaire.item.enableWhen.question",                                                     // MakerGen.cs:231
                                        Id = "Questionnaire.item.enableWhen.question",                                                      // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 31. Questionnaire.item.enableWhen.operator
                                    this.Operator = new ElementDefinitionInfo                                                               // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Operator",                                                                                  // MakerGen.cs:230
                                        Path= "Questionnaire.item.enableWhen.operator",                                                     // MakerGen.cs:231
                                        Id = "Questionnaire.item.enableWhen.operator",                                                      // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 32. Questionnaire.item.enableWhen.answer[x]
                                    this.Answer = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Answer",                                                                                    // MakerGen.cs:230
                                        Path= "Questionnaire.item.enableWhen.answer[x]",                                                    // MakerGen.cs:231
                                        Id = "Questionnaire.item.enableWhen.answer[x]",                                                     // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.Date                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.DateTime                                                    // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.Time                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Complex.Coding                                                        // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            },                                                                                              // MakerGen.cs:314
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            },                                                                                              // MakerGen.cs:355
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:341
                                            {                                                                                               // MakerGen.cs:342
                                                TargetProfile = new String[]                                                                // MakerGen.cs:344
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                      // MakerGen.cs:344
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:345
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Question.Write(sDef);                                                                                       // MakerGen.cs:215
                                Operator.Write(sDef);                                                                                       // MakerGen.cs:215
                                Answer.Write(sDef);                                                                                         // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_EnableWhen_Elements Elements                                                                            // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_EnableWhen_Elements();                                                         // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_EnableWhen_Elements elements;                                                                                  // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_EnableWhen()                                                                                            // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "Questionnaire.item.enableWhen",                                                                     // MakerGen.cs:423
                                ElementId = "Questionnaire.item.enableWhen"                                                                 // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 39. Questionnaire.item.answerOption
                    public class Type_AnswerOption : FhirKhit.Maker.Common.Complex.ComplexBase                                              // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_AnswerOption_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                               // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 40. Questionnaire.item.answerOption.value[x]
                            public ElementDefinitionInfo Value;                                                                             // MakerGen.cs:211
                            // 41. Questionnaire.item.answerOption.initialSelected
                            public ElementDefinitionInfo InitialSelected;                                                                   // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_AnswerOption_Elements()                                                                             // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 40. Questionnaire.item.answerOption.value[x]
                                    this.Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Value",                                                                                     // MakerGen.cs:230
                                        Path= "Questionnaire.item.answerOption.value[x]",                                                   // MakerGen.cs:231
                                        Id = "Questionnaire.item.answerOption.value[x]",                                                    // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.Date                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.Time                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Complex.Coding                                                        // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            },                                                                                              // MakerGen.cs:314
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:341
                                            {                                                                                               // MakerGen.cs:342
                                                TargetProfile = new String[]                                                                // MakerGen.cs:344
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                      // MakerGen.cs:344
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:345
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                                {                                                                                                           // MakerGen.cs:226
                                    // 41. Questionnaire.item.answerOption.initialSelected
                                    this.InitialSelected = new ElementDefinitionInfo                                                        // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "InitialSelected",                                                                           // MakerGen.cs:230
                                        Path= "Questionnaire.item.answerOption.initialSelected",                                            // MakerGen.cs:231
                                        Id = "Questionnaire.item.answerOption.initialSelected",                                             // MakerGen.cs:232
                                        Min = 0,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            }                                                                                               // MakerGen.cs:299
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Value.Write(sDef);                                                                                          // MakerGen.cs:215
                                InitialSelected.Write(sDef);                                                                                // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_AnswerOption_Elements Elements                                                                          // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_AnswerOption_Elements();                                                       // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_AnswerOption_Elements elements;                                                                                // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_AnswerOption()                                                                                          // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "Questionnaire.item.answerOption",                                                                   // MakerGen.cs:423
                                ElementId = "Questionnaire.item.answerOption"                                                               // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 42. Questionnaire.item.initial
                    public class Type_Initial : FhirKhit.Maker.Common.Complex.ComplexBase                                                   // MakerGen.cs:379
                    {                                                                                                                       // MakerGen.cs:380
                        public class Type_Initial_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                    // MakerGen.cs:381
                        {                                                                                                                   // MakerGen.cs:382
                            // 43. Questionnaire.item.initial.value[x]
                            public ElementDefinitionInfo Value;                                                                             // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                            public Type_Initial_Elements()                                                                                  // MakerGen.cs:387
                            {                                                                                                               // MakerGen.cs:388
                                {                                                                                                           // MakerGen.cs:226
                                    // 43. Questionnaire.item.initial.value[x]
                                    this.Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:228
                                    {                                                                                                       // MakerGen.cs:229
                                        Name = "Value",                                                                                     // MakerGen.cs:230
                                        Path= "Questionnaire.item.initial.value[x]",                                                        // MakerGen.cs:231
                                        Id = "Questionnaire.item.initial.value[x]",                                                         // MakerGen.cs:232
                                        Min = 1,                                                                                            // MakerGen.cs:233
                                        Max = 1,                                                                                            // MakerGen.cs:234
                                        Types = new BaseType[]                                                                              // MakerGen.cs:235
                                        {                                                                                                   // MakerGen.cs:236
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.Date                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.DateTime                                                    // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.Time                                                        // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Primitive.Uri                                                         // MakerGen.cs:295
                                            {                                                                                               // MakerGen.cs:296
                                            },                                                                                              // MakerGen.cs:299
                                            new FhirKhit.Maker.Common.Complex.Attachment                                                    // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            },                                                                                              // MakerGen.cs:355
                                            new FhirKhit.Maker.Common.Complex.Coding                                                        // MakerGen.cs:310
                                            {                                                                                               // MakerGen.cs:311
                                            },                                                                                              // MakerGen.cs:314
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:353
                                            {                                                                                               // MakerGen.cs:354
                                            },                                                                                              // MakerGen.cs:355
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:341
                                            {                                                                                               // MakerGen.cs:342
                                                TargetProfile = new String[]                                                                // MakerGen.cs:344
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                      // MakerGen.cs:344
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:345
                                        }                                                                                                   // MakerGen.cs:238
                                    };                                                                                                      // MakerGen.cs:239
                                }                                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:393
                            {                                                                                                               // MakerGen.cs:394
                                base.Write(sDef);                                                                                           // MakerGen.cs:395
                                Value.Write(sDef);                                                                                          // MakerGen.cs:215
                            }                                                                                                               // MakerGen.cs:397
                        }                                                                                                                   // MakerGen.cs:399
                        public Type_Initial_Elements Elements                                                                               // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            get                                                                                                             // MakerGen.cs:403
                            {                                                                                                               // MakerGen.cs:404
                                if (this.elements == null)                                                                                  // MakerGen.cs:405
                                    this.elements = new Type_Initial_Elements();                                                            // MakerGen.cs:406
                                return this.elements;                                                                                       // MakerGen.cs:407
                            }                                                                                                               // MakerGen.cs:408
                        }                                                                                                                   // MakerGen.cs:409
                        Type_Initial_Elements elements;                                                                                     // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                        public Type_Initial()                                                                                               // MakerGen.cs:413
                        {                                                                                                                   // MakerGen.cs:414
                        }                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:419
                        {                                                                                                                   // MakerGen.cs:420
                            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                              // MakerGen.cs:421
                            {                                                                                                               // MakerGen.cs:422
                                Path = "Questionnaire.item.initial",                                                                        // MakerGen.cs:423
                                ElementId = "Questionnaire.item.initial"                                                                    // MakerGen.cs:424
                            });                                                                                                             // MakerGen.cs:425
                            if (this.elements != null)                                                                                      // MakerGen.cs:426
                                this.elements.Write(sDef);                                                                                  // MakerGen.cs:427
                        }                                                                                                                   // MakerGen.cs:428
                    }                                                                                                                       // MakerGen.cs:429
                    // 23. Questionnaire.item.linkId
                    public ElementDefinitionInfo LinkId;                                                                                    // MakerGen.cs:211
                    // 24. Questionnaire.item.definition
                    public ElementDefinitionInfo Definition;                                                                                // MakerGen.cs:211
                    // 25. Questionnaire.item.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:211
                    // 26. Questionnaire.item.prefix
                    public ElementDefinitionInfo Prefix;                                                                                    // MakerGen.cs:211
                    // 27. Questionnaire.item.text
                    public ElementDefinitionInfo Text;                                                                                      // MakerGen.cs:211
                    // 28. Questionnaire.item.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:211
                    // 29. Questionnaire.item.enableWhen
                    public ElementDefinitionInfo EnableWhen;                                                                                // MakerGen.cs:211
                    // 33. Questionnaire.item.enableBehavior
                    public ElementDefinitionInfo EnableBehavior;                                                                            // MakerGen.cs:211
                    // 34. Questionnaire.item.required
                    public ElementDefinitionInfo Required;                                                                                  // MakerGen.cs:211
                    // 35. Questionnaire.item.repeats
                    public ElementDefinitionInfo Repeats;                                                                                   // MakerGen.cs:211
                    // 36. Questionnaire.item.readOnly
                    public ElementDefinitionInfo ReadOnly;                                                                                  // MakerGen.cs:211
                    // 37. Questionnaire.item.maxLength
                    public ElementDefinitionInfo MaxLength;                                                                                 // MakerGen.cs:211
                    // 38. Questionnaire.item.answerValueSet
                    public ElementDefinitionInfo AnswerValueSet;                                                                            // MakerGen.cs:211
                    // 39. Questionnaire.item.answerOption
                    public ElementDefinitionInfo AnswerOption;                                                                              // MakerGen.cs:211
                    // 42. Questionnaire.item.initial
                    public ElementDefinitionInfo Initial;                                                                                   // MakerGen.cs:211
                    // 44. Questionnaire.item.item
                    public ElementDefinitionInfo Item;                                                                                      // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
                    public Type_Item_Elements()                                                                                             // MakerGen.cs:387
                    {                                                                                                                       // MakerGen.cs:388
                        {                                                                                                                   // MakerGen.cs:226
                            // 23. Questionnaire.item.linkId
                            this.LinkId = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "LinkId",                                                                                            // MakerGen.cs:230
                                Path= "Questionnaire.item.linkId",                                                                          // MakerGen.cs:231
                                Id = "Questionnaire.item.linkId",                                                                           // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 24. Questionnaire.item.definition
                            this.Definition = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Definition",                                                                                        // MakerGen.cs:230
                                Path= "Questionnaire.item.definition",                                                                      // MakerGen.cs:231
                                Id = "Questionnaire.item.definition",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 25. Questionnaire.item.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Code",                                                                                              // MakerGen.cs:230
                                Path= "Questionnaire.item.code",                                                                            // MakerGen.cs:231
                                Id = "Questionnaire.item.code",                                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Complex.Coding                                                                // MakerGen.cs:310
                                    {                                                                                                       // MakerGen.cs:311
                                    }                                                                                                       // MakerGen.cs:314
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 26. Questionnaire.item.prefix
                            this.Prefix = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Prefix",                                                                                            // MakerGen.cs:230
                                Path= "Questionnaire.item.prefix",                                                                          // MakerGen.cs:231
                                Id = "Questionnaire.item.prefix",                                                                           // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 27. Questionnaire.item.text
                            this.Text = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Text",                                                                                              // MakerGen.cs:230
                                Path= "Questionnaire.item.text",                                                                            // MakerGen.cs:231
                                Id = "Questionnaire.item.text",                                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 28. Questionnaire.item.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Type",                                                                                              // MakerGen.cs:230
                                Path= "Questionnaire.item.type",                                                                            // MakerGen.cs:231
                                Id = "Questionnaire.item.type",                                                                             // MakerGen.cs:232
                                Min = 1,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 29. Questionnaire.item.enableWhen
                            this.EnableWhen = new ElementDefinitionInfo                                                                     // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "EnableWhen",                                                                                        // MakerGen.cs:230
                                Path= "Questionnaire.item.enableWhen",                                                                      // MakerGen.cs:231
                                Id = "Questionnaire.item.enableWhen",                                                                       // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_EnableWhen                                                                                     // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 33. Questionnaire.item.enableBehavior
                            this.EnableBehavior = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "EnableBehavior",                                                                                    // MakerGen.cs:230
                                Path= "Questionnaire.item.enableBehavior",                                                                  // MakerGen.cs:231
                                Id = "Questionnaire.item.enableBehavior",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 34. Questionnaire.item.required
                            this.Required = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Required",                                                                                          // MakerGen.cs:230
                                Path= "Questionnaire.item.required",                                                                        // MakerGen.cs:231
                                Id = "Questionnaire.item.required",                                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 35. Questionnaire.item.repeats
                            this.Repeats = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Repeats",                                                                                           // MakerGen.cs:230
                                Path= "Questionnaire.item.repeats",                                                                         // MakerGen.cs:231
                                Id = "Questionnaire.item.repeats",                                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 36. Questionnaire.item.readOnly
                            this.ReadOnly = new ElementDefinitionInfo                                                                       // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "ReadOnly",                                                                                          // MakerGen.cs:230
                                Path= "Questionnaire.item.readOnly",                                                                        // MakerGen.cs:231
                                Id = "Questionnaire.item.readOnly",                                                                         // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Boolean                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 37. Questionnaire.item.maxLength
                            this.MaxLength = new ElementDefinitionInfo                                                                      // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "MaxLength",                                                                                         // MakerGen.cs:230
                                Path= "Questionnaire.item.maxLength",                                                                       // MakerGen.cs:231
                                Id = "Questionnaire.item.maxLength",                                                                        // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Integer                                                             // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 38. Questionnaire.item.answerValueSet
                            this.AnswerValueSet = new ElementDefinitionInfo                                                                 // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "AnswerValueSet",                                                                                    // MakerGen.cs:230
                                Path= "Questionnaire.item.answerValueSet",                                                                  // MakerGen.cs:231
                                Id = "Questionnaire.item.answerValueSet",                                                                   // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = 1,                                                                                                    // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new FhirKhit.Maker.Common.Primitive.Canonical                                                           // MakerGen.cs:295
                                    {                                                                                                       // MakerGen.cs:296
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:298
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/ValueSet"                                              // MakerGen.cs:298
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:299
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 39. Questionnaire.item.answerOption
                            this.AnswerOption = new ElementDefinitionInfo                                                                   // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "AnswerOption",                                                                                      // MakerGen.cs:230
                                Path= "Questionnaire.item.answerOption",                                                                    // MakerGen.cs:231
                                Id = "Questionnaire.item.answerOption",                                                                     // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_AnswerOption                                                                                   // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 42. Questionnaire.item.initial
                            this.Initial = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Initial",                                                                                           // MakerGen.cs:230
                                Path= "Questionnaire.item.initial",                                                                         // MakerGen.cs:231
                                Id = "Questionnaire.item.initial",                                                                          // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                    new Type_Initial                                                                                        // MakerGen.cs:254
                                    {                                                                                                       // MakerGen.cs:255
                                    }                                                                                                       // MakerGen.cs:256
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                        {                                                                                                                   // MakerGen.cs:226
                            // 44. Questionnaire.item.item
                            this.Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                            {                                                                                                               // MakerGen.cs:229
                                Name = "Item",                                                                                              // MakerGen.cs:230
                                Path= "Questionnaire.item.item",                                                                            // MakerGen.cs:231
                                Id = "Questionnaire.item.item",                                                                             // MakerGen.cs:232
                                Min = 0,                                                                                                    // MakerGen.cs:233
                                Max = -1,                                                                                                   // MakerGen.cs:234
                                Types = new BaseType[]                                                                                      // MakerGen.cs:235
                                {                                                                                                           // MakerGen.cs:236
                                }                                                                                                           // MakerGen.cs:238
                            };                                                                                                              // MakerGen.cs:239
                        }                                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:393
                    {                                                                                                                       // MakerGen.cs:394
                        base.Write(sDef);                                                                                                   // MakerGen.cs:395
                        LinkId.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Definition.Write(sDef);                                                                                             // MakerGen.cs:215
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Prefix.Write(sDef);                                                                                                 // MakerGen.cs:215
                        Text.Write(sDef);                                                                                                   // MakerGen.cs:215
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:215
                        EnableWhen.Write(sDef);                                                                                             // MakerGen.cs:215
                        EnableBehavior.Write(sDef);                                                                                         // MakerGen.cs:215
                        Required.Write(sDef);                                                                                               // MakerGen.cs:215
                        Repeats.Write(sDef);                                                                                                // MakerGen.cs:215
                        ReadOnly.Write(sDef);                                                                                               // MakerGen.cs:215
                        MaxLength.Write(sDef);                                                                                              // MakerGen.cs:215
                        AnswerValueSet.Write(sDef);                                                                                         // MakerGen.cs:215
                        AnswerOption.Write(sDef);                                                                                           // MakerGen.cs:215
                        Initial.Write(sDef);                                                                                                // MakerGen.cs:215
                        Item.Write(sDef);                                                                                                   // MakerGen.cs:215
                    }                                                                                                                       // MakerGen.cs:397
                }                                                                                                                           // MakerGen.cs:399
                public Type_Item_Elements Elements                                                                                          // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    get                                                                                                                     // MakerGen.cs:403
                    {                                                                                                                       // MakerGen.cs:404
                        if (this.elements == null)                                                                                          // MakerGen.cs:405
                            this.elements = new Type_Item_Elements();                                                                       // MakerGen.cs:406
                        return this.elements;                                                                                               // MakerGen.cs:407
                    }                                                                                                                       // MakerGen.cs:408
                }                                                                                                                           // MakerGen.cs:409
                Type_Item_Elements elements;                                                                                                // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
                public Type_Item()                                                                                                          // MakerGen.cs:413
                {                                                                                                                           // MakerGen.cs:414
                }                                                                                                                           // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:419
                {                                                                                                                           // MakerGen.cs:420
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                      // MakerGen.cs:421
                    {                                                                                                                       // MakerGen.cs:422
                        Path = "Questionnaire.item",                                                                                        // MakerGen.cs:423
                        ElementId = "Questionnaire.item"                                                                                    // MakerGen.cs:424
                    });                                                                                                                     // MakerGen.cs:425
                    if (this.elements != null)                                                                                              // MakerGen.cs:426
                        this.elements.Write(sDef);                                                                                          // MakerGen.cs:427
                }                                                                                                                           // MakerGen.cs:428
            }                                                                                                                               // MakerGen.cs:429
            // 1. Questionnaire.url
            public ElementDefinitionInfo Url;                                                                                               // MakerGen.cs:211
            // 2. Questionnaire.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:211
            // 3. Questionnaire.version
            public ElementDefinitionInfo Version;                                                                                           // MakerGen.cs:211
            // 4. Questionnaire.name
            public ElementDefinitionInfo Name;                                                                                              // MakerGen.cs:211
            // 5. Questionnaire.title
            public ElementDefinitionInfo Title;                                                                                             // MakerGen.cs:211
            // 6. Questionnaire.derivedFrom
            public ElementDefinitionInfo DerivedFrom;                                                                                       // MakerGen.cs:211
            // 7. Questionnaire.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:211
            // 8. Questionnaire.experimental
            public ElementDefinitionInfo Experimental;                                                                                      // MakerGen.cs:211
            // 9. Questionnaire.subjectType
            public ElementDefinitionInfo SubjectType;                                                                                       // MakerGen.cs:211
            // 10. Questionnaire.date
            public ElementDefinitionInfo Date;                                                                                              // MakerGen.cs:211
            // 11. Questionnaire.publisher
            public ElementDefinitionInfo Publisher;                                                                                         // MakerGen.cs:211
            // 12. Questionnaire.contact
            public ElementDefinitionInfo Contact;                                                                                           // MakerGen.cs:211
            // 13. Questionnaire.description
            public ElementDefinitionInfo Description;                                                                                       // MakerGen.cs:211
            // 14. Questionnaire.useContext
            public ElementDefinitionInfo UseContext;                                                                                        // MakerGen.cs:211
            // 15. Questionnaire.jurisdiction
            public ElementDefinitionInfo Jurisdiction;                                                                                      // MakerGen.cs:211
            // 16. Questionnaire.purpose
            public ElementDefinitionInfo Purpose;                                                                                           // MakerGen.cs:211
            // 17. Questionnaire.copyright
            public ElementDefinitionInfo Copyright;                                                                                         // MakerGen.cs:211
            // 18. Questionnaire.approvalDate
            public ElementDefinitionInfo ApprovalDate;                                                                                      // MakerGen.cs:211
            // 19. Questionnaire.lastReviewDate
            public ElementDefinitionInfo LastReviewDate;                                                                                    // MakerGen.cs:211
            // 20. Questionnaire.effectivePeriod
            public ElementDefinitionInfo EffectivePeriod;                                                                                   // MakerGen.cs:211
            // 21. Questionnaire.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:211
            // 22. Questionnaire.item
            public ElementDefinitionInfo Item;                                                                                              // MakerGen.cs:211
                                                                                                                                            // MakerGen.cs:386
            public Questionnaire_Elements()                                                                                                 // MakerGen.cs:387
            {                                                                                                                               // MakerGen.cs:388
                {                                                                                                                           // MakerGen.cs:226
                    // 1. Questionnaire.url
                    this.Url = new ElementDefinitionInfo                                                                                    // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Url",                                                                                                       // MakerGen.cs:230
                        Path= "Questionnaire.url",                                                                                          // MakerGen.cs:231
                        Id = "Questionnaire.url",                                                                                           // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 2. Questionnaire.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Identifier",                                                                                                // MakerGen.cs:230
                        Path= "Questionnaire.identifier",                                                                                   // MakerGen.cs:231
                        Id = "Questionnaire.identifier",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 3. Questionnaire.version
                    this.Version = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Version",                                                                                                   // MakerGen.cs:230
                        Path= "Questionnaire.version",                                                                                      // MakerGen.cs:231
                        Id = "Questionnaire.version",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 4. Questionnaire.name
                    this.Name = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Name",                                                                                                      // MakerGen.cs:230
                        Path= "Questionnaire.name",                                                                                         // MakerGen.cs:231
                        Id = "Questionnaire.name",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 5. Questionnaire.title
                    this.Title = new ElementDefinitionInfo                                                                                  // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Title",                                                                                                     // MakerGen.cs:230
                        Path= "Questionnaire.title",                                                                                        // MakerGen.cs:231
                        Id = "Questionnaire.title",                                                                                         // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 6. Questionnaire.derivedFrom
                    this.DerivedFrom = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "DerivedFrom",                                                                                               // MakerGen.cs:230
                        Path= "Questionnaire.derivedFrom",                                                                                  // MakerGen.cs:231
                        Id = "Questionnaire.derivedFrom",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                                TargetProfile = new String[]                                                                                // MakerGen.cs:298
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Questionnaire"                                                 // MakerGen.cs:298
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 7. Questionnaire.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Status",                                                                                                    // MakerGen.cs:230
                        Path= "Questionnaire.status",                                                                                       // MakerGen.cs:231
                        Id = "Questionnaire.status",                                                                                        // MakerGen.cs:232
                        Min = 1,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 8. Questionnaire.experimental
                    this.Experimental = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Experimental",                                                                                              // MakerGen.cs:230
                        Path= "Questionnaire.experimental",                                                                                 // MakerGen.cs:231
                        Id = "Questionnaire.experimental",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Boolean                                                                     // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 9. Questionnaire.subjectType
                    this.SubjectType = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "SubjectType",                                                                                               // MakerGen.cs:230
                        Path= "Questionnaire.subjectType",                                                                                  // MakerGen.cs:231
                        Id = "Questionnaire.subjectType",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 10. Questionnaire.date
                    this.Date = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Date",                                                                                                      // MakerGen.cs:230
                        Path= "Questionnaire.date",                                                                                         // MakerGen.cs:231
                        Id = "Questionnaire.date",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 11. Questionnaire.publisher
                    this.Publisher = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Publisher",                                                                                                 // MakerGen.cs:230
                        Path= "Questionnaire.publisher",                                                                                    // MakerGen.cs:231
                        Id = "Questionnaire.publisher",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.String                                                                      // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 12. Questionnaire.contact
                    this.Contact = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Contact",                                                                                                   // MakerGen.cs:230
                        Path= "Questionnaire.contact",                                                                                      // MakerGen.cs:231
                        Id = "Questionnaire.contact",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.ContactDetail                                                                 // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 13. Questionnaire.description
                    this.Description = new ElementDefinitionInfo                                                                            // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Description",                                                                                               // MakerGen.cs:230
                        Path= "Questionnaire.description",                                                                                  // MakerGen.cs:231
                        Id = "Questionnaire.description",                                                                                   // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 14. Questionnaire.useContext
                    this.UseContext = new ElementDefinitionInfo                                                                             // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "UseContext",                                                                                                // MakerGen.cs:230
                        Path= "Questionnaire.useContext",                                                                                   // MakerGen.cs:231
                        Id = "Questionnaire.useContext",                                                                                    // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.UsageContext                                                                  // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 15. Questionnaire.jurisdiction
                    this.Jurisdiction = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Jurisdiction",                                                                                              // MakerGen.cs:230
                        Path= "Questionnaire.jurisdiction",                                                                                 // MakerGen.cs:231
                        Id = "Questionnaire.jurisdiction",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 16. Questionnaire.purpose
                    this.Purpose = new ElementDefinitionInfo                                                                                // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Purpose",                                                                                                   // MakerGen.cs:230
                        Path= "Questionnaire.purpose",                                                                                      // MakerGen.cs:231
                        Id = "Questionnaire.purpose",                                                                                       // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 17. Questionnaire.copyright
                    this.Copyright = new ElementDefinitionInfo                                                                              // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Copyright",                                                                                                 // MakerGen.cs:230
                        Path= "Questionnaire.copyright",                                                                                    // MakerGen.cs:231
                        Id = "Questionnaire.copyright",                                                                                     // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Markdown                                                                    // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 18. Questionnaire.approvalDate
                    this.ApprovalDate = new ElementDefinitionInfo                                                                           // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "ApprovalDate",                                                                                              // MakerGen.cs:230
                        Path= "Questionnaire.approvalDate",                                                                                 // MakerGen.cs:231
                        Id = "Questionnaire.approvalDate",                                                                                  // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 19. Questionnaire.lastReviewDate
                    this.LastReviewDate = new ElementDefinitionInfo                                                                         // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "LastReviewDate",                                                                                            // MakerGen.cs:230
                        Path= "Questionnaire.lastReviewDate",                                                                               // MakerGen.cs:231
                        Id = "Questionnaire.lastReviewDate",                                                                                // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Primitive.Date                                                                        // MakerGen.cs:295
                            {                                                                                                               // MakerGen.cs:296
                            }                                                                                                               // MakerGen.cs:299
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 20. Questionnaire.effectivePeriod
                    this.EffectivePeriod = new ElementDefinitionInfo                                                                        // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "EffectivePeriod",                                                                                           // MakerGen.cs:230
                        Path= "Questionnaire.effectivePeriod",                                                                              // MakerGen.cs:231
                        Id = "Questionnaire.effectivePeriod",                                                                               // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = 1,                                                                                                            // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Period                                                                        // MakerGen.cs:353
                            {                                                                                                               // MakerGen.cs:354
                            }                                                                                                               // MakerGen.cs:355
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 21. Questionnaire.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Code",                                                                                                      // MakerGen.cs:230
                        Path= "Questionnaire.code",                                                                                         // MakerGen.cs:231
                        Id = "Questionnaire.code",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new FhirKhit.Maker.Common.Complex.Coding                                                                        // MakerGen.cs:310
                            {                                                                                                               // MakerGen.cs:311
                            }                                                                                                               // MakerGen.cs:314
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
                {                                                                                                                           // MakerGen.cs:226
                    // 22. Questionnaire.item
                    this.Item = new ElementDefinitionInfo                                                                                   // MakerGen.cs:228
                    {                                                                                                                       // MakerGen.cs:229
                        Name = "Item",                                                                                                      // MakerGen.cs:230
                        Path= "Questionnaire.item",                                                                                         // MakerGen.cs:231
                        Id = "Questionnaire.item",                                                                                          // MakerGen.cs:232
                        Min = 0,                                                                                                            // MakerGen.cs:233
                        Max = -1,                                                                                                           // MakerGen.cs:234
                        Types = new BaseType[]                                                                                              // MakerGen.cs:235
                        {                                                                                                                   // MakerGen.cs:236
                            new Type_Item                                                                                                   // MakerGen.cs:254
                            {                                                                                                               // MakerGen.cs:255
                            }                                                                                                               // MakerGen.cs:256
                        }                                                                                                                   // MakerGen.cs:238
                    };                                                                                                                      // MakerGen.cs:239
                }                                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:390
                                                                                                                                            // MakerGen.cs:392
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:393
            {                                                                                                                               // MakerGen.cs:394
                base.Write(sDef);                                                                                                           // MakerGen.cs:395
                Url.Write(sDef);                                                                                                            // MakerGen.cs:215
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:215
                Version.Write(sDef);                                                                                                        // MakerGen.cs:215
                Name.Write(sDef);                                                                                                           // MakerGen.cs:215
                Title.Write(sDef);                                                                                                          // MakerGen.cs:215
                DerivedFrom.Write(sDef);                                                                                                    // MakerGen.cs:215
                Status.Write(sDef);                                                                                                         // MakerGen.cs:215
                Experimental.Write(sDef);                                                                                                   // MakerGen.cs:215
                SubjectType.Write(sDef);                                                                                                    // MakerGen.cs:215
                Date.Write(sDef);                                                                                                           // MakerGen.cs:215
                Publisher.Write(sDef);                                                                                                      // MakerGen.cs:215
                Contact.Write(sDef);                                                                                                        // MakerGen.cs:215
                Description.Write(sDef);                                                                                                    // MakerGen.cs:215
                UseContext.Write(sDef);                                                                                                     // MakerGen.cs:215
                Jurisdiction.Write(sDef);                                                                                                   // MakerGen.cs:215
                Purpose.Write(sDef);                                                                                                        // MakerGen.cs:215
                Copyright.Write(sDef);                                                                                                      // MakerGen.cs:215
                ApprovalDate.Write(sDef);                                                                                                   // MakerGen.cs:215
                LastReviewDate.Write(sDef);                                                                                                 // MakerGen.cs:215
                EffectivePeriod.Write(sDef);                                                                                                // MakerGen.cs:215
                Code.Write(sDef);                                                                                                           // MakerGen.cs:215
                Item.Write(sDef);                                                                                                           // MakerGen.cs:215
            }                                                                                                                               // MakerGen.cs:397
        }                                                                                                                                   // MakerGen.cs:399
        public Questionnaire_Elements Elements                                                                                              // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            get                                                                                                                             // MakerGen.cs:403
            {                                                                                                                               // MakerGen.cs:404
                if (this.elements == null)                                                                                                  // MakerGen.cs:405
                    this.elements = new Questionnaire_Elements();                                                                           // MakerGen.cs:406
                return this.elements;                                                                                                       // MakerGen.cs:407
            }                                                                                                                               // MakerGen.cs:408
        }                                                                                                                                   // MakerGen.cs:409
        Questionnaire_Elements elements;                                                                                                    // MakerGen.cs:410
                                                                                                                                            // MakerGen.cs:412
        public Questionnaire()                                                                                                              // MakerGen.cs:413
        {                                                                                                                                   // MakerGen.cs:414
            this.Name = "Questionnaire";                                                                                                    // MakerGen.cs:487
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Questionnaire";                                                             // MakerGen.cs:488
        }                                                                                                                                   // MakerGen.cs:416
                                                                                                                                            // MakerGen.cs:418
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:419
        {                                                                                                                                   // MakerGen.cs:420
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition                                                              // MakerGen.cs:421
            {                                                                                                                               // MakerGen.cs:422
                Path = "Questionnaire",                                                                                                     // MakerGen.cs:423
                ElementId = "Questionnaire"                                                                                                 // MakerGen.cs:424
            });                                                                                                                             // MakerGen.cs:425
            if (this.elements != null)                                                                                                      // MakerGen.cs:426
                this.elements.Write(sDef);                                                                                                  // MakerGen.cs:427
        }                                                                                                                                   // MakerGen.cs:428
    }                                                                                                                                       // MakerGen.cs:429
}                                                                                                                                           // MakerGen.cs:474
