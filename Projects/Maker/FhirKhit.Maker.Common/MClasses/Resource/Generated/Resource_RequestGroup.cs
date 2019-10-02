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
      "id": "RequestGroup",
      "url": "http://hl7.org/fhir/StructureDefinition/RequestGroup",
      "version": "4.0.0",
      "name": "RequestGroup",
      "status": "draft",
      "publisher": "Health Level Seven International (Clinical Decision Support)",
      "description": "A group of related requests that can be used to capture intended activities that have inter-dependencies such as \"give this medication after that one\".",
      "fhirVersion": "4.0.0",
      "kind": "resource",
      "abstract": false,
      "type": "RequestGroup",
      "baseDefinition": "http://hl7.org/fhir/StructureDefinition/DomainResource",
      "derivation": "specialization",
      "differential": {
        "element": [
          {
            "id": "RequestGroup",
            "path": "RequestGroup",
            "short": "A group of related requests",
            "definition": "A group of related requests that can be used to capture intended activities that have inter-dependencies such as \"give this medication after that one\".",
            "min": 0,
            "max": "*"
          },
          {
            "id": "RequestGroup.identifier",
            "path": "RequestGroup.identifier",
            "short": "Business identifier",
            "definition": "Allows a service to provide a unique, business identifier for the request.",
            "requirements": "Allows identification of the request as it is known by various participating systems and in a way that remains consistent across servers.",
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
            "id": "RequestGroup.instantiatesCanonical",
            "path": "RequestGroup.instantiatesCanonical",
            "short": "Instantiates FHIR protocol or definition",
            "definition": "A canonical URL referencing a FHIR-defined protocol, guideline, orderset or other definition that is adhered to in whole or in part by this request.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "canonical"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RequestGroup.instantiatesUri",
            "path": "RequestGroup.instantiatesUri",
            "short": "Instantiates external protocol or definition",
            "definition": "A URL referencing an externally defined protocol, guideline, orderset or other definition that is adhered to in whole or in part by this request.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "uri"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RequestGroup.basedOn",
            "path": "RequestGroup.basedOn",
            "short": "Fulfills plan, proposal, or order",
            "definition": "A plan, proposal or order that is fulfilled in whole or in part by this request.",
            "requirements": "Allows tracing of authorization for the request and tracking whether proposals/recommendations were acted upon.",
            "alias": [
              "fulfills"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "RequestGroup.replaces",
            "path": "RequestGroup.replaces",
            "short": "Request(s) replaced by this request",
            "definition": "Completed or terminated request(s) whose function is taken by this new request.",
            "comment": "The replacement could be because the initial request was immediately rejected (due to an issue) or because the previous request was completed, but the need for the action described by the request remains ongoing.",
            "requirements": "Allows tracing the continuation of a therapy or administrative process instantiated through multiple requests.",
            "alias": [
              "supersedes",
              "prior",
              "renewed order"
            ],
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Resource"
                ]
              }
            ]
          },
          {
            "id": "RequestGroup.groupIdentifier",
            "path": "RequestGroup.groupIdentifier",
            "short": "Composite request this is part of",
            "definition": "A shared identifier common to all requests that were authorized more or less simultaneously by a single author, representing the identifier of the requisition, prescription or similar form.",
            "comment": "Requests are linked either by a \"basedOn\" relationship (i.e. one request is fulfilling another) or by having a common requisition.  Requests that are part of the same requisition are generally treated independently from the perspective of changing their state or maintaining them after initial creation.",
            "requirements": "Some business processes need to know if multiple items were ordered as part of the same \"prescription\" or \"requisition\" for billing or other purposes.",
            "alias": [
              "grouperid",
              "requisition"
            ],
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
            "id": "RequestGroup.status",
            "path": "RequestGroup.status",
            "short": "draft | active | suspended | cancelled | completed | entered-in-error | unknown",
            "definition": "The current state of the request. For request groups, the status reflects the status of all the requests in the group.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element is labeled as a modifier because it is a status element that contains status entered-in-error which means that the resource should not be treated as valid",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "RequestStatus"
                }
              ],
              "strength": "required",
              "description": "Codes identifying the lifecycle stage of a request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-status|4.0.0"
            }
          },
          {
            "id": "RequestGroup.intent",
            "path": "RequestGroup.intent",
            "short": "proposal | plan | order",
            "definition": "Indicates the level of authority/intentionality associated with the request and where the request fits into the workflow chain.",
            "requirements": "Proposals/recommendations, plans and orders all use the same structure and can exist in the same fulfillment chain.",
            "alias": [
              "category"
            ],
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "isModifier": true,
            "isModifierReason": "This element changes the interpretation of all descriptive attributes. For example \"the time the request is recommended to occur\" vs. \"the time the request is authorized to occur\" or \"who is recommended to perform the request\" vs. \"who is authorized to perform the request",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "RequestIntent"
                }
              ],
              "strength": "required",
              "description": "Codes indicating the degree of authority/intentionality associated with a request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-intent|4.0.0"
            }
          },
          {
            "id": "RequestGroup.priority",
            "path": "RequestGroup.priority",
            "short": "routine | urgent | asap | stat",
            "definition": "Indicates how quickly the request should be addressed with respect to other requests.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "code"
              }
            ],
            "meaningWhenMissing": "If missing, this request should be performed with normal priority",
            "isSummary": true,
            "binding": {
              "extension": [
                {
                  "url": "http://hl7.org/fhir/StructureDefinition/elementdefinition-bindingName",
                  "valueString": "RequestPriority"
                }
              ],
              "strength": "required",
              "description": "Identifies the level of importance to be assigned to actioning the request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-priority|4.0.0"
            }
          },
          {
            "id": "RequestGroup.code",
            "path": "RequestGroup.code",
            "short": "What's being requested/ordered",
            "definition": "A code that identifies what the overall request group is.",
            "comment": "This element can be used to provide a code that captures the meaning of the request group as a whole, as opposed to the code of the action element, which captures the meaning of the individual actions within the request group.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ],
            "isSummary": true
          },
          {
            "id": "RequestGroup.subject",
            "path": "RequestGroup.subject",
            "short": "Who the request group is about",
            "definition": "The subject for which the request group was created.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Group"
                ]
              }
            ]
          },
          {
            "id": "RequestGroup.encounter",
            "path": "RequestGroup.encounter",
            "short": "Created as part of",
            "definition": "Describes the context of the request group, if any.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Encounter"
                ]
              }
            ]
          },
          {
            "id": "RequestGroup.authoredOn",
            "path": "RequestGroup.authoredOn",
            "short": "When the request group was authored",
            "definition": "Indicates when the request group was created.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              }
            ]
          },
          {
            "id": "RequestGroup.author",
            "path": "RequestGroup.author",
            "short": "Device or practitioner that authored the request group",
            "definition": "Provides a reference to the author of the request group.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Device",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                ]
              }
            ]
          },
          {
            "id": "RequestGroup.reasonCode",
            "path": "RequestGroup.reasonCode",
            "short": "Why the request group is needed",
            "definition": "Describes the reason for the request group in coded or textual form.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "RequestGroup.reasonReference",
            "path": "RequestGroup.reasonReference",
            "short": "Why the request group is needed",
            "definition": "Indicates another resource whose existence justifies this request group.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Condition",
                  "http://hl7.org/fhir/StructureDefinition/Observation",
                  "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                  "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                ]
              }
            ]
          },
          {
            "id": "RequestGroup.note",
            "path": "RequestGroup.note",
            "short": "Additional notes about the response",
            "definition": "Provides a mechanism to communicate additional information about the response.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Annotation"
              }
            ]
          },
          {
            "id": "RequestGroup.action",
            "path": "RequestGroup.action",
            "short": "Proposed actions, if any",
            "definition": "The actions, if any, produced by the evaluation of the artifact.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "RequestGroup.action.prefix",
            "path": "RequestGroup.action.prefix",
            "short": "User-visible prefix for the action (e.g. 1. or A.)",
            "definition": "A user-visible prefix for the action.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "RequestGroup.action.title",
            "path": "RequestGroup.action.title",
            "short": "User-visible title",
            "definition": "The title of the action displayed to a user.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "string"
              }
            ]
          },
          {
            "id": "RequestGroup.action.description",
            "path": "RequestGroup.action.description",
            "short": "Short description of the action",
            "definition": "A short description of the action used to provide a summary to display to the user.",
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
            "id": "RequestGroup.action.textEquivalent",
            "path": "RequestGroup.action.textEquivalent",
            "short": "Static text equivalent of the action, used if the dynamic aspects cannot be interpreted by the receiving system",
            "definition": "A text equivalent of the action to be performed. This provides a human-interpretable description of the action when the definition is consumed by a system that might not be capable of interpreting it dynamically.",
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
            "id": "RequestGroup.action.priority",
            "path": "RequestGroup.action.priority",
            "short": "routine | urgent | asap | stat",
            "definition": "Indicates how quickly the action should be addressed with respect to other actions.",
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
                  "valueString": "RequestPriority"
                }
              ],
              "strength": "required",
              "description": "Identifies the level of importance to be assigned to actioning the request.",
              "valueSet": "http://hl7.org/fhir/ValueSet/request-priority|4.0.0"
            }
          },
          {
            "id": "RequestGroup.action.code",
            "path": "RequestGroup.action.code",
            "short": "Code representing the meaning of the action or sub-actions",
            "definition": "A code that provides meaning for the action or action group. For example, a section may have a LOINC code for a section of a documentation template.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "CodeableConcept"
              }
            ]
          },
          {
            "id": "RequestGroup.action.documentation",
            "path": "RequestGroup.action.documentation",
            "short": "Supporting documentation for the intended performer of the action",
            "definition": "Didactic or other informational resources associated with the action that can be provided to the CDS recipient. Information resources can include inline text commentary and links to web resources.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "RelatedArtifact"
              }
            ]
          },
          {
            "id": "RequestGroup.action.condition",
            "path": "RequestGroup.action.condition",
            "short": "Whether or not the action is applicable",
            "definition": "An expression that describes applicability criteria, or start/stop conditions for the action.",
            "comment": "When multiple conditions of the same kind are present, the effects are combined using AND semantics, so the overall condition is true only if all of the conditions are true.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "RequestGroup.action.condition.kind",
            "path": "RequestGroup.action.condition.kind",
            "short": "applicability | start | stop",
            "definition": "The kind of condition.",
            "comment": "Applicability criteria are used to determine immediate applicability when a plan definition is applied to a given context. Start and stop criteria are carried through application and used to describe enter/exit criteria for an action.",
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
                  "valueString": "ActionConditionKind"
                }
              ],
              "strength": "required",
              "description": "The kind of condition for the action.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-condition-kind|4.0.0"
            }
          },
          {
            "id": "RequestGroup.action.condition.expression",
            "path": "RequestGroup.action.condition.expression",
            "short": "Boolean-valued expression",
            "definition": "An expression that returns true or false, indicating whether or not the condition is satisfied.",
            "comment": "The expression may be inlined, or may be a reference to a named expression within a logic library referenced by the library element.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Expression"
              }
            ]
          },
          {
            "id": "RequestGroup.action.relatedAction",
            "path": "RequestGroup.action.relatedAction",
            "short": "Relationship to another action",
            "definition": "A relationship to another action such as \"before\" or \"30-60 minutes after start of\".",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "BackboneElement"
              }
            ]
          },
          {
            "id": "RequestGroup.action.relatedAction.actionId",
            "path": "RequestGroup.action.relatedAction.actionId",
            "short": "What action this is related to",
            "definition": "The element id of the action this is related to.",
            "min": 1,
            "max": "1",
            "type": [
              {
                "code": "id"
              }
            ]
          },
          {
            "id": "RequestGroup.action.relatedAction.relationship",
            "path": "RequestGroup.action.relatedAction.relationship",
            "short": "before-start | before | before-end | concurrent-with-start | concurrent | concurrent-with-end | after-start | after | after-end",
            "definition": "The relationship of this action to the related action.",
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
                  "valueString": "ActionRelationshipType"
                }
              ],
              "strength": "required",
              "description": "Defines the types of relationships between actions.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-relationship-type|4.0.0"
            }
          },
          {
            "id": "RequestGroup.action.relatedAction.offset[x]",
            "path": "RequestGroup.action.relatedAction.offset[x]",
            "short": "Time offset for the relationship",
            "definition": "A duration or range of durations to apply to the relationship. For example, 30-60 minutes before.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "Duration"
              },
              {
                "code": "Range"
              }
            ]
          },
          {
            "id": "RequestGroup.action.timing[x]",
            "path": "RequestGroup.action.timing[x]",
            "short": "When the action should take place",
            "definition": "An optional value describing when the action should be performed.",
            "min": 0,
            "max": "1",
            "type": [
              {
                "code": "dateTime"
              },
              {
                "code": "Age"
              },
              {
                "code": "Period"
              },
              {
                "code": "Duration"
              },
              {
                "code": "Range"
              },
              {
                "code": "Timing"
              }
            ]
          },
          {
            "id": "RequestGroup.action.participant",
            "path": "RequestGroup.action.participant",
            "short": "Who should perform the action",
            "definition": "The participant that should perform or be responsible for this action.",
            "min": 0,
            "max": "*",
            "type": [
              {
                "code": "Reference",
                "targetProfile": [
                  "http://hl7.org/fhir/StructureDefinition/Patient",
                  "http://hl7.org/fhir/StructureDefinition/Practitioner",
                  "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                  "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                  "http://hl7.org/fhir/StructureDefinition/Device"
                ]
              }
            ]
          },
          {
            "id": "RequestGroup.action.type",
            "path": "RequestGroup.action.type",
            "short": "create | update | remove | fire-event",
            "definition": "The type of action to perform (create, update, remove).",
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
                  "valueString": "ActionType"
                }
              ],
              "strength": "extensible",
              "description": "The type of action to be performed.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-type"
            }
          },
          {
            "id": "RequestGroup.action.groupingBehavior",
            "path": "RequestGroup.action.groupingBehavior",
            "short": "visual-group | logical-group | sentence-group",
            "definition": "Defines the grouping behavior for the action and its children.",
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
                  "valueString": "ActionGroupingBehavior"
                }
              ],
              "strength": "required",
              "description": "Defines organization behavior of a group.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-grouping-behavior|4.0.0"
            }
          },
          {
            "id": "RequestGroup.action.selectionBehavior",
            "path": "RequestGroup.action.selectionBehavior",
            "short": "any | all | all-or-none | exactly-one | at-most-one | one-or-more",
            "definition": "Defines the selection behavior for the action and its children.",
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
                  "valueString": "ActionSelectionBehavior"
                }
              ],
              "strength": "required",
              "description": "Defines selection behavior of a group.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-selection-behavior|4.0.0"
            }
          },
          {
            "id": "RequestGroup.action.requiredBehavior",
            "path": "RequestGroup.action.requiredBehavior",
            "short": "must | could | must-unless-documented",
            "definition": "Defines expectations around whether an action is required.",
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
                  "valueString": "ActionRequiredBehavior"
                }
              ],
              "strength": "required",
              "description": "Defines expectations around whether an action or action group is required.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-required-behavior|4.0.0"
            }
          },
          {
            "id": "RequestGroup.action.precheckBehavior",
            "path": "RequestGroup.action.precheckBehavior",
            "short": "yes | no",
            "definition": "Defines whether the action should usually be preselected.",
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
                  "valueString": "ActionPrecheckBehavior"
                }
              ],
              "strength": "required",
              "description": "Defines selection frequency behavior for an action or group.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-precheck-behavior|4.0.0"
            }
          },
          {
            "id": "RequestGroup.action.cardinalityBehavior",
            "path": "RequestGroup.action.cardinalityBehavior",
            "short": "single | multiple",
            "definition": "Defines whether the action can be selected multiple times.",
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
                  "valueString": "ActionCardinalityBehavior"
                }
              ],
              "strength": "required",
              "description": "Defines behavior for an action or a group for how many times that item may be repeated.",
              "valueSet": "http://hl7.org/fhir/ValueSet/action-cardinality-behavior|4.0.0"
            }
          },
          {
            "id": "RequestGroup.action.resource",
            "path": "RequestGroup.action.resource",
            "short": "The target of the action",
            "definition": "The resource that is the target of the action (e.g. CommunicationRequest).",
            "comment": "The target resource SHALL be a [Request](request.html) resource with a Request.intent set to \"option\".",
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
            "condition": [
              "rqg-1"
            ]
          },
          {
            "id": "RequestGroup.action.action",
            "path": "RequestGroup.action.action",
            "short": "Sub action",
            "definition": "Sub actions.",
            "min": 0,
            "max": "*",
            "contentReference": "#RequestGroup.action",
            "condition": [
              "rqg-1"
            ]
          }
        ]
      }
    }
    #endif
    #endregion
    /// <summary>
    /// Fhir resource 'RequestGroup'
    /// </summary>
    // 0. RequestGroup
    public partial class Resource_RequestGroup : FhirKhit.Maker.Common.Resource.Resource_DomainResource
    {
        // 18. RequestGroup.action
        public partial class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase
        {
            // 26. RequestGroup.action.condition
            public partial class Type_Condition : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 27. RequestGroup.action.condition.kind
                public ElementDefinitionInfo Element_Kind;
                // 28. RequestGroup.action.condition.expression
                public ElementDefinitionInfo Element_Expression;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "RequestGroup.action.condition",
                        ElementId = "RequestGroup.action.condition"
                    });
                    Element_Kind.Write(sDef);
                    Element_Expression.Write(sDef);
                }
                
                public Type_Condition()
                {
                    {
                        // 27. RequestGroup.action.condition.kind
                        this.Element_Kind = new ElementDefinitionInfo
                        {
                            Name = "Element_Kind",
                            Path= "RequestGroup.action.condition.kind",
                            Id = "RequestGroup.action.condition.kind",
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
                        // 28. RequestGroup.action.condition.expression
                        this.Element_Expression = new ElementDefinitionInfo
                        {
                            Name = "Element_Expression",
                            Path= "RequestGroup.action.condition.expression",
                            Id = "RequestGroup.action.condition.expression",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Expression
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 29. RequestGroup.action.relatedAction
            public partial class Type_RelatedAction : FhirKhit.Maker.Common.Complex.ComplexBase
            {
                // 30. RequestGroup.action.relatedAction.actionId
                public ElementDefinitionInfo Element_ActionId;
                // 31. RequestGroup.action.relatedAction.relationship
                public ElementDefinitionInfo Element_Relationship;
                // 32. RequestGroup.action.relatedAction.offset[x]
                public ElementDefinitionInfo Element_Offset;
                
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
                {
                    base.Write(sDef);
                    sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                    {
                        Path = "RequestGroup.action.relatedAction",
                        ElementId = "RequestGroup.action.relatedAction"
                    });
                    Element_ActionId.Write(sDef);
                    Element_Relationship.Write(sDef);
                    Element_Offset.Write(sDef);
                }
                
                public Type_RelatedAction()
                {
                    {
                        // 30. RequestGroup.action.relatedAction.actionId
                        this.Element_ActionId = new ElementDefinitionInfo
                        {
                            Name = "Element_ActionId",
                            Path= "RequestGroup.action.relatedAction.actionId",
                            Id = "RequestGroup.action.relatedAction.actionId",
                            Min = 1,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Primitive.Primitive_Id
                                {
                                }
                            }
                        };
                    }
                    {
                        // 31. RequestGroup.action.relatedAction.relationship
                        this.Element_Relationship = new ElementDefinitionInfo
                        {
                            Name = "Element_Relationship",
                            Path= "RequestGroup.action.relatedAction.relationship",
                            Id = "RequestGroup.action.relatedAction.relationship",
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
                        // 32. RequestGroup.action.relatedAction.offset[x]
                        this.Element_Offset = new ElementDefinitionInfo
                        {
                            Name = "Element_Offset",
                            Path= "RequestGroup.action.relatedAction.offset[x]",
                            Id = "RequestGroup.action.relatedAction.offset[x]",
                            Min = 0,
                            Max = 1,
                            Types = new BaseType[]
                            {
                                new FhirKhit.Maker.Common.Complex.Type_Duration
                                {
                                },
                                new FhirKhit.Maker.Common.Complex.Type_Range
                                {
                                }
                            }
                        };
                    }
                }
            }
            // 19. RequestGroup.action.prefix
            public ElementDefinitionInfo Element_Prefix;
            // 20. RequestGroup.action.title
            public ElementDefinitionInfo Element_Title;
            // 21. RequestGroup.action.description
            public ElementDefinitionInfo Element_Description;
            // 22. RequestGroup.action.textEquivalent
            public ElementDefinitionInfo Element_TextEquivalent;
            // 23. RequestGroup.action.priority
            public ElementDefinitionInfo Element_Priority;
            // 24. RequestGroup.action.code
            public ElementDefinitionInfo Element_Code;
            // 25. RequestGroup.action.documentation
            public ElementDefinitionInfo Element_Documentation;
            // 26. RequestGroup.action.condition
            public ElementDefinitionInfo Element_Condition;
            // 29. RequestGroup.action.relatedAction
            public ElementDefinitionInfo Element_RelatedAction;
            // 33. RequestGroup.action.timing[x]
            public ElementDefinitionInfo Element_Timing;
            // 34. RequestGroup.action.participant
            public ElementDefinitionInfo Element_Participant;
            // 35. RequestGroup.action.type
            public ElementDefinitionInfo Element_Type;
            // 36. RequestGroup.action.groupingBehavior
            public ElementDefinitionInfo Element_GroupingBehavior;
            // 37. RequestGroup.action.selectionBehavior
            public ElementDefinitionInfo Element_SelectionBehavior;
            // 38. RequestGroup.action.requiredBehavior
            public ElementDefinitionInfo Element_RequiredBehavior;
            // 39. RequestGroup.action.precheckBehavior
            public ElementDefinitionInfo Element_PrecheckBehavior;
            // 40. RequestGroup.action.cardinalityBehavior
            public ElementDefinitionInfo Element_CardinalityBehavior;
            // 41. RequestGroup.action.resource
            public ElementDefinitionInfo Element_Resource;
            // 42. RequestGroup.action.action
            public ElementDefinitionInfo Element_Action;
            
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
            {
                base.Write(sDef);
                sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
                {
                    Path = "RequestGroup.action",
                    ElementId = "RequestGroup.action"
                });
                Element_Prefix.Write(sDef);
                Element_Title.Write(sDef);
                Element_Description.Write(sDef);
                Element_TextEquivalent.Write(sDef);
                Element_Priority.Write(sDef);
                Element_Code.Write(sDef);
                Element_Documentation.Write(sDef);
                Element_Condition.Write(sDef);
                Element_RelatedAction.Write(sDef);
                Element_Timing.Write(sDef);
                Element_Participant.Write(sDef);
                Element_Type.Write(sDef);
                Element_GroupingBehavior.Write(sDef);
                Element_SelectionBehavior.Write(sDef);
                Element_RequiredBehavior.Write(sDef);
                Element_PrecheckBehavior.Write(sDef);
                Element_CardinalityBehavior.Write(sDef);
                Element_Resource.Write(sDef);
                Element_Action.Write(sDef);
            }
            
            public Type_Action()
            {
                {
                    // 19. RequestGroup.action.prefix
                    this.Element_Prefix = new ElementDefinitionInfo
                    {
                        Name = "Element_Prefix",
                        Path= "RequestGroup.action.prefix",
                        Id = "RequestGroup.action.prefix",
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
                    // 20. RequestGroup.action.title
                    this.Element_Title = new ElementDefinitionInfo
                    {
                        Name = "Element_Title",
                        Path= "RequestGroup.action.title",
                        Id = "RequestGroup.action.title",
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
                    // 21. RequestGroup.action.description
                    this.Element_Description = new ElementDefinitionInfo
                    {
                        Name = "Element_Description",
                        Path= "RequestGroup.action.description",
                        Id = "RequestGroup.action.description",
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
                    // 22. RequestGroup.action.textEquivalent
                    this.Element_TextEquivalent = new ElementDefinitionInfo
                    {
                        Name = "Element_TextEquivalent",
                        Path= "RequestGroup.action.textEquivalent",
                        Id = "RequestGroup.action.textEquivalent",
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
                    // 23. RequestGroup.action.priority
                    this.Element_Priority = new ElementDefinitionInfo
                    {
                        Name = "Element_Priority",
                        Path= "RequestGroup.action.priority",
                        Id = "RequestGroup.action.priority",
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
                    // 24. RequestGroup.action.code
                    this.Element_Code = new ElementDefinitionInfo
                    {
                        Name = "Element_Code",
                        Path= "RequestGroup.action.code",
                        Id = "RequestGroup.action.code",
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
                    // 25. RequestGroup.action.documentation
                    this.Element_Documentation = new ElementDefinitionInfo
                    {
                        Name = "Element_Documentation",
                        Path= "RequestGroup.action.documentation",
                        Id = "RequestGroup.action.documentation",
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
                    // 26. RequestGroup.action.condition
                    this.Element_Condition = new ElementDefinitionInfo
                    {
                        Name = "Element_Condition",
                        Path= "RequestGroup.action.condition",
                        Id = "RequestGroup.action.condition",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_Condition
                            {
                            }
                        }
                    };
                }
                {
                    // 29. RequestGroup.action.relatedAction
                    this.Element_RelatedAction = new ElementDefinitionInfo
                    {
                        Name = "Element_RelatedAction",
                        Path= "RequestGroup.action.relatedAction",
                        Id = "RequestGroup.action.relatedAction",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new Type_RelatedAction
                            {
                            }
                        }
                    };
                }
                {
                    // 33. RequestGroup.action.timing[x]
                    this.Element_Timing = new ElementDefinitionInfo
                    {
                        Name = "Element_Timing",
                        Path= "RequestGroup.action.timing[x]",
                        Id = "RequestGroup.action.timing[x]",
                        Min = 0,
                        Max = 1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Primitive.Primitive_DateTime
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Age
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Period
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Duration
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Range
                            {
                            },
                            new FhirKhit.Maker.Common.Complex.Type_Timing
                            {
                            }
                        }
                    };
                }
                {
                    // 34. RequestGroup.action.participant
                    this.Element_Participant = new ElementDefinitionInfo
                    {
                        Name = "Element_Participant",
                        Path= "RequestGroup.action.participant",
                        Id = "RequestGroup.action.participant",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                            new FhirKhit.Maker.Common.Complex.Type_Reference
                            {
                                TargetProfile = new String[]
                                {
                                    "http://hl7.org/fhir/StructureDefinition/Patient",
                                    "http://hl7.org/fhir/StructureDefinition/Practitioner",
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole",
                                    "http://hl7.org/fhir/StructureDefinition/RelatedPerson",
                                    "http://hl7.org/fhir/StructureDefinition/Device"
                                }
                            }
                        }
                    };
                }
                {
                    // 35. RequestGroup.action.type
                    this.Element_Type = new ElementDefinitionInfo
                    {
                        Name = "Element_Type",
                        Path= "RequestGroup.action.type",
                        Id = "RequestGroup.action.type",
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
                    // 36. RequestGroup.action.groupingBehavior
                    this.Element_GroupingBehavior = new ElementDefinitionInfo
                    {
                        Name = "Element_GroupingBehavior",
                        Path= "RequestGroup.action.groupingBehavior",
                        Id = "RequestGroup.action.groupingBehavior",
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
                    // 37. RequestGroup.action.selectionBehavior
                    this.Element_SelectionBehavior = new ElementDefinitionInfo
                    {
                        Name = "Element_SelectionBehavior",
                        Path= "RequestGroup.action.selectionBehavior",
                        Id = "RequestGroup.action.selectionBehavior",
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
                    // 38. RequestGroup.action.requiredBehavior
                    this.Element_RequiredBehavior = new ElementDefinitionInfo
                    {
                        Name = "Element_RequiredBehavior",
                        Path= "RequestGroup.action.requiredBehavior",
                        Id = "RequestGroup.action.requiredBehavior",
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
                    // 39. RequestGroup.action.precheckBehavior
                    this.Element_PrecheckBehavior = new ElementDefinitionInfo
                    {
                        Name = "Element_PrecheckBehavior",
                        Path= "RequestGroup.action.precheckBehavior",
                        Id = "RequestGroup.action.precheckBehavior",
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
                    // 40. RequestGroup.action.cardinalityBehavior
                    this.Element_CardinalityBehavior = new ElementDefinitionInfo
                    {
                        Name = "Element_CardinalityBehavior",
                        Path= "RequestGroup.action.cardinalityBehavior",
                        Id = "RequestGroup.action.cardinalityBehavior",
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
                    // 41. RequestGroup.action.resource
                    this.Element_Resource = new ElementDefinitionInfo
                    {
                        Name = "Element_Resource",
                        Path= "RequestGroup.action.resource",
                        Id = "RequestGroup.action.resource",
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
                    // 42. RequestGroup.action.action
                    this.Element_Action = new ElementDefinitionInfo
                    {
                        Name = "Element_Action",
                        Path= "RequestGroup.action.action",
                        Id = "RequestGroup.action.action",
                        Min = 0,
                        Max = -1,
                        Types = new BaseType[]
                        {
                        }
                    };
                }
            }
        }
        // 1. RequestGroup.identifier
        public ElementDefinitionInfo Element_Identifier;
        // 2. RequestGroup.instantiatesCanonical
        public ElementDefinitionInfo Element_InstantiatesCanonical;
        // 3. RequestGroup.instantiatesUri
        public ElementDefinitionInfo Element_InstantiatesUri;
        // 4. RequestGroup.basedOn
        public ElementDefinitionInfo Element_BasedOn;
        // 5. RequestGroup.replaces
        public ElementDefinitionInfo Element_Replaces;
        // 6. RequestGroup.groupIdentifier
        public ElementDefinitionInfo Element_GroupIdentifier;
        // 7. RequestGroup.status
        public ElementDefinitionInfo Element_Status;
        // 8. RequestGroup.intent
        public ElementDefinitionInfo Element_Intent;
        // 9. RequestGroup.priority
        public ElementDefinitionInfo Element_Priority;
        // 10. RequestGroup.code
        public ElementDefinitionInfo Element_Code;
        // 11. RequestGroup.subject
        public ElementDefinitionInfo Element_Subject;
        // 12. RequestGroup.encounter
        public ElementDefinitionInfo Element_Encounter;
        // 13. RequestGroup.authoredOn
        public ElementDefinitionInfo Element_AuthoredOn;
        // 14. RequestGroup.author
        public ElementDefinitionInfo Element_Author;
        // 15. RequestGroup.reasonCode
        public ElementDefinitionInfo Element_ReasonCode;
        // 16. RequestGroup.reasonReference
        public ElementDefinitionInfo Element_ReasonReference;
        // 17. RequestGroup.note
        public ElementDefinitionInfo Element_Note;
        // 18. RequestGroup.action
        public ElementDefinitionInfo Element_Action;
        
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)
        {
            base.Write(sDef);
            sDef.Differential.Element.Add(new Hl7.Fhir.Model.ElementDefinition
            {
                Path = "RequestGroup",
                ElementId = "RequestGroup"
            });
            Element_Identifier.Write(sDef);
            Element_InstantiatesCanonical.Write(sDef);
            Element_InstantiatesUri.Write(sDef);
            Element_BasedOn.Write(sDef);
            Element_Replaces.Write(sDef);
            Element_GroupIdentifier.Write(sDef);
            Element_Status.Write(sDef);
            Element_Intent.Write(sDef);
            Element_Priority.Write(sDef);
            Element_Code.Write(sDef);
            Element_Subject.Write(sDef);
            Element_Encounter.Write(sDef);
            Element_AuthoredOn.Write(sDef);
            Element_Author.Write(sDef);
            Element_ReasonCode.Write(sDef);
            Element_ReasonReference.Write(sDef);
            Element_Note.Write(sDef);
            Element_Action.Write(sDef);
        }
        
        public Resource_RequestGroup()
        {
            {
                // 1. RequestGroup.identifier
                this.Element_Identifier = new ElementDefinitionInfo
                {
                    Name = "Element_Identifier",
                    Path= "RequestGroup.identifier",
                    Id = "RequestGroup.identifier",
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
                // 2. RequestGroup.instantiatesCanonical
                this.Element_InstantiatesCanonical = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesCanonical",
                    Path= "RequestGroup.instantiatesCanonical",
                    Id = "RequestGroup.instantiatesCanonical",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Canonical
                        {
                        }
                    }
                };
            }
            {
                // 3. RequestGroup.instantiatesUri
                this.Element_InstantiatesUri = new ElementDefinitionInfo
                {
                    Name = "Element_InstantiatesUri",
                    Path= "RequestGroup.instantiatesUri",
                    Id = "RequestGroup.instantiatesUri",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Primitive.Primitive_Uri
                        {
                        }
                    }
                };
            }
            {
                // 4. RequestGroup.basedOn
                this.Element_BasedOn = new ElementDefinitionInfo
                {
                    Name = "Element_BasedOn",
                    Path= "RequestGroup.basedOn",
                    Id = "RequestGroup.basedOn",
                    Min = 0,
                    Max = -1,
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
                // 5. RequestGroup.replaces
                this.Element_Replaces = new ElementDefinitionInfo
                {
                    Name = "Element_Replaces",
                    Path= "RequestGroup.replaces",
                    Id = "RequestGroup.replaces",
                    Min = 0,
                    Max = -1,
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
                // 6. RequestGroup.groupIdentifier
                this.Element_GroupIdentifier = new ElementDefinitionInfo
                {
                    Name = "Element_GroupIdentifier",
                    Path= "RequestGroup.groupIdentifier",
                    Id = "RequestGroup.groupIdentifier",
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
                // 7. RequestGroup.status
                this.Element_Status = new ElementDefinitionInfo
                {
                    Name = "Element_Status",
                    Path= "RequestGroup.status",
                    Id = "RequestGroup.status",
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
                // 8. RequestGroup.intent
                this.Element_Intent = new ElementDefinitionInfo
                {
                    Name = "Element_Intent",
                    Path= "RequestGroup.intent",
                    Id = "RequestGroup.intent",
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
                // 9. RequestGroup.priority
                this.Element_Priority = new ElementDefinitionInfo
                {
                    Name = "Element_Priority",
                    Path= "RequestGroup.priority",
                    Id = "RequestGroup.priority",
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
                // 10. RequestGroup.code
                this.Element_Code = new ElementDefinitionInfo
                {
                    Name = "Element_Code",
                    Path= "RequestGroup.code",
                    Id = "RequestGroup.code",
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
                // 11. RequestGroup.subject
                this.Element_Subject = new ElementDefinitionInfo
                {
                    Name = "Element_Subject",
                    Path= "RequestGroup.subject",
                    Id = "RequestGroup.subject",
                    Min = 0,
                    Max = 1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Patient",
                                "http://hl7.org/fhir/StructureDefinition/Group"
                            }
                        }
                    }
                };
            }
            {
                // 12. RequestGroup.encounter
                this.Element_Encounter = new ElementDefinitionInfo
                {
                    Name = "Element_Encounter",
                    Path= "RequestGroup.encounter",
                    Id = "RequestGroup.encounter",
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
                // 13. RequestGroup.authoredOn
                this.Element_AuthoredOn = new ElementDefinitionInfo
                {
                    Name = "Element_AuthoredOn",
                    Path= "RequestGroup.authoredOn",
                    Id = "RequestGroup.authoredOn",
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
                // 14. RequestGroup.author
                this.Element_Author = new ElementDefinitionInfo
                {
                    Name = "Element_Author",
                    Path= "RequestGroup.author",
                    Id = "RequestGroup.author",
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
                                "http://hl7.org/fhir/StructureDefinition/PractitionerRole"
                            }
                        }
                    }
                };
            }
            {
                // 15. RequestGroup.reasonCode
                this.Element_ReasonCode = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonCode",
                    Path= "RequestGroup.reasonCode",
                    Id = "RequestGroup.reasonCode",
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
                // 16. RequestGroup.reasonReference
                this.Element_ReasonReference = new ElementDefinitionInfo
                {
                    Name = "Element_ReasonReference",
                    Path= "RequestGroup.reasonReference",
                    Id = "RequestGroup.reasonReference",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new FhirKhit.Maker.Common.Complex.Type_Reference
                        {
                            TargetProfile = new String[]
                            {
                                "http://hl7.org/fhir/StructureDefinition/Condition",
                                "http://hl7.org/fhir/StructureDefinition/Observation",
                                "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",
                                "http://hl7.org/fhir/StructureDefinition/DocumentReference"
                            }
                        }
                    }
                };
            }
            {
                // 17. RequestGroup.note
                this.Element_Note = new ElementDefinitionInfo
                {
                    Name = "Element_Note",
                    Path= "RequestGroup.note",
                    Id = "RequestGroup.note",
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
                // 18. RequestGroup.action
                this.Element_Action = new ElementDefinitionInfo
                {
                    Name = "Element_Action",
                    Path= "RequestGroup.action",
                    Id = "RequestGroup.action",
                    Min = 0,
                    Max = -1,
                    Types = new BaseType[]
                    {
                        new Type_Action
                        {
                        }
                    }
                };
            }
            this.Name = "RequestGroup";
            this.Uri = "http://hl7.org/fhir/StructureDefinition/RequestGroup";
        }
    }
}
