using System;                                                                                                                               // MakerGen.cs:451
using System.Diagnostics;                                                                                                                   // MakerGen.cs:452
using System.IO;                                                                                                                            // MakerGen.cs:453
using System.Linq;                                                                                                                          // MakerGen.cs:454
using Hl7.Fhir.Model;                                                                                                                       // MakerGen.cs:455
                                                                                                                                            // MakerGen.cs:456
namespace FhirKhit.Maker.Common.Resource                                                                                                    // MakerGen.cs:457
{                                                                                                                                           // MakerGen.cs:458
    #region Json                                                                                                                            // MakerGen.cs:459
    #if NEVER                                                                                                                               // MakerGen.cs:460
    {
      "resourceType": "StructureDefinition",
      "id": "QuestionnaireResponse",
      "url": "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse",
      "version": "4.0.0",
      "name": "QuestionnaireResponse",
      "status": "draft",
      "publisher": "Health Level Seven International (FHIR Infrastructure)",
      "description": "A structured set of questions and their answers. The questions are ordered and grouped into coherent subsets, corresponding to the structure of the grouping of the questionnaire being responded to.",
      "purpose": "To support structured, hierarchical reporting of data gathered using digital forms and other questionnaires.",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "QuestionnaireResponse",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "QuestionnaireResponse",
            "path": "QuestionnaireResponse",
            "short": "A structured set of questions and their answers",
            "definition": "A structured set of questions and their answers. The questions are ordered and grouped into coherent subsets, corresponding to the structure of the grouping of the questionnaire being responded to.",
            "comment": "The QuestionnaireResponse contains enough information about the questions asked and their organization that it can be interpreted somewhat independently from the Questionnaire it is based on.  I.e. You don't need access to the Questionnaire in order to extract basic information from a QuestionnaireResponse.",
            "alias": [
              "Form",
              "QuestionnaireAnswers"
            ],
            "min": 0,
            "max": "*"
          },
          {
            "id": "QuestionnaireResponse.identifier",
            "path": "QuestionnaireResponse.identifier",
            "short": "Unique id for this set of answers",
            "definition": "A business identifier assigned to a particular completed (or partially completed) questionnaire.",
            "requirements": "Used for tracking, registration and other business purposes.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Identifier"
              }
            ],
            "isSummary": true
          },
          {
            "id": "QuestionnaireResponse.basedOn",
            "path": "QuestionnaireResponse.basedOn",
            "short": "Request fulfilled by this QuestionnaireResponse",
            "definition": "The order, proposal or plan that is fulfilled in whole or in part by this QuestionnaireResponse.  For example, a ServiceRequest seeking an intake assessment or a decision support recommendation to assess for post-partum depression.",
            "requirements": "Supports traceability of responsibility for the action and allows linkage of an action to the recommendations acted upon.",
            "alias": [
              "order"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/CarePlan",
                  "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "QuestionnaireResponse.partOf",
            "path": "QuestionnaireResponse.partOf",
            "short": "Part of this action",
            "definition": "A procedure or observation that this questionnaire was performed as part of the execution of.  For example, the surgery a checklist was executed as part of.",
            "comment": "Composition of questionnaire responses will be handled by the parent questionnaire having answers that reference the child questionnaire.  For relationships to referrals, and other types of requests, use basedOn.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/Procedure"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "QuestionnaireResponse.questionnaire",
            "path": "QuestionnaireResponse.questionnaire",
            "short": "Form being answered",
            "definition": "The Questionnaire that defines and organizes the questions for which answers are being provided.",
            "comment": "If a QuestionnaireResponse references a Questionnaire, then the QuestionnaireResponse structure must be consistent with the Questionnaire (i.e. questions must be organized into the same groups, nested questions must still be nested, etc.).",
            "requirements": "Needed to allow editing of the questionnaire response in a manner that enforces the constraints of the original form.",
            "alias": [
              "Form"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "canonical",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Questionnaire"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "QuestionnaireResponse.status",
            "path": "QuestionnaireResponse.status",
            "short": "in-progress | completed | amended | entered-in-error | stopped",
            "definition": "The position of the questionnaire response within its overall lifecycle.",
            "comment": "This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.",
            "requirements": "The information on Questionnaire resources  may possibly be gathered during multiple sessions and altered after considered being finished.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labelled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "QuestionnaireResponseStatus"
                }
              ],
              "strength": "required",
              "description": "Lifecycle status of the questionnaire response.",
              "valueSet": "http://hl7.org/fhir/ValueSet/questionnaire-answers-status|4.0.0"
            }
          },
          {
            "id": "QuestionnaireResponse.subject",
            "path": "QuestionnaireResponse.subject",
            "short": "The subject of the questions",
            "definition": "The subject of the questionnaire response.  This could be a patient, organization, practitioner, device, etc.  This is who/what the answers apply to, but is not necessarily the source of information.",
            "comment": "If the Questionnaire declared a subjectType, the resource pointed to by this element must be an instance of one of the listed types.",
            "requirements": "Allows linking the answers to the individual the answers describe.  May also affect access control.",
            "alias": [
              "Patient",
              "Focus"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "QuestionnaireResponse.encounter",
            "path": "QuestionnaireResponse.encounter",
            "short": "Encounter created as part of",
            "definition": "The Encounter during which this questionnaire response was created or to which the creation of this record is tightly associated.",
            "comment": "This will typically be the encounter the event occurred within, but some activities may be initiated prior to or after the official completion of an encounter but still be tied to the context of the encounter. A questionnaire that was initiated during an encounter but not fully completed during the encounter would still generally be associated with the encounter.",
            "requirements": "Provides context for the information that was captured.  May also affect access control.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "QuestionnaireResponse.authored",
            "path": "QuestionnaireResponse.authored",
            "short": "Date the answers were gathered",
            "definition": "The date and/or time that this set of answers were last changed.",
            "comment": "May be different from the lastUpdateTime of the resource itself, because that reflects when the data was known to the server, not when the data was captured.\n\nThis element is optional to allow for systems that might not know the value, however it SHOULD be populated if possible.",
            "requirements": "Clinicians need to be able to check the date that the information in the questionnaire was collected, to derive the context of the answers.",
            "alias": [
              "Date Created",
              "Date published",
              "Date Issued",
              "Date updated"
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
            "id": "QuestionnaireResponse.author",
            "path": "QuestionnaireResponse.author",
            "short": "Person who received and recorded the answers",
            "definition": "Person who received the answers to the questions in the QuestionnaireResponse and recorded them in the system.",
            "comment": "Mapping a subject's answers to multiple choice options and determining what to put in the textual answer is a matter of interpretation.  Authoring by device would indicate that some portion of the questionnaire had been auto-populated.",
            "requirements": "Need to know who interpreted the subject's answers to the questions in the questionnaire, and selected the appropriate options for answers.",
            "alias": [
              "Laboratory",
              "Service",
              "Practitioner",
              "Department",
              "Company",
              "Performer"
            ],
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Organization"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "QuestionnaireResponse.source",
            "path": "QuestionnaireResponse.source",
            "short": "The person who answered the questions",
            "definition": "The person who answered the questions about the subject.",
            "comment": "If not specified, no inference can be made about who provided the data.",
            "requirements": "When answering questions about a subject that is minor, incapable of answering or an animal, another human source may answer the questions.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                ]
              }
            ],
            "isSummary": true
          },
          {
            "id": "QuestionnaireResponse.item",
            "path": "QuestionnaireResponse.item",
            "short": "Groups and questions",
            "definition": "A group or question item from the original questionnaire for which answers are provided.",
            "comment": "Groups cannot have answers and therefore must nest directly within item. When dealing with questions, nesting must occur within each answer because some questions may have multiple answers (and the nesting occurs for each answer).",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "QuestionnaireResponse.item.linkId",
            "path": "QuestionnaireResponse.item.linkId",
            "short": "Pointer to specific item from Questionnaire",
            "definition": "The item from the Questionnaire that corresponds to this item in the QuestionnaireResponse resource.",
            "requirements": "Items can repeat in the answers, so a direct 1..1 correspondence by position might not exist - requiring correspondence by identifier.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "QuestionnaireResponse.item.definition",
            "path": "QuestionnaireResponse.item.definition",
            "short": "ElementDefinition - details for the item",
            "definition": "A reference to an [ElementDefinition](elementdefinition.html) that provides the details for the item.",
            "comment": "The ElementDefinition must be in a [StructureDefinition](structuredefinition.html#), and must have a fragment identifier that identifies the specific data element by its id (Element.id). E.g. http://hl7.org/fhir/StructureDefinition/Observation#Observation.value[x].\n\nThere is no need for this element if the item pointed to by the linkId has a definition listed.",
            "requirements": "A common pattern is to define a set of data elements, and then build multiple different questionnaires for different circumstances to gather the data. This element provides traceability to the common definition.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "uri"
              }
            ]
          },
          {
            "id": "QuestionnaireResponse.item.text",
            "path": "QuestionnaireResponse.item.text",
            "short": "Name for group or question text",
            "definition": "Text that is displayed above the contents of the group or as the text of the question being answered.",
            "requirements": "Allows the questionnaire response to be read without access to the questionnaire.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "QuestionnaireResponse.item.answer",
            "path": "QuestionnaireResponse.item.answer",
            "short": "The response(s) to the question",
            "definition": "The respondent's answer(s) to the question.",
            "comment": "The value is nested because we cannot have a repeating structure that has variable type.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "QuestionnaireResponse.item.answer.value[x]",
            "path": "QuestionnaireResponse.item.answer.value[x]",
            "short": "Single-valued answer to the question",
            "definition": "The answer (or one of the answers) provided by the respondent to the question.",
            "comment": "More complex structures (Attachment, Resource and Quantity) will typically be limited to electronic forms that can expose an appropriate user interface to capture the components and enforce the constraints of a complex data type.  Additional complex types can be introduced through extensions. Must match the datatype specified by Questionnaire.item.type in the corresponding Questionnaire.",
            "requirements": "Ability to retain a single-valued answer to a question.",
            "min": 0,
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
                  "valueString": "QuestionnaireAnswer"
                }
              ],
              "strength": "example",
              "description": "Code indicating the response provided for a question.",
              "valueSet": "http://hl7.org/fhir/ValueSet/questionnaire-answers"
            }
          },
          {
            "id": "QuestionnaireResponse.item.answer.item",
            "path": "QuestionnaireResponse.item.answer.item",
            "short": "Nested groups and questions",
            "definition": "Nested groups and/or questions found within this particular answer.",
            "requirements": "It is useful to have \"sub-questions\", questions which normally appear when certain answers are given and which collect additional details.",
            "min": 0,
            "max": "*",
            "contentReference": "#QuestionnaireResponse.item"
          },
          {
            "id": "QuestionnaireResponse.item.item",
            "path": "QuestionnaireResponse.item.item",
            "short": "Nested questionnaire response items",
            "definition": "Questions or sub-groups nested beneath a question or group.",
            "requirements": "Reports can consist of complex nested groups.",
            "min": 0,
            "max": "*",
            "contentReference": "#QuestionnaireResponse.item"
          }
        ]
      }
    }
    #endif
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'QuestionnaireResponse'
    /// </summary>
    // 0. QuestionnaireResponse
    public class QuestionnaireResponse : FhirKhit.Maker.Common.Resource.ResourceBase                                                        // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class QuestionnaireResponse_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                           // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 11. QuestionnaireResponse.item
            public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase                                                              // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Item_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                               // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 15. QuestionnaireResponse.item.answer
                    public class Type_Answer : FhirKhit.Maker.Common.Complex.ComplexBase                                                    // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Answer_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                     // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 16. QuestionnaireResponse.item.answer.value[x]
                            public ElementDefinitionInfo Value;                                                                             // MakerGen.cs:236
                            // 17. QuestionnaireResponse.item.answer.item
                            public ElementDefinitionInfo Item;                                                                              // MakerGen.cs:236
                            public Type_Answer_Elements()                                                                                   // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 16. QuestionnaireResponse.item.answer.value[x]
                                    this.Value = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Value",                                                                                     // MakerGen.cs:255
                                        Path= "QuestionnaireResponse.item.answer.value[x]",                                                 // MakerGen.cs:256
                                        Id = "QuestionnaireResponse.item.answer.value[x]",                                                  // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Boolean                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            },                                                                                              // MakerGen.cs:303
                                            new FhirKhit.Maker.Common.Primitive.Decimal                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            },                                                                                              // MakerGen.cs:303
                                            new FhirKhit.Maker.Common.Primitive.Integer                                                     // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            },                                                                                              // MakerGen.cs:303
                                            new FhirKhit.Maker.Common.Primitive.Date                                                        // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            },                                                                                              // MakerGen.cs:303
                                            new FhirKhit.Maker.Common.Primitive.DateTime                                                    // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            },                                                                                              // MakerGen.cs:303
                                            new FhirKhit.Maker.Common.Primitive.Time                                                        // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            },                                                                                              // MakerGen.cs:303
                                            new FhirKhit.Maker.Common.Primitive.String                                                      // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            },                                                                                              // MakerGen.cs:303
                                            new FhirKhit.Maker.Common.Primitive.Uri                                                         // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            },                                                                                              // MakerGen.cs:303
                                            new FhirKhit.Maker.Common.Complex.Attachment                                                    // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            },                                                                                              // MakerGen.cs:359
                                            new FhirKhit.Maker.Common.Complex.Coding                                                        // MakerGen.cs:314
                                            {                                                                                               // MakerGen.cs:315
                                            },                                                                                              // MakerGen.cs:318
                                            new FhirKhit.Maker.Common.Complex.Quantity                                                      // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            },                                                                                              // MakerGen.cs:359
                                            new FhirKhit.Maker.Common.Complex.Reference                                                     // MakerGen.cs:345
                                            {                                                                                               // MakerGen.cs:346
                                                TargetProfile = new String[]                                                                // MakerGen.cs:348
                                                {                                                                                           // CodeEditorExtensions.cs:28
                                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                      // MakerGen.cs:348
                                                }                                                                                           // CodeEditorExtensions.cs:34
                                            }                                                                                               // MakerGen.cs:349
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 17. QuestionnaireResponse.item.answer.item
                                    this.Item = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Item",                                                                                      // MakerGen.cs:255
                                        Path= "QuestionnaireResponse.item.answer.item",                                                     // MakerGen.cs:256
                                        Id = "QuestionnaireResponse.item.answer.item",                                                      // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = -1,                                                                                           // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Value.Write(sDef);                                                                                          // MakerGen.cs:240
                                Item.Write(sDef);                                                                                           // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Answer_Elements Elements { get; }                                                                       // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Answer()                                                                                                // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Answer_Elements();                                                                     // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 12. QuestionnaireResponse.item.linkId
                    public ElementDefinitionInfo LinkId;                                                                                    // MakerGen.cs:236
                    // 13. QuestionnaireResponse.item.definition
                    public ElementDefinitionInfo Definition;                                                                                // MakerGen.cs:236
                    // 14. QuestionnaireResponse.item.text
                    public ElementDefinitionInfo Text;                                                                                      // MakerGen.cs:236
                    // 18. QuestionnaireResponse.item.item
                    public ElementDefinitionInfo Item;                                                                                      // MakerGen.cs:236
                    public Type_Item_Elements()                                                                                             // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 12. QuestionnaireResponse.item.linkId
                            this.LinkId = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "LinkId",                                                                                            // MakerGen.cs:255
                                Path= "QuestionnaireResponse.item.linkId",                                                                  // MakerGen.cs:256
                                Id = "QuestionnaireResponse.item.linkId",                                                                   // MakerGen.cs:257
                                Min = 1,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 13. QuestionnaireResponse.item.definition
                            this.Definition = new ElementDefinitionInfo                                                                     // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Definition",                                                                                        // MakerGen.cs:255
                                Path= "QuestionnaireResponse.item.definition",                                                              // MakerGen.cs:256
                                Id = "QuestionnaireResponse.item.definition",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Uri                                                                 // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 14. QuestionnaireResponse.item.text
                            this.Text = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Text",                                                                                              // MakerGen.cs:255
                                Path= "QuestionnaireResponse.item.text",                                                                    // MakerGen.cs:256
                                Id = "QuestionnaireResponse.item.text",                                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.String                                                              // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 18. QuestionnaireResponse.item.item
                            this.Item = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Item",                                                                                              // MakerGen.cs:255
                                Path= "QuestionnaireResponse.item.item",                                                                    // MakerGen.cs:256
                                Id = "QuestionnaireResponse.item.item",                                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                    }                                                                                                                       // MakerGen.cs:429
                    public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                     // MakerGen.cs:414
                    {                                                                                                                       // MakerGen.cs:415
                        base.Write(sDef);                                                                                                   // MakerGen.cs:416
                        LinkId.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Definition.Write(sDef);                                                                                             // MakerGen.cs:240
                        Text.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Item.Write(sDef);                                                                                                   // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Item_Elements Elements { get; }                                                                                 // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Item()                                                                                                          // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Item_Elements();                                                                               // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. QuestionnaireResponse.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. QuestionnaireResponse.basedOn
            public ElementDefinitionInfo BasedOn;                                                                                           // MakerGen.cs:236
            // 3. QuestionnaireResponse.partOf
            public ElementDefinitionInfo PartOf;                                                                                            // MakerGen.cs:236
            // 4. QuestionnaireResponse.questionnaire
            public ElementDefinitionInfo Questionnaire;                                                                                     // MakerGen.cs:236
            // 5. QuestionnaireResponse.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 6. QuestionnaireResponse.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:236
            // 7. QuestionnaireResponse.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:236
            // 8. QuestionnaireResponse.authored
            public ElementDefinitionInfo Authored;                                                                                          // MakerGen.cs:236
            // 9. QuestionnaireResponse.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:236
            // 10. QuestionnaireResponse.source
            public ElementDefinitionInfo Source;                                                                                            // MakerGen.cs:236
            public QuestionnaireResponse_Elements()                                                                                         // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. QuestionnaireResponse.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "QuestionnaireResponse.identifier",                                                                           // MakerGen.cs:256
                        Id = "QuestionnaireResponse.identifier",                                                                            // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. QuestionnaireResponse.basedOn
                    this.BasedOn = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "BasedOn",                                                                                                   // MakerGen.cs:255
                        Path= "QuestionnaireResponse.basedOn",                                                                              // MakerGen.cs:256
                        Id = "QuestionnaireResponse.basedOn",                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/CarePlan",                                                     // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/ServiceRequest"                                                // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. QuestionnaireResponse.partOf
                    this.PartOf = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "PartOf",                                                                                                    // MakerGen.cs:255
                        Path= "QuestionnaireResponse.partOf",                                                                               // MakerGen.cs:256
                        Id = "QuestionnaireResponse.partOf",                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Procedure"                                                     // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. QuestionnaireResponse.questionnaire
                    this.Questionnaire = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Questionnaire",                                                                                             // MakerGen.cs:255
                        Path= "QuestionnaireResponse.questionnaire",                                                                        // MakerGen.cs:256
                        Id = "QuestionnaireResponse.questionnaire",                                                                         // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                                TargetProfile = new String[]                                                                                // MakerGen.cs:302
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Questionnaire"                                                 // MakerGen.cs:302
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 5. QuestionnaireResponse.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "QuestionnaireResponse.status",                                                                               // MakerGen.cs:256
                        Id = "QuestionnaireResponse.status",                                                                                // MakerGen.cs:257
                        Min = 1,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Code                                                                        // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 6. QuestionnaireResponse.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Subject",                                                                                                   // MakerGen.cs:255
                        Path= "QuestionnaireResponse.subject",                                                                              // MakerGen.cs:256
                        Id = "QuestionnaireResponse.subject",                                                                               // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Resource"                                                      // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 7. QuestionnaireResponse.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Encounter",                                                                                                 // MakerGen.cs:255
                        Path= "QuestionnaireResponse.encounter",                                                                            // MakerGen.cs:256
                        Id = "QuestionnaireResponse.encounter",                                                                             // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Encounter"                                                     // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 8. QuestionnaireResponse.authored
                    this.Authored = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Authored",                                                                                                  // MakerGen.cs:255
                        Path= "QuestionnaireResponse.authored",                                                                             // MakerGen.cs:256
                        Id = "QuestionnaireResponse.authored",                                                                              // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.DateTime                                                                    // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 9. QuestionnaireResponse.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Author",                                                                                                    // MakerGen.cs:255
                        Path= "QuestionnaireResponse.author",                                                                               // MakerGen.cs:256
                        Id = "QuestionnaireResponse.author",                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Device",                                                       // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                                // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Organization"                                                  // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 10. QuestionnaireResponse.source
                    this.Source = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Source",                                                                                                    // MakerGen.cs:255
                        Path= "QuestionnaireResponse.source",                                                                               // MakerGen.cs:256
                        Id = "QuestionnaireResponse.source",                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",                                                 // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson"                                                 // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                BasedOn.Write(sDef);                                                                                                        // MakerGen.cs:240
                PartOf.Write(sDef);                                                                                                         // MakerGen.cs:240
                Questionnaire.Write(sDef);                                                                                                  // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:240
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:240
                Authored.Write(sDef);                                                                                                       // MakerGen.cs:240
                Author.Write(sDef);                                                                                                         // MakerGen.cs:240
                Source.Write(sDef);                                                                                                         // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public QuestionnaireResponse_Elements Elements { get; }                                                                             // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public QuestionnaireResponse()                                                                                                      // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new QuestionnaireResponse_Elements();                                                                           // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
