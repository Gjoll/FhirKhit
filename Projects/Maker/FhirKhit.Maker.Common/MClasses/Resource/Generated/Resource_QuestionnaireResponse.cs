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
    #endregion
    /// <summary>
    /// Fhir resource 'QuestionnaireResponse'
    /// </summary>
    // 0. QuestionnaireResponse
    public class Resource_QuestionnaireResponse : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 11. QuestionnaireResponse.item
        public class Type_Item : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 15. QuestionnaireResponse.item.answer
            public class Type_Answer : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 16. QuestionnaireResponse.item.answer.value[x]
                public ElementDefinitionInfo Element_Value;
                // 17. QuestionnaireResponse.item.answer.item
                public ElementDefinitionInfo Element_Item;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "QuestionnaireResponse.item.answer",
                        ElementId = "QuestionnaireResponse.item.answer"
                    });
                    Element_Value.Write(sDef);
                    Element_Item.Write(sDef);
                }
                
                public Type_Answer()
                {
                    {
                        // 16. QuestionnaireResponse.item.answer.value[x]
                        this.Element_Value = new ElementDefinitionInfo
                        {
                            Name = "Element_Value",
                            Path= "QuestionnaireResponse.item.answer.value[x]",
                            Id = "QuestionnaireResponse.item.answer.value[x]",
                            Min = 0,
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
                    {
                        // 17. QuestionnaireResponse.item.answer.item
                        this.Element_Item = new ElementDefinitionInfo
                        {
                            Name = "Element_Item",
                            Path= "QuestionnaireResponse.item.answer.item",
                            Id = "QuestionnaireResponse.item.answer.item",
                            Min = 0,
                            Max = -1,
                            Types = new BaseType[]
                            {
                            }
                        };
                    }
                }
            }
            // 12. QuestionnaireResponse.item.linkId
            public ElementDefinitionInfo Element_LinkId;
            // 13. QuestionnaireResponse.item.definition
            public ElementDefinitionInfo Element_Definition;
            // 14. QuestionnaireResponse.item.text
            public ElementDefinitionInfo Element_Text;
            // 15. QuestionnaireResponse.item.answer
            public ElementDefinitionInfo Element_Answer;
            // 18. QuestionnaireResponse.item.item
            public ElementDefinitionInfo Element_Item;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "QuestionnaireResponse.item",
                    ElementId = "QuestionnaireResponse.item"
                });
                Element_LinkId.Write(sDef);
                Element_Definition.Write(sDef);
                Element_Text.Write(sDef);
                Element_Answer.Write(sDef);
                Element_Item.Write(sDef);
            }
            
            public Type_Item()
            {
                {
                    // 12. QuestionnaireResponse.item.linkId
                    this.Element_LinkId = new ElementDefinitionInfo
                    {
                        Name = "Element_LinkId",
                        Path= "QuestionnaireResponse.item.linkId",
                        Id = "QuestionnaireResponse.item.linkId",
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
                    // 13. QuestionnaireResponse.item.definition
                    this.Element_Definition = new ElementDefinitionInfo
                    {
                        Name = "Element_Definition",
                        Path= "QuestionnaireResponse.item.definition",
                        Id = "QuestionnaireResponse.item.definition",
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
                    // 14. QuestionnaireResponse.item.text
                    this.Element_Text = new ElementDefinitionInfo
                    {
                        Name = "Element_Text",
                        Path= "QuestionnaireResponse.item.text",
                        Id = "QuestionnaireResponse.item.text",
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
                    // 15. QuestionnaireResponse.item.answer
                    this.Element_Answer = new ElementDefinitionInfo
                    {
                        Name = "Element_Answer",
                        Path= "QuestionnaireResponse.item.answer",
                        Id = "QuestionnaireResponse.item.answer",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Answer
                            {
                            }
                        }
                    };
                }
                {
                    // 18. QuestionnaireResponse.item.item
                    this.Element_Item = new ElementDefinitionInfo
                    {
                        Name = "Element_Item",
                        Path= "QuestionnaireResponse.item.item",
                        Id = "QuestionnaireResponse.item.item",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
            }
        }
        // 1. QuestionnaireResponse.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. QuestionnaireResponse.basedOn
        public ElementDefinitionInfo Element_BasedOn;
        // 3. QuestionnaireResponse.partOf
        public ElementDefinitionInfo Element_PartOf;
        // 4. QuestionnaireResponse.questionnaire
        public ElementDefinitionInfo Element_Questionnaire;
        // 5. QuestionnaireResponse.status
        public ElementDefinitionInfo Element_Status;
        // 6. QuestionnaireResponse.subject
        public ElementDefinitionInfo Element_Subject;
        // 7. QuestionnaireResponse.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 8. QuestionnaireResponse.authored
        public ElementDefinitionInfo Element_Authored;
        // 9. QuestionnaireResponse.author
        public ElementDefinitionInfo Element_Author;
        // 10. QuestionnaireResponse.source
        public ElementDefinitionInfo Element_Source;
        // 11. QuestionnaireResponse.item
        public ElementDefinitionInfo Element_Item;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "QuestionnaireResponse",
                ElementId = "QuestionnaireResponse"
            });
            Element_Identifier.Write(sDef);
            Element_BasedOn.Write(sDef);
            Element_PartOf.Write(sDef);
            Element_Questionnaire.Write(sDef);
            Element_Status.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_Authored.Write(sDef);
            Element_Author.Write(sDef);
            Element_Source.Write(sDef);
            Element_Item.Write(sDef);
        }
        
        public Resource_QuestionnaireResponse()
        {
            {
                // 1. QuestionnaireResponse.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "QuestionnaireResponse.identifier",
                    Id = "QuestionnaireResponse.identifier",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Identifier
                        {
                        }
                    }
                };
            }
            {
                // 2. QuestionnaireResponse.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo
                {
                    Name = "Element_BasedOn",
                    Path= "QuestionnaireResponse.basedOn",
                    Id = "QuestionnaireResponse.basedOn",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/CarePlan",
                                "http://hl7.org/fhir/StructureDefinition/ServiceRequest"
                            }
                        }
                    }
                };
            }
            {
                // 3. QuestionnaireResponse.partOf
                this.Element_PartOf = new ElementDefinitionInfo
                {
                    Name = "Element_PartOf",
                    Path= "QuestionnaireResponse.partOf",
                    Id = "QuestionnaireResponse.partOf",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Observation",
                                "http://hl7.org/fhir/StructureDefinition/Procedure"
                            }
                        }
                    }
                };
            }
            {
                // 4. QuestionnaireResponse.questionnaire
                this.Element_Questionnaire = new ElementDefinitionInfo
                {
                    Name = "Element_Questionnaire",
                    Path= "QuestionnaireResponse.questionnaire",
                    Id = "QuestionnaireResponse.questionnaire",
                    Min = 0,
                    Max = 1,
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
                // 5. QuestionnaireResponse.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "QuestionnaireResponse.status",
                    Id = "QuestionnaireResponse.status",
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
                // 6. QuestionnaireResponse.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "QuestionnaireResponse.subject",
                    Id = "QuestionnaireResponse.subject",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
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
                // 7. QuestionnaireResponse.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "QuestionnaireResponse.encounter",
                    Id = "QuestionnaireResponse.encounter",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Encounter"
                            }
                        }
                    }
                };
            }
            {
                // 8. QuestionnaireResponse.authored
                this.Element_Authored = new ElementDefinitionInfo
                {
                    Name = "Element_Authored",
                    Path= "QuestionnaireResponse.authored",
                    Id = "QuestionnaireResponse.authored",
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
                // 9. QuestionnaireResponse.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "QuestionnaireResponse.author",
                    Id = "QuestionnaireResponse.author",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Device",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                "http://hl7.org/fhir/StructureDefinition/Organization"
                            }
                        }
                    }
                };
            }
            {
                // 10. QuestionnaireResponse.source
                this.Element_Source = new ElementDefinitionInfo
                {
                    Name = "Element_Source",
                    Path= "QuestionnaireResponse.source",
                    Id = "QuestionnaireResponse.source",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                "http://hl7.org/fhir/StructureDefinition/RelatedPerson"
                            }
                        }
                    }
                };
            }
            {
                // 11. QuestionnaireResponse.item
                this.Element_Item = new ElementDefinitionInfo
                {
                    Name = "Element_Item",
                    Path= "QuestionnaireResponse.item",
                    Id = "QuestionnaireResponse.item",
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
            this.Name = "QuestionnaireResponse";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/QuestionnaireResponse";
        }
    }
}
