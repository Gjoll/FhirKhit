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
    #endregion                                                                                                                              // MakerGen.cs:463
    /// <summary>
    /// Fhir resource 'RequestGroup'
    /// </summary>
    // 0. RequestGroup
    public class RequestGroup : FhirKhit.Maker.Common.Resource.ResourceBase                                                                 // MakerGen.cs:385
    {                                                                                                                                       // MakerGen.cs:386
        public class RequestGroup_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                                    // MakerGen.cs:387
        {                                                                                                                                   // MakerGen.cs:388
            // 18. RequestGroup.action
            public class Type_Action : FhirKhit.Maker.Common.Complex.ComplexBase                                                            // MakerGen.cs:385
            {                                                                                                                               // MakerGen.cs:386
                public class Type_Action_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                             // MakerGen.cs:387
                {                                                                                                                           // MakerGen.cs:388
                    // 26. RequestGroup.action.condition
                    public class Type_Condition : FhirKhit.Maker.Common.Complex.ComplexBase                                                 // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_Condition_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                                  // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 27. RequestGroup.action.condition.kind
                            public ElementDefinitionInfo Kind;                                                                              // MakerGen.cs:236
                            // 28. RequestGroup.action.condition.expression
                            public ElementDefinitionInfo Expression;                                                                        // MakerGen.cs:236
                            public Type_Condition_Elements()                                                                                // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 27. RequestGroup.action.condition.kind
                                    this.Kind = new ElementDefinitionInfo                                                                   // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Kind",                                                                                      // MakerGen.cs:255
                                        Path= "RequestGroup.action.condition.kind",                                                         // MakerGen.cs:256
                                        Id = "RequestGroup.action.condition.kind",                                                          // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 28. RequestGroup.action.condition.expression
                                    this.Expression = new ElementDefinitionInfo                                                             // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Expression",                                                                                // MakerGen.cs:255
                                        Path= "RequestGroup.action.condition.expression",                                                   // MakerGen.cs:256
                                        Id = "RequestGroup.action.condition.expression",                                                    // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Expression                                                    // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                Kind.Write(sDef);                                                                                           // MakerGen.cs:240
                                Expression.Write(sDef);                                                                                     // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_Condition_Elements Elements { get; }                                                                    // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_Condition()                                                                                             // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_Condition_Elements();                                                                  // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 29. RequestGroup.action.relatedAction
                    public class Type_RelatedAction : FhirKhit.Maker.Common.Complex.ComplexBase                                             // MakerGen.cs:385
                    {                                                                                                                       // MakerGen.cs:386
                        public class Type_RelatedAction_Elements : FhirKhit.Maker.Common.Resource.ElementsBase                              // MakerGen.cs:387
                        {                                                                                                                   // MakerGen.cs:388
                            // 30. RequestGroup.action.relatedAction.actionId
                            public ElementDefinitionInfo ActionId;                                                                          // MakerGen.cs:236
                            // 31. RequestGroup.action.relatedAction.relationship
                            public ElementDefinitionInfo Relationship;                                                                      // MakerGen.cs:236
                            // 32. RequestGroup.action.relatedAction.offset[x]
                            public ElementDefinitionInfo Offset;                                                                            // MakerGen.cs:236
                            public Type_RelatedAction_Elements()                                                                            // MakerGen.cs:409
                            {                                                                                                               // MakerGen.cs:410
                                {                                                                                                           // MakerGen.cs:251
                                    // 30. RequestGroup.action.relatedAction.actionId
                                    this.ActionId = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "ActionId",                                                                                  // MakerGen.cs:255
                                        Path= "RequestGroup.action.relatedAction.actionId",                                                 // MakerGen.cs:256
                                        Id = "RequestGroup.action.relatedAction.actionId",                                                  // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Id                                                          // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 31. RequestGroup.action.relatedAction.relationship
                                    this.Relationship = new ElementDefinitionInfo                                                           // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Relationship",                                                                              // MakerGen.cs:255
                                        Path= "RequestGroup.action.relatedAction.relationship",                                             // MakerGen.cs:256
                                        Id = "RequestGroup.action.relatedAction.relationship",                                              // MakerGen.cs:257
                                        Min = 1,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Primitive.Code                                                        // MakerGen.cs:299
                                            {                                                                                               // MakerGen.cs:300
                                            }                                                                                               // MakerGen.cs:303
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                                {                                                                                                           // MakerGen.cs:251
                                    // 32. RequestGroup.action.relatedAction.offset[x]
                                    this.Offset = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                                    {                                                                                                       // MakerGen.cs:254
                                        Name = "Offset",                                                                                    // MakerGen.cs:255
                                        Path= "RequestGroup.action.relatedAction.offset[x]",                                                // MakerGen.cs:256
                                        Id = "RequestGroup.action.relatedAction.offset[x]",                                                 // MakerGen.cs:257
                                        Min = 0,                                                                                            // MakerGen.cs:258
                                        Max = 1,                                                                                            // MakerGen.cs:259
                                        Types = new BaseType[]                                                                              // MakerGen.cs:260
                                        {                                                                                                   // MakerGen.cs:261
                                            new FhirKhit.Maker.Common.Complex.Duration                                                      // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            },                                                                                              // MakerGen.cs:359
                                            new FhirKhit.Maker.Common.Complex.Range                                                         // MakerGen.cs:357
                                            {                                                                                               // MakerGen.cs:358
                                            }                                                                                               // MakerGen.cs:359
                                        }                                                                                                   // MakerGen.cs:263
                                    };                                                                                                      // MakerGen.cs:264
                                }                                                                                                           // MakerGen.cs:366
                            }                                                                                                               // MakerGen.cs:429
                            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                             // MakerGen.cs:414
                            {                                                                                                               // MakerGen.cs:415
                                base.Write(sDef);                                                                                           // MakerGen.cs:416
                                ActionId.Write(sDef);                                                                                       // MakerGen.cs:240
                                Relationship.Write(sDef);                                                                                   // MakerGen.cs:240
                                Offset.Write(sDef);                                                                                         // MakerGen.cs:240
                            }                                                                                                               // MakerGen.cs:433
                        }                                                                                                                   // MakerGen.cs:393
                        public Type_RelatedAction_Elements Elements { get; }                                                                // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                        public Type_RelatedAction()                                                                                         // MakerGen.cs:396
                        {                                                                                                                   // MakerGen.cs:397
                            this.Elements = new Type_RelatedAction_Elements();                                                              // MakerGen.cs:398
                        }                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                 // MakerGen.cs:401
                        {                                                                                                                   // MakerGen.cs:402
                            this.Elements.Write(sDef);                                                                                      // MakerGen.cs:403
                        }                                                                                                                   // MakerGen.cs:404
                    }                                                                                                                       // MakerGen.cs:405
                    // 19. RequestGroup.action.prefix
                    public ElementDefinitionInfo Prefix;                                                                                    // MakerGen.cs:236
                    // 20. RequestGroup.action.title
                    public ElementDefinitionInfo Title;                                                                                     // MakerGen.cs:236
                    // 21. RequestGroup.action.description
                    public ElementDefinitionInfo Description;                                                                               // MakerGen.cs:236
                    // 22. RequestGroup.action.textEquivalent
                    public ElementDefinitionInfo TextEquivalent;                                                                            // MakerGen.cs:236
                    // 23. RequestGroup.action.priority
                    public ElementDefinitionInfo Priority;                                                                                  // MakerGen.cs:236
                    // 24. RequestGroup.action.code
                    public ElementDefinitionInfo Code;                                                                                      // MakerGen.cs:236
                    // 25. RequestGroup.action.documentation
                    public ElementDefinitionInfo Documentation;                                                                             // MakerGen.cs:236
                    // 33. RequestGroup.action.timing[x]
                    public ElementDefinitionInfo Timing;                                                                                    // MakerGen.cs:236
                    // 34. RequestGroup.action.participant
                    public ElementDefinitionInfo Participant;                                                                               // MakerGen.cs:236
                    // 35. RequestGroup.action.type
                    public ElementDefinitionInfo Type;                                                                                      // MakerGen.cs:236
                    // 36. RequestGroup.action.groupingBehavior
                    public ElementDefinitionInfo GroupingBehavior;                                                                          // MakerGen.cs:236
                    // 37. RequestGroup.action.selectionBehavior
                    public ElementDefinitionInfo SelectionBehavior;                                                                         // MakerGen.cs:236
                    // 38. RequestGroup.action.requiredBehavior
                    public ElementDefinitionInfo RequiredBehavior;                                                                          // MakerGen.cs:236
                    // 39. RequestGroup.action.precheckBehavior
                    public ElementDefinitionInfo PrecheckBehavior;                                                                          // MakerGen.cs:236
                    // 40. RequestGroup.action.cardinalityBehavior
                    public ElementDefinitionInfo CardinalityBehavior;                                                                       // MakerGen.cs:236
                    // 41. RequestGroup.action.resource
                    public ElementDefinitionInfo Resource;                                                                                  // MakerGen.cs:236
                    // 42. RequestGroup.action.action
                    public ElementDefinitionInfo Action;                                                                                    // MakerGen.cs:236
                    public Type_Action_Elements()                                                                                           // MakerGen.cs:409
                    {                                                                                                                       // MakerGen.cs:410
                        {                                                                                                                   // MakerGen.cs:251
                            // 19. RequestGroup.action.prefix
                            this.Prefix = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Prefix",                                                                                            // MakerGen.cs:255
                                Path= "RequestGroup.action.prefix",                                                                         // MakerGen.cs:256
                                Id = "RequestGroup.action.prefix",                                                                          // MakerGen.cs:257
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
                            // 20. RequestGroup.action.title
                            this.Title = new ElementDefinitionInfo                                                                          // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Title",                                                                                             // MakerGen.cs:255
                                Path= "RequestGroup.action.title",                                                                          // MakerGen.cs:256
                                Id = "RequestGroup.action.title",                                                                           // MakerGen.cs:257
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
                            // 21. RequestGroup.action.description
                            this.Description = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Description",                                                                                       // MakerGen.cs:255
                                Path= "RequestGroup.action.description",                                                                    // MakerGen.cs:256
                                Id = "RequestGroup.action.description",                                                                     // MakerGen.cs:257
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
                            // 22. RequestGroup.action.textEquivalent
                            this.TextEquivalent = new ElementDefinitionInfo                                                                 // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "TextEquivalent",                                                                                    // MakerGen.cs:255
                                Path= "RequestGroup.action.textEquivalent",                                                                 // MakerGen.cs:256
                                Id = "RequestGroup.action.textEquivalent",                                                                  // MakerGen.cs:257
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
                            // 23. RequestGroup.action.priority
                            this.Priority = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Priority",                                                                                          // MakerGen.cs:255
                                Path= "RequestGroup.action.priority",                                                                       // MakerGen.cs:256
                                Id = "RequestGroup.action.priority",                                                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 24. RequestGroup.action.code
                            this.Code = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Code",                                                                                              // MakerGen.cs:255
                                Path= "RequestGroup.action.code",                                                                           // MakerGen.cs:256
                                Id = "RequestGroup.action.code",                                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 25. RequestGroup.action.documentation
                            this.Documentation = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Documentation",                                                                                     // MakerGen.cs:255
                                Path= "RequestGroup.action.documentation",                                                                  // MakerGen.cs:256
                                Id = "RequestGroup.action.documentation",                                                                   // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.RelatedArtifact                                                       // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 33. RequestGroup.action.timing[x]
                            this.Timing = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Timing",                                                                                            // MakerGen.cs:255
                                Path= "RequestGroup.action.timing[x]",                                                                      // MakerGen.cs:256
                                Id = "RequestGroup.action.timing[x]",                                                                       // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.DateTime                                                            // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    },                                                                                                      // MakerGen.cs:303
                                    new FhirKhit.Maker.Common.Complex.Age                                                                   // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Period                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Duration                                                              // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Range                                                                 // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    },                                                                                                      // MakerGen.cs:359
                                    new FhirKhit.Maker.Common.Complex.Timing                                                                // MakerGen.cs:357
                                    {                                                                                                       // MakerGen.cs:358
                                    }                                                                                                       // MakerGen.cs:359
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 34. RequestGroup.action.participant
                            this.Participant = new ElementDefinitionInfo                                                                    // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Participant",                                                                                       // MakerGen.cs:255
                                Path= "RequestGroup.action.participant",                                                                    // MakerGen.cs:256
                                Id = "RequestGroup.action.participant",                                                                     // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = -1,                                                                                                   // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Patient",                                              // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Practitioner",                                         // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/PractitionerRole",                                     // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/RelatedPerson",                                        // MakerGen.cs:348
                                            "http://hl7.org/fhir/StructureDefinition/Device"                                                // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 35. RequestGroup.action.type
                            this.Type = new ElementDefinitionInfo                                                                           // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Type",                                                                                              // MakerGen.cs:255
                                Path= "RequestGroup.action.type",                                                                           // MakerGen.cs:256
                                Id = "RequestGroup.action.type",                                                                            // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.CodeableConcept                                                       // MakerGen.cs:314
                                    {                                                                                                       // MakerGen.cs:315
                                    }                                                                                                       // MakerGen.cs:318
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 36. RequestGroup.action.groupingBehavior
                            this.GroupingBehavior = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "GroupingBehavior",                                                                                  // MakerGen.cs:255
                                Path= "RequestGroup.action.groupingBehavior",                                                               // MakerGen.cs:256
                                Id = "RequestGroup.action.groupingBehavior",                                                                // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 37. RequestGroup.action.selectionBehavior
                            this.SelectionBehavior = new ElementDefinitionInfo                                                              // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "SelectionBehavior",                                                                                 // MakerGen.cs:255
                                Path= "RequestGroup.action.selectionBehavior",                                                              // MakerGen.cs:256
                                Id = "RequestGroup.action.selectionBehavior",                                                               // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 38. RequestGroup.action.requiredBehavior
                            this.RequiredBehavior = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "RequiredBehavior",                                                                                  // MakerGen.cs:255
                                Path= "RequestGroup.action.requiredBehavior",                                                               // MakerGen.cs:256
                                Id = "RequestGroup.action.requiredBehavior",                                                                // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 39. RequestGroup.action.precheckBehavior
                            this.PrecheckBehavior = new ElementDefinitionInfo                                                               // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "PrecheckBehavior",                                                                                  // MakerGen.cs:255
                                Path= "RequestGroup.action.precheckBehavior",                                                               // MakerGen.cs:256
                                Id = "RequestGroup.action.precheckBehavior",                                                                // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 40. RequestGroup.action.cardinalityBehavior
                            this.CardinalityBehavior = new ElementDefinitionInfo                                                            // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "CardinalityBehavior",                                                                               // MakerGen.cs:255
                                Path= "RequestGroup.action.cardinalityBehavior",                                                            // MakerGen.cs:256
                                Id = "RequestGroup.action.cardinalityBehavior",                                                             // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Primitive.Code                                                                // MakerGen.cs:299
                                    {                                                                                                       // MakerGen.cs:300
                                    }                                                                                                       // MakerGen.cs:303
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 41. RequestGroup.action.resource
                            this.Resource = new ElementDefinitionInfo                                                                       // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Resource",                                                                                          // MakerGen.cs:255
                                Path= "RequestGroup.action.resource",                                                                       // MakerGen.cs:256
                                Id = "RequestGroup.action.resource",                                                                        // MakerGen.cs:257
                                Min = 0,                                                                                                    // MakerGen.cs:258
                                Max = 1,                                                                                                    // MakerGen.cs:259
                                Types = new BaseType[]                                                                                      // MakerGen.cs:260
                                {                                                                                                           // MakerGen.cs:261
                                    new FhirKhit.Maker.Common.Complex.Reference                                                             // MakerGen.cs:345
                                    {                                                                                                       // MakerGen.cs:346
                                        TargetProfile = new String[]                                                                        // MakerGen.cs:348
                                        {                                                                                                   // CodeEditorExtensions.cs:28
                                            "http://hl7.org/fhir/StructureDefinition/Resource"                                              // MakerGen.cs:348
                                        }                                                                                                   // CodeEditorExtensions.cs:34
                                    }                                                                                                       // MakerGen.cs:349
                                }                                                                                                           // MakerGen.cs:263
                            };                                                                                                              // MakerGen.cs:264
                        }                                                                                                                   // MakerGen.cs:366
                        {                                                                                                                   // MakerGen.cs:251
                            // 42. RequestGroup.action.action
                            this.Action = new ElementDefinitionInfo                                                                         // MakerGen.cs:253
                            {                                                                                                               // MakerGen.cs:254
                                Name = "Action",                                                                                            // MakerGen.cs:255
                                Path= "RequestGroup.action.action",                                                                         // MakerGen.cs:256
                                Id = "RequestGroup.action.action",                                                                          // MakerGen.cs:257
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
                        Prefix.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Title.Write(sDef);                                                                                                  // MakerGen.cs:240
                        Description.Write(sDef);                                                                                            // MakerGen.cs:240
                        TextEquivalent.Write(sDef);                                                                                         // MakerGen.cs:240
                        Priority.Write(sDef);                                                                                               // MakerGen.cs:240
                        Code.Write(sDef);                                                                                                   // MakerGen.cs:240
                        Documentation.Write(sDef);                                                                                          // MakerGen.cs:240
                        Timing.Write(sDef);                                                                                                 // MakerGen.cs:240
                        Participant.Write(sDef);                                                                                            // MakerGen.cs:240
                        Type.Write(sDef);                                                                                                   // MakerGen.cs:240
                        GroupingBehavior.Write(sDef);                                                                                       // MakerGen.cs:240
                        SelectionBehavior.Write(sDef);                                                                                      // MakerGen.cs:240
                        RequiredBehavior.Write(sDef);                                                                                       // MakerGen.cs:240
                        PrecheckBehavior.Write(sDef);                                                                                       // MakerGen.cs:240
                        CardinalityBehavior.Write(sDef);                                                                                    // MakerGen.cs:240
                        Resource.Write(sDef);                                                                                               // MakerGen.cs:240
                        Action.Write(sDef);                                                                                                 // MakerGen.cs:240
                    }                                                                                                                       // MakerGen.cs:433
                }                                                                                                                           // MakerGen.cs:393
                public Type_Action_Elements Elements { get; }                                                                               // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
                public Type_Action()                                                                                                        // MakerGen.cs:396
                {                                                                                                                           // MakerGen.cs:397
                    this.Elements = new Type_Action_Elements();                                                                             // MakerGen.cs:398
                }                                                                                                                           // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
                public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                         // MakerGen.cs:401
                {                                                                                                                           // MakerGen.cs:402
                    this.Elements.Write(sDef);                                                                                              // MakerGen.cs:403
                }                                                                                                                           // MakerGen.cs:404
            }                                                                                                                               // MakerGen.cs:405
            // 1. RequestGroup.identifier
            public ElementDefinitionInfo Identifier;                                                                                        // MakerGen.cs:236
            // 2. RequestGroup.instantiatesCanonical
            public ElementDefinitionInfo InstantiatesCanonical;                                                                             // MakerGen.cs:236
            // 3. RequestGroup.instantiatesUri
            public ElementDefinitionInfo InstantiatesUri;                                                                                   // MakerGen.cs:236
            // 4. RequestGroup.basedOn
            public ElementDefinitionInfo BasedOn;                                                                                           // MakerGen.cs:236
            // 5. RequestGroup.replaces
            public ElementDefinitionInfo Replaces;                                                                                          // MakerGen.cs:236
            // 6. RequestGroup.groupIdentifier
            public ElementDefinitionInfo GroupIdentifier;                                                                                   // MakerGen.cs:236
            // 7. RequestGroup.status
            public ElementDefinitionInfo Status;                                                                                            // MakerGen.cs:236
            // 8. RequestGroup.intent
            public ElementDefinitionInfo Intent;                                                                                            // MakerGen.cs:236
            // 9. RequestGroup.priority
            public ElementDefinitionInfo Priority;                                                                                          // MakerGen.cs:236
            // 10. RequestGroup.code
            public ElementDefinitionInfo Code;                                                                                              // MakerGen.cs:236
            // 11. RequestGroup.subject
            public ElementDefinitionInfo Subject;                                                                                           // MakerGen.cs:236
            // 12. RequestGroup.encounter
            public ElementDefinitionInfo Encounter;                                                                                         // MakerGen.cs:236
            // 13. RequestGroup.authoredOn
            public ElementDefinitionInfo AuthoredOn;                                                                                        // MakerGen.cs:236
            // 14. RequestGroup.author
            public ElementDefinitionInfo Author;                                                                                            // MakerGen.cs:236
            // 15. RequestGroup.reasonCode
            public ElementDefinitionInfo ReasonCode;                                                                                        // MakerGen.cs:236
            // 16. RequestGroup.reasonReference
            public ElementDefinitionInfo ReasonReference;                                                                                   // MakerGen.cs:236
            // 17. RequestGroup.note
            public ElementDefinitionInfo Note;                                                                                              // MakerGen.cs:236
            public RequestGroup_Elements()                                                                                                  // MakerGen.cs:409
            {                                                                                                                               // MakerGen.cs:410
                {                                                                                                                           // MakerGen.cs:251
                    // 1. RequestGroup.identifier
                    this.Identifier = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Identifier",                                                                                                // MakerGen.cs:255
                        Path= "RequestGroup.identifier",                                                                                    // MakerGen.cs:256
                        Id = "RequestGroup.identifier",                                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Identifier                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 2. RequestGroup.instantiatesCanonical
                    this.InstantiatesCanonical = new ElementDefinitionInfo                                                                  // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "InstantiatesCanonical",                                                                                     // MakerGen.cs:255
                        Path= "RequestGroup.instantiatesCanonical",                                                                         // MakerGen.cs:256
                        Id = "RequestGroup.instantiatesCanonical",                                                                          // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Canonical                                                                   // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 3. RequestGroup.instantiatesUri
                    this.InstantiatesUri = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "InstantiatesUri",                                                                                           // MakerGen.cs:255
                        Path= "RequestGroup.instantiatesUri",                                                                               // MakerGen.cs:256
                        Id = "RequestGroup.instantiatesUri",                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Primitive.Uri                                                                         // MakerGen.cs:299
                            {                                                                                                               // MakerGen.cs:300
                            }                                                                                                               // MakerGen.cs:303
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 4. RequestGroup.basedOn
                    this.BasedOn = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "BasedOn",                                                                                                   // MakerGen.cs:255
                        Path= "RequestGroup.basedOn",                                                                                       // MakerGen.cs:256
                        Id = "RequestGroup.basedOn",                                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
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
                    // 5. RequestGroup.replaces
                    this.Replaces = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Replaces",                                                                                                  // MakerGen.cs:255
                        Path= "RequestGroup.replaces",                                                                                      // MakerGen.cs:256
                        Id = "RequestGroup.replaces",                                                                                       // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
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
                    // 6. RequestGroup.groupIdentifier
                    this.GroupIdentifier = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "GroupIdentifier",                                                                                           // MakerGen.cs:255
                        Path= "RequestGroup.groupIdentifier",                                                                               // MakerGen.cs:256
                        Id = "RequestGroup.groupIdentifier",                                                                                // MakerGen.cs:257
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
                    // 7. RequestGroup.status
                    this.Status = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Status",                                                                                                    // MakerGen.cs:255
                        Path= "RequestGroup.status",                                                                                        // MakerGen.cs:256
                        Id = "RequestGroup.status",                                                                                         // MakerGen.cs:257
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
                    // 8. RequestGroup.intent
                    this.Intent = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Intent",                                                                                                    // MakerGen.cs:255
                        Path= "RequestGroup.intent",                                                                                        // MakerGen.cs:256
                        Id = "RequestGroup.intent",                                                                                         // MakerGen.cs:257
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
                    // 9. RequestGroup.priority
                    this.Priority = new ElementDefinitionInfo                                                                               // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Priority",                                                                                                  // MakerGen.cs:255
                        Path= "RequestGroup.priority",                                                                                      // MakerGen.cs:256
                        Id = "RequestGroup.priority",                                                                                       // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
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
                    // 10. RequestGroup.code
                    this.Code = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Code",                                                                                                      // MakerGen.cs:255
                        Path= "RequestGroup.code",                                                                                          // MakerGen.cs:256
                        Id = "RequestGroup.code",                                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 11. RequestGroup.subject
                    this.Subject = new ElementDefinitionInfo                                                                                // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Subject",                                                                                                   // MakerGen.cs:255
                        Path= "RequestGroup.subject",                                                                                       // MakerGen.cs:256
                        Id = "RequestGroup.subject",                                                                                        // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = 1,                                                                                                            // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Patient",                                                      // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Group"                                                         // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 12. RequestGroup.encounter
                    this.Encounter = new ElementDefinitionInfo                                                                              // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Encounter",                                                                                                 // MakerGen.cs:255
                        Path= "RequestGroup.encounter",                                                                                     // MakerGen.cs:256
                        Id = "RequestGroup.encounter",                                                                                      // MakerGen.cs:257
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
                    // 13. RequestGroup.authoredOn
                    this.AuthoredOn = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "AuthoredOn",                                                                                                // MakerGen.cs:255
                        Path= "RequestGroup.authoredOn",                                                                                    // MakerGen.cs:256
                        Id = "RequestGroup.authoredOn",                                                                                     // MakerGen.cs:257
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
                    // 14. RequestGroup.author
                    this.Author = new ElementDefinitionInfo                                                                                 // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Author",                                                                                                    // MakerGen.cs:255
                        Path= "RequestGroup.author",                                                                                        // MakerGen.cs:256
                        Id = "RequestGroup.author",                                                                                         // MakerGen.cs:257
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
                                    "http://hl7.org/fhir/StructureDefinition/PractitionerRole"                                              // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 15. RequestGroup.reasonCode
                    this.ReasonCode = new ElementDefinitionInfo                                                                             // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ReasonCode",                                                                                                // MakerGen.cs:255
                        Path= "RequestGroup.reasonCode",                                                                                    // MakerGen.cs:256
                        Id = "RequestGroup.reasonCode",                                                                                     // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.CodeableConcept                                                               // MakerGen.cs:314
                            {                                                                                                               // MakerGen.cs:315
                            }                                                                                                               // MakerGen.cs:318
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 16. RequestGroup.reasonReference
                    this.ReasonReference = new ElementDefinitionInfo                                                                        // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "ReasonReference",                                                                                           // MakerGen.cs:255
                        Path= "RequestGroup.reasonReference",                                                                               // MakerGen.cs:256
                        Id = "RequestGroup.reasonReference",                                                                                // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Reference                                                                     // MakerGen.cs:345
                            {                                                                                                               // MakerGen.cs:346
                                TargetProfile = new String[]                                                                                // MakerGen.cs:348
                                {                                                                                                           // CodeEditorExtensions.cs:28
                                    "http://hl7.org/fhir/StructureDefinition/Condition",                                                    // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/Observation",                                                  // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/DiagnosticReport",                                             // MakerGen.cs:348
                                    "http://hl7.org/fhir/StructureDefinition/DocumentReference"                                             // MakerGen.cs:348
                                }                                                                                                           // CodeEditorExtensions.cs:34
                            }                                                                                                               // MakerGen.cs:349
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
                {                                                                                                                           // MakerGen.cs:251
                    // 17. RequestGroup.note
                    this.Note = new ElementDefinitionInfo                                                                                   // MakerGen.cs:253
                    {                                                                                                                       // MakerGen.cs:254
                        Name = "Note",                                                                                                      // MakerGen.cs:255
                        Path= "RequestGroup.note",                                                                                          // MakerGen.cs:256
                        Id = "RequestGroup.note",                                                                                           // MakerGen.cs:257
                        Min = 0,                                                                                                            // MakerGen.cs:258
                        Max = -1,                                                                                                           // MakerGen.cs:259
                        Types = new BaseType[]                                                                                              // MakerGen.cs:260
                        {                                                                                                                   // MakerGen.cs:261
                            new FhirKhit.Maker.Common.Complex.Annotation                                                                    // MakerGen.cs:357
                            {                                                                                                               // MakerGen.cs:358
                            }                                                                                                               // MakerGen.cs:359
                        }                                                                                                                   // MakerGen.cs:263
                    };                                                                                                                      // MakerGen.cs:264
                }                                                                                                                           // MakerGen.cs:366
            }                                                                                                                               // MakerGen.cs:429
            public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                             // MakerGen.cs:414
            {                                                                                                                               // MakerGen.cs:415
                base.Write(sDef);                                                                                                           // MakerGen.cs:416
                Identifier.Write(sDef);                                                                                                     // MakerGen.cs:240
                InstantiatesCanonical.Write(sDef);                                                                                          // MakerGen.cs:240
                InstantiatesUri.Write(sDef);                                                                                                // MakerGen.cs:240
                BasedOn.Write(sDef);                                                                                                        // MakerGen.cs:240
                Replaces.Write(sDef);                                                                                                       // MakerGen.cs:240
                GroupIdentifier.Write(sDef);                                                                                                // MakerGen.cs:240
                Status.Write(sDef);                                                                                                         // MakerGen.cs:240
                Intent.Write(sDef);                                                                                                         // MakerGen.cs:240
                Priority.Write(sDef);                                                                                                       // MakerGen.cs:240
                Code.Write(sDef);                                                                                                           // MakerGen.cs:240
                Subject.Write(sDef);                                                                                                        // MakerGen.cs:240
                Encounter.Write(sDef);                                                                                                      // MakerGen.cs:240
                AuthoredOn.Write(sDef);                                                                                                     // MakerGen.cs:240
                Author.Write(sDef);                                                                                                         // MakerGen.cs:240
                ReasonCode.Write(sDef);                                                                                                     // MakerGen.cs:240
                ReasonReference.Write(sDef);                                                                                                // MakerGen.cs:240
                Note.Write(sDef);                                                                                                           // MakerGen.cs:240
            }                                                                                                                               // MakerGen.cs:433
        }                                                                                                                                   // MakerGen.cs:393
        public RequestGroup_Elements Elements { get; }                                                                                      // MakerGen.cs:394
                                                                                                                                            // MakerGen.cs:395
        public RequestGroup()                                                                                                               // MakerGen.cs:396
        {                                                                                                                                   // MakerGen.cs:397
            this.Elements = new RequestGroup_Elements();                                                                                    // MakerGen.cs:398
        }                                                                                                                                   // MakerGen.cs:399
                                                                                                                                            // MakerGen.cs:400
        public override void Write(Hl7.Fhir.Model.StructureDefinition sDef)                                                                 // MakerGen.cs:401
        {                                                                                                                                   // MakerGen.cs:402
            this.Elements.Write(sDef);                                                                                                      // MakerGen.cs:403
        }                                                                                                                                   // MakerGen.cs:404
    }                                                                                                                                       // MakerGen.cs:405
}                                                                                                                                           // MakerGen.cs:468
