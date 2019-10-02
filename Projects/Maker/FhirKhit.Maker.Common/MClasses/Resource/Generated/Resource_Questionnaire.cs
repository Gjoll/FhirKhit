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
    #endregion
    /// <summary>
    /// Fhir resource 'Questionnaire'
    /// </summary>
    // 0. Questionnaire
    public partial class Resource_Questionnaire : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 22. Questionnaire.item
        public partial class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 29. Questionnaire.item.enableWhen
            public partial class Type_EnableWhen : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 30. Questionnaire.item.enableWhen.question
                public ElementDefinitionInfo Element_Question;
                // 31. Questionnaire.item.enableWhen.operator
                public ElementDefinitionInfo Element_Operator;
                // 32. Questionnaire.item.enableWhen.answer[x]
                public ElementDefinitionInfo Element_Answer;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "Questionnaire.item.enableWhen",
                        ElementId = "Questionnaire.item.enableWhen"
                    });
                    Element_Question.Write(sDef);
                    Element_Operator.Write(sDef);
                    Element_Answer.Write(sDef);
                }
                
                public Type_EnableWhen()
                {
                    {
                        // 30. Questionnaire.item.enableWhen.question
                        this.Element_Question = new ElementDefinitionInfo
                        {
                            Name = "Element_Question",
                            Path= "Questionnaire.item.enableWhen.question",
                            Id = "Questionnaire.item.enableWhen.question",
                            Min = 1,
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
                        // 31. Questionnaire.item.enableWhen.operator
                        this.Element_Operator = new ElementDefinitionInfo
                        {
                            Name = "Element_Operator",
                            Path= "Questionnaire.item.enableWhen.operator",
                            Id = "Questionnaire.item.enableWhen.operator",
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
                        // 32. Questionnaire.item.enableWhen.answer[x]
                        this.Element_Answer = new ElementDefinitionInfo
                        {
                            Name = "Element_Answer",
                            Path= "Questionnaire.item.enableWhen.answer[x]",
                            Id = "Questionnaire.item.enableWhen.answer[x]",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Date
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Time
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Coding
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Quantity
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Reference
                                {
                                    TargetProfile = new String[]
                                    {
                                        "http://hl7.org/fhir/StructureDefinition/Resource"
                                    }
                                }
                            }
                        };
                    }
                }
            }
            // 39. Questionnaire.item.answerOption
            public partial class Type_AnswerOption : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 40. Questionnaire.item.answerOption.value[x]
                public ElementDefinitionInfo Element_Value;
                // 41. Questionnaire.item.answerOption.initialSelected
                public ElementDefinitionInfo Element_InitialSelected;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "Questionnaire.item.answerOption",
                        ElementId = "Questionnaire.item.answerOption"
                    });
                    Element_Value.Write(sDef);
                    Element_InitialSelected.Write(sDef);
                }
                
                public Type_AnswerOption()
                {
                    {
                        // 40. Questionnaire.item.answerOption.value[x]
                        this.Element_Value = new ElementDefinitionInfo
                        {
                            Name = "Element_Value",
                            Path= "Questionnaire.item.answerOption.value[x]",
                            Id = "Questionnaire.item.answerOption.value[x]",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Date
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Time
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Coding
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Reference
                                {
                                    TargetProfile = new String[]
                                    {
                                        "http://hl7.org/fhir/StructureDefinition/Resource"
                                    }
                                }
                            }
                        };
                    }
                    {
                        // 41. Questionnaire.item.answerOption.initialSelected
                        this.Element_InitialSelected = new ElementDefinitionInfo
                        {
                            Name = "Element_InitialSelected",
                            Path= "Questionnaire.item.answerOption.initialSelected",
                            Id = "Questionnaire.item.answerOption.initialSelected",
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
                }
            }
            // 42. Questionnaire.item.initial
            public partial class Type_Initial : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 43. Questionnaire.item.initial.value[x]
                public ElementDefinitionInfo Element_Value;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "Questionnaire.item.initial",
                        ElementId = "Questionnaire.item.initial"
                    });
                    Element_Value.Write(sDef);
                }
                
                public Type_Initial()
                {
                    {
                        // 43. Questionnaire.item.initial.value[x]
                        this.Element_Value = new ElementDefinitionInfo
                        {
                            Name = "Element_Value",
                            Path= "Questionnaire.item.initial.value[x]",
                            Id = "Questionnaire.item.initial.value[x]",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Boolean
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Decimal
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Integer
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Date
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Time
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_String
                                {
                                },
                                new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Attachment
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Coding
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Quantity
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Reference
                                {
                                    TargetProfile = new String[]
                                    {
                                        "http://hl7.org/fhir/StructureDefinition/Resource"
                                    }
                                }
                            }
                        };
                    }
                }
            }
            // 23. Questionnaire.item.linkId
            public ElementDefinitionInfo Element_LinkId;
            // 24. Questionnaire.item.definition
            public ElementDefinitionInfo Element_Definition;
            // 25. Questionnaire.item.code
            public ElementDefinitionInfo Element_Code;
            // 26. Questionnaire.item.prefix
            public ElementDefinitionInfo Element_Prefix;
            // 27. Questionnaire.item.text
            public ElementDefinitionInfo Element_Text;
            // 28. Questionnaire.item.type
            public ElementDefinitionInfo Element_Type;
            // 29. Questionnaire.item.enableWhen
            public ElementDefinitionInfo Element_EnableWhen;
            // 33. Questionnaire.item.enableBehavior
            public ElementDefinitionInfo Element_EnableBehavior;
            // 34. Questionnaire.item.required
            public ElementDefinitionInfo Element_Required;
            // 35. Questionnaire.item.repeats
            public ElementDefinitionInfo Element_Repeats;
            // 36. Questionnaire.item.readOnly
            public ElementDefinitionInfo Element_ReadOnly;
            // 37. Questionnaire.item.maxLength
            public ElementDefinitionInfo Element_MaxLength;
            // 38. Questionnaire.item.answerValueSet
            public ElementDefinitionInfo Element_AnswerValueSet;
            // 39. Questionnaire.item.answerOption
            public ElementDefinitionInfo Element_AnswerOption;
            // 42. Questionnaire.item.initial
            public ElementDefinitionInfo Element_Initial;
            // 44. Questionnaire.item.item
            public ElementDefinitionInfo Element_Item;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "Questionnaire.item",
                    ElementId = "Questionnaire.item"
                });
                Element_LinkId.Write(sDef);
                Element_Definition.Write(sDef);
                Element_Code.Write(sDef);
                Element_Prefix.Write(sDef);
                Element_Text.Write(sDef);
                Element_Type.Write(sDef);
                Element_EnableWhen.Write(sDef);
                Element_EnableBehavior.Write(sDef);
                Element_Required.Write(sDef);
                Element_Repeats.Write(sDef);
                Element_ReadOnly.Write(sDef);
                Element_MaxLength.Write(sDef);
                Element_AnswerValueSet.Write(sDef);
                Element_AnswerOption.Write(sDef);
                Element_Initial.Write(sDef);
                Element_Item.Write(sDef);
            }
            
            public Type_Item()
            {
                {
                    // 23. Questionnaire.item.linkId
                    this.Element_LinkId = new ElementDefinitionInfo
                    {
                        Name = "Element_LinkId",
                        Path= "Questionnaire.item.linkId",
                        Id = "Questionnaire.item.linkId",
                        Min = 1,
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
                    // 24. Questionnaire.item.definition
                    this.Element_Definition = new ElementDefinitionInfo
                    {
                        Name = "Element_Definition",
                        Path= "Questionnaire.item.definition",
                        Id = "Questionnaire.item.definition",
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
                    // 25. Questionnaire.item.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "Questionnaire.item.code",
                        Id = "Questionnaire.item.code",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Coding
                            {
                            }
                        }
                    };
                }
                {
                    // 26. Questionnaire.item.prefix
                    this.Element_Prefix = new ElementDefinitionInfo
                    {
                        Name = "Element_Prefix",
                        Path= "Questionnaire.item.prefix",
                        Id = "Questionnaire.item.prefix",
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
                    // 27. Questionnaire.item.text
                    this.Element_Text = new ElementDefinitionInfo
                    {
                        Name = "Element_Text",
                        Path= "Questionnaire.item.text",
                        Id = "Questionnaire.item.text",
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
                    // 28. Questionnaire.item.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "Questionnaire.item.type",
                        Id = "Questionnaire.item.type",
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
                    // 29. Questionnaire.item.enableWhen
                    this.Element_EnableWhen = new ElementDefinitionInfo
                    {
                        Name = "Element_EnableWhen",
                        Path= "Questionnaire.item.enableWhen",
                        Id = "Questionnaire.item.enableWhen",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_EnableWhen
                            {
                            }
                        }
                    };
                }
                {
                    // 33. Questionnaire.item.enableBehavior
                    this.Element_EnableBehavior = new ElementDefinitionInfo
                    {
                        Name = "Element_EnableBehavior",
                        Path= "Questionnaire.item.enableBehavior",
                        Id = "Questionnaire.item.enableBehavior",
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
                    // 34. Questionnaire.item.required
                    this.Element_Required = new ElementDefinitionInfo
                    {
                        Name = "Element_Required",
                        Path= "Questionnaire.item.required",
                        Id = "Questionnaire.item.required",
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
                    // 35. Questionnaire.item.repeats
                    this.Element_Repeats = new ElementDefinitionInfo
                    {
                        Name = "Element_Repeats",
                        Path= "Questionnaire.item.repeats",
                        Id = "Questionnaire.item.repeats",
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
                    // 36. Questionnaire.item.readOnly
                    this.Element_ReadOnly = new ElementDefinitionInfo
                    {
                        Name = "Element_ReadOnly",
                        Path= "Questionnaire.item.readOnly",
                        Id = "Questionnaire.item.readOnly",
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
                    // 37. Questionnaire.item.maxLength
                    this.Element_MaxLength = new ElementDefinitionInfo
                    {
                        Name = "Element_MaxLength",
                        Path= "Questionnaire.item.maxLength",
                        Id = "Questionnaire.item.maxLength",
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
                    // 38. Questionnaire.item.answerValueSet
                    this.Element_AnswerValueSet = new ElementDefinitionInfo
                    {
                        Name = "Element_AnswerValueSet",
                        Path= "Questionnaire.item.answerValueSet",
                        Id = "Questionnaire.item.answerValueSet",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/ValueSet"
                                }
                            }
                        }
                    };
                }
                {
                    // 39. Questionnaire.item.answerOption
                    this.Element_AnswerOption = new ElementDefinitionInfo
                    {
                        Name = "Element_AnswerOption",
                        Path= "Questionnaire.item.answerOption",
                        Id = "Questionnaire.item.answerOption",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_AnswerOption
                            {
                            }
                        }
                    };
                }
                {
                    // 42. Questionnaire.item.initial
                    this.Element_Initial = new ElementDefinitionInfo
                    {
                        Name = "Element_Initial",
                        Path= "Questionnaire.item.initial",
                        Id = "Questionnaire.item.initial",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Initial
                            {
                            }
                        }
                    };
                }
                {
                    // 44. Questionnaire.item.item
                    this.Element_Item = new ElementDefinitionInfo
                    {
                        Name = "Element_Item",
                        Path= "Questionnaire.item.item",
                        Id = "Questionnaire.item.item",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
            }
        }
        // 1. Questionnaire.url
        public ElementDefinitionInfo Element_Url;
        // 2. Questionnaire.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 3. Questionnaire.version
        public ElementDefinitionInfo Element_Version;
        // 4. Questionnaire.name
        public ElementDefinitionInfo Element_Name;
        // 5. Questionnaire.title
        public ElementDefinitionInfo Element_Title;
        // 6. Questionnaire.derivedFrom
        public ElementDefinitionInfo Element_DerivedFrom;
        // 7. Questionnaire.status
        public ElementDefinitionInfo Element_Status;
        // 8. Questionnaire.experimental
        public ElementDefinitionInfo Element_Experimental;
        // 9. Questionnaire.subjectType
        public ElementDefinitionInfo Element_SubjectType;
        // 10. Questionnaire.date
        public ElementDefinitionInfo Element_Date;
        // 11. Questionnaire.publisher
        public ElementDefinitionInfo Element_Publisher;
        // 12. Questionnaire.contact
        public ElementDefinitionInfo Element_Contact;
        // 13. Questionnaire.description
        public ElementDefinitionInfo Element_Description;
        // 14. Questionnaire.useContext
        public ElementDefinitionInfo Element_UseContext;
        // 15. Questionnaire.jurisdiction
        public ElementDefinitionInfo Element_Jurisdiction;
        // 16. Questionnaire.purpose
        public ElementDefinitionInfo Element_Purpose;
        // 17. Questionnaire.copyright
        public ElementDefinitionInfo Element_Copyright;
        // 18. Questionnaire.approvalDate
        public ElementDefinitionInfo Element_ApprovalDate;
        // 19. Questionnaire.lastReviewDate
        public ElementDefinitionInfo Element_LastReviewDate;
        // 20. Questionnaire.effectivePeriod
        public ElementDefinitionInfo Element_EffectivePeriod;
        // 21. Questionnaire.code
        public ElementDefinitionInfo Element_Code;
        // 22. Questionnaire.item
        public ElementDefinitionInfo Element_Item;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "Questionnaire",
                ElementId = "Questionnaire"
            });
            Element_Url.Write(sDef);
            Element_Identifier.Write(sDef);
            Element_Version.Write(sDef);
            Element_Name.Write(sDef);
            Element_Title.Write(sDef);
            Element_DerivedFrom.Write(sDef);
            Element_Status.Write(sDef);
            Element_Experimental.Write(sDef);
            Element_SubjectType.Write(sDef);
            Element_Date.Write(sDef);
            Element_Publisher.Write(sDef);
            Element_Contact.Write(sDef);
            Element_Description.Write(sDef);
            Element_UseContext.Write(sDef);
            Element_Jurisdiction.Write(sDef);
            Element_Purpose.Write(sDef);
            Element_Copyright.Write(sDef);
            Element_ApprovalDate.Write(sDef);
            Element_LastReviewDate.Write(sDef);
            Element_EffectivePeriod.Write(sDef);
            Element_Code.Write(sDef);
            Element_Item.Write(sDef);
        }
        
        public Resource_Questionnaire()
        {
            {
                // 1. Questionnaire.url
                this.Element_Url = new ElementDefinitionInfo
                {
                    Name = "Element_Url",
                    Path= "Questionnaire.url",
                    Id = "Questionnaire.url",
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
                // 2. Questionnaire.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "Questionnaire.identifier",
                    Id = "Questionnaire.identifier",
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
                // 3. Questionnaire.version
                this.Element_Version = new ElementDefinitionInfo
                {
                    Name = "Element_Version",
                    Path= "Questionnaire.version",
                    Id = "Questionnaire.version",
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
                // 4. Questionnaire.name
                this.Element_Name = new ElementDefinitionInfo
                {
                    Name = "Element_Name",
                    Path= "Questionnaire.name",
                    Id = "Questionnaire.name",
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
                // 5. Questionnaire.title
                this.Element_Title = new ElementDefinitionInfo
                {
                    Name = "Element_Title",
                    Path= "Questionnaire.title",
                    Id = "Questionnaire.title",
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
                // 6. Questionnaire.derivedFrom
                this.Element_DerivedFrom = new ElementDefinitionInfo
                {
                    Name = "Element_DerivedFrom",
                    Path= "Questionnaire.derivedFrom",
                    Id = "Questionnaire.derivedFrom",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Questionnaire"
                            }
                        }
                    }
                };
            }
            {
                // 7. Questionnaire.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "Questionnaire.status",
                    Id = "Questionnaire.status",
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
                // 8. Questionnaire.experimental
                this.Element_Experimental = new ElementDefinitionInfo
                {
                    Name = "Element_Experimental",
                    Path= "Questionnaire.experimental",
                    Id = "Questionnaire.experimental",
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
                // 9. Questionnaire.subjectType
                this.Element_SubjectType = new ElementDefinitionInfo
                {
                    Name = "Element_SubjectType",
                    Path= "Questionnaire.subjectType",
                    Id = "Questionnaire.subjectType",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Code
                        {
                        }
                    }
                };
            }
            {
                // 10. Questionnaire.date
                this.Element_Date = new ElementDefinitionInfo
                {
                    Name = "Element_Date",
                    Path= "Questionnaire.date",
                    Id = "Questionnaire.date",
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
                // 11. Questionnaire.publisher
                this.Element_Publisher = new ElementDefinitionInfo
                {
                    Name = "Element_Publisher",
                    Path= "Questionnaire.publisher",
                    Id = "Questionnaire.publisher",
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
                // 12. Questionnaire.contact
                this.Element_Contact = new ElementDefinitionInfo
                {
                    Name = "Element_Contact",
                    Path= "Questionnaire.contact",
                    Id = "Questionnaire.contact",
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
                // 13. Questionnaire.description
                this.Element_Description = new ElementDefinitionInfo
                {
                    Name = "Element_Description",
                    Path= "Questionnaire.description",
                    Id = "Questionnaire.description",
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
                // 14. Questionnaire.useContext
                this.Element_UseContext = new ElementDefinitionInfo
                {
                    Name = "Element_UseContext",
                    Path= "Questionnaire.useContext",
                    Id = "Questionnaire.useContext",
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
                // 15. Questionnaire.jurisdiction
                this.Element_Jurisdiction = new ElementDefinitionInfo
                {
                    Name = "Element_Jurisdiction",
                    Path= "Questionnaire.jurisdiction",
                    Id = "Questionnaire.jurisdiction",
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
                // 16. Questionnaire.purpose
                this.Element_Purpose = new ElementDefinitionInfo
                {
                    Name = "Element_Purpose",
                    Path= "Questionnaire.purpose",
                    Id = "Questionnaire.purpose",
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
                // 17. Questionnaire.copyright
                this.Element_Copyright = new ElementDefinitionInfo
                {
                    Name = "Element_Copyright",
                    Path= "Questionnaire.copyright",
                    Id = "Questionnaire.copyright",
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
                // 18. Questionnaire.approvalDate
                this.Element_ApprovalDate = new ElementDefinitionInfo
                {
                    Name = "Element_ApprovalDate",
                    Path= "Questionnaire.approvalDate",
                    Id = "Questionnaire.approvalDate",
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
                // 19. Questionnaire.lastReviewDate
                this.Element_LastReviewDate = new ElementDefinitionInfo
                {
                    Name = "Element_LastReviewDate",
                    Path= "Questionnaire.lastReviewDate",
                    Id = "Questionnaire.lastReviewDate",
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
                // 20. Questionnaire.effectivePeriod
                this.Element_EffectivePeriod = new ElementDefinitionInfo
                {
                    Name = "Element_EffectivePeriod",
                    Path= "Questionnaire.effectivePeriod",
                    Id = "Questionnaire.effectivePeriod",
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
                // 21. Questionnaire.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "Questionnaire.code",
                    Id = "Questionnaire.code",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Coding
                        {
                        }
                    }
                };
            }
            {
                // 22. Questionnaire.item
                this.Element_Item = new ElementDefinitionInfo
                {
                    Name = "Element_Item",
                    Path= "Questionnaire.item",
                    Id = "Questionnaire.item",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Item
                        {
                        }
                    }
                };
            }
            this.Name = "Questionnaire";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/Questionnaire";
        }
    }
}
